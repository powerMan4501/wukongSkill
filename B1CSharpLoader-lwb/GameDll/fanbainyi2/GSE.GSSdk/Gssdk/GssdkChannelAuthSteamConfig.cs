using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class GssdkChannelAuthSteamConfig : IMessage<GssdkChannelAuthSteamConfig>, IMessage, IEquatable<GssdkChannelAuthSteamConfig>, IDeepCloneable<GssdkChannelAuthSteamConfig>
{
	private static readonly MessageParser<GssdkChannelAuthSteamConfig> _parser = new MessageParser<GssdkChannelAuthSteamConfig>(() => new GssdkChannelAuthSteamConfig());

	private UnknownFieldSet _unknownFields;

	private string appId_ = "";

	private string secret_ = "";

	private string tokenPrefix_ = "";

	public static MessageParser<GssdkChannelAuthSteamConfig> Parser => _parser;

	public string AppId
	{
		get
		{
			return appId_;
		}
		set
		{
			appId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Secret
	{
		get
		{
			return secret_;
		}
		set
		{
			secret_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string TokenPrefix
	{
		get
		{
			return tokenPrefix_;
		}
		set
		{
			tokenPrefix_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public GssdkChannelAuthSteamConfig()
	{
	}

	public GssdkChannelAuthSteamConfig(GssdkChannelAuthSteamConfig other)
		: this()
	{
		appId_ = other.appId_;
		secret_ = other.secret_;
		tokenPrefix_ = other.tokenPrefix_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GssdkChannelAuthSteamConfig Clone()
	{
		return new GssdkChannelAuthSteamConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GssdkChannelAuthSteamConfig);
	}

	public bool Equals(GssdkChannelAuthSteamConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AppId != other.AppId)
		{
			return false;
		}
		if (Secret != other.Secret)
		{
			return false;
		}
		if (TokenPrefix != other.TokenPrefix)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (AppId.Length != 0)
		{
			num ^= AppId.GetHashCode();
		}
		if (Secret.Length != 0)
		{
			num ^= Secret.GetHashCode();
		}
		if (TokenPrefix.Length != 0)
		{
			num ^= TokenPrefix.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (AppId.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(AppId);
		}
		if (Secret.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Secret);
		}
		if (TokenPrefix.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(TokenPrefix);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (AppId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AppId);
		}
		if (Secret.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Secret);
		}
		if (TokenPrefix.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TokenPrefix);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GssdkChannelAuthSteamConfig other)
	{
		if (other != null)
		{
			if (other.AppId.Length != 0)
			{
				AppId = other.AppId;
			}
			if (other.Secret.Length != 0)
			{
				Secret = other.Secret;
			}
			if (other.TokenPrefix.Length != 0)
			{
				TokenPrefix = other.TokenPrefix;
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
			case 10u:
				AppId = input.ReadString();
				break;
			case 18u:
				Secret = input.ReadString();
				break;
			case 26u:
				TokenPrefix = input.ReadString();
				break;
			}
		}
	}
}
