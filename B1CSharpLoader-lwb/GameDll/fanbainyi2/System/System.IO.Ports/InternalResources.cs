using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32;

namespace System.IO.Ports;

internal static class InternalResources
{
	internal static void EndOfFile()
	{
		throw new EndOfStreamException(SR.GetString("IO_EOF_ReadBeyondEOF"));
	}

	internal static string GetMessage(int errorCode)
	{
		StringBuilder stringBuilder = new StringBuilder(512);
		if (Microsoft.Win32.SafeNativeMethods.FormatMessage(12800, IntPtr.Zero, (uint)errorCode, 0, stringBuilder, stringBuilder.Capacity, null) != 0)
		{
			return stringBuilder.ToString();
		}
		return SR.GetString("IO_UnknownError", errorCode);
	}

	internal static void FileNotOpen()
	{
		throw new ObjectDisposedException(null, SR.GetString("Port_not_open"));
	}

	internal static void WrongAsyncResult()
	{
		throw new ArgumentException(SR.GetString("Arg_WrongAsyncResult"));
	}

	internal static void EndReadCalledTwice()
	{
		throw new ArgumentException(SR.GetString("InvalidOperation_EndReadCalledMultiple"));
	}

	internal static void EndWriteCalledTwice()
	{
		throw new ArgumentException(SR.GetString("InvalidOperation_EndWriteCalledMultiple"));
	}

	internal static void WinIOError()
	{
		int lastWin32Error = Marshal.GetLastWin32Error();
		WinIOError(lastWin32Error, string.Empty);
	}

	internal static void WinIOError(string str)
	{
		int lastWin32Error = Marshal.GetLastWin32Error();
		WinIOError(lastWin32Error, str);
	}

	internal static void WinIOError(int errorCode, string str)
	{
		switch (errorCode)
		{
		case 2:
		case 3:
			if (str.Length == 0)
			{
				throw new IOException(SR.GetString("IO_PortNotFound"));
			}
			throw new IOException(SR.GetString("IO_PortNotFoundFileName", str));
		case 5:
			if (str.Length == 0)
			{
				throw new UnauthorizedAccessException(SR.GetString("UnauthorizedAccess_IODenied_NoPathName"));
			}
			throw new UnauthorizedAccessException(SR.GetString("UnauthorizedAccess_IODenied_Path", str));
		case 206:
			throw new PathTooLongException(SR.GetString("IO_PathTooLong"));
		case 32:
			if (str.Length == 0)
			{
				throw new IOException(SR.GetString("IO_SharingViolation_NoFileName"));
			}
			throw new IOException(SR.GetString("IO_SharingViolation_File", str));
		default:
			throw new IOException(GetMessage(errorCode), MakeHRFromErrorCode(errorCode));
		}
	}

	internal static int MakeHRFromErrorCode(int errorCode)
	{
		return -2147024896 | errorCode;
	}
}
