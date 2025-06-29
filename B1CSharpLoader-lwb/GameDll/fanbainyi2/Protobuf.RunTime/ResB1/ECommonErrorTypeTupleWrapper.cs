using System;
using Google.Protobuf;

namespace ResB1;

public sealed class ECommonErrorTypeTupleWrapper : IMessage<ECommonErrorTypeTupleWrapper>, IMessage, IEquatable<ECommonErrorTypeTupleWrapper>, IDeepCloneable<ECommonErrorTypeTupleWrapper>
{
	private static readonly MessageParser<ECommonErrorTypeTupleWrapper> _parser = new MessageParser<ECommonErrorTypeTupleWrapper>(() => new ECommonErrorTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ECommonErrorType item1_;

	private ECommonErrorType item2_;

	public static MessageParser<ECommonErrorTypeTupleWrapper> Parser => _parser;

	public ECommonErrorType Item1
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

	public ECommonErrorType Item2
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

	public ECommonErrorTypeTupleWrapper()
	{
	}

	public ECommonErrorTypeTupleWrapper(ECommonErrorTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ECommonErrorTypeTupleWrapper Clone()
	{
		return new ECommonErrorTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ECommonErrorTypeTupleWrapper);
	}

	public bool Equals(ECommonErrorTypeTupleWrapper other)
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
		if (Item1 != ECommonErrorType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ECommonErrorType.None)
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
		if (Item1 != ECommonErrorType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ECommonErrorType.None)
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
		if (Item1 != ECommonErrorType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ECommonErrorType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ECommonErrorTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ECommonErrorType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ECommonErrorType.None)
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
				Item1 = (ECommonErrorType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ECommonErrorType)input.ReadEnum();
				break;
			}
		}
	}
}
