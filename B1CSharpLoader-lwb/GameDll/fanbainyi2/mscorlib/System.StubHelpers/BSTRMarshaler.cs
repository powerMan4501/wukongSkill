using System.Runtime.ConstrainedExecution;
using System.Security;
using Microsoft.Win32;

namespace System.StubHelpers;

[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
internal static class BSTRMarshaler
{
	[SecurityCritical]
	internal unsafe static IntPtr ConvertToNative(string strManaged, IntPtr pNativeBuffer)
	{
		if (strManaged == null)
		{
			return IntPtr.Zero;
		}
		StubHelpers.CheckStringLength(strManaged.Length);
		byte data;
		bool flag = strManaged.TryGetTrailByte(out data);
		uint num = (uint)(strManaged.Length * 2);
		if (flag)
		{
			num++;
		}
		byte* ptr;
		if (pNativeBuffer != IntPtr.Zero)
		{
			*(uint*)pNativeBuffer.ToPointer() = num;
			ptr = (byte*)pNativeBuffer.ToPointer() + 4;
		}
		else
		{
			ptr = (byte*)Win32Native.SysAllocStringByteLen(null, num).ToPointer();
		}
		fixed (char* src = strManaged)
		{
			Buffer.Memcpy(ptr, (byte*)src, (strManaged.Length + 1) * 2);
		}
		if (flag)
		{
			ptr[num - 1] = data;
		}
		return (IntPtr)ptr;
	}

	[SecurityCritical]
	internal unsafe static string ConvertToManaged(IntPtr bstr)
	{
		if (IntPtr.Zero == bstr)
		{
			return null;
		}
		uint num = Win32Native.SysStringByteLen(bstr);
		StubHelpers.CheckStringLength(num);
		string text = ((num != 1) ? new string((char*)(void*)bstr, 0, (int)(num / 2)) : string.FastAllocateString(0));
		if ((num & 1) == 1)
		{
			text.SetTrailByte(((byte*)bstr.ToPointer())[num - 1]);
		}
		return text;
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
