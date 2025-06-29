using System;
using Google.Protobuf;

namespace X2.Base;

public sealed class BattleTypeTupleWrapper : IMessage<BattleTypeTupleWrapper>, IMessage, IEquatable<BattleTypeTupleWrapper>, IDeepCloneable<BattleTypeTupleWrapper>
{
	private static readonly MessageParser<BattleTypeTupleWrapper> _parser = new MessageParser<BattleTypeTupleWrapper>(() => new BattleTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private BattleType item1_;

	private BattleType item2_;

	public static MessageParser<BattleTypeTupleWrapper> Parser => _parser;

	public BattleType Item1
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

	public BattleType Item2
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

	public BattleTypeTupleWrapper()
	{
	}

	public BattleTypeTupleWrapper(BattleTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BattleTypeTupleWrapper Clone()
	{
		return new BattleTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BattleTypeTupleWrapper);
	}

	public bool Equals(BattleTypeTupleWrapper other)
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
		if (Item1 != BattleType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != BattleType.None)
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
		if (Item1 != BattleType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != BattleType.None)
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
		if (Item1 != BattleType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != BattleType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BattleTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != BattleType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != BattleType.None)
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
				Item1 = (BattleType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (BattleType)input.ReadEnum();
				break;
			}
		}
	}
}
