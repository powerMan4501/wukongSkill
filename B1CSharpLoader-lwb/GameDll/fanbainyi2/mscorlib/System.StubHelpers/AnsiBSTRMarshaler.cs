using System.Runtime.ConstrainedExecution;
using System.Security;
using Microsoft.Win32;

namespace System.StubHelpers;

[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
internal static class AnsiBSTRMarshaler
{
	[SecurityCritical]
	internal static IntPtr ConvertToNative(int flags, string strManaged)
	{
		if (strManaged == null)
		{
			return IntPtr.Zero;
		}
		int length = strManaged.Length;
		StubHelpers.CheckStringLength(length);
		byte[] str = null;
		int cbLength = 0;
		if (length > 0)
		{
			str = AnsiCharMarshaler.DoAnsiConversion(strManaged, (flags & 0xFF) != 0, flags >> 8 != 0, out cbLength);
		}
		return Win32Native.SysAllocStringByteLen(str, (uint)cbLength);
	}

	[SecurityCritical]
	internal unsafe static string ConvertToManaged(IntPtr bstr)
	{
		if (IntPtr.Zero == bstr)
		{
			return null;
		}
		return new string((sbyte*)(void*)bstr);
	}

	[SecurityCritical]
	internal static void ClearNative(IntPtr pNative)
	{
		if (IntPtr.Zero != pNative)
		{
			Win32Native.SysFreeString(pNative);
		}
	}
}
