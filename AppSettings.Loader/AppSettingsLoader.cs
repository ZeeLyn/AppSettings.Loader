using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AppSettings.Loader
{
	public class AppSettingLoader<T> where T : class, new()
	{
		/// <summary>
		/// 获取appsettings
		/// </summary>
		[JsonIgnore]
		public static T Get => AppSettingsReader<T>.Get();

		/// <summary>
		/// 重置appsettings
		/// </summary>
		public static void Rest()
		{
			AppSettingsReader<T>.Rest();
		}
	}
}
