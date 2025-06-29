using System;
using CommB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoomJoinPartyCSRes : IMessage<CSMsgRoomJoinPartyCSRes>, IMessage, IEquatable<CSMsgRoomJoinPartyCSRes>, IDeepCloneable<CSMsgRoomJoinPartyCSRes>
{
	private static readonly MessageParser<CSMsgRoomJoinPartyCSRes> _parser = new MessageParser<CSMsgRoomJoinPartyCSRes>(() => new CSMsgRoomJoinPartyCSRes());

	private UnknownFieldSet _unknownFields;

	private PartyData partyData_;

	public static MessageParser<CSMsgRoomJoinPartyCSRes> Parser => _parser;

	public PartyData PartyData
	{
		get
		{
			return partyData_;
		}
		set
		{
			partyData_ = value;
		}
	}

	public CSMsgRoomJoinPartyCSRes()
	{
	}

	public CSMsgRoomJoinPartyCSRes(CSMsgRoomJoinPartyCSRes other)
		: this()
	{
		partyData_ = ((other.partyData_ != null) ? other.partyData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoomJoinPartyCSRes Clone()
	{
		return new CSMsgRoomJoinPartyCSRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoomJoinPartyCSRes);
	}

	public bool Equals(CSMsgRoomJoinPartyCSRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PartyData, other.PartyData))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (partyData_ != null)
		{
			num ^= PartyData.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (partyData_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(PartyData);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (partyData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PartyData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgRoomJoinPartyCSRes other)
	{
		if (other == null)
		{
			return;
		}
		if (other.partyData_ != null)
		{
			if (partyData_ == null)
			{
				PartyData = new PartyData();
			}
			PartyData.MergeFrom(other.PartyData);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				continue;
			}
			if (partyData_ == null)
			{
				PartyData = new PartyData();
			}
			input.ReadMessage(PartyData);
		}
	}
}
