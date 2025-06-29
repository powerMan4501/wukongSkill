using System;
using Google.Protobuf;

namespace CommB1;

public sealed class PartyTaskUpdateTypeTupleWrapper : IMessage<PartyTaskUpdateTypeTupleWrapper>, IMessage, IEquatable<PartyTaskUpdateTypeTupleWrapper>, IDeepCloneable<PartyTaskUpdateTypeTupleWrapper>
{
	private static readonly MessageParser<PartyTaskUpdateTypeTupleWrapper> _parser = new MessageParser<PartyTaskUpdateTypeTupleWrapper>(() => new PartyTaskUpdateTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private PartyTaskUpdateType item1_;

	private PartyTaskUpdateType item2_;

	public static MessageParser<PartyTaskUpdateTypeTupleWrapper> Parser => _parser;

	public PartyTaskUpdateType Item1
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

	public PartyTaskUpdateType Item2
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

	public PartyTaskUpdateTypeTupleWrapper()
	{
	}

	public PartyTaskUpdateTypeTupleWrapper(PartyTaskUpdateTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartyTaskUpdateTypeTupleWrapper Clone()
	{
		return new PartyTaskUpdateTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartyTaskUpdateTypeTupleWrapper);
	}

	public bool Equals(PartyTaskUpdateTypeTupleWrapper other)
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
		if (Item1 != PartyTaskUpdateType.Default)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != PartyTaskUpdateType.Default)
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
		if (Item1 != PartyTaskUpdateType.Default)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != PartyTaskUpdateType.Default)
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
		if (Item1 != PartyTaskUpdateType.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != PartyTaskUpdateType.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PartyTaskUpdateTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != PartyTaskUpdateType.Default)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != PartyTaskUpdateType.Default)
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
				Item1 = (PartyTaskUpdateType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (PartyTaskUpdateType)input.ReadEnum();
				break;
			}
		}
	}
}
