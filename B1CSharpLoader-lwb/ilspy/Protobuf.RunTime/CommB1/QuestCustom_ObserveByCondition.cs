using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class QuestCustom_ObserveByCondition : IMessage<QuestCustom_ObserveByCondition>, IMessage, IEquatable<QuestCustom_ObserveByCondition>, IDeepCloneable<QuestCustom_ObserveByCondition>
{
	private static readonly MessageParser<QuestCustom_ObserveByCondition> _parser = new MessageParser<QuestCustom_ObserveByCondition>(() => new QuestCustom_ObserveByCondition());

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

	private int itemNumOnline_;

	private bool reversal_;

	private int challengeLevel_;

	public static MessageParser<QuestCustom_ObserveByCondition> Parser => _parser;

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

	public int ItemNumOnline
	{
		get
		{
			return itemNumOnline_;
		}
		set
		{
			itemNumOnline_ = value;
		}
	}

	public bool Reversal
	{
		get
		{
			return reversal_;
		}
		set
		{
			reversal_ = value;
		}
	}

	public int ChallengeLevel
	{
		get
		{
			return challengeLevel_;
		}
		set
		{
			challengeLevel_ = value;
		}
	}

	public QuestCustom_ObserveByCondition()
	{
	}

	public QuestCustom_ObserveByCondition(QuestCustom_ObserveByCondition other)
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
		itemNumOnline_ = other.itemNumOnline_;
		reversal_ = other.reversal_;
		challengeLevel_ = other.challengeLevel_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_ObserveByCondition Clone()
	{
		return new QuestCustom_ObserveByCondition(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_ObserveByCondition);
	}

	public bool Equals(QuestCustom_ObserveByCondition other)
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
		if (ItemNumOnline != other.ItemNumOnline)
		{
			return false;
		}
		if (Reversal != other.Reversal)
		{
			return false;
		}
		if (ChallengeLevel != other.ChallengeLevel)
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
		if (ItemNumOnline != 0)
		{
			num ^= ItemNumOnline.GetHashCode();
		}
		if (Reversal)
		{
			num ^= Reversal.GetHashCode();
		}
		if (ChallengeLevel != 0)
		{
			num ^= ChallengeLevel.GetHashCode();
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
		if (ItemNumOnline != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(ItemNumOnline);
		}
		if (Reversal)
		{
			output.WriteRawTag(88);
			output.WriteBool(Reversal);
		}
		if (ChallengeLevel != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(ChallengeLevel);
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
		if (ItemNumOnline != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemNumOnline);
		}
		if (Reversal)
		{
			num += 2;
		}
		if (ChallengeLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChallengeLevel);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_ObserveByCondition other)
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
			if (other.ItemNumOnline != 0)
			{
				ItemNumOnline = other.ItemNumOnline;
			}
			if (other.Reversal)
			{
				Reversal = other.Reversal;
			}
			if (other.ChallengeLevel != 0)
			{
				ChallengeLevel = other.ChallengeLevel;
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
			case 80u:
				ItemNumOnline = input.ReadInt32();
				break;
			case 88u:
				Reversal = input.ReadBool();
				break;
			case 96u:
				ChallengeLevel = input.ReadInt32();
				break;
			}
		}
	}
}
