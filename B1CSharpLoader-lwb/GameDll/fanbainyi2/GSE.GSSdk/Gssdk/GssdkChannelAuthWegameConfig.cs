using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class GssdkChannelAuthWegameConfig : IMessage<GssdkChannelAuthWegameConfig>, IMessage, IEquatable<GssdkChannelAuthWegameConfig>, IDeepCloneable<GssdkChannelAuthWegameConfig>
{
	private static readonly MessageParser<GssdkChannelAuthWegameConfig> _parser = new MessageParser<GssdkChannelAuthWegameConfig>(() => new GssdkChannelAuthWegameConfig());

	private UnknownFieldSet _unknownFields;

	private string gameId_ = "";

	private string clientId_ = "";

	private string clientSecret_ = "";

	private string acsUrl_ = "";

	private string verifyUrl_ = "";

	public static MessageParser<GssdkChannelAuthWegameConfig> Parser => _parser;

	public string GameId
	{
		get
		{
			return gameId_;
		}
		set
		{
			gameId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ClientId
	{
		get
		{
			return clientId_;
		}
		set
		{
			clientId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ClientSecret
	{
		get
		{
			return clientSecret_;
		}
		set
		{
			clientSecret_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string AcsUrl
	{
		get
		{
			return acsUrl_;
		}
		set
		{
			acsUrl_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string VerifyUrl
	{
		get
		{
			return verifyUrl_;
		}
		set
		{
			verifyUrl_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public GssdkChannelAuthWegameConfig()
	{
	}

	public GssdkChannelAuthWegameConfig(GssdkChannelAuthWegameConfig other)
		: this()
	{
		gameId_ = other.gameId_;
		clientId_ = other.clientId_;
		clientSecret_ = other.clientSecret_;
		acsUrl_ = other.acsUrl_;
		verifyUrl_ = other.verifyUrl_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GssdkChannelAuthWegameConfig Clone()
	{
		return new GssdkChannelAuthWegameConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GssdkChannelAuthWegameConfig);
	}

	public bool Equals(GssdkChannelAuthWegameConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GameId != other.GameId)
		{
			return false;
		}
		if (ClientId != other.ClientId)
		{
			return false;
		}
		if (ClientSecret != other.ClientSecret)
		{
			return false;
		}
		if (AcsUrl != other.AcsUrl)
		{
			return false;
		}
		if (VerifyUrl != other.VerifyUrl)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (GameId.Length != 0)
		{
			num ^= GameId.GetHashCode();
		}
		if (ClientId.Length != 0)
		{
			num ^= ClientId.GetHashCode();
		}
		if (ClientSecret.Length != 0)
		{
			num ^= ClientSecret.GetHashCode();
		}
		if (AcsUrl.Length != 0)
		{
			num ^= AcsUrl.GetHashCode();
		}
		if (VerifyUrl.Length != 0)
		{
			num ^= VerifyUrl.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (GameId.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(GameId);
		}
		if (ClientId.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(ClientId);
		}
		if (ClientSecret.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(ClientSecret);
		}
		if (AcsUrl.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(AcsUrl);
		}
		if (VerifyUrl.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(VerifyUrl);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (GameId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GameId);
		}
		if (ClientId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ClientId);
		}
		if (ClientSecret.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ClientSecret);
		}
		if (AcsUrl.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AcsUrl);
		}
		if (VerifyUrl.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(VerifyUrl);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GssdkChannelAuthWegameConfig other)
	{
		if (other != null)
		{
			if (other.GameId.Length != 0)
			{
				GameId = other.GameId;
			}
			if (other.ClientId.Length != 0)
			{
				ClientId = other.ClientId;
			}
			if (other.ClientSecret.Length != 0)
			{
				ClientSecret = other.ClientSecret;
			}
			if (other.AcsUrl.Length != 0)
			{
				AcsUrl = other.AcsUrl;
			}
			if (other.VerifyUrl.Length != 0)
			{
				VerifyUrl = other.VerifyUrl;
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
				GameId = input.ReadString();
				break;
			case 18u:
				ClientId = input.ReadString();
				break;
			case 26u:
				ClientSecret = input.ReadString();
				break;
			case 34u:
				AcsUrl = input.ReadString();
				break;
			case 42u:
				VerifyUrl = input.ReadString();
				break;
			}
		}
	}
}
