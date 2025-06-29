using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class EModifyMethodTupleWrapper : IMessage<EModifyMethodTupleWrapper>, IMessage, IEquatable<EModifyMethodTupleWrapper>, IDeepCloneable<EModifyMethodTupleWrapper>
{
	private static readonly MessageParser<EModifyMethodTupleWrapper> _parser = new MessageParser<EModifyMethodTupleWrapper>(() => new EModifyMethodTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EModifyMethod item1_;

	private EModifyMethod item2_;

	public static MessageParser<EModifyMethodTupleWrapper> Parser => _parser;

	public EModifyMethod Item1
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

	public EModifyMethod Item2
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

	public EModifyMethodTupleWrapper()
	{
	}

	public EModifyMethodTupleWrapper(EModifyMethodTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EModifyMethodTupleWrapper Clone()
	{
		return new EModifyMethodTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EModifyMethodTupleWrapper);
	}

	public bool Equals(EModifyMethodTupleWrapper other)
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
		if (Item1 != EModifyMethod.SkillCooldown)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EModifyMethod.SkillCooldown)
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
		if (Item1 != EModifyMethod.SkillCooldown)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EModifyMethod.SkillCooldown)
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
		if (Item1 != EModifyMethod.SkillCooldown)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EModifyMethod.SkillCooldown)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EModifyMethodTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EModifyMethod.SkillCooldown)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EModifyMethod.SkillCooldown)
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
				Item1 = (EModifyMethod)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EModifyMethod)input.ReadEnum();
				break;
			}
		}
	}
}
