using System;

namespace AppSettings.Loader.Example
{
	class Program
	{
		static void Main(string[] args)
		{
			AppSettingsRegister.BindJsonFile("appsettings.json");

			Console.WriteLine(AppSettings.Get.Version);
			Console.WriteLine(Cnf.Get.Code);
			//AppSettings.Get.Version;
			var key = Console.ReadKey();
			if (key.KeyChar == 'r')
			{
				Console.WriteLine();
				Console.WriteLine(AppSettings.Get.Version);
				Console.WriteLine(Cnf.Get.Code);
			}
			Console.ReadKey();
		}
	}
}
