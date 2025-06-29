using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EGSBuffLayerCounterTypeTupleWrapper : IMessage<EGSBuffLayerCounterTypeTupleWrapper>, IMessage, IEquatable<EGSBuffLayerCounterTypeTupleWrapper>, IDeepCloneable<EGSBuffLayerCounterTypeTupleWrapper>
{
	private static readonly MessageParser<EGSBuffLayerCounterTypeTupleWrapper> _parser = new MessageParser<EGSBuffLayerCounterTypeTupleWrapper>(() => new EGSBuffLayerCounterTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EGSBuffLayerCounterType item1_;

	private EGSBuffLayerCounterType item2_;

	public static MessageParser<EGSBuffLayerCounterTypeTupleWrapper> Parser => _parser;

	public EGSBuffLayerCounterType Item1
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

	public EGSBuffLayerCounterType Item2
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

	public EGSBuffLayerCounterTypeTupleWrapper()
	{
	}

	public EGSBuffLayerCounterTypeTupleWrapper(EGSBuffLayerCounterTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EGSBuffLayerCounterTypeTupleWrapper Clone()
	{
		return new EGSBuffLayerCounterTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EGSBuffLayerCounterTypeTupleWrapper);
	}

	public bool Equals(EGSBuffLayerCounterTypeTupleWrapper other)
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
		if (Item1 != EGSBuffLayerCounterType.ReduceLayer)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EGSBuffLayerCounterType.ReduceLayer)
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
		if (Item1 != EGSBuffLayerCounterType.ReduceLayer)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EGSBuffLayerCounterType.ReduceLayer)
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
		if (Item1 != EGSBuffLayerCounterType.ReduceLayer)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EGSBuffLayerCounterType.ReduceLayer)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EGSBuffLayerCounterTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EGSBuffLayerCounterType.ReduceLayer)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EGSBuffLayerCounterType.ReduceLayer)
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
				Item1 = (EGSBuffLayerCounterType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EGSBuffLayerCounterType)input.ReadEnum();
				break;
			}
		}
	}
}
