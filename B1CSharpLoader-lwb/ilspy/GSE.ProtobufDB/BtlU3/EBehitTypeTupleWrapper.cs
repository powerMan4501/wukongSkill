using System;
using Google.Protobuf;

namespace BtlU3;

public sealed class EBehitTypeTupleWrapper : IMessage<EBehitTypeTupleWrapper>, IMessage, IEquatable<EBehitTypeTupleWrapper>, IDeepCloneable<EBehitTypeTupleWrapper>
{
	private static readonly MessageParser<EBehitTypeTupleWrapper> _parser = new MessageParser<EBehitTypeTupleWrapper>(() => new EBehitTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EBehitType item1_;

	private EBehitType item2_;

	public static MessageParser<EBehitTypeTupleWrapper> Parser => _parser;

	public EBehitType Item1
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

	public EBehitType Item2
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

	public EBehitTypeTupleWrapper()
	{
	}

	public EBehitTypeTupleWrapper(EBehitTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EBehitTypeTupleWrapper Clone()
	{
		return new EBehitTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EBehitTypeTupleWrapper);
	}

	public bool Equals(EBehitTypeTupleWrapper other)
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
		if (Item1 != EBehitType.Biology)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EBehitType.Biology)
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
		if (Item1 != EBehitType.Biology)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EBehitType.Biology)
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
		if (Item1 != EBehitType.Biology)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EBehitType.Biology)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EBehitTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EBehitType.Biology)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EBehitType.Biology)
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
				Item1 = (EBehitType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EBehitType)input.ReadEnum();
				break;
			}
		}
	}
}
