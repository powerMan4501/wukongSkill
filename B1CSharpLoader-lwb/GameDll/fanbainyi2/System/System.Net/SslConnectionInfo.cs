using System.Runtime.InteropServices;

namespace System.Net;

[StructLayout(LayoutKind.Sequential)]
internal class SslConnectionInfo
{
	public readonly int Protocol;

	public readonly int DataCipherAlg;

	public readonly int DataKeySize;

	public readonly int DataHashAlg;

	public readonly int DataHashKeySize;

	public readonly int KeyExchangeAlg;

	public readonly int KeyExchKeySize;

	internal unsafe SslConnectionInfo(byte[] nativeBuffer)
	{
		fixed (byte* ptr = nativeBuffer)
		{
			void* value = ptr;
			IntPtr ptr2 = new IntPtr(value);
			Protocol = Marshal.ReadInt32(ptr2);
			DataCipherAlg = Marshal.ReadInt32(ptr2, 4);
			DataKeySize = Marshal.ReadInt32(ptr2, 8);
			DataHashAlg = Marshal.ReadInt32(ptr2, 12);
			DataHashKeySize = Marshal.ReadInt32(ptr2, 16);
			KeyExchangeAlg = Marshal.ReadInt32(ptr2, 20);
			KeyExchKeySize = Marshal.ReadInt32(ptr2, 24);
		}
	}
}
