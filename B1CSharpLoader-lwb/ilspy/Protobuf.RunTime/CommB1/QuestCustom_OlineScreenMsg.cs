using System;
using Google.Protobuf;

namespace CommB1;

public sealed class QuestCustom_OlineScreenMsg : IMessage<QuestCustom_OlineScreenMsg>, IMessage, IEquatable<QuestCustom_OlineScreenMsg>, IDeepCloneable<QuestCustom_OlineScreenMsg>
{
	private static readonly MessageParser<QuestCustom_OlineScreenMsg> _parser = new MessageParser<QuestCustom_OlineScreenMsg>(() => new QuestCustom_OlineScreenMsg());

	private UnknownFieldSet _unknownFields;

	private int eventId_;

	public static MessageParser<QuestCustom_OlineScreenMsg> Parser => _parser;

	public int EventId
	{
		get
		{
			return eventId_;
		}
		set
		{
			eventId_ = value;
		}
	}

	public QuestCustom_OlineScreenMsg()
	{
	}

	public QuestCustom_OlineScreenMsg(QuestCustom_OlineScreenMsg other)
		: this()
	{
		eventId_ = other.eventId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_OlineScreenMsg Clone()
	{
		return new QuestCustom_OlineScreenMsg(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_OlineScreenMsg);
	}

	public bool Equals(QuestCustom_OlineScreenMsg other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EventId != other.EventId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (EventId != 0)
		{
			num ^= EventId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (EventId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(EventId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (EventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_OlineScreenMsg other)
	{
		if (other != null)
		{
			if (other.EventId != 0)
			{
				EventId = other.EventId;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				EventId = input.ReadInt32();
			}
		}
	}
}
