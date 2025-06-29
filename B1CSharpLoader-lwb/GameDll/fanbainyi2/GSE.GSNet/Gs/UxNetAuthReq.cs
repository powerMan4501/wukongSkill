using System;
using Google.Protobuf;

namespace Gs;

public sealed class UxNetAuthReq : IMessage<UxNetAuthReq>, IMessage, IEquatable<UxNetAuthReq>, IDeepCloneable<UxNetAuthReq>
{
	private static readonly MessageParser<UxNetAuthReq> _parser = new MessageParser<UxNetAuthReq>(() => new UxNetAuthReq());

	private UnknownFieldSet _unknownFields;

	private string token_ = "";

	private ByteString envPacked_ = ByteString.Empty;

	private uint worldId_;

	private UxNetProxyHeader proxy_;

	public static MessageParser<UxNetAuthReq> Parser => _parser;

	public string Token
	{
		get
		{
			return token_;
		}
		set
		{
			token_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ByteString EnvPacked
	{
		get
		{
			return envPacked_;
		}
		set
		{
			envPacked_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public uint WorldId
	{
		get
		{
			return worldId_;
		}
		set
		{
			worldId_ = value;
		}
	}

	public UxNetProxyHeader Proxy
	{
		get
		{
			return proxy_;
		}
		set
		{
			proxy_ = value;
		}
	}

	public UxNetAuthReq()
	{
	}

	public UxNetAuthReq(UxNetAuthReq other)
		: this()
	{
		token_ = other.token_;
		envPacked_ = other.envPacked_;
		worldId_ = other.worldId_;
		proxy_ = ((other.proxy_ != null) ? other.proxy_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UxNetAuthReq Clone()
	{
		return new UxNetAuthReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UxNetAuthReq);
	}

	public bool Equals(UxNetAuthReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Token != other.Token)
		{
			return false;
		}
		if (EnvPacked != other.EnvPacked)
		{
			return false;
		}
		if (WorldId != other.WorldId)
		{
			return false;
		}
		if (!object.Equals(Proxy, other.Proxy))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Token.Length != 0)
		{
			num ^= Token.GetHashCode();
		}
		if (EnvPacked.Length != 0)
		{
			num ^= EnvPacked.GetHashCode();
		}
		if (WorldId != 0)
		{
			num ^= WorldId.GetHashCode();
		}
		if (proxy_ != null)
		{
			num ^= Proxy.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Token.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Token);
		}
		if (EnvPacked.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteBytes(EnvPacked);
		}
		if (WorldId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(WorldId);
		}
		if (proxy_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Proxy);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Token.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Token);
		}
		if (EnvPacked.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(EnvPacked);
		}
		if (WorldId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(WorldId);
		}
		if (proxy_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Proxy);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UxNetAuthReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Token.Length != 0)
		{
			Token = other.Token;
		}
		if (other.EnvPacked.Length != 0)
		{
			EnvPacked = other.EnvPacked;
		}
		if (other.WorldId != 0)
		{
			WorldId = other.WorldId;
		}
		if (other.proxy_ != null)
		{
			if (proxy_ == null)
			{
				Proxy = new UxNetProxyHeader();
			}
			Proxy.MergeFrom(other.Proxy);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 10u:
				Token = input.ReadString();
				break;
			case 18u:
				EnvPacked = input.ReadBytes();
				break;
			case 24u:
				WorldId = input.ReadUInt32();
				break;
			case 34u:
				if (proxy_ == null)
				{
					Proxy = new UxNetProxyHeader();
				}
				input.ReadMessage(Proxy);
				break;
			}
		}
	}
}
