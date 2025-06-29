using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class LobbySetting : IMessage<LobbySetting>, IMessage, IEquatable<LobbySetting>, IDeepCloneable<LobbySetting>
{
	private static readonly MessageParser<LobbySetting> _parser = new MessageParser<LobbySetting>(() => new LobbySetting());

	private UnknownFieldSet _unknownFields;

	private string name_ = "";

	private string mapName_ = "";

	private string mapNickName_ = "";

	private uint maxMemberNum_;

	private LobbyAdvertiseType advertiseType_;

	private BattleHostType hostType_;

	private string password_ = "";

	private static readonly FieldCodec<LobbyCustomSetting> _repeated_customSettings_codec = FieldCodec.ForMessage(66u, LobbyCustomSetting.Parser);

	private readonly RepeatedField<LobbyCustomSetting> customSettings_ = new RepeatedField<LobbyCustomSetting>();

	public static MessageParser<LobbySetting> Parser => _parser;

	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public LobbyAdvertiseType AdvertiseType
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

	public RepeatedField<LobbyCustomSetting> CustomSettings => customSettings_;

	public LobbySetting()
	{
	}

	public LobbySetting(LobbySetting other)
		: this()
	{
		name_ = other.name_;
		mapName_ = other.mapName_;
		mapNickName_ = other.mapNickName_;
		maxMemberNum_ = other.maxMemberNum_;
		advertiseType_ = other.advertiseType_;
		hostType_ = other.hostType_;
		password_ = other.password_;
		customSettings_ = other.customSettings_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LobbySetting Clone()
	{
		return new LobbySetting(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LobbySetting);
	}

	public bool Equals(LobbySetting other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Name != other.Name)
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
		if (Password != other.Password)
		{
			return false;
		}
		if (!customSettings_.Equals(other.customSettings_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
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
		if (AdvertiseType != LobbyAdvertiseType.Private)
		{
			num ^= AdvertiseType.GetHashCode();
		}
		if (HostType != BattleHostType.P2P)
		{
			num ^= HostType.GetHashCode();
		}
		if (Password.Length != 0)
		{
			num ^= Password.GetHashCode();
		}
		num ^= customSettings_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Name.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Name);
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
		if (AdvertiseType != LobbyAdvertiseType.Private)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)AdvertiseType);
		}
		if (HostType != BattleHostType.P2P)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)HostType);
		}
		if (Password.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(Password);
		}
		customSettings_.WriteTo(output, _repeated_customSettings_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
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
		if (AdvertiseType != LobbyAdvertiseType.Private)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AdvertiseType);
		}
		if (HostType != BattleHostType.P2P)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HostType);
		}
		if (Password.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Password);
		}
		num += customSettings_.CalculateSize(_repeated_customSettings_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LobbySetting other)
	{
		if (other != null)
		{
			if (other.Name.Length != 0)
			{
				Name = other.Name;
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
			if (other.AdvertiseType != LobbyAdvertiseType.Private)
			{
				AdvertiseType = other.AdvertiseType;
			}
			if (other.HostType != BattleHostType.P2P)
			{
				HostType = other.HostType;
			}
			if (other.Password.Length != 0)
			{
				Password = other.Password;
			}
			customSettings_.Add(other.customSettings_);
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
				Name = input.ReadString();
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
				AdvertiseType = (LobbyAdvertiseType)input.ReadEnum();
				break;
			case 48u:
				HostType = (BattleHostType)input.ReadEnum();
				break;
			case 58u:
				Password = input.ReadString();
				break;
			case 66u:
				customSettings_.AddEntriesFrom(input, _repeated_customSettings_codec);
				break;
			}
		}
	}
}
