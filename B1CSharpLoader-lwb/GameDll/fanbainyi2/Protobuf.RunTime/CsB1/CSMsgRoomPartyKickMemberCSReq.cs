using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoomPartyKickMemberCSReq : IMessage<CSMsgRoomPartyKickMemberCSReq>, IMessage, IEquatable<CSMsgRoomPartyKickMemberCSReq>, IDeepCloneable<CSMsgRoomPartyKickMemberCSReq>
{
	private static readonly MessageParser<CSMsgRoomPartyKickMemberCSReq> _parser = new MessageParser<CSMsgRoomPartyKickMemberCSReq>(() => new CSMsgRoomPartyKickMemberCSReq());

	private UnknownFieldSet _unknownFields;

	private ulong partyId_;

	private ulong targetRoleId_;

	public static MessageParser<CSMsgRoomPartyKickMemberCSReq> Parser => _parser;

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

	public ulong TargetRoleId
	{
		get
		{
			return targetRoleId_;
		}
		set
		{
			targetRoleId_ = value;
		}
	}

	public CSMsgRoomPartyKickMemberCSReq()
	{
	}

	public CSMsgRoomPartyKickMemberCSReq(CSMsgRoomPartyKickMemberCSReq other)
		: this()
	{
		partyId_ = other.partyId_;
		targetRoleId_ = other.targetRoleId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoomPartyKickMemberCSReq Clone()
	{
		return new CSMsgRoomPartyKickMemberCSReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoomPartyKickMemberCSReq);
	}

	public bool Equals(CSMsgRoomPartyKickMemberCSReq other)
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
		if (TargetRoleId != other.TargetRoleId)
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
		if (TargetRoleId != 0L)
		{
			num ^= TargetRoleId.GetHashCode();
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
		if (TargetRoleId != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(TargetRoleId);
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
		if (TargetRoleId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(TargetRoleId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgRoomPartyKickMemberCSReq other)
	{
		if (other != null)
		{
			if (other.PartyId != 0L)
			{
				PartyId = other.PartyId;
			}
			if (other.TargetRoleId != 0L)
			{
				TargetRoleId = other.TargetRoleId;
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
				PartyId = input.ReadUInt64();
				break;
			case 16u:
				TargetRoleId = input.ReadUInt64();
				break;
			}
		}
	}
}
