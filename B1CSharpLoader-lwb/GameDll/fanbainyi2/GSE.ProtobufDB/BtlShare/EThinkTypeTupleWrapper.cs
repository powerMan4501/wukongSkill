using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EThinkTypeTupleWrapper : IMessage<EThinkTypeTupleWrapper>, IMessage, IEquatable<EThinkTypeTupleWrapper>, IDeepCloneable<EThinkTypeTupleWrapper>
{
	private static readonly MessageParser<EThinkTypeTupleWrapper> _parser = new MessageParser<EThinkTypeTupleWrapper>(() => new EThinkTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EThinkType item1_;

	private EThinkType item2_;

	public static MessageParser<EThinkTypeTupleWrapper> Parser => _parser;

	public EThinkType Item1
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

	public EThinkType Item2
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

	public EThinkTypeTupleWrapper()
	{
	}

	public EThinkTypeTupleWrapper(EThinkTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EThinkTypeTupleWrapper Clone()
	{
		return new EThinkTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EThinkTypeTupleWrapper);
	}

	public bool Equals(EThinkTypeTupleWrapper other)
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
		if (Item1 != EThinkType.CircleThink)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EThinkType.CircleThink)
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
		if (Item1 != EThinkType.CircleThink)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EThinkType.CircleThink)
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
		if (Item1 != EThinkType.CircleThink)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EThinkType.CircleThink)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EThinkTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EThinkType.CircleThink)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EThinkType.CircleThink)
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
				Item1 = (EThinkType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EThinkType)input.ReadEnum();
				break;
			}
		}
	}
}
