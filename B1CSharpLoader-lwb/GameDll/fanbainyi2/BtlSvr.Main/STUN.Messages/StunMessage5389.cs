using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using STUN.Enums;

namespace STUN.Messages;

public class StunMessage5389
{
	public StunMessageType StunMessageType { get; set; }

	public uint MagicCookie { get; set; }

	public byte[] TransactionId { get; }

	public IEnumerable<StunAttribute> Attributes { get; set; }

	public StunMessage5389()
	{
		Attributes = Array.Empty<StunAttribute>();
		StunMessageType = StunMessageType.BindingRequest;
		MagicCookie = 554869826u;
		TransactionId = new byte[12];
		RandomNumberGenerator.Create().GetBytes(TransactionId);
	}

	public int WriteTo(Span<byte> buffer)
	{
		ushort num = Attributes.Aggregate<StunAttribute, ushort>(0, (ushort current, StunAttribute attribute) => (ushort)(current + attribute.RealLength));
		int result = 20 + num;
		BinaryPrimitives.WriteUInt16BigEndian(buffer, (ushort)StunMessageType);
		BinaryPrimitives.WriteUInt16BigEndian(buffer.Slice(2), num);
		BinaryPrimitives.WriteUInt32BigEndian(buffer.Slice(4), MagicCookie);
		TransactionId.CopyTo(buffer.Slice(8));
		buffer.Slice(20);
		foreach (StunAttribute attribute in Attributes)
		{
			int start = attribute.WriteTo(buffer);
			buffer = buffer.Slice(start);
		}
		return result;
	}

	public bool TryParse(ReadOnlySpan<byte> buffer)
	{
		if (buffer.Length < 20)
		{
			return false;
		}
		Span<byte> span = stackalloc byte[2];
		span[0] = (byte)(buffer[0] & 0x3F);
		span[1] = buffer[1];
		StunMessageType stunMessageType = (StunMessageType)BinaryPrimitives.ReadUInt16BigEndian(span);
		if (!Enum.IsDefined(typeof(StunMessageType), stunMessageType))
		{
			return false;
		}
		StunMessageType = stunMessageType;
		ushort num = BinaryPrimitives.ReadUInt16BigEndian(buffer.Slice(2));
		MagicCookie = BinaryPrimitives.ReadUInt32BigEndian(buffer.Slice(4));
		buffer.Slice(8, 12).CopyTo(TransactionId);
		if (buffer.Length != num + 20)
		{
			return false;
		}
		List<StunAttribute> list = new List<StunAttribute>();
		ReadOnlySpan<byte> buffer2 = buffer.Slice(20);
		ReadOnlySpan<byte> magicCookieAndTransactionId = buffer.Slice(4, 16);
		while (buffer2.Length > 0)
		{
			StunAttribute stunAttribute = new StunAttribute();
			int num2 = stunAttribute.TryParse(buffer2, magicCookieAndTransactionId);
			if (num2 <= 0)
			{
				break;
			}
			list.Add(stunAttribute);
			buffer2 = buffer2.Slice(num2);
		}
		Attributes = list;
		return true;
	}

	public bool IsSameTransaction(StunMessage5389 other)
	{
		if (MagicCookie == other.MagicCookie)
		{
			return TransactionId.AsSpan().SequenceEqual(other.TransactionId);
		}
		return false;
	}
}
