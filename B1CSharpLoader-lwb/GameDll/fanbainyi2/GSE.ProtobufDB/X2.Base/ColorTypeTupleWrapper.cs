using System;
using Google.Protobuf;

namespace X2.Base;

public sealed class ColorTypeTupleWrapper : IMessage<ColorTypeTupleWrapper>, IMessage, IEquatable<ColorTypeTupleWrapper>, IDeepCloneable<ColorTypeTupleWrapper>
{
	private static readonly MessageParser<ColorTypeTupleWrapper> _parser = new MessageParser<ColorTypeTupleWrapper>(() => new ColorTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ColorType item1_;

	private ColorType item2_;

	public static MessageParser<ColorTypeTupleWrapper> Parser => _parser;

	public ColorType Item1
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

	public ColorType Item2
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

	public ColorTypeTupleWrapper()
	{
	}

	public ColorTypeTupleWrapper(ColorTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ColorTypeTupleWrapper Clone()
	{
		return new ColorTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ColorTypeTupleWrapper);
	}

	public bool Equals(ColorTypeTupleWrapper other)
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
		if (Item1 != ColorType.Init)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ColorType.Init)
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
		if (Item1 != ColorType.Init)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ColorType.Init)
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
		if (Item1 != ColorType.Init)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ColorType.Init)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ColorTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ColorType.Init)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ColorType.Init)
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
				Item1 = (ColorType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ColorType)input.ReadEnum();
				break;
			}
		}
	}
}
