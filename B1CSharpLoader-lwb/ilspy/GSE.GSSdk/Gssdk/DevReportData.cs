using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class DevReportData : IMessage<DevReportData>, IMessage, IEquatable<DevReportData>, IDeepCloneable<DevReportData>
{
	private static readonly MessageParser<DevReportData> _parser = new MessageParser<DevReportData>(() => new DevReportData());

	private UnknownFieldSet _unknownFields;

	private long id_;

	private uint time_;

	private uint gameStart_;

	private string deviceId_ = "";

	private string deviceInfo_ = "";

	private string sessionUuid_ = "";

	private string ip_ = "";

	private string hostName_ = "";

	private string userSdkId_ = "";

	private string userName_ = "";

	private string userRoleId_ = "";

	private uint frame_;

	private uint sequence_;

	private string tag_ = "";

	private string msgStr_ = "";

	private string associateFileUuid_ = "";

	private int cnt_;

	public static MessageParser<DevReportData> Parser => _parser;

	public long Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public uint Time
	{
		get
		{
			return time_;
		}
		set
		{
			time_ = value;
		}
	}

	public uint GameStart
	{
		get
		{
			return gameStart_;
		}
		set
		{
			gameStart_ = value;
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

	public uint Frame
	{
		get
		{
			return frame_;
		}
		set
		{
			frame_ = value;
		}
	}

	public uint Sequence
	{
		get
		{
			return sequence_;
		}
		set
		{
			sequence_ = value;
		}
	}

	public string Tag
	{
		get
		{
			return tag_;
		}
		set
		{
			tag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string MsgStr
	{
		get
		{
			return msgStr_;
		}
		set
		{
			msgStr_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string AssociateFileUuid
	{
		get
		{
			return associateFileUuid_;
		}
		set
		{
			associateFileUuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int Cnt
	{
		get
		{
			return cnt_;
		}
		set
		{
			cnt_ = value;
		}
	}

	public DevReportData()
	{
	}

	public DevReportData(DevReportData other)
		: this()
	{
		id_ = other.id_;
		time_ = other.time_;
		gameStart_ = other.gameStart_;
		deviceId_ = other.deviceId_;
		deviceInfo_ = other.deviceInfo_;
		sessionUuid_ = other.sessionUuid_;
		ip_ = other.ip_;
		hostName_ = other.hostName_;
		userSdkId_ = other.userSdkId_;
		userName_ = other.userName_;
		userRoleId_ = other.userRoleId_;
		frame_ = other.frame_;
		sequence_ = other.sequence_;
		tag_ = other.tag_;
		msgStr_ = other.msgStr_;
		associateFileUuid_ = other.associateFileUuid_;
		cnt_ = other.cnt_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DevReportData Clone()
	{
		return new DevReportData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DevReportData);
	}

	public bool Equals(DevReportData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (Time != other.Time)
		{
			return false;
		}
		if (GameStart != other.GameStart)
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
		if (Frame != other.Frame)
		{
			return false;
		}
		if (Sequence != other.Sequence)
		{
			return false;
		}
		if (Tag != other.Tag)
		{
			return false;
		}
		if (MsgStr != other.MsgStr)
		{
			return false;
		}
		if (AssociateFileUuid != other.AssociateFileUuid)
		{
			return false;
		}
		if (Cnt != other.Cnt)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0L)
		{
			num ^= Id.GetHashCode();
		}
		if (Time != 0)
		{
			num ^= Time.GetHashCode();
		}
		if (GameStart != 0)
		{
			num ^= GameStart.GetHashCode();
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
		if (Frame != 0)
		{
			num ^= Frame.GetHashCode();
		}
		if (Sequence != 0)
		{
			num ^= Sequence.GetHashCode();
		}
		if (Tag.Length != 0)
		{
			num ^= Tag.GetHashCode();
		}
		if (MsgStr.Length != 0)
		{
			num ^= MsgStr.GetHashCode();
		}
		if (AssociateFileUuid.Length != 0)
		{
			num ^= AssociateFileUuid.GetHashCode();
		}
		if (Cnt != 0)
		{
			num ^= Cnt.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(Id);
		}
		if (Time != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Time);
		}
		if (GameStart != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(GameStart);
		}
		if (DeviceId.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(DeviceId);
		}
		if (DeviceInfo.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(DeviceInfo);
		}
		if (SessionUuid.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(SessionUuid);
		}
		if (Ip.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(Ip);
		}
		if (HostName.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(HostName);
		}
		if (UserSdkId.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(UserSdkId);
		}
		if (UserName.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(UserName);
		}
		if (UserRoleId.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(UserRoleId);
		}
		if (Frame != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Frame);
		}
		if (Sequence != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Sequence);
		}
		if (Tag.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteString(Tag);
		}
		if (MsgStr.Length != 0)
		{
			output.WriteRawTag(122);
			output.WriteString(MsgStr);
		}
		if (AssociateFileUuid.Length != 0)
		{
			output.WriteRawTag(130, 1);
			output.WriteString(AssociateFileUuid);
		}
		if (Cnt != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(Cnt);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Id);
		}
		if (Time != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Time);
		}
		if (GameStart != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GameStart);
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
		if (Frame != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Frame);
		}
		if (Sequence != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Sequence);
		}
		if (Tag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Tag);
		}
		if (MsgStr.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MsgStr);
		}
		if (AssociateFileUuid.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(AssociateFileUuid);
		}
		if (Cnt != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(Cnt);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DevReportData other)
	{
		if (other != null)
		{
			if (other.Id != 0L)
			{
				Id = other.Id;
			}
			if (other.Time != 0)
			{
				Time = other.Time;
			}
			if (other.GameStart != 0)
			{
				GameStart = other.GameStart;
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
			if (other.Frame != 0)
			{
				Frame = other.Frame;
			}
			if (other.Sequence != 0)
			{
				Sequence = other.Sequence;
			}
			if (other.Tag.Length != 0)
			{
				Tag = other.Tag;
			}
			if (other.MsgStr.Length != 0)
			{
				MsgStr = other.MsgStr;
			}
			if (other.AssociateFileUuid.Length != 0)
			{
				AssociateFileUuid = other.AssociateFileUuid;
			}
			if (other.Cnt != 0)
			{
				Cnt = other.Cnt;
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
				Id = input.ReadInt64();
				break;
			case 16u:
				Time = input.ReadUInt32();
				break;
			case 24u:
				GameStart = input.ReadUInt32();
				break;
			case 34u:
				DeviceId = input.ReadString();
				break;
			case 42u:
				DeviceInfo = input.ReadString();
				break;
			case 50u:
				SessionUuid = input.ReadString();
				break;
			case 58u:
				Ip = input.ReadString();
				break;
			case 66u:
				HostName = input.ReadString();
				break;
			case 74u:
				UserSdkId = input.ReadString();
				break;
			case 82u:
				UserName = input.ReadString();
				break;
			case 90u:
				UserRoleId = input.ReadString();
				break;
			case 96u:
				Frame = input.ReadUInt32();
				break;
			case 104u:
				Sequence = input.ReadUInt32();
				break;
			case 114u:
				Tag = input.ReadString();
				break;
			case 122u:
				MsgStr = input.ReadString();
				break;
			case 130u:
				AssociateFileUuid = input.ReadString();
				break;
			case 136u:
				Cnt = input.ReadInt32();
				break;
			}
		}
	}
}
