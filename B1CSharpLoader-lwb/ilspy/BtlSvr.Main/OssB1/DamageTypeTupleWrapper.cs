using System;
using Google.Protobuf;

namespace OssB1;

public sealed class DamageTypeTupleWrapper : IMessage<DamageTypeTupleWrapper>, IMessage, IEquatable<DamageTypeTupleWrapper>, IDeepCloneable<DamageTypeTupleWrapper>
{
	private static readonly MessageParser<DamageTypeTupleWrapper> _parser = new MessageParser<DamageTypeTupleWrapper>(() => new DamageTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private DamageType item1_;

	private DamageType item2_;

	public static MessageParser<DamageTypeTupleWrapper> Parser => _parser;

	public DamageType Item1
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

	public DamageType Item2
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

	public DamageTypeTupleWrapper()
	{
	}

	public DamageTypeTupleWrapper(DamageTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DamageTypeTupleWrapper Clone()
	{
		return new DamageTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DamageTypeTupleWrapper);
	}

	public bool Equals(DamageTypeTupleWrapper other)
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
		if (Item1 != DamageType.Skill)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != DamageType.Skill)
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
		if (Item1 != DamageType.Skill)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != DamageType.Skill)
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
		if (Item1 != DamageType.Skill)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != DamageType.Skill)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DamageTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != DamageType.Skill)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != DamageType.Skill)
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
				Item1 = (DamageType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (DamageType)input.ReadEnum();
				break;
			}
		}
	}
}
