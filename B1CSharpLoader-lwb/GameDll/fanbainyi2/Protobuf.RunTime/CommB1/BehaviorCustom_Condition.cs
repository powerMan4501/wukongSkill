using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BehaviorCustom_Condition : IMessage<BehaviorCustom_Condition>, IMessage, IEquatable<BehaviorCustom_Condition>, IDeepCloneable<BehaviorCustom_Condition>
{
	private static readonly MessageParser<BehaviorCustom_Condition> _parser = new MessageParser<BehaviorCustom_Condition>(() => new BehaviorCustom_Condition());

	private UnknownFieldSet _unknownFields;

	private bool isReverseCondition_;

	private int conditionCoolDownTimeMs_;

	public static MessageParser<BehaviorCustom_Condition> Parser => _parser;

	public bool IsReverseCondition
	{
		get
		{
			return isReverseCondition_;
		}
		set
		{
			isReverseCondition_ = value;
		}
	}

	public int ConditionCoolDownTimeMs
	{
		get
		{
			return conditionCoolDownTimeMs_;
		}
		set
		{
			conditionCoolDownTimeMs_ = value;
		}
	}

	public BehaviorCustom_Condition()
	{
	}

	public BehaviorCustom_Condition(BehaviorCustom_Condition other)
		: this()
	{
		isReverseCondition_ = other.isReverseCondition_;
		conditionCoolDownTimeMs_ = other.conditionCoolDownTimeMs_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_Condition Clone()
	{
		return new BehaviorCustom_Condition(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_Condition);
	}

	public bool Equals(BehaviorCustom_Condition other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsReverseCondition != other.IsReverseCondition)
		{
			return false;
		}
		if (ConditionCoolDownTimeMs != other.ConditionCoolDownTimeMs)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (IsReverseCondition)
		{
			num ^= IsReverseCondition.GetHashCode();
		}
		if (ConditionCoolDownTimeMs != 0)
		{
			num ^= ConditionCoolDownTimeMs.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (IsReverseCondition)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsReverseCondition);
		}
		if (ConditionCoolDownTimeMs != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ConditionCoolDownTimeMs);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (IsReverseCondition)
		{
			num += 2;
		}
		if (ConditionCoolDownTimeMs != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionCoolDownTimeMs);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_Condition other)
	{
		if (other != null)
		{
			if (other.IsReverseCondition)
			{
				IsReverseCondition = other.IsReverseCondition;
			}
			if (other.ConditionCoolDownTimeMs != 0)
			{
				ConditionCoolDownTimeMs = other.ConditionCoolDownTimeMs;
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
				IsReverseCondition = input.ReadBool();
				break;
			case 16u:
				ConditionCoolDownTimeMs = input.ReadInt32();
				break;
			}
		}
	}
}
