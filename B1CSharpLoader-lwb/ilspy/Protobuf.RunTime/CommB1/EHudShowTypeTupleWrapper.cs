using System;
using Google.Protobuf;

namespace CommB1;

public sealed class EHudShowTypeTupleWrapper : IMessage<EHudShowTypeTupleWrapper>, IMessage, IEquatable<EHudShowTypeTupleWrapper>, IDeepCloneable<EHudShowTypeTupleWrapper>
{
	private static readonly MessageParser<EHudShowTypeTupleWrapper> _parser = new MessageParser<EHudShowTypeTupleWrapper>(() => new EHudShowTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EHudShowType item1_;

	private EHudShowType item2_;

	public static MessageParser<EHudShowTypeTupleWrapper> Parser => _parser;

	public EHudShowType Item1
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

	public EHudShowType Item2
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

	public EHudShowTypeTupleWrapper()
	{
	}

	public EHudShowTypeTupleWrapper(EHudShowTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EHudShowTypeTupleWrapper Clone()
	{
		return new EHudShowTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EHudShowTypeTupleWrapper);
	}

	public bool Equals(EHudShowTypeTupleWrapper other)
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
		if (Item1 != EHudShowType.AutoShow)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EHudShowType.AutoShow)
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
		if (Item1 != EHudShowType.AutoShow)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EHudShowType.AutoShow)
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
		if (Item1 != EHudShowType.AutoShow)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EHudShowType.AutoShow)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EHudShowTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EHudShowType.AutoShow)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EHudShowType.AutoShow)
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
				Item1 = (EHudShowType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EHudShowType)input.ReadEnum();
				break;
			}
		}
	}
}
