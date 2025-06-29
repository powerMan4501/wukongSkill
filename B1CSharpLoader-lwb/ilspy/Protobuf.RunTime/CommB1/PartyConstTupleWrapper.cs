using System;
using Google.Protobuf;

namespace CommB1;

public sealed class PartyConstTupleWrapper : IMessage<PartyConstTupleWrapper>, IMessage, IEquatable<PartyConstTupleWrapper>, IDeepCloneable<PartyConstTupleWrapper>
{
	private static readonly MessageParser<PartyConstTupleWrapper> _parser = new MessageParser<PartyConstTupleWrapper>(() => new PartyConstTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private PartyConst item1_;

	private PartyConst item2_;

	public static MessageParser<PartyConstTupleWrapper> Parser => _parser;

	public PartyConst Item1
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

	public PartyConst Item2
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

	public PartyConstTupleWrapper()
	{
	}

	public PartyConstTupleWrapper(PartyConstTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartyConstTupleWrapper Clone()
	{
		return new PartyConstTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartyConstTupleWrapper);
	}

	public bool Equals(PartyConstTupleWrapper other)
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
		if (Item1 != PartyConst.Default)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != PartyConst.Default)
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
		if (Item1 != PartyConst.Default)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != PartyConst.Default)
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
		if (Item1 != PartyConst.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != PartyConst.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PartyConstTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != PartyConst.Default)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != PartyConst.Default)
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
				Item1 = (PartyConst)input.ReadEnum();
				break;
			case 16u:
				Item2 = (PartyConst)input.ReadEnum();
				break;
			}
		}
	}
}
