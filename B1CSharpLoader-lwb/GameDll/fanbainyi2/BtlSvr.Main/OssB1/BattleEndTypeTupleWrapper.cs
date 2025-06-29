using System;
using Google.Protobuf;

namespace OssB1;

public sealed class BattleEndTypeTupleWrapper : IMessage<BattleEndTypeTupleWrapper>, IMessage, IEquatable<BattleEndTypeTupleWrapper>, IDeepCloneable<BattleEndTypeTupleWrapper>
{
	private static readonly MessageParser<BattleEndTypeTupleWrapper> _parser = new MessageParser<BattleEndTypeTupleWrapper>(() => new BattleEndTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private BattleEndType item1_;

	private BattleEndType item2_;

	public static MessageParser<BattleEndTypeTupleWrapper> Parser => _parser;

	public BattleEndType Item1
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

	public BattleEndType Item2
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

	public BattleEndTypeTupleWrapper()
	{
	}

	public BattleEndTypeTupleWrapper(BattleEndTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BattleEndTypeTupleWrapper Clone()
	{
		return new BattleEndTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BattleEndTypeTupleWrapper);
	}

	public bool Equals(BattleEndTypeTupleWrapper other)
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
		if (Item1 != BattleEndType.Detach)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != BattleEndType.Detach)
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
		if (Item1 != BattleEndType.Detach)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != BattleEndType.Detach)
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
		if (Item1 != BattleEndType.Detach)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != BattleEndType.Detach)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BattleEndTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != BattleEndType.Detach)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != BattleEndType.Detach)
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
				Item1 = (BattleEndType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (BattleEndType)input.ReadEnum();
				break;
			}
		}
	}
}
