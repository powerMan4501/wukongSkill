using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class EHitPartReduceAttrTypeTupleWrapper : IMessage<EHitPartReduceAttrTypeTupleWrapper>, IMessage, IEquatable<EHitPartReduceAttrTypeTupleWrapper>, IDeepCloneable<EHitPartReduceAttrTypeTupleWrapper>
{
	private static readonly MessageParser<EHitPartReduceAttrTypeTupleWrapper> _parser = new MessageParser<EHitPartReduceAttrTypeTupleWrapper>(() => new EHitPartReduceAttrTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EHitPartReduceAttrType item1_;

	private EHitPartReduceAttrType item2_;

	public static MessageParser<EHitPartReduceAttrTypeTupleWrapper> Parser => _parser;

	public EHitPartReduceAttrType Item1
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

	public EHitPartReduceAttrType Item2
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

	public EHitPartReduceAttrTypeTupleWrapper()
	{
	}

	public EHitPartReduceAttrTypeTupleWrapper(EHitPartReduceAttrTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EHitPartReduceAttrTypeTupleWrapper Clone()
	{
		return new EHitPartReduceAttrTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EHitPartReduceAttrTypeTupleWrapper);
	}

	public bool Equals(EHitPartReduceAttrTypeTupleWrapper other)
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
		if (Item1 != EHitPartReduceAttrType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EHitPartReduceAttrType.None)
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
		if (Item1 != EHitPartReduceAttrType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EHitPartReduceAttrType.None)
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
		if (Item1 != EHitPartReduceAttrType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EHitPartReduceAttrType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EHitPartReduceAttrTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EHitPartReduceAttrType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EHitPartReduceAttrType.None)
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
				Item1 = (EHitPartReduceAttrType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EHitPartReduceAttrType)input.ReadEnum();
				break;
			}
		}
	}
}
