using System;
using Google.Protobuf;

namespace ResB1;

public sealed class FillToHUDTypeTupleWrapper : IMessage<FillToHUDTypeTupleWrapper>, IMessage, IEquatable<FillToHUDTypeTupleWrapper>, IDeepCloneable<FillToHUDTypeTupleWrapper>
{
	private static readonly MessageParser<FillToHUDTypeTupleWrapper> _parser = new MessageParser<FillToHUDTypeTupleWrapper>(() => new FillToHUDTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private FillToHUDType item1_;

	private FillToHUDType item2_;

	public static MessageParser<FillToHUDTypeTupleWrapper> Parser => _parser;

	public FillToHUDType Item1
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

	public FillToHUDType Item2
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

	public FillToHUDTypeTupleWrapper()
	{
	}

	public FillToHUDTypeTupleWrapper(FillToHUDTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FillToHUDTypeTupleWrapper Clone()
	{
		return new FillToHUDTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FillToHUDTypeTupleWrapper);
	}

	public bool Equals(FillToHUDTypeTupleWrapper other)
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
		if (Item1 != FillToHUDType.Min)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != FillToHUDType.Min)
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
		if (Item1 != FillToHUDType.Min)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != FillToHUDType.Min)
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
		if (Item1 != FillToHUDType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != FillToHUDType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FillToHUDTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != FillToHUDType.Min)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != FillToHUDType.Min)
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
				Item1 = (FillToHUDType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (FillToHUDType)input.ReadEnum();
				break;
			}
		}
	}
}
