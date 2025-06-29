using System;
using Google.Protobuf;

namespace ResB1;

public sealed class TipsCondition : IMessage<TipsCondition>, IMessage, IEquatable<TipsCondition>, IDeepCloneable<TipsCondition>
{
	private static readonly MessageParser<TipsCondition> _parser = new MessageParser<TipsCondition>(() => new TipsCondition());

	private UnknownFieldSet _unknownFields;

	private TipsConditionType tipConditionType_;

	private int param1_;

	private int param2_;

	public static MessageParser<TipsCondition> Parser => _parser;

	public TipsConditionType TipConditionType
	{
		get
		{
			return tipConditionType_;
		}
		set
		{
			tipConditionType_ = value;
		}
	}

	public int Param1
	{
		get
		{
			return param1_;
		}
		set
		{
			param1_ = value;
		}
	}

	public int Param2
	{
		get
		{
			return param2_;
		}
		set
		{
			param2_ = value;
		}
	}

	public TipsCondition()
	{
	}

	public TipsCondition(TipsCondition other)
		: this()
	{
		tipConditionType_ = other.tipConditionType_;
		param1_ = other.param1_;
		param2_ = other.param2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TipsCondition Clone()
	{
		return new TipsCondition(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TipsCondition);
	}

	public bool Equals(TipsCondition other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TipConditionType != other.TipConditionType)
		{
			return false;
		}
		if (Param1 != other.Param1)
		{
			return false;
		}
		if (Param2 != other.Param2)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (TipConditionType != TipsConditionType.Level)
		{
			num ^= TipConditionType.GetHashCode();
		}
		if (Param1 != 0)
		{
			num ^= Param1.GetHashCode();
		}
		if (Param2 != 0)
		{
			num ^= Param2.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (TipConditionType != TipsConditionType.Level)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)TipConditionType);
		}
		if (Param1 != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Param1);
		}
		if (Param2 != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Param2);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (TipConditionType != TipsConditionType.Level)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)TipConditionType);
		}
		if (Param1 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Param1);
		}
		if (Param2 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Param2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TipsCondition other)
	{
		if (other != null)
		{
			if (other.TipConditionType != TipsConditionType.Level)
			{
				TipConditionType = other.TipConditionType;
			}
			if (other.Param1 != 0)
			{
				Param1 = other.Param1;
			}
			if (other.Param2 != 0)
			{
				Param2 = other.Param2;
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
				TipConditionType = (TipsConditionType)input.ReadEnum();
				break;
			case 16u:
				Param1 = input.ReadInt32();
				break;
			case 24u:
				Param2 = input.ReadInt32();
				break;
			}
		}
	}
}
