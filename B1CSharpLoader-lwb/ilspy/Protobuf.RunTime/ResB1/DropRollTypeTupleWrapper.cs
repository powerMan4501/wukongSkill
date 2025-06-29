using System;
using Google.Protobuf;

namespace ResB1;

public sealed class DropRollTypeTupleWrapper : IMessage<DropRollTypeTupleWrapper>, IMessage, IEquatable<DropRollTypeTupleWrapper>, IDeepCloneable<DropRollTypeTupleWrapper>
{
	private static readonly MessageParser<DropRollTypeTupleWrapper> _parser = new MessageParser<DropRollTypeTupleWrapper>(() => new DropRollTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private DropRollType item1_;

	private DropRollType item2_;

	public static MessageParser<DropRollTypeTupleWrapper> Parser => _parser;

	public DropRollType Item1
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

	public DropRollType Item2
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

	public DropRollTypeTupleWrapper()
	{
	}

	public DropRollTypeTupleWrapper(DropRollTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DropRollTypeTupleWrapper Clone()
	{
		return new DropRollTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DropRollTypeTupleWrapper);
	}

	public bool Equals(DropRollTypeTupleWrapper other)
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
		if (Item1 != DropRollType.All)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != DropRollType.All)
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
		if (Item1 != DropRollType.All)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != DropRollType.All)
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
		if (Item1 != DropRollType.All)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != DropRollType.All)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DropRollTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != DropRollType.All)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != DropRollType.All)
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
				Item1 = (DropRollType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (DropRollType)input.ReadEnum();
				break;
			}
		}
	}
}
