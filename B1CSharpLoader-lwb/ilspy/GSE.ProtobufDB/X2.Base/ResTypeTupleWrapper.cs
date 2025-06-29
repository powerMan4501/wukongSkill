using System;
using Google.Protobuf;

namespace X2.Base;

public sealed class ResTypeTupleWrapper : IMessage<ResTypeTupleWrapper>, IMessage, IEquatable<ResTypeTupleWrapper>, IDeepCloneable<ResTypeTupleWrapper>
{
	private static readonly MessageParser<ResTypeTupleWrapper> _parser = new MessageParser<ResTypeTupleWrapper>(() => new ResTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ResType item1_;

	private ResType item2_;

	public static MessageParser<ResTypeTupleWrapper> Parser => _parser;

	public ResType Item1
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

	public ResType Item2
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

	public ResTypeTupleWrapper()
	{
	}

	public ResTypeTupleWrapper(ResTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ResTypeTupleWrapper Clone()
	{
		return new ResTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ResTypeTupleWrapper);
	}

	public bool Equals(ResTypeTupleWrapper other)
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
		if (Item1 != ResType.NormalMonster)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ResType.NormalMonster)
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
		if (Item1 != ResType.NormalMonster)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ResType.NormalMonster)
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
		if (Item1 != ResType.NormalMonster)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ResType.NormalMonster)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ResTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ResType.NormalMonster)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ResType.NormalMonster)
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
				Item1 = (ResType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ResType)input.ReadEnum();
				break;
			}
		}
	}
}
