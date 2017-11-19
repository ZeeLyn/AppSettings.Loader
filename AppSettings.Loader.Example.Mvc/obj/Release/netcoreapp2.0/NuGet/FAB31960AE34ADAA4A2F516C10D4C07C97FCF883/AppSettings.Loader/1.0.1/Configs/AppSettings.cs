using AppSettings.Loader;

namespace AppSettings.Loader.Example.Mvc
{
	public class AppSettings
	{
		[JsonIgnore]
		public static AppSettings Get => SettingsLoader<AppSettings>.Get();

		
		public static void Rest()
		{
			SettingsLoader<AppSettings>.Rest();
		}

		// TODO 再此定义具体的配置属性
	}
}
