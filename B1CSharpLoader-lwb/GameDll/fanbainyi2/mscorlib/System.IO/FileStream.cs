using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.IO;

[ComVisible(true)]
public class FileStream : Stream
{
	private sealed class FileStreamReadWriteTask<T> : Task<T>
	{
		internal CancellationToken _cancellationToken;

		internal CancellationTokenRegistration _registration;

		internal FileStreamAsyncResult _asyncResult;

		internal FileStreamReadWriteTask(CancellationToken cancellationToken)
		{
			_cancellationToken = cancellationToken;
		}
	}

	internal const int DefaultBufferSize = 4096;

	private const bool _canUseAsync = true;

	private byte[] _buffer;

	private string _fileName;

	private bool _isAsync;

	private bool _canRead;

	private bool _canWrite;

	private bool _canSeek;

	private bool _exposedHandle;

	private bool _isPipe;

	private int _readPos;

	private int _readLen;

	private int _writePos;

	private int _bufferSize;

	[SecurityCritical]
	private SafeFileHandle _handle;

	private long _pos;

	private long _appendStart;

	private static AsyncCallback s_endReadTask;

	private static AsyncCallback s_endWriteTask;

	private static Action<object> s_cancelReadHandler;

	private static Action<object> s_cancelWriteHandler;

	private const int FILE_ATTRIBUTE_NORMAL = 128;

	private const int FILE_ATTRIBUTE_ENCRYPTED = 16384;

	private const int FILE_FLAG_OVERLAPPED = 1073741824;

	internal const int GENERIC_READ = int.MinValue;

	private const int GENERIC_WRITE = 1073741824;

	private const int FILE_BEGIN = 0;

	private const int FILE_CURRENT = 1;

	private const int FILE_END = 2;

	internal const int ERROR_BROKEN_PIPE = 109;

	internal const int ERROR_NO_DATA = 232;

	private const int ERROR_HANDLE_EOF = 38;

	private const int ERROR_INVALID_PARAMETER = 87;

	private const int ERROR_IO_PENDING = 997;

	public override bool CanRead => _canRead;

	public override bool CanWrite => _canWrite;

	public override bool CanSeek => _canSeek;

	public virtual bool IsAsync => _isAsync;

	public override long Length
	{
		[SecuritySafeCritical]
		get
		{
			if (_handle.IsClosed)
			{
				__Error.FileNotOpen();
			}
			if (!CanSeek)
			{
				__Error.SeekNotSupported();
			}
			int highSize = 0;
			int num = 0;
			num = Win32Native.GetFileSize(_handle, out highSize);
			if (num == -1)
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (lastWin32Error != 0)
				{
					__Error.WinIOError(lastWin32Error, string.Empty);
				}
			}
			long num2 = ((long)highSize << 32) | (uint)num;
			if (_writePos > 0 && _pos + _writePos > num2)
			{
				num2 = _writePos + _pos;
			}
			return num2;
		}
	}

	public string Name
	{
		[SecuritySafeCritical]
		get
		{
			if (_fileName == null)
			{
				return Environment.GetResourceString("IO_UnknownFileName");
			}
			FileIOPermission.QuickDemand(FileIOPermissionAccess.PathDiscovery, _fileName, checkForDuplicates: false, needFullPath: false);
			return _fileName;
		}
	}

	internal string NameInternal
	{
		get
		{
			if (_fileName == null)
			{
				return "<UnknownFileName>";
			}
			return _fileName;
		}
	}

	public override long Position
	{
		[SecuritySafeCritical]
		get
		{
			if (_handle.IsClosed)
			{
				__Error.FileNotOpen();
			}
			if (!CanSeek)
			{
				__Error.SeekNotSupported();
			}
			if (_exposedHandle)
			{
				VerifyOSHandlePosition();
			}
			return _pos + (_readPos - _readLen + _writePos);
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("value", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
			}
			if (_writePos > 0)
			{
				FlushWrite(calledFromFinalizer: false);
			}
			_readPos = 0;
			_readLen = 0;
			Seek(value, SeekOrigin.Begin);
		}
	}

	[Obsolete("This property has been deprecated.  Please use FileStream's SafeFileHandle property instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public virtual IntPtr Handle
	{
		[SecurityCritical]
		[SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		get
		{
			Flush();
			_readPos = 0;
			_readLen = 0;
			_writePos = 0;
			_exposedHandle = true;
			return _handle.DangerousGetHandle();
		}
	}

	public virtual SafeFileHandle SafeFileHandle
	{
		[SecurityCritical]
		[SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		get
		{
			Flush();
			_readPos = 0;
			_readLen = 0;
			_writePos = 0;
			_exposedHandle = true;
			return _handle;
		}
	}

	internal FileStream()
	{
	}

	[SecuritySafeCritical]
	public FileStream(string path, FileMode mode)
		: this(path, mode, (mode == FileMode.Append) ? FileAccess.Write : FileAccess.ReadWrite, FileShare.Read, 4096, FileOptions.None, Path.GetFileName(path), bFromProxy: false)
	{
	}

	[SecuritySafeCritical]
	public FileStream(string path, FileMode mode, FileAccess access)
		: this(path, mode, access, FileShare.Read, 4096, FileOptions.None, Path.GetFileName(path), bFromProxy: false)
	{
	}

	[SecuritySafeCritical]
	public FileStream(string path, FileMode mode, FileAccess access, FileShare share)
		: this(path, mode, access, share, 4096, FileOptions.None, Path.GetFileName(path), bFromProxy: false)
	{
	}

	[SecuritySafeCritical]
	public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize)
		: this(path, mode, access, share, bufferSize, FileOptions.None, Path.GetFileName(path), bFromProxy: false)
	{
	}

	[SecuritySafeCritical]
	public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options)
		: this(path, mode, access, share, bufferSize, options, Path.GetFileName(path), bFromProxy: false)
	{
	}

	[SecuritySafeCritical]
	public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync)
		: this(path, mode, access, share, bufferSize, useAsync ? FileOptions.Asynchronous : FileOptions.None, Path.GetFileName(path), bFromProxy: false)
	{
	}

	[SecuritySafeCritical]
	public FileStream(string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, FileOptions options, FileSecurity fileSecurity)
	{
		object pinningHandle;
		Win32Native.SECURITY_ATTRIBUTES secAttrs = GetSecAttrs(share, fileSecurity, out pinningHandle);
		try
		{
			Init(path, mode, (FileAccess)0, (int)rights, useRights: true, share, bufferSize, options, secAttrs, Path.GetFileName(path), bFromProxy: false, useLongPath: false, checkHost: false);
		}
		finally
		{
			if (pinningHandle != null)
			{
				((GCHandle)pinningHandle).Free();
			}
		}
	}

	[SecuritySafeCritical]
	public FileStream(string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, FileOptions options)
	{
		Win32Native.SECURITY_ATTRIBUTES secAttrs = GetSecAttrs(share);
		Init(path, mode, (FileAccess)0, (int)rights, useRights: true, share, bufferSize, options, secAttrs, Path.GetFileName(path), bFromProxy: false, useLongPath: false, checkHost: false);
	}

	[SecurityCritical]
	internal FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options, string msgPath, bool bFromProxy)
	{
		Win32Native.SECURITY_ATTRIBUTES secAttrs = GetSecAttrs(share);
		Init(path, mode, access, 0, useRights: false, share, bufferSize, options, secAttrs, msgPath, bFromProxy, useLongPath: false, checkHost: false);
	}

	[SecurityCritical]
	internal FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options, string msgPath, bool bFromProxy, bool useLongPath)
	{
		Win32Native.SECURITY_ATTRIBUTES secAttrs = GetSecAttrs(share);
		Init(path, mode, access, 0, useRights: false, share, bufferSize, options, secAttrs, msgPath, bFromProxy, useLongPath, checkHost: false);
	}

	[SecurityCritical]
	internal FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options, string msgPath, bool bFromProxy, bool useLongPath, bool checkHost)
	{
		Win32Native.SECURITY_ATTRIBUTES secAttrs = GetSecAttrs(share);
		Init(path, mode, access, 0, useRights: false, share, bufferSize, options, secAttrs, msgPath, bFromProxy, useLongPath, checkHost);
	}

	[SecuritySafeCritical]
	private unsafe void Init(string path, FileMode mode, FileAccess access, int rights, bool useRights, FileShare share, int bufferSize, FileOptions options, Win32Native.SECURITY_ATTRIBUTES secAttrs, string msgPath, bool bFromProxy, bool useLongPath, bool checkHost)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path", Environment.GetResourceString("ArgumentNull_Path"));
		}
		if (path.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyPath"));
		}
		_fileName = msgPath;
		_exposedHandle = false;
		FileShare fileShare = share & ~FileShare.Inheritable;
		string text = null;
		if (mode < FileMode.CreateNew || mode > FileMode.Append)
		{
			text = "mode";
		}
		else if (!useRights && (access < FileAccess.Read || access > FileAccess.ReadWrite))
		{
			text = "access";
		}
		else if (useRights && (rights < 1 || rights > 2032127))
		{
			text = "rights";
		}
		else if ((fileShare < FileShare.None) || fileShare > (FileShare.ReadWrite | FileShare.Delete))
		{
			text = "share";
		}
		if (text != null)
		{
			throw new ArgumentOutOfRangeException(text, Environment.GetResourceString("ArgumentOutOfRange_Enum"));
		}
		if (options != FileOptions.None && (options & (FileOptions)67092479) != FileOptions.None)
		{
			throw new ArgumentOutOfRangeException("options", Environment.GetResourceString("ArgumentOutOfRange_Enum"));
		}
		if (bufferSize <= 0)
		{
			throw new ArgumentOutOfRangeException("bufferSize", Environment.GetResourceString("ArgumentOutOfRange_NeedPosNum"));
		}
		if (((!useRights && (access & FileAccess.Write) == 0) || (useRights && (rights & 0x116) == 0)) && (mode == FileMode.Truncate || mode == FileMode.CreateNew || mode == FileMode.Create || mode == FileMode.Append))
		{
			if (!useRights)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidFileMode&AccessCombo", mode, access));
			}
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidFileMode&RightsCombo", mode, (FileSystemRights)rights));
		}
		if (useRights && mode == FileMode.Truncate)
		{
			if (rights != 278)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidFileModeTruncate&RightsCombo", mode, (FileSystemRights)rights));
			}
			useRights = false;
			access = FileAccess.Write;
		}
		int dwDesiredAccess = (useRights ? rights : (access switch
		{
			FileAccess.Write => 1073741824, 
			FileAccess.Read => int.MinValue, 
			_ => -1073741824, 
		}));
		int maxPathLength = (useLongPath ? 32767 : (AppContextSwitches.BlockLongPaths ? 260 : 32767));
		string text2 = (_fileName = Path.NormalizePath(path, fullCheck: true, maxPathLength));
		if ((!CodeAccessSecurityEngine.QuickCheckForAllDemands() || AppContextSwitches.UseLegacyPathHandling) && text2.StartsWith("\\\\.\\", StringComparison.Ordinal))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_DevicesNotSupported"));
		}
		bool flag = false;
		if ((!useRights && (access & FileAccess.Read) != 0) || (useRights && (rights & 0x200A9) != 0))
		{
			if (mode == FileMode.Append)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidAppendMode"));
			}
			flag = true;
		}
		if (CodeAccessSecurityEngine.QuickCheckForAllDemands())
		{
			FileIOPermission.EmulateFileIOPermissionChecks(text2);
		}
		else
		{
			FileIOPermissionAccess fileIOPermissionAccess = FileIOPermissionAccess.NoAccess;
			if (flag)
			{
				fileIOPermissionAccess |= FileIOPermissionAccess.Read;
			}
			if ((!useRights && (access & FileAccess.Write) != 0) || (useRights && (rights & 0xD0156) != 0) || (useRights && (rights & 0x100000) != 0 && mode == FileMode.OpenOrCreate))
			{
				fileIOPermissionAccess = ((mode != FileMode.Append) ? (fileIOPermissionAccess | FileIOPermissionAccess.Write) : (fileIOPermissionAccess | FileIOPermissionAccess.Append));
			}
			AccessControlActions control = ((secAttrs != null && secAttrs.pSecurityDescriptor != null) ? AccessControlActions.Change : AccessControlActions.None);
			FileIOPermission.QuickDemand(fileIOPermissionAccess, control, new string[1] { text2 }, checkForDuplicates: false, needFullPath: false);
		}
		share &= ~FileShare.Inheritable;
		bool flag2 = mode == FileMode.Append;
		if (mode == FileMode.Append)
		{
			mode = FileMode.OpenOrCreate;
		}
		if ((options & FileOptions.Asynchronous) != FileOptions.None)
		{
			_isAsync = true;
		}
		else
		{
			options &= ~FileOptions.Asynchronous;
		}
		int num = (int)options;
		num |= 0x100000;
		int errorMode = Win32Native.SetErrorMode(1);
		try
		{
			string text3 = text2;
			if (useLongPath)
			{
				text3 = Path.AddLongPathPrefix(text3);
			}
			_handle = Win32Native.SafeCreateFile(text3, dwDesiredAccess, share, secAttrs, mode, num, IntPtr.Zero);
			if (_handle.IsInvalid)
			{
				int num2 = Marshal.GetLastWin32Error();
				if (num2 == 3 && text2.Equals(Directory.InternalGetDirectoryRoot(text2)))
				{
					num2 = 5;
				}
				bool flag3 = false;
				if (!bFromProxy)
				{
					try
					{
						FileIOPermission.QuickDemand(FileIOPermissionAccess.PathDiscovery, _fileName, checkForDuplicates: false, needFullPath: false);
						flag3 = true;
					}
					catch (SecurityException)
					{
					}
				}
				if (flag3)
				{
					__Error.WinIOError(num2, _fileName);
				}
				else
				{
					__Error.WinIOError(num2, msgPath);
				}
			}
		}
		finally
		{
			Win32Native.SetErrorMode(errorMode);
		}
		int fileType = Win32Native.GetFileType(_handle);
		if (fileType != 1)
		{
			_handle.Close();
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_FileStreamOnNonFiles"));
		}
		if (_isAsync)
		{
			bool flag4 = false;
			new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Assert();
			try
			{
				flag4 = ThreadPool.BindHandle(_handle);
			}
			finally
			{
				CodeAccessPermission.RevertAssert();
				if (!flag4)
				{
					_handle.Close();
				}
			}
			if (!flag4)
			{
				throw new IOException(Environment.GetResourceString("IO.IO_BindHandleFailed"));
			}
		}
		if (!useRights)
		{
			_canRead = (access & FileAccess.Read) != 0;
			_canWrite = (access & FileAccess.Write) != 0;
		}
		else
		{
			_canRead = (rights & 1) != 0;
			_canWrite = (rights & 2) != 0 || (rights & 4) != 0;
		}
		_canSeek = true;
		_isPipe = false;
		_pos = 0L;
		_bufferSize = bufferSize;
		_readPos = 0;
		_readLen = 0;
		_writePos = 0;
		if (flag2)
		{
			_appendStart = SeekCore(0L, SeekOrigin.End);
		}
		else
		{
			_appendStart = -1L;
		}
	}

	[Obsolete("This constructor has been deprecated.  Please use new FileStream(SafeFileHandle handle, FileAccess access) instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public FileStream(IntPtr handle, FileAccess access)
		: this(handle, access, ownsHandle: true, 4096, isAsync: false)
	{
	}

	[Obsolete("This constructor has been deprecated.  Please use new FileStream(SafeFileHandle handle, FileAccess access) instead, and optionally make a new SafeFileHandle with ownsHandle=false if needed.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public FileStream(IntPtr handle, FileAccess access, bool ownsHandle)
		: this(handle, access, ownsHandle, 4096, isAsync: false)
	{
	}

	[Obsolete("This constructor has been deprecated.  Please use new FileStream(SafeFileHandle handle, FileAccess access, int bufferSize) instead, and optionally make a new SafeFileHandle with ownsHandle=false if needed.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public FileStream(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize)
		: this(handle, access, ownsHandle, bufferSize, isAsync: false)
	{
	}

	[SecuritySafeCritical]
	[Obsolete("This constructor has been deprecated.  Please use new FileStream(SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync) instead, and optionally make a new SafeFileHandle with ownsHandle=false if needed.  http://go.microsoft.com/fwlink/?linkid=14202")]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public FileStream(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync)
		: this(new SafeFileHandle(handle, ownsHandle), access, bufferSize, isAsync)
	{
	}

	[SecuritySafeCritical]
	public FileStream(SafeFileHandle handle, FileAccess access)
		: this(handle, access, 4096, isAsync: false)
	{
	}

	[SecuritySafeCritical]
	public FileStream(SafeFileHandle handle, FileAccess access, int bufferSize)
		: this(handle, access, bufferSize, isAsync: false)
	{
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public FileStream(SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync)
	{
		if (handle.IsInvalid)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_InvalidHandle"), "handle");
		}
		_handle = handle;
		_exposedHandle = true;
		if (access < FileAccess.Read || access > FileAccess.ReadWrite)
		{
			throw new ArgumentOutOfRangeException("access", Environment.GetResourceString("ArgumentOutOfRange_Enum"));
		}
		if (bufferSize <= 0)
		{
			throw new ArgumentOutOfRangeException("bufferSize", Environment.GetResourceString("ArgumentOutOfRange_NeedPosNum"));
		}
		int fileType = Win32Native.GetFileType(_handle);
		_isAsync = isAsync;
		_canRead = (access & FileAccess.Read) != 0;
		_canWrite = (access & FileAccess.Write) != 0;
		_canSeek = fileType == 1;
		_bufferSize = bufferSize;
		_readPos = 0;
		_readLen = 0;
		_writePos = 0;
		_fileName = null;
		_isPipe = fileType == 3;
		if (_isAsync)
		{
			bool flag = false;
			try
			{
				flag = ThreadPool.BindHandle(_handle);
			}
			catch (ApplicationException)
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_HandleNotAsync"));
			}
			if (!flag)
			{
				throw new IOException(Environment.GetResourceString("IO.IO_BindHandleFailed"));
			}
		}
		else if (fileType != 3)
		{
			VerifyHandleIsSync();
		}
		if (_canSeek)
		{
			SeekCore(0L, SeekOrigin.Current);
		}
		else
		{
			_pos = 0L;
		}
	}

	[SecuritySafeCritical]
	private static Win32Native.SECURITY_ATTRIBUTES GetSecAttrs(FileShare share)
	{
		Win32Native.SECURITY_ATTRIBUTES sECURITY_ATTRIBUTES = null;
		if ((share & FileShare.Inheritable) != FileShare.None)
		{
			sECURITY_ATTRIBUTES = new Win32Native.SECURITY_ATTRIBUTES();
			sECURITY_ATTRIBUTES.nLength = Marshal.SizeOf(sECURITY_ATTRIBUTES);
			sECURITY_ATTRIBUTES.bInheritHandle = 1;
		}
		return sECURITY_ATTRIBUTES;
	}

	[SecuritySafeCritical]
	private unsafe static Win32Native.SECURITY_ATTRIBUTES GetSecAttrs(FileShare share, FileSecurity fileSecurity, out object pinningHandle)
	{
		pinningHandle = null;
		Win32Native.SECURITY_ATTRIBUTES sECURITY_ATTRIBUTES = null;
		if ((share & FileShare.Inheritable) != FileShare.None || fileSecurity != null)
		{
			sECURITY_ATTRIBUTES = new Win32Native.SECURITY_ATTRIBUTES();
			sECURITY_ATTRIBUTES.nLength = Marshal.SizeOf(sECURITY_ATTRIBUTES);
			if ((share & FileShare.Inheritable) != FileShare.None)
			{
				sECURITY_ATTRIBUTES.bInheritHandle = 1;
			}
			if (fileSecurity != null)
			{
				byte[] securityDescriptorBinaryForm = fileSecurity.GetSecurityDescriptorBinaryForm();
				pinningHandle = GCHandle.Alloc(securityDescriptorBinaryForm, GCHandleType.Pinned);
				fixed (byte* pSecurityDescriptor = securityDescriptorBinaryForm)
				{
					sECURITY_ATTRIBUTES.pSecurityDescriptor = pSecurityDescriptor;
				}
			}
		}
		return sECURITY_ATTRIBUTES;
	}

	[SecuritySafeCritical]
	private unsafe void VerifyHandleIsSync()
	{
		byte[] bytes = new byte[1];
		int hr = 0;
		int num = 0;
		if (CanRead)
		{
			num = ReadFileNative(_handle, bytes, 0, 0, null, out hr);
		}
		else if (CanWrite)
		{
			num = WriteFileNative(_handle, bytes, 0, 0, null, out hr);
		}
		switch (hr)
		{
		case 87:
			throw new ArgumentException(Environment.GetResourceString("Arg_HandleNotSync"));
		case 6:
			__Error.WinIOError(hr, "<OS handle>");
			break;
		}
	}

	[SecuritySafeCritical]
	public FileSecurity GetAccessControl()
	{
		if (_handle.IsClosed)
		{
			__Error.FileNotOpen();
		}
		return new FileSecurity(_handle, _fileName, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group);
	}

	[SecuritySafeCritical]
	public void SetAccessControl(FileSecurity fileSecurity)
	{
		if (fileSecurity == null)
		{
			throw new ArgumentNullException("fileSecurity");
		}
		if (_handle.IsClosed)
		{
			__Error.FileNotOpen();
		}
		fileSecurity.Persist(_handle, _fileName);
	}

	[SecuritySafeCritical]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (_handle != null && !_handle.IsClosed && _writePos > 0)
			{
				FlushWrite(!disposing);
			}
		}
		finally
		{
			if (_handle != null && !_handle.IsClosed)
			{
				_handle.Dispose();
			}
			_canRead = false;
			_canWrite = false;
			_canSeek = false;
			base.Dispose(disposing);
		}
	}

	[SecuritySafeCritical]
	~FileStream()
	{
		if (_handle != null)
		{
			Dispose(disposing: false);
		}
	}

	public override void Flush()
	{
		Flush(flushToDisk: false);
	}

	[SecuritySafeCritical]
	public virtual void Flush(bool flushToDisk)
	{
		if (_handle.IsClosed)
		{
			__Error.FileNotOpen();
		}
		FlushInternalBuffer();
		if (flushToDisk && CanWrite)
		{
			FlushOSBuffer();
		}
	}

	private void FlushInternalBuffer()
	{
		if (_writePos > 0)
		{
			FlushWrite(calledFromFinalizer: false);
		}
		else if (_readPos < _readLen && CanSeek)
		{
			FlushRead();
		}
	}

	[SecuritySafeCritical]
	private void FlushOSBuffer()
	{
		if (!Win32Native.FlushFileBuffers(_handle))
		{
			__Error.WinIOError();
		}
	}

	private void FlushRead()
	{
		if (_readPos - _readLen != 0)
		{
			SeekCore(_readPos - _readLen, SeekOrigin.Current);
		}
		_readPos = 0;
		_readLen = 0;
	}

	private void FlushWrite(bool calledFromFinalizer)
	{
		if (_isAsync)
		{
			IAsyncResult asyncResult = BeginWriteCore(_buffer, 0, _writePos, null, null);
			if (!calledFromFinalizer)
			{
				EndWrite(asyncResult);
			}
		}
		else
		{
			WriteCore(_buffer, 0, _writePos);
		}
		_writePos = 0;
	}

	[SecuritySafeCritical]
	public override void SetLength(long value)
	{
		if (value < 0)
		{
			throw new ArgumentOutOfRangeException("value", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (_handle.IsClosed)
		{
			__Error.FileNotOpen();
		}
		if (!CanSeek)
		{
			__Error.SeekNotSupported();
		}
		if (!CanWrite)
		{
			__Error.WriteNotSupported();
		}
		if (_writePos > 0)
		{
			FlushWrite(calledFromFinalizer: false);
		}
		else if (_readPos < _readLen)
		{
			FlushRead();
		}
		_readPos = 0;
		_readLen = 0;
		if (_appendStart != -1 && value < _appendStart)
		{
			throw new IOException(Environment.GetResourceString("IO.IO_SetLengthAppendTruncate"));
		}
		SetLengthCore(value);
	}

	[SecuritySafeCritical]
	private void SetLengthCore(long value)
	{
		long pos = _pos;
		if (_exposedHandle)
		{
			VerifyOSHandlePosition();
		}
		if (_pos != value)
		{
			SeekCore(value, SeekOrigin.Begin);
		}
		if (!Win32Native.SetEndOfFile(_handle))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error == 87)
			{
				throw new ArgumentOutOfRangeException("value", Environment.GetResourceString("ArgumentOutOfRange_FileLengthTooBig"));
			}
			__Error.WinIOError(lastWin32Error, string.Empty);
		}
		if (pos != value)
		{
			if (pos < value)
			{
				SeekCore(pos, SeekOrigin.Begin);
			}
			else
			{
				SeekCore(0L, SeekOrigin.End);
			}
		}
	}

	[SecuritySafeCritical]
	public override int Read([In][Out] byte[] array, int offset, int count)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array", Environment.GetResourceString("ArgumentNull_Buffer"));
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (array.Length - offset < count)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		if (_handle.IsClosed)
		{
			__Error.FileNotOpen();
		}
		bool flag = false;
		int num = _readLen - _readPos;
		if (num == 0)
		{
			if (!CanRead)
			{
				__Error.ReadNotSupported();
			}
			if (_writePos > 0)
			{
				FlushWrite(calledFromFinalizer: false);
			}
			if (!CanSeek || count >= _bufferSize)
			{
				num = ReadCore(array, offset, count);
				_readPos = 0;
				_readLen = 0;
				return num;
			}
			if (_buffer == null)
			{
				_buffer = new byte[_bufferSize];
			}
			num = ReadCore(_buffer, 0, _bufferSize);
			if (num == 0)
			{
				return 0;
			}
			flag = num < _bufferSize;
			_readPos = 0;
			_readLen = num;
		}
		if (num > count)
		{
			num = count;
		}
		Buffer.InternalBlockCopy(_buffer, _readPos, array, offset, num);
		_readPos += num;
		if (!_isPipe && num < count && !flag)
		{
			int num2 = ReadCore(array, offset + num, count - num);
			num += num2;
			_readPos = 0;
			_readLen = 0;
		}
		return num;
	}

	[SecuritySafeCritical]
	private unsafe int ReadCore(byte[] buffer, int offset, int count)
	{
		if (_isAsync)
		{
			IAsyncResult asyncResult = BeginReadCore(buffer, offset, count, null, null, 0);
			return EndRead(asyncResult);
		}
		if (_exposedHandle)
		{
			VerifyOSHandlePosition();
		}
		int hr = 0;
		int num = ReadFileNative(_handle, buffer, offset, count, null, out hr);
		if (num == -1)
		{
			switch (hr)
			{
			case 109:
				num = 0;
				break;
			case 87:
				throw new ArgumentException(Environment.GetResourceString("Arg_HandleNotSync"));
			default:
				__Error.WinIOError(hr, string.Empty);
				break;
			}
		}
		_pos += num;
		return num;
	}

	[SecuritySafeCritical]
	public override long Seek(long offset, SeekOrigin origin)
	{
		if (origin < SeekOrigin.Begin || origin > SeekOrigin.End)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidSeekOrigin"));
		}
		if (_handle.IsClosed)
		{
			__Error.FileNotOpen();
		}
		if (!CanSeek)
		{
			__Error.SeekNotSupported();
		}
		if (_writePos > 0)
		{
			FlushWrite(calledFromFinalizer: false);
		}
		else if (origin == SeekOrigin.Current)
		{
			offset -= _readLen - _readPos;
		}
		if (_exposedHandle)
		{
			VerifyOSHandlePosition();
		}
		long num = _pos + (_readPos - _readLen);
		long num2 = SeekCore(offset, origin);
		if (_appendStart != -1 && num2 < _appendStart)
		{
			SeekCore(num, SeekOrigin.Begin);
			throw new IOException(Environment.GetResourceString("IO.IO_SeekAppendOverwrite"));
		}
		if (_readLen > 0)
		{
			if (num == num2)
			{
				if (_readPos > 0)
				{
					Buffer.InternalBlockCopy(_buffer, _readPos, _buffer, 0, _readLen - _readPos);
					_readLen -= _readPos;
					_readPos = 0;
				}
				if (_readLen > 0)
				{
					SeekCore(_readLen, SeekOrigin.Current);
				}
			}
			else if (num - _readPos < num2 && num2 < num + _readLen - _readPos)
			{
				int num3 = (int)(num2 - num);
				Buffer.InternalBlockCopy(_buffer, _readPos + num3, _buffer, 0, _readLen - (_readPos + num3));
				_readLen -= _readPos + num3;
				_readPos = 0;
				if (_readLen > 0)
				{
					SeekCore(_readLen, SeekOrigin.Current);
				}
			}
			else
			{
				_readPos = 0;
				_readLen = 0;
			}
		}
		return num2;
	}

	[SecuritySafeCritical]
	private long SeekCore(long offset, SeekOrigin origin)
	{
		int hr = 0;
		long num = 0L;
		num = Win32Native.SetFilePointer(_handle, offset, origin, out hr);
		if (num == -1)
		{
			if (hr == 6)
			{
				_handle.Dispose();
			}
			__Error.WinIOError(hr, string.Empty);
		}
		_pos = num;
		return num;
	}

	private void VerifyOSHandlePosition()
	{
		if (!CanSeek)
		{
			return;
		}
		long pos = _pos;
		long num = SeekCore(0L, SeekOrigin.Current);
		if (num != pos)
		{
			_readPos = 0;
			_readLen = 0;
			if (_writePos > 0)
			{
				_writePos = 0;
				throw new IOException(Environment.GetResourceString("IO.IO_FileStreamHandlePosition"));
			}
		}
	}

	[SecuritySafeCritical]
	public override void Write(byte[] array, int offset, int count)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array", Environment.GetResourceString("ArgumentNull_Buffer"));
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (array.Length - offset < count)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		if (_handle.IsClosed)
		{
			__Error.FileNotOpen();
		}
		if (_writePos == 0)
		{
			if (!CanWrite)
			{
				__Error.WriteNotSupported();
			}
			if (_readPos < _readLen)
			{
				FlushRead();
			}
			_readPos = 0;
			_readLen = 0;
		}
		if (_writePos > 0)
		{
			int num = _bufferSize - _writePos;
			if (num > 0)
			{
				if (num > count)
				{
					num = count;
				}
				Buffer.InternalBlockCopy(array, offset, _buffer, _writePos, num);
				_writePos += num;
				if (count == num)
				{
					return;
				}
				offset += num;
				count -= num;
			}
			if (_isAsync)
			{
				IAsyncResult asyncResult = BeginWriteCore(_buffer, 0, _writePos, null, null);
				EndWrite(asyncResult);
			}
			else
			{
				WriteCore(_buffer, 0, _writePos);
			}
			_writePos = 0;
		}
		if (count >= _bufferSize)
		{
			WriteCore(array, offset, count);
		}
		else if (count != 0)
		{
			if (_buffer == null)
			{
				_buffer = new byte[_bufferSize];
			}
			Buffer.InternalBlockCopy(array, offset, _buffer, _writePos, count);
			_writePos = count;
		}
	}

	[SecuritySafeCritical]
	private unsafe void WriteCore(byte[] buffer, int offset, int count)
	{
		if (_isAsync)
		{
			IAsyncResult asyncResult = BeginWriteCore(buffer, offset, count, null, null);
			EndWrite(asyncResult);
			return;
		}
		if (_exposedHandle)
		{
			VerifyOSHandlePosition();
		}
		int hr = 0;
		int num = WriteFileNative(_handle, buffer, offset, count, null, out hr);
		if (num == -1)
		{
			switch (hr)
			{
			case 232:
				num = 0;
				break;
			case 87:
				throw new IOException(Environment.GetResourceString("IO.IO_FileTooLongOrHandleNotSync"));
			default:
				__Error.WinIOError(hr, string.Empty);
				break;
			}
		}
		_pos += num;
	}

	[SecuritySafeCritical]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override IAsyncResult BeginRead(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (numBytes < 0)
		{
			throw new ArgumentOutOfRangeException("numBytes", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (array.Length - offset < numBytes)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		if (_handle.IsClosed)
		{
			__Error.FileNotOpen();
		}
		if (!_isAsync)
		{
			return base.BeginRead(array, offset, numBytes, userCallback, stateObject);
		}
		return BeginReadAsync(array, offset, numBytes, userCallback, stateObject);
	}

	[SecuritySafeCritical]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	private FileStreamAsyncResult BeginReadAsync(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
	{
		if (!CanRead)
		{
			__Error.ReadNotSupported();
		}
		if (_isPipe)
		{
			if (_readPos < _readLen)
			{
				int num = _readLen - _readPos;
				if (num > numBytes)
				{
					num = numBytes;
				}
				Buffer.InternalBlockCopy(_buffer, _readPos, array, offset, num);
				_readPos += num;
				return FileStreamAsyncResult.CreateBufferedReadResult(num, userCallback, stateObject, isWrite: false);
			}
			return BeginReadCore(array, offset, numBytes, userCallback, stateObject, 0);
		}
		if (_writePos > 0)
		{
			FlushWrite(calledFromFinalizer: false);
		}
		if (_readPos == _readLen)
		{
			if (numBytes < _bufferSize)
			{
				if (_buffer == null)
				{
					_buffer = new byte[_bufferSize];
				}
				IAsyncResult asyncResult = BeginReadCore(_buffer, 0, _bufferSize, null, null, 0);
				_readLen = EndRead(asyncResult);
				int num2 = _readLen;
				if (num2 > numBytes)
				{
					num2 = numBytes;
				}
				Buffer.InternalBlockCopy(_buffer, 0, array, offset, num2);
				_readPos = num2;
				return FileStreamAsyncResult.CreateBufferedReadResult(num2, userCallback, stateObject, isWrite: false);
			}
			_readPos = 0;
			_readLen = 0;
			return BeginReadCore(array, offset, numBytes, userCallback, stateObject, 0);
		}
		int num3 = _readLen - _readPos;
		if (num3 > numBytes)
		{
			num3 = numBytes;
		}
		Buffer.InternalBlockCopy(_buffer, _readPos, array, offset, num3);
		_readPos += num3;
		if (num3 >= numBytes)
		{
			return FileStreamAsyncResult.CreateBufferedReadResult(num3, userCallback, stateObject, isWrite: false);
		}
		_readPos = 0;
		_readLen = 0;
		return BeginReadCore(array, offset + num3, numBytes - num3, userCallback, stateObject, num3);
	}

	[SecuritySafeCritical]
	private unsafe FileStreamAsyncResult BeginReadCore(byte[] bytes, int offset, int numBytes, AsyncCallback userCallback, object stateObject, int numBufferedBytesRead)
	{
		FileStreamAsyncResult fileStreamAsyncResult = new FileStreamAsyncResult(numBufferedBytesRead, bytes, _handle, userCallback, stateObject, isWrite: false);
		NativeOverlapped* overLapped = fileStreamAsyncResult.OverLapped;
		if (CanSeek)
		{
			long length = Length;
			if (_exposedHandle)
			{
				VerifyOSHandlePosition();
			}
			if (_pos + numBytes > length)
			{
				numBytes = (int)((_pos <= length) ? (length - _pos) : 0);
			}
			overLapped->OffsetLow = (int)_pos;
			overLapped->OffsetHigh = (int)(_pos >> 32);
			SeekCore(numBytes, SeekOrigin.Current);
		}
		if (FrameworkEventSource.IsInitialized && FrameworkEventSource.Log.IsEnabled(EventLevel.Informational, (EventKeywords)16L))
		{
			FrameworkEventSource.Log.ThreadTransferSend((long)fileStreamAsyncResult.OverLapped, 2, string.Empty, multiDequeues: false);
		}
		int hr = 0;
		int num = ReadFileNative(_handle, bytes, offset, numBytes, overLapped, out hr);
		if (num == -1 && numBytes != -1)
		{
			switch (hr)
			{
			case 109:
				overLapped->InternalLow = IntPtr.Zero;
				fileStreamAsyncResult.CallUserCallback();
				break;
			default:
				if (!_handle.IsClosed && CanSeek)
				{
					SeekCore(0L, SeekOrigin.Current);
				}
				if (hr == 38)
				{
					__Error.EndOfFile();
				}
				else
				{
					__Error.WinIOError(hr, string.Empty);
				}
				break;
			case 997:
				break;
			}
		}
		return fileStreamAsyncResult;
	}

	[SecuritySafeCritical]
	public override int EndRead(IAsyncResult asyncResult)
	{
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (!_isAsync)
		{
			return base.EndRead(asyncResult);
		}
		FileStreamAsyncResult fileStreamAsyncResult = asyncResult as FileStreamAsyncResult;
		if (fileStreamAsyncResult == null || fileStreamAsyncResult.IsWrite)
		{
			__Error.WrongAsyncResult();
		}
		if (1 == Interlocked.CompareExchange(ref fileStreamAsyncResult._EndXxxCalled, 1, 0))
		{
			__Error.EndReadCalledTwice();
		}
		fileStreamAsyncResult.Wait();
		fileStreamAsyncResult.ReleaseNativeResource();
		if (fileStreamAsyncResult.ErrorCode != 0)
		{
			__Error.WinIOError(fileStreamAsyncResult.ErrorCode, string.Empty);
		}
		return fileStreamAsyncResult.NumBytesRead;
	}

	[SecuritySafeCritical]
	public override int ReadByte()
	{
		if (_handle.IsClosed)
		{
			__Error.FileNotOpen();
		}
		if (_readLen == 0 && !CanRead)
		{
			__Error.ReadNotSupported();
		}
		if (_readPos == _readLen)
		{
			if (_writePos > 0)
			{
				FlushWrite(calledFromFinalizer: false);
			}
			if (_buffer == null)
			{
				_buffer = new byte[_bufferSize];
			}
			_readLen = ReadCore(_buffer, 0, _bufferSize);
			_readPos = 0;
		}
		if (_readPos == _readLen)
		{
			return -1;
		}
		int result = _buffer[_readPos];
		_readPos++;
		return result;
	}

	[SecuritySafeCritical]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (numBytes < 0)
		{
			throw new ArgumentOutOfRangeException("numBytes", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (array.Length - offset < numBytes)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		if (_handle.IsClosed)
		{
			__Error.FileNotOpen();
		}
		if (!_isAsync)
		{
			return base.BeginWrite(array, offset, numBytes, userCallback, stateObject);
		}
		return BeginWriteAsync(array, offset, numBytes, userCallback, stateObject);
	}

	[SecuritySafeCritical]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	private FileStreamAsyncResult BeginWriteAsync(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
	{
		if (!CanWrite)
		{
			__Error.WriteNotSupported();
		}
		if (_isPipe)
		{
			if (_writePos > 0)
			{
				FlushWrite(calledFromFinalizer: false);
			}
			return BeginWriteCore(array, offset, numBytes, userCallback, stateObject);
		}
		if (_writePos == 0)
		{
			if (_readPos < _readLen)
			{
				FlushRead();
			}
			_readPos = 0;
			_readLen = 0;
		}
		int num = _bufferSize - _writePos;
		if (numBytes <= num)
		{
			if (_writePos == 0)
			{
				_buffer = new byte[_bufferSize];
			}
			Buffer.InternalBlockCopy(array, offset, _buffer, _writePos, numBytes);
			_writePos += numBytes;
			return FileStreamAsyncResult.CreateBufferedReadResult(numBytes, userCallback, stateObject, isWrite: true);
		}
		if (_writePos > 0)
		{
			FlushWrite(calledFromFinalizer: false);
		}
		return BeginWriteCore(array, offset, numBytes, userCallback, stateObject);
	}

	[SecuritySafeCritical]
	private unsafe FileStreamAsyncResult BeginWriteCore(byte[] bytes, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
	{
		FileStreamAsyncResult fileStreamAsyncResult = new FileStreamAsyncResult(0, bytes, _handle, userCallback, stateObject, isWrite: true);
		NativeOverlapped* overLapped = fileStreamAsyncResult.OverLapped;
		if (CanSeek)
		{
			long length = Length;
			if (_exposedHandle)
			{
				VerifyOSHandlePosition();
			}
			if (_pos + numBytes > length)
			{
				SetLengthCore(_pos + numBytes);
			}
			overLapped->OffsetLow = (int)_pos;
			overLapped->OffsetHigh = (int)(_pos >> 32);
			SeekCore(numBytes, SeekOrigin.Current);
		}
		if (FrameworkEventSource.IsInitialized && FrameworkEventSource.Log.IsEnabled(EventLevel.Informational, (EventKeywords)16L))
		{
			FrameworkEventSource.Log.ThreadTransferSend((long)fileStreamAsyncResult.OverLapped, 2, string.Empty, multiDequeues: false);
		}
		int hr = 0;
		int num = WriteFileNative(_handle, bytes, offset, numBytes, overLapped, out hr);
		if (num == -1 && numBytes != -1)
		{
			switch (hr)
			{
			case 232:
				fileStreamAsyncResult.CallUserCallback();
				break;
			default:
				if (!_handle.IsClosed && CanSeek)
				{
					SeekCore(0L, SeekOrigin.Current);
				}
				if (hr == 38)
				{
					__Error.EndOfFile();
				}
				else
				{
					__Error.WinIOError(hr, string.Empty);
				}
				break;
			case 997:
				break;
			}
		}
		return fileStreamAsyncResult;
	}

	[SecuritySafeCritical]
	public override void EndWrite(IAsyncResult asyncResult)
	{
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (!_isAsync)
		{
			base.EndWrite(asyncResult);
			return;
		}
		FileStreamAsyncResult fileStreamAsyncResult = asyncResult as FileStreamAsyncResult;
		if (fileStreamAsyncResult == null || !fileStreamAsyncResult.IsWrite)
		{
			__Error.WrongAsyncResult();
		}
		if (1 == Interlocked.CompareExchange(ref fileStreamAsyncResult._EndXxxCalled, 1, 0))
		{
			__Error.EndWriteCalledTwice();
		}
		fileStreamAsyncResult.Wait();
		fileStreamAsyncResult.ReleaseNativeResource();
		if (fileStreamAsyncResult.ErrorCode != 0)
		{
			__Error.WinIOError(fileStreamAsyncResult.ErrorCode, string.Empty);
		}
	}

	[SecuritySafeCritical]
	public override void WriteByte(byte value)
	{
		if (_handle.IsClosed)
		{
			__Error.FileNotOpen();
		}
		if (_writePos == 0)
		{
			if (!CanWrite)
			{
				__Error.WriteNotSupported();
			}
			if (_readPos < _readLen)
			{
				FlushRead();
			}
			_readPos = 0;
			_readLen = 0;
			if (_buffer == null)
			{
				_buffer = new byte[_bufferSize];
			}
		}
		if (_writePos == _bufferSize)
		{
			FlushWrite(calledFromFinalizer: false);
		}
		_buffer[_writePos] = value;
		_writePos++;
	}

	[SecuritySafeCritical]
	public virtual void Lock(long position, long length)
	{
		if (position < 0 || length < 0)
		{
			throw new ArgumentOutOfRangeException((position < 0) ? "position" : "length", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (_handle.IsClosed)
		{
			__Error.FileNotOpen();
		}
		int offsetLow = (int)position;
		int offsetHigh = (int)(position >> 32);
		int countLow = (int)length;
		int countHigh = (int)(length >> 32);
		if (!Win32Native.LockFile(_handle, offsetLow, offsetHigh, countLow, countHigh))
		{
			__Error.WinIOError();
		}
	}

	[SecuritySafeCritical]
	public virtual void Unlock(long position, long length)
	{
		if (position < 0 || length < 0)
		{
			throw new ArgumentOutOfRangeException((position < 0) ? "position" : "length", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (_handle.IsClosed)
		{
			__Error.FileNotOpen();
		}
		int offsetLow = (int)position;
		int offsetHigh = (int)(position >> 32);
		int countLow = (int)length;
		int countHigh = (int)(length >> 32);
		if (!Win32Native.UnlockFile(_handle, offsetLow, offsetHigh, countLow, countHigh))
		{
			__Error.WinIOError();
		}
	}

	[SecurityCritical]
	private unsafe int ReadFileNative(SafeFileHandle handle, byte[] bytes, int offset, int count, NativeOverlapped* overlapped, out int hr)
	{
		if (bytes.Length - offset < count)
		{
			throw new IndexOutOfRangeException(Environment.GetResourceString("IndexOutOfRange_IORaceCondition"));
		}
		if (bytes.Length == 0)
		{
			hr = 0;
			return 0;
		}
		int num = 0;
		int numBytesRead = 0;
		fixed (byte* ptr = bytes)
		{
			num = ((!_isAsync) ? Win32Native.ReadFile(handle, ptr + offset, count, out numBytesRead, IntPtr.Zero) : Win32Native.ReadFile(handle, ptr + offset, count, IntPtr.Zero, overlapped));
		}
		if (num == 0)
		{
			hr = Marshal.GetLastWin32Error();
			if (hr == 109 || hr == 233)
			{
				return -1;
			}
			if (hr == 6)
			{
				_handle.Dispose();
			}
			return -1;
		}
		hr = 0;
		return numBytesRead;
	}

	[SecurityCritical]
	private unsafe int WriteFileNative(SafeFileHandle handle, byte[] bytes, int offset, int count, NativeOverlapped* overlapped, out int hr)
	{
		if (bytes.Length - offset < count)
		{
			throw new IndexOutOfRangeException(Environment.GetResourceString("IndexOutOfRange_IORaceCondition"));
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
			num = ((!_isAsync) ? Win32Native.WriteFile(handle, ptr + offset, count, out numBytesWritten, IntPtr.Zero) : Win32Native.WriteFile(handle, ptr + offset, count, IntPtr.Zero, overlapped));
		}
		if (num == 0)
		{
			hr = Marshal.GetLastWin32Error();
			if (hr == 232)
			{
				return -1;
			}
			if (hr == 6)
			{
				_handle.Dispose();
			}
			return -1;
		}
		hr = 0;
		return numBytesWritten;
	}

	[ComVisible(false)]
	[SecuritySafeCritical]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		if (GetType() != typeof(FileStream))
		{
			return base.ReadAsync(buffer, offset, count, cancellationToken);
		}
		if (cancellationToken.IsCancellationRequested)
		{
			return Task.FromCancellation<int>(cancellationToken);
		}
		if (_handle.IsClosed)
		{
			__Error.FileNotOpen();
		}
		if (!_isAsync)
		{
			return base.ReadAsync(buffer, offset, count, cancellationToken);
		}
		FileStreamReadWriteTask<int> fileStreamReadWriteTask = new FileStreamReadWriteTask<int>(cancellationToken);
		AsyncCallback userCallback = EndReadTask;
		fileStreamReadWriteTask._asyncResult = BeginReadAsync(buffer, offset, count, userCallback, fileStreamReadWriteTask);
		if (fileStreamReadWriteTask._asyncResult.IsAsync && cancellationToken.CanBeCanceled)
		{
			Action<object> callback = CancelTask<int>;
			fileStreamReadWriteTask._registration = cancellationToken.Register(callback, fileStreamReadWriteTask);
			if (fileStreamReadWriteTask._asyncResult.IsCompleted)
			{
				fileStreamReadWriteTask._registration.Dispose();
			}
		}
		return fileStreamReadWriteTask;
	}

	[ComVisible(false)]
	[SecuritySafeCritical]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		if (GetType() != typeof(FileStream))
		{
			return base.WriteAsync(buffer, offset, count, cancellationToken);
		}
		if (cancellationToken.IsCancellationRequested)
		{
			return Task.FromCancellation(cancellationToken);
		}
		if (_handle.IsClosed)
		{
			__Error.FileNotOpen();
		}
		if (!_isAsync)
		{
			return base.WriteAsync(buffer, offset, count, cancellationToken);
		}
		FileStreamReadWriteTask<VoidTaskResult> fileStreamReadWriteTask = new FileStreamReadWriteTask<VoidTaskResult>(cancellationToken);
		AsyncCallback userCallback = EndWriteTask;
		fileStreamReadWriteTask._asyncResult = BeginWriteAsync(buffer, offset, count, userCallback, fileStreamReadWriteTask);
		if (fileStreamReadWriteTask._asyncResult.IsAsync && cancellationToken.CanBeCanceled)
		{
			Action<object> callback = CancelTask<VoidTaskResult>;
			fileStreamReadWriteTask._registration = cancellationToken.Register(callback, fileStreamReadWriteTask);
			if (fileStreamReadWriteTask._asyncResult.IsCompleted)
			{
				fileStreamReadWriteTask._registration.Dispose();
			}
		}
		return fileStreamReadWriteTask;
	}

	[SecuritySafeCritical]
	private static void CancelTask<T>(object state)
	{
		FileStreamReadWriteTask<T> fileStreamReadWriteTask = state as FileStreamReadWriteTask<T>;
		FileStreamAsyncResult asyncResult = fileStreamReadWriteTask._asyncResult;
		try
		{
			if (!asyncResult.IsCompleted)
			{
				asyncResult.Cancel();
			}
		}
		catch (Exception exceptionObject)
		{
			fileStreamReadWriteTask.TrySetException(exceptionObject);
		}
	}

	[SecuritySafeCritical]
	private static void EndReadTask(IAsyncResult iar)
	{
		FileStreamAsyncResult fileStreamAsyncResult = iar as FileStreamAsyncResult;
		FileStreamReadWriteTask<int> fileStreamReadWriteTask = fileStreamAsyncResult.AsyncState as FileStreamReadWriteTask<int>;
		try
		{
			if (fileStreamAsyncResult.IsAsync)
			{
				fileStreamAsyncResult.ReleaseNativeResource();
				fileStreamReadWriteTask._registration.Dispose();
			}
			if (fileStreamAsyncResult.ErrorCode == 995)
			{
				CancellationToken cancellationToken = fileStreamReadWriteTask._cancellationToken;
				fileStreamReadWriteTask.TrySetCanceled(cancellationToken);
			}
			else
			{
				fileStreamReadWriteTask.TrySetResult(fileStreamAsyncResult.NumBytesRead);
			}
		}
		catch (Exception exceptionObject)
		{
			fileStreamReadWriteTask.TrySetException(exceptionObject);
		}
	}

	[SecuritySafeCritical]
	private static void EndWriteTask(IAsyncResult iar)
	{
		FileStreamAsyncResult fileStreamAsyncResult = iar as FileStreamAsyncResult;
		FileStreamReadWriteTask<VoidTaskResult> fileStreamReadWriteTask = iar.AsyncState as FileStreamReadWriteTask<VoidTaskResult>;
		try
		{
			if (fileStreamAsyncResult.IsAsync)
			{
				fileStreamAsyncResult.ReleaseNativeResource();
				fileStreamReadWriteTask._registration.Dispose();
			}
			if (fileStreamAsyncResult.ErrorCode == 995)
			{
				CancellationToken cancellationToken = fileStreamReadWriteTask._cancellationToken;
				fileStreamReadWriteTask.TrySetCanceled(cancellationToken);
			}
			else
			{
				fileStreamReadWriteTask.TrySetResult(default(VoidTaskResult));
			}
		}
		catch (Exception exceptionObject)
		{
			fileStreamReadWriteTask.TrySetException(exceptionObject);
		}
	}

	[ComVisible(false)]
	[SecuritySafeCritical]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		if (GetType() != typeof(FileStream))
		{
			return base.FlushAsync(cancellationToken);
		}
		if (cancellationToken.IsCancellationRequested)
		{
			return Task.FromCancellation(cancellationToken);
		}
		if (_handle.IsClosed)
		{
			__Error.FileNotOpen();
		}
		try
		{
			FlushInternalBuffer();
		}
		catch (Exception exception)
		{
			return Task.FromException(exception);
		}
		if (CanWrite)
		{
			return Task.Factory.StartNew(delegate(object state)
			{
				((FileStream)state).FlushOSBuffer();
			}, this, cancellationToken, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}
		return Task.CompletedTask;
	}
}
