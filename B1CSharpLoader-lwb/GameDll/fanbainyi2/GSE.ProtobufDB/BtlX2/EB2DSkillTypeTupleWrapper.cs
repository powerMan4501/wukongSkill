using System;
using Google.Protobuf;

namespace BtlX2;

public sealed class EB2DSkillTypeTupleWrapper : IMessage<EB2DSkillTypeTupleWrapper>, IMessage, IEquatable<EB2DSkillTypeTupleWrapper>, IDeepCloneable<EB2DSkillTypeTupleWrapper>
{
	private static readonly MessageParser<EB2DSkillTypeTupleWrapper> _parser = new MessageParser<EB2DSkillTypeTupleWrapper>(() => new EB2DSkillTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EB2DSkillType item1_;

	private EB2DSkillType item2_;

	public static MessageParser<EB2DSkillTypeTupleWrapper> Parser => _parser;

	public EB2DSkillType Item1
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

	public EB2DSkillType Item2
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

	public EB2DSkillTypeTupleWrapper()
	{
	}

	public EB2DSkillTypeTupleWrapper(EB2DSkillTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EB2DSkillTypeTupleWrapper Clone()
	{
		return new EB2DSkillTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EB2DSkillTypeTupleWrapper);
	}

	public bool Equals(EB2DSkillTypeTupleWrapper other)
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
		if (Item1 != EB2DSkillType.Normal)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EB2DSkillType.Normal)
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
		if (Item1 != EB2DSkillType.Normal)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EB2DSkillType.Normal)
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
		if (Item1 != EB2DSkillType.Normal)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EB2DSkillType.Normal)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EB2DSkillTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EB2DSkillType.Normal)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EB2DSkillType.Normal)
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
				Item1 = (EB2DSkillType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EB2DSkillType)input.ReadEnum();
				break;
			}
		}
	}
}
