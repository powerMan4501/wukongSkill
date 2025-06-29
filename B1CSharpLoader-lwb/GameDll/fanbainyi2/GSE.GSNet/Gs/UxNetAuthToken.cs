using System;
using Google.Protobuf;

namespace Gs;

public sealed class UxNetAuthToken : IMessage<UxNetAuthToken>, IMessage, IEquatable<UxNetAuthToken>, IDeepCloneable<UxNetAuthToken>
{
	private static readonly MessageParser<UxNetAuthToken> _parser = new MessageParser<UxNetAuthToken>(() => new UxNetAuthToken());

	private UnknownFieldSet _unknownFields;

	private uint sessionMagic_;

	private uint sessionKey_;

	private ulong proxyAuthCookie_;

	private ulong netioAuthCookie_;

	public static MessageParser<UxNetAuthToken> Parser => _parser;

	public uint SessionMagic
	{
		get
		{
			return sessionMagic_;
		}
		set
		{
			sessionMagic_ = value;
		}
	}

	public uint SessionKey
	{
		get
		{
			return sessionKey_;
		}
		set
		{
			sessionKey_ = value;
		}
	}

	public ulong ProxyAuthCookie
	{
		get
		{
			return proxyAuthCookie_;
		}
		set
		{
			proxyAuthCookie_ = value;
		}
	}

	public ulong NetioAuthCookie
	{
		get
		{
			return netioAuthCookie_;
		}
		set
		{
			netioAuthCookie_ = value;
		}
	}

	public UxNetAuthToken()
	{
	}

	public UxNetAuthToken(UxNetAuthToken other)
		: this()
	{
		sessionMagic_ = other.sessionMagic_;
		sessionKey_ = other.sessionKey_;
		proxyAuthCookie_ = other.proxyAuthCookie_;
		netioAuthCookie_ = other.netioAuthCookie_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UxNetAuthToken Clone()
	{
		return new UxNetAuthToken(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UxNetAuthToken);
	}

	public bool Equals(UxNetAuthToken other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SessionMagic != other.SessionMagic)
		{
			return false;
		}
		if (SessionKey != other.SessionKey)
		{
			return false;
		}
		if (ProxyAuthCookie != other.ProxyAuthCookie)
		{
			return false;
		}
		if (NetioAuthCookie != other.NetioAuthCookie)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SessionMagic != 0)
		{
			num ^= SessionMagic.GetHashCode();
		}
		if (SessionKey != 0)
		{
			num ^= SessionKey.GetHashCode();
		}
		if (ProxyAuthCookie != 0L)
		{
			num ^= ProxyAuthCookie.GetHashCode();
		}
		if (NetioAuthCookie != 0L)
		{
			num ^= NetioAuthCookie.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SessionMagic != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(SessionMagic);
		}
		if (SessionKey != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(SessionKey);
		}
		if (ProxyAuthCookie != 0L)
		{
			output.WriteRawTag(24);
			output.WriteUInt64(ProxyAuthCookie);
		}
		if (NetioAuthCookie != 0L)
		{
			output.WriteRawTag(32);
			output.WriteUInt64(NetioAuthCookie);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SessionMagic != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SessionMagic);
		}
		if (SessionKey != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SessionKey);
		}
		if (ProxyAuthCookie != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(ProxyAuthCookie);
		}
		if (NetioAuthCookie != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(NetioAuthCookie);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UxNetAuthToken other)
	{
		if (other != null)
		{
			if (other.SessionMagic != 0)
			{
				SessionMagic = other.SessionMagic;
			}
			if (other.SessionKey != 0)
			{
				SessionKey = other.SessionKey;
			}
			if (other.ProxyAuthCookie != 0L)
			{
				ProxyAuthCookie = other.ProxyAuthCookie;
			}
			if (other.NetioAuthCookie != 0L)
			{
				NetioAuthCookie = other.NetioAuthCookie;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 8u:
				SessionMagic = input.ReadUInt32();
				break;
			case 16u:
				SessionKey = input.ReadUInt32();
				break;
			case 24u:
				ProxyAuthCookie = input.ReadUInt64();
				break;
			case 32u:
				NetioAuthCookie = input.ReadUInt64();
				break;
			}
		}
	}
}
