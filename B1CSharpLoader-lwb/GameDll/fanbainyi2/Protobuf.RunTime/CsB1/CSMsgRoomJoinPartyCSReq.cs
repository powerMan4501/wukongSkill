using System;
using CommB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoomJoinPartyCSReq : IMessage<CSMsgRoomJoinPartyCSReq>, IMessage, IEquatable<CSMsgRoomJoinPartyCSReq>, IDeepCloneable<CSMsgRoomJoinPartyCSReq>
{
	private static readonly MessageParser<CSMsgRoomJoinPartyCSReq> _parser = new MessageParser<CSMsgRoomJoinPartyCSReq>(() => new CSMsgRoomJoinPartyCSReq());

	private UnknownFieldSet _unknownFields;

	private ulong partyId_;

	private string partyIdStr_ = "";

	private string memberPlatformId_ = "";

	private string passwd_ = "";

	private PartyMemberType joinType_;

	private MemberRoleData roleData_;

	public static MessageParser<CSMsgRoomJoinPartyCSReq> Parser => _parser;

	public ulong PartyId
	{
		get
		{
			return partyId_;
		}
		set
		{
			partyId_ = value;
		}
	}

	public string PartyIdStr
	{
		get
		{
			return partyIdStr_;
		}
		set
		{
			partyIdStr_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string MemberPlatformId
	{
		get
		{
			return memberPlatformId_;
		}
		set
		{
			memberPlatformId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Passwd
	{
		get
		{
			return passwd_;
		}
		set
		{
			passwd_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public PartyMemberType JoinType
	{
		get
		{
			return joinType_;
		}
		set
		{
			joinType_ = value;
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

	public CSMsgRoomJoinPartyCSReq()
	{
	}

	public CSMsgRoomJoinPartyCSReq(CSMsgRoomJoinPartyCSReq other)
		: this()
	{
		partyId_ = other.partyId_;
		partyIdStr_ = other.partyIdStr_;
		memberPlatformId_ = other.memberPlatformId_;
		passwd_ = other.passwd_;
		joinType_ = other.joinType_;
		roleData_ = ((other.roleData_ != null) ? other.roleData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoomJoinPartyCSReq Clone()
	{
		return new CSMsgRoomJoinPartyCSReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoomJoinPartyCSReq);
	}

	public bool Equals(CSMsgRoomJoinPartyCSReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PartyId != other.PartyId)
		{
			return false;
		}
		if (PartyIdStr != other.PartyIdStr)
		{
			return false;
		}
		if (MemberPlatformId != other.MemberPlatformId)
		{
			return false;
		}
		if (Passwd != other.Passwd)
		{
			return false;
		}
		if (JoinType != other.JoinType)
		{
			return false;
		}
		if (!object.Equals(RoleData, other.RoleData))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (PartyId != 0L)
		{
			num ^= PartyId.GetHashCode();
		}
		if (PartyIdStr.Length != 0)
		{
			num ^= PartyIdStr.GetHashCode();
		}
		if (MemberPlatformId.Length != 0)
		{
			num ^= MemberPlatformId.GetHashCode();
		}
		if (Passwd.Length != 0)
		{
			num ^= Passwd.GetHashCode();
		}
		if (JoinType != PartyMemberType.Teammate)
		{
			num ^= JoinType.GetHashCode();
		}
		if (roleData_ != null)
		{
			num ^= RoleData.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (PartyId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(PartyId);
		}
		if (PartyIdStr.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(PartyIdStr);
		}
		if (MemberPlatformId.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(MemberPlatformId);
		}
		if (Passwd.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Passwd);
		}
		if (JoinType != PartyMemberType.Teammate)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)JoinType);
		}
		if (roleData_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(RoleData);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (PartyId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(PartyId);
		}
		if (PartyIdStr.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PartyIdStr);
		}
		if (MemberPlatformId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MemberPlatformId);
		}
		if (Passwd.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Passwd);
		}
		if (JoinType != PartyMemberType.Teammate)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)JoinType);
		}
		if (roleData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RoleData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgRoomJoinPartyCSReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PartyId != 0L)
		{
			PartyId = other.PartyId;
		}
		if (other.PartyIdStr.Length != 0)
		{
			PartyIdStr = other.PartyIdStr;
		}
		if (other.MemberPlatformId.Length != 0)
		{
			MemberPlatformId = other.MemberPlatformId;
		}
		if (other.Passwd.Length != 0)
		{
			Passwd = other.Passwd;
		}
		if (other.JoinType != PartyMemberType.Teammate)
		{
			JoinType = other.JoinType;
		}
		if (other.roleData_ != null)
		{
			if (roleData_ == null)
			{
				RoleData = new MemberRoleData();
			}
			RoleData.MergeFrom(other.RoleData);
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
				PartyId = input.ReadUInt64();
				break;
			case 18u:
				PartyIdStr = input.ReadString();
				break;
			case 26u:
				MemberPlatformId = input.ReadString();
				break;
			case 34u:
				Passwd = input.ReadString();
				break;
			case 40u:
				JoinType = (PartyMemberType)input.ReadEnum();
				break;
			case 50u:
				if (roleData_ == null)
				{
					RoleData = new MemberRoleData();
				}
				input.ReadMessage(RoleData);
				break;
			}
		}
	}
}
