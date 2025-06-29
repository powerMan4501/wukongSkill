using System;
using Google.Protobuf;

namespace CommB1;

public sealed class QuestCustom_Counter : IMessage<QuestCustom_Counter>, IMessage, IEquatable<QuestCustom_Counter>, IDeepCloneable<QuestCustom_Counter>
{
	private static readonly MessageParser<QuestCustom_Counter> _parser = new MessageParser<QuestCustom_Counter>(() => new QuestCustom_Counter());

	private UnknownFieldSet _unknownFields;

	private int goal_;

	public static MessageParser<QuestCustom_Counter> Parser => _parser;

	public int Goal
	{
		get
		{
			return goal_;
		}
		set
		{
			goal_ = value;
		}
	}

	public QuestCustom_Counter()
	{
	}

	public QuestCustom_Counter(QuestCustom_Counter other)
		: this()
	{
		goal_ = other.goal_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_Counter Clone()
	{
		return new QuestCustom_Counter(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_Counter);
	}

	public bool Equals(QuestCustom_Counter other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Goal != other.Goal)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Goal != 0)
		{
			num ^= Goal.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Goal != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Goal);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Goal != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Goal);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_Counter other)
	{
		if (other != null)
		{
			if (other.Goal != 0)
			{
				Goal = other.Goal;
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
				Goal = input.ReadInt32();
			}
		}
	}
}
