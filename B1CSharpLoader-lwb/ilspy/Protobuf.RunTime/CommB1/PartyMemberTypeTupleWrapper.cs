using System;
using Google.Protobuf;

namespace CommB1;

public sealed class PartyMemberTypeTupleWrapper : IMessage<PartyMemberTypeTupleWrapper>, IMessage, IEquatable<PartyMemberTypeTupleWrapper>, IDeepCloneable<PartyMemberTypeTupleWrapper>
{
	private static readonly MessageParser<PartyMemberTypeTupleWrapper> _parser = new MessageParser<PartyMemberTypeTupleWrapper>(() => new PartyMemberTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private PartyMemberType item1_;

	private PartyMemberType item2_;

	public static MessageParser<PartyMemberTypeTupleWrapper> Parser => _parser;

	public PartyMemberType Item1
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

	public PartyMemberType Item2
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

	public PartyMemberTypeTupleWrapper()
	{
	}

	public PartyMemberTypeTupleWrapper(PartyMemberTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartyMemberTypeTupleWrapper Clone()
	{
		return new PartyMemberTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartyMemberTypeTupleWrapper);
	}

	public bool Equals(PartyMemberTypeTupleWrapper other)
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
		if (Item1 != PartyMemberType.Teammate)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != PartyMemberType.Teammate)
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
		if (Item1 != PartyMemberType.Teammate)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != PartyMemberType.Teammate)
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
		if (Item1 != PartyMemberType.Teammate)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != PartyMemberType.Teammate)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PartyMemberTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != PartyMemberType.Teammate)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != PartyMemberType.Teammate)
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
				Item1 = (PartyMemberType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (PartyMemberType)input.ReadEnum();
				break;
			}
		}
	}
}
