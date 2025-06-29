using System;
using Google.Protobuf;

namespace GsOnline;

public sealed class BattleHostTypeTupleWrapper : IMessage<BattleHostTypeTupleWrapper>, IMessage, IEquatable<BattleHostTypeTupleWrapper>, IDeepCloneable<BattleHostTypeTupleWrapper>
{
	private static readonly MessageParser<BattleHostTypeTupleWrapper> _parser = new MessageParser<BattleHostTypeTupleWrapper>(() => new BattleHostTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private BattleHostType item1_;

	private BattleHostType item2_;

	public static MessageParser<BattleHostTypeTupleWrapper> Parser => _parser;

	public BattleHostType Item1
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

	public BattleHostType Item2
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

	public BattleHostTypeTupleWrapper()
	{
	}

	public BattleHostTypeTupleWrapper(BattleHostTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BattleHostTypeTupleWrapper Clone()
	{
		return new BattleHostTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BattleHostTypeTupleWrapper);
	}

	public bool Equals(BattleHostTypeTupleWrapper other)
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
		if (Item1 != BattleHostType.P2P)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != BattleHostType.P2P)
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
		if (Item1 != BattleHostType.P2P)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != BattleHostType.P2P)
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
		if (Item1 != BattleHostType.P2P)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != BattleHostType.P2P)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BattleHostTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != BattleHostType.P2P)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != BattleHostType.P2P)
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
				Item1 = (BattleHostType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (BattleHostType)input.ReadEnum();
				break;
			}
		}
	}
}
