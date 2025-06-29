using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using GurCalliopeState;

namespace CommB1;

public sealed class BehaviorCustom_DetectUnit : IMessage<BehaviorCustom_DetectUnit>, IMessage, IEquatable<BehaviorCustom_DetectUnit>, IDeepCloneable<BehaviorCustom_DetectUnit>
{
	private static readonly MessageParser<BehaviorCustom_DetectUnit> _parser = new MessageParser<BehaviorCustom_DetectUnit>(() => new BehaviorCustom_DetectUnit());

	private UnknownFieldSet _unknownFields;

	private bool isReverseCondition_;

	private int conditionCoolDownTimeMs_;

	private int unitType_;

	private static readonly FieldCodec<CalliopeCustom_DetectCondition> _repeated_conditions_codec = FieldCodec.ForMessage(34u, CalliopeCustom_DetectCondition.Parser);

	private readonly RepeatedField<CalliopeCustom_DetectCondition> conditions_ = new RepeatedField<CalliopeCustom_DetectCondition>();

	private int conditionalRelation_;

	private string smartUnitGuid_ = "";

	public static MessageParser<BehaviorCustom_DetectUnit> Parser => _parser;

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

	public int UnitType
	{
		get
		{
			return unitType_;
		}
		set
		{
			unitType_ = value;
		}
	}

	public RepeatedField<CalliopeCustom_DetectCondition> Conditions => conditions_;

	public int ConditionalRelation
	{
		get
		{
			return conditionalRelation_;
		}
		set
		{
			conditionalRelation_ = value;
		}
	}

	public string SmartUnitGuid
	{
		get
		{
			return smartUnitGuid_;
		}
		set
		{
			smartUnitGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public BehaviorCustom_DetectUnit()
	{
	}

	public BehaviorCustom_DetectUnit(BehaviorCustom_DetectUnit other)
		: this()
	{
		isReverseCondition_ = other.isReverseCondition_;
		conditionCoolDownTimeMs_ = other.conditionCoolDownTimeMs_;
		unitType_ = other.unitType_;
		conditions_ = other.conditions_.Clone();
		conditionalRelation_ = other.conditionalRelation_;
		smartUnitGuid_ = other.smartUnitGuid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_DetectUnit Clone()
	{
		return new BehaviorCustom_DetectUnit(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_DetectUnit);
	}

	public bool Equals(BehaviorCustom_DetectUnit other)
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
		if (UnitType != other.UnitType)
		{
			return false;
		}
		if (!conditions_.Equals(other.conditions_))
		{
			return false;
		}
		if (ConditionalRelation != other.ConditionalRelation)
		{
			return false;
		}
		if (SmartUnitGuid != other.SmartUnitGuid)
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
		if (UnitType != 0)
		{
			num ^= UnitType.GetHashCode();
		}
		num ^= conditions_.GetHashCode();
		if (ConditionalRelation != 0)
		{
			num ^= ConditionalRelation.GetHashCode();
		}
		if (SmartUnitGuid.Length != 0)
		{
			num ^= SmartUnitGuid.GetHashCode();
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
		if (UnitType != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(UnitType);
		}
		conditions_.WriteTo(output, _repeated_conditions_codec);
		if (ConditionalRelation != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(ConditionalRelation);
		}
		if (SmartUnitGuid.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(SmartUnitGuid);
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
		if (UnitType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitType);
		}
		num += conditions_.CalculateSize(_repeated_conditions_codec);
		if (ConditionalRelation != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionalRelation);
		}
		if (SmartUnitGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SmartUnitGuid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_DetectUnit other)
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
			if (other.UnitType != 0)
			{
				UnitType = other.UnitType;
			}
			conditions_.Add(other.conditions_);
			if (other.ConditionalRelation != 0)
			{
				ConditionalRelation = other.ConditionalRelation;
			}
			if (other.SmartUnitGuid.Length != 0)
			{
				SmartUnitGuid = other.SmartUnitGuid;
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
			case 24u:
				UnitType = input.ReadInt32();
				break;
			case 34u:
				conditions_.AddEntriesFrom(input, _repeated_conditions_codec);
				break;
			case 40u:
				ConditionalRelation = input.ReadInt32();
				break;
			case 50u:
				SmartUnitGuid = input.ReadString();
				break;
			}
		}
	}
}
