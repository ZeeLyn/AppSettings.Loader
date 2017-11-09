using Microsoft.AspNetCore.Builder;

namespace AppSettings.Loader.MVC
{
	public static class AppSettingsBuilder
	{
		public static void AddAppSettingsJsonFile(this IApplicationBuilder builder, string jsonfilepath)
		{
			AppSettingsRegister.BindJsonFile(jsonfilepath);
		}
	}
}
