using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Threading;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.IO.MemoryMappedFiles;

public class MemoryMappedFile : IDisposable
{
	private SafeMemoryMappedFileHandle _handle;

	private bool _leaveOpen;

	private FileStream _fileStream;

	internal const int DefaultSize = 0;

	public SafeMemoryMappedFileHandle SafeMemoryMappedFileHandle
	{
		[SecurityCritical]
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		get
		{
			return _handle;
		}
	}

	[SecurityCritical]
	private MemoryMappedFile(SafeMemoryMappedFileHandle handle)
	{
		_handle = handle;
		_leaveOpen = true;
	}

	[SecurityCritical]
	private MemoryMappedFile(SafeMemoryMappedFileHandle handle, FileStream fileStream, bool leaveOpen)
	{
		_handle = handle;
		_fileStream = fileStream;
		_leaveOpen = leaveOpen;
	}

	public static MemoryMappedFile OpenExisting(string mapName)
	{
		return OpenExisting(mapName, MemoryMappedFileRights.ReadWrite, HandleInheritability.None);
	}

	public static MemoryMappedFile OpenExisting(string mapName, MemoryMappedFileRights desiredAccessRights)
	{
		return OpenExisting(mapName, desiredAccessRights, HandleInheritability.None);
	}

	[SecurityCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public static MemoryMappedFile OpenExisting(string mapName, MemoryMappedFileRights desiredAccessRights, HandleInheritability inheritability)
	{
		if (mapName == null)
		{
			throw new ArgumentNullException("mapName", System.SR.GetString("ArgumentNull_MapName"));
		}
		if (mapName.Length == 0)
		{
			throw new ArgumentException(System.SR.GetString("Argument_MapNameEmptyString"));
		}
		if (inheritability < HandleInheritability.None || inheritability > HandleInheritability.Inheritable)
		{
			throw new ArgumentOutOfRangeException("inheritability");
		}
		if ((desiredAccessRights & ~(MemoryMappedFileRights.FullControl | MemoryMappedFileRights.AccessSystemSecurity)) != 0)
		{
			throw new ArgumentOutOfRangeException("desiredAccessRights");
		}
		SafeMemoryMappedFileHandle handle = OpenCore(mapName, inheritability, (int)desiredAccessRights, createOrOpen: false);
		return new MemoryMappedFile(handle);
	}

	public static MemoryMappedFile CreateFromFile(string path)
	{
		return CreateFromFile(path, FileMode.Open, null, 0L, MemoryMappedFileAccess.ReadWrite);
	}

	public static MemoryMappedFile CreateFromFile(string path, FileMode mode)
	{
		return CreateFromFile(path, mode, null, 0L, MemoryMappedFileAccess.ReadWrite);
	}

	public static MemoryMappedFile CreateFromFile(string path, FileMode mode, string mapName)
	{
		return CreateFromFile(path, mode, mapName, 0L, MemoryMappedFileAccess.ReadWrite);
	}

	public static MemoryMappedFile CreateFromFile(string path, FileMode mode, string mapName, long capacity)
	{
		return CreateFromFile(path, mode, mapName, capacity, MemoryMappedFileAccess.ReadWrite);
	}

	[SecurityCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public static MemoryMappedFile CreateFromFile(string path, FileMode mode, string mapName, long capacity, MemoryMappedFileAccess access)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (mapName != null && mapName.Length == 0)
		{
			throw new ArgumentException(System.SR.GetString("Argument_MapNameEmptyString"));
		}
		if (capacity < 0)
		{
			throw new ArgumentOutOfRangeException("capacity", System.SR.GetString("ArgumentOutOfRange_PositiveOrDefaultCapacityRequired"));
		}
		if (access < MemoryMappedFileAccess.ReadWrite || access > MemoryMappedFileAccess.ReadWriteExecute)
		{
			throw new ArgumentOutOfRangeException("access");
		}
		if (mode == FileMode.Append)
		{
			throw new ArgumentException(System.SR.GetString("Argument_NewMMFAppendModeNotAllowed"), "mode");
		}
		if (access == MemoryMappedFileAccess.Write)
		{
			throw new ArgumentException(System.SR.GetString("Argument_NewMMFWriteAccessNotAllowed"), "access");
		}
		bool existed = File.Exists(path);
		FileStream fileStream = new FileStream(path, mode, GetFileStreamFileSystemRights(access), FileShare.None, 4096, FileOptions.None);
		if (capacity == 0L && fileStream.Length == 0L)
		{
			CleanupFile(fileStream, existed, path);
			throw new ArgumentException(System.SR.GetString("Argument_EmptyFile"));
		}
		if (access == MemoryMappedFileAccess.Read && capacity > fileStream.Length)
		{
			CleanupFile(fileStream, existed, path);
			throw new ArgumentException(System.SR.GetString("Argument_ReadAccessWithLargeCapacity"));
		}
		if (capacity == 0L)
		{
			capacity = fileStream.Length;
		}
		if (fileStream.Length > capacity)
		{
			CleanupFile(fileStream, existed, path);
			throw new ArgumentOutOfRangeException("capacity", System.SR.GetString("ArgumentOutOfRange_CapacityGEFileSizeRequired"));
		}
		SafeMemoryMappedFileHandle safeMemoryMappedFileHandle = null;
		try
		{
			safeMemoryMappedFileHandle = CreateCore(fileStream.SafeFileHandle, mapName, HandleInheritability.None, null, access, MemoryMappedFileOptions.None, capacity);
		}
		catch
		{
			CleanupFile(fileStream, existed, path);
			throw;
		}
		return new MemoryMappedFile(safeMemoryMappedFileHandle, fileStream, leaveOpen: false);
	}

	public static MemoryMappedFile CreateFromFile(FileStream fileStream, string mapName, long capacity, MemoryMappedFileAccess access, HandleInheritability inheritability, bool leaveOpen)
	{
		return CreateFromFile(fileStream, mapName, capacity, access, null, inheritability, leaveOpen);
	}

	[SecurityCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public static MemoryMappedFile CreateFromFile(FileStream fileStream, string mapName, long capacity, MemoryMappedFileAccess access, MemoryMappedFileSecurity memoryMappedFileSecurity, HandleInheritability inheritability, bool leaveOpen)
	{
		if (fileStream == null)
		{
			throw new ArgumentNullException("fileStream", System.SR.GetString("ArgumentNull_FileStream"));
		}
		if (mapName != null && mapName.Length == 0)
		{
			throw new ArgumentException(System.SR.GetString("Argument_MapNameEmptyString"));
		}
		if (capacity < 0)
		{
			throw new ArgumentOutOfRangeException("capacity", System.SR.GetString("ArgumentOutOfRange_PositiveOrDefaultCapacityRequired"));
		}
		if (capacity == 0L && fileStream.Length == 0L)
		{
			throw new ArgumentException(System.SR.GetString("Argument_EmptyFile"));
		}
		switch (access)
		{
		default:
			throw new ArgumentOutOfRangeException("access");
		case MemoryMappedFileAccess.Write:
			throw new ArgumentException(System.SR.GetString("Argument_NewMMFWriteAccessNotAllowed"), "access");
		case MemoryMappedFileAccess.Read:
			if (capacity > fileStream.Length)
			{
				throw new ArgumentException(System.SR.GetString("Argument_ReadAccessWithLargeCapacity"));
			}
			break;
		case MemoryMappedFileAccess.ReadWrite:
		case MemoryMappedFileAccess.CopyOnWrite:
		case MemoryMappedFileAccess.ReadExecute:
		case MemoryMappedFileAccess.ReadWriteExecute:
			break;
		}
		if (inheritability < HandleInheritability.None || inheritability > HandleInheritability.Inheritable)
		{
			throw new ArgumentOutOfRangeException("inheritability");
		}
		fileStream.Flush();
		if (capacity == 0L)
		{
			capacity = fileStream.Length;
		}
		if (fileStream.Length > capacity)
		{
			throw new ArgumentOutOfRangeException("capacity", System.SR.GetString("ArgumentOutOfRange_CapacityGEFileSizeRequired"));
		}
		SafeMemoryMappedFileHandle handle = CreateCore(fileStream.SafeFileHandle, mapName, inheritability, memoryMappedFileSecurity, access, MemoryMappedFileOptions.None, capacity);
		return new MemoryMappedFile(handle, fileStream, leaveOpen);
	}

	public static MemoryMappedFile CreateNew(string mapName, long capacity)
	{
		return CreateNew(mapName, capacity, MemoryMappedFileAccess.ReadWrite, MemoryMappedFileOptions.None, null, HandleInheritability.None);
	}

	public static MemoryMappedFile CreateNew(string mapName, long capacity, MemoryMappedFileAccess access)
	{
		return CreateNew(mapName, capacity, access, MemoryMappedFileOptions.None, null, HandleInheritability.None);
	}

	public static MemoryMappedFile CreateNew(string mapName, long capacity, MemoryMappedFileAccess access, MemoryMappedFileOptions options, HandleInheritability inheritability)
	{
		return CreateNew(mapName, capacity, access, options, null, inheritability);
	}

	[SecurityCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public static MemoryMappedFile CreateNew(string mapName, long capacity, MemoryMappedFileAccess access, MemoryMappedFileOptions options, MemoryMappedFileSecurity memoryMappedFileSecurity, HandleInheritability inheritability)
	{
		if (mapName != null && mapName.Length == 0)
		{
			throw new ArgumentException(System.SR.GetString("Argument_MapNameEmptyString"));
		}
		if (capacity <= 0)
		{
			throw new ArgumentOutOfRangeException("capacity", System.SR.GetString("ArgumentOutOfRange_NeedPositiveNumber"));
		}
		if (IntPtr.Size == 4 && capacity > uint.MaxValue)
		{
			throw new ArgumentOutOfRangeException("capacity", System.SR.GetString("ArgumentOutOfRange_CapacityLargerThanLogicalAddressSpaceNotAllowed"));
		}
		switch (access)
		{
		default:
			throw new ArgumentOutOfRangeException("access");
		case MemoryMappedFileAccess.Write:
			throw new ArgumentException(System.SR.GetString("Argument_NewMMFWriteAccessNotAllowed"), "access");
		case MemoryMappedFileAccess.ReadWrite:
		case MemoryMappedFileAccess.Read:
		case MemoryMappedFileAccess.CopyOnWrite:
		case MemoryMappedFileAccess.ReadExecute:
		case MemoryMappedFileAccess.ReadWriteExecute:
		{
			if ((options & ~MemoryMappedFileOptions.DelayAllocatePages) != MemoryMappedFileOptions.None)
			{
				throw new ArgumentOutOfRangeException("options");
			}
			if (inheritability < HandleInheritability.None || inheritability > HandleInheritability.Inheritable)
			{
				throw new ArgumentOutOfRangeException("inheritability");
			}
			SafeMemoryMappedFileHandle handle = CreateCore(new SafeFileHandle(new IntPtr(-1), ownsHandle: true), mapName, inheritability, memoryMappedFileSecurity, access, options, capacity);
			return new MemoryMappedFile(handle);
		}
		}
	}

	public static MemoryMappedFile CreateOrOpen(string mapName, long capacity)
	{
		return CreateOrOpen(mapName, capacity, MemoryMappedFileAccess.ReadWrite, MemoryMappedFileOptions.None, null, HandleInheritability.None);
	}

	public static MemoryMappedFile CreateOrOpen(string mapName, long capacity, MemoryMappedFileAccess access)
	{
		return CreateOrOpen(mapName, capacity, access, MemoryMappedFileOptions.None, null, HandleInheritability.None);
	}

	public static MemoryMappedFile CreateOrOpen(string mapName, long capacity, MemoryMappedFileAccess access, MemoryMappedFileOptions options, HandleInheritability inheritability)
	{
		return CreateOrOpen(mapName, capacity, access, options, null, inheritability);
	}

	[SecurityCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public static MemoryMappedFile CreateOrOpen(string mapName, long capacity, MemoryMappedFileAccess access, MemoryMappedFileOptions options, MemoryMappedFileSecurity memoryMappedFileSecurity, HandleInheritability inheritability)
	{
		if (mapName == null)
		{
			throw new ArgumentNullException("mapName", System.SR.GetString("ArgumentNull_MapName"));
		}
		if (mapName.Length == 0)
		{
			throw new ArgumentException(System.SR.GetString("Argument_MapNameEmptyString"));
		}
		if (capacity <= 0)
		{
			throw new ArgumentOutOfRangeException("capacity", System.SR.GetString("ArgumentOutOfRange_NeedPositiveNumber"));
		}
		if (IntPtr.Size == 4 && capacity > uint.MaxValue)
		{
			throw new ArgumentOutOfRangeException("capacity", System.SR.GetString("ArgumentOutOfRange_CapacityLargerThanLogicalAddressSpaceNotAllowed"));
		}
		if (access < MemoryMappedFileAccess.ReadWrite || access > MemoryMappedFileAccess.ReadWriteExecute)
		{
			throw new ArgumentOutOfRangeException("access");
		}
		if ((options & ~MemoryMappedFileOptions.DelayAllocatePages) != MemoryMappedFileOptions.None)
		{
			throw new ArgumentOutOfRangeException("options");
		}
		if (inheritability < HandleInheritability.None || inheritability > HandleInheritability.Inheritable)
		{
			throw new ArgumentOutOfRangeException("inheritability");
		}
		SafeMemoryMappedFileHandle handle = ((access != MemoryMappedFileAccess.Write) ? CreateOrOpenCore(new SafeFileHandle(new IntPtr(-1), ownsHandle: true), mapName, inheritability, memoryMappedFileSecurity, access, options, capacity) : OpenCore(mapName, inheritability, GetFileMapAccess(access), createOrOpen: true));
		return new MemoryMappedFile(handle);
	}

	[SecurityCritical]
	private static SafeMemoryMappedFileHandle CreateCore(SafeFileHandle fileHandle, string mapName, HandleInheritability inheritability, MemoryMappedFileSecurity memoryMappedFileSecurity, MemoryMappedFileAccess access, MemoryMappedFileOptions options, long capacity)
	{
		SafeMemoryMappedFileHandle safeMemoryMappedFileHandle = null;
		object pinningHandle;
		Microsoft.Win32.UnsafeNativeMethods.SECURITY_ATTRIBUTES secAttrs = GetSecAttrs(inheritability, memoryMappedFileSecurity, out pinningHandle);
		int dwMaximumSizeLow = (int)(capacity & 0xFFFFFFFFu);
		int dwMaximumSizeHigh = (int)(capacity >> 32);
		try
		{
			safeMemoryMappedFileHandle = Microsoft.Win32.UnsafeNativeMethods.CreateFileMapping(fileHandle, secAttrs, GetPageAccess(access) | (int)options, dwMaximumSizeHigh, dwMaximumSizeLow, mapName);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!safeMemoryMappedFileHandle.IsInvalid && lastWin32Error == 183)
			{
				safeMemoryMappedFileHandle.Dispose();
				__Error.WinIOError(lastWin32Error, string.Empty);
			}
			else if (safeMemoryMappedFileHandle.IsInvalid)
			{
				__Error.WinIOError(lastWin32Error, string.Empty);
			}
		}
		finally
		{
			if (pinningHandle != null)
			{
				((GCHandle)pinningHandle).Free();
			}
		}
		return safeMemoryMappedFileHandle;
	}

	[SecurityCritical]
	private static SafeMemoryMappedFileHandle OpenCore(string mapName, HandleInheritability inheritability, int desiredAccessRights, bool createOrOpen)
	{
		SafeMemoryMappedFileHandle safeMemoryMappedFileHandle = Microsoft.Win32.UnsafeNativeMethods.OpenFileMapping(desiredAccessRights, (inheritability & HandleInheritability.Inheritable) != 0, mapName);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (safeMemoryMappedFileHandle.IsInvalid)
		{
			if (createOrOpen && lastWin32Error == 2)
			{
				throw new ArgumentException(System.SR.GetString("Argument_NewMMFWriteAccessNotAllowed"), "access");
			}
			__Error.WinIOError(lastWin32Error, string.Empty);
		}
		return safeMemoryMappedFileHandle;
	}

	[SecurityCritical]
	private static SafeMemoryMappedFileHandle CreateOrOpenCore(SafeFileHandle fileHandle, string mapName, HandleInheritability inheritability, MemoryMappedFileSecurity memoryMappedFileSecurity, MemoryMappedFileAccess access, MemoryMappedFileOptions options, long capacity)
	{
		SafeMemoryMappedFileHandle safeMemoryMappedFileHandle = null;
		object pinningHandle;
		Microsoft.Win32.UnsafeNativeMethods.SECURITY_ATTRIBUTES secAttrs = GetSecAttrs(inheritability, memoryMappedFileSecurity, out pinningHandle);
		int dwMaximumSizeLow = (int)(capacity & 0xFFFFFFFFu);
		int dwMaximumSizeHigh = (int)(capacity >> 32);
		try
		{
			int num = 14;
			int num2 = 0;
			while (num > 0)
			{
				safeMemoryMappedFileHandle = Microsoft.Win32.UnsafeNativeMethods.CreateFileMapping(fileHandle, secAttrs, GetPageAccess(access) | (int)options, dwMaximumSizeHigh, dwMaximumSizeLow, mapName);
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (!safeMemoryMappedFileHandle.IsInvalid)
				{
					break;
				}
				if (lastWin32Error != 5)
				{
					__Error.WinIOError(lastWin32Error, string.Empty);
				}
				safeMemoryMappedFileHandle.SetHandleAsInvalid();
				safeMemoryMappedFileHandle = Microsoft.Win32.UnsafeNativeMethods.OpenFileMapping(GetFileMapAccess(access), (inheritability & HandleInheritability.Inheritable) != 0, mapName);
				int lastWin32Error2 = Marshal.GetLastWin32Error();
				if (!safeMemoryMappedFileHandle.IsInvalid)
				{
					break;
				}
				if (lastWin32Error2 != 2)
				{
					__Error.WinIOError(lastWin32Error2, string.Empty);
				}
				num--;
				if (num2 == 0)
				{
					num2 = 10;
					continue;
				}
				Thread.Sleep(num2);
				num2 *= 2;
			}
			if (safeMemoryMappedFileHandle == null || safeMemoryMappedFileHandle.IsInvalid)
			{
				throw new InvalidOperationException(System.SR.GetString("InvalidOperation_CantCreateFileMapping"));
			}
			return safeMemoryMappedFileHandle;
		}
		finally
		{
			if (pinningHandle != null)
			{
				((GCHandle)pinningHandle).Free();
			}
		}
	}

	public MemoryMappedViewStream CreateViewStream()
	{
		return CreateViewStream(0L, 0L, MemoryMappedFileAccess.ReadWrite);
	}

	public MemoryMappedViewStream CreateViewStream(long offset, long size)
	{
		return CreateViewStream(offset, size, MemoryMappedFileAccess.ReadWrite);
	}

	[SecurityCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public MemoryMappedViewStream CreateViewStream(long offset, long size, MemoryMappedFileAccess access)
	{
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", System.SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (size < 0)
		{
			throw new ArgumentOutOfRangeException("size", System.SR.GetString("ArgumentOutOfRange_PositiveOrDefaultSizeRequired"));
		}
		if (access < MemoryMappedFileAccess.ReadWrite || access > MemoryMappedFileAccess.ReadWriteExecute)
		{
			throw new ArgumentOutOfRangeException("access");
		}
		if (IntPtr.Size == 4 && size > uint.MaxValue)
		{
			throw new ArgumentOutOfRangeException("size", System.SR.GetString("ArgumentOutOfRange_CapacityLargerThanLogicalAddressSpaceNotAllowed"));
		}
		MemoryMappedView view = MemoryMappedView.CreateView(_handle, access, offset, size);
		return new MemoryMappedViewStream(view);
	}

	public MemoryMappedViewAccessor CreateViewAccessor()
	{
		return CreateViewAccessor(0L, 0L, MemoryMappedFileAccess.ReadWrite);
	}

	public MemoryMappedViewAccessor CreateViewAccessor(long offset, long size)
	{
		return CreateViewAccessor(offset, size, MemoryMappedFileAccess.ReadWrite);
	}

	[SecurityCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public MemoryMappedViewAccessor CreateViewAccessor(long offset, long size, MemoryMappedFileAccess access)
	{
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", System.SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (size < 0)
		{
			throw new ArgumentOutOfRangeException("size", System.SR.GetString("ArgumentOutOfRange_PositiveOrDefaultSizeRequired"));
		}
		if (access < MemoryMappedFileAccess.ReadWrite || access > MemoryMappedFileAccess.ReadWriteExecute)
		{
			throw new ArgumentOutOfRangeException("access");
		}
		if (IntPtr.Size == 4 && size > uint.MaxValue)
		{
			throw new ArgumentOutOfRangeException("size", System.SR.GetString("ArgumentOutOfRange_CapacityLargerThanLogicalAddressSpaceNotAllowed"));
		}
		MemoryMappedView view = MemoryMappedView.CreateView(_handle, access, offset, size);
		return new MemoryMappedViewAccessor(view);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[SecuritySafeCritical]
	protected virtual void Dispose(bool disposing)
	{
		try
		{
			if (_handle != null && !_handle.IsClosed)
			{
				_handle.Dispose();
			}
		}
		finally
		{
			if (_fileStream != null && !_leaveOpen)
			{
				_fileStream.Dispose();
			}
		}
	}

	[SecurityCritical]
	public MemoryMappedFileSecurity GetAccessControl()
	{
		if (_handle.IsClosed)
		{
			__Error.FileNotOpen();
		}
		return new MemoryMappedFileSecurity(_handle, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group);
	}

	[SecurityCritical]
	public void SetAccessControl(MemoryMappedFileSecurity memoryMappedFileSecurity)
	{
		if (memoryMappedFileSecurity == null)
		{
			throw new ArgumentNullException("memoryMappedFileSecurity");
		}
		if (_handle.IsClosed)
		{
			__Error.FileNotOpen();
		}
		memoryMappedFileSecurity.PersistHandle(_handle);
	}

	[SecurityCritical]
	internal static int GetSystemPageAllocationGranularity()
	{
		Microsoft.Win32.UnsafeNativeMethods.SYSTEM_INFO lpSystemInfo = default(Microsoft.Win32.UnsafeNativeMethods.SYSTEM_INFO);
		Microsoft.Win32.UnsafeNativeMethods.GetSystemInfo(ref lpSystemInfo);
		return lpSystemInfo.dwAllocationGranularity;
	}

	internal static int GetPageAccess(MemoryMappedFileAccess access)
	{
		return access switch
		{
			MemoryMappedFileAccess.Read => 2, 
			MemoryMappedFileAccess.ReadWrite => 4, 
			MemoryMappedFileAccess.CopyOnWrite => 8, 
			MemoryMappedFileAccess.ReadExecute => 32, 
			MemoryMappedFileAccess.ReadWriteExecute => 64, 
			_ => throw new ArgumentOutOfRangeException("access"), 
		};
	}

	internal static int GetFileMapAccess(MemoryMappedFileAccess access)
	{
		return access switch
		{
			MemoryMappedFileAccess.Read => 4, 
			MemoryMappedFileAccess.Write => 2, 
			MemoryMappedFileAccess.ReadWrite => 6, 
			MemoryMappedFileAccess.CopyOnWrite => 1, 
			MemoryMappedFileAccess.ReadExecute => 36, 
			MemoryMappedFileAccess.ReadWriteExecute => 38, 
			_ => throw new ArgumentOutOfRangeException("access"), 
		};
	}

	private static FileSystemRights GetFileStreamFileSystemRights(MemoryMappedFileAccess access)
	{
		switch (access)
		{
		case MemoryMappedFileAccess.Read:
		case MemoryMappedFileAccess.CopyOnWrite:
			return FileSystemRights.ReadData;
		case MemoryMappedFileAccess.ReadWrite:
			return FileSystemRights.ReadData | FileSystemRights.WriteData;
		case MemoryMappedFileAccess.Write:
			return FileSystemRights.WriteData;
		case MemoryMappedFileAccess.ReadExecute:
			return FileSystemRights.ReadData | FileSystemRights.ExecuteFile;
		case MemoryMappedFileAccess.ReadWriteExecute:
			return FileSystemRights.ReadData | FileSystemRights.WriteData | FileSystemRights.ExecuteFile;
		default:
			throw new ArgumentOutOfRangeException("access");
		}
	}

	internal static FileAccess GetFileAccess(MemoryMappedFileAccess access)
	{
		return access switch
		{
			MemoryMappedFileAccess.Read => FileAccess.Read, 
			MemoryMappedFileAccess.Write => FileAccess.Write, 
			MemoryMappedFileAccess.ReadWrite => FileAccess.ReadWrite, 
			MemoryMappedFileAccess.CopyOnWrite => FileAccess.ReadWrite, 
			MemoryMappedFileAccess.ReadExecute => FileAccess.Read, 
			MemoryMappedFileAccess.ReadWriteExecute => FileAccess.ReadWrite, 
			_ => throw new ArgumentOutOfRangeException("access"), 
		};
	}

	[SecurityCritical]
	private unsafe static Microsoft.Win32.UnsafeNativeMethods.SECURITY_ATTRIBUTES GetSecAttrs(HandleInheritability inheritability, MemoryMappedFileSecurity memoryMappedFileSecurity, out object pinningHandle)
	{
		pinningHandle = null;
		Microsoft.Win32.UnsafeNativeMethods.SECURITY_ATTRIBUTES sECURITY_ATTRIBUTES = null;
		if ((inheritability & HandleInheritability.Inheritable) != HandleInheritability.None || memoryMappedFileSecurity != null)
		{
			sECURITY_ATTRIBUTES = new Microsoft.Win32.UnsafeNativeMethods.SECURITY_ATTRIBUTES();
			sECURITY_ATTRIBUTES.nLength = Marshal.SizeOf((object)sECURITY_ATTRIBUTES);
			if ((inheritability & HandleInheritability.Inheritable) != HandleInheritability.None)
			{
				sECURITY_ATTRIBUTES.bInheritHandle = 1;
			}
			if (memoryMappedFileSecurity != null)
			{
				byte[] securityDescriptorBinaryForm = memoryMappedFileSecurity.GetSecurityDescriptorBinaryForm();
				pinningHandle = GCHandle.Alloc(securityDescriptorBinaryForm, GCHandleType.Pinned);
				fixed (byte* pSecurityDescriptor = securityDescriptorBinaryForm)
				{
					sECURITY_ATTRIBUTES.pSecurityDescriptor = pSecurityDescriptor;
				}
			}
		}
		return sECURITY_ATTRIBUTES;
	}

	private static void CleanupFile(FileStream fileStream, bool existed, string path)
	{
		fileStream.Close();
		if (!existed)
		{
			File.Delete(path);
		}
	}
}
