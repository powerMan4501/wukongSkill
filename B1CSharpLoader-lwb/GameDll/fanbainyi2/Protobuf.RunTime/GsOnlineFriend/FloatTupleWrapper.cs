using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GsOnlineFriend;

public sealed class FloatTupleWrapper : IMessage<FloatTupleWrapper>, IMessage, IEquatable<FloatTupleWrapper>, IDeepCloneable<FloatTupleWrapper>
{
	private static readonly MessageParser<FloatTupleWrapper> _parser = new MessageParser<FloatTupleWrapper>(() => new FloatTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private float item1_;

	private float item2_;

	public static MessageParser<FloatTupleWrapper> Parser => _parser;

	public float Item1
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

	public float Item2
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

	public FloatTupleWrapper()
	{
	}

	public FloatTupleWrapper(FloatTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FloatTupleWrapper Clone()
	{
		return new FloatTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FloatTupleWrapper);
	}

	public bool Equals(FloatTupleWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Item1, other.Item1))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Item2, other.Item2))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Item1 != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Item1);
		}
		if (Item2 != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Item2);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Item1 != 0f)
		{
			output.WriteRawTag(13);
			output.WriteFloat(Item1);
		}
		if (Item2 != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(Item2);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Item1 != 0f)
		{
			num += 5;
		}
		if (Item2 != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FloatTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != 0f)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != 0f)
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
			case 13u:
				Item1 = input.ReadFloat();
				break;
			case 21u:
				Item2 = input.ReadFloat();
				break;
			}
		}
	}
}
