using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EGSBuffAndSkillEffectActiveConditionTupleWrapper : IMessage<EGSBuffAndSkillEffectActiveConditionTupleWrapper>, IMessage, IEquatable<EGSBuffAndSkillEffectActiveConditionTupleWrapper>, IDeepCloneable<EGSBuffAndSkillEffectActiveConditionTupleWrapper>
{
	private static readonly MessageParser<EGSBuffAndSkillEffectActiveConditionTupleWrapper> _parser = new MessageParser<EGSBuffAndSkillEffectActiveConditionTupleWrapper>(() => new EGSBuffAndSkillEffectActiveConditionTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EGSBuffAndSkillEffectActiveCondition item1_;

	private EGSBuffAndSkillEffectActiveCondition item2_;

	public static MessageParser<EGSBuffAndSkillEffectActiveConditionTupleWrapper> Parser => _parser;

	public EGSBuffAndSkillEffectActiveCondition Item1
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

	public EGSBuffAndSkillEffectActiveCondition Item2
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

	public EGSBuffAndSkillEffectActiveConditionTupleWrapper()
	{
	}

	public EGSBuffAndSkillEffectActiveConditionTupleWrapper(EGSBuffAndSkillEffectActiveConditionTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EGSBuffAndSkillEffectActiveConditionTupleWrapper Clone()
	{
		return new EGSBuffAndSkillEffectActiveConditionTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EGSBuffAndSkillEffectActiveConditionTupleWrapper);
	}

	public bool Equals(EGSBuffAndSkillEffectActiveConditionTupleWrapper other)
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
		if (Item1 != EGSBuffAndSkillEffectActiveCondition.Always)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EGSBuffAndSkillEffectActiveCondition.Always)
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
		if (Item1 != EGSBuffAndSkillEffectActiveCondition.Always)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EGSBuffAndSkillEffectActiveCondition.Always)
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
		if (Item1 != EGSBuffAndSkillEffectActiveCondition.Always)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EGSBuffAndSkillEffectActiveCondition.Always)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EGSBuffAndSkillEffectActiveConditionTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EGSBuffAndSkillEffectActiveCondition.Always)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EGSBuffAndSkillEffectActiveCondition.Always)
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
				Item1 = (EGSBuffAndSkillEffectActiveCondition)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EGSBuffAndSkillEffectActiveCondition)input.ReadEnum();
				break;
			}
		}
	}
}
