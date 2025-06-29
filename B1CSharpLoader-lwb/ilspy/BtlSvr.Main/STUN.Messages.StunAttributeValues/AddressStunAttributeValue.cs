using System;
using System.Buffers.Binary;
using System.Net;
using System.Net.Sockets;
using STUN.Enums;

namespace STUN.Messages.StunAttributeValues;

public abstract class AddressStunAttributeValue : IStunAttributeValue
{
	public IpFamily Family { get; set; }

	public ushort Port { get; set; }

	public IPAddress Address { get; set; }

	public virtual int WriteTo(Span<byte> buffer)
	{
		buffer[0] = 0;
		buffer[1] = (byte)Family;
		BinaryPrimitives.WriteUInt16BigEndian(buffer.Slice(2), Port);
		byte[] addressBytes = Address.GetAddressBytes();
		addressBytes.CopyTo(buffer.Slice(4));
		int num = addressBytes.Length;
		return 4 + num;
	}

	public virtual bool TryParse(ReadOnlySpan<byte> buffer)
	{
		int num = 4;
		if (buffer.Length < num)
		{
			return false;
		}
		Family = (IpFamily)buffer[1];
		switch (Family)
		{
		case IpFamily.IPv4:
			num += 4;
			break;
		case IpFamily.IPv6:
			num += 16;
			break;
		default:
			return false;
		}
		if (buffer.Length != num)
		{
			return false;
		}
		Port = BinaryPrimitives.ReadUInt16BigEndian(buffer.Slice(2));
		Address = new IPAddress(buffer.Slice(4).ToArray());
		return true;
	}

	public override string ToString()
	{
		return Address?.AddressFamily switch
		{
			AddressFamily.InterNetwork => $"{Address}:{Port}", 
			AddressFamily.InterNetworkV6 => $"[{Address}]:{Port}", 
			_ => base.ToString(), 
		};
	}
}
