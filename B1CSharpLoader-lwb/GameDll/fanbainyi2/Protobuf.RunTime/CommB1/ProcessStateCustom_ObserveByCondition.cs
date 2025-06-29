using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class ProcessStateCustom_ObserveByCondition : IMessage<ProcessStateCustom_ObserveByCondition>, IMessage, IEquatable<ProcessStateCustom_ObserveByCondition>, IDeepCloneable<ProcessStateCustom_ObserveByCondition>
{
	private static readonly MessageParser<ProcessStateCustom_ObserveByCondition> _parser = new MessageParser<ProcessStateCustom_ObserveByCondition>(() => new ProcessStateCustom_ObserveByCondition());

	private UnknownFieldSet _unknownFields;

	private int conditionType_;

	private int successLimit_;

	private string observeActorGuid_ = "";

	private int unitState_;

	private int simpleState_;

	private int attrFloatType_;

	private int compareOperation_;

	private float compareValue_;

	private int buffId_;

	public static MessageParser<ProcessStateCustom_ObserveByCondition> Parser => _parser;

	public int ConditionType
	{
		get
		{
			return conditionType_;
		}
		set
		{
			conditionType_ = value;
		}
	}

	public int SuccessLimit
	{
		get
		{
			return successLimit_;
		}
		set
		{
			successLimit_ = value;
		}
	}

	public string ObserveActorGuid
	{
		get
		{
			return observeActorGuid_;
		}
		set
		{
			observeActorGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int UnitState
	{
		get
		{
			return unitState_;
		}
		set
		{
			unitState_ = value;
		}
	}

	public int SimpleState
	{
		get
		{
			return simpleState_;
		}
		set
		{
			simpleState_ = value;
		}
	}

	public int AttrFloatType
	{
		get
		{
			return attrFloatType_;
		}
		set
		{
			attrFloatType_ = value;
		}
	}

	public int CompareOperation
	{
		get
		{
			return compareOperation_;
		}
		set
		{
			compareOperation_ = value;
		}
	}

	public float CompareValue
	{
		get
		{
			return compareValue_;
		}
		set
		{
			compareValue_ = value;
		}
	}

	public int BuffId
	{
		get
		{
			return buffId_;
		}
		set
		{
			buffId_ = value;
		}
	}

	public ProcessStateCustom_ObserveByCondition()
	{
	}

	public ProcessStateCustom_ObserveByCondition(ProcessStateCustom_ObserveByCondition other)
		: this()
	{
		conditionType_ = other.conditionType_;
		successLimit_ = other.successLimit_;
		observeActorGuid_ = other.observeActorGuid_;
		unitState_ = other.unitState_;
		simpleState_ = other.simpleState_;
		attrFloatType_ = other.attrFloatType_;
		compareOperation_ = other.compareOperation_;
		compareValue_ = other.compareValue_;
		buffId_ = other.buffId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessStateCustom_ObserveByCondition Clone()
	{
		return new ProcessStateCustom_ObserveByCondition(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessStateCustom_ObserveByCondition);
	}

	public bool Equals(ProcessStateCustom_ObserveByCondition other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ConditionType != other.ConditionType)
		{
			return false;
		}
		if (SuccessLimit != other.SuccessLimit)
		{
			return false;
		}
		if (ObserveActorGuid != other.ObserveActorGuid)
		{
			return false;
		}
		if (UnitState != other.UnitState)
		{
			return false;
		}
		if (SimpleState != other.SimpleState)
		{
			return false;
		}
		if (AttrFloatType != other.AttrFloatType)
		{
			return false;
		}
		if (CompareOperation != other.CompareOperation)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CompareValue, other.CompareValue))
		{
			return false;
		}
		if (BuffId != other.BuffId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ConditionType != 0)
		{
			num ^= ConditionType.GetHashCode();
		}
		if (SuccessLimit != 0)
		{
			num ^= SuccessLimit.GetHashCode();
		}
		if (ObserveActorGuid.Length != 0)
		{
			num ^= ObserveActorGuid.GetHashCode();
		}
		if (UnitState != 0)
		{
			num ^= UnitState.GetHashCode();
		}
		if (SimpleState != 0)
		{
			num ^= SimpleState.GetHashCode();
		}
		if (AttrFloatType != 0)
		{
			num ^= AttrFloatType.GetHashCode();
		}
		if (CompareOperation != 0)
		{
			num ^= CompareOperation.GetHashCode();
		}
		if (CompareValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CompareValue);
		}
		if (BuffId != 0)
		{
			num ^= BuffId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ConditionType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ConditionType);
		}
		if (SuccessLimit != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SuccessLimit);
		}
		if (ObserveActorGuid.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(ObserveActorGuid);
		}
		if (UnitState != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(UnitState);
		}
		if (SimpleState != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(SimpleState);
		}
		if (AttrFloatType != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(AttrFloatType);
		}
		if (CompareOperation != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(CompareOperation);
		}
		if (CompareValue != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(CompareValue);
		}
		if (BuffId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(BuffId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ConditionType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionType);
		}
		if (SuccessLimit != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SuccessLimit);
		}
		if (ObserveActorGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ObserveActorGuid);
		}
		if (UnitState != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitState);
		}
		if (SimpleState != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SimpleState);
		}
		if (AttrFloatType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttrFloatType);
		}
		if (CompareOperation != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CompareOperation);
		}
		if (CompareValue != 0f)
		{
			num += 5;
		}
		if (BuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ProcessStateCustom_ObserveByCondition other)
	{
		if (other != null)
		{
			if (other.ConditionType != 0)
			{
				ConditionType = other.ConditionType;
			}
			if (other.SuccessLimit != 0)
			{
				SuccessLimit = other.SuccessLimit;
			}
			if (other.ObserveActorGuid.Length != 0)
			{
				ObserveActorGuid = other.ObserveActorGuid;
			}
			if (other.UnitState != 0)
			{
				UnitState = other.UnitState;
			}
			if (other.SimpleState != 0)
			{
				SimpleState = other.SimpleState;
			}
			if (other.AttrFloatType != 0)
			{
				AttrFloatType = other.AttrFloatType;
			}
			if (other.CompareOperation != 0)
			{
				CompareOperation = other.CompareOperation;
			}
			if (other.CompareValue != 0f)
			{
				CompareValue = other.CompareValue;
			}
			if (other.BuffId != 0)
			{
				BuffId = other.BuffId;
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
				ConditionType = input.ReadInt32();
				break;
			case 16u:
				SuccessLimit = input.ReadInt32();
				break;
			case 26u:
				ObserveActorGuid = input.ReadString();
				break;
			case 32u:
				UnitState = input.ReadInt32();
				break;
			case 40u:
				SimpleState = input.ReadInt32();
				break;
			case 48u:
				AttrFloatType = input.ReadInt32();
				break;
			case 56u:
				CompareOperation = input.ReadInt32();
				break;
			case 69u:
				CompareValue = input.ReadFloat();
				break;
			case 72u:
				BuffId = input.ReadInt32();
				break;
			}
		}
	}
}
