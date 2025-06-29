using System;
using Google.Protobuf;
using ResB1;

namespace CommB1;

public sealed class PartyMemberSyncWrapper : IMessage<PartyMemberSyncWrapper>, IMessage, IEquatable<PartyMemberSyncWrapper>, IDeepCloneable<PartyMemberSyncWrapper>
{
	private static readonly MessageParser<PartyMemberSyncWrapper> _parser = new MessageParser<PartyMemberSyncWrapper>(() => new PartyMemberSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Uint64SyncWrapper memberId_;

	private PartyMemberTypeSyncWrapper type_;

	private StringSyncWrapper accountId_;

	private Uint64SyncWrapper svrId_;

	private PartyMemberStateSyncWrapper state_;

	private MemberRoleDataSyncWrapper roleData_;

	private Uint32SyncWrapper lastActivityTime_;

	public static MessageParser<PartyMemberSyncWrapper> Parser => _parser;

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

	public PartyMemberTypeSyncWrapper Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	public StringSyncWrapper AccountId
	{
		get
		{
			return accountId_;
		}
		set
		{
			accountId_ = value;
		}
	}

	public Uint64SyncWrapper SvrId
	{
		get
		{
			return svrId_;
		}
		set
		{
			svrId_ = value;
		}
	}

	public PartyMemberStateSyncWrapper State
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

	public MemberRoleDataSyncWrapper RoleData
	{
		get
		{
			return roleData_;
		}
		set
		{
			roleData_ = value;
		}
	}

	public Uint32SyncWrapper LastActivityTime
	{
		get
		{
			return lastActivityTime_;
		}
		set
		{
			lastActivityTime_ = value;
		}
	}

	public PartyMemberSyncWrapper()
	{
	}

	public PartyMemberSyncWrapper(PartyMemberSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		memberId_ = ((other.memberId_ != null) ? other.memberId_.Clone() : null);
		type_ = ((other.type_ != null) ? other.type_.Clone() : null);
		accountId_ = ((other.accountId_ != null) ? other.accountId_.Clone() : null);
		svrId_ = ((other.svrId_ != null) ? other.svrId_.Clone() : null);
		state_ = ((other.state_ != null) ? other.state_.Clone() : null);
		roleData_ = ((other.roleData_ != null) ? other.roleData_.Clone() : null);
		lastActivityTime_ = ((other.lastActivityTime_ != null) ? other.lastActivityTime_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartyMemberSyncWrapper Clone()
	{
		return new PartyMemberSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartyMemberSyncWrapper);
	}

	public bool Equals(PartyMemberSyncWrapper other)
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
		if (!object.Equals(Type, other.Type))
		{
			return false;
		}
		if (!object.Equals(AccountId, other.AccountId))
		{
			return false;
		}
		if (!object.Equals(SvrId, other.SvrId))
		{
			return false;
		}
		if (!object.Equals(State, other.State))
		{
			return false;
		}
		if (!object.Equals(RoleData, other.RoleData))
		{
			return false;
		}
		if (!object.Equals(LastActivityTime, other.LastActivityTime))
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
		if (type_ != null)
		{
			num ^= Type.GetHashCode();
		}
		if (accountId_ != null)
		{
			num ^= AccountId.GetHashCode();
		}
		if (svrId_ != null)
		{
			num ^= SvrId.GetHashCode();
		}
		if (state_ != null)
		{
			num ^= State.GetHashCode();
		}
		if (roleData_ != null)
		{
			num ^= RoleData.GetHashCode();
		}
		if (lastActivityTime_ != null)
		{
			num ^= LastActivityTime.GetHashCode();
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
		if (type_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Type);
		}
		if (accountId_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(AccountId);
		}
		if (svrId_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(SvrId);
		}
		if (state_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(State);
		}
		if (roleData_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(RoleData);
		}
		if (lastActivityTime_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(LastActivityTime);
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
		if (type_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Type);
		}
		if (accountId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AccountId);
		}
		if (svrId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SvrId);
		}
		if (state_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(State);
		}
		if (roleData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RoleData);
		}
		if (lastActivityTime_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LastActivityTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PartyMemberSyncWrapper other)
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
		if (other.type_ != null)
		{
			if (type_ == null)
			{
				Type = new PartyMemberTypeSyncWrapper();
			}
			Type.MergeFrom(other.Type);
		}
		if (other.accountId_ != null)
		{
			if (accountId_ == null)
			{
				AccountId = new StringSyncWrapper();
			}
			AccountId.MergeFrom(other.AccountId);
		}
		if (other.svrId_ != null)
		{
			if (svrId_ == null)
			{
				SvrId = new Uint64SyncWrapper();
			}
			SvrId.MergeFrom(other.SvrId);
		}
		if (other.state_ != null)
		{
			if (state_ == null)
			{
				State = new PartyMemberStateSyncWrapper();
			}
			State.MergeFrom(other.State);
		}
		if (other.roleData_ != null)
		{
			if (roleData_ == null)
			{
				RoleData = new MemberRoleDataSyncWrapper();
			}
			RoleData.MergeFrom(other.RoleData);
		}
		if (other.lastActivityTime_ != null)
		{
			if (lastActivityTime_ == null)
			{
				LastActivityTime = new Uint32SyncWrapper();
			}
			LastActivityTime.MergeFrom(other.LastActivityTime);
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
				if (type_ == null)
				{
					Type = new PartyMemberTypeSyncWrapper();
				}
				input.ReadMessage(Type);
				break;
			case 42u:
				if (accountId_ == null)
				{
					AccountId = new StringSyncWrapper();
				}
				input.ReadMessage(AccountId);
				break;
			case 50u:
				if (svrId_ == null)
				{
					SvrId = new Uint64SyncWrapper();
				}
				input.ReadMessage(SvrId);
				break;
			case 58u:
				if (state_ == null)
				{
					State = new PartyMemberStateSyncWrapper();
				}
				input.ReadMessage(State);
				break;
			case 66u:
				if (roleData_ == null)
				{
					RoleData = new MemberRoleDataSyncWrapper();
				}
				input.ReadMessage(RoleData);
				break;
			case 74u:
				if (lastActivityTime_ == null)
				{
					LastActivityTime = new Uint32SyncWrapper();
				}
				input.ReadMessage(LastActivityTime);
				break;
			}
		}
	}
}
