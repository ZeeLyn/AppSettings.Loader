using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace AppSettings.Loader
{
	public class SettingsLoader<T>
	{
		private static readonly object Lock = new object();
		private static T Instance { get; set; }

		private SettingsLoader()
		{
		}
		public static T Get()
		{
			if (Instance != null)
				return Instance;
			lock (Lock)
			{
				if (Instance == null)
					Instance = ReadSettings();
			}
			return Instance;
		}

		public static void Rest()
		{
			Instance = default;
		}

		private static T ReadSettings()
		{
			var path = Path.Combine(Directory.GetCurrentDirectory(), AppSettingsRegister.JsonPath);
			if (!File.Exists(path))
				throw new FileNotFoundException($"未找到配置文件:{AppSettingsRegister.JsonPath}");
			return JsonConvert.DeserializeObject<T>(File.ReadAllText(path, Encoding.UTF8));
		}
	}
}
