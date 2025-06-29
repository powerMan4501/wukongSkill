using System;
using CommB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoomCreatePartyTaskCSReq : IMessage<CSMsgRoomCreatePartyTaskCSReq>, IMessage, IEquatable<CSMsgRoomCreatePartyTaskCSReq>, IDeepCloneable<CSMsgRoomCreatePartyTaskCSReq>
{
	private static readonly MessageParser<CSMsgRoomCreatePartyTaskCSReq> _parser = new MessageParser<CSMsgRoomCreatePartyTaskCSReq>(() => new CSMsgRoomCreatePartyTaskCSReq());

	private UnknownFieldSet _unknownFields;

	private ulong partyId_;

	private PartyTaskParam param_;

	public static MessageParser<CSMsgRoomCreatePartyTaskCSReq> Parser => _parser;

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

	public PartyTaskParam Param
	{
		get
		{
			return param_;
		}
		set
		{
			param_ = value;
		}
	}

	public CSMsgRoomCreatePartyTaskCSReq()
	{
	}

	public CSMsgRoomCreatePartyTaskCSReq(CSMsgRoomCreatePartyTaskCSReq other)
		: this()
	{
		partyId_ = other.partyId_;
		param_ = ((other.param_ != null) ? other.param_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoomCreatePartyTaskCSReq Clone()
	{
		return new CSMsgRoomCreatePartyTaskCSReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoomCreatePartyTaskCSReq);
	}

	public bool Equals(CSMsgRoomCreatePartyTaskCSReq other)
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
		if (!object.Equals(Param, other.Param))
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
		if (param_ != null)
		{
			num ^= Param.GetHashCode();
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
		if (param_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Param);
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
		if (param_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Param);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgRoomCreatePartyTaskCSReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PartyId != 0L)
		{
			PartyId = other.PartyId;
		}
		if (other.param_ != null)
		{
			if (param_ == null)
			{
				Param = new PartyTaskParam();
			}
			Param.MergeFrom(other.Param);
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
				if (param_ == null)
				{
					Param = new PartyTaskParam();
				}
				input.ReadMessage(Param);
				break;
			}
		}
	}
}
