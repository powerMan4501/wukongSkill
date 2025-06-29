using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoomSendPartyBattleMessageCSReq : IMessage<CSMsgRoomSendPartyBattleMessageCSReq>, IMessage, IEquatable<CSMsgRoomSendPartyBattleMessageCSReq>, IDeepCloneable<CSMsgRoomSendPartyBattleMessageCSReq>
{
	private static readonly MessageParser<CSMsgRoomSendPartyBattleMessageCSReq> _parser = new MessageParser<CSMsgRoomSendPartyBattleMessageCSReq>(() => new CSMsgRoomSendPartyBattleMessageCSReq());

	private UnknownFieldSet _unknownFields;

	private ulong partyId_;

	private PartyBattleMessage message_;

	public static MessageParser<CSMsgRoomSendPartyBattleMessageCSReq> Parser => _parser;

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

	public PartyBattleMessage Message
	{
		get
		{
			return message_;
		}
		set
		{
			message_ = value;
		}
	}

	public CSMsgRoomSendPartyBattleMessageCSReq()
	{
	}

	public CSMsgRoomSendPartyBattleMessageCSReq(CSMsgRoomSendPartyBattleMessageCSReq other)
		: this()
	{
		partyId_ = other.partyId_;
		message_ = ((other.message_ != null) ? other.message_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoomSendPartyBattleMessageCSReq Clone()
	{
		return new CSMsgRoomSendPartyBattleMessageCSReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoomSendPartyBattleMessageCSReq);
	}

	public bool Equals(CSMsgRoomSendPartyBattleMessageCSReq other)
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
		if (!object.Equals(Message, other.Message))
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
		if (message_ != null)
		{
			num ^= Message.GetHashCode();
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
		if (message_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Message);
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
		if (message_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Message);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgRoomSendPartyBattleMessageCSReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PartyId != 0L)
		{
			PartyId = other.PartyId;
		}
		if (other.message_ != null)
		{
			if (message_ == null)
			{
				Message = new PartyBattleMessage();
			}
			Message.MergeFrom(other.Message);
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
				if (message_ == null)
				{
					Message = new PartyBattleMessage();
				}
				input.ReadMessage(Message);
				break;
			}
		}
	}
}
