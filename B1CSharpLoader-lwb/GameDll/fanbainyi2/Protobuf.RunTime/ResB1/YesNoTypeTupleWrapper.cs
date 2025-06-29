using System;
using Google.Protobuf;

namespace ResB1;

public sealed class YesNoTypeTupleWrapper : IMessage<YesNoTypeTupleWrapper>, IMessage, IEquatable<YesNoTypeTupleWrapper>, IDeepCloneable<YesNoTypeTupleWrapper>
{
	private static readonly MessageParser<YesNoTypeTupleWrapper> _parser = new MessageParser<YesNoTypeTupleWrapper>(() => new YesNoTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private YesNoType item1_;

	private YesNoType item2_;

	public static MessageParser<YesNoTypeTupleWrapper> Parser => _parser;

	public YesNoType Item1
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

	public YesNoType Item2
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

	public YesNoTypeTupleWrapper()
	{
	}

	public YesNoTypeTupleWrapper(YesNoTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public YesNoTypeTupleWrapper Clone()
	{
		return new YesNoTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as YesNoTypeTupleWrapper);
	}

	public bool Equals(YesNoTypeTupleWrapper other)
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
		if (Item1 != YesNoType.No)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != YesNoType.No)
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
		if (Item1 != YesNoType.No)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != YesNoType.No)
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
		if (Item1 != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(YesNoTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != YesNoType.No)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != YesNoType.No)
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
				Item1 = (YesNoType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (YesNoType)input.ReadEnum();
				break;
			}
		}
	}
}
