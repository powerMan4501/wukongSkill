using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EItemQualityColorTupleWrapper : IMessage<EItemQualityColorTupleWrapper>, IMessage, IEquatable<EItemQualityColorTupleWrapper>, IDeepCloneable<EItemQualityColorTupleWrapper>
{
	private static readonly MessageParser<EItemQualityColorTupleWrapper> _parser = new MessageParser<EItemQualityColorTupleWrapper>(() => new EItemQualityColorTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EItemQualityColor item1_;

	private EItemQualityColor item2_;

	public static MessageParser<EItemQualityColorTupleWrapper> Parser => _parser;

	public EItemQualityColor Item1
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

	public EItemQualityColor Item2
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

	public EItemQualityColorTupleWrapper()
	{
	}

	public EItemQualityColorTupleWrapper(EItemQualityColorTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EItemQualityColorTupleWrapper Clone()
	{
		return new EItemQualityColorTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EItemQualityColorTupleWrapper);
	}

	public bool Equals(EItemQualityColorTupleWrapper other)
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
		if (Item1 != EItemQualityColor.White)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EItemQualityColor.White)
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
		if (Item1 != EItemQualityColor.White)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EItemQualityColor.White)
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
		if (Item1 != EItemQualityColor.White)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EItemQualityColor.White)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EItemQualityColorTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EItemQualityColor.White)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EItemQualityColor.White)
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
				Item1 = (EItemQualityColor)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EItemQualityColor)input.ReadEnum();
				break;
			}
		}
	}
}
