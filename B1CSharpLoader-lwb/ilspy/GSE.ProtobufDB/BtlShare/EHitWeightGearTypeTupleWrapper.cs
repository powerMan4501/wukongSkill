using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EHitWeightGearTypeTupleWrapper : IMessage<EHitWeightGearTypeTupleWrapper>, IMessage, IEquatable<EHitWeightGearTypeTupleWrapper>, IDeepCloneable<EHitWeightGearTypeTupleWrapper>
{
	private static readonly MessageParser<EHitWeightGearTypeTupleWrapper> _parser = new MessageParser<EHitWeightGearTypeTupleWrapper>(() => new EHitWeightGearTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EHitWeightGearType item1_;

	private EHitWeightGearType item2_;

	public static MessageParser<EHitWeightGearTypeTupleWrapper> Parser => _parser;

	public EHitWeightGearType Item1
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

	public EHitWeightGearType Item2
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

	public EHitWeightGearTypeTupleWrapper()
	{
	}

	public EHitWeightGearTypeTupleWrapper(EHitWeightGearTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EHitWeightGearTypeTupleWrapper Clone()
	{
		return new EHitWeightGearTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EHitWeightGearTypeTupleWrapper);
	}

	public bool Equals(EHitWeightGearTypeTupleWrapper other)
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
		if (Item1 != EHitWeightGearType.LowHitWeight)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EHitWeightGearType.LowHitWeight)
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
		if (Item1 != EHitWeightGearType.LowHitWeight)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EHitWeightGearType.LowHitWeight)
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
		if (Item1 != EHitWeightGearType.LowHitWeight)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EHitWeightGearType.LowHitWeight)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EHitWeightGearTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EHitWeightGearType.LowHitWeight)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EHitWeightGearType.LowHitWeight)
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
				Item1 = (EHitWeightGearType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EHitWeightGearType)input.ReadEnum();
				break;
			}
		}
	}
}
