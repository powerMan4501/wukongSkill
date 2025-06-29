using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStGlobalConfigTypeTupleWrapper : IMessage<FUStGlobalConfigTypeTupleWrapper>, IMessage, IEquatable<FUStGlobalConfigTypeTupleWrapper>, IDeepCloneable<FUStGlobalConfigTypeTupleWrapper>
{
	private static readonly MessageParser<FUStGlobalConfigTypeTupleWrapper> _parser = new MessageParser<FUStGlobalConfigTypeTupleWrapper>(() => new FUStGlobalConfigTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private FUStGlobalConfigType item1_;

	private FUStGlobalConfigType item2_;

	public static MessageParser<FUStGlobalConfigTypeTupleWrapper> Parser => _parser;

	public FUStGlobalConfigType Item1
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

	public FUStGlobalConfigType Item2
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

	public FUStGlobalConfigTypeTupleWrapper()
	{
	}

	public FUStGlobalConfigTypeTupleWrapper(FUStGlobalConfigTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStGlobalConfigTypeTupleWrapper Clone()
	{
		return new FUStGlobalConfigTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStGlobalConfigTypeTupleWrapper);
	}

	public bool Equals(FUStGlobalConfigTypeTupleWrapper other)
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
		if (Item1 != FUStGlobalConfigType.Int)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != FUStGlobalConfigType.Int)
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
		if (Item1 != FUStGlobalConfigType.Int)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != FUStGlobalConfigType.Int)
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
		if (Item1 != FUStGlobalConfigType.Int)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != FUStGlobalConfigType.Int)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStGlobalConfigTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != FUStGlobalConfigType.Int)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != FUStGlobalConfigType.Int)
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
				Item1 = (FUStGlobalConfigType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (FUStGlobalConfigType)input.ReadEnum();
				break;
			}
		}
	}
}
