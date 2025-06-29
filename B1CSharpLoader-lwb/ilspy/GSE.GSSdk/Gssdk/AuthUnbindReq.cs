using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class AuthUnbindReq : IMessage<AuthUnbindReq>, IMessage, IEquatable<AuthUnbindReq>, IDeepCloneable<AuthUnbindReq>
{
	private static readonly MessageParser<AuthUnbindReq> _parser = new MessageParser<AuthUnbindReq>(() => new AuthUnbindReq());

	private UnknownFieldSet _unknownFields;

	private UserInfo userInfoTodoDel_;

	private AuthUserChannelVerify verify_;

	private ReportUserKey userKey_;

	public static MessageParser<AuthUnbindReq> Parser => _parser;

	public UserInfo UserInfoTodoDel
	{
		get
		{
			return userInfoTodoDel_;
		}
		set
		{
			userInfoTodoDel_ = value;
		}
	}

	public AuthUserChannelVerify Verify
	{
		get
		{
			return verify_;
		}
		set
		{
			verify_ = value;
		}
	}

	public ReportUserKey UserKey
	{
		get
		{
			return userKey_;
		}
		set
		{
			userKey_ = value;
		}
	}

	public AuthUnbindReq()
	{
	}

	public AuthUnbindReq(AuthUnbindReq other)
		: this()
	{
		userInfoTodoDel_ = ((other.userInfoTodoDel_ != null) ? other.userInfoTodoDel_.Clone() : null);
		verify_ = ((other.verify_ != null) ? other.verify_.Clone() : null);
		userKey_ = ((other.userKey_ != null) ? other.userKey_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AuthUnbindReq Clone()
	{
		return new AuthUnbindReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AuthUnbindReq);
	}

	public bool Equals(AuthUnbindReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(UserInfoTodoDel, other.UserInfoTodoDel))
		{
			return false;
		}
		if (!object.Equals(Verify, other.Verify))
		{
			return false;
		}
		if (!object.Equals(UserKey, other.UserKey))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (userInfoTodoDel_ != null)
		{
			num ^= UserInfoTodoDel.GetHashCode();
		}
		if (verify_ != null)
		{
			num ^= Verify.GetHashCode();
		}
		if (userKey_ != null)
		{
			num ^= UserKey.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (userInfoTodoDel_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(UserInfoTodoDel);
		}
		if (verify_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Verify);
		}
		if (userKey_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(UserKey);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (userInfoTodoDel_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(UserInfoTodoDel);
		}
		if (verify_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Verify);
		}
		if (userKey_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(UserKey);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AuthUnbindReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.userInfoTodoDel_ != null)
		{
			if (userInfoTodoDel_ == null)
			{
				UserInfoTodoDel = new UserInfo();
			}
			UserInfoTodoDel.MergeFrom(other.UserInfoTodoDel);
		}
		if (other.verify_ != null)
		{
			if (verify_ == null)
			{
				Verify = new AuthUserChannelVerify();
			}
			Verify.MergeFrom(other.Verify);
		}
		if (other.userKey_ != null)
		{
			if (userKey_ == null)
			{
				UserKey = new ReportUserKey();
			}
			UserKey.MergeFrom(other.UserKey);
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
				if (userInfoTodoDel_ == null)
				{
					UserInfoTodoDel = new UserInfo();
				}
				input.ReadMessage(UserInfoTodoDel);
				break;
			case 18u:
				if (verify_ == null)
				{
					Verify = new AuthUserChannelVerify();
				}
				input.ReadMessage(Verify);
				break;
			case 26u:
				if (userKey_ == null)
				{
					UserKey = new ReportUserKey();
				}
				input.ReadMessage(UserKey);
				break;
			}
		}
	}
}
