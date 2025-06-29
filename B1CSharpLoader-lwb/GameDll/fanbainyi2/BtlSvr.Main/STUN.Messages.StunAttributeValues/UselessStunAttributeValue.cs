using System;

namespace STUN.Messages.StunAttributeValues;

public class UselessStunAttributeValue : IStunAttributeValue
{
	public int WriteTo(Span<byte> buffer)
	{
		throw new NotSupportedException();
	}

	public bool TryParse(ReadOnlySpan<byte> buffer)
	{
		return true;
	}
}
