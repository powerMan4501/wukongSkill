using System;
using Google.Protobuf;

namespace CommB1;

public sealed class QuestCustom_CustomInput : IMessage<QuestCustom_CustomInput>, IMessage, IEquatable<QuestCustom_CustomInput>, IDeepCloneable<QuestCustom_CustomInput>
{
	private static readonly MessageParser<QuestCustom_CustomInput> _parser = new MessageParser<QuestCustom_CustomInput>(() => new QuestCustom_CustomInput());

	private UnknownFieldSet _unknownFields;

	private string eventName_ = "";

	public static MessageParser<QuestCustom_CustomInput> Parser => _parser;

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

	public QuestCustom_CustomInput()
	{
	}

	public QuestCustom_CustomInput(QuestCustom_CustomInput other)
		: this()
	{
		eventName_ = other.eventName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_CustomInput Clone()
	{
		return new QuestCustom_CustomInput(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_CustomInput);
	}

	public bool Equals(QuestCustom_CustomInput other)
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

	public void MergeFrom(QuestCustom_CustomInput other)
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
