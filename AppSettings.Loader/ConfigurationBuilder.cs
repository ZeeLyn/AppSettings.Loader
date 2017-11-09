using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace AppSettings.Loader
{
	public static class ConfigurationBuilder
	{
		public static IConfigurationBuilder AddConfig(this IConfigurationBuilder builder, string configfilepath)
		{
			AppSettingsRegister.RegisterSettings(configfilepath);
			return builder;
		}
	}
}
