using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class ESkipTypeTupleWrapper : IMessage<ESkipTypeTupleWrapper>, IMessage, IEquatable<ESkipTypeTupleWrapper>, IDeepCloneable<ESkipTypeTupleWrapper>
{
	private static readonly MessageParser<ESkipTypeTupleWrapper> _parser = new MessageParser<ESkipTypeTupleWrapper>(() => new ESkipTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ESkipType item1_;

	private ESkipType item2_;

	public static MessageParser<ESkipTypeTupleWrapper> Parser => _parser;

	public ESkipType Item1
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

	public ESkipType Item2
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

	public ESkipTypeTupleWrapper()
	{
	}

	public ESkipTypeTupleWrapper(ESkipTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ESkipTypeTupleWrapper Clone()
	{
		return new ESkipTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ESkipTypeTupleWrapper);
	}

	public bool Equals(ESkipTypeTupleWrapper other)
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
		if (Item1 != ESkipType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ESkipType.None)
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
		if (Item1 != ESkipType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ESkipType.None)
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
		if (Item1 != ESkipType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ESkipType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ESkipTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ESkipType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ESkipType.None)
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
				Item1 = (ESkipType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ESkipType)input.ReadEnum();
				break;
			}
		}
	}
}
