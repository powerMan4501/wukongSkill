using System;
using System.Buffers.Binary;
using System.Net;

namespace STUN.Messages.StunAttributeValues;

public class XorMappedAddressStunAttributeValue : AddressStunAttributeValue
{
	private readonly byte[] _magicCookieAndTransactionId;

	public XorMappedAddressStunAttributeValue(ReadOnlySpan<byte> magicCookieAndTransactionId)
	{
		_magicCookieAndTransactionId = magicCookieAndTransactionId.ToArray();
	}

	public override int WriteTo(Span<byte> buffer)
	{
		buffer[0] = 0;
		buffer[1] = (byte)base.Family;
		BinaryPrimitives.WriteUInt16BigEndian(buffer.Slice(2), Xor(base.Port));
		byte[] addressBytes = Xor(base.Address).GetAddressBytes();
		addressBytes.AsSpan().TryCopyTo(buffer.Slice(4));
		int num = addressBytes.Length;
		return 4 + num;
	}

	public override bool TryParse(ReadOnlySpan<byte> buffer)
	{
		if (!base.TryParse(buffer))
		{
			return false;
		}
		base.Port = Xor(base.Port);
		base.Address = Xor(base.Address);
		return true;
	}

	private ushort Xor(ushort port)
	{
		Span<byte> span = stackalloc byte[2];
		BinaryPrimitives.WriteUInt16BigEndian(span, port);
		span[0] ^= _magicCookieAndTransactionId[0];
		span[1] ^= _magicCookieAndTransactionId[1];
		return BinaryPrimitives.ReadUInt16BigEndian(span);
	}

	private IPAddress Xor(IPAddress address)
	{
		Span<byte> span = stackalloc byte[16];
		int num = address.GetAddressBytes().Length;
		for (int i = 0; i < num; i++)
		{
			span[i] ^= _magicCookieAndTransactionId[i];
		}
		return new IPAddress(span.Slice(0, num).ToArray());
	}
}
