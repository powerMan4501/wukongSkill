using System;
using Google.Protobuf;

namespace X2.Base;

public sealed class CardRaceTypeTupleWrapper : IMessage<CardRaceTypeTupleWrapper>, IMessage, IEquatable<CardRaceTypeTupleWrapper>, IDeepCloneable<CardRaceTypeTupleWrapper>
{
	private static readonly MessageParser<CardRaceTypeTupleWrapper> _parser = new MessageParser<CardRaceTypeTupleWrapper>(() => new CardRaceTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private CardRaceType item1_;

	private CardRaceType item2_;

	public static MessageParser<CardRaceTypeTupleWrapper> Parser => _parser;

	public CardRaceType Item1
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

	public CardRaceType Item2
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

	public CardRaceTypeTupleWrapper()
	{
	}

	public CardRaceTypeTupleWrapper(CardRaceTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CardRaceTypeTupleWrapper Clone()
	{
		return new CardRaceTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CardRaceTypeTupleWrapper);
	}

	public bool Equals(CardRaceTypeTupleWrapper other)
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
		if (Item1 != CardRaceType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != CardRaceType.None)
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
		if (Item1 != CardRaceType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != CardRaceType.None)
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
		if (Item1 != CardRaceType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != CardRaceType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CardRaceTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != CardRaceType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != CardRaceType.None)
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
				Item1 = (CardRaceType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (CardRaceType)input.ReadEnum();
				break;
			}
		}
	}
}
