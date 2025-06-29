using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class ESkillMappingConditionTypeTupleWrapper : IMessage<ESkillMappingConditionTypeTupleWrapper>, IMessage, IEquatable<ESkillMappingConditionTypeTupleWrapper>, IDeepCloneable<ESkillMappingConditionTypeTupleWrapper>
{
	private static readonly MessageParser<ESkillMappingConditionTypeTupleWrapper> _parser = new MessageParser<ESkillMappingConditionTypeTupleWrapper>(() => new ESkillMappingConditionTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ESkillMappingConditionType item1_;

	private ESkillMappingConditionType item2_;

	public static MessageParser<ESkillMappingConditionTypeTupleWrapper> Parser => _parser;

	public ESkillMappingConditionType Item1
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

	public ESkillMappingConditionType Item2
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

	public ESkillMappingConditionTypeTupleWrapper()
	{
	}

	public ESkillMappingConditionTypeTupleWrapper(ESkillMappingConditionTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ESkillMappingConditionTypeTupleWrapper Clone()
	{
		return new ESkillMappingConditionTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ESkillMappingConditionTypeTupleWrapper);
	}

	public bool Equals(ESkillMappingConditionTypeTupleWrapper other)
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
		if (Item1 != ESkillMappingConditionType.Any)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ESkillMappingConditionType.Any)
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
		if (Item1 != ESkillMappingConditionType.Any)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ESkillMappingConditionType.Any)
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
		if (Item1 != ESkillMappingConditionType.Any)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ESkillMappingConditionType.Any)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ESkillMappingConditionTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ESkillMappingConditionType.Any)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ESkillMappingConditionType.Any)
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
				Item1 = (ESkillMappingConditionType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ESkillMappingConditionType)input.ReadEnum();
				break;
			}
		}
	}
}
