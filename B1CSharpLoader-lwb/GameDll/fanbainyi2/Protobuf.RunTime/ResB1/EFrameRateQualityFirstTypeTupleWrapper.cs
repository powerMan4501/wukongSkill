using System;
using Google.Protobuf;

namespace ResB1;

public sealed class EFrameRateQualityFirstTypeTupleWrapper : IMessage<EFrameRateQualityFirstTypeTupleWrapper>, IMessage, IEquatable<EFrameRateQualityFirstTypeTupleWrapper>, IDeepCloneable<EFrameRateQualityFirstTypeTupleWrapper>
{
	private static readonly MessageParser<EFrameRateQualityFirstTypeTupleWrapper> _parser = new MessageParser<EFrameRateQualityFirstTypeTupleWrapper>(() => new EFrameRateQualityFirstTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EFrameRateQualityFirstType item1_;

	private EFrameRateQualityFirstType item2_;

	public static MessageParser<EFrameRateQualityFirstTypeTupleWrapper> Parser => _parser;

	public EFrameRateQualityFirstType Item1
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

	public EFrameRateQualityFirstType Item2
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

	public EFrameRateQualityFirstTypeTupleWrapper()
	{
	}

	public EFrameRateQualityFirstTypeTupleWrapper(EFrameRateQualityFirstTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EFrameRateQualityFirstTypeTupleWrapper Clone()
	{
		return new EFrameRateQualityFirstTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EFrameRateQualityFirstTypeTupleWrapper);
	}

	public bool Equals(EFrameRateQualityFirstTypeTupleWrapper other)
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
		if (Item1 != EFrameRateQualityFirstType.FrameRate)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EFrameRateQualityFirstType.FrameRate)
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
		if (Item1 != EFrameRateQualityFirstType.FrameRate)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EFrameRateQualityFirstType.FrameRate)
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
		if (Item1 != EFrameRateQualityFirstType.FrameRate)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EFrameRateQualityFirstType.FrameRate)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EFrameRateQualityFirstTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EFrameRateQualityFirstType.FrameRate)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EFrameRateQualityFirstType.FrameRate)
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
				Item1 = (EFrameRateQualityFirstType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EFrameRateQualityFirstType)input.ReadEnum();
				break;
			}
		}
	}
}
