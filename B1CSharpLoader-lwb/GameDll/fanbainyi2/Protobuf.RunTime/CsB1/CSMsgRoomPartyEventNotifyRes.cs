using System;
using CommB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoomPartyEventNotifyRes : IMessage<CSMsgRoomPartyEventNotifyRes>, IMessage, IEquatable<CSMsgRoomPartyEventNotifyRes>, IDeepCloneable<CSMsgRoomPartyEventNotifyRes>
{
	private static readonly MessageParser<CSMsgRoomPartyEventNotifyRes> _parser = new MessageParser<CSMsgRoomPartyEventNotifyRes>(() => new CSMsgRoomPartyEventNotifyRes());

	private UnknownFieldSet _unknownFields;

	private ulong partyId_;

	private PartyEvent event_;

	private bool refreshData_;

	private PartyData partyData_;

	public static MessageParser<CSMsgRoomPartyEventNotifyRes> Parser => _parser;

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

	public PartyEvent Event
	{
		get
		{
			return event_;
		}
		set
		{
			event_ = value;
		}
	}

	public bool RefreshData
	{
		get
		{
			return refreshData_;
		}
		set
		{
			refreshData_ = value;
		}
	}

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

	public CSMsgRoomPartyEventNotifyRes()
	{
	}

	public CSMsgRoomPartyEventNotifyRes(CSMsgRoomPartyEventNotifyRes other)
		: this()
	{
		partyId_ = other.partyId_;
		event_ = ((other.event_ != null) ? other.event_.Clone() : null);
		refreshData_ = other.refreshData_;
		partyData_ = ((other.partyData_ != null) ? other.partyData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoomPartyEventNotifyRes Clone()
	{
		return new CSMsgRoomPartyEventNotifyRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoomPartyEventNotifyRes);
	}

	public bool Equals(CSMsgRoomPartyEventNotifyRes other)
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
		if (!object.Equals(Event, other.Event))
		{
			return false;
		}
		if (RefreshData != other.RefreshData)
		{
			return false;
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
		if (PartyId != 0L)
		{
			num ^= PartyId.GetHashCode();
		}
		if (event_ != null)
		{
			num ^= Event.GetHashCode();
		}
		if (RefreshData)
		{
			num ^= RefreshData.GetHashCode();
		}
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
		if (PartyId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(PartyId);
		}
		if (event_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Event);
		}
		if (RefreshData)
		{
			output.WriteRawTag(24);
			output.WriteBool(RefreshData);
		}
		if (partyData_ != null)
		{
			output.WriteRawTag(34);
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
		if (PartyId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(PartyId);
		}
		if (event_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Event);
		}
		if (RefreshData)
		{
			num += 2;
		}
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

	public void MergeFrom(CSMsgRoomPartyEventNotifyRes other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PartyId != 0L)
		{
			PartyId = other.PartyId;
		}
		if (other.event_ != null)
		{
			if (event_ == null)
			{
				Event = new PartyEvent();
			}
			Event.MergeFrom(other.Event);
		}
		if (other.RefreshData)
		{
			RefreshData = other.RefreshData;
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 8u:
				PartyId = input.ReadUInt64();
				break;
			case 18u:
				if (event_ == null)
				{
					Event = new PartyEvent();
				}
				input.ReadMessage(Event);
				break;
			case 24u:
				RefreshData = input.ReadBool();
				break;
			case 34u:
				if (partyData_ == null)
				{
					PartyData = new PartyData();
				}
				input.ReadMessage(PartyData);
				break;
			}
		}
	}
}
