using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.IO;

internal class LogStream : BufferedStream2
{
	internal const long DefaultFileSize = 10240000L;

	internal const int DefaultNumberOfFiles = 2;

	internal const LogRetentionOption DefaultRetention = LogRetentionOption.SingleFileUnboundedSize;

	private const int _retentionRetryThreshold = 2;

	private LogRetentionOption _retention;

	private long _maxFileSize = 10240000L;

	private int _maxNumberOfFiles = 2;

	private int _currentFileNum = 1;

	private bool _disableLogging;

	private int _retentionRetryCount;

	private bool _canRead;

	private bool _canWrite;

	private bool _canSeek;

	[SecurityCritical]
	private SafeFileHandle _handle;

	private string _fileName;

	private string _fileNameWithoutExt;

	private string _fileExt;

	private string _pathSav;

	private int _fAccessSav;

	private FileShare _shareSav;

	private Microsoft.Win32.UnsafeNativeMethods.SECURITY_ATTRIBUTES _secAttrsSav;

	private FileIOPermissionAccess _secAccessSav;

	private FileMode _modeSav;

	private int _flagsAndAttributesSav;

	private bool _seekToEndSav;

	private readonly object m_lockObject = new object();

	public override bool CanRead => _canRead;

	public override bool CanWrite => _canWrite;

	public override bool CanSeek => _canSeek;

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
			throw new NotSupportedException();
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	[SecurityCritical]
	internal LogStream(string path, int bufferSize, LogRetentionOption retention, long maxFileSize, int maxNumOfFiles)
	{
		string text = (_fileName = Path.GetFullPath(path));
		if (text.StartsWith("\\\\.\\", StringComparison.Ordinal))
		{
			throw new NotSupportedException(System.SR.GetString("NotSupported_IONonFileDevices"));
		}
		Microsoft.Win32.UnsafeNativeMethods.SECURITY_ATTRIBUTES secAttrs = GetSecAttrs(FileShare.Read);
		int flagsAndAttributesSav = 1048576;
		_canWrite = true;
		_pathSav = text;
		_fAccessSav = 1073741824;
		_shareSav = FileShare.Read;
		_secAttrsSav = secAttrs;
		_secAccessSav = FileIOPermissionAccess.Write;
		_modeSav = ((retention != LogRetentionOption.SingleFileUnboundedSize) ? FileMode.Create : FileMode.OpenOrCreate);
		_flagsAndAttributesSav = flagsAndAttributesSav;
		_seekToEndSav = retention == LogRetentionOption.SingleFileUnboundedSize;
		base.bufferSize = bufferSize;
		_retention = retention;
		_maxFileSize = maxFileSize;
		_maxNumberOfFiles = maxNumOfFiles;
		_Init(text, _fAccessSav, _shareSav, _secAttrsSav, _secAccessSav, _modeSav, _flagsAndAttributesSav, _seekToEndSav);
	}

	[SecurityCritical]
	internal void _Init(string path, int fAccess, FileShare share, Microsoft.Win32.UnsafeNativeMethods.SECURITY_ATTRIBUTES secAttrs, FileIOPermissionAccess secAccess, FileMode mode, int flagsAndAttributes, bool seekToEnd)
	{
		string text = (_fileName = Path.GetFullPath(path));
		new FileIOPermission(secAccess, new string[1] { text }).Demand();
		int errorMode = Microsoft.Win32.UnsafeNativeMethods.SetErrorMode(1);
		try
		{
			_handle = Microsoft.Win32.UnsafeNativeMethods.SafeCreateFile(text, fAccess, share, secAttrs, mode, flagsAndAttributes, Microsoft.Win32.UnsafeNativeMethods.NULL);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (_handle.IsInvalid)
			{
				bool flag = false;
				try
				{
					new FileIOPermission(FileIOPermissionAccess.PathDiscovery, new string[1] { _fileName }).Demand();
					flag = true;
				}
				catch (SecurityException)
				{
				}
				if (flag)
				{
					__Error.WinIOError(lastWin32Error, _fileName);
				}
				else
				{
					__Error.WinIOError(lastWin32Error, Path.GetFileName(_fileName));
				}
			}
		}
		finally
		{
			Microsoft.Win32.UnsafeNativeMethods.SetErrorMode(errorMode);
		}
		pos = 0L;
		if (seekToEnd)
		{
			SeekCore(0L, SeekOrigin.End);
		}
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException();
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException();
	}

	public override int Read(byte[] array, int offset, int count)
	{
		throw new NotSupportedException();
	}

	[SecurityCritical]
	protected unsafe override void WriteCore(byte[] buffer, int offset, int count, bool blockForWrite, out long streamPos)
	{
		int hr = 0;
		int num = WriteFileNative(buffer, offset, count, null, out hr);
		if (num == -1)
		{
			switch (hr)
			{
			case 232:
				num = 0;
				break;
			case 87:
				throw new IOException(System.SR.GetString("IO_FileTooLongOrHandleNotSync"));
			default:
				__Error.WinIOError(hr, string.Empty);
				break;
			}
		}
		streamPos = AddUnderlyingStreamPosition(num);
		EnforceRetentionPolicy(_handle, streamPos);
		streamPos = pos;
	}

	[SecurityCritical]
	private unsafe int WriteFileNative(byte[] bytes, int offset, int count, NativeOverlapped* overlapped, out int hr)
	{
		if (_handle.IsClosed)
		{
			__Error.FileNotOpen();
		}
		if (_disableLogging)
		{
			hr = 0;
			return 0;
		}
		if (bytes.Length - offset < count)
		{
			throw new IndexOutOfRangeException(System.SR.GetString("IndexOutOfRange_IORaceCondition"));
		}
		if (bytes.Length == 0)
		{
			hr = 0;
			return 0;
		}
		int numBytesWritten = 0;
		int num = 0;
		fixed (byte* ptr = bytes)
		{
			num = Microsoft.Win32.UnsafeNativeMethods.WriteFile(_handle, ptr + offset, count, out numBytesWritten, overlapped);
		}
		if (num == 0)
		{
			hr = Marshal.GetLastWin32Error();
			if (hr == 6)
			{
				_handle.SetHandleAsInvalid();
			}
			return -1;
		}
		hr = 0;
		return numBytesWritten;
	}

	[SecurityCritical]
	private long SeekCore(long offset, SeekOrigin origin)
	{
		int hr = 0;
		long num = 0L;
		num = Microsoft.Win32.UnsafeNativeMethods.SetFilePointer(_handle, offset, origin, out hr);
		if (num == -1)
		{
			if (hr == 6)
			{
				_handle.SetHandleAsInvalid();
			}
			__Error.WinIOError(hr, string.Empty);
		}
		base.UnderlyingStreamPosition = num;
		return num;
	}

	[SecurityCritical]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (_handle == null || _handle.IsClosed)
			{
				DiscardBuffer();
			}
		}
		finally
		{
			try
			{
				base.Dispose(disposing);
			}
			finally
			{
				if (_handle != null && !_handle.IsClosed)
				{
					_handle.Dispose();
				}
				_handle = null;
				_canRead = false;
				_canWrite = false;
				_canSeek = false;
			}
		}
	}

	[SecurityCritical]
	~LogStream()
	{
		if (_handle != null)
		{
			Dispose(disposing: false);
		}
	}

	[SecurityCritical]
	private void EnforceRetentionPolicy(SafeFileHandle handle, long lastPos)
	{
		switch (_retention)
		{
		case LogRetentionOption.UnlimitedSequentialFiles:
		case LogRetentionOption.LimitedCircularFiles:
		case LogRetentionOption.LimitedSequentialFiles:
			if (lastPos < _maxFileSize || handle != _handle)
			{
				break;
			}
			lock (m_lockObject)
			{
				if (handle != _handle || lastPos < _maxFileSize)
				{
					break;
				}
				_currentFileNum++;
				if (_retention == LogRetentionOption.LimitedCircularFiles && _currentFileNum > _maxNumberOfFiles)
				{
					_currentFileNum = 1;
				}
				else if (_retention == LogRetentionOption.LimitedSequentialFiles && _currentFileNum > _maxNumberOfFiles)
				{
					_DisableLogging();
					break;
				}
				if (_fileNameWithoutExt == null)
				{
					_fileNameWithoutExt = Path.Combine(Path.GetDirectoryName(_pathSav), Path.GetFileNameWithoutExtension(_pathSav));
					_fileExt = Path.GetExtension(_pathSav);
				}
				string path = ((_currentFileNum == 1) ? _pathSav : (_fileNameWithoutExt + _currentFileNum.ToString(CultureInfo.InvariantCulture) + _fileExt));
				try
				{
					_Init(path, _fAccessSav, _shareSav, _secAttrsSav, _secAccessSav, _modeSav, _flagsAndAttributesSav, _seekToEndSav);
					if (handle != null && !handle.IsClosed)
					{
						handle.Dispose();
					}
					break;
				}
				catch (IOException)
				{
					_handle = handle;
					_retentionRetryCount++;
					if (_retentionRetryCount >= 2)
					{
						_DisableLogging();
					}
					break;
				}
				catch (UnauthorizedAccessException)
				{
					_DisableLogging();
					break;
				}
				catch (Exception)
				{
					_DisableLogging();
					break;
				}
			}
		case LogRetentionOption.SingleFileBoundedSize:
			if (lastPos >= _maxFileSize)
			{
				_DisableLogging();
			}
			break;
		case LogRetentionOption.SingleFileUnboundedSize:
			break;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	private void _DisableLogging()
	{
		_disableLogging = true;
	}

	[SecurityCritical]
	private static Microsoft.Win32.UnsafeNativeMethods.SECURITY_ATTRIBUTES GetSecAttrs(FileShare share)
	{
		Microsoft.Win32.UnsafeNativeMethods.SECURITY_ATTRIBUTES sECURITY_ATTRIBUTES = null;
		if ((share & FileShare.Inheritable) != FileShare.None)
		{
			sECURITY_ATTRIBUTES = new Microsoft.Win32.UnsafeNativeMethods.SECURITY_ATTRIBUTES();
			sECURITY_ATTRIBUTES.nLength = Marshal.SizeOf((object)sECURITY_ATTRIBUTES);
			sECURITY_ATTRIBUTES.bInheritHandle = 1;
		}
		return sECURITY_ATTRIBUTES;
	}
}
