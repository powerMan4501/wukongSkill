using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EUnitAIAttackTypeTupleWrapper : IMessage<EUnitAIAttackTypeTupleWrapper>, IMessage, IEquatable<EUnitAIAttackTypeTupleWrapper>, IDeepCloneable<EUnitAIAttackTypeTupleWrapper>
{
	private static readonly MessageParser<EUnitAIAttackTypeTupleWrapper> _parser = new MessageParser<EUnitAIAttackTypeTupleWrapper>(() => new EUnitAIAttackTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EUnitAIAttackType item1_;

	private EUnitAIAttackType item2_;

	public static MessageParser<EUnitAIAttackTypeTupleWrapper> Parser => _parser;

	public EUnitAIAttackType Item1
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

	public EUnitAIAttackType Item2
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

	public EUnitAIAttackTypeTupleWrapper()
	{
	}

	public EUnitAIAttackTypeTupleWrapper(EUnitAIAttackTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EUnitAIAttackTypeTupleWrapper Clone()
	{
		return new EUnitAIAttackTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EUnitAIAttackTypeTupleWrapper);
	}

	public bool Equals(EUnitAIAttackTypeTupleWrapper other)
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
		if (Item1 != EUnitAIAttackType.ActiveAttack)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EUnitAIAttackType.ActiveAttack)
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
		if (Item1 != EUnitAIAttackType.ActiveAttack)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EUnitAIAttackType.ActiveAttack)
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
		if (Item1 != EUnitAIAttackType.ActiveAttack)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EUnitAIAttackType.ActiveAttack)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EUnitAIAttackTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EUnitAIAttackType.ActiveAttack)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EUnitAIAttackType.ActiveAttack)
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
				Item1 = (EUnitAIAttackType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EUnitAIAttackType)input.ReadEnum();
				break;
			}
		}
	}
}
