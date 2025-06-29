using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class VersionCheckConfigReq : IMessage<VersionCheckConfigReq>, IMessage, IEquatable<VersionCheckConfigReq>, IDeepCloneable<VersionCheckConfigReq>
{
	private static readonly MessageParser<VersionCheckConfigReq> _parser = new MessageParser<VersionCheckConfigReq>(() => new VersionCheckConfigReq());

	private UnknownFieldSet _unknownFields;

	private UserInfo userInfoTodoDelete_;

	private VersionCheckConfigUserInfo userInfo_;

	private ReportUserKey userKey_;

	public static MessageParser<VersionCheckConfigReq> Parser => _parser;

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

	public VersionCheckConfigUserInfo UserInfo
	{
		get
		{
			return userInfo_;
		}
		set
		{
			userInfo_ = value;
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

	public VersionCheckConfigReq()
	{
	}

	public VersionCheckConfigReq(VersionCheckConfigReq other)
		: this()
	{
		userInfoTodoDelete_ = ((other.userInfoTodoDelete_ != null) ? other.userInfoTodoDelete_.Clone() : null);
		userInfo_ = ((other.userInfo_ != null) ? other.userInfo_.Clone() : null);
		userKey_ = ((other.userKey_ != null) ? other.userKey_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public VersionCheckConfigReq Clone()
	{
		return new VersionCheckConfigReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as VersionCheckConfigReq);
	}

	public bool Equals(VersionCheckConfigReq other)
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
		if (!object.Equals(UserInfo, other.UserInfo))
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
		if (userInfo_ != null)
		{
			num ^= UserInfo.GetHashCode();
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
		if (userInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(UserInfo);
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
		if (userInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(UserInfo);
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

	public void MergeFrom(VersionCheckConfigReq other)
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
		if (other.userInfo_ != null)
		{
			if (userInfo_ == null)
			{
				UserInfo = new VersionCheckConfigUserInfo();
			}
			UserInfo.MergeFrom(other.UserInfo);
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
				if (userInfo_ == null)
				{
					UserInfo = new VersionCheckConfigUserInfo();
				}
				input.ReadMessage(UserInfo);
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
