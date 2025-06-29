using System;
using Google.Protobuf;

namespace ResB1;

public sealed class EBossRushDebuffTargetTupleWrapper : IMessage<EBossRushDebuffTargetTupleWrapper>, IMessage, IEquatable<EBossRushDebuffTargetTupleWrapper>, IDeepCloneable<EBossRushDebuffTargetTupleWrapper>
{
	private static readonly MessageParser<EBossRushDebuffTargetTupleWrapper> _parser = new MessageParser<EBossRushDebuffTargetTupleWrapper>(() => new EBossRushDebuffTargetTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EBossRushDebuffTarget item1_;

	private EBossRushDebuffTarget item2_;

	public static MessageParser<EBossRushDebuffTargetTupleWrapper> Parser => _parser;

	public EBossRushDebuffTarget Item1
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

	public EBossRushDebuffTarget Item2
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

	public EBossRushDebuffTargetTupleWrapper()
	{
	}

	public EBossRushDebuffTargetTupleWrapper(EBossRushDebuffTargetTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EBossRushDebuffTargetTupleWrapper Clone()
	{
		return new EBossRushDebuffTargetTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EBossRushDebuffTargetTupleWrapper);
	}

	public bool Equals(EBossRushDebuffTargetTupleWrapper other)
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
		if (Item1 != EBossRushDebuffTarget.Player)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EBossRushDebuffTarget.Player)
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
		if (Item1 != EBossRushDebuffTarget.Player)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EBossRushDebuffTarget.Player)
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
		if (Item1 != EBossRushDebuffTarget.Player)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EBossRushDebuffTarget.Player)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EBossRushDebuffTargetTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EBossRushDebuffTarget.Player)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EBossRushDebuffTarget.Player)
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
				Item1 = (EBossRushDebuffTarget)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EBossRushDebuffTarget)input.ReadEnum();
				break;
			}
		}
	}
}
