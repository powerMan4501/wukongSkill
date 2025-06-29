using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class AuthLoginReq : IMessage<AuthLoginReq>, IMessage, IEquatable<AuthLoginReq>, IDeepCloneable<AuthLoginReq>
{
	private static readonly MessageParser<AuthLoginReq> _parser = new MessageParser<AuthLoginReq>(() => new AuthLoginReq());

	private UnknownFieldSet _unknownFields;

	private UserInfo userInfoTodoDelete_;

	private AuthUserChannelVerify verify_;

	private ReportUserKey userKey_;

	public static MessageParser<AuthLoginReq> Parser => _parser;

	public UserInfo UserInfoTodoDelete
	{
		get
		{
			return userInfoTodoDelete_;
		}
		set
		{
			userInfoTodoDelete_ = value;
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

	public AuthLoginReq()
	{
	}

	public AuthLoginReq(AuthLoginReq other)
		: this()
	{
		userInfoTodoDelete_ = ((other.userInfoTodoDelete_ != null) ? other.userInfoTodoDelete_.Clone() : null);
		verify_ = ((other.verify_ != null) ? other.verify_.Clone() : null);
		userKey_ = ((other.userKey_ != null) ? other.userKey_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AuthLoginReq Clone()
	{
		return new AuthLoginReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AuthLoginReq);
	}

	public bool Equals(AuthLoginReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(UserInfoTodoDelete, other.UserInfoTodoDelete))
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
		if (userInfoTodoDelete_ != null)
		{
			num ^= UserInfoTodoDelete.GetHashCode();
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
		if (userInfoTodoDelete_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(UserInfoTodoDelete);
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
		if (userInfoTodoDelete_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(UserInfoTodoDelete);
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

	public void MergeFrom(AuthLoginReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.userInfoTodoDelete_ != null)
		{
			if (userInfoTodoDelete_ == null)
			{
				UserInfoTodoDelete = new UserInfo();
			}
			UserInfoTodoDelete.MergeFrom(other.UserInfoTodoDelete);
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
				if (userInfoTodoDelete_ == null)
				{
					UserInfoTodoDelete = new UserInfo();
				}
				input.ReadMessage(UserInfoTodoDelete);
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
