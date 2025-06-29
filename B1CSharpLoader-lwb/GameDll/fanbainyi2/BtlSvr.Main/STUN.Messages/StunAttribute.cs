using System;
using System.Buffers.Binary;
using System.Security.Cryptography;
using STUN.Enums;
using STUN.Messages.StunAttributeValues;

namespace STUN.Messages;

public class StunAttribute
{
	public AttributeType Type { get; set; }

	public ushort Length { get; set; }

	public ushort RealLength => (ushort)((Type != AttributeType.Useless) ? ((uint)(4 + Length + (4 - Length % 4) % 4)) : 0u);

	public IStunAttributeValue Value { get; set; } = new UselessStunAttributeValue();

	public int WriteTo(Span<byte> buffer)
	{
		int num = 4 + Length;
		int num2 = (4 - num % 4) % 4;
		int result = num + num2;
		BinaryPrimitives.WriteUInt16BigEndian(buffer, (ushort)Type);
		BinaryPrimitives.WriteUInt16BigEndian(buffer.Slice(2), Length);
		Value.WriteTo(buffer.Slice(4));
		byte[] array = new byte[num2];
		RandomNumberGenerator.Create().GetBytes(array);
		array.CopyTo(buffer.Slice(num, num2));
		return result;
	}

	public static IStunAttributeValue GetIStunAttributeValueByType(AttributeType Type, ReadOnlySpan<byte> magicCookieAndTransactionId)
	{
		return Type switch
		{
			AttributeType.MappedAddress => new MappedAddressStunAttributeValue(), 
			AttributeType.XorMappedAddress => new XorMappedAddressStunAttributeValue(magicCookieAndTransactionId), 
			AttributeType.ResponseAddress => new ResponseAddressStunAttributeValue(), 
			AttributeType.ChangeRequest => new ChangeRequestStunAttributeValue(), 
			AttributeType.SourceAddress => new SourceAddressStunAttributeValue(), 
			AttributeType.ChangedAddress => new ChangedAddressStunAttributeValue(), 
			AttributeType.OtherAddress => new OtherAddressStunAttributeValue(), 
			AttributeType.ReflectedFrom => new ReflectedFromStunAttributeValue(), 
			AttributeType.ErrorCode => new ErrorCodeStunAttributeValue(), 
			_ => new UselessStunAttributeValue(), 
		};
	}

	public int TryParse(ReadOnlySpan<byte> buffer, ReadOnlySpan<byte> magicCookieAndTransactionId)
	{
		if (buffer.Length < 4)
		{
			return 0;
		}
		Type = (AttributeType)BinaryPrimitives.ReadUInt16BigEndian(buffer);
		Length = BinaryPrimitives.ReadUInt16BigEndian(buffer.Slice(2));
		if (buffer.Length < 4 + Length)
		{
			return 0;
		}
		ReadOnlySpan<byte> buffer2 = buffer.Slice(4, Length);
		IStunAttributeValue iStunAttributeValueByType = GetIStunAttributeValueByType(Type, magicCookieAndTransactionId);
		if (iStunAttributeValueByType.TryParse(buffer2))
		{
			Value = iStunAttributeValueByType;
		}
		return 4 + Length + (4 - Length % 4) % 4;
	}
}
