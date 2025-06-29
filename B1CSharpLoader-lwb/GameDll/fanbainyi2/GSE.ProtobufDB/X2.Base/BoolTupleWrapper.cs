using System;
using Google.Protobuf;

namespace X2.Base;

public sealed class BoolTupleWrapper : IMessage<BoolTupleWrapper>, IMessage, IEquatable<BoolTupleWrapper>, IDeepCloneable<BoolTupleWrapper>
{
	private static readonly MessageParser<BoolTupleWrapper> _parser = new MessageParser<BoolTupleWrapper>(() => new BoolTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private bool item1_;

	private bool item2_;

	public static MessageParser<BoolTupleWrapper> Parser => _parser;

	public bool Item1
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

	public bool Item2
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

	public BoolTupleWrapper()
	{
	}

	public BoolTupleWrapper(BoolTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BoolTupleWrapper Clone()
	{
		return new BoolTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BoolTupleWrapper);
	}

	public bool Equals(BoolTupleWrapper other)
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
		if (Item1)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2)
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
		if (Item1)
		{
			output.WriteRawTag(8);
			output.WriteBool(Item1);
		}
		if (Item2)
		{
			output.WriteRawTag(16);
			output.WriteBool(Item2);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Item1)
		{
			num += 2;
		}
		if (Item2)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BoolTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1)
			{
				Item1 = other.Item1;
			}
			if (other.Item2)
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
				Item1 = input.ReadBool();
				break;
			case 16u:
				Item2 = input.ReadBool();
				break;
			}
		}
	}
}
