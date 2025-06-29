using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EGSYesNoTupleWrapper : IMessage<EGSYesNoTupleWrapper>, IMessage, IEquatable<EGSYesNoTupleWrapper>, IDeepCloneable<EGSYesNoTupleWrapper>
{
	private static readonly MessageParser<EGSYesNoTupleWrapper> _parser = new MessageParser<EGSYesNoTupleWrapper>(() => new EGSYesNoTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EGSYesNo item1_;

	private EGSYesNo item2_;

	public static MessageParser<EGSYesNoTupleWrapper> Parser => _parser;

	public EGSYesNo Item1
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

	public EGSYesNo Item2
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

	public EGSYesNoTupleWrapper()
	{
	}

	public EGSYesNoTupleWrapper(EGSYesNoTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EGSYesNoTupleWrapper Clone()
	{
		return new EGSYesNoTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EGSYesNoTupleWrapper);
	}

	public bool Equals(EGSYesNoTupleWrapper other)
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
		if (Item1 != EGSYesNo.No)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EGSYesNo.No)
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
		if (Item1 != EGSYesNo.No)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EGSYesNo.No)
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
		if (Item1 != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EGSYesNoTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EGSYesNo.No)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EGSYesNo.No)
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
				Item1 = (EGSYesNo)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EGSYesNo)input.ReadEnum();
				break;
			}
		}
	}
}
