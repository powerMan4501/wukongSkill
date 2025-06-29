using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class AuthLoginRes : IMessage<AuthLoginRes>, IMessage, IEquatable<AuthLoginRes>, IDeepCloneable<AuthLoginRes>
{
	private static readonly MessageParser<AuthLoginRes> _parser = new MessageParser<AuthLoginRes>(() => new AuthLoginRes());

	private UnknownFieldSet _unknownFields;

	private GssdkRet ret_;

	private string gameToken_ = "";

	private uint gameTokenExpiredTime_;

	private string skey_ = "";

	private uint skeyExpiredTime_;

	private UserAuthResult authResult_;

	private string userJsonConfig_ = "";

	public static MessageParser<AuthLoginRes> Parser => _parser;

	public GssdkRet Ret
	{
		get
		{
			return ret_;
		}
		set
		{
			ret_ = value;
		}
	}

	public string GameToken
	{
		get
		{
			return gameToken_;
		}
		set
		{
			gameToken_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public uint GameTokenExpiredTime
	{
		get
		{
			return gameTokenExpiredTime_;
		}
		set
		{
			gameTokenExpiredTime_ = value;
		}
	}

	public string Skey
	{
		get
		{
			return skey_;
		}
		set
		{
			skey_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public uint SkeyExpiredTime
	{
		get
		{
			return skeyExpiredTime_;
		}
		set
		{
			skeyExpiredTime_ = value;
		}
	}

	public UserAuthResult AuthResult
	{
		get
		{
			return authResult_;
		}
		set
		{
			authResult_ = value;
		}
	}

	public string UserJsonConfig
	{
		get
		{
			return userJsonConfig_;
		}
		set
		{
			userJsonConfig_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public AuthLoginRes()
	{
	}

	public AuthLoginRes(AuthLoginRes other)
		: this()
	{
		ret_ = ((other.ret_ != null) ? other.ret_.Clone() : null);
		gameToken_ = other.gameToken_;
		gameTokenExpiredTime_ = other.gameTokenExpiredTime_;
		skey_ = other.skey_;
		skeyExpiredTime_ = other.skeyExpiredTime_;
		authResult_ = ((other.authResult_ != null) ? other.authResult_.Clone() : null);
		userJsonConfig_ = other.userJsonConfig_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AuthLoginRes Clone()
	{
		return new AuthLoginRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AuthLoginRes);
	}

	public bool Equals(AuthLoginRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Ret, other.Ret))
		{
			return false;
		}
		if (GameToken != other.GameToken)
		{
			return false;
		}
		if (GameTokenExpiredTime != other.GameTokenExpiredTime)
		{
			return false;
		}
		if (Skey != other.Skey)
		{
			return false;
		}
		if (SkeyExpiredTime != other.SkeyExpiredTime)
		{
			return false;
		}
		if (!object.Equals(AuthResult, other.AuthResult))
		{
			return false;
		}
		if (UserJsonConfig != other.UserJsonConfig)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ret_ != null)
		{
			num ^= Ret.GetHashCode();
		}
		if (GameToken.Length != 0)
		{
			num ^= GameToken.GetHashCode();
		}
		if (GameTokenExpiredTime != 0)
		{
			num ^= GameTokenExpiredTime.GetHashCode();
		}
		if (Skey.Length != 0)
		{
			num ^= Skey.GetHashCode();
		}
		if (SkeyExpiredTime != 0)
		{
			num ^= SkeyExpiredTime.GetHashCode();
		}
		if (authResult_ != null)
		{
			num ^= AuthResult.GetHashCode();
		}
		if (UserJsonConfig.Length != 0)
		{
			num ^= UserJsonConfig.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ret_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Ret);
		}
		if (GameToken.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(GameToken);
		}
		if (GameTokenExpiredTime != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(GameTokenExpiredTime);
		}
		if (Skey.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Skey);
		}
		if (SkeyExpiredTime != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(SkeyExpiredTime);
		}
		if (authResult_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(AuthResult);
		}
		if (UserJsonConfig.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(UserJsonConfig);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ret_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Ret);
		}
		if (GameToken.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GameToken);
		}
		if (GameTokenExpiredTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GameTokenExpiredTime);
		}
		if (Skey.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Skey);
		}
		if (SkeyExpiredTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SkeyExpiredTime);
		}
		if (authResult_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AuthResult);
		}
		if (UserJsonConfig.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UserJsonConfig);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AuthLoginRes other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ret_ != null)
		{
			if (ret_ == null)
			{
				Ret = new GssdkRet();
			}
			Ret.MergeFrom(other.Ret);
		}
		if (other.GameToken.Length != 0)
		{
			GameToken = other.GameToken;
		}
		if (other.GameTokenExpiredTime != 0)
		{
			GameTokenExpiredTime = other.GameTokenExpiredTime;
		}
		if (other.Skey.Length != 0)
		{
			Skey = other.Skey;
		}
		if (other.SkeyExpiredTime != 0)
		{
			SkeyExpiredTime = other.SkeyExpiredTime;
		}
		if (other.authResult_ != null)
		{
			if (authResult_ == null)
			{
				AuthResult = new UserAuthResult();
			}
			AuthResult.MergeFrom(other.AuthResult);
		}
		if (other.UserJsonConfig.Length != 0)
		{
			UserJsonConfig = other.UserJsonConfig;
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
				if (ret_ == null)
				{
					Ret = new GssdkRet();
				}
				input.ReadMessage(Ret);
				break;
			case 18u:
				GameToken = input.ReadString();
				break;
			case 24u:
				GameTokenExpiredTime = input.ReadUInt32();
				break;
			case 34u:
				Skey = input.ReadString();
				break;
			case 40u:
				SkeyExpiredTime = input.ReadUInt32();
				break;
			case 50u:
				if (authResult_ == null)
				{
					AuthResult = new UserAuthResult();
				}
				input.ReadMessage(AuthResult);
				break;
			case 58u:
				UserJsonConfig = input.ReadString();
				break;
			}
		}
	}
}
