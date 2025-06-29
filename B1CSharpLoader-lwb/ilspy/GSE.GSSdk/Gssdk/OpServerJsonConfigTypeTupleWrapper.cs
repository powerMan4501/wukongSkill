using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class OpServerJsonConfigTypeTupleWrapper : IMessage<OpServerJsonConfigTypeTupleWrapper>, IMessage, IEquatable<OpServerJsonConfigTypeTupleWrapper>, IDeepCloneable<OpServerJsonConfigTypeTupleWrapper>
{
	private static readonly MessageParser<OpServerJsonConfigTypeTupleWrapper> _parser = new MessageParser<OpServerJsonConfigTypeTupleWrapper>(() => new OpServerJsonConfigTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private OpServerJsonConfigType item1_;

	private OpServerJsonConfigType item2_;

	public static MessageParser<OpServerJsonConfigTypeTupleWrapper> Parser => _parser;

	public OpServerJsonConfigType Item1
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

	public OpServerJsonConfigType Item2
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

	public OpServerJsonConfigTypeTupleWrapper()
	{
	}

	public OpServerJsonConfigTypeTupleWrapper(OpServerJsonConfigTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public OpServerJsonConfigTypeTupleWrapper Clone()
	{
		return new OpServerJsonConfigTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as OpServerJsonConfigTypeTupleWrapper);
	}

	public bool Equals(OpServerJsonConfigTypeTupleWrapper other)
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
		if (Item1 != OpServerJsonConfigType.OsjctGet)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != OpServerJsonConfigType.OsjctGet)
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
		if (Item1 != OpServerJsonConfigType.OsjctGet)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != OpServerJsonConfigType.OsjctGet)
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
		if (Item1 != OpServerJsonConfigType.OsjctGet)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != OpServerJsonConfigType.OsjctGet)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(OpServerJsonConfigTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != OpServerJsonConfigType.OsjctGet)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != OpServerJsonConfigType.OsjctGet)
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
				Item1 = (OpServerJsonConfigType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (OpServerJsonConfigType)input.ReadEnum();
				break;
			}
		}
	}
}
