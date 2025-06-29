using System;
using Google.Protobuf;

namespace CommB1;

public sealed class PlayerGameModeTupleWrapper : IMessage<PlayerGameModeTupleWrapper>, IMessage, IEquatable<PlayerGameModeTupleWrapper>, IDeepCloneable<PlayerGameModeTupleWrapper>
{
	private static readonly MessageParser<PlayerGameModeTupleWrapper> _parser = new MessageParser<PlayerGameModeTupleWrapper>(() => new PlayerGameModeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private PlayerGameMode item1_;

	private PlayerGameMode item2_;

	public static MessageParser<PlayerGameModeTupleWrapper> Parser => _parser;

	public PlayerGameMode Item1
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

	public PlayerGameMode Item2
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

	public PlayerGameModeTupleWrapper()
	{
	}

	public PlayerGameModeTupleWrapper(PlayerGameModeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlayerGameModeTupleWrapper Clone()
	{
		return new PlayerGameModeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlayerGameModeTupleWrapper);
	}

	public bool Equals(PlayerGameModeTupleWrapper other)
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
		if (Item1 != PlayerGameMode.Console)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != PlayerGameMode.Console)
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
		if (Item1 != PlayerGameMode.Console)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != PlayerGameMode.Console)
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
		if (Item1 != PlayerGameMode.Console)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != PlayerGameMode.Console)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PlayerGameModeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != PlayerGameMode.Console)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != PlayerGameMode.Console)
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
				Item1 = (PlayerGameMode)input.ReadEnum();
				break;
			case 16u:
				Item2 = (PlayerGameMode)input.ReadEnum();
				break;
			}
		}
	}
}
