using System;
using Google.Protobuf;

namespace CommB1;

public sealed class LogicRelationTypeTupleWrapper : IMessage<LogicRelationTypeTupleWrapper>, IMessage, IEquatable<LogicRelationTypeTupleWrapper>, IDeepCloneable<LogicRelationTypeTupleWrapper>
{
	private static readonly MessageParser<LogicRelationTypeTupleWrapper> _parser = new MessageParser<LogicRelationTypeTupleWrapper>(() => new LogicRelationTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private LogicRelationType item1_;

	private LogicRelationType item2_;

	public static MessageParser<LogicRelationTypeTupleWrapper> Parser => _parser;

	public LogicRelationType Item1
	{
		get
		{
			return item1_;
		}
		set
		{
			item1_ = value;
		}
	}

	public LogicRelationType Item2
	{
		get
		{
			return item2_;
		}
		set
		{
			item2_ = value;
		}
	}

	public LogicRelationTypeTupleWrapper()
	{
	}

	public LogicRelationTypeTupleWrapper(LogicRelationTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LogicRelationTypeTupleWrapper Clone()
	{
		return new LogicRelationTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LogicRelationTypeTupleWrapper);
	}

	public bool Equals(LogicRelationTypeTupleWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Item1 != other.Item1)
		{
			return false;
		}
		if (Item2 != other.Item2)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Item1 != LogicRelationType.LogicRelationAnd)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != LogicRelationType.LogicRelationAnd)
		{
			num ^= Item2.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Item1 != LogicRelationType.LogicRelationAnd)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != LogicRelationType.LogicRelationAnd)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Item2);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Item1 != LogicRelationType.LogicRelationAnd)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != LogicRelationType.LogicRelationAnd)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LogicRelationTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != LogicRelationType.LogicRelationAnd)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != LogicRelationType.LogicRelationAnd)
			{
				Item2 = other.Item2;
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
				Item1 = (LogicRelationType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (LogicRelationType)input.ReadEnum();
				break;
			}
		}
	}
}
