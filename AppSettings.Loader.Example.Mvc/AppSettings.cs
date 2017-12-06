using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppSettings.Loader.Example.Mvc
{
	public class AppSettings : AppSettingLoader<AppSettings>
	{
		public string Version { get; set; }
	}
}
