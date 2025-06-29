using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class ESummonUnitLocationTypeTupleWrapper : IMessage<ESummonUnitLocationTypeTupleWrapper>, IMessage, IEquatable<ESummonUnitLocationTypeTupleWrapper>, IDeepCloneable<ESummonUnitLocationTypeTupleWrapper>
{
	private static readonly MessageParser<ESummonUnitLocationTypeTupleWrapper> _parser = new MessageParser<ESummonUnitLocationTypeTupleWrapper>(() => new ESummonUnitLocationTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ESummonUnitLocationType item1_;

	private ESummonUnitLocationType item2_;

	public static MessageParser<ESummonUnitLocationTypeTupleWrapper> Parser => _parser;

	public ESummonUnitLocationType Item1
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

	public ESummonUnitLocationType Item2
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

	public ESummonUnitLocationTypeTupleWrapper()
	{
	}

	public ESummonUnitLocationTypeTupleWrapper(ESummonUnitLocationTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ESummonUnitLocationTypeTupleWrapper Clone()
	{
		return new ESummonUnitLocationTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ESummonUnitLocationTypeTupleWrapper);
	}

	public bool Equals(ESummonUnitLocationTypeTupleWrapper other)
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
		if (Item1 != ESummonUnitLocationType.UsePointSetCached)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ESummonUnitLocationType.UsePointSetCached)
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
		if (Item1 != ESummonUnitLocationType.UsePointSetCached)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ESummonUnitLocationType.UsePointSetCached)
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
		if (Item1 != ESummonUnitLocationType.UsePointSetCached)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ESummonUnitLocationType.UsePointSetCached)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ESummonUnitLocationTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ESummonUnitLocationType.UsePointSetCached)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ESummonUnitLocationType.UsePointSetCached)
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
				Item1 = (ESummonUnitLocationType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ESummonUnitLocationType)input.ReadEnum();
				break;
			}
		}
	}
}
