using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class ESeqClockSourceTupleWrapper : IMessage<ESeqClockSourceTupleWrapper>, IMessage, IEquatable<ESeqClockSourceTupleWrapper>, IDeepCloneable<ESeqClockSourceTupleWrapper>
{
	private static readonly MessageParser<ESeqClockSourceTupleWrapper> _parser = new MessageParser<ESeqClockSourceTupleWrapper>(() => new ESeqClockSourceTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ESeqClockSource item1_;

	private ESeqClockSource item2_;

	public static MessageParser<ESeqClockSourceTupleWrapper> Parser => _parser;

	public ESeqClockSource Item1
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

	public ESeqClockSource Item2
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

	public ESeqClockSourceTupleWrapper()
	{
	}

	public ESeqClockSourceTupleWrapper(ESeqClockSourceTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ESeqClockSourceTupleWrapper Clone()
	{
		return new ESeqClockSourceTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ESeqClockSourceTupleWrapper);
	}

	public bool Equals(ESeqClockSourceTupleWrapper other)
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
		if (Item1 != ESeqClockSource.Tick)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ESeqClockSource.Tick)
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
		if (Item1 != ESeqClockSource.Tick)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ESeqClockSource.Tick)
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
		if (Item1 != ESeqClockSource.Tick)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ESeqClockSource.Tick)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ESeqClockSourceTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ESeqClockSource.Tick)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ESeqClockSource.Tick)
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
				Item1 = (ESeqClockSource)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ESeqClockSource)input.ReadEnum();
				break;
			}
		}
	}
}
