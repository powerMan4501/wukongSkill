using System;
using Google.Protobuf;

namespace ResB1;

public sealed class ELowHpTipsTypeTupleWrapper : IMessage<ELowHpTipsTypeTupleWrapper>, IMessage, IEquatable<ELowHpTipsTypeTupleWrapper>, IDeepCloneable<ELowHpTipsTypeTupleWrapper>
{
	private static readonly MessageParser<ELowHpTipsTypeTupleWrapper> _parser = new MessageParser<ELowHpTipsTypeTupleWrapper>(() => new ELowHpTipsTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ELowHpTipsType item1_;

	private ELowHpTipsType item2_;

	public static MessageParser<ELowHpTipsTypeTupleWrapper> Parser => _parser;

	public ELowHpTipsType Item1
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

	public ELowHpTipsType Item2
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

	public ELowHpTipsTypeTupleWrapper()
	{
	}

	public ELowHpTipsTypeTupleWrapper(ELowHpTipsTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ELowHpTipsTypeTupleWrapper Clone()
	{
		return new ELowHpTipsTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ELowHpTipsTypeTupleWrapper);
	}

	public bool Equals(ELowHpTipsTypeTupleWrapper other)
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
		if (Item1 != ELowHpTipsType.Close)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ELowHpTipsType.Close)
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
		if (Item1 != ELowHpTipsType.Close)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ELowHpTipsType.Close)
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
		if (Item1 != ELowHpTipsType.Close)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ELowHpTipsType.Close)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ELowHpTipsTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ELowHpTipsType.Close)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ELowHpTipsType.Close)
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
				Item1 = (ELowHpTipsType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ELowHpTipsType)input.ReadEnum();
				break;
			}
		}
	}
}
