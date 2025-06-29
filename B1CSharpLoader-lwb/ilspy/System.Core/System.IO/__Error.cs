using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using Microsoft.Win32;

namespace System.IO;

internal static class __Error
{
	internal static void EndOfFile()
	{
		throw new EndOfStreamException(System.SR.GetString("IO_EOF_ReadBeyondEOF"));
	}

	internal static void FileNotOpen()
	{
		throw new ObjectDisposedException(null, System.SR.GetString("ObjectDisposed_FileClosed"));
	}

	internal static void PipeNotOpen()
	{
		throw new ObjectDisposedException(null, System.SR.GetString("ObjectDisposed_PipeClosed"));
	}

	internal static void StreamIsClosed()
	{
		throw new ObjectDisposedException(null, System.SR.GetString("ObjectDisposed_StreamIsClosed"));
	}

	internal static void ReadNotSupported()
	{
		throw new NotSupportedException(System.SR.GetString("NotSupported_UnreadableStream"));
	}

	internal static void SeekNotSupported()
	{
		throw new NotSupportedException(System.SR.GetString("NotSupported_UnseekableStream"));
	}

	internal static void WrongAsyncResult()
	{
		throw new ArgumentException(System.SR.GetString("Argument_WrongAsyncResult"));
	}

	internal static void EndReadCalledTwice()
	{
		throw new ArgumentException(System.SR.GetString("InvalidOperation_EndReadCalledMultiple"));
	}

	internal static void EndWriteCalledTwice()
	{
		throw new ArgumentException(System.SR.GetString("InvalidOperation_EndWriteCalledMultiple"));
	}

	internal static void EndWaitForConnectionCalledTwice()
	{
		throw new ArgumentException(System.SR.GetString("InvalidOperation_EndWaitForConnectionCalledMultiple"));
	}

	[SecuritySafeCritical]
	internal static string GetDisplayablePath(string path, bool isInvalidPath)
	{
		if (string.IsNullOrEmpty(path))
		{
			return path;
		}
		bool flag = false;
		if (path.Length < 2)
		{
			return path;
		}
		if (path[0] == Path.DirectorySeparatorChar && path[1] == Path.DirectorySeparatorChar)
		{
			flag = true;
		}
		else if (path[1] == Path.VolumeSeparatorChar)
		{
			flag = true;
		}
		if (!flag && !isInvalidPath)
		{
			return path;
		}
		bool flag2 = false;
		try
		{
			if (!isInvalidPath)
			{
				new FileIOPermission(FileIOPermissionAccess.PathDiscovery, new string[1] { path }).Demand();
				flag2 = true;
			}
		}
		catch (SecurityException)
		{
		}
		catch (ArgumentException)
		{
		}
		catch (NotSupportedException)
		{
		}
		if (!flag2)
		{
			path = ((path[path.Length - 1] != Path.DirectorySeparatorChar) ? Path.GetFileName(path) : System.SR.GetString("IO_IO_NoPermissionToDirectoryName"));
		}
		return path;
	}

	[SecurityCritical]
	internal static void WinIOError()
	{
		int lastWin32Error = Marshal.GetLastWin32Error();
		WinIOError(lastWin32Error, string.Empty);
	}

	[SecurityCritical]
	internal static void WinIOError(int errorCode, string maybeFullPath)
	{
		bool isInvalidPath = errorCode == 123 || errorCode == 161;
		string displayablePath = GetDisplayablePath(maybeFullPath, isInvalidPath);
		switch (errorCode)
		{
		case 2:
			if (displayablePath.Length == 0)
			{
				throw new FileNotFoundException(System.SR.GetString("IO_FileNotFound"));
			}
			throw new FileNotFoundException(string.Format(CultureInfo.CurrentCulture, System.SR.GetString("IO_FileNotFound_FileName"), new object[1] { displayablePath }), displayablePath);
		case 3:
			if (displayablePath.Length == 0)
			{
				throw new DirectoryNotFoundException(System.SR.GetString("IO_PathNotFound_NoPathName"));
			}
			throw new DirectoryNotFoundException(string.Format(CultureInfo.CurrentCulture, System.SR.GetString("IO_PathNotFound_Path"), new object[1] { displayablePath }));
		case 5:
			if (displayablePath.Length == 0)
			{
				throw new UnauthorizedAccessException(System.SR.GetString("UnauthorizedAccess_IODenied_NoPathName"));
			}
			throw new UnauthorizedAccessException(string.Format(CultureInfo.CurrentCulture, System.SR.GetString("UnauthorizedAccess_IODenied_Path"), new object[1] { displayablePath }));
		case 183:
			if (displayablePath.Length != 0)
			{
				throw new IOException(System.SR.GetString("IO_IO_AlreadyExists_Name", displayablePath), Microsoft.Win32.UnsafeNativeMethods.MakeHRFromErrorCode(errorCode));
			}
			break;
		case 206:
			throw new PathTooLongException(System.SR.GetString("IO_PathTooLong"));
		case 15:
			throw new DriveNotFoundException(string.Format(CultureInfo.CurrentCulture, System.SR.GetString("IO_DriveNotFound_Drive"), new object[1] { displayablePath }));
		case 87:
			throw new IOException(Microsoft.Win32.UnsafeNativeMethods.GetMessage(errorCode), Microsoft.Win32.UnsafeNativeMethods.MakeHRFromErrorCode(errorCode));
		case 32:
			if (displayablePath.Length == 0)
			{
				throw new IOException(System.SR.GetString("IO_IO_SharingViolation_NoFileName"), Microsoft.Win32.UnsafeNativeMethods.MakeHRFromErrorCode(errorCode));
			}
			throw new IOException(System.SR.GetString("IO_IO_SharingViolation_File", displayablePath), Microsoft.Win32.UnsafeNativeMethods.MakeHRFromErrorCode(errorCode));
		case 80:
			if (displayablePath.Length != 0)
			{
				throw new IOException(string.Format(CultureInfo.CurrentCulture, System.SR.GetString("IO_IO_FileExists_Name"), new object[1] { displayablePath }), Microsoft.Win32.UnsafeNativeMethods.MakeHRFromErrorCode(errorCode));
			}
			break;
		case 995:
			throw new OperationCanceledException();
		}
		throw new IOException(Microsoft.Win32.UnsafeNativeMethods.GetMessage(errorCode), Microsoft.Win32.UnsafeNativeMethods.MakeHRFromErrorCode(errorCode));
	}

	internal static void WriteNotSupported()
	{
		throw new NotSupportedException(System.SR.GetString("NotSupported_UnwritableStream"));
	}

	internal static void OperationAborted()
	{
		throw new IOException(System.SR.GetString("IO_OperationAborted"));
	}
}
