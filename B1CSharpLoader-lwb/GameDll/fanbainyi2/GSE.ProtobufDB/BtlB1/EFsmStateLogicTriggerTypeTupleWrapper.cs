using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class EFsmStateLogicTriggerTypeTupleWrapper : IMessage<EFsmStateLogicTriggerTypeTupleWrapper>, IMessage, IEquatable<EFsmStateLogicTriggerTypeTupleWrapper>, IDeepCloneable<EFsmStateLogicTriggerTypeTupleWrapper>
{
	private static readonly MessageParser<EFsmStateLogicTriggerTypeTupleWrapper> _parser = new MessageParser<EFsmStateLogicTriggerTypeTupleWrapper>(() => new EFsmStateLogicTriggerTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EFsmStateLogicTriggerType item1_;

	private EFsmStateLogicTriggerType item2_;

	public static MessageParser<EFsmStateLogicTriggerTypeTupleWrapper> Parser => _parser;

	public EFsmStateLogicTriggerType Item1
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

	public EFsmStateLogicTriggerType Item2
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

	public EFsmStateLogicTriggerTypeTupleWrapper()
	{
	}

	public EFsmStateLogicTriggerTypeTupleWrapper(EFsmStateLogicTriggerTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EFsmStateLogicTriggerTypeTupleWrapper Clone()
	{
		return new EFsmStateLogicTriggerTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EFsmStateLogicTriggerTypeTupleWrapper);
	}

	public bool Equals(EFsmStateLogicTriggerTypeTupleWrapper other)
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
		if (Item1 != EFsmStateLogicTriggerType.Auto)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EFsmStateLogicTriggerType.Auto)
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
		if (Item1 != EFsmStateLogicTriggerType.Auto)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EFsmStateLogicTriggerType.Auto)
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
		if (Item1 != EFsmStateLogicTriggerType.Auto)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EFsmStateLogicTriggerType.Auto)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EFsmStateLogicTriggerTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EFsmStateLogicTriggerType.Auto)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EFsmStateLogicTriggerType.Auto)
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
				Item1 = (EFsmStateLogicTriggerType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EFsmStateLogicTriggerType)input.ReadEnum();
				break;
			}
		}
	}
}
