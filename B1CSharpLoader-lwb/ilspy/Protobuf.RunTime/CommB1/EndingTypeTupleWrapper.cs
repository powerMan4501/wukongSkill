using System;
using Google.Protobuf;

namespace CommB1;

public sealed class EndingTypeTupleWrapper : IMessage<EndingTypeTupleWrapper>, IMessage, IEquatable<EndingTypeTupleWrapper>, IDeepCloneable<EndingTypeTupleWrapper>
{
	private static readonly MessageParser<EndingTypeTupleWrapper> _parser = new MessageParser<EndingTypeTupleWrapper>(() => new EndingTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EndingType item1_;

	private EndingType item2_;

	public static MessageParser<EndingTypeTupleWrapper> Parser => _parser;

	public EndingType Item1
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

	public EndingType Item2
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

	public EndingTypeTupleWrapper()
	{
	}

	public EndingTypeTupleWrapper(EndingTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EndingTypeTupleWrapper Clone()
	{
		return new EndingTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EndingTypeTupleWrapper);
	}

	public bool Equals(EndingTypeTupleWrapper other)
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
		if (Item1 != EndingType.A)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EndingType.A)
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
		if (Item1 != EndingType.A)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EndingType.A)
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
		if (Item1 != EndingType.A)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EndingType.A)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EndingTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EndingType.A)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EndingType.A)
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
				Item1 = (EndingType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EndingType)input.ReadEnum();
				break;
			}
		}
	}
}
