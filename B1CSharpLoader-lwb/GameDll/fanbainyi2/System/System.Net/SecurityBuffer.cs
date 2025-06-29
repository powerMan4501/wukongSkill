using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection;

namespace System.Net;

internal class SecurityBuffer
{
	public int size;

	public BufferType type;

	public byte[] token;

	public SafeHandle unmanagedToken;

	public int offset;

	public SecurityBuffer(byte[] data, int offset, int size, BufferType tokentype)
	{
		this.offset = ((data != null && offset >= 0) ? Math.Min(offset, data.Length) : 0);
		this.size = ((data != null && size >= 0) ? Math.Min(size, data.Length - this.offset) : 0);
		type = tokentype;
		token = ((size == 0) ? null : data);
	}

	public SecurityBuffer(byte[] data, BufferType tokentype)
	{
		size = ((data != null) ? data.Length : 0);
		type = tokentype;
		token = ((size == 0) ? null : data);
	}

	public SecurityBuffer(int size, BufferType tokentype)
	{
		this.size = size;
		type = tokentype;
		token = ((size == 0) ? null : new byte[size]);
	}

	public SecurityBuffer(ChannelBinding binding)
	{
		size = binding?.Size ?? 0;
		type = BufferType.ChannelBindings;
		unmanagedToken = binding;
	}
}
