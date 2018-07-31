# AppSettings.Loader
Json配置加载器

默认配置文件的目录是项目的根目录，文件名appsettings.json

## 自定义json文件路径

mvc配置方法
```csharp
public void ConfigureServices(IServiceCollection services, IHostingEnvironment env)
{
	services.AddAppSettingsJsonFile($"appsettings.{env.EnvironmentName}.json",reloadOnChange:true);
}
```

其他项目的配置方法
```csharp
static void Main(string[] args)
{
	AppSettingsRegister.BindJsonFile("appsettings.json",reloadOnChange:true);
}
```

## 建立实体类与json文件映射
```csharp
public class AppSetting : AppSettingLoader<AppSetting>
{
	public int Version { get; set; }
}
```
## 使用
```csharp
AppSetting.Get.Version;
```

