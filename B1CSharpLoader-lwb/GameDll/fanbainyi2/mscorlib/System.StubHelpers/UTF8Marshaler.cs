using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Microsoft.Win32;

namespace System.StubHelpers;

[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
internal static class UTF8Marshaler
{
	private const int MAX_UTF8_CHAR_SIZE = 3;

	[SecurityCritical]
	internal unsafe static IntPtr ConvertToNative(int flags, string strManaged, IntPtr pNativeBuffer)
	{
		if (strManaged == null)
		{
			return IntPtr.Zero;
		}
		StubHelpers.CheckStringLength(strManaged.Length);
		byte* ptr = (byte*)(void*)pNativeBuffer;
		int cbNativeBuffer;
		if (ptr != null)
		{
			cbNativeBuffer = (strManaged.Length + 1) * 3;
			cbNativeBuffer = strManaged.GetBytesFromEncoding(ptr, cbNativeBuffer, Encoding.UTF8);
		}
		else
		{
			cbNativeBuffer = Encoding.UTF8.GetByteCount(strManaged);
			ptr = (byte*)(void*)Marshal.AllocCoTaskMem(cbNativeBuffer + 1);
			strManaged.GetBytesFromEncoding(ptr, cbNativeBuffer, Encoding.UTF8);
		}
		ptr[cbNativeBuffer] = 0;
		return (IntPtr)ptr;
	}

	[SecurityCritical]
	internal unsafe static string ConvertToManaged(IntPtr cstr)
	{
		if (IntPtr.Zero == cstr)
		{
			return null;
		}
		int byteLength = StubHelpers.strlen((sbyte*)(void*)cstr);
		return string.CreateStringFromEncoding((byte*)(void*)cstr, byteLength, Encoding.UTF8);
	}

	[SecurityCritical]
	internal static void ClearNative(IntPtr pNative)
	{
		if (pNative != IntPtr.Zero)
		{
			Win32Native.CoTaskMemFree(pNative);
		}
	}
}
