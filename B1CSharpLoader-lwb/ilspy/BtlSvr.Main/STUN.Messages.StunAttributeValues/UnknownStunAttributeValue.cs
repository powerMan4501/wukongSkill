using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using STUN.Enums;

namespace STUN.Messages.StunAttributeValues;

public class UnknownStunAttributeValue : IStunAttributeValue
{
	public List<AttributeType> Types { get; } = new List<AttributeType>();

	public int WriteTo(Span<byte> buffer)
	{
		int result = Types.Count << 1;
		foreach (AttributeType type in Types)
		{
			BinaryPrimitives.WriteUInt16BigEndian(buffer, (ushort)type);
			buffer = buffer.Slice(2);
		}
		return result;
	}

	public bool TryParse(ReadOnlySpan<byte> buffer)
	{
		if (buffer.Length < 2 || (buffer.Length & 1) == 1)
		{
			return false;
		}
		Types.Clear();
		while (!buffer.IsEmpty)
		{
			ushort item = BinaryPrimitives.ReadUInt16BigEndian(buffer);
			Types.Add((AttributeType)item);
			buffer = buffer.Slice(2);
		}
		return true;
	}
}
