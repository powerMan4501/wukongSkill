using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using GurCalliopeState;

namespace CommB1;

public sealed class BehaviorCustom_DetectForce : IMessage<BehaviorCustom_DetectForce>, IMessage, IEquatable<BehaviorCustom_DetectForce>, IDeepCloneable<BehaviorCustom_DetectForce>
{
	private static readonly MessageParser<BehaviorCustom_DetectForce> _parser = new MessageParser<BehaviorCustom_DetectForce>(() => new BehaviorCustom_DetectForce());

	private UnknownFieldSet _unknownFields;

	private bool isReverseCondition_;

	private int conditionCoolDownTimeMs_;

	private int forceType_;

	private int detectFilter_;

	private static readonly FieldCodec<CalliopeCustom_DetectCondition> _repeated_conditions_codec = FieldCodec.ForMessage(42u, CalliopeCustom_DetectCondition.Parser);

	private readonly RepeatedField<CalliopeCustom_DetectCondition> conditions_ = new RepeatedField<CalliopeCustom_DetectCondition>();

	private int successCount_;

	public static MessageParser<BehaviorCustom_DetectForce> Parser => _parser;

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

	public int ForceType
	{
		get
		{
			return forceType_;
		}
		set
		{
			forceType_ = value;
		}
	}

	public int DetectFilter
	{
		get
		{
			return detectFilter_;
		}
		set
		{
			detectFilter_ = value;
		}
	}

	public RepeatedField<CalliopeCustom_DetectCondition> Conditions => conditions_;

	public int SuccessCount
	{
		get
		{
			return successCount_;
		}
		set
		{
			successCount_ = value;
		}
	}

	public BehaviorCustom_DetectForce()
	{
	}

	public BehaviorCustom_DetectForce(BehaviorCustom_DetectForce other)
		: this()
	{
		isReverseCondition_ = other.isReverseCondition_;
		conditionCoolDownTimeMs_ = other.conditionCoolDownTimeMs_;
		forceType_ = other.forceType_;
		detectFilter_ = other.detectFilter_;
		conditions_ = other.conditions_.Clone();
		successCount_ = other.successCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_DetectForce Clone()
	{
		return new BehaviorCustom_DetectForce(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_DetectForce);
	}

	public bool Equals(BehaviorCustom_DetectForce other)
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
		if (ForceType != other.ForceType)
		{
			return false;
		}
		if (DetectFilter != other.DetectFilter)
		{
			return false;
		}
		if (!conditions_.Equals(other.conditions_))
		{
			return false;
		}
		if (SuccessCount != other.SuccessCount)
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
		if (ForceType != 0)
		{
			num ^= ForceType.GetHashCode();
		}
		if (DetectFilter != 0)
		{
			num ^= DetectFilter.GetHashCode();
		}
		num ^= conditions_.GetHashCode();
		if (SuccessCount != 0)
		{
			num ^= SuccessCount.GetHashCode();
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
		if (ForceType != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ForceType);
		}
		if (DetectFilter != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(DetectFilter);
		}
		conditions_.WriteTo(output, _repeated_conditions_codec);
		if (SuccessCount != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(SuccessCount);
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
		if (ForceType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ForceType);
		}
		if (DetectFilter != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DetectFilter);
		}
		num += conditions_.CalculateSize(_repeated_conditions_codec);
		if (SuccessCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SuccessCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_DetectForce other)
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
			if (other.ForceType != 0)
			{
				ForceType = other.ForceType;
			}
			if (other.DetectFilter != 0)
			{
				DetectFilter = other.DetectFilter;
			}
			conditions_.Add(other.conditions_);
			if (other.SuccessCount != 0)
			{
				SuccessCount = other.SuccessCount;
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
				ForceType = input.ReadInt32();
				break;
			case 32u:
				DetectFilter = input.ReadInt32();
				break;
			case 42u:
				conditions_.AddEntriesFrom(input, _repeated_conditions_codec);
				break;
			case 48u:
				SuccessCount = input.ReadInt32();
				break;
			}
		}
	}
}
