using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class ESkillMappingResultRullTupleWrapper : IMessage<ESkillMappingResultRullTupleWrapper>, IMessage, IEquatable<ESkillMappingResultRullTupleWrapper>, IDeepCloneable<ESkillMappingResultRullTupleWrapper>
{
	private static readonly MessageParser<ESkillMappingResultRullTupleWrapper> _parser = new MessageParser<ESkillMappingResultRullTupleWrapper>(() => new ESkillMappingResultRullTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ESkillMappingResultRull item1_;

	private ESkillMappingResultRull item2_;

	public static MessageParser<ESkillMappingResultRullTupleWrapper> Parser => _parser;

	public ESkillMappingResultRull Item1
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

	public ESkillMappingResultRull Item2
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

	public ESkillMappingResultRullTupleWrapper()
	{
	}

	public ESkillMappingResultRullTupleWrapper(ESkillMappingResultRullTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ESkillMappingResultRullTupleWrapper Clone()
	{
		return new ESkillMappingResultRullTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ESkillMappingResultRullTupleWrapper);
	}

	public bool Equals(ESkillMappingResultRullTupleWrapper other)
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
		if (Item1 != ESkillMappingResultRull.PseudoRandom)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ESkillMappingResultRull.PseudoRandom)
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
		if (Item1 != ESkillMappingResultRull.PseudoRandom)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ESkillMappingResultRull.PseudoRandom)
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
		if (Item1 != ESkillMappingResultRull.PseudoRandom)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ESkillMappingResultRull.PseudoRandom)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ESkillMappingResultRullTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ESkillMappingResultRull.PseudoRandom)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ESkillMappingResultRull.PseudoRandom)
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
				Item1 = (ESkillMappingResultRull)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ESkillMappingResultRull)input.ReadEnum();
				break;
			}
		}
	}
}
