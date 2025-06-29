using System.Runtime.InteropServices;

namespace System.Net;

[StructLayout(LayoutKind.Sequential)]
internal class TransmitFileBuffers
{
	internal IntPtr preBuffer;

	internal int preBufferLength;

	internal IntPtr postBuffer;

	internal int postBufferLength;
}
