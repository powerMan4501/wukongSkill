using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class ESkillBaseTargetTupleWrapper : IMessage<ESkillBaseTargetTupleWrapper>, IMessage, IEquatable<ESkillBaseTargetTupleWrapper>, IDeepCloneable<ESkillBaseTargetTupleWrapper>
{
	private static readonly MessageParser<ESkillBaseTargetTupleWrapper> _parser = new MessageParser<ESkillBaseTargetTupleWrapper>(() => new ESkillBaseTargetTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ESkillBaseTarget item1_;

	private ESkillBaseTarget item2_;

	public static MessageParser<ESkillBaseTargetTupleWrapper> Parser => _parser;

	public ESkillBaseTarget Item1
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

	public ESkillBaseTarget Item2
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

	public ESkillBaseTargetTupleWrapper()
	{
	}

	public ESkillBaseTargetTupleWrapper(ESkillBaseTargetTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ESkillBaseTargetTupleWrapper Clone()
	{
		return new ESkillBaseTargetTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ESkillBaseTargetTupleWrapper);
	}

	public bool Equals(ESkillBaseTargetTupleWrapper other)
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
		if (Item1 != ESkillBaseTarget.NoneOrCurrenttarget)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ESkillBaseTarget.NoneOrCurrenttarget)
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
		if (Item1 != ESkillBaseTarget.NoneOrCurrenttarget)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ESkillBaseTarget.NoneOrCurrenttarget)
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
		if (Item1 != ESkillBaseTarget.NoneOrCurrenttarget)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ESkillBaseTarget.NoneOrCurrenttarget)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ESkillBaseTargetTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ESkillBaseTarget.NoneOrCurrenttarget)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ESkillBaseTarget.NoneOrCurrenttarget)
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
				Item1 = (ESkillBaseTarget)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ESkillBaseTarget)input.ReadEnum();
				break;
			}
		}
	}
}
