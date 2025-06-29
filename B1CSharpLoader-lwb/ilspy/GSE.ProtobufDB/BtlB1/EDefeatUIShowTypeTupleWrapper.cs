using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class EDefeatUIShowTypeTupleWrapper : IMessage<EDefeatUIShowTypeTupleWrapper>, IMessage, IEquatable<EDefeatUIShowTypeTupleWrapper>, IDeepCloneable<EDefeatUIShowTypeTupleWrapper>
{
	private static readonly MessageParser<EDefeatUIShowTypeTupleWrapper> _parser = new MessageParser<EDefeatUIShowTypeTupleWrapper>(() => new EDefeatUIShowTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EDefeatUIShowType item1_;

	private EDefeatUIShowType item2_;

	public static MessageParser<EDefeatUIShowTypeTupleWrapper> Parser => _parser;

	public EDefeatUIShowType Item1
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

	public EDefeatUIShowType Item2
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

	public EDefeatUIShowTypeTupleWrapper()
	{
	}

	public EDefeatUIShowTypeTupleWrapper(EDefeatUIShowTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EDefeatUIShowTypeTupleWrapper Clone()
	{
		return new EDefeatUIShowTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EDefeatUIShowTypeTupleWrapper);
	}

	public bool Equals(EDefeatUIShowTypeTupleWrapper other)
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
		if (Item1 != EDefeatUIShowType.Defeat)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EDefeatUIShowType.Defeat)
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
		if (Item1 != EDefeatUIShowType.Defeat)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EDefeatUIShowType.Defeat)
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
		if (Item1 != EDefeatUIShowType.Defeat)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EDefeatUIShowType.Defeat)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EDefeatUIShowTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EDefeatUIShowType.Defeat)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EDefeatUIShowType.Defeat)
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
				Item1 = (EDefeatUIShowType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EDefeatUIShowType)input.ReadEnum();
				break;
			}
		}
	}
}
