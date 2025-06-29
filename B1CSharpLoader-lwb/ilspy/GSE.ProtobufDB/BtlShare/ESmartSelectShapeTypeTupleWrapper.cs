using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class ESmartSelectShapeTypeTupleWrapper : IMessage<ESmartSelectShapeTypeTupleWrapper>, IMessage, IEquatable<ESmartSelectShapeTypeTupleWrapper>, IDeepCloneable<ESmartSelectShapeTypeTupleWrapper>
{
	private static readonly MessageParser<ESmartSelectShapeTypeTupleWrapper> _parser = new MessageParser<ESmartSelectShapeTypeTupleWrapper>(() => new ESmartSelectShapeTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ESmartSelectShapeType item1_;

	private ESmartSelectShapeType item2_;

	public static MessageParser<ESmartSelectShapeTypeTupleWrapper> Parser => _parser;

	public ESmartSelectShapeType Item1
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

	public ESmartSelectShapeType Item2
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

	public ESmartSelectShapeTypeTupleWrapper()
	{
	}

	public ESmartSelectShapeTypeTupleWrapper(ESmartSelectShapeTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ESmartSelectShapeTypeTupleWrapper Clone()
	{
		return new ESmartSelectShapeTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ESmartSelectShapeTypeTupleWrapper);
	}

	public bool Equals(ESmartSelectShapeTypeTupleWrapper other)
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
		if (Item1 != ESmartSelectShapeType.SssNone)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ESmartSelectShapeType.SssNone)
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
		if (Item1 != ESmartSelectShapeType.SssNone)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ESmartSelectShapeType.SssNone)
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
		if (Item1 != ESmartSelectShapeType.SssNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ESmartSelectShapeType.SssNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ESmartSelectShapeTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ESmartSelectShapeType.SssNone)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ESmartSelectShapeType.SssNone)
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
				Item1 = (ESmartSelectShapeType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ESmartSelectShapeType)input.ReadEnum();
				break;
			}
		}
	}
}
