using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EBuffEffectTargetSelectTypeTupleWrapper : IMessage<EBuffEffectTargetSelectTypeTupleWrapper>, IMessage, IEquatable<EBuffEffectTargetSelectTypeTupleWrapper>, IDeepCloneable<EBuffEffectTargetSelectTypeTupleWrapper>
{
	private static readonly MessageParser<EBuffEffectTargetSelectTypeTupleWrapper> _parser = new MessageParser<EBuffEffectTargetSelectTypeTupleWrapper>(() => new EBuffEffectTargetSelectTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EBuffEffectTargetSelectType item1_;

	private EBuffEffectTargetSelectType item2_;

	public static MessageParser<EBuffEffectTargetSelectTypeTupleWrapper> Parser => _parser;

	public EBuffEffectTargetSelectType Item1
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

	public EBuffEffectTargetSelectType Item2
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

	public EBuffEffectTargetSelectTypeTupleWrapper()
	{
	}

	public EBuffEffectTargetSelectTypeTupleWrapper(EBuffEffectTargetSelectTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EBuffEffectTargetSelectTypeTupleWrapper Clone()
	{
		return new EBuffEffectTargetSelectTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EBuffEffectTargetSelectTypeTupleWrapper);
	}

	public bool Equals(EBuffEffectTargetSelectTypeTupleWrapper other)
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
		if (Item1 != EBuffEffectTargetSelectType.BuffTarget)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EBuffEffectTargetSelectType.BuffTarget)
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
		if (Item1 != EBuffEffectTargetSelectType.BuffTarget)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EBuffEffectTargetSelectType.BuffTarget)
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
		if (Item1 != EBuffEffectTargetSelectType.BuffTarget)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EBuffEffectTargetSelectType.BuffTarget)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EBuffEffectTargetSelectTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EBuffEffectTargetSelectType.BuffTarget)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EBuffEffectTargetSelectType.BuffTarget)
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
				Item1 = (EBuffEffectTargetSelectType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EBuffEffectTargetSelectType)input.ReadEnum();
				break;
			}
		}
	}
}
