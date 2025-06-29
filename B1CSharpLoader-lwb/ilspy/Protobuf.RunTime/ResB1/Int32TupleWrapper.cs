using System;
using Google.Protobuf;

namespace ResB1;

public sealed class Int32TupleWrapper : IMessage<Int32TupleWrapper>, IMessage, IEquatable<Int32TupleWrapper>, IDeepCloneable<Int32TupleWrapper>
{
	private static readonly MessageParser<Int32TupleWrapper> _parser = new MessageParser<Int32TupleWrapper>(() => new Int32TupleWrapper());

	private UnknownFieldSet _unknownFields;

	private int item1_;

	private int item2_;

	public static MessageParser<Int32TupleWrapper> Parser => _parser;

	public int Item1
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

	public int Item2
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

	public Int32TupleWrapper()
	{
	}

	public Int32TupleWrapper(Int32TupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public Int32TupleWrapper Clone()
	{
		return new Int32TupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as Int32TupleWrapper);
	}

	public bool Equals(Int32TupleWrapper other)
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
		if (Item1 != 0)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != 0)
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
		if (Item1 != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Item1);
		}
		if (Item2 != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Item2);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Item1 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Item1);
		}
		if (Item2 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(Int32TupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != 0)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != 0)
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
				Item1 = input.ReadInt32();
				break;
			case 16u:
				Item2 = input.ReadInt32();
				break;
			}
		}
	}
}
