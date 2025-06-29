using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EEffectRangeCenterTypeTupleWrapper : IMessage<EEffectRangeCenterTypeTupleWrapper>, IMessage, IEquatable<EEffectRangeCenterTypeTupleWrapper>, IDeepCloneable<EEffectRangeCenterTypeTupleWrapper>
{
	private static readonly MessageParser<EEffectRangeCenterTypeTupleWrapper> _parser = new MessageParser<EEffectRangeCenterTypeTupleWrapper>(() => new EEffectRangeCenterTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EEffectRangeCenterType item1_;

	private EEffectRangeCenterType item2_;

	public static MessageParser<EEffectRangeCenterTypeTupleWrapper> Parser => _parser;

	public EEffectRangeCenterType Item1
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

	public EEffectRangeCenterType Item2
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

	public EEffectRangeCenterTypeTupleWrapper()
	{
	}

	public EEffectRangeCenterTypeTupleWrapper(EEffectRangeCenterTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EEffectRangeCenterTypeTupleWrapper Clone()
	{
		return new EEffectRangeCenterTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EEffectRangeCenterTypeTupleWrapper);
	}

	public bool Equals(EEffectRangeCenterTypeTupleWrapper other)
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
		if (Item1 != EEffectRangeCenterType.ActorPosition)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EEffectRangeCenterType.ActorPosition)
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
		if (Item1 != EEffectRangeCenterType.ActorPosition)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EEffectRangeCenterType.ActorPosition)
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
		if (Item1 != EEffectRangeCenterType.ActorPosition)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EEffectRangeCenterType.ActorPosition)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EEffectRangeCenterTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EEffectRangeCenterType.ActorPosition)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EEffectRangeCenterType.ActorPosition)
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
				Item1 = (EEffectRangeCenterType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EEffectRangeCenterType)input.ReadEnum();
				break;
			}
		}
	}
}
