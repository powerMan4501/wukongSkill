using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EUnitBodyTypeTupleWrapper : IMessage<EUnitBodyTypeTupleWrapper>, IMessage, IEquatable<EUnitBodyTypeTupleWrapper>, IDeepCloneable<EUnitBodyTypeTupleWrapper>
{
	private static readonly MessageParser<EUnitBodyTypeTupleWrapper> _parser = new MessageParser<EUnitBodyTypeTupleWrapper>(() => new EUnitBodyTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EUnitBodyType item1_;

	private EUnitBodyType item2_;

	public static MessageParser<EUnitBodyTypeTupleWrapper> Parser => _parser;

	public EUnitBodyType Item1
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

	public EUnitBodyType Item2
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

	public EUnitBodyTypeTupleWrapper()
	{
	}

	public EUnitBodyTypeTupleWrapper(EUnitBodyTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EUnitBodyTypeTupleWrapper Clone()
	{
		return new EUnitBodyTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EUnitBodyTypeTupleWrapper);
	}

	public bool Equals(EUnitBodyTypeTupleWrapper other)
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
		if (Item1 != EUnitBodyType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EUnitBodyType.None)
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
		if (Item1 != EUnitBodyType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EUnitBodyType.None)
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
		if (Item1 != EUnitBodyType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EUnitBodyType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EUnitBodyTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EUnitBodyType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EUnitBodyType.None)
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
				Item1 = (EUnitBodyType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EUnitBodyType)input.ReadEnum();
				break;
			}
		}
	}
}
