using System;
using Google.Protobuf;

namespace CommB1;

public sealed class LobbyEventTypeTupleWrapper : IMessage<LobbyEventTypeTupleWrapper>, IMessage, IEquatable<LobbyEventTypeTupleWrapper>, IDeepCloneable<LobbyEventTypeTupleWrapper>
{
	private static readonly MessageParser<LobbyEventTypeTupleWrapper> _parser = new MessageParser<LobbyEventTypeTupleWrapper>(() => new LobbyEventTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private LobbyEventType item1_;

	private LobbyEventType item2_;

	public static MessageParser<LobbyEventTypeTupleWrapper> Parser => _parser;

	public LobbyEventType Item1
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

	public LobbyEventType Item2
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

	public LobbyEventTypeTupleWrapper()
	{
	}

	public LobbyEventTypeTupleWrapper(LobbyEventTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LobbyEventTypeTupleWrapper Clone()
	{
		return new LobbyEventTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LobbyEventTypeTupleWrapper);
	}

	public bool Equals(LobbyEventTypeTupleWrapper other)
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
		if (Item1 != LobbyEventType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != LobbyEventType.None)
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
		if (Item1 != LobbyEventType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != LobbyEventType.None)
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
		if (Item1 != LobbyEventType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != LobbyEventType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LobbyEventTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != LobbyEventType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != LobbyEventType.None)
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
				Item1 = (LobbyEventType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (LobbyEventType)input.ReadEnum();
				break;
			}
		}
	}
}
