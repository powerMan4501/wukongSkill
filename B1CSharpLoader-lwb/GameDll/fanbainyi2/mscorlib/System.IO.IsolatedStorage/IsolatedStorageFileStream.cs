using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.IO.IsolatedStorage;

[ComVisible(true)]
public class IsolatedStorageFileStream : FileStream
{
	private const int s_BlockSize = 1024;

	private const string s_BackSlash = "\\";

	private FileStream m_fs;

	private IsolatedStorageFile m_isf;

	private string m_GivenPath;

	private string m_FullPath;

	private bool m_OwnedStore;

	public override bool CanRead => m_fs.CanRead;

	public override bool CanWrite => m_fs.CanWrite;

	public override bool CanSeek => m_fs.CanSeek;

	public override bool IsAsync => m_fs.IsAsync;

	public override long Length => m_fs.Length;

	public override long Position
	{
		get
		{
			return m_fs.Position;
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("value", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
			}
			Seek(value, SeekOrigin.Begin);
		}
	}

	[Obsolete("This property has been deprecated.  Please use IsolatedStorageFileStream's SafeFileHandle property instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public override IntPtr Handle
	{
		[SecurityCritical]
		[SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		get
		{
			NotPermittedError();
			return Win32Native.INVALID_HANDLE_VALUE;
		}
	}

	public override SafeFileHandle SafeFileHandle
	{
		[SecurityCritical]
		[SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		get
		{
			NotPermittedError();
			return null;
		}
	}

	private IsolatedStorageFileStream()
	{
	}

	public IsolatedStorageFileStream(string path, FileMode mode)
		: this(path, mode, (mode == FileMode.Append) ? FileAccess.Write : FileAccess.ReadWrite, FileShare.None, null)
	{
	}

	public IsolatedStorageFileStream(string path, FileMode mode, IsolatedStorageFile isf)
		: this(path, mode, (mode == FileMode.Append) ? FileAccess.Write : FileAccess.ReadWrite, FileShare.None, isf)
	{
	}

	public IsolatedStorageFileStream(string path, FileMode mode, FileAccess access)
		: this(path, mode, access, (access == FileAccess.Read) ? FileShare.Read : FileShare.None, 4096, null)
	{
	}

	public IsolatedStorageFileStream(string path, FileMode mode, FileAccess access, IsolatedStorageFile isf)
		: this(path, mode, access, (access == FileAccess.Read) ? FileShare.Read : FileShare.None, 4096, isf)
	{
	}

	public IsolatedStorageFileStream(string path, FileMode mode, FileAccess access, FileShare share)
		: this(path, mode, access, share, 4096, null)
	{
	}

	public IsolatedStorageFileStream(string path, FileMode mode, FileAccess access, FileShare share, IsolatedStorageFile isf)
		: this(path, mode, access, share, 4096, isf)
	{
	}

	public IsolatedStorageFileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize)
		: this(path, mode, access, share, bufferSize, null)
	{
	}

	[SecuritySafeCritical]
	public IsolatedStorageFileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, IsolatedStorageFile isf)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (path.Length == 0 || path.Equals("\\"))
		{
			throw new ArgumentException(Environment.GetResourceString("IsolatedStorage_Path"));
		}
		if (isf == null)
		{
			m_OwnedStore = true;
			isf = IsolatedStorageFile.GetUserStoreForDomain();
		}
		if (isf.Disposed)
		{
			throw new ObjectDisposedException(null, Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
		}
		if ((uint)(mode - 1) > 5u)
		{
			throw new ArgumentException(Environment.GetResourceString("IsolatedStorage_FileOpenMode"));
		}
		m_isf = isf;
		FileIOPermission fileIOPermission = new FileIOPermission(FileIOPermissionAccess.AllAccess, m_isf.RootDirectory);
		fileIOPermission.Assert();
		fileIOPermission.PermitOnly();
		m_GivenPath = path;
		m_FullPath = m_isf.GetFullPath(m_GivenPath);
		ulong num = 0uL;
		bool flag = false;
		bool locked = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			switch (mode)
			{
			case FileMode.CreateNew:
				flag = true;
				break;
			case FileMode.Create:
			case FileMode.OpenOrCreate:
			case FileMode.Truncate:
			case FileMode.Append:
				m_isf.Lock(ref locked);
				try
				{
					num = IsolatedStorageFile.RoundToBlockSize((ulong)LongPathFile.GetLength(m_FullPath));
				}
				catch (FileNotFoundException)
				{
					flag = true;
				}
				catch
				{
				}
				break;
			}
			if (flag)
			{
				m_isf.ReserveOneBlock();
			}
			try
			{
				m_fs = new FileStream(m_FullPath, mode, access, share, bufferSize, FileOptions.None, m_GivenPath, bFromProxy: true, useLongPath: true);
			}
			catch
			{
				if (flag)
				{
					m_isf.UnreserveOneBlock();
				}
				throw;
			}
			if (!flag && (mode == FileMode.Truncate || mode == FileMode.Create))
			{
				ulong num2 = IsolatedStorageFile.RoundToBlockSize((ulong)m_fs.Length);
				if (num > num2)
				{
					m_isf.Unreserve(num - num2);
				}
				else if (num2 > num)
				{
					m_isf.Reserve(num2 - num);
				}
			}
		}
		finally
		{
			if (locked)
			{
				m_isf.Unlock();
			}
		}
		CodeAccessPermission.RevertAll();
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (!disposing)
			{
				return;
			}
			try
			{
				if (m_fs != null)
				{
					m_fs.Close();
				}
			}
			finally
			{
				if (m_OwnedStore && m_isf != null)
				{
					m_isf.Close();
				}
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	public override void Flush()
	{
		m_fs.Flush();
	}

	public override void Flush(bool flushToDisk)
	{
		m_fs.Flush(flushToDisk);
	}

	[SecuritySafeCritical]
	public override void SetLength(long value)
	{
		if (value < 0)
		{
			throw new ArgumentOutOfRangeException("value", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		bool locked = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			m_isf.Lock(ref locked);
			ulong length = (ulong)m_fs.Length;
			m_isf.Reserve(length, (ulong)value);
			try
			{
				ZeroInit(length, (ulong)value);
				m_fs.SetLength(value);
			}
			catch
			{
				m_isf.UndoReserveOperation(length, (ulong)value);
				throw;
			}
			if (length > (ulong)value)
			{
				m_isf.UndoReserveOperation((ulong)value, length);
			}
		}
		finally
		{
			if (locked)
			{
				m_isf.Unlock();
			}
		}
	}

	public override void Lock(long position, long length)
	{
		if (position < 0 || length < 0)
		{
			throw new ArgumentOutOfRangeException((position < 0) ? "position" : "length", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		m_fs.Lock(position, length);
	}

	public override void Unlock(long position, long length)
	{
		if (position < 0 || length < 0)
		{
			throw new ArgumentOutOfRangeException((position < 0) ? "position" : "length", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		m_fs.Unlock(position, length);
	}

	private void ZeroInit(ulong oldLen, ulong newLen)
	{
		if (oldLen >= newLen)
		{
			return;
		}
		ulong num = newLen - oldLen;
		byte[] buffer = new byte[1024];
		long position = m_fs.Position;
		m_fs.Seek((long)oldLen, SeekOrigin.Begin);
		if (num <= 1024)
		{
			m_fs.Write(buffer, 0, (int)num);
			m_fs.Position = position;
			return;
		}
		int num2 = 1024 - (int)(oldLen & 0x3FF);
		m_fs.Write(buffer, 0, num2);
		num -= (ulong)num2;
		int num3 = (int)(num / 1024);
		for (int i = 0; i < num3; i++)
		{
			m_fs.Write(buffer, 0, 1024);
		}
		m_fs.Write(buffer, 0, (int)(num & 0x3FF));
		m_fs.Position = position;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return m_fs.Read(buffer, offset, count);
	}

	public override int ReadByte()
	{
		return m_fs.ReadByte();
	}

	[SecuritySafeCritical]
	public override long Seek(long offset, SeekOrigin origin)
	{
		bool locked = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			m_isf.Lock(ref locked);
			ulong length = (ulong)m_fs.Length;
			ulong newLen = origin switch
			{
				SeekOrigin.Begin => (ulong)((offset < 0) ? 0 : offset), 
				SeekOrigin.Current => (ulong)((m_fs.Position + offset < 0) ? 0 : (m_fs.Position + offset)), 
				SeekOrigin.End => (ulong)((m_fs.Length + offset < 0) ? 0 : (m_fs.Length + offset)), 
				_ => throw new ArgumentException(Environment.GetResourceString("IsolatedStorage_SeekOrigin")), 
			};
			m_isf.Reserve(length, newLen);
			try
			{
				ZeroInit(length, newLen);
				return m_fs.Seek(offset, origin);
			}
			catch
			{
				m_isf.UndoReserveOperation(length, newLen);
				throw;
			}
		}
		finally
		{
			if (locked)
			{
				m_isf.Unlock();
			}
		}
	}

	[SecuritySafeCritical]
	public override void Write(byte[] buffer, int offset, int count)
	{
		bool locked = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			m_isf.Lock(ref locked);
			ulong length = (ulong)m_fs.Length;
			ulong newLen = (ulong)(m_fs.Position + count);
			m_isf.Reserve(length, newLen);
			try
			{
				m_fs.Write(buffer, offset, count);
			}
			catch
			{
				m_isf.UndoReserveOperation(length, newLen);
				throw;
			}
		}
		finally
		{
			if (locked)
			{
				m_isf.Unlock();
			}
		}
	}

	[SecuritySafeCritical]
	public override void WriteByte(byte value)
	{
		bool locked = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			m_isf.Lock(ref locked);
			ulong length = (ulong)m_fs.Length;
			ulong newLen = (ulong)(m_fs.Position + 1);
			m_isf.Reserve(length, newLen);
			try
			{
				m_fs.WriteByte(value);
			}
			catch
			{
				m_isf.UndoReserveOperation(length, newLen);
				throw;
			}
		}
		finally
		{
			if (locked)
			{
				m_isf.Unlock();
			}
		}
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
	{
		return m_fs.BeginRead(buffer, offset, numBytes, userCallback, stateObject);
	}

	public override int EndRead(IAsyncResult asyncResult)
	{
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		return m_fs.EndRead(asyncResult);
	}

	[SecuritySafeCritical]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
	{
		bool locked = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			m_isf.Lock(ref locked);
			ulong length = (ulong)m_fs.Length;
			ulong newLen = (ulong)(m_fs.Position + numBytes);
			m_isf.Reserve(length, newLen);
			try
			{
				return m_fs.BeginWrite(buffer, offset, numBytes, userCallback, stateObject);
			}
			catch
			{
				m_isf.UndoReserveOperation(length, newLen);
				throw;
			}
		}
		finally
		{
			if (locked)
			{
				m_isf.Unlock();
			}
		}
	}

	public override void EndWrite(IAsyncResult asyncResult)
	{
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		m_fs.EndWrite(asyncResult);
	}

	internal void NotPermittedError(string str)
	{
		throw new IsolatedStorageException(str);
	}

	internal void NotPermittedError()
	{
		NotPermittedError(Environment.GetResourceString("IsolatedStorage_Operation_ISFS"));
	}
}
