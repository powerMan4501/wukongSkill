using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GsOnline;

public sealed class SessionSettingSyncWrapper : IMessage<SessionSettingSyncWrapper>, IMessage, IEquatable<SessionSettingSyncWrapper>, IDeepCloneable<SessionSettingSyncWrapper>
{
	private static readonly MessageParser<SessionSettingSyncWrapper> _parser = new MessageParser<SessionSettingSyncWrapper>(() => new SessionSettingSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private StringSyncWrapper sessionName_;

	private StringSyncWrapper mapName_;

	private StringSyncWrapper mapNickName_;

	private Uint32SyncWrapper maxMemberNum_;

	private SessionAdvertiseTypeSyncWrapper advertiseType_;

	private BattleHostTypeSyncWrapper hostType_;

	private static readonly FieldCodec<SessionCustomSettingSyncWrapper> _repeated_customSettings_codec = FieldCodec.ForMessage(74u, SessionCustomSettingSyncWrapper.Parser);

	private readonly RepeatedField<SessionCustomSettingSyncWrapper> customSettings_ = new RepeatedField<SessionCustomSettingSyncWrapper>();

	private StringSyncWrapper password_;

	public static MessageParser<SessionSettingSyncWrapper> Parser => _parser;

	public int SyncFlag
	{
		get
		{
			return syncFlag_;
		}
		set
		{
			syncFlag_ = value;
		}
	}

	public int SyncIdx
	{
		get
		{
			return syncIdx_;
		}
		set
		{
			syncIdx_ = value;
		}
	}

	public StringSyncWrapper SessionName
	{
		get
		{
			return sessionName_;
		}
		set
		{
			sessionName_ = value;
		}
	}

	public StringSyncWrapper MapName
	{
		get
		{
			return mapName_;
		}
		set
		{
			mapName_ = value;
		}
	}

	public StringSyncWrapper MapNickName
	{
		get
		{
			return mapNickName_;
		}
		set
		{
			mapNickName_ = value;
		}
	}

	public Uint32SyncWrapper MaxMemberNum
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

	public SessionAdvertiseTypeSyncWrapper AdvertiseType
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

	public BattleHostTypeSyncWrapper HostType
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

	public RepeatedField<SessionCustomSettingSyncWrapper> CustomSettings => customSettings_;

	public StringSyncWrapper Password
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

	public SessionSettingSyncWrapper()
	{
	}

	public SessionSettingSyncWrapper(SessionSettingSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		sessionName_ = ((other.sessionName_ != null) ? other.sessionName_.Clone() : null);
		mapName_ = ((other.mapName_ != null) ? other.mapName_.Clone() : null);
		mapNickName_ = ((other.mapNickName_ != null) ? other.mapNickName_.Clone() : null);
		maxMemberNum_ = ((other.maxMemberNum_ != null) ? other.maxMemberNum_.Clone() : null);
		advertiseType_ = ((other.advertiseType_ != null) ? other.advertiseType_.Clone() : null);
		hostType_ = ((other.hostType_ != null) ? other.hostType_.Clone() : null);
		customSettings_ = other.customSettings_.Clone();
		password_ = ((other.password_ != null) ? other.password_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SessionSettingSyncWrapper Clone()
	{
		return new SessionSettingSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SessionSettingSyncWrapper);
	}

	public bool Equals(SessionSettingSyncWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SyncFlag != other.SyncFlag)
		{
			return false;
		}
		if (SyncIdx != other.SyncIdx)
		{
			return false;
		}
		if (!object.Equals(SessionName, other.SessionName))
		{
			return false;
		}
		if (!object.Equals(MapName, other.MapName))
		{
			return false;
		}
		if (!object.Equals(MapNickName, other.MapNickName))
		{
			return false;
		}
		if (!object.Equals(MaxMemberNum, other.MaxMemberNum))
		{
			return false;
		}
		if (!object.Equals(AdvertiseType, other.AdvertiseType))
		{
			return false;
		}
		if (!object.Equals(HostType, other.HostType))
		{
			return false;
		}
		if (!customSettings_.Equals(other.customSettings_))
		{
			return false;
		}
		if (!object.Equals(Password, other.Password))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SyncFlag != 0)
		{
			num ^= SyncFlag.GetHashCode();
		}
		if (SyncIdx != 0)
		{
			num ^= SyncIdx.GetHashCode();
		}
		if (sessionName_ != null)
		{
			num ^= SessionName.GetHashCode();
		}
		if (mapName_ != null)
		{
			num ^= MapName.GetHashCode();
		}
		if (mapNickName_ != null)
		{
			num ^= MapNickName.GetHashCode();
		}
		if (maxMemberNum_ != null)
		{
			num ^= MaxMemberNum.GetHashCode();
		}
		if (advertiseType_ != null)
		{
			num ^= AdvertiseType.GetHashCode();
		}
		if (hostType_ != null)
		{
			num ^= HostType.GetHashCode();
		}
		num ^= customSettings_.GetHashCode();
		if (password_ != null)
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
		if (SyncFlag != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SyncIdx);
		}
		if (sessionName_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(SessionName);
		}
		if (mapName_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(MapName);
		}
		if (mapNickName_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(MapNickName);
		}
		if (maxMemberNum_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(MaxMemberNum);
		}
		if (advertiseType_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(AdvertiseType);
		}
		if (hostType_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(HostType);
		}
		customSettings_.WriteTo(output, _repeated_customSettings_codec);
		if (password_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(Password);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SyncFlag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncIdx);
		}
		if (sessionName_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SessionName);
		}
		if (mapName_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MapName);
		}
		if (mapNickName_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MapNickName);
		}
		if (maxMemberNum_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MaxMemberNum);
		}
		if (advertiseType_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AdvertiseType);
		}
		if (hostType_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HostType);
		}
		num += customSettings_.CalculateSize(_repeated_customSettings_codec);
		if (password_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Password);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SessionSettingSyncWrapper other)
	{
		if (other == null)
		{
			return;
		}
		if (other.SyncFlag != 0)
		{
			SyncFlag = other.SyncFlag;
		}
		if (other.SyncIdx != 0)
		{
			SyncIdx = other.SyncIdx;
		}
		if (other.sessionName_ != null)
		{
			if (sessionName_ == null)
			{
				SessionName = new StringSyncWrapper();
			}
			SessionName.MergeFrom(other.SessionName);
		}
		if (other.mapName_ != null)
		{
			if (mapName_ == null)
			{
				MapName = new StringSyncWrapper();
			}
			MapName.MergeFrom(other.MapName);
		}
		if (other.mapNickName_ != null)
		{
			if (mapNickName_ == null)
			{
				MapNickName = new StringSyncWrapper();
			}
			MapNickName.MergeFrom(other.MapNickName);
		}
		if (other.maxMemberNum_ != null)
		{
			if (maxMemberNum_ == null)
			{
				MaxMemberNum = new Uint32SyncWrapper();
			}
			MaxMemberNum.MergeFrom(other.MaxMemberNum);
		}
		if (other.advertiseType_ != null)
		{
			if (advertiseType_ == null)
			{
				AdvertiseType = new SessionAdvertiseTypeSyncWrapper();
			}
			AdvertiseType.MergeFrom(other.AdvertiseType);
		}
		if (other.hostType_ != null)
		{
			if (hostType_ == null)
			{
				HostType = new BattleHostTypeSyncWrapper();
			}
			HostType.MergeFrom(other.HostType);
		}
		customSettings_.Add(other.customSettings_);
		if (other.password_ != null)
		{
			if (password_ == null)
			{
				Password = new StringSyncWrapper();
			}
			Password.MergeFrom(other.Password);
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
			case 8u:
				SyncFlag = input.ReadInt32();
				break;
			case 16u:
				SyncIdx = input.ReadInt32();
				break;
			case 26u:
				if (sessionName_ == null)
				{
					SessionName = new StringSyncWrapper();
				}
				input.ReadMessage(SessionName);
				break;
			case 34u:
				if (mapName_ == null)
				{
					MapName = new StringSyncWrapper();
				}
				input.ReadMessage(MapName);
				break;
			case 42u:
				if (mapNickName_ == null)
				{
					MapNickName = new StringSyncWrapper();
				}
				input.ReadMessage(MapNickName);
				break;
			case 50u:
				if (maxMemberNum_ == null)
				{
					MaxMemberNum = new Uint32SyncWrapper();
				}
				input.ReadMessage(MaxMemberNum);
				break;
			case 58u:
				if (advertiseType_ == null)
				{
					AdvertiseType = new SessionAdvertiseTypeSyncWrapper();
				}
				input.ReadMessage(AdvertiseType);
				break;
			case 66u:
				if (hostType_ == null)
				{
					HostType = new BattleHostTypeSyncWrapper();
				}
				input.ReadMessage(HostType);
				break;
			case 74u:
				customSettings_.AddEntriesFrom(input, _repeated_customSettings_codec);
				break;
			case 82u:
				if (password_ == null)
				{
					Password = new StringSyncWrapper();
				}
				input.ReadMessage(Password);
				break;
			}
		}
	}
}
