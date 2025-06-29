using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class UserInfo : IMessage<UserInfo>, IMessage, IEquatable<UserInfo>, IDeepCloneable<UserInfo>
{
	private static readonly MessageParser<UserInfo> _parser = new MessageParser<UserInfo>(() => new UserInfo());

	private UnknownFieldSet _unknownFields;

	private UserDevice deviceInfo_;

	private UserAuthInfo authInfo_;

	private UserClientSetting clientSetting_;

	private UserGameSession userSession_;

	public static MessageParser<UserInfo> Parser => _parser;

	public UserDevice DeviceInfo
	{
		get
		{
			return deviceInfo_;
		}
		set
		{
			deviceInfo_ = value;
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

	public UserClientSetting ClientSetting
	{
		get
		{
			return clientSetting_;
		}
		set
		{
			clientSetting_ = value;
		}
	}

	public UserGameSession UserSession
	{
		get
		{
			return userSession_;
		}
		set
		{
			userSession_ = value;
		}
	}

	public UserInfo()
	{
	}

	public UserInfo(UserInfo other)
		: this()
	{
		deviceInfo_ = ((other.deviceInfo_ != null) ? other.deviceInfo_.Clone() : null);
		authInfo_ = ((other.authInfo_ != null) ? other.authInfo_.Clone() : null);
		clientSetting_ = ((other.clientSetting_ != null) ? other.clientSetting_.Clone() : null);
		userSession_ = ((other.userSession_ != null) ? other.userSession_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UserInfo Clone()
	{
		return new UserInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UserInfo);
	}

	public bool Equals(UserInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(DeviceInfo, other.DeviceInfo))
		{
			return false;
		}
		if (!object.Equals(AuthInfo, other.AuthInfo))
		{
			return false;
		}
		if (!object.Equals(ClientSetting, other.ClientSetting))
		{
			return false;
		}
		if (!object.Equals(UserSession, other.UserSession))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (deviceInfo_ != null)
		{
			num ^= DeviceInfo.GetHashCode();
		}
		if (authInfo_ != null)
		{
			num ^= AuthInfo.GetHashCode();
		}
		if (clientSetting_ != null)
		{
			num ^= ClientSetting.GetHashCode();
		}
		if (userSession_ != null)
		{
			num ^= UserSession.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (deviceInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(DeviceInfo);
		}
		if (authInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(AuthInfo);
		}
		if (clientSetting_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(ClientSetting);
		}
		if (userSession_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(UserSession);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (deviceInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DeviceInfo);
		}
		if (authInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AuthInfo);
		}
		if (clientSetting_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ClientSetting);
		}
		if (userSession_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(UserSession);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UserInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.deviceInfo_ != null)
		{
			if (deviceInfo_ == null)
			{
				DeviceInfo = new UserDevice();
			}
			DeviceInfo.MergeFrom(other.DeviceInfo);
		}
		if (other.authInfo_ != null)
		{
			if (authInfo_ == null)
			{
				AuthInfo = new UserAuthInfo();
			}
			AuthInfo.MergeFrom(other.AuthInfo);
		}
		if (other.clientSetting_ != null)
		{
			if (clientSetting_ == null)
			{
				ClientSetting = new UserClientSetting();
			}
			ClientSetting.MergeFrom(other.ClientSetting);
		}
		if (other.userSession_ != null)
		{
			if (userSession_ == null)
			{
				UserSession = new UserGameSession();
			}
			UserSession.MergeFrom(other.UserSession);
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
				if (deviceInfo_ == null)
				{
					DeviceInfo = new UserDevice();
				}
				input.ReadMessage(DeviceInfo);
				break;
			case 18u:
				if (authInfo_ == null)
				{
					AuthInfo = new UserAuthInfo();
				}
				input.ReadMessage(AuthInfo);
				break;
			case 26u:
				if (clientSetting_ == null)
				{
					ClientSetting = new UserClientSetting();
				}
				input.ReadMessage(ClientSetting);
				break;
			case 34u:
				if (userSession_ == null)
				{
					UserSession = new UserGameSession();
				}
				input.ReadMessage(UserSession);
				break;
			}
		}
	}
}
