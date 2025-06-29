using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class StanceTupleWrapper : IMessage<StanceTupleWrapper>, IMessage, IEquatable<StanceTupleWrapper>, IDeepCloneable<StanceTupleWrapper>
{
	private static readonly MessageParser<StanceTupleWrapper> _parser = new MessageParser<StanceTupleWrapper>(() => new StanceTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private Stance item1_;

	private Stance item2_;

	public static MessageParser<StanceTupleWrapper> Parser => _parser;

	public Stance Item1
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

	public Stance Item2
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

	public StanceTupleWrapper()
	{
	}

	public StanceTupleWrapper(StanceTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public StanceTupleWrapper Clone()
	{
		return new StanceTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as StanceTupleWrapper);
	}

	public bool Equals(StanceTupleWrapper other)
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
		if (Item1 != Stance.Heavy)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != Stance.Heavy)
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
		if (Item1 != Stance.Heavy)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != Stance.Heavy)
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
		if (Item1 != Stance.Heavy)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != Stance.Heavy)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(StanceTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != Stance.Heavy)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != Stance.Heavy)
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
				Item1 = (Stance)input.ReadEnum();
				break;
			case 16u:
				Item2 = (Stance)input.ReadEnum();
				break;
			}
		}
	}
}
