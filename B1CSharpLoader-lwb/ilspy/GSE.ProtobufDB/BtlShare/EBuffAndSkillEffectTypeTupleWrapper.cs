using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EBuffAndSkillEffectTypeTupleWrapper : IMessage<EBuffAndSkillEffectTypeTupleWrapper>, IMessage, IEquatable<EBuffAndSkillEffectTypeTupleWrapper>, IDeepCloneable<EBuffAndSkillEffectTypeTupleWrapper>
{
	private static readonly MessageParser<EBuffAndSkillEffectTypeTupleWrapper> _parser = new MessageParser<EBuffAndSkillEffectTypeTupleWrapper>(() => new EBuffAndSkillEffectTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EBuffAndSkillEffectType item1_;

	private EBuffAndSkillEffectType item2_;

	public static MessageParser<EBuffAndSkillEffectTypeTupleWrapper> Parser => _parser;

	public EBuffAndSkillEffectType Item1
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

	public EBuffAndSkillEffectType Item2
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

	public EBuffAndSkillEffectTypeTupleWrapper()
	{
	}

	public EBuffAndSkillEffectTypeTupleWrapper(EBuffAndSkillEffectTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EBuffAndSkillEffectTypeTupleWrapper Clone()
	{
		return new EBuffAndSkillEffectTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EBuffAndSkillEffectTypeTupleWrapper);
	}

	public bool Equals(EBuffAndSkillEffectTypeTupleWrapper other)
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
		if (Item1 != EBuffAndSkillEffectType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EBuffAndSkillEffectType.None)
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
		if (Item1 != EBuffAndSkillEffectType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EBuffAndSkillEffectType.None)
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
		if (Item1 != EBuffAndSkillEffectType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EBuffAndSkillEffectType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EBuffAndSkillEffectTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EBuffAndSkillEffectType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EBuffAndSkillEffectType.None)
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
				Item1 = (EBuffAndSkillEffectType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EBuffAndSkillEffectType)input.ReadEnum();
				break;
			}
		}
	}
}
