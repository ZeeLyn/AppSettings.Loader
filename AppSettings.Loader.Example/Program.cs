using System;

namespace AppSettings.Loader.Example
{
	class Program
	{
		static void Main(string[] args)
		{
			AppSettingsRegister.BindJsonFile("appsettings.json");

			Console.WriteLine(SettingsLoader<AppSettings>.Get().GetHashCode());
			Console.WriteLine("Hello World!");
			Console.WriteLine(SettingsLoader<Cnf>.Get().GetHashCode());
			Console.WriteLine("Hello World!");
			Console.WriteLine(SettingsLoader<AppSettings>.Get().GetHashCode());
			Console.WriteLine("Hello World!");
			Console.WriteLine(SettingsLoader<Cnf>.Get().Code);


			Console.ReadKey();
		}
	}
}
