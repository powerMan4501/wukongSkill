using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EGSRoarWeightLevelTupleWrapper : IMessage<EGSRoarWeightLevelTupleWrapper>, IMessage, IEquatable<EGSRoarWeightLevelTupleWrapper>, IDeepCloneable<EGSRoarWeightLevelTupleWrapper>
{
	private static readonly MessageParser<EGSRoarWeightLevelTupleWrapper> _parser = new MessageParser<EGSRoarWeightLevelTupleWrapper>(() => new EGSRoarWeightLevelTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EGSRoarWeightLevel item1_;

	private EGSRoarWeightLevel item2_;

	public static MessageParser<EGSRoarWeightLevelTupleWrapper> Parser => _parser;

	public EGSRoarWeightLevel Item1
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

	public EGSRoarWeightLevel Item2
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

	public EGSRoarWeightLevelTupleWrapper()
	{
	}

	public EGSRoarWeightLevelTupleWrapper(EGSRoarWeightLevelTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EGSRoarWeightLevelTupleWrapper Clone()
	{
		return new EGSRoarWeightLevelTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EGSRoarWeightLevelTupleWrapper);
	}

	public bool Equals(EGSRoarWeightLevelTupleWrapper other)
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
		if (Item1 != EGSRoarWeightLevel.NoFeeling)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EGSRoarWeightLevel.NoFeeling)
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
		if (Item1 != EGSRoarWeightLevel.NoFeeling)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EGSRoarWeightLevel.NoFeeling)
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
		if (Item1 != EGSRoarWeightLevel.NoFeeling)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EGSRoarWeightLevel.NoFeeling)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EGSRoarWeightLevelTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EGSRoarWeightLevel.NoFeeling)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EGSRoarWeightLevel.NoFeeling)
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
				Item1 = (EGSRoarWeightLevel)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EGSRoarWeightLevel)input.ReadEnum();
				break;
			}
		}
	}
}
