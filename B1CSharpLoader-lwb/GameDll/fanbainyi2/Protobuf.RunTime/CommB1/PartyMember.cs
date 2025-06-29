using System;
using Google.Protobuf;

namespace CommB1;

public sealed class PartyMember : IMessage<PartyMember>, IMessage, IEquatable<PartyMember>, IDeepCloneable<PartyMember>
{
	private static readonly MessageParser<PartyMember> _parser = new MessageParser<PartyMember>(() => new PartyMember());

	private UnknownFieldSet _unknownFields;

	private ulong memberId_;

	private PartyMemberType type_;

	private string accountId_ = "";

	private ulong svrId_;

	private PartyMemberState state_;

	private MemberRoleData roleData_;

	private uint lastActivityTime_;

	public static MessageParser<PartyMember> Parser => _parser;

	public ulong MemberId
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

	public PartyMemberType Type
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

	public string AccountId
	{
		get
		{
			return accountId_;
		}
		set
		{
			accountId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ulong SvrId
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

	public PartyMemberState State
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

	public MemberRoleData RoleData
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

	public uint LastActivityTime
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

	public PartyMember()
	{
	}

	public PartyMember(PartyMember other)
		: this()
	{
		memberId_ = other.memberId_;
		type_ = other.type_;
		accountId_ = other.accountId_;
		svrId_ = other.svrId_;
		state_ = other.state_;
		roleData_ = ((other.roleData_ != null) ? other.roleData_.Clone() : null);
		lastActivityTime_ = other.lastActivityTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartyMember Clone()
	{
		return new PartyMember(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartyMember);
	}

	public bool Equals(PartyMember other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MemberId != other.MemberId)
		{
			return false;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (AccountId != other.AccountId)
		{
			return false;
		}
		if (SvrId != other.SvrId)
		{
			return false;
		}
		if (State != other.State)
		{
			return false;
		}
		if (!object.Equals(RoleData, other.RoleData))
		{
			return false;
		}
		if (LastActivityTime != other.LastActivityTime)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (MemberId != 0L)
		{
			num ^= MemberId.GetHashCode();
		}
		if (Type != PartyMemberType.Teammate)
		{
			num ^= Type.GetHashCode();
		}
		if (AccountId.Length != 0)
		{
			num ^= AccountId.GetHashCode();
		}
		if (SvrId != 0L)
		{
			num ^= SvrId.GetHashCode();
		}
		if (State != PartyMemberState.Online)
		{
			num ^= State.GetHashCode();
		}
		if (roleData_ != null)
		{
			num ^= RoleData.GetHashCode();
		}
		if (LastActivityTime != 0)
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
		if (MemberId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(MemberId);
		}
		if (Type != PartyMemberType.Teammate)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Type);
		}
		if (AccountId.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(AccountId);
		}
		if (SvrId != 0L)
		{
			output.WriteRawTag(32);
			output.WriteUInt64(SvrId);
		}
		if (State != PartyMemberState.Online)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)State);
		}
		if (roleData_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(RoleData);
		}
		if (LastActivityTime != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(LastActivityTime);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (MemberId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(MemberId);
		}
		if (Type != PartyMemberType.Teammate)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (AccountId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AccountId);
		}
		if (SvrId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(SvrId);
		}
		if (State != PartyMemberState.Online)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)State);
		}
		if (roleData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RoleData);
		}
		if (LastActivityTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LastActivityTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PartyMember other)
	{
		if (other == null)
		{
			return;
		}
		if (other.MemberId != 0L)
		{
			MemberId = other.MemberId;
		}
		if (other.Type != PartyMemberType.Teammate)
		{
			Type = other.Type;
		}
		if (other.AccountId.Length != 0)
		{
			AccountId = other.AccountId;
		}
		if (other.SvrId != 0L)
		{
			SvrId = other.SvrId;
		}
		if (other.State != PartyMemberState.Online)
		{
			State = other.State;
		}
		if (other.roleData_ != null)
		{
			if (roleData_ == null)
			{
				RoleData = new MemberRoleData();
			}
			RoleData.MergeFrom(other.RoleData);
		}
		if (other.LastActivityTime != 0)
		{
			LastActivityTime = other.LastActivityTime;
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
				MemberId = input.ReadUInt64();
				break;
			case 16u:
				Type = (PartyMemberType)input.ReadEnum();
				break;
			case 26u:
				AccountId = input.ReadString();
				break;
			case 32u:
				SvrId = input.ReadUInt64();
				break;
			case 40u:
				State = (PartyMemberState)input.ReadEnum();
				break;
			case 50u:
				if (roleData_ == null)
				{
					RoleData = new MemberRoleData();
				}
				input.ReadMessage(RoleData);
				break;
			case 56u:
				LastActivityTime = input.ReadUInt32();
				break;
			}
		}
	}
}
