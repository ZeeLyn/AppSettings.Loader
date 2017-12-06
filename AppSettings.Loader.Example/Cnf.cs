using System;
using System.Collections.Generic;
using System.Text;

namespace AppSettings.Loader.Example
{
	public class Cnf : AppSettingLoader<Cnf>
	{
		public string Code { get; set; }
	}
}
