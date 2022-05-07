using System;
using System.Collections.Generic;
using System.Net;

namespace UoKRLoader {
	internal class StaticData {
		public const string KRLOADER_SITE = "http://code.google.com/p/kprojects/";
		public const string LAUNCH_CFG = "login.cfg";

		#region SA
		public const string UOSA_CLIENT = @"\uosa.exe";
		public const string UOSA_PATCHCLIENT = @"\uosa.patched.exe";
		public const string UOSA_REGKEY = @"Electronic Arts\EA Games\Ultima Online Stygian Abyss";
		public const string UOHS_REGKEY = @"Electronic Arts\EA Games\Ultima Online High Seas Enhanced BETA";
		public const string UOEC_REGKEY = @"Electronic Arts\EA Games\Ultima Online Enhanced";
		#endregion

		private static byte[] UOKR_IPDATA_0 = new byte[] { 
            0x6a, 0x39, 0x68, 0x99, 0, 0, 0, 0x68, 0x9f, 0, 0, 0, 0x56, 0xb1, 0xc4, 0xe8, 
            0xc7, 0xff, 0xff, 0xff, 0x66, 0xc7, 70, 4, 0x5f, 30, 0xc3, 0x66, 0xc7, 0x40, 4, 0x5f, 
            30
         };
		private static byte[] UOKR_IPDATA_1a = new byte[] { 0xc7, 0x44, 0x24, 12, 0x39, 0xc4, 0x99, 0x9f, 0x66, 0xc7, 0x44, 0x24, 0x10, 0x5f, 30 };
		private static byte[] UOKR_IPDATA_1b = new byte[] { 
            0xc7, 0, 0x39, 0xc4, 0x99, 0x9f, 0x66, 0xc7, 0x40, 4, 0x5f, 30, 0xc3, 0xcc, 0xcc, 0xcc, 
            0x66, 0xc7, 0x40, 4, 0x5f, 30
         };
		private static byte[] UOKR_IPDATA_2a = new byte[] { 0xc7, 0x44, 0x24, 0x10, 0x39, 0xc4, 0x99, 0x9f, 0x66, 0xc7, 0x44, 0x24, 20, 0x5f, 30 };
		private static byte[] UOKR_IPDATA_2b = new byte[] { 
            0xc7, 0, 0x39, 0xc4, 0x99, 0x9f, 0x66, 0xc7, 0x40, 4, 0x5f, 30, 0xc3, 0xcc, 0xcc, 0xcc, 
            0x66, 0xc7, 0x40, 4, 0x5f, 30
         };
		private static byte[] UOKR_IPDATA_3a = new byte[] { 0xc7, 0x44, 0x24, 0x10, 0x29, 0xc4, 0x99, 0x9f, 0x66, 0xc7, 0x44, 0x24, 20, 0x5f, 30 };
		private static byte[] UOKR_IPDATA_3b = new byte[] { 
            0xc7, 0, 0x29, 0xc4, 0x99, 0x9f, 0x66, 0xc7, 0x40, 4, 0x5f, 30, 0xc3, 0xcc, 0xcc, 0xcc, 
            0x66, 0xc7, 0x40, 4, 0x5f, 30
         };

		#region SA
		private static byte[] UOSA_IPDATA_1a = new byte[] { 0xC7, 0x44, 0x24, 0x10, 0x4F, 0xD1, 0x99, 0x9F, 0x66, 0xC7, 0x44, 0x24, 0x14, 0x5F, 0x1E };
		private static byte[] UOSA_IPDATA_1b = new byte[] { 0xC7, 0x00, 0x4F, 0xD1, 0x99, 0x9F, 0x66, 0xC7, 0x40, 0x04, 0x5F, 0x1E, 0xC3, 0xCC, 0xCC, 0xCC, 0x66, 0xC7, 0x40, 0x04, 0x5F, 0x1E };

		private static byte[] UOSA_IPDATA_2a = new byte[] { 0xC7, 0x44, 0x24, 0x10, 0x4F, 0xD1, 0x99, 0x9F };
		private static byte[] UOSA_IPDATA_2b = new byte[] { 0xC7, 0x44, 0x24, 0x10, 0x3A, 0x24, 0x12, 0x0A };
		private static byte[] UOSA_PORTDATA_2a = new byte[] { 0x66, 0xC7, 0x44, 0x24, 0x14, 0x5F, 0x1E };

		private static byte[] UOSA_IPDATA_3 = new byte[] { 0x6C, 0x6F, 0x67, 0x69, 0x6E, 0x2E, 0x75, 0x6C, 0x74, 0x69, 0x6D, 0x61, 0x6F, 0x6E, 0x6C, 0x69, 0x6E, 0x65, 0x2E, 0x63, 0x6F, 0x6D, 0x00 };
		private static byte[] UOSA_PORTDATA_3 = new byte[] { 0x66, 0xC7, 0x44, 0x24, 0x18, 0x5F, 0x1E };

		private static byte[] UOSA_IPDATA_2a_Fake = new byte[] { 0xC7, 0x44, 0x54, 0x10, 0x4F, 0xD1, 0x99, 0x9F };
		private static byte[] UOSA_IPDATA_2b_Fake = new byte[] { 0xC7, 0x44, 0x24, 0x40, 0x3A, 0x24, 0x12, 0x0A };
		private static byte[] UOSA_PORTDATA_2a_Fake = new byte[] { 0x66, 0xC7, 0x44, 0x27, 0x14, 0x5F, 0x1E };
		private static byte[] UOSA_IPDATA_2a_Fake_Fake = new byte[] { 0xC7, 0x44, 0x24, 0x10, 0x4F, 0xD1, 0x99, 0x9F };
		private static byte[] UOSA_IPDATA_2b_Fake_Fake = new byte[] { 0xC7, 0x44, 0x24, 0x10, 0x3A, 0x84, 0x12, 0x0A };
		private static byte[] UOSA_PORTDATA_2a_Fake_Fake = new byte[] { 0x66, 0xC7, 0x48, 0x24, 0x14, 0x5F, 0x1E };
		private static byte[] UOSA_IPDATA_Fake = new byte[] { 0xC7, 0x44, 0x24, 0x00, 0x4F, 0xD1, 0x79, 0x9F, 0x66, 0xC7, 0x44, 0x24, 0x14, 0x5F, 0x1E };
		private static byte[] UOSA_IPDATA_Fake2 = new byte[] { 0xC7, 0x44, 0x24, 0x13, 0x4F, 0xD2, 0x99, 0x9F, 0x66, 0xC7, 0x44, 0x24, 0x14, 0x5F, 0x1E };
		private static byte[] UOSA_IPDATA_Fake3 = new byte[] { 0xC7, 0x00, 0x4F, 0xD1, 0x99, 0x7F, 0x66, 0xC7, 0x40, 0x04, 0x6F, 0x1E, 0xC3, 0xCC, 0xCC, 0xCC, 0x66, 0xC7, 0x40, 0x04, 0x5F, 0x1E };
		private static byte[] UOSA_IPDATA_Fake4 = new byte[] { 0xC7, 0x00, 0x4F, 0xD2, 0x99, 0x9F, 0x66, 0xC7, 0x40, 0x04, 0x5F, 0x1E, 0xC3, 0xDC, 0xCC, 0xCC, 0x66, 0xC7, 0x40, 0x04, 0x5F, 0x1E };
		#endregion

		//public static byte[] UOKR_LOGDATA_0 = new byte[] { 0x8a, 0x4f, 4, 0x30, 8, 0x8b, 0x4f, 4, 0x8b, 0x47, 8, 0xff, 0x45, 240, 0x8b, 0xd0 };
		//public static byte[] UOKR_LOGDATA_1 = new byte[] { 0x8a, 0x4e, 4, 0x30, 8, 0x8b, 0x4e, 4, 0x8b, 70, 8, 0x8b, 0xd0, 0xd1, 0xe8 };

		#region SA
		/*public static byte[] UOSA_GAMEDATA_Send = new byte[] { 0x00, 0x00, 0x00, 0x5E, 0x8B, 0x93, 0x4C, 0x12, 0x00, 0x00, 0x8A, 0x84, 0x1A, 0x4C, 0x11, 0x00, 0x00, 0x30, 0x45, 0x00, 0x83, 0x83, 0x4C, 0x12, 0x00, 0x00, 0x01 };
		public static byte[] UOSA_GAMEDATA_Receive = new byte[] { 0x8A, 0x54, 0x31, 0x08, 0x30, 0x10, 0x83, 0x46, 0x18, 0x01, 0x8B, 0x45, 0x0C, 0x83, 0xC7, 0x01, 0x3B, 0xFB, 0x72, 0xD5, 0x01, 0x5E, 0x04, 0x8B, 0x7D, 0x08, 0x8B, 0x75, 0x10, 0x85, 0xF6, 0x89, 0x07, 0x89, 0x77, 0x04 };

		public static byte[] GetSAPatchedGameData_Send() {
			byte[] array = new byte[UOSA_GAMEDATA_Send.Length];
			UOSA_GAMEDATA_Send.CopyTo(array, 0);

			array[17] = 0x90;//XOR
			array[18] = 0x90;
			array[19] = 0x90;
			return array;
		}

		public static byte[] GetSAPatchedGameData_Receive() {
			byte[] array = new byte[UOSA_GAMEDATA_Receive.Length];
			UOSA_GAMEDATA_Receive.CopyTo(array, 0);

			array[04] = 0x90;//XOR
			array[05] = 0x90;

			return array;
		}*/
		#endregion


		public static List<byte[]> GetIPData(int iVersion) {
			List<byte[]> list = new List<byte[]>();
			switch (iVersion) {
				case 0:
					list.Add(UOKR_IPDATA_0);
					return list;

				case 1:
					list.Add(UOKR_IPDATA_1a);
					list.Add(UOKR_IPDATA_1b);
					return list;

				case 2:
					list.Add(UOKR_IPDATA_2a);
					list.Add(UOKR_IPDATA_2b);
					return list;

				case 3:
					list.Add(UOKR_IPDATA_3a);
					list.Add(UOKR_IPDATA_3b);
					return list;
				case 4:
					list.Add(UOSA_IPDATA_1a);
					list.Add(UOSA_IPDATA_1b);
					return list;
				case 5:
					list.Add(UOSA_IPDATA_2a);
					list.Add(UOSA_IPDATA_2b);
					list.Add(UOSA_PORTDATA_2a);
					return list;
				case 6:
					list.Add(UOSA_IPDATA_3);
					list.Add(UOSA_PORTDATA_3);
					return list;
			}
			return list;
		}

		/*public static byte[] GetLoginData(int iVersion) {
			switch (iVersion) {
				case 0:
					return UOKR_LOGDATA_0;

				case 1:
					return UOKR_LOGDATA_1;
			}
			return null;
		}*/

		public static List<byte[]> GetPatchedIPData(int iVersion, IPAddress theIP, uint thePort) {
			List<byte[]> list = new List<byte[]>();
			switch (iVersion) {
				case 0: {
						byte[] array = new byte[UOKR_IPDATA_0.Length];
						UOKR_IPDATA_0.CopyTo(array, 0);
						array[1] = theIP.GetAddressBytes()[3];
						array[3] = theIP.GetAddressBytes()[1];
						array[8] = theIP.GetAddressBytes()[0];
						array[14] = theIP.GetAddressBytes()[2];
						array[0x18] = (byte)(thePort & 0xff);
						array[0x19] = (byte)((thePort & 0xff00) >> 8);
						array[30] = (byte)(thePort & 0xff);
						array[0x1f] = (byte)((thePort & 0xff00) >> 8);
						list.Add(array);
						return list;
					}
				case 1: {
						byte[] buffer5 = new byte[UOKR_IPDATA_1a.Length];
						UOKR_IPDATA_1a.CopyTo(buffer5, 0);
						buffer5[4] = theIP.GetAddressBytes()[3];
						buffer5[5] = theIP.GetAddressBytes()[2];
						buffer5[6] = theIP.GetAddressBytes()[1];
						buffer5[7] = theIP.GetAddressBytes()[0];
						buffer5[13] = (byte)(thePort & 0xff);
						buffer5[14] = (byte)((thePort & 0xff00) >> 8);
						list.Add(buffer5);
						byte[] buffer6 = new byte[UOKR_IPDATA_1b.Length];
						UOKR_IPDATA_1b.CopyTo(buffer6, 0);
						buffer6[2] = theIP.GetAddressBytes()[3];
						buffer6[3] = theIP.GetAddressBytes()[2];
						buffer6[4] = theIP.GetAddressBytes()[1];
						buffer6[5] = theIP.GetAddressBytes()[0];
						buffer6[10] = (byte)(thePort & 0xff);
						buffer6[11] = (byte)((thePort & 0xff00) >> 8);
						buffer6[20] = (byte)(thePort & 0xff);
						buffer6[0x15] = (byte)((thePort & 0xff00) >> 8);
						list.Add(buffer6);
						return list;
					}
				case 2: {
						byte[] buffer3 = new byte[UOKR_IPDATA_2a.Length];
						UOKR_IPDATA_2a.CopyTo(buffer3, 0);
						buffer3[4] = theIP.GetAddressBytes()[3];
						buffer3[5] = theIP.GetAddressBytes()[2];
						buffer3[6] = theIP.GetAddressBytes()[1];
						buffer3[7] = theIP.GetAddressBytes()[0];
						buffer3[13] = (byte)(thePort & 0xff);
						buffer3[14] = (byte)((thePort & 0xff00) >> 8);
						list.Add(buffer3);
						byte[] buffer4 = new byte[UOKR_IPDATA_2b.Length];
						UOKR_IPDATA_2b.CopyTo(buffer4, 0);
						buffer4[2] = theIP.GetAddressBytes()[3];
						buffer4[3] = theIP.GetAddressBytes()[2];
						buffer4[4] = theIP.GetAddressBytes()[1];
						buffer4[5] = theIP.GetAddressBytes()[0];
						buffer4[10] = (byte)(thePort & 0xff);
						buffer4[11] = (byte)((thePort & 0xff00) >> 8);
						buffer4[20] = (byte)(thePort & 0xff);
						buffer4[0x15] = (byte)((thePort & 0xff00) >> 8);
						list.Add(buffer4);
						return list;
					}
				case 3: {
						byte[] buffer = new byte[UOKR_IPDATA_3a.Length];
						UOKR_IPDATA_3a.CopyTo(buffer, 0);
						buffer[4] = theIP.GetAddressBytes()[3];
						buffer[5] = theIP.GetAddressBytes()[2];
						buffer[6] = theIP.GetAddressBytes()[1];
						buffer[7] = theIP.GetAddressBytes()[0];
						buffer[13] = (byte)(thePort & 0xff);
						buffer[14] = (byte)((thePort & 0xff00) >> 8);
						list.Add(buffer);
						byte[] buffer2 = new byte[UOKR_IPDATA_3b.Length];
						UOKR_IPDATA_3b.CopyTo(buffer2, 0);
						buffer2[2] = theIP.GetAddressBytes()[3];
						buffer2[3] = theIP.GetAddressBytes()[2];
						buffer2[4] = theIP.GetAddressBytes()[1];
						buffer2[5] = theIP.GetAddressBytes()[0];
						buffer2[10] = (byte)(thePort & 0xff);
						buffer2[11] = (byte)((thePort & 0xff00) >> 8);
						buffer2[20] = (byte)(thePort & 0xff);
						buffer2[0x15] = (byte)((thePort & 0xff00) >> 8);
						list.Add(buffer2);
						return list;
					}
				case 4: {
						byte[] buffer = new byte[UOSA_IPDATA_1a.Length];
						UOSA_IPDATA_1a.CopyTo(buffer, 0);
						buffer[4] = theIP.GetAddressBytes()[3];
						buffer[5] = theIP.GetAddressBytes()[2];
						buffer[6] = theIP.GetAddressBytes()[1];
						buffer[7] = theIP.GetAddressBytes()[0];
						buffer[13] = (byte)(thePort & 0xff);
						buffer[14] = (byte)((thePort & 0xff00) >> 8);
						list.Add(buffer);
						byte[] buffer2 = new byte[UOSA_IPDATA_1b.Length];
						UOSA_IPDATA_1b.CopyTo(buffer2, 0);
						buffer2[2] = theIP.GetAddressBytes()[3];
						buffer2[3] = theIP.GetAddressBytes()[2];
						buffer2[4] = theIP.GetAddressBytes()[1];
						buffer2[5] = theIP.GetAddressBytes()[0];
						buffer2[10] = (byte)(thePort & 0xff);
						buffer2[11] = (byte)((thePort & 0xff00) >> 8);
						buffer2[20] = (byte)(thePort & 0xff);
						buffer2[0x15] = (byte)((thePort & 0xff00) >> 8);
						list.Add(buffer2);
						return list;
					}
				case 5: {
						byte[] buffer = new byte[UOSA_IPDATA_2a.Length];
						UOSA_IPDATA_2a.CopyTo(buffer, 0);
						buffer[4] = theIP.GetAddressBytes()[3];
						buffer[5] = theIP.GetAddressBytes()[2];
						buffer[6] = theIP.GetAddressBytes()[1];
						buffer[7] = theIP.GetAddressBytes()[0];
						list.Add(buffer);
						byte[] buffer2 = new byte[UOSA_IPDATA_2b.Length];
						UOSA_IPDATA_2b.CopyTo(buffer2, 0);
						buffer2[4] = theIP.GetAddressBytes()[3];
						buffer2[5] = theIP.GetAddressBytes()[2];
						buffer2[6] = theIP.GetAddressBytes()[1];
						buffer2[7] = theIP.GetAddressBytes()[0];
						list.Add(buffer2);
						byte[] buffer3 = new byte[UOSA_PORTDATA_2a.Length];
						UOSA_PORTDATA_2a.CopyTo(buffer3, 0);
						buffer3[5] = (byte)(thePort & 0xff);
						buffer3[6] = (byte)((thePort & 0xff00) >> 8);
						list.Add(buffer3);
						return list;
					}
				case 6: {
						byte[] buffer = new byte[UOSA_IPDATA_3.Length];
						for (int i = 0; i < buffer.Length; ++i)
							buffer[i] = 0;
						char[] ip = theIP.ToString().ToCharArray();
						for (int i = 0; i < ip.Length; ++i)
							buffer[i] = (byte)ip[i];
						list.Add(buffer);

						byte[] buffer3 = new byte[UOSA_PORTDATA_3.Length];
						UOSA_PORTDATA_3.CopyTo(buffer3, 0);
						buffer3[5] = (byte)(thePort & 0xff);
						buffer3[6] = (byte)((thePort & 0xff00) >> 8);
						list.Add(buffer3);
						//list.Add(buffer3);
						return list;
					}
			}
			return list;
		}

		/*public static byte[] GetPatchedLoginData(int iVersion) {
			byte[] array = null;
			switch (iVersion) {
				case 0:
					array = new byte[UOKR_LOGDATA_0.Length];
					UOKR_LOGDATA_0.CopyTo(array, 0);
					array[3] = 0x90;
					array[4] = 0x90;
					return array;

				case 1:
					array = new byte[UOKR_LOGDATA_1.Length];
					UOKR_LOGDATA_1.CopyTo(array, 0);
					array[3] = 0x90;
					array[4] = 0x90;
					return array;
			}
			return array;
		}*/

		public static int UOKR_IPDATA_VERSION {
			get {
				return 7;
			}
		}

		public static int UOKR_LOGDATA_VERSION {
			get {
				return 2;
			}
		}
	}
}