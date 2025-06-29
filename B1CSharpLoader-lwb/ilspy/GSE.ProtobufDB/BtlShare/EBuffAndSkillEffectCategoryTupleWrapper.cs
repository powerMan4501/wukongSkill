using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EBuffAndSkillEffectCategoryTupleWrapper : IMessage<EBuffAndSkillEffectCategoryTupleWrapper>, IMessage, IEquatable<EBuffAndSkillEffectCategoryTupleWrapper>, IDeepCloneable<EBuffAndSkillEffectCategoryTupleWrapper>
{
	private static readonly MessageParser<EBuffAndSkillEffectCategoryTupleWrapper> _parser = new MessageParser<EBuffAndSkillEffectCategoryTupleWrapper>(() => new EBuffAndSkillEffectCategoryTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EBuffAndSkillEffectCategory item1_;

	private EBuffAndSkillEffectCategory item2_;

	public static MessageParser<EBuffAndSkillEffectCategoryTupleWrapper> Parser => _parser;

	public EBuffAndSkillEffectCategory Item1
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

	public EBuffAndSkillEffectCategory Item2
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

	public EBuffAndSkillEffectCategoryTupleWrapper()
	{
	}

	public EBuffAndSkillEffectCategoryTupleWrapper(EBuffAndSkillEffectCategoryTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EBuffAndSkillEffectCategoryTupleWrapper Clone()
	{
		return new EBuffAndSkillEffectCategoryTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EBuffAndSkillEffectCategoryTupleWrapper);
	}

	public bool Equals(EBuffAndSkillEffectCategoryTupleWrapper other)
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
		if (Item1 != EBuffAndSkillEffectCategory.Neutral)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EBuffAndSkillEffectCategory.Neutral)
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
		if (Item1 != EBuffAndSkillEffectCategory.Neutral)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EBuffAndSkillEffectCategory.Neutral)
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
		if (Item1 != EBuffAndSkillEffectCategory.Neutral)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EBuffAndSkillEffectCategory.Neutral)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EBuffAndSkillEffectCategoryTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EBuffAndSkillEffectCategory.Neutral)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EBuffAndSkillEffectCategory.Neutral)
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
				Item1 = (EBuffAndSkillEffectCategory)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EBuffAndSkillEffectCategory)input.ReadEnum();
				break;
			}
		}
	}
}
