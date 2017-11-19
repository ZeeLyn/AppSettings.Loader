using System;

namespace AppSettings.Loader.Example
{
	class Program
	{
		static void Main(string[] args)
		{
			AppSettingsRegister.BindJsonFile("appsettings.json");

			//Console.WriteLine(AppSettingsReader<AppSettings>.Get().GetHashCode());
			//Console.WriteLine("Hello World!");
			//Console.WriteLine(AppSettingsReader<Cnf>.Get().GetHashCode());
			//Console.WriteLine("Hello World!");
			//Console.WriteLine(AppSettingsReader<AppSettings>.Get().GetHashCode());
			//Console.WriteLine("Hello World!");
			//Console.WriteLine(AppSettingsReader<Cnf>.Get().Code);

			Console.WriteLine(AppSettings.Get.Version);

			//AppSettings.Get.Version;
			Console.ReadKey();
		}
	}
}
