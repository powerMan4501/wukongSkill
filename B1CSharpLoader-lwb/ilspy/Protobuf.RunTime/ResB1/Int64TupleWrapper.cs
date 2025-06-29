using System;
using Google.Protobuf;

namespace ResB1;

public sealed class Int64TupleWrapper : IMessage<Int64TupleWrapper>, IMessage, IEquatable<Int64TupleWrapper>, IDeepCloneable<Int64TupleWrapper>
{
	private static readonly MessageParser<Int64TupleWrapper> _parser = new MessageParser<Int64TupleWrapper>(() => new Int64TupleWrapper());

	private UnknownFieldSet _unknownFields;

	private long item1_;

	private long item2_;

	public static MessageParser<Int64TupleWrapper> Parser => _parser;

	public long Item1
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

	public long Item2
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

	public Int64TupleWrapper()
	{
	}

	public Int64TupleWrapper(Int64TupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public Int64TupleWrapper Clone()
	{
		return new Int64TupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as Int64TupleWrapper);
	}

	public bool Equals(Int64TupleWrapper other)
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
		if (Item1 != 0L)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != 0L)
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
		if (Item1 != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(Item1);
		}
		if (Item2 != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(Item2);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Item1 != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Item1);
		}
		if (Item2 != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(Int64TupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != 0L)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != 0L)
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
				Item1 = input.ReadInt64();
				break;
			case 16u:
				Item2 = input.ReadInt64();
				break;
			}
		}
	}
}
