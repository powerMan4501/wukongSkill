using System;
using Google.Protobuf;

namespace BaseU3;

public sealed class AITargetModeTupleWrapper : IMessage<AITargetModeTupleWrapper>, IMessage, IEquatable<AITargetModeTupleWrapper>, IDeepCloneable<AITargetModeTupleWrapper>
{
	private static readonly MessageParser<AITargetModeTupleWrapper> _parser = new MessageParser<AITargetModeTupleWrapper>(() => new AITargetModeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private AITargetMode item1_;

	private AITargetMode item2_;

	public static MessageParser<AITargetModeTupleWrapper> Parser => _parser;

	public AITargetMode Item1
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

	public AITargetMode Item2
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

	public AITargetModeTupleWrapper()
	{
	}

	public AITargetModeTupleWrapper(AITargetModeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AITargetModeTupleWrapper Clone()
	{
		return new AITargetModeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AITargetModeTupleWrapper);
	}

	public bool Equals(AITargetModeTupleWrapper other)
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
		if (Item1 != AITargetMode.Aim)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != AITargetMode.Aim)
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
		if (Item1 != AITargetMode.Aim)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != AITargetMode.Aim)
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
		if (Item1 != AITargetMode.Aim)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != AITargetMode.Aim)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AITargetModeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != AITargetMode.Aim)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != AITargetMode.Aim)
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
				Item1 = (AITargetMode)input.ReadEnum();
				break;
			case 16u:
				Item2 = (AITargetMode)input.ReadEnum();
				break;
			}
		}
	}
}
