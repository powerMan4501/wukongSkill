using System;
using Google.Protobuf;

namespace GurGsStruct;

public sealed class OPTypeTupleWrapper : IMessage<OPTypeTupleWrapper>, IMessage, IEquatable<OPTypeTupleWrapper>, IDeepCloneable<OPTypeTupleWrapper>
{
	private static readonly MessageParser<OPTypeTupleWrapper> _parser = new MessageParser<OPTypeTupleWrapper>(() => new OPTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private OPType item1_;

	private OPType item2_;

	public static MessageParser<OPTypeTupleWrapper> Parser => _parser;

	public OPType Item1
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

	public OPType Item2
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

	public OPTypeTupleWrapper()
	{
	}

	public OPTypeTupleWrapper(OPTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public OPTypeTupleWrapper Clone()
	{
		return new OPTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as OPTypeTupleWrapper);
	}

	public bool Equals(OPTypeTupleWrapper other)
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
		if (Item1 != OPType.Add)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != OPType.Add)
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
		if (Item1 != OPType.Add)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != OPType.Add)
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
		if (Item1 != OPType.Add)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != OPType.Add)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(OPTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != OPType.Add)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != OPType.Add)
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
				Item1 = (OPType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (OPType)input.ReadEnum();
				break;
			}
		}
	}
}
