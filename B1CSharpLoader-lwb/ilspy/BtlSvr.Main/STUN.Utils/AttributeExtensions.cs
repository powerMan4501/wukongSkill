using System;
using System.Linq;
using System.Net;
using STUN.Enums;
using STUN.Messages;
using STUN.Messages.StunAttributeValues;

namespace STUN.Utils;

public static class AttributeExtensions
{
	public static StunAttribute BuildChangeRequest(bool changeIp, bool changePort)
	{
		return new StunAttribute
		{
			Type = AttributeType.ChangeRequest,
			Length = 4,
			Value = new ChangeRequestStunAttributeValue
			{
				ChangeIp = changeIp,
				ChangePort = changePort
			}
		};
	}

	private static int GetIpFamilyLength(IpFamily family)
	{
		return family switch
		{
			IpFamily.IPv4 => 4, 
			IpFamily.IPv6 => 16, 
			_ => throw new ArgumentOutOfRangeException("family", family, null), 
		};
	}

	public static StunAttribute BuildMapping(IpFamily family, IPAddress ip, ushort port)
	{
		int ipFamilyLength = GetIpFamilyLength(family);
		return new StunAttribute
		{
			Type = AttributeType.MappedAddress,
			Length = (ushort)(4 + ipFamilyLength),
			Value = new MappedAddressStunAttributeValue
			{
				Family = family,
				Address = ip,
				Port = port
			}
		};
	}

	public static StunAttribute BuildChangeAddress(IpFamily family, IPAddress ip, ushort port)
	{
		int ipFamilyLength = GetIpFamilyLength(family);
		return new StunAttribute
		{
			Type = AttributeType.ChangedAddress,
			Length = (ushort)(4 + ipFamilyLength),
			Value = new ChangedAddressStunAttributeValue
			{
				Family = family,
				Address = ip,
				Port = port
			}
		};
	}

	public static IPEndPoint GetMappedAddressAttribute(this StunMessage5389 response)
	{
		StunAttribute stunAttribute = response.Attributes.FirstOrDefault((StunAttribute t) => t.Type == AttributeType.MappedAddress);
		if (stunAttribute == null)
		{
			return null;
		}
		MappedAddressStunAttributeValue mappedAddressStunAttributeValue = (MappedAddressStunAttributeValue)stunAttribute.Value;
		return new IPEndPoint(mappedAddressStunAttributeValue.Address, mappedAddressStunAttributeValue.Port);
	}

	public static IPEndPoint GetChangedAddressAttribute(this StunMessage5389 response)
	{
		StunAttribute stunAttribute = response.Attributes.FirstOrDefault((StunAttribute t) => t.Type == AttributeType.ChangedAddress);
		if (stunAttribute == null)
		{
			return null;
		}
		ChangedAddressStunAttributeValue changedAddressStunAttributeValue = (ChangedAddressStunAttributeValue)stunAttribute.Value;
		return new IPEndPoint(changedAddressStunAttributeValue.Address, changedAddressStunAttributeValue.Port);
	}

	public static IPEndPoint GetXorMappedAddressAttribute(this StunMessage5389 response)
	{
		StunAttribute stunAttribute = response.Attributes.FirstOrDefault((StunAttribute t) => t.Type == AttributeType.XorMappedAddress) ?? response.Attributes.FirstOrDefault((StunAttribute t) => t.Type == AttributeType.MappedAddress);
		if (stunAttribute == null)
		{
			return null;
		}
		AddressStunAttributeValue addressStunAttributeValue = (AddressStunAttributeValue)stunAttribute.Value;
		return new IPEndPoint(addressStunAttributeValue.Address, addressStunAttributeValue.Port);
	}

	public static IPEndPoint GetOtherAddressAttribute(this StunMessage5389 response)
	{
		StunAttribute stunAttribute = response.Attributes.FirstOrDefault((StunAttribute t) => t.Type == AttributeType.OtherAddress) ?? response.Attributes.FirstOrDefault((StunAttribute t) => t.Type == AttributeType.ChangedAddress);
		if (stunAttribute == null)
		{
			return null;
		}
		AddressStunAttributeValue addressStunAttributeValue = (AddressStunAttributeValue)stunAttribute.Value;
		return new IPEndPoint(addressStunAttributeValue.Address, addressStunAttributeValue.Port);
	}
}
