using System;
using Google.Protobuf;

namespace ResB1;

public sealed class TipsTriggerTypeTupleWrapper : IMessage<TipsTriggerTypeTupleWrapper>, IMessage, IEquatable<TipsTriggerTypeTupleWrapper>, IDeepCloneable<TipsTriggerTypeTupleWrapper>
{
	private static readonly MessageParser<TipsTriggerTypeTupleWrapper> _parser = new MessageParser<TipsTriggerTypeTupleWrapper>(() => new TipsTriggerTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private TipsTriggerType item1_;

	private TipsTriggerType item2_;

	public static MessageParser<TipsTriggerTypeTupleWrapper> Parser => _parser;

	public TipsTriggerType Item1
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

	public TipsTriggerType Item2
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

	public TipsTriggerTypeTupleWrapper()
	{
	}

	public TipsTriggerTypeTupleWrapper(TipsTriggerTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TipsTriggerTypeTupleWrapper Clone()
	{
		return new TipsTriggerTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TipsTriggerTypeTupleWrapper);
	}

	public bool Equals(TipsTriggerTypeTupleWrapper other)
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
		if (Item1 != TipsTriggerType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != TipsTriggerType.None)
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
		if (Item1 != TipsTriggerType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != TipsTriggerType.None)
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
		if (Item1 != TipsTriggerType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != TipsTriggerType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TipsTriggerTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != TipsTriggerType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != TipsTriggerType.None)
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
				Item1 = (TipsTriggerType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (TipsTriggerType)input.ReadEnum();
				break;
			}
		}
	}
}
