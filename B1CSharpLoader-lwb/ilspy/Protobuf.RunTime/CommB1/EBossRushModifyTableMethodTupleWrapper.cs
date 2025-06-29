using System;
using Google.Protobuf;

namespace CommB1;

public sealed class EBossRushModifyTableMethodTupleWrapper : IMessage<EBossRushModifyTableMethodTupleWrapper>, IMessage, IEquatable<EBossRushModifyTableMethodTupleWrapper>, IDeepCloneable<EBossRushModifyTableMethodTupleWrapper>
{
	private static readonly MessageParser<EBossRushModifyTableMethodTupleWrapper> _parser = new MessageParser<EBossRushModifyTableMethodTupleWrapper>(() => new EBossRushModifyTableMethodTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EBossRushModifyTableMethod item1_;

	private EBossRushModifyTableMethod item2_;

	public static MessageParser<EBossRushModifyTableMethodTupleWrapper> Parser => _parser;

	public EBossRushModifyTableMethod Item1
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

	public EBossRushModifyTableMethod Item2
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

	public EBossRushModifyTableMethodTupleWrapper()
	{
	}

	public EBossRushModifyTableMethodTupleWrapper(EBossRushModifyTableMethodTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EBossRushModifyTableMethodTupleWrapper Clone()
	{
		return new EBossRushModifyTableMethodTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EBossRushModifyTableMethodTupleWrapper);
	}

	public bool Equals(EBossRushModifyTableMethodTupleWrapper other)
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
		if (Item1 != EBossRushModifyTableMethod.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EBossRushModifyTableMethod.None)
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
		if (Item1 != EBossRushModifyTableMethod.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EBossRushModifyTableMethod.None)
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
		if (Item1 != EBossRushModifyTableMethod.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EBossRushModifyTableMethod.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EBossRushModifyTableMethodTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EBossRushModifyTableMethod.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EBossRushModifyTableMethod.None)
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
				Item1 = (EBossRushModifyTableMethod)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EBossRushModifyTableMethod)input.ReadEnum();
				break;
			}
		}
	}
}
