using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AppSettings.Loader.Example
{
	public class AppSettings
	{
		[JsonIgnore]
		public static AppSettings Get => SettingsLoader<AppSettings>.Get();

		public static void Rest()
		{
			SettingsLoader<AppSettings>.Rest();
		}



		public int Version { get; set; }
	}
}
