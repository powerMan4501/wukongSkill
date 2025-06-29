using System;
using Google.Protobuf;

namespace BaseU3;

public sealed class BattleResultReasonTupleWrapper : IMessage<BattleResultReasonTupleWrapper>, IMessage, IEquatable<BattleResultReasonTupleWrapper>, IDeepCloneable<BattleResultReasonTupleWrapper>
{
	private static readonly MessageParser<BattleResultReasonTupleWrapper> _parser = new MessageParser<BattleResultReasonTupleWrapper>(() => new BattleResultReasonTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private BattleResultReason item1_;

	private BattleResultReason item2_;

	public static MessageParser<BattleResultReasonTupleWrapper> Parser => _parser;

	public BattleResultReason Item1
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

	public BattleResultReason Item2
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

	public BattleResultReasonTupleWrapper()
	{
	}

	public BattleResultReasonTupleWrapper(BattleResultReasonTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BattleResultReasonTupleWrapper Clone()
	{
		return new BattleResultReasonTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BattleResultReasonTupleWrapper);
	}

	public bool Equals(BattleResultReasonTupleWrapper other)
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
		if (Item1 != BattleResultReason.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != BattleResultReason.None)
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
		if (Item1 != BattleResultReason.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != BattleResultReason.None)
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
		if (Item1 != BattleResultReason.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != BattleResultReason.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BattleResultReasonTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != BattleResultReason.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != BattleResultReason.None)
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
				Item1 = (BattleResultReason)input.ReadEnum();
				break;
			case 16u:
				Item2 = (BattleResultReason)input.ReadEnum();
				break;
			}
		}
	}
}
