using System;

namespace AppSettings.Loader
{
	public class AppSettingsRegister
	{
		protected internal static string JsonPath { get; private set; } = "appsettings.json";

		protected internal static bool ReloadOnChange { get; private set; } = true;

		/// <summary>
		/// 设置json文件
		/// </summary>
		/// <param name="jsonpath">json文件的路径</param>
		/// <param name="reloadOnChange">当文件被修改时是否自动重新加载</param>
		public static void BindJsonFile(string jsonpath, bool reloadOnChange = true)
		{
			if (string.IsNullOrWhiteSpace(jsonpath))
				throw new ArgumentNullException("json路路径不能为空");
			JsonPath = jsonpath;
			ReloadOnChange = reloadOnChange;
		}
	}
}
