using System;
using Google.Protobuf;

namespace ResB1;

public sealed class ConsumeEffectTypeTupleWrapper : IMessage<ConsumeEffectTypeTupleWrapper>, IMessage, IEquatable<ConsumeEffectTypeTupleWrapper>, IDeepCloneable<ConsumeEffectTypeTupleWrapper>
{
	private static readonly MessageParser<ConsumeEffectTypeTupleWrapper> _parser = new MessageParser<ConsumeEffectTypeTupleWrapper>(() => new ConsumeEffectTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ConsumeEffectType item1_;

	private ConsumeEffectType item2_;

	public static MessageParser<ConsumeEffectTypeTupleWrapper> Parser => _parser;

	public ConsumeEffectType Item1
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

	public ConsumeEffectType Item2
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

	public ConsumeEffectTypeTupleWrapper()
	{
	}

	public ConsumeEffectTypeTupleWrapper(ConsumeEffectTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ConsumeEffectTypeTupleWrapper Clone()
	{
		return new ConsumeEffectTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ConsumeEffectTypeTupleWrapper);
	}

	public bool Equals(ConsumeEffectTypeTupleWrapper other)
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
		if (Item1 != ConsumeEffectType.Buff)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ConsumeEffectType.Buff)
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
		if (Item1 != ConsumeEffectType.Buff)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ConsumeEffectType.Buff)
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
		if (Item1 != ConsumeEffectType.Buff)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ConsumeEffectType.Buff)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ConsumeEffectTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ConsumeEffectType.Buff)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ConsumeEffectType.Buff)
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
				Item1 = (ConsumeEffectType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ConsumeEffectType)input.ReadEnum();
				break;
			}
		}
	}
}
