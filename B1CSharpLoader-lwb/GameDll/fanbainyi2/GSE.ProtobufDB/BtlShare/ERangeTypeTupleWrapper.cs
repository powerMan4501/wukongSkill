using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class ERangeTypeTupleWrapper : IMessage<ERangeTypeTupleWrapper>, IMessage, IEquatable<ERangeTypeTupleWrapper>, IDeepCloneable<ERangeTypeTupleWrapper>
{
	private static readonly MessageParser<ERangeTypeTupleWrapper> _parser = new MessageParser<ERangeTypeTupleWrapper>(() => new ERangeTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ERangeType item1_;

	private ERangeType item2_;

	public static MessageParser<ERangeTypeTupleWrapper> Parser => _parser;

	public ERangeType Item1
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

	public ERangeType Item2
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

	public ERangeTypeTupleWrapper()
	{
	}

	public ERangeTypeTupleWrapper(ERangeTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ERangeTypeTupleWrapper Clone()
	{
		return new ERangeTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ERangeTypeTupleWrapper);
	}

	public bool Equals(ERangeTypeTupleWrapper other)
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
		if (Item1 != ERangeType.TargetBaseObj)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ERangeType.TargetBaseObj)
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
		if (Item1 != ERangeType.TargetBaseObj)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ERangeType.TargetBaseObj)
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
		if (Item1 != ERangeType.TargetBaseObj)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ERangeType.TargetBaseObj)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ERangeTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ERangeType.TargetBaseObj)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ERangeType.TargetBaseObj)
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
				Item1 = (ERangeType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ERangeType)input.ReadEnum();
				break;
			}
		}
	}
}
