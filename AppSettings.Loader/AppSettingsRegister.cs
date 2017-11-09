namespace AppSettings.Loader
{


	public class AppSettingsRegister
	{
		protected internal static string JsonPath { get; private set; } = "appsettings.json";

		public static void RegisterSettings(string jsonpath)
		{
			JsonPath = jsonpath;
		}
	}
}
