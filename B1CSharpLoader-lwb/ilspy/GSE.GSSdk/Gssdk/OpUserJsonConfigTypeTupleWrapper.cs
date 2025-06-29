using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class OpUserJsonConfigTypeTupleWrapper : IMessage<OpUserJsonConfigTypeTupleWrapper>, IMessage, IEquatable<OpUserJsonConfigTypeTupleWrapper>, IDeepCloneable<OpUserJsonConfigTypeTupleWrapper>
{
	private static readonly MessageParser<OpUserJsonConfigTypeTupleWrapper> _parser = new MessageParser<OpUserJsonConfigTypeTupleWrapper>(() => new OpUserJsonConfigTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private OpUserJsonConfigType item1_;

	private OpUserJsonConfigType item2_;

	public static MessageParser<OpUserJsonConfigTypeTupleWrapper> Parser => _parser;

	public OpUserJsonConfigType Item1
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

	public OpUserJsonConfigType Item2
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

	public OpUserJsonConfigTypeTupleWrapper()
	{
	}

	public OpUserJsonConfigTypeTupleWrapper(OpUserJsonConfigTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public OpUserJsonConfigTypeTupleWrapper Clone()
	{
		return new OpUserJsonConfigTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as OpUserJsonConfigTypeTupleWrapper);
	}

	public bool Equals(OpUserJsonConfigTypeTupleWrapper other)
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
		if (Item1 != OpUserJsonConfigType.OujctGet)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != OpUserJsonConfigType.OujctGet)
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
		if (Item1 != OpUserJsonConfigType.OujctGet)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != OpUserJsonConfigType.OujctGet)
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
		if (Item1 != OpUserJsonConfigType.OujctGet)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != OpUserJsonConfigType.OujctGet)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(OpUserJsonConfigTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != OpUserJsonConfigType.OujctGet)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != OpUserJsonConfigType.OujctGet)
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
				Item1 = (OpUserJsonConfigType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (OpUserJsonConfigType)input.ReadEnum();
				break;
			}
		}
	}
}
