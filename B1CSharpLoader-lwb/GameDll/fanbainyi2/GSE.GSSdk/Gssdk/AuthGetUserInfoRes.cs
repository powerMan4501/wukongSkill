using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class AuthGetUserInfoRes : IMessage<AuthGetUserInfoRes>, IMessage, IEquatable<AuthGetUserInfoRes>, IDeepCloneable<AuthGetUserInfoRes>
{
	private static readonly MessageParser<AuthGetUserInfoRes> _parser = new MessageParser<AuthGetUserInfoRes>(() => new AuthGetUserInfoRes());

	private UnknownFieldSet _unknownFields;

	private GssdkRet ret_;

	private UserAuthResult authResult_;

	private AccountProfile profile_;

	public static MessageParser<AuthGetUserInfoRes> Parser => _parser;

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

	public AccountProfile Profile
	{
		get
		{
			return profile_;
		}
		set
		{
			profile_ = value;
		}
	}

	public AuthGetUserInfoRes()
	{
	}

	public AuthGetUserInfoRes(AuthGetUserInfoRes other)
		: this()
	{
		ret_ = ((other.ret_ != null) ? other.ret_.Clone() : null);
		authResult_ = ((other.authResult_ != null) ? other.authResult_.Clone() : null);
		profile_ = ((other.profile_ != null) ? other.profile_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AuthGetUserInfoRes Clone()
	{
		return new AuthGetUserInfoRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AuthGetUserInfoRes);
	}

	public bool Equals(AuthGetUserInfoRes other)
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
		if (!object.Equals(AuthResult, other.AuthResult))
		{
			return false;
		}
		if (!object.Equals(Profile, other.Profile))
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
		if (authResult_ != null)
		{
			num ^= AuthResult.GetHashCode();
		}
		if (profile_ != null)
		{
			num ^= Profile.GetHashCode();
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
		if (authResult_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(AuthResult);
		}
		if (profile_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Profile);
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
		if (authResult_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AuthResult);
		}
		if (profile_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Profile);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AuthGetUserInfoRes other)
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
		if (other.authResult_ != null)
		{
			if (authResult_ == null)
			{
				AuthResult = new UserAuthResult();
			}
			AuthResult.MergeFrom(other.AuthResult);
		}
		if (other.profile_ != null)
		{
			if (profile_ == null)
			{
				Profile = new AccountProfile();
			}
			Profile.MergeFrom(other.Profile);
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
				if (authResult_ == null)
				{
					AuthResult = new UserAuthResult();
				}
				input.ReadMessage(AuthResult);
				break;
			case 26u:
				if (profile_ == null)
				{
					Profile = new AccountProfile();
				}
				input.ReadMessage(Profile);
				break;
			}
		}
	}
}
