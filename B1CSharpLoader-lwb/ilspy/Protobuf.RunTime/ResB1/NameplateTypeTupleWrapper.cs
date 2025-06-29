using System;
using Google.Protobuf;

namespace ResB1;

public sealed class NameplateTypeTupleWrapper : IMessage<NameplateTypeTupleWrapper>, IMessage, IEquatable<NameplateTypeTupleWrapper>, IDeepCloneable<NameplateTypeTupleWrapper>
{
	private static readonly MessageParser<NameplateTypeTupleWrapper> _parser = new MessageParser<NameplateTypeTupleWrapper>(() => new NameplateTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private NameplateType item1_;

	private NameplateType item2_;

	public static MessageParser<NameplateTypeTupleWrapper> Parser => _parser;

	public NameplateType Item1
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

	public NameplateType Item2
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

	public NameplateTypeTupleWrapper()
	{
	}

	public NameplateTypeTupleWrapper(NameplateTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public NameplateTypeTupleWrapper Clone()
	{
		return new NameplateTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as NameplateTypeTupleWrapper);
	}

	public bool Equals(NameplateTypeTupleWrapper other)
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
		if (Item1 != NameplateType.Min)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != NameplateType.Min)
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
		if (Item1 != NameplateType.Min)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != NameplateType.Min)
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
		if (Item1 != NameplateType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != NameplateType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(NameplateTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != NameplateType.Min)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != NameplateType.Min)
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
				Item1 = (NameplateType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (NameplateType)input.ReadEnum();
				break;
			}
		}
	}
}
