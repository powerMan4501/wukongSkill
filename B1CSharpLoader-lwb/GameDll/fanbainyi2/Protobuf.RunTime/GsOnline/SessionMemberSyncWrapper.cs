using System;
using Google.Protobuf;

namespace GsOnline;

public sealed class SessionMemberSyncWrapper : IMessage<SessionMemberSyncWrapper>, IMessage, IEquatable<SessionMemberSyncWrapper>, IDeepCloneable<SessionMemberSyncWrapper>
{
	private static readonly MessageParser<SessionMemberSyncWrapper> _parser = new MessageParser<SessionMemberSyncWrapper>(() => new SessionMemberSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Uint64SyncWrapper memberId_;

	private StringSyncWrapper memberName_;

	private MemberStateSyncWrapper state_;

	public static MessageParser<SessionMemberSyncWrapper> Parser => _parser;

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

	public Uint64SyncWrapper MemberId
	{
		get
		{
			return memberId_;
		}
		set
		{
			memberId_ = value;
		}
	}

	public StringSyncWrapper MemberName
	{
		get
		{
			return memberName_;
		}
		set
		{
			memberName_ = value;
		}
	}

	public MemberStateSyncWrapper State
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

	public SessionMemberSyncWrapper()
	{
	}

	public SessionMemberSyncWrapper(SessionMemberSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		memberId_ = ((other.memberId_ != null) ? other.memberId_.Clone() : null);
		memberName_ = ((other.memberName_ != null) ? other.memberName_.Clone() : null);
		state_ = ((other.state_ != null) ? other.state_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SessionMemberSyncWrapper Clone()
	{
		return new SessionMemberSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SessionMemberSyncWrapper);
	}

	public bool Equals(SessionMemberSyncWrapper other)
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
		if (!object.Equals(MemberId, other.MemberId))
		{
			return false;
		}
		if (!object.Equals(MemberName, other.MemberName))
		{
			return false;
		}
		if (!object.Equals(State, other.State))
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
		if (memberId_ != null)
		{
			num ^= MemberId.GetHashCode();
		}
		if (memberName_ != null)
		{
			num ^= MemberName.GetHashCode();
		}
		if (state_ != null)
		{
			num ^= State.GetHashCode();
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
		if (memberId_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(MemberId);
		}
		if (memberName_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(MemberName);
		}
		if (state_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(State);
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
		if (memberId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MemberId);
		}
		if (memberName_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MemberName);
		}
		if (state_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(State);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SessionMemberSyncWrapper other)
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
		if (other.memberId_ != null)
		{
			if (memberId_ == null)
			{
				MemberId = new Uint64SyncWrapper();
			}
			MemberId.MergeFrom(other.MemberId);
		}
		if (other.memberName_ != null)
		{
			if (memberName_ == null)
			{
				MemberName = new StringSyncWrapper();
			}
			MemberName.MergeFrom(other.MemberName);
		}
		if (other.state_ != null)
		{
			if (state_ == null)
			{
				State = new MemberStateSyncWrapper();
			}
			State.MergeFrom(other.State);
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
				if (memberId_ == null)
				{
					MemberId = new Uint64SyncWrapper();
				}
				input.ReadMessage(MemberId);
				break;
			case 34u:
				if (memberName_ == null)
				{
					MemberName = new StringSyncWrapper();
				}
				input.ReadMessage(MemberName);
				break;
			case 42u:
				if (state_ == null)
				{
					State = new MemberStateSyncWrapper();
				}
				input.ReadMessage(State);
				break;
			}
		}
	}
}
