using System;
using Google.Protobuf;

namespace ResB1;

public sealed class EGPUHardwareSchedulingTupleWrapper : IMessage<EGPUHardwareSchedulingTupleWrapper>, IMessage, IEquatable<EGPUHardwareSchedulingTupleWrapper>, IDeepCloneable<EGPUHardwareSchedulingTupleWrapper>
{
	private static readonly MessageParser<EGPUHardwareSchedulingTupleWrapper> _parser = new MessageParser<EGPUHardwareSchedulingTupleWrapper>(() => new EGPUHardwareSchedulingTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EGPUHardwareScheduling item1_;

	private EGPUHardwareScheduling item2_;

	public static MessageParser<EGPUHardwareSchedulingTupleWrapper> Parser => _parser;

	public EGPUHardwareScheduling Item1
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

	public EGPUHardwareScheduling Item2
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

	public EGPUHardwareSchedulingTupleWrapper()
	{
	}

	public EGPUHardwareSchedulingTupleWrapper(EGPUHardwareSchedulingTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EGPUHardwareSchedulingTupleWrapper Clone()
	{
		return new EGPUHardwareSchedulingTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EGPUHardwareSchedulingTupleWrapper);
	}

	public bool Equals(EGPUHardwareSchedulingTupleWrapper other)
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
		if (Item1 != EGPUHardwareScheduling.Min)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EGPUHardwareScheduling.Min)
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
		if (Item1 != EGPUHardwareScheduling.Min)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EGPUHardwareScheduling.Min)
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
		if (Item1 != EGPUHardwareScheduling.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EGPUHardwareScheduling.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EGPUHardwareSchedulingTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EGPUHardwareScheduling.Min)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EGPUHardwareScheduling.Min)
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
				Item1 = (EGPUHardwareScheduling)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EGPUHardwareScheduling)input.ReadEnum();
				break;
			}
		}
	}
}
