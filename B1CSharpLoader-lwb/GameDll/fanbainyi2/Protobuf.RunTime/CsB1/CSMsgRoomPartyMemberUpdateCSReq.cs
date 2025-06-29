using System;
using CommB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoomPartyMemberUpdateCSReq : IMessage<CSMsgRoomPartyMemberUpdateCSReq>, IMessage, IEquatable<CSMsgRoomPartyMemberUpdateCSReq>, IDeepCloneable<CSMsgRoomPartyMemberUpdateCSReq>
{
	private static readonly MessageParser<CSMsgRoomPartyMemberUpdateCSReq> _parser = new MessageParser<CSMsgRoomPartyMemberUpdateCSReq>(() => new CSMsgRoomPartyMemberUpdateCSReq());

	private UnknownFieldSet _unknownFields;

	private ulong partyId_;

	private PartyMemberUpdateParam updateParam_;

	public static MessageParser<CSMsgRoomPartyMemberUpdateCSReq> Parser => _parser;

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

	public PartyMemberUpdateParam UpdateParam
	{
		get
		{
			return updateParam_;
		}
		set
		{
			updateParam_ = value;
		}
	}

	public CSMsgRoomPartyMemberUpdateCSReq()
	{
	}

	public CSMsgRoomPartyMemberUpdateCSReq(CSMsgRoomPartyMemberUpdateCSReq other)
		: this()
	{
		partyId_ = other.partyId_;
		updateParam_ = ((other.updateParam_ != null) ? other.updateParam_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoomPartyMemberUpdateCSReq Clone()
	{
		return new CSMsgRoomPartyMemberUpdateCSReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoomPartyMemberUpdateCSReq);
	}

	public bool Equals(CSMsgRoomPartyMemberUpdateCSReq other)
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
		if (!object.Equals(UpdateParam, other.UpdateParam))
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
		if (updateParam_ != null)
		{
			num ^= UpdateParam.GetHashCode();
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
		if (updateParam_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(UpdateParam);
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
		if (updateParam_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(UpdateParam);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgRoomPartyMemberUpdateCSReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PartyId != 0L)
		{
			PartyId = other.PartyId;
		}
		if (other.updateParam_ != null)
		{
			if (updateParam_ == null)
			{
				UpdateParam = new PartyMemberUpdateParam();
			}
			UpdateParam.MergeFrom(other.UpdateParam);
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
				if (updateParam_ == null)
				{
					UpdateParam = new PartyMemberUpdateParam();
				}
				input.ReadMessage(UpdateParam);
				break;
			}
		}
	}
}
