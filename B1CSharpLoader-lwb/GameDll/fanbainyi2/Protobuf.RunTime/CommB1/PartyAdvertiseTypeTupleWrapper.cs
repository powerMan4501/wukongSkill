using System;
using Google.Protobuf;

namespace CommB1;

public sealed class PartyAdvertiseTypeTupleWrapper : IMessage<PartyAdvertiseTypeTupleWrapper>, IMessage, IEquatable<PartyAdvertiseTypeTupleWrapper>, IDeepCloneable<PartyAdvertiseTypeTupleWrapper>
{
	private static readonly MessageParser<PartyAdvertiseTypeTupleWrapper> _parser = new MessageParser<PartyAdvertiseTypeTupleWrapper>(() => new PartyAdvertiseTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private PartyAdvertiseType item1_;

	private PartyAdvertiseType item2_;

	public static MessageParser<PartyAdvertiseTypeTupleWrapper> Parser => _parser;

	public PartyAdvertiseType Item1
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

	public PartyAdvertiseType Item2
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

	public PartyAdvertiseTypeTupleWrapper()
	{
	}

	public PartyAdvertiseTypeTupleWrapper(PartyAdvertiseTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartyAdvertiseTypeTupleWrapper Clone()
	{
		return new PartyAdvertiseTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartyAdvertiseTypeTupleWrapper);
	}

	public bool Equals(PartyAdvertiseTypeTupleWrapper other)
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
		if (Item1 != PartyAdvertiseType.Public)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != PartyAdvertiseType.Public)
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
		if (Item1 != PartyAdvertiseType.Public)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != PartyAdvertiseType.Public)
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
		if (Item1 != PartyAdvertiseType.Public)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != PartyAdvertiseType.Public)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PartyAdvertiseTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != PartyAdvertiseType.Public)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != PartyAdvertiseType.Public)
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
				Item1 = (PartyAdvertiseType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (PartyAdvertiseType)input.ReadEnum();
				break;
			}
		}
	}
}
