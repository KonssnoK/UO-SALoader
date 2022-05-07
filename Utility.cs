using Microsoft.Win32;
using System;
using System.IO;

namespace UoKRLoader
{
	internal class Utility
	{
		public static string GetExePath(string subName)
		{
			bool Is64Bit = (IntPtr.Size == 8);
			try
			{
				if (Is64Bit)
					subName = @"Wow6432Node\" + subName;
				RegistryKey key = Registry.LocalMachine.OpenSubKey(string.Format(@"SOFTWARE\{0}", subName));
				if (key == null)
				{
					key = Registry.CurrentUser.OpenSubKey(string.Format(@"SOFTWARE\{0}", subName));
					if (key == null)
					{
						return null;
					}
				}
				string path = key.GetValue("ExePath") as string;
				if (((path == null) || (path.Length <= 0)) || (!Directory.Exists(path) && !File.Exists(path)))
				{
					path = key.GetValue("InstallDir") as string;
					if (((path == null) || (path.Length <= 0)) || (!Directory.Exists(path) && !File.Exists(path)))
					{
						return null;
					}
				}
				else
				{
					path = Path.GetDirectoryName(path);
				}
				if ((path == null) || !Directory.Exists(path))
				{
					return null;
				}
				return path;
			}
			catch
			{
				return null;
			}
		}

		public static int Search(Stream pc, byte[] buffer, bool bFile) {
			return Search(pc, buffer, bFile, 0);
		}

		public static int Search(Stream pc, byte[] buffer, bool bFile, int StartingFrom)
		{
			int StartingOffset = bFile ? 0 : 0x400000;
			if (StartingFrom > 0)
				StartingOffset = StartingFrom + buffer.Length;

			int count = 0x1000 + buffer.Length;
			byte[] filepart = new byte[count];

			for (int curr = 0; ; ++curr) {
				//Get 0x1000 file part
				pc.Seek((long)(StartingOffset + (curr * 0x1000)), SeekOrigin.Begin);
				//End of File
				if (pc.Read(filepart, 0, count) != count) {
					return 0;
				}
				for (int i = 0; i < 0x1000; i++) {
					bool found = true;
					for (int j = 0; found && (j < buffer.Length); j++) {
						found = (buffer[j] == filepart[i + j]);
					}
					if (found) {
						//Found
						return ((StartingOffset + (curr * 0x1000)) + i);
					}
				}
			}
		}

		public static int VersionToInteger(string version)
		{
			string[] strArray = version.Split(new char[] { '.' });
			int num = -1;
			try
			{
				num = ((int.Parse(strArray[3]) + (int.Parse(strArray[2]) * 100)) + (int.Parse(strArray[1]) * 0x2710)) + (int.Parse(strArray[0]) * 0xf4240);
			}
			catch
			{
			}
			return num;
		}
	}
}