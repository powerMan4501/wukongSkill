using System;
using Google.Protobuf;

namespace CommB1;

public sealed class RoomMemberStateTupleWrapper : IMessage<RoomMemberStateTupleWrapper>, IMessage, IEquatable<RoomMemberStateTupleWrapper>, IDeepCloneable<RoomMemberStateTupleWrapper>
{
	private static readonly MessageParser<RoomMemberStateTupleWrapper> _parser = new MessageParser<RoomMemberStateTupleWrapper>(() => new RoomMemberStateTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private RoomMemberState item1_;

	private RoomMemberState item2_;

	public static MessageParser<RoomMemberStateTupleWrapper> Parser => _parser;

	public RoomMemberState Item1
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

	public RoomMemberState Item2
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

	public RoomMemberStateTupleWrapper()
	{
	}

	public RoomMemberStateTupleWrapper(RoomMemberStateTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoomMemberStateTupleWrapper Clone()
	{
		return new RoomMemberStateTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoomMemberStateTupleWrapper);
	}

	public bool Equals(RoomMemberStateTupleWrapper other)
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
		if (Item1 != RoomMemberState.Init)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != RoomMemberState.Init)
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
		if (Item1 != RoomMemberState.Init)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != RoomMemberState.Init)
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
		if (Item1 != RoomMemberState.Init)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != RoomMemberState.Init)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoomMemberStateTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != RoomMemberState.Init)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != RoomMemberState.Init)
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
				Item1 = (RoomMemberState)input.ReadEnum();
				break;
			case 16u:
				Item2 = (RoomMemberState)input.ReadEnum();
				break;
			}
		}
	}
}
