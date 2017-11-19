using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AppSettings.Loader.Example
{
	public class AppSettings : AppSettingLoader<AppSettings>
	{
		public int Version { get; set; }
	}
}
