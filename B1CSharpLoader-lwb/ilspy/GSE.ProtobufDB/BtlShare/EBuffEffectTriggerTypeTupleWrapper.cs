using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EBuffEffectTriggerTypeTupleWrapper : IMessage<EBuffEffectTriggerTypeTupleWrapper>, IMessage, IEquatable<EBuffEffectTriggerTypeTupleWrapper>, IDeepCloneable<EBuffEffectTriggerTypeTupleWrapper>
{
	private static readonly MessageParser<EBuffEffectTriggerTypeTupleWrapper> _parser = new MessageParser<EBuffEffectTriggerTypeTupleWrapper>(() => new EBuffEffectTriggerTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EBuffEffectTriggerType item1_;

	private EBuffEffectTriggerType item2_;

	public static MessageParser<EBuffEffectTriggerTypeTupleWrapper> Parser => _parser;

	public EBuffEffectTriggerType Item1
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

	public EBuffEffectTriggerType Item2
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

	public EBuffEffectTriggerTypeTupleWrapper()
	{
	}

	public EBuffEffectTriggerTypeTupleWrapper(EBuffEffectTriggerTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EBuffEffectTriggerTypeTupleWrapper Clone()
	{
		return new EBuffEffectTriggerTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EBuffEffectTriggerTypeTupleWrapper);
	}

	public bool Equals(EBuffEffectTriggerTypeTupleWrapper other)
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
		if (Item1 != EBuffEffectTriggerType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EBuffEffectTriggerType.None)
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
		if (Item1 != EBuffEffectTriggerType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EBuffEffectTriggerType.None)
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
		if (Item1 != EBuffEffectTriggerType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EBuffEffectTriggerType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EBuffEffectTriggerTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EBuffEffectTriggerType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EBuffEffectTriggerType.None)
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
				Item1 = (EBuffEffectTriggerType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EBuffEffectTriggerType)input.ReadEnum();
				break;
			}
		}
	}
}
