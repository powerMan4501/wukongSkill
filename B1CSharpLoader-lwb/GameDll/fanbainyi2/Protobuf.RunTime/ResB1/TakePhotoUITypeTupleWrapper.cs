using System;
using Google.Protobuf;

namespace ResB1;

public sealed class TakePhotoUITypeTupleWrapper : IMessage<TakePhotoUITypeTupleWrapper>, IMessage, IEquatable<TakePhotoUITypeTupleWrapper>, IDeepCloneable<TakePhotoUITypeTupleWrapper>
{
	private static readonly MessageParser<TakePhotoUITypeTupleWrapper> _parser = new MessageParser<TakePhotoUITypeTupleWrapper>(() => new TakePhotoUITypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private TakePhotoUIType item1_;

	private TakePhotoUIType item2_;

	public static MessageParser<TakePhotoUITypeTupleWrapper> Parser => _parser;

	public TakePhotoUIType Item1
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

	public TakePhotoUIType Item2
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

	public TakePhotoUITypeTupleWrapper()
	{
	}

	public TakePhotoUITypeTupleWrapper(TakePhotoUITypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TakePhotoUITypeTupleWrapper Clone()
	{
		return new TakePhotoUITypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TakePhotoUITypeTupleWrapper);
	}

	public bool Equals(TakePhotoUITypeTupleWrapper other)
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
		if (Item1 != TakePhotoUIType.Fixed)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != TakePhotoUIType.Fixed)
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
		if (Item1 != TakePhotoUIType.Fixed)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != TakePhotoUIType.Fixed)
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
		if (Item1 != TakePhotoUIType.Fixed)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != TakePhotoUIType.Fixed)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TakePhotoUITypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != TakePhotoUIType.Fixed)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != TakePhotoUIType.Fixed)
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
				Item1 = (TakePhotoUIType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (TakePhotoUIType)input.ReadEnum();
				break;
			}
		}
	}
}
