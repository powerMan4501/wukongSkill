using System;
using Google.Protobuf;

namespace CommB1;

public sealed class PlayerCommandTypeTupleWrapper : IMessage<PlayerCommandTypeTupleWrapper>, IMessage, IEquatable<PlayerCommandTypeTupleWrapper>, IDeepCloneable<PlayerCommandTypeTupleWrapper>
{
	private static readonly MessageParser<PlayerCommandTypeTupleWrapper> _parser = new MessageParser<PlayerCommandTypeTupleWrapper>(() => new PlayerCommandTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private PlayerCommandType item1_;

	private PlayerCommandType item2_;

	public static MessageParser<PlayerCommandTypeTupleWrapper> Parser => _parser;

	public PlayerCommandType Item1
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

	public PlayerCommandType Item2
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

	public PlayerCommandTypeTupleWrapper()
	{
	}

	public PlayerCommandTypeTupleWrapper(PlayerCommandTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlayerCommandTypeTupleWrapper Clone()
	{
		return new PlayerCommandTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlayerCommandTypeTupleWrapper);
	}

	public bool Equals(PlayerCommandTypeTupleWrapper other)
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
		if (Item1 != PlayerCommandType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != PlayerCommandType.None)
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
		if (Item1 != PlayerCommandType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != PlayerCommandType.None)
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
		if (Item1 != PlayerCommandType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != PlayerCommandType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PlayerCommandTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != PlayerCommandType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != PlayerCommandType.None)
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
				Item1 = (PlayerCommandType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (PlayerCommandType)input.ReadEnum();
				break;
			}
		}
	}
}
