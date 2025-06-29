using System;
using Google.Protobuf;

namespace CommB1;

public sealed class PartyEvent : IMessage<PartyEvent>, IMessage, IEquatable<PartyEvent>, IDeepCloneable<PartyEvent>
{
	private static readonly MessageParser<PartyEvent> _parser = new MessageParser<PartyEvent>(() => new PartyEvent());

	private UnknownFieldSet _unknownFields;

	private PartyEventType eventType_;

	private ulong trigger_;

	private ulong receiver_;

	public static MessageParser<PartyEvent> Parser => _parser;

	public PartyEventType EventType
	{
		get
		{
			return eventType_;
		}
		set
		{
			eventType_ = value;
		}
	}

	public ulong Trigger
	{
		get
		{
			return trigger_;
		}
		set
		{
			trigger_ = value;
		}
	}

	public ulong Receiver
	{
		get
		{
			return receiver_;
		}
		set
		{
			receiver_ = value;
		}
	}

	public PartyEvent()
	{
	}

	public PartyEvent(PartyEvent other)
		: this()
	{
		eventType_ = other.eventType_;
		trigger_ = other.trigger_;
		receiver_ = other.receiver_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartyEvent Clone()
	{
		return new PartyEvent(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartyEvent);
	}

	public bool Equals(PartyEvent other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EventType != other.EventType)
		{
			return false;
		}
		if (Trigger != other.Trigger)
		{
			return false;
		}
		if (Receiver != other.Receiver)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (EventType != PartyEventType.None)
		{
			num ^= EventType.GetHashCode();
		}
		if (Trigger != 0L)
		{
			num ^= Trigger.GetHashCode();
		}
		if (Receiver != 0L)
		{
			num ^= Receiver.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (EventType != PartyEventType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)EventType);
		}
		if (Trigger != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(Trigger);
		}
		if (Receiver != 0L)
		{
			output.WriteRawTag(24);
			output.WriteUInt64(Receiver);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (EventType != PartyEventType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EventType);
		}
		if (Trigger != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Trigger);
		}
		if (Receiver != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Receiver);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PartyEvent other)
	{
		if (other != null)
		{
			if (other.EventType != PartyEventType.None)
			{
				EventType = other.EventType;
			}
			if (other.Trigger != 0L)
			{
				Trigger = other.Trigger;
			}
			if (other.Receiver != 0L)
			{
				Receiver = other.Receiver;
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
				EventType = (PartyEventType)input.ReadEnum();
				break;
			case 16u:
				Trigger = input.ReadUInt64();
				break;
			case 24u:
				Receiver = input.ReadUInt64();
				break;
			}
		}
	}
}
