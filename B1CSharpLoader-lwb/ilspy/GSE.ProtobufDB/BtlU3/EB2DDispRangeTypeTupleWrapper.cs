using System;
using Google.Protobuf;

namespace BtlU3;

public sealed class EB2DDispRangeTypeTupleWrapper : IMessage<EB2DDispRangeTypeTupleWrapper>, IMessage, IEquatable<EB2DDispRangeTypeTupleWrapper>, IDeepCloneable<EB2DDispRangeTypeTupleWrapper>
{
	private static readonly MessageParser<EB2DDispRangeTypeTupleWrapper> _parser = new MessageParser<EB2DDispRangeTypeTupleWrapper>(() => new EB2DDispRangeTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EB2DDispRangeType item1_;

	private EB2DDispRangeType item2_;

	public static MessageParser<EB2DDispRangeTypeTupleWrapper> Parser => _parser;

	public EB2DDispRangeType Item1
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

	public EB2DDispRangeType Item2
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

	public EB2DDispRangeTypeTupleWrapper()
	{
	}

	public EB2DDispRangeTypeTupleWrapper(EB2DDispRangeTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EB2DDispRangeTypeTupleWrapper Clone()
	{
		return new EB2DDispRangeTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EB2DDispRangeTypeTupleWrapper);
	}

	public bool Equals(EB2DDispRangeTypeTupleWrapper other)
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
		if (Item1 != EB2DDispRangeType.TargetBaseObj)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EB2DDispRangeType.TargetBaseObj)
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
		if (Item1 != EB2DDispRangeType.TargetBaseObj)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EB2DDispRangeType.TargetBaseObj)
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
		if (Item1 != EB2DDispRangeType.TargetBaseObj)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EB2DDispRangeType.TargetBaseObj)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EB2DDispRangeTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EB2DDispRangeType.TargetBaseObj)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EB2DDispRangeType.TargetBaseObj)
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
				Item1 = (EB2DDispRangeType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EB2DDispRangeType)input.ReadEnum();
				break;
			}
		}
	}
}
