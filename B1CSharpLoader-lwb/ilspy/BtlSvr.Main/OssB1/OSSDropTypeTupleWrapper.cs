using System;
using Google.Protobuf;

namespace OssB1;

public sealed class OSSDropTypeTupleWrapper : IMessage<OSSDropTypeTupleWrapper>, IMessage, IEquatable<OSSDropTypeTupleWrapper>, IDeepCloneable<OSSDropTypeTupleWrapper>
{
	private static readonly MessageParser<OSSDropTypeTupleWrapper> _parser = new MessageParser<OSSDropTypeTupleWrapper>(() => new OSSDropTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private OSSDropType item1_;

	private OSSDropType item2_;

	public static MessageParser<OSSDropTypeTupleWrapper> Parser => _parser;

	public OSSDropType Item1
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

	public OSSDropType Item2
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

	public OSSDropTypeTupleWrapper()
	{
	}

	public OSSDropTypeTupleWrapper(OSSDropTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public OSSDropTypeTupleWrapper Clone()
	{
		return new OSSDropTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as OSSDropTypeTupleWrapper);
	}

	public bool Equals(OSSDropTypeTupleWrapper other)
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
		if (Item1 != OSSDropType.CommDrop)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != OSSDropType.CommDrop)
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
		if (Item1 != OSSDropType.CommDrop)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != OSSDropType.CommDrop)
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
		if (Item1 != OSSDropType.CommDrop)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != OSSDropType.CommDrop)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(OSSDropTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != OSSDropType.CommDrop)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != OSSDropType.CommDrop)
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
				Item1 = (OSSDropType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (OSSDropType)input.ReadEnum();
				break;
			}
		}
	}
}
