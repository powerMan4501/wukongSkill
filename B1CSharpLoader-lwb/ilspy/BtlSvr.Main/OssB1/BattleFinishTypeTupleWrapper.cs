using System;
using Google.Protobuf;

namespace OssB1;

public sealed class BattleFinishTypeTupleWrapper : IMessage<BattleFinishTypeTupleWrapper>, IMessage, IEquatable<BattleFinishTypeTupleWrapper>, IDeepCloneable<BattleFinishTypeTupleWrapper>
{
	private static readonly MessageParser<BattleFinishTypeTupleWrapper> _parser = new MessageParser<BattleFinishTypeTupleWrapper>(() => new BattleFinishTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private BattleFinishType item1_;

	private BattleFinishType item2_;

	public static MessageParser<BattleFinishTypeTupleWrapper> Parser => _parser;

	public BattleFinishType Item1
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

	public BattleFinishType Item2
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

	public BattleFinishTypeTupleWrapper()
	{
	}

	public BattleFinishTypeTupleWrapper(BattleFinishTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BattleFinishTypeTupleWrapper Clone()
	{
		return new BattleFinishTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BattleFinishTypeTupleWrapper);
	}

	public bool Equals(BattleFinishTypeTupleWrapper other)
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
		if (Item1 != BattleFinishType.BattleFinish)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != BattleFinishType.BattleFinish)
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
		if (Item1 != BattleFinishType.BattleFinish)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != BattleFinishType.BattleFinish)
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
		if (Item1 != BattleFinishType.BattleFinish)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != BattleFinishType.BattleFinish)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BattleFinishTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != BattleFinishType.BattleFinish)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != BattleFinishType.BattleFinish)
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
				Item1 = (BattleFinishType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (BattleFinishType)input.ReadEnum();
				break;
			}
		}
	}
}
