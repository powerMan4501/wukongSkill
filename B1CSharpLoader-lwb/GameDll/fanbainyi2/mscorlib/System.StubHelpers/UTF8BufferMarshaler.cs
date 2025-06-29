using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Text;

namespace System.StubHelpers;

[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
internal static class UTF8BufferMarshaler
{
	[SecurityCritical]
	internal unsafe static IntPtr ConvertToNative(StringBuilder sb, IntPtr pNativeBuffer, int flags)
	{
		if (sb == null)
		{
			return IntPtr.Zero;
		}
		string text = sb.ToString();
		int byteCount = Encoding.UTF8.GetByteCount(text);
		byte* ptr = (byte*)(void*)pNativeBuffer;
		byteCount = text.GetBytesFromEncoding(ptr, byteCount, Encoding.UTF8);
		ptr[byteCount] = 0;
		return (IntPtr)ptr;
	}

	[SecurityCritical]
	internal unsafe static void ConvertToManaged(StringBuilder sb, IntPtr pNative)
	{
		int num = StubHelpers.strlen((sbyte*)(void*)pNative);
		int charCount = Encoding.UTF8.GetCharCount((byte*)(void*)pNative, num);
		char[] array = new char[charCount + 1];
		array[charCount] = '\0';
		fixed (char* ptr = array)
		{
			charCount = Encoding.UTF8.GetChars((byte*)(void*)pNative, num, ptr, charCount);
			sb.ReplaceBufferInternal(ptr, charCount);
		}
	}
}
