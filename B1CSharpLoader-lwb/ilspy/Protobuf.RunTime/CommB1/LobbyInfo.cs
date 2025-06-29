using System;
using Google.Protobuf;

namespace CommB1;

public sealed class LobbyInfo : IMessage<LobbyInfo>, IMessage, IEquatable<LobbyInfo>, IDeepCloneable<LobbyInfo>
{
	private static readonly MessageParser<LobbyInfo> _parser = new MessageParser<LobbyInfo>(() => new LobbyInfo());

	private UnknownFieldSet _unknownFields;

	private ulong lobbyId_;

	private string name_ = "";

	private ulong owner_;

	private string ownerName_ = "";

	private string mapName_ = "";

	private string mapNickName_ = "";

	private uint maxMemberNum_;

	private uint curMemberNum_;

	private LobbyAdvertiseType advertiseType_;

	private LobbyState state_;

	private bool password_;

	public static MessageParser<LobbyInfo> Parser => _parser;

	public ulong LobbyId
	{
		get
		{
			return lobbyId_;
		}
		set
		{
			lobbyId_ = value;
		}
	}

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

	public ulong Owner
	{
		get
		{
			return owner_;
		}
		set
		{
			owner_ = value;
		}
	}

	public string OwnerName
	{
		get
		{
			return ownerName_;
		}
		set
		{
			ownerName_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public uint CurMemberNum
	{
		get
		{
			return curMemberNum_;
		}
		set
		{
			curMemberNum_ = value;
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

	public LobbyState State
	{
		get
		{
			return state_;
		}
		set
		{
			state_ = value;
		}
	}

	public bool Password
	{
		get
		{
			return password_;
		}
		set
		{
			password_ = value;
		}
	}

	public LobbyInfo()
	{
	}

	public LobbyInfo(LobbyInfo other)
		: this()
	{
		lobbyId_ = other.lobbyId_;
		name_ = other.name_;
		owner_ = other.owner_;
		ownerName_ = other.ownerName_;
		mapName_ = other.mapName_;
		mapNickName_ = other.mapNickName_;
		maxMemberNum_ = other.maxMemberNum_;
		curMemberNum_ = other.curMemberNum_;
		advertiseType_ = other.advertiseType_;
		state_ = other.state_;
		password_ = other.password_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LobbyInfo Clone()
	{
		return new LobbyInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LobbyInfo);
	}

	public bool Equals(LobbyInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LobbyId != other.LobbyId)
		{
			return false;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (Owner != other.Owner)
		{
			return false;
		}
		if (OwnerName != other.OwnerName)
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
		if (CurMemberNum != other.CurMemberNum)
		{
			return false;
		}
		if (AdvertiseType != other.AdvertiseType)
		{
			return false;
		}
		if (State != other.State)
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
		if (LobbyId != 0L)
		{
			num ^= LobbyId.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (Owner != 0L)
		{
			num ^= Owner.GetHashCode();
		}
		if (OwnerName.Length != 0)
		{
			num ^= OwnerName.GetHashCode();
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
		if (CurMemberNum != 0)
		{
			num ^= CurMemberNum.GetHashCode();
		}
		if (AdvertiseType != LobbyAdvertiseType.Private)
		{
			num ^= AdvertiseType.GetHashCode();
		}
		if (State != LobbyState.Create)
		{
			num ^= State.GetHashCode();
		}
		if (Password)
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
		if (LobbyId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(LobbyId);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Name);
		}
		if (Owner != 0L)
		{
			output.WriteRawTag(24);
			output.WriteUInt64(Owner);
		}
		if (OwnerName.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(OwnerName);
		}
		if (MapName.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(MapName);
		}
		if (MapNickName.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(MapNickName);
		}
		if (MaxMemberNum != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(MaxMemberNum);
		}
		if (CurMemberNum != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(CurMemberNum);
		}
		if (AdvertiseType != LobbyAdvertiseType.Private)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)AdvertiseType);
		}
		if (State != LobbyState.Create)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)State);
		}
		if (Password)
		{
			output.WriteRawTag(88);
			output.WriteBool(Password);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (LobbyId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(LobbyId);
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (Owner != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Owner);
		}
		if (OwnerName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(OwnerName);
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
		if (CurMemberNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurMemberNum);
		}
		if (AdvertiseType != LobbyAdvertiseType.Private)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AdvertiseType);
		}
		if (State != LobbyState.Create)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)State);
		}
		if (Password)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LobbyInfo other)
	{
		if (other != null)
		{
			if (other.LobbyId != 0L)
			{
				LobbyId = other.LobbyId;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.Owner != 0L)
			{
				Owner = other.Owner;
			}
			if (other.OwnerName.Length != 0)
			{
				OwnerName = other.OwnerName;
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
			if (other.CurMemberNum != 0)
			{
				CurMemberNum = other.CurMemberNum;
			}
			if (other.AdvertiseType != LobbyAdvertiseType.Private)
			{
				AdvertiseType = other.AdvertiseType;
			}
			if (other.State != LobbyState.Create)
			{
				State = other.State;
			}
			if (other.Password)
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
			case 8u:
				LobbyId = input.ReadUInt64();
				break;
			case 18u:
				Name = input.ReadString();
				break;
			case 24u:
				Owner = input.ReadUInt64();
				break;
			case 34u:
				OwnerName = input.ReadString();
				break;
			case 42u:
				MapName = input.ReadString();
				break;
			case 50u:
				MapNickName = input.ReadString();
				break;
			case 56u:
				MaxMemberNum = input.ReadUInt32();
				break;
			case 64u:
				CurMemberNum = input.ReadUInt32();
				break;
			case 72u:
				AdvertiseType = (LobbyAdvertiseType)input.ReadEnum();
				break;
			case 80u:
				State = (LobbyState)input.ReadEnum();
				break;
			case 88u:
				Password = input.ReadBool();
				break;
			}
		}
	}
}
