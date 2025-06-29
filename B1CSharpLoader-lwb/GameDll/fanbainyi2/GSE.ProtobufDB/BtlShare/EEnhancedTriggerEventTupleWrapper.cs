using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EEnhancedTriggerEventTupleWrapper : IMessage<EEnhancedTriggerEventTupleWrapper>, IMessage, IEquatable<EEnhancedTriggerEventTupleWrapper>, IDeepCloneable<EEnhancedTriggerEventTupleWrapper>
{
	private static readonly MessageParser<EEnhancedTriggerEventTupleWrapper> _parser = new MessageParser<EEnhancedTriggerEventTupleWrapper>(() => new EEnhancedTriggerEventTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EEnhancedTriggerEvent item1_;

	private EEnhancedTriggerEvent item2_;

	public static MessageParser<EEnhancedTriggerEventTupleWrapper> Parser => _parser;

	public EEnhancedTriggerEvent Item1
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

	public EEnhancedTriggerEvent Item2
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

	public EEnhancedTriggerEventTupleWrapper()
	{
	}

	public EEnhancedTriggerEventTupleWrapper(EEnhancedTriggerEventTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EEnhancedTriggerEventTupleWrapper Clone()
	{
		return new EEnhancedTriggerEventTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EEnhancedTriggerEventTupleWrapper);
	}

	public bool Equals(EEnhancedTriggerEventTupleWrapper other)
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
		if (Item1 != EEnhancedTriggerEvent.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EEnhancedTriggerEvent.None)
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
		if (Item1 != EEnhancedTriggerEvent.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EEnhancedTriggerEvent.None)
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
		if (Item1 != EEnhancedTriggerEvent.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EEnhancedTriggerEvent.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EEnhancedTriggerEventTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EEnhancedTriggerEvent.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EEnhancedTriggerEvent.None)
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
				Item1 = (EEnhancedTriggerEvent)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EEnhancedTriggerEvent)input.ReadEnum();
				break;
			}
		}
	}
}
