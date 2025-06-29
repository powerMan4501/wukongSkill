using System;
using Google.Protobuf;

namespace X2.Base;

public sealed class RelicTypeTupleWrapper : IMessage<RelicTypeTupleWrapper>, IMessage, IEquatable<RelicTypeTupleWrapper>, IDeepCloneable<RelicTypeTupleWrapper>
{
	private static readonly MessageParser<RelicTypeTupleWrapper> _parser = new MessageParser<RelicTypeTupleWrapper>(() => new RelicTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private RelicType item1_;

	private RelicType item2_;

	public static MessageParser<RelicTypeTupleWrapper> Parser => _parser;

	public RelicType Item1
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

	public RelicType Item2
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

	public RelicTypeTupleWrapper()
	{
	}

	public RelicTypeTupleWrapper(RelicTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RelicTypeTupleWrapper Clone()
	{
		return new RelicTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RelicTypeTupleWrapper);
	}

	public bool Equals(RelicTypeTupleWrapper other)
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
		if (Item1 != RelicType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != RelicType.None)
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
		if (Item1 != RelicType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != RelicType.None)
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
		if (Item1 != RelicType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != RelicType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RelicTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != RelicType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != RelicType.None)
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
				Item1 = (RelicType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (RelicType)input.ReadEnum();
				break;
			}
		}
	}
}
