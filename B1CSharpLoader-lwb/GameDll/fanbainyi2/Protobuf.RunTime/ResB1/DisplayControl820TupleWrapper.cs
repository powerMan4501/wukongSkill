using System;
using Google.Protobuf;

namespace ResB1;

public sealed class DisplayControl820TupleWrapper : IMessage<DisplayControl820TupleWrapper>, IMessage, IEquatable<DisplayControl820TupleWrapper>, IDeepCloneable<DisplayControl820TupleWrapper>
{
	private static readonly MessageParser<DisplayControl820TupleWrapper> _parser = new MessageParser<DisplayControl820TupleWrapper>(() => new DisplayControl820TupleWrapper());

	private UnknownFieldSet _unknownFields;

	private DisplayControl820 item1_;

	private DisplayControl820 item2_;

	public static MessageParser<DisplayControl820TupleWrapper> Parser => _parser;

	public DisplayControl820 Item1
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

	public DisplayControl820 Item2
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

	public DisplayControl820TupleWrapper()
	{
	}

	public DisplayControl820TupleWrapper(DisplayControl820TupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DisplayControl820TupleWrapper Clone()
	{
		return new DisplayControl820TupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DisplayControl820TupleWrapper);
	}

	public bool Equals(DisplayControl820TupleWrapper other)
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
		if (Item1 != DisplayControl820.Default)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != DisplayControl820.Default)
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
		if (Item1 != DisplayControl820.Default)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != DisplayControl820.Default)
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
		if (Item1 != DisplayControl820.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != DisplayControl820.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DisplayControl820TupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != DisplayControl820.Default)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != DisplayControl820.Default)
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
				Item1 = (DisplayControl820)input.ReadEnum();
				break;
			case 16u:
				Item2 = (DisplayControl820)input.ReadEnum();
				break;
			}
		}
	}
}
