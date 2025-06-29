using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GsOnline;

public sealed class SessionSetting : IMessage<SessionSetting>, IMessage, IEquatable<SessionSetting>, IDeepCloneable<SessionSetting>
{
	private static readonly MessageParser<SessionSetting> _parser = new MessageParser<SessionSetting>(() => new SessionSetting());

	private UnknownFieldSet _unknownFields;

	private string sessionName_ = "";

	private string mapName_ = "";

	private string mapNickName_ = "";

	private uint maxMemberNum_;

	private SessionAdvertiseType advertiseType_;

	private BattleHostType hostType_;

	private static readonly FieldCodec<SessionCustomSetting> _repeated_customSettings_codec = FieldCodec.ForMessage(58u, SessionCustomSetting.Parser);

	private readonly RepeatedField<SessionCustomSetting> customSettings_ = new RepeatedField<SessionCustomSetting>();

	private string password_ = "";

	public static MessageParser<SessionSetting> Parser => _parser;

	public string SessionName
	{
		get
		{
			return sessionName_;
		}
		set
		{
			sessionName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string MapName
	{
		get
		{
			return mapName_;
		}
		set
		{
			mapName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string MapNickName
	{
		get
		{
			return mapNickName_;
		}
		set
		{
			mapNickName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public uint MaxMemberNum
	{
		get
		{
			return maxMemberNum_;
		}
		set
		{
			maxMemberNum_ = value;
		}
	}

	public SessionAdvertiseType AdvertiseType
	{
		get
		{
			return advertiseType_;
		}
		set
		{
			advertiseType_ = value;
		}
	}

	public BattleHostType HostType
	{
		get
		{
			return hostType_;
		}
		set
		{
			hostType_ = value;
		}
	}

	public RepeatedField<SessionCustomSetting> CustomSettings => customSettings_;

	public string Password
	{
		get
		{
			return password_;
		}
		set
		{
			password_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public SessionSetting()
	{
	}

	public SessionSetting(SessionSetting other)
		: this()
	{
		sessionName_ = other.sessionName_;
		mapName_ = other.mapName_;
		mapNickName_ = other.mapNickName_;
		maxMemberNum_ = other.maxMemberNum_;
		advertiseType_ = other.advertiseType_;
		hostType_ = other.hostType_;
		customSettings_ = other.customSettings_.Clone();
		password_ = other.password_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SessionSetting Clone()
	{
		return new SessionSetting(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SessionSetting);
	}

	public bool Equals(SessionSetting other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SessionName != other.SessionName)
		{
			return false;
		}
		if (MapName != other.MapName)
		{
			return false;
		}
		if (MapNickName != other.MapNickName)
		{
			return false;
		}
		if (MaxMemberNum != other.MaxMemberNum)
		{
			return false;
		}
		if (AdvertiseType != other.AdvertiseType)
		{
			return false;
		}
		if (HostType != other.HostType)
		{
			return false;
		}
		if (!customSettings_.Equals(other.customSettings_))
		{
			return false;
		}
		if (Password != other.Password)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SessionName.Length != 0)
		{
			num ^= SessionName.GetHashCode();
		}
		if (MapName.Length != 0)
		{
			num ^= MapName.GetHashCode();
		}
		if (MapNickName.Length != 0)
		{
			num ^= MapNickName.GetHashCode();
		}
		if (MaxMemberNum != 0)
		{
			num ^= MaxMemberNum.GetHashCode();
		}
		if (AdvertiseType != SessionAdvertiseType.Private)
		{
			num ^= AdvertiseType.GetHashCode();
		}
		if (HostType != BattleHostType.P2P)
		{
			num ^= HostType.GetHashCode();
		}
		num ^= customSettings_.GetHashCode();
		if (Password.Length != 0)
		{
			num ^= Password.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SessionName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(SessionName);
		}
		if (MapName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(MapName);
		}
		if (MapNickName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(MapNickName);
		}
		if (MaxMemberNum != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(MaxMemberNum);
		}
		if (AdvertiseType != SessionAdvertiseType.Private)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)AdvertiseType);
		}
		if (HostType != BattleHostType.P2P)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)HostType);
		}
		customSettings_.WriteTo(output, _repeated_customSettings_codec);
		if (Password.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(Password);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SessionName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SessionName);
		}
		if (MapName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MapName);
		}
		if (MapNickName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MapNickName);
		}
		if (MaxMemberNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MaxMemberNum);
		}
		if (AdvertiseType != SessionAdvertiseType.Private)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AdvertiseType);
		}
		if (HostType != BattleHostType.P2P)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HostType);
		}
		num += customSettings_.CalculateSize(_repeated_customSettings_codec);
		if (Password.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Password);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SessionSetting other)
	{
		if (other != null)
		{
			if (other.SessionName.Length != 0)
			{
				SessionName = other.SessionName;
			}
			if (other.MapName.Length != 0)
			{
				MapName = other.MapName;
			}
			if (other.MapNickName.Length != 0)
			{
				MapNickName = other.MapNickName;
			}
			if (other.MaxMemberNum != 0)
			{
				MaxMemberNum = other.MaxMemberNum;
			}
			if (other.AdvertiseType != SessionAdvertiseType.Private)
			{
				AdvertiseType = other.AdvertiseType;
			}
			if (other.HostType != BattleHostType.P2P)
			{
				HostType = other.HostType;
			}
			customSettings_.Add(other.customSettings_);
			if (other.Password.Length != 0)
			{
				Password = other.Password;
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
			case 10u:
				SessionName = input.ReadString();
				break;
			case 18u:
				MapName = input.ReadString();
				break;
			case 26u:
				MapNickName = input.ReadString();
				break;
			case 32u:
				MaxMemberNum = input.ReadUInt32();
				break;
			case 40u:
				AdvertiseType = (SessionAdvertiseType)input.ReadEnum();
				break;
			case 48u:
				HostType = (BattleHostType)input.ReadEnum();
				break;
			case 58u:
				customSettings_.AddEntriesFrom(input, _repeated_customSettings_codec);
				break;
			case 66u:
				Password = input.ReadString();
				break;
			}
		}
	}
}
