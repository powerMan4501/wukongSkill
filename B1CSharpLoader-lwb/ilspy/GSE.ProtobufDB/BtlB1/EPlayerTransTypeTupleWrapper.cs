using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class EPlayerTransTypeTupleWrapper : IMessage<EPlayerTransTypeTupleWrapper>, IMessage, IEquatable<EPlayerTransTypeTupleWrapper>, IDeepCloneable<EPlayerTransTypeTupleWrapper>
{
	private static readonly MessageParser<EPlayerTransTypeTupleWrapper> _parser = new MessageParser<EPlayerTransTypeTupleWrapper>(() => new EPlayerTransTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EPlayerTransType item1_;

	private EPlayerTransType item2_;

	public static MessageParser<EPlayerTransTypeTupleWrapper> Parser => _parser;

	public EPlayerTransType Item1
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

	public EPlayerTransType Item2
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

	public EPlayerTransTypeTupleWrapper()
	{
	}

	public EPlayerTransTypeTupleWrapper(EPlayerTransTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EPlayerTransTypeTupleWrapper Clone()
	{
		return new EPlayerTransTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EPlayerTransTypeTupleWrapper);
	}

	public bool Equals(EPlayerTransTypeTupleWrapper other)
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
		if (Item1 != EPlayerTransType.BattleUnit)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EPlayerTransType.BattleUnit)
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
		if (Item1 != EPlayerTransType.BattleUnit)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EPlayerTransType.BattleUnit)
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
		if (Item1 != EPlayerTransType.BattleUnit)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EPlayerTransType.BattleUnit)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EPlayerTransTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EPlayerTransType.BattleUnit)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EPlayerTransType.BattleUnit)
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
				Item1 = (EPlayerTransType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EPlayerTransType)input.ReadEnum();
				break;
			}
		}
	}
}
