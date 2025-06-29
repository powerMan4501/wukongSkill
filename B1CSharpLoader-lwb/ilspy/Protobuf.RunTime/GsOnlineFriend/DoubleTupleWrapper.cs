using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GsOnlineFriend;

public sealed class DoubleTupleWrapper : IMessage<DoubleTupleWrapper>, IMessage, IEquatable<DoubleTupleWrapper>, IDeepCloneable<DoubleTupleWrapper>
{
	private static readonly MessageParser<DoubleTupleWrapper> _parser = new MessageParser<DoubleTupleWrapper>(() => new DoubleTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private double item1_;

	private double item2_;

	public static MessageParser<DoubleTupleWrapper> Parser => _parser;

	public double Item1
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

	public double Item2
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

	public DoubleTupleWrapper()
	{
	}

	public DoubleTupleWrapper(DoubleTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DoubleTupleWrapper Clone()
	{
		return new DoubleTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DoubleTupleWrapper);
	}

	public bool Equals(DoubleTupleWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Item1, other.Item1))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Item2, other.Item2))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Item1 != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Item1);
		}
		if (Item2 != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Item2);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Item1 != 0.0)
		{
			output.WriteRawTag(9);
			output.WriteDouble(Item1);
		}
		if (Item2 != 0.0)
		{
			output.WriteRawTag(17);
			output.WriteDouble(Item2);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Item1 != 0.0)
		{
			num += 9;
		}
		if (Item2 != 0.0)
		{
			num += 9;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DoubleTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != 0.0)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != 0.0)
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
			case 9u:
				Item1 = input.ReadDouble();
				break;
			case 17u:
				Item2 = input.ReadDouble();
				break;
			}
		}
	}
}
