using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppSettings.Loader.Example.Mvc
{
	public class AppSettings
	{
		[JsonIgnore]
		public static AppSettings Get => SettingsLoader<AppSettings>.Get();


		public static void Rest()
		{
			SettingsLoader<AppSettings>.Rest();
		}

		public string Version { get; set; }
	}
}
