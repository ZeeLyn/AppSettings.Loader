using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AppSettings.Loader.MVC
{
	public static class AppSettingsBuilder
	{
		/// <summary>
		/// 设置配置文件
		/// </summary>
		/// <param name="builder"></param>
		/// <param name="jsonfilepath">json文件路径</param>
		/// <param name="reloadOnChange">文件被修改时是否自动重新加载</param>
		public static void AddAppSettingsJsonFile(this IApplicationBuilder builder, string jsonfilepath, bool reloadOnChange = true)
		{
			AppSettingsRegister.BindJsonFile(jsonfilepath, reloadOnChange);
		}

		/// <summary>
		/// 设置配置文件
		/// </summary>
		/// <param name="builder"></param>
		/// <param name="jsonfilepath">json文件路径</param>
		/// <param name="reloadOnChange">文件被修改时是否自动重新加载</param>
		public static IConfiguration AddAppSettingsJsonFile(this IConfiguration builder, string jsonfilepath, bool reloadOnChange = true)
		{
			AppSettingsRegister.BindJsonFile(jsonfilepath, reloadOnChange);
			return builder;
		}

		/// <summary>
		/// 设置配置文件
		/// </summary>
		/// <param name="builder"></param>
		/// <param name="jsonfilepath">json文件路径</param>
		/// <param name="reloadOnChange">文件被修改时是否自动重新加载</param>
		public static IServiceCollection AddAppSettingsJsonFile(this IServiceCollection builder, string jsonfilepath, bool reloadOnChange = true)
		{
			AppSettingsRegister.BindJsonFile(jsonfilepath, reloadOnChange);
			return builder;
		}
	}
}
