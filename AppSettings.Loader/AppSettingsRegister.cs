using System;

namespace AppSettings.Loader
{


	public class AppSettingsRegister
	{
		protected internal static string JsonPath { get; private set; } = "appsettings.json";

		public static void BindJsonFile(string jsonpath)
		{
			if (string.IsNullOrWhiteSpace(jsonpath))
				throw new ArgumentNullException("json路路径不能为空");
			JsonPath = jsonpath;
		}
	}
}
