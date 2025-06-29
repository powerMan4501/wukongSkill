using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class EAITaskActivationEventTupleWrapper : IMessage<EAITaskActivationEventTupleWrapper>, IMessage, IEquatable<EAITaskActivationEventTupleWrapper>, IDeepCloneable<EAITaskActivationEventTupleWrapper>
{
	private static readonly MessageParser<EAITaskActivationEventTupleWrapper> _parser = new MessageParser<EAITaskActivationEventTupleWrapper>(() => new EAITaskActivationEventTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EAITaskActivationEvent item1_;

	private EAITaskActivationEvent item2_;

	public static MessageParser<EAITaskActivationEventTupleWrapper> Parser => _parser;

	public EAITaskActivationEvent Item1
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

	public EAITaskActivationEvent Item2
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

	public EAITaskActivationEventTupleWrapper()
	{
	}

	public EAITaskActivationEventTupleWrapper(EAITaskActivationEventTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EAITaskActivationEventTupleWrapper Clone()
	{
		return new EAITaskActivationEventTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EAITaskActivationEventTupleWrapper);
	}

	public bool Equals(EAITaskActivationEventTupleWrapper other)
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
		if (Item1 != EAITaskActivationEvent.AtOnce)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EAITaskActivationEvent.AtOnce)
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
		if (Item1 != EAITaskActivationEvent.AtOnce)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EAITaskActivationEvent.AtOnce)
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
		if (Item1 != EAITaskActivationEvent.AtOnce)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EAITaskActivationEvent.AtOnce)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EAITaskActivationEventTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EAITaskActivationEvent.AtOnce)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EAITaskActivationEvent.AtOnce)
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
				Item1 = (EAITaskActivationEvent)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EAITaskActivationEvent)input.ReadEnum();
				break;
			}
		}
	}
}
