using System;
using Google.Protobuf;

namespace CommB1;

public sealed class QuestCustom_CustomOutput : IMessage<QuestCustom_CustomOutput>, IMessage, IEquatable<QuestCustom_CustomOutput>, IDeepCloneable<QuestCustom_CustomOutput>
{
	private static readonly MessageParser<QuestCustom_CustomOutput> _parser = new MessageParser<QuestCustom_CustomOutput>(() => new QuestCustom_CustomOutput());

	private UnknownFieldSet _unknownFields;

	private string eventName_ = "";

	public static MessageParser<QuestCustom_CustomOutput> Parser => _parser;

	public string EventName
	{
		get
		{
			return eventName_;
		}
		set
		{
			eventName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public QuestCustom_CustomOutput()
	{
	}

	public QuestCustom_CustomOutput(QuestCustom_CustomOutput other)
		: this()
	{
		eventName_ = other.eventName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_CustomOutput Clone()
	{
		return new QuestCustom_CustomOutput(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_CustomOutput);
	}

	public bool Equals(QuestCustom_CustomOutput other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EventName != other.EventName)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (EventName.Length != 0)
		{
			num ^= EventName.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (EventName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(EventName);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (EventName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EventName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_CustomOutput other)
	{
		if (other != null)
		{
			if (other.EventName.Length != 0)
			{
				EventName = other.EventName;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				EventName = input.ReadString();
			}
		}
	}
}
