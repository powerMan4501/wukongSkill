using System;
using Google.Protobuf;

namespace ResB1;

public sealed class PS5ActivityObjectTypeTupleWrapper : IMessage<PS5ActivityObjectTypeTupleWrapper>, IMessage, IEquatable<PS5ActivityObjectTypeTupleWrapper>, IDeepCloneable<PS5ActivityObjectTypeTupleWrapper>
{
	private static readonly MessageParser<PS5ActivityObjectTypeTupleWrapper> _parser = new MessageParser<PS5ActivityObjectTypeTupleWrapper>(() => new PS5ActivityObjectTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private PS5ActivityObjectType item1_;

	private PS5ActivityObjectType item2_;

	public static MessageParser<PS5ActivityObjectTypeTupleWrapper> Parser => _parser;

	public PS5ActivityObjectType Item1
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

	public PS5ActivityObjectType Item2
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

	public PS5ActivityObjectTypeTupleWrapper()
	{
	}

	public PS5ActivityObjectTypeTupleWrapper(PS5ActivityObjectTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PS5ActivityObjectTypeTupleWrapper Clone()
	{
		return new PS5ActivityObjectTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PS5ActivityObjectTypeTupleWrapper);
	}

	public bool Equals(PS5ActivityObjectTypeTupleWrapper other)
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
		if (Item1 != PS5ActivityObjectType.Activity)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != PS5ActivityObjectType.Activity)
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
		if (Item1 != PS5ActivityObjectType.Activity)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != PS5ActivityObjectType.Activity)
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
		if (Item1 != PS5ActivityObjectType.Activity)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != PS5ActivityObjectType.Activity)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PS5ActivityObjectTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != PS5ActivityObjectType.Activity)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != PS5ActivityObjectType.Activity)
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
				Item1 = (PS5ActivityObjectType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (PS5ActivityObjectType)input.ReadEnum();
				break;
			}
		}
	}
}
