using System;
using Google.Protobuf;

namespace ResB1;

public sealed class FuncOpenLimitTypeTupleWrapper : IMessage<FuncOpenLimitTypeTupleWrapper>, IMessage, IEquatable<FuncOpenLimitTypeTupleWrapper>, IDeepCloneable<FuncOpenLimitTypeTupleWrapper>
{
	private static readonly MessageParser<FuncOpenLimitTypeTupleWrapper> _parser = new MessageParser<FuncOpenLimitTypeTupleWrapper>(() => new FuncOpenLimitTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private FuncOpenLimitType item1_;

	private FuncOpenLimitType item2_;

	public static MessageParser<FuncOpenLimitTypeTupleWrapper> Parser => _parser;

	public FuncOpenLimitType Item1
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

	public FuncOpenLimitType Item2
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

	public FuncOpenLimitTypeTupleWrapper()
	{
	}

	public FuncOpenLimitTypeTupleWrapper(FuncOpenLimitTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FuncOpenLimitTypeTupleWrapper Clone()
	{
		return new FuncOpenLimitTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FuncOpenLimitTypeTupleWrapper);
	}

	public bool Equals(FuncOpenLimitTypeTupleWrapper other)
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
		if (Item1 != FuncOpenLimitType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != FuncOpenLimitType.None)
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
		if (Item1 != FuncOpenLimitType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != FuncOpenLimitType.None)
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
		if (Item1 != FuncOpenLimitType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != FuncOpenLimitType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FuncOpenLimitTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != FuncOpenLimitType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != FuncOpenLimitType.None)
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
				Item1 = (FuncOpenLimitType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (FuncOpenLimitType)input.ReadEnum();
				break;
			}
		}
	}
}
