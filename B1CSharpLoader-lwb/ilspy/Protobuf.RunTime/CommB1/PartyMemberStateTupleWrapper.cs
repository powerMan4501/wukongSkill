using System;
using Google.Protobuf;

namespace CommB1;

public sealed class PartyMemberStateTupleWrapper : IMessage<PartyMemberStateTupleWrapper>, IMessage, IEquatable<PartyMemberStateTupleWrapper>, IDeepCloneable<PartyMemberStateTupleWrapper>
{
	private static readonly MessageParser<PartyMemberStateTupleWrapper> _parser = new MessageParser<PartyMemberStateTupleWrapper>(() => new PartyMemberStateTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private PartyMemberState item1_;

	private PartyMemberState item2_;

	public static MessageParser<PartyMemberStateTupleWrapper> Parser => _parser;

	public PartyMemberState Item1
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

	public PartyMemberState Item2
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

	public PartyMemberStateTupleWrapper()
	{
	}

	public PartyMemberStateTupleWrapper(PartyMemberStateTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartyMemberStateTupleWrapper Clone()
	{
		return new PartyMemberStateTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartyMemberStateTupleWrapper);
	}

	public bool Equals(PartyMemberStateTupleWrapper other)
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
		if (Item1 != PartyMemberState.Online)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != PartyMemberState.Online)
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
		if (Item1 != PartyMemberState.Online)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != PartyMemberState.Online)
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
		if (Item1 != PartyMemberState.Online)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != PartyMemberState.Online)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PartyMemberStateTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != PartyMemberState.Online)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != PartyMemberState.Online)
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
				Item1 = (PartyMemberState)input.ReadEnum();
				break;
			case 16u:
				Item2 = (PartyMemberState)input.ReadEnum();
				break;
			}
		}
	}
}
