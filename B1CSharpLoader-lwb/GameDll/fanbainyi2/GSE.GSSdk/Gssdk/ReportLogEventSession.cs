using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class ReportLogEventSession : IMessage<ReportLogEventSession>, IMessage, IEquatable<ReportLogEventSession>, IDeepCloneable<ReportLogEventSession>
{
	private static readonly MessageParser<ReportLogEventSession> _parser = new MessageParser<ReportLogEventSession>(() => new ReportLogEventSession());

	private UnknownFieldSet _unknownFields;

	private uint gameStartTimestamp_;

	private string deviceId_ = "";

	private string deviceInfo_ = "";

	private string sessionUuid_ = "";

	private string ip_ = "";

	private string hostName_ = "";

	private string userSdkId_ = "";

	private string userName_ = "";

	private string userRoleId_ = "";

	public static MessageParser<ReportLogEventSession> Parser => _parser;

	public uint GameStartTimestamp
	{
		get
		{
			return gameStartTimestamp_;
		}
		set
		{
			gameStartTimestamp_ = value;
		}
	}

	public string DeviceId
	{
		get
		{
			return deviceId_;
		}
		set
		{
			deviceId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DeviceInfo
	{
		get
		{
			return deviceInfo_;
		}
		set
		{
			deviceInfo_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string SessionUuid
	{
		get
		{
			return sessionUuid_;
		}
		set
		{
			sessionUuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Ip
	{
		get
		{
			return ip_;
		}
		set
		{
			ip_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string HostName
	{
		get
		{
			return hostName_;
		}
		set
		{
			hostName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string UserSdkId
	{
		get
		{
			return userSdkId_;
		}
		set
		{
			userSdkId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string UserName
	{
		get
		{
			return userName_;
		}
		set
		{
			userName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string UserRoleId
	{
		get
		{
			return userRoleId_;
		}
		set
		{
			userRoleId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ReportLogEventSession()
	{
	}

	public ReportLogEventSession(ReportLogEventSession other)
		: this()
	{
		gameStartTimestamp_ = other.gameStartTimestamp_;
		deviceId_ = other.deviceId_;
		deviceInfo_ = other.deviceInfo_;
		sessionUuid_ = other.sessionUuid_;
		ip_ = other.ip_;
		hostName_ = other.hostName_;
		userSdkId_ = other.userSdkId_;
		userName_ = other.userName_;
		userRoleId_ = other.userRoleId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportLogEventSession Clone()
	{
		return new ReportLogEventSession(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportLogEventSession);
	}

	public bool Equals(ReportLogEventSession other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GameStartTimestamp != other.GameStartTimestamp)
		{
			return false;
		}
		if (DeviceId != other.DeviceId)
		{
			return false;
		}
		if (DeviceInfo != other.DeviceInfo)
		{
			return false;
		}
		if (SessionUuid != other.SessionUuid)
		{
			return false;
		}
		if (Ip != other.Ip)
		{
			return false;
		}
		if (HostName != other.HostName)
		{
			return false;
		}
		if (UserSdkId != other.UserSdkId)
		{
			return false;
		}
		if (UserName != other.UserName)
		{
			return false;
		}
		if (UserRoleId != other.UserRoleId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (GameStartTimestamp != 0)
		{
			num ^= GameStartTimestamp.GetHashCode();
		}
		if (DeviceId.Length != 0)
		{
			num ^= DeviceId.GetHashCode();
		}
		if (DeviceInfo.Length != 0)
		{
			num ^= DeviceInfo.GetHashCode();
		}
		if (SessionUuid.Length != 0)
		{
			num ^= SessionUuid.GetHashCode();
		}
		if (Ip.Length != 0)
		{
			num ^= Ip.GetHashCode();
		}
		if (HostName.Length != 0)
		{
			num ^= HostName.GetHashCode();
		}
		if (UserSdkId.Length != 0)
		{
			num ^= UserSdkId.GetHashCode();
		}
		if (UserName.Length != 0)
		{
			num ^= UserName.GetHashCode();
		}
		if (UserRoleId.Length != 0)
		{
			num ^= UserRoleId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (GameStartTimestamp != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(GameStartTimestamp);
		}
		if (DeviceId.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(DeviceId);
		}
		if (DeviceInfo.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(DeviceInfo);
		}
		if (SessionUuid.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(SessionUuid);
		}
		if (Ip.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Ip);
		}
		if (HostName.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(HostName);
		}
		if (UserSdkId.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(UserSdkId);
		}
		if (UserName.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(UserName);
		}
		if (UserRoleId.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(UserRoleId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (GameStartTimestamp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GameStartTimestamp);
		}
		if (DeviceId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DeviceId);
		}
		if (DeviceInfo.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DeviceInfo);
		}
		if (SessionUuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SessionUuid);
		}
		if (Ip.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Ip);
		}
		if (HostName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(HostName);
		}
		if (UserSdkId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UserSdkId);
		}
		if (UserName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UserName);
		}
		if (UserRoleId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UserRoleId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportLogEventSession other)
	{
		if (other != null)
		{
			if (other.GameStartTimestamp != 0)
			{
				GameStartTimestamp = other.GameStartTimestamp;
			}
			if (other.DeviceId.Length != 0)
			{
				DeviceId = other.DeviceId;
			}
			if (other.DeviceInfo.Length != 0)
			{
				DeviceInfo = other.DeviceInfo;
			}
			if (other.SessionUuid.Length != 0)
			{
				SessionUuid = other.SessionUuid;
			}
			if (other.Ip.Length != 0)
			{
				Ip = other.Ip;
			}
			if (other.HostName.Length != 0)
			{
				HostName = other.HostName;
			}
			if (other.UserSdkId.Length != 0)
			{
				UserSdkId = other.UserSdkId;
			}
			if (other.UserName.Length != 0)
			{
				UserName = other.UserName;
			}
			if (other.UserRoleId.Length != 0)
			{
				UserRoleId = other.UserRoleId;
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
			case 8u:
				GameStartTimestamp = input.ReadUInt32();
				break;
			case 18u:
				DeviceId = input.ReadString();
				break;
			case 26u:
				DeviceInfo = input.ReadString();
				break;
			case 34u:
				SessionUuid = input.ReadString();
				break;
			case 42u:
				Ip = input.ReadString();
				break;
			case 50u:
				HostName = input.ReadString();
				break;
			case 58u:
				UserSdkId = input.ReadString();
				break;
			case 66u:
				UserName = input.ReadString();
				break;
			case 74u:
				UserRoleId = input.ReadString();
				break;
			}
		}
	}
}
