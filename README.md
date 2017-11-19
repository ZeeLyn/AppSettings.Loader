# AppSettings.Loader
Json配置加载器

默认配置文件的目录是项目的根目录，文件名appsettings.json

## 自定义json文件路径

mvc配置方法
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
```

其他项目的配置方法
```csharp
static void Main(string[] args)
{
	AppSettingsRegister.BindJsonFile("appsettings.json");
}
```

## 与json文件映射
```csharp
public class AppSettings : AppSettingLoader<AppSettings>
{
	public int Version { get; set; }
}
```
## 使用
```csharp
AppSettings.Get.Version;
```

