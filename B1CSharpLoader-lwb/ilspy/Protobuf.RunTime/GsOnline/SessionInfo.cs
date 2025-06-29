using System;
using Google.Protobuf;

namespace GsOnline;

public sealed class SessionInfo : IMessage<SessionInfo>, IMessage, IEquatable<SessionInfo>, IDeepCloneable<SessionInfo>
{
	private static readonly MessageParser<SessionInfo> _parser = new MessageParser<SessionInfo>(() => new SessionInfo());

	private UnknownFieldSet _unknownFields;

	private ulong sessionId_;

	private string sessionName_ = "";

	private ulong owner_;

	private string ownerName_ = "";

	private string mapName_ = "";

	private string mapNickName_ = "";

	private uint maxMemberNum_;

	private uint curMemberNum_;

	private SessionAdvertiseType advertiseType_;

	private SessionState state_;

	private bool password_;

	public static MessageParser<SessionInfo> Parser => _parser;

	public ulong SessionId
	{
		get
		{
			return sessionId_;
		}
		set
		{
			sessionId_ = value;
		}
	}

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

	public SessionState State
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

	public SessionInfo()
	{
	}

	public SessionInfo(SessionInfo other)
		: this()
	{
		sessionId_ = other.sessionId_;
		sessionName_ = other.sessionName_;
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

	public SessionInfo Clone()
	{
		return new SessionInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SessionInfo);
	}

	public bool Equals(SessionInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SessionId != other.SessionId)
		{
			return false;
		}
		if (SessionName != other.SessionName)
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
		if (SessionId != 0L)
		{
			num ^= SessionId.GetHashCode();
		}
		if (SessionName.Length != 0)
		{
			num ^= SessionName.GetHashCode();
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
		if (AdvertiseType != SessionAdvertiseType.Private)
		{
			num ^= AdvertiseType.GetHashCode();
		}
		if (State != SessionState.None)
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
		if (SessionId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(SessionId);
		}
		if (SessionName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(SessionName);
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
		if (AdvertiseType != SessionAdvertiseType.Private)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)AdvertiseType);
		}
		if (State != SessionState.None)
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
		if (SessionId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(SessionId);
		}
		if (SessionName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SessionName);
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
		if (AdvertiseType != SessionAdvertiseType.Private)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AdvertiseType);
		}
		if (State != SessionState.None)
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

	public void MergeFrom(SessionInfo other)
	{
		if (other != null)
		{
			if (other.SessionId != 0L)
			{
				SessionId = other.SessionId;
			}
			if (other.SessionName.Length != 0)
			{
				SessionName = other.SessionName;
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
			if (other.AdvertiseType != SessionAdvertiseType.Private)
			{
				AdvertiseType = other.AdvertiseType;
			}
			if (other.State != SessionState.None)
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
				SessionId = input.ReadUInt64();
				break;
			case 18u:
				SessionName = input.ReadString();
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
				AdvertiseType = (SessionAdvertiseType)input.ReadEnum();
				break;
			case 80u:
				State = (SessionState)input.ReadEnum();
				break;
			case 88u:
				Password = input.ReadBool();
				break;
			}
		}
	}
}
