using System;
using System.IO;
using System.Text;
using Microsoft.Extensions.FileProviders;
using Newtonsoft.Json;

namespace AppSettings.Loader
{
	public class AppSettingsReader<T>
	{
		private static readonly object Lock = new object();
		private static T Instance { get; set; }

		private AppSettingsReader()
		{
		}

		static AppSettingsReader()
		{
			if (AppSettingsRegister.ReloadOnChange)
				FileManager.AddChangeListen(AppSettingsRegister.JsonPath, ReadSettings);
		}

		public static T Get()
		{
			if (Instance != null)
				return Instance;
			lock (Lock)
			{
				if (Instance == null)
					ReadSettings();
			}
			return Instance;
		}

		public static void Rest()
		{
			Instance = default;
		}

		private static void ReadSettings()
		{
			var path = Path.Combine(Directory.GetCurrentDirectory(), AppSettingsRegister.JsonPath);
			if (!File.Exists(path))
				throw new FileNotFoundException($"未找到配置文件:{path}");
			Instance = JsonConvert.DeserializeObject<T>(File.ReadAllText(path, Encoding.UTF8));
		}
	}
}
