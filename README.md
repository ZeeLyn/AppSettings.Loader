# AppSettings.Loader
Json配置加载器

默认配置文件的目录是项目的根目录，文件名appsettings.json


```csharp
public Startup(IHostingEnvironment env)
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(env.ContentRootPath)
				.AddJsonFile("appsettings.json", false, true)
				.AddJsonFile($"appsettings.{env.EnvironmentName}.json", true)
				.AddConfig($"Configs/AppSettings.{env.EnvironmentName}.json")
				.AddEnvironmentVariables();
			Configuration = builder.Build();
		}
    
    
    
    static void Main(string[] args)
		{
			AppSettingsRegister.BindJsonFile("appsettings.json");
		}
```

## 读取
```csharp
public class AppSettings
	{
		[JsonIgnore]
		public static AppSettings Get => SettingsLoader<AppSettings>.Get();

		public static void Rest()
		{
			SettingsLoader<AppSettings>.Rest();
		}



		public int Version { get; set; }
	}
  
  AppSettings.Get.Version;
```

