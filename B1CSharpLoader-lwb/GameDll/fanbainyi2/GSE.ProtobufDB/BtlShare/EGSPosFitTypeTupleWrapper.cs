using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EGSPosFitTypeTupleWrapper : IMessage<EGSPosFitTypeTupleWrapper>, IMessage, IEquatable<EGSPosFitTypeTupleWrapper>, IDeepCloneable<EGSPosFitTypeTupleWrapper>
{
	private static readonly MessageParser<EGSPosFitTypeTupleWrapper> _parser = new MessageParser<EGSPosFitTypeTupleWrapper>(() => new EGSPosFitTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EGSPosFitType item1_;

	private EGSPosFitType item2_;

	public static MessageParser<EGSPosFitTypeTupleWrapper> Parser => _parser;

	public EGSPosFitType Item1
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

	public EGSPosFitType Item2
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

	public EGSPosFitTypeTupleWrapper()
	{
	}

	public EGSPosFitTypeTupleWrapper(EGSPosFitTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EGSPosFitTypeTupleWrapper Clone()
	{
		return new EGSPosFitTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EGSPosFitTypeTupleWrapper);
	}

	public bool Equals(EGSPosFitTypeTupleWrapper other)
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
		if (Item1 != EGSPosFitType.FitBegin)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EGSPosFitType.FitBegin)
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
		if (Item1 != EGSPosFitType.FitBegin)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EGSPosFitType.FitBegin)
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
		if (Item1 != EGSPosFitType.FitBegin)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EGSPosFitType.FitBegin)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EGSPosFitTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EGSPosFitType.FitBegin)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EGSPosFitType.FitBegin)
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
				Item1 = (EGSPosFitType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EGSPosFitType)input.ReadEnum();
				break;
			}
		}
	}
}
