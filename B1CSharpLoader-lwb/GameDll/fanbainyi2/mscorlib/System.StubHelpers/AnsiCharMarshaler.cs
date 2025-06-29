using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace System.StubHelpers;

[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
internal static class AnsiCharMarshaler
{
	[SecurityCritical]
	internal unsafe static byte[] DoAnsiConversion(string str, bool fBestFit, bool fThrowOnUnmappableChar, out int cbLength)
	{
		byte[] array = new byte[(str.Length + 1) * Marshal.SystemMaxDBCSCharSize];
		fixed (byte* pbNativeBuffer = array)
		{
			cbLength = str.ConvertToAnsi(pbNativeBuffer, array.Length, fBestFit, fThrowOnUnmappableChar);
		}
		return array;
	}

	[SecurityCritical]
	internal unsafe static byte ConvertToNative(char managedChar, bool fBestFit, bool fThrowOnUnmappableChar)
	{
		int num = 2 * Marshal.SystemMaxDBCSCharSize;
		byte* ptr = stackalloc byte[(int)(uint)num];
		int num2 = managedChar.ToString().ConvertToAnsi(ptr, num, fBestFit, fThrowOnUnmappableChar);
		return *ptr;
	}

	internal static char ConvertToManaged(byte nativeChar)
	{
		byte[] bytes = new byte[1] { nativeChar };
		string text = Encoding.Default.GetString(bytes);
		return text[0];
	}
}
