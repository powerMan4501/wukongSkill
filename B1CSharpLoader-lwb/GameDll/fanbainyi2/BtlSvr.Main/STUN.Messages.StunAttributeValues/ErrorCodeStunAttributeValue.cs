using System;
using System.Text;

namespace STUN.Messages.StunAttributeValues;

public class ErrorCodeStunAttributeValue : IStunAttributeValue
{
	public const int MaxReasonPhraseBytesLength = 762;

	public ushort ErrorCode { get; set; }

	public string ReasonPhrase { get; set; } = string.Empty;

	public byte Class => (byte)(ErrorCode % 1000 / 100);

	public byte Number => (byte)(ErrorCode % 100);

	public int WriteTo(Span<byte> buffer)
	{
		buffer[0] = (buffer[1] = 0);
		buffer[2] = Class;
		buffer[3] = Number;
		byte[] bytes = Encoding.UTF8.GetBytes(ReasonPhrase);
		bytes.CopyTo(buffer.Slice(4));
		int val = bytes.Length;
		return 4 + Math.Min(val, 762);
	}

	public bool TryParse(ReadOnlySpan<byte> buffer)
	{
		if (buffer.Length < 4 || buffer.Length > 766)
		{
			return false;
		}
		byte b = (byte)(buffer[2] & 7);
		ushort num = Math.Min((ushort)buffer[3], (ushort)99);
		ErrorCode = (ushort)(b * 100 + num);
		ReasonPhrase = Encoding.UTF8.GetString(buffer.Slice(4).ToArray());
		return true;
	}
}
