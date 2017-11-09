using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace AppSettings.Loader
{
	public static class AppSettingsBuilder
	{
		public static IConfigurationBuilder AddAppSettingsJsonFile(this IConfigurationBuilder builder, string jsonfilepath)
		{
			AppSettingsRegister.BindJsonFile(jsonfilepath);
			return builder;
		}
	}
}
