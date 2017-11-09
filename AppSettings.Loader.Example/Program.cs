using System;

namespace AppSettings.Loader.Example
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(SettingsLoader<AppSettings>.Get().GetHashCode());
			Console.WriteLine("Hello World!");
			Console.WriteLine(SettingsLoader<Cnf>.Get().GetHashCode());
			Console.WriteLine("Hello World!");
			Console.WriteLine(SettingsLoader<AppSettings>.Get().GetHashCode());
			Console.WriteLine("Hello World!");
			Console.WriteLine(SettingsLoader<Cnf>.Get().GetHashCode());


			Console.ReadKey();
		}
	}
}
