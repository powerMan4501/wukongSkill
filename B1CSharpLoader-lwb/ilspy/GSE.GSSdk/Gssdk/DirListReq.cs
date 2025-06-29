using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class DirListReq : IMessage<DirListReq>, IMessage, IEquatable<DirListReq>, IDeepCloneable<DirListReq>
{
	private static readonly MessageParser<DirListReq> _parser = new MessageParser<DirListReq>(() => new DirListReq());

	private UnknownFieldSet _unknownFields;

	private UserDevice deviceTodoDel_;

	private UserInfo userTodoDel_;

	private ReportUserKey userKey_;

	private UserAuthInfo authInfo_;

	public static MessageParser<DirListReq> Parser => _parser;

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

	public UserInfo UserTodoDel
	{
		get
		{
			return userTodoDel_;
		}
		set
		{
			userTodoDel_ = value;
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

	public UserAuthInfo AuthInfo
	{
		get
		{
			return authInfo_;
		}
		set
		{
			authInfo_ = value;
		}
	}

	public DirListReq()
	{
	}

	public DirListReq(DirListReq other)
		: this()
	{
		deviceTodoDel_ = ((other.deviceTodoDel_ != null) ? other.deviceTodoDel_.Clone() : null);
		userTodoDel_ = ((other.userTodoDel_ != null) ? other.userTodoDel_.Clone() : null);
		userKey_ = ((other.userKey_ != null) ? other.userKey_.Clone() : null);
		authInfo_ = ((other.authInfo_ != null) ? other.authInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DirListReq Clone()
	{
		return new DirListReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DirListReq);
	}

	public bool Equals(DirListReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(DeviceTodoDel, other.DeviceTodoDel))
		{
			return false;
		}
		if (!object.Equals(UserTodoDel, other.UserTodoDel))
		{
			return false;
		}
		if (!object.Equals(UserKey, other.UserKey))
		{
			return false;
		}
		if (!object.Equals(AuthInfo, other.AuthInfo))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (deviceTodoDel_ != null)
		{
			num ^= DeviceTodoDel.GetHashCode();
		}
		if (userTodoDel_ != null)
		{
			num ^= UserTodoDel.GetHashCode();
		}
		if (userKey_ != null)
		{
			num ^= UserKey.GetHashCode();
		}
		if (authInfo_ != null)
		{
			num ^= AuthInfo.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (deviceTodoDel_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(DeviceTodoDel);
		}
		if (userTodoDel_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(UserTodoDel);
		}
		if (userKey_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(UserKey);
		}
		if (authInfo_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(AuthInfo);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (deviceTodoDel_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DeviceTodoDel);
		}
		if (userTodoDel_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(UserTodoDel);
		}
		if (userKey_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(UserKey);
		}
		if (authInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AuthInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DirListReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.deviceTodoDel_ != null)
		{
			if (deviceTodoDel_ == null)
			{
				DeviceTodoDel = new UserDevice();
			}
			DeviceTodoDel.MergeFrom(other.DeviceTodoDel);
		}
		if (other.userTodoDel_ != null)
		{
			if (userTodoDel_ == null)
			{
				UserTodoDel = new UserInfo();
			}
			UserTodoDel.MergeFrom(other.UserTodoDel);
		}
		if (other.userKey_ != null)
		{
			if (userKey_ == null)
			{
				UserKey = new ReportUserKey();
			}
			UserKey.MergeFrom(other.UserKey);
		}
		if (other.authInfo_ != null)
		{
			if (authInfo_ == null)
			{
				AuthInfo = new UserAuthInfo();
			}
			AuthInfo.MergeFrom(other.AuthInfo);
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
				if (deviceTodoDel_ == null)
				{
					DeviceTodoDel = new UserDevice();
				}
				input.ReadMessage(DeviceTodoDel);
				break;
			case 18u:
				if (userTodoDel_ == null)
				{
					UserTodoDel = new UserInfo();
				}
				input.ReadMessage(UserTodoDel);
				break;
			case 26u:
				if (userKey_ == null)
				{
					UserKey = new ReportUserKey();
				}
				input.ReadMessage(UserKey);
				break;
			case 34u:
				if (authInfo_ == null)
				{
					AuthInfo = new UserAuthInfo();
				}
				input.ReadMessage(AuthInfo);
				break;
			}
		}
	}
}
