using System;
using Google.Protobuf;

namespace GsOnlineFriend;

public sealed class FriendStateTypeTupleWrapper : IMessage<FriendStateTypeTupleWrapper>, IMessage, IEquatable<FriendStateTypeTupleWrapper>, IDeepCloneable<FriendStateTypeTupleWrapper>
{
	private static readonly MessageParser<FriendStateTypeTupleWrapper> _parser = new MessageParser<FriendStateTypeTupleWrapper>(() => new FriendStateTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private FriendStateType item1_;

	private FriendStateType item2_;

	public static MessageParser<FriendStateTypeTupleWrapper> Parser => _parser;

	public FriendStateType Item1
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

	public FriendStateType Item2
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

	public FriendStateTypeTupleWrapper()
	{
	}

	public FriendStateTypeTupleWrapper(FriendStateTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FriendStateTypeTupleWrapper Clone()
	{
		return new FriendStateTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FriendStateTypeTupleWrapper);
	}

	public bool Equals(FriendStateTypeTupleWrapper other)
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
		if (Item1 != FriendStateType.Online)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != FriendStateType.Online)
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
		if (Item1 != FriendStateType.Online)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != FriendStateType.Online)
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
		if (Item1 != FriendStateType.Online)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != FriendStateType.Online)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FriendStateTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != FriendStateType.Online)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != FriendStateType.Online)
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
				Item1 = (FriendStateType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (FriendStateType)input.ReadEnum();
				break;
			}
		}
	}
}
