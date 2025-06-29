using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class ESkillCooldownTypeTupleWrapper : IMessage<ESkillCooldownTypeTupleWrapper>, IMessage, IEquatable<ESkillCooldownTypeTupleWrapper>, IDeepCloneable<ESkillCooldownTypeTupleWrapper>
{
	private static readonly MessageParser<ESkillCooldownTypeTupleWrapper> _parser = new MessageParser<ESkillCooldownTypeTupleWrapper>(() => new ESkillCooldownTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ESkillCooldownType item1_;

	private ESkillCooldownType item2_;

	public static MessageParser<ESkillCooldownTypeTupleWrapper> Parser => _parser;

	public ESkillCooldownType Item1
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

	public ESkillCooldownType Item2
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

	public ESkillCooldownTypeTupleWrapper()
	{
	}

	public ESkillCooldownTypeTupleWrapper(ESkillCooldownTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ESkillCooldownTypeTupleWrapper Clone()
	{
		return new ESkillCooldownTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ESkillCooldownTypeTupleWrapper);
	}

	public bool Equals(ESkillCooldownTypeTupleWrapper other)
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
		if (Item1 != ESkillCooldownType.TryToCast)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ESkillCooldownType.TryToCast)
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
		if (Item1 != ESkillCooldownType.TryToCast)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ESkillCooldownType.TryToCast)
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
		if (Item1 != ESkillCooldownType.TryToCast)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ESkillCooldownType.TryToCast)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ESkillCooldownTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ESkillCooldownType.TryToCast)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ESkillCooldownType.TryToCast)
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
				Item1 = (ESkillCooldownType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ESkillCooldownType)input.ReadEnum();
				break;
			}
		}
	}
}
