using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GsOnline;

public sealed class SessionDataSyncWrapper : IMessage<SessionDataSyncWrapper>, IMessage, IEquatable<SessionDataSyncWrapper>, IDeepCloneable<SessionDataSyncWrapper>
{
	private static readonly MessageParser<SessionDataSyncWrapper> _parser = new MessageParser<SessionDataSyncWrapper>(() => new SessionDataSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private SessionSettingSyncWrapper setting_;

	private Uint64SyncWrapper sessionId_;

	private Uint64SyncWrapper owner_;

	private StringSyncWrapper ownerName_;

	private SessionStateSyncWrapper state_;

	private StringSyncWrapper hostAddr_;

	private StringSyncWrapper hostPort_;

	private static readonly FieldCodec<SessionMemberSyncWrapper> _repeated_members_codec = FieldCodec.ForMessage(82u, SessionMemberSyncWrapper.Parser);

	private readonly RepeatedField<SessionMemberSyncWrapper> members_ = new RepeatedField<SessionMemberSyncWrapper>();

	public static MessageParser<SessionDataSyncWrapper> Parser => _parser;

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

	public SessionSettingSyncWrapper Setting
	{
		get
		{
			return setting_;
		}
		set
		{
			setting_ = value;
		}
	}

	public Uint64SyncWrapper SessionId
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

	public Uint64SyncWrapper Owner
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

	public StringSyncWrapper OwnerName
	{
		get
		{
			return ownerName_;
		}
		set
		{
			ownerName_ = value;
		}
	}

	public SessionStateSyncWrapper State
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

	public StringSyncWrapper HostAddr
	{
		get
		{
			return hostAddr_;
		}
		set
		{
			hostAddr_ = value;
		}
	}

	public StringSyncWrapper HostPort
	{
		get
		{
			return hostPort_;
		}
		set
		{
			hostPort_ = value;
		}
	}

	public RepeatedField<SessionMemberSyncWrapper> Members => members_;

	public SessionDataSyncWrapper()
	{
	}

	public SessionDataSyncWrapper(SessionDataSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		setting_ = ((other.setting_ != null) ? other.setting_.Clone() : null);
		sessionId_ = ((other.sessionId_ != null) ? other.sessionId_.Clone() : null);
		owner_ = ((other.owner_ != null) ? other.owner_.Clone() : null);
		ownerName_ = ((other.ownerName_ != null) ? other.ownerName_.Clone() : null);
		state_ = ((other.state_ != null) ? other.state_.Clone() : null);
		hostAddr_ = ((other.hostAddr_ != null) ? other.hostAddr_.Clone() : null);
		hostPort_ = ((other.hostPort_ != null) ? other.hostPort_.Clone() : null);
		members_ = other.members_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SessionDataSyncWrapper Clone()
	{
		return new SessionDataSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SessionDataSyncWrapper);
	}

	public bool Equals(SessionDataSyncWrapper other)
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
		if (!object.Equals(Setting, other.Setting))
		{
			return false;
		}
		if (!object.Equals(SessionId, other.SessionId))
		{
			return false;
		}
		if (!object.Equals(Owner, other.Owner))
		{
			return false;
		}
		if (!object.Equals(OwnerName, other.OwnerName))
		{
			return false;
		}
		if (!object.Equals(State, other.State))
		{
			return false;
		}
		if (!object.Equals(HostAddr, other.HostAddr))
		{
			return false;
		}
		if (!object.Equals(HostPort, other.HostPort))
		{
			return false;
		}
		if (!members_.Equals(other.members_))
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
		if (setting_ != null)
		{
			num ^= Setting.GetHashCode();
		}
		if (sessionId_ != null)
		{
			num ^= SessionId.GetHashCode();
		}
		if (owner_ != null)
		{
			num ^= Owner.GetHashCode();
		}
		if (ownerName_ != null)
		{
			num ^= OwnerName.GetHashCode();
		}
		if (state_ != null)
		{
			num ^= State.GetHashCode();
		}
		if (hostAddr_ != null)
		{
			num ^= HostAddr.GetHashCode();
		}
		if (hostPort_ != null)
		{
			num ^= HostPort.GetHashCode();
		}
		num ^= members_.GetHashCode();
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
		if (setting_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Setting);
		}
		if (sessionId_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(SessionId);
		}
		if (owner_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(Owner);
		}
		if (ownerName_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(OwnerName);
		}
		if (state_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(State);
		}
		if (hostAddr_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(HostAddr);
		}
		if (hostPort_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(HostPort);
		}
		members_.WriteTo(output, _repeated_members_codec);
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
		if (setting_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Setting);
		}
		if (sessionId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SessionId);
		}
		if (owner_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Owner);
		}
		if (ownerName_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OwnerName);
		}
		if (state_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(State);
		}
		if (hostAddr_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HostAddr);
		}
		if (hostPort_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HostPort);
		}
		num += members_.CalculateSize(_repeated_members_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SessionDataSyncWrapper other)
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
		if (other.setting_ != null)
		{
			if (setting_ == null)
			{
				Setting = new SessionSettingSyncWrapper();
			}
			Setting.MergeFrom(other.Setting);
		}
		if (other.sessionId_ != null)
		{
			if (sessionId_ == null)
			{
				SessionId = new Uint64SyncWrapper();
			}
			SessionId.MergeFrom(other.SessionId);
		}
		if (other.owner_ != null)
		{
			if (owner_ == null)
			{
				Owner = new Uint64SyncWrapper();
			}
			Owner.MergeFrom(other.Owner);
		}
		if (other.ownerName_ != null)
		{
			if (ownerName_ == null)
			{
				OwnerName = new StringSyncWrapper();
			}
			OwnerName.MergeFrom(other.OwnerName);
		}
		if (other.state_ != null)
		{
			if (state_ == null)
			{
				State = new SessionStateSyncWrapper();
			}
			State.MergeFrom(other.State);
		}
		if (other.hostAddr_ != null)
		{
			if (hostAddr_ == null)
			{
				HostAddr = new StringSyncWrapper();
			}
			HostAddr.MergeFrom(other.HostAddr);
		}
		if (other.hostPort_ != null)
		{
			if (hostPort_ == null)
			{
				HostPort = new StringSyncWrapper();
			}
			HostPort.MergeFrom(other.HostPort);
		}
		members_.Add(other.members_);
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
				if (setting_ == null)
				{
					Setting = new SessionSettingSyncWrapper();
				}
				input.ReadMessage(Setting);
				break;
			case 34u:
				if (sessionId_ == null)
				{
					SessionId = new Uint64SyncWrapper();
				}
				input.ReadMessage(SessionId);
				break;
			case 42u:
				if (owner_ == null)
				{
					Owner = new Uint64SyncWrapper();
				}
				input.ReadMessage(Owner);
				break;
			case 50u:
				if (ownerName_ == null)
				{
					OwnerName = new StringSyncWrapper();
				}
				input.ReadMessage(OwnerName);
				break;
			case 58u:
				if (state_ == null)
				{
					State = new SessionStateSyncWrapper();
				}
				input.ReadMessage(State);
				break;
			case 66u:
				if (hostAddr_ == null)
				{
					HostAddr = new StringSyncWrapper();
				}
				input.ReadMessage(HostAddr);
				break;
			case 74u:
				if (hostPort_ == null)
				{
					HostPort = new StringSyncWrapper();
				}
				input.ReadMessage(HostPort);
				break;
			case 82u:
				members_.AddEntriesFrom(input, _repeated_members_codec);
				break;
			}
		}
	}
}
