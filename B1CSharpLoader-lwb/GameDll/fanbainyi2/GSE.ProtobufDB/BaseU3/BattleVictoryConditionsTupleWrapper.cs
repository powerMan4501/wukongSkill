using System;
using Google.Protobuf;

namespace BaseU3;

public sealed class BattleVictoryConditionsTupleWrapper : IMessage<BattleVictoryConditionsTupleWrapper>, IMessage, IEquatable<BattleVictoryConditionsTupleWrapper>, IDeepCloneable<BattleVictoryConditionsTupleWrapper>
{
	private static readonly MessageParser<BattleVictoryConditionsTupleWrapper> _parser = new MessageParser<BattleVictoryConditionsTupleWrapper>(() => new BattleVictoryConditionsTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private BattleVictoryConditions item1_;

	private BattleVictoryConditions item2_;

	public static MessageParser<BattleVictoryConditionsTupleWrapper> Parser => _parser;

	public BattleVictoryConditions Item1
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

	public BattleVictoryConditions Item2
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

	public BattleVictoryConditionsTupleWrapper()
	{
	}

	public BattleVictoryConditionsTupleWrapper(BattleVictoryConditionsTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BattleVictoryConditionsTupleWrapper Clone()
	{
		return new BattleVictoryConditionsTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BattleVictoryConditionsTupleWrapper);
	}

	public bool Equals(BattleVictoryConditionsTupleWrapper other)
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
		if (Item1 != BattleVictoryConditions.AllEnemyDie)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != BattleVictoryConditions.AllEnemyDie)
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
		if (Item1 != BattleVictoryConditions.AllEnemyDie)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != BattleVictoryConditions.AllEnemyDie)
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
		if (Item1 != BattleVictoryConditions.AllEnemyDie)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != BattleVictoryConditions.AllEnemyDie)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BattleVictoryConditionsTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != BattleVictoryConditions.AllEnemyDie)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != BattleVictoryConditions.AllEnemyDie)
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
				Item1 = (BattleVictoryConditions)input.ReadEnum();
				break;
			case 16u:
				Item2 = (BattleVictoryConditions)input.ReadEnum();
				break;
			}
		}
	}
}
