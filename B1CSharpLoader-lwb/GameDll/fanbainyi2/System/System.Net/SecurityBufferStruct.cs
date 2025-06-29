namespace System.Net;

internal struct SecurityBufferStruct
{
	public int count;

	public BufferType type;

	public IntPtr token;

	public unsafe static readonly int Size = sizeof(SecurityBufferStruct);
}
