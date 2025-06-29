using System;
using Google.Protobuf;

namespace BtlU3;

public sealed class EB2DBuffEffectTriggerTypeTupleWrapper : IMessage<EB2DBuffEffectTriggerTypeTupleWrapper>, IMessage, IEquatable<EB2DBuffEffectTriggerTypeTupleWrapper>, IDeepCloneable<EB2DBuffEffectTriggerTypeTupleWrapper>
{
	private static readonly MessageParser<EB2DBuffEffectTriggerTypeTupleWrapper> _parser = new MessageParser<EB2DBuffEffectTriggerTypeTupleWrapper>(() => new EB2DBuffEffectTriggerTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EB2DBuffEffectTriggerType item1_;

	private EB2DBuffEffectTriggerType item2_;

	public static MessageParser<EB2DBuffEffectTriggerTypeTupleWrapper> Parser => _parser;

	public EB2DBuffEffectTriggerType Item1
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

	public EB2DBuffEffectTriggerType Item2
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

	public EB2DBuffEffectTriggerTypeTupleWrapper()
	{
	}

	public EB2DBuffEffectTriggerTypeTupleWrapper(EB2DBuffEffectTriggerTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EB2DBuffEffectTriggerTypeTupleWrapper Clone()
	{
		return new EB2DBuffEffectTriggerTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EB2DBuffEffectTriggerTypeTupleWrapper);
	}

	public bool Equals(EB2DBuffEffectTriggerTypeTupleWrapper other)
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
		if (Item1 != EB2DBuffEffectTriggerType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EB2DBuffEffectTriggerType.None)
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
		if (Item1 != EB2DBuffEffectTriggerType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EB2DBuffEffectTriggerType.None)
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
		if (Item1 != EB2DBuffEffectTriggerType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EB2DBuffEffectTriggerType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EB2DBuffEffectTriggerTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EB2DBuffEffectTriggerType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EB2DBuffEffectTriggerType.None)
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
				Item1 = (EB2DBuffEffectTriggerType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EB2DBuffEffectTriggerType)input.ReadEnum();
				break;
			}
		}
	}
}
