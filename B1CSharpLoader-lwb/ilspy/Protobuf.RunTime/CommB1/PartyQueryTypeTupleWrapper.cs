using System;
using Google.Protobuf;

namespace CommB1;

public sealed class PartyQueryTypeTupleWrapper : IMessage<PartyQueryTypeTupleWrapper>, IMessage, IEquatable<PartyQueryTypeTupleWrapper>, IDeepCloneable<PartyQueryTypeTupleWrapper>
{
	private static readonly MessageParser<PartyQueryTypeTupleWrapper> _parser = new MessageParser<PartyQueryTypeTupleWrapper>(() => new PartyQueryTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private PartyQueryType item1_;

	private PartyQueryType item2_;

	public static MessageParser<PartyQueryTypeTupleWrapper> Parser => _parser;

	public PartyQueryType Item1
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

	public PartyQueryType Item2
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

	public PartyQueryTypeTupleWrapper()
	{
	}

	public PartyQueryTypeTupleWrapper(PartyQueryTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartyQueryTypeTupleWrapper Clone()
	{
		return new PartyQueryTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartyQueryTypeTupleWrapper);
	}

	public bool Equals(PartyQueryTypeTupleWrapper other)
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
		if (Item1 != PartyQueryType.Role)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != PartyQueryType.Role)
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
		if (Item1 != PartyQueryType.Role)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != PartyQueryType.Role)
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
		if (Item1 != PartyQueryType.Role)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != PartyQueryType.Role)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PartyQueryTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != PartyQueryType.Role)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != PartyQueryType.Role)
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
				Item1 = (PartyQueryType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (PartyQueryType)input.ReadEnum();
				break;
			}
		}
	}
}
