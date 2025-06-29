using System;
using Google.Protobuf;

namespace ResB1;

public sealed class EGoreEffectTypeTupleWrapper : IMessage<EGoreEffectTypeTupleWrapper>, IMessage, IEquatable<EGoreEffectTypeTupleWrapper>, IDeepCloneable<EGoreEffectTypeTupleWrapper>
{
	private static readonly MessageParser<EGoreEffectTypeTupleWrapper> _parser = new MessageParser<EGoreEffectTypeTupleWrapper>(() => new EGoreEffectTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EGoreEffectType item1_;

	private EGoreEffectType item2_;

	public static MessageParser<EGoreEffectTypeTupleWrapper> Parser => _parser;

	public EGoreEffectType Item1
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

	public EGoreEffectType Item2
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

	public EGoreEffectTypeTupleWrapper()
	{
	}

	public EGoreEffectTypeTupleWrapper(EGoreEffectTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EGoreEffectTypeTupleWrapper Clone()
	{
		return new EGoreEffectTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EGoreEffectTypeTupleWrapper);
	}

	public bool Equals(EGoreEffectTypeTupleWrapper other)
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
		if (Item1 != EGoreEffectType.Close)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EGoreEffectType.Close)
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
		if (Item1 != EGoreEffectType.Close)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EGoreEffectType.Close)
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
		if (Item1 != EGoreEffectType.Close)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EGoreEffectType.Close)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EGoreEffectTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EGoreEffectType.Close)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EGoreEffectType.Close)
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
				Item1 = (EGoreEffectType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EGoreEffectType)input.ReadEnum();
				break;
			}
		}
	}
}
