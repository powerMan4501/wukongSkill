using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class ESkillDamageTypeTupleWrapper : IMessage<ESkillDamageTypeTupleWrapper>, IMessage, IEquatable<ESkillDamageTypeTupleWrapper>, IDeepCloneable<ESkillDamageTypeTupleWrapper>
{
	private static readonly MessageParser<ESkillDamageTypeTupleWrapper> _parser = new MessageParser<ESkillDamageTypeTupleWrapper>(() => new ESkillDamageTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ESkillDamageType item1_;

	private ESkillDamageType item2_;

	public static MessageParser<ESkillDamageTypeTupleWrapper> Parser => _parser;

	public ESkillDamageType Item1
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

	public ESkillDamageType Item2
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

	public ESkillDamageTypeTupleWrapper()
	{
	}

	public ESkillDamageTypeTupleWrapper(ESkillDamageTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ESkillDamageTypeTupleWrapper Clone()
	{
		return new ESkillDamageTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ESkillDamageTypeTupleWrapper);
	}

	public bool Equals(ESkillDamageTypeTupleWrapper other)
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
		if (Item1 != ESkillDamageType.NoneEffectAtk)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ESkillDamageType.NoneEffectAtk)
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
		if (Item1 != ESkillDamageType.NoneEffectAtk)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ESkillDamageType.NoneEffectAtk)
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
		if (Item1 != ESkillDamageType.NoneEffectAtk)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ESkillDamageType.NoneEffectAtk)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ESkillDamageTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ESkillDamageType.NoneEffectAtk)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ESkillDamageType.NoneEffectAtk)
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
				Item1 = (ESkillDamageType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ESkillDamageType)input.ReadEnum();
				break;
			}
		}
	}
}
