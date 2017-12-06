using System;
using System.IO;
using System.Text;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Primitives;

namespace AppSettings.Loader
{
	public class FileManager
	{
		private static IFileProvider FileProvider { get; }

		private FileManager()
		{
		}

		static FileManager()
		{
			FileProvider = new PhysicalFileProvider(Directory.GetCurrentDirectory());
		}

		//public static string ReadFile(string filename)
		//{
		//	using (var stream = FileProvider.GetFileInfo(filename).CreateReadStream())
		//	{
		//		var buffer = new byte[stream.Length];
		//		stream.Read(buffer, 0, buffer.Length);
		//		return Encoding.Default.GetString(buffer);
		//	}
		//}
		///// <summary>
		///// 
		///// </summary>
		///// <param name="filename"></param>
		///// <returns></returns>
		//public static bool Exists(string filename)
		//{
		//	return FileProvider.GetFileInfo(filename).Exists;
		//}

		/// <summary>
		/// 监听文件是否被修改
		/// </summary>
		/// <param name="filename">文件名</param>
		/// <param name="onChanged">文件被修改时回调</param>
		public static void AddChangeListen(string filename, Action onChanged)
		{
			ChangeToken.OnChange(() => FileProvider.Watch(filename), onChanged);
		}
	}
}
