using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EBuffRuleTypeTupleWrapper : IMessage<EBuffRuleTypeTupleWrapper>, IMessage, IEquatable<EBuffRuleTypeTupleWrapper>, IDeepCloneable<EBuffRuleTypeTupleWrapper>
{
	private static readonly MessageParser<EBuffRuleTypeTupleWrapper> _parser = new MessageParser<EBuffRuleTypeTupleWrapper>(() => new EBuffRuleTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EBuffRuleType item1_;

	private EBuffRuleType item2_;

	public static MessageParser<EBuffRuleTypeTupleWrapper> Parser => _parser;

	public EBuffRuleType Item1
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

	public EBuffRuleType Item2
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

	public EBuffRuleTypeTupleWrapper()
	{
	}

	public EBuffRuleTypeTupleWrapper(EBuffRuleTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EBuffRuleTypeTupleWrapper Clone()
	{
		return new EBuffRuleTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EBuffRuleTypeTupleWrapper);
	}

	public bool Equals(EBuffRuleTypeTupleWrapper other)
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
		if (Item1 != EBuffRuleType.BuffRuleNone)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EBuffRuleType.BuffRuleNone)
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
		if (Item1 != EBuffRuleType.BuffRuleNone)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EBuffRuleType.BuffRuleNone)
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
		if (Item1 != EBuffRuleType.BuffRuleNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EBuffRuleType.BuffRuleNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EBuffRuleTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EBuffRuleType.BuffRuleNone)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EBuffRuleType.BuffRuleNone)
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
				Item1 = (EBuffRuleType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EBuffRuleType)input.ReadEnum();
				break;
			}
		}
	}
}
