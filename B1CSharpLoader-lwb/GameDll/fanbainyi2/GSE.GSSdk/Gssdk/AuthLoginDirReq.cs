using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class AuthLoginDirReq : IMessage<AuthLoginDirReq>, IMessage, IEquatable<AuthLoginDirReq>, IDeepCloneable<AuthLoginDirReq>
{
	private static readonly MessageParser<AuthLoginDirReq> _parser = new MessageParser<AuthLoginDirReq>(() => new AuthLoginDirReq());

	private UnknownFieldSet _unknownFields;

	private UserInfo userInfoTodoDel_;

	private AuthUserChannelVerify verify_;

	private UserDevice deviceTodoDel_;

	private ReportUserKey userKey_;

	public static MessageParser<AuthLoginDirReq> Parser => _parser;

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

	public UserDevice DeviceTodoDel
	{
		get
		{
			return deviceTodoDel_;
		}
		set
		{
			deviceTodoDel_ = value;
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

	public AuthLoginDirReq()
	{
	}

	public AuthLoginDirReq(AuthLoginDirReq other)
		: this()
	{
		userInfoTodoDel_ = ((other.userInfoTodoDel_ != null) ? other.userInfoTodoDel_.Clone() : null);
		verify_ = ((other.verify_ != null) ? other.verify_.Clone() : null);
		deviceTodoDel_ = ((other.deviceTodoDel_ != null) ? other.deviceTodoDel_.Clone() : null);
		userKey_ = ((other.userKey_ != null) ? other.userKey_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AuthLoginDirReq Clone()
	{
		return new AuthLoginDirReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AuthLoginDirReq);
	}

	public bool Equals(AuthLoginDirReq other)
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
		if (!object.Equals(DeviceTodoDel, other.DeviceTodoDel))
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
		if (deviceTodoDel_ != null)
		{
			num ^= DeviceTodoDel.GetHashCode();
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
		if (deviceTodoDel_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(DeviceTodoDel);
		}
		if (userKey_ != null)
		{
			output.WriteRawTag(34);
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
		if (deviceTodoDel_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DeviceTodoDel);
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

	public void MergeFrom(AuthLoginDirReq other)
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
		if (other.deviceTodoDel_ != null)
		{
			if (deviceTodoDel_ == null)
			{
				DeviceTodoDel = new UserDevice();
			}
			DeviceTodoDel.MergeFrom(other.DeviceTodoDel);
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
				if (deviceTodoDel_ == null)
				{
					DeviceTodoDel = new UserDevice();
				}
				input.ReadMessage(DeviceTodoDel);
				break;
			case 34u:
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
