using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class ESkillTypeTupleWrapper : IMessage<ESkillTypeTupleWrapper>, IMessage, IEquatable<ESkillTypeTupleWrapper>, IDeepCloneable<ESkillTypeTupleWrapper>
{
	private static readonly MessageParser<ESkillTypeTupleWrapper> _parser = new MessageParser<ESkillTypeTupleWrapper>(() => new ESkillTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ESkillType item1_;

	private ESkillType item2_;

	public static MessageParser<ESkillTypeTupleWrapper> Parser => _parser;

	public ESkillType Item1
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

	public ESkillType Item2
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

	public ESkillTypeTupleWrapper()
	{
	}

	public ESkillTypeTupleWrapper(ESkillTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ESkillTypeTupleWrapper Clone()
	{
		return new ESkillTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ESkillTypeTupleWrapper);
	}

	public bool Equals(ESkillTypeTupleWrapper other)
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
		if (Item1 != ESkillType.NormalSkill)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ESkillType.NormalSkill)
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
		if (Item1 != ESkillType.NormalSkill)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ESkillType.NormalSkill)
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
		if (Item1 != ESkillType.NormalSkill)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ESkillType.NormalSkill)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ESkillTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ESkillType.NormalSkill)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ESkillType.NormalSkill)
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
				Item1 = (ESkillType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ESkillType)input.ReadEnum();
				break;
			}
		}
	}
}
