using System;
using System.IO;
using System.Runtime.InteropServices;

namespace UoKRLoader
{
	internal class ProcessStream : Stream
	{
		#region Declarations
		private bool m_Open;
		private int m_Position;
		private IntPtr m_Process;
		private IntPtr m_ProcessID;
		private const int ProcessAllAccess = 0x1f0fff;

		public override bool CanRead
		{
			get
			{
				return this.m_Open;
			}
		}

		public override bool CanSeek
		{
			get
			{
				return this.m_Open;
			}
		}

		public override bool CanWrite
		{
			get
			{
				return this.m_Open;
			}
		}

		public bool IsOpened
		{
			get
			{
				return this.m_Open;
			}
			set
			{
				this.m_Open = value;
			}
		}

		public override long Length
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		public override long Position
		{
			get
			{
				return (long)this.m_Position;
			}
			set
			{
				this.Seek(value, SeekOrigin.Begin);
			}
		}

		public IntPtr ProcessHandle
		{
			get
			{
				return this.m_Process;
			}
			set
			{
				this.m_Process = value;
			}
		}

		#endregion

		[DllImport("Kernel32")]
		private static extern int CloseHandle(IntPtr handle);
		[DllImport("Kernel32")]
		private static extern IntPtr OpenProcess(int desiredAccess, int inheritHandle, IntPtr processID);
		[DllImport("Kernel32")]
		private static extern unsafe int ReadProcessMemory(IntPtr process, int baseAddress, void* buffer, int size, ref int op);
		[DllImport("Kernel32")]
		private static extern unsafe int WriteProcessMemory(IntPtr process, int baseAddress, void* buffer, int size, int nullMe);


		public ProcessStream()
		{
		}

		public ProcessStream(IntPtr processID)
		{
			this.m_ProcessID = processID;
			this.BeginAccess();
		}

		public bool BeginAccess()
		{
			if (this.m_Open)
			{
				return false;
			}
			this.m_Process = OpenProcess(0x1f0fff, 0, this.m_ProcessID);
			this.m_Open = true;
			return true;
		}

		public override void Close()
		{
			this.EndAccess();
		}

		public void EndAccess()
		{
			if (this.m_Open)
			{
				CloseHandle(this.m_Process);
				this.m_Open = false;
			}
		}

		public override void Flush()
		{
		}

		public static ProcessStream GetProcessFromHandle(IntPtr handle)
		{
			ProcessStream stream = new ProcessStream();
			stream.ProcessHandle = handle;
			stream.IsOpened = true;
			return stream;
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			switch (origin)
			{
				case SeekOrigin.Begin:
					this.m_Position = (int)offset;
					break;

				case SeekOrigin.Current:
					this.m_Position += (int)offset;
					break;

				case SeekOrigin.End:
					throw new NotSupportedException();
			}
			return (long)this.m_Position;
		}

		public override void SetLength(long value)
		{
			throw new NotSupportedException();
		}

		public override unsafe int Read(byte[] buffer, int offset, int count)
		{
			bool flag = !this.BeginAccess();
			int op = 0;
			fixed (byte* numRef = buffer)
			{
				ReadProcessMemory(this.m_Process, this.m_Position, (void*)(numRef + offset), count, ref op);
			}
			this.m_Position += count;
			if (flag)
			{
				this.EndAccess();
			}
			return op;
		}

		public override unsafe void Write(byte[] buffer, int offset, int count)
		{
			bool flag = !this.BeginAccess();
			fixed (byte* numRef = buffer)
			{
				WriteProcessMemory(this.m_Process, this.m_Position, (void*)(numRef + offset), count, 0);
			}
			this.m_Position += count;
			if (flag)
			{
				this.EndAccess();
			}
		}

	}
}