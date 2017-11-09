# AppSettings.Loader
Json配置加载器

默认配置文件的目录是项目的根目录，文件名appsettings.json

## 配置
```csharp
public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
	if (env.IsDevelopment())
	{
		app.UseDeveloperExceptionPage();
	}
	app.AddAppSettingsJsonFile($"appsettings.{env.EnvironmentName}.json");
	app.UseMvc();
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

