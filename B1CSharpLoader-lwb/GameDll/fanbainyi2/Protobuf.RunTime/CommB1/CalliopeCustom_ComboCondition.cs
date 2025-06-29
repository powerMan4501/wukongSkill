using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class CalliopeCustom_ComboCondition : IMessage<CalliopeCustom_ComboCondition>, IMessage, IEquatable<CalliopeCustom_ComboCondition>, IDeepCloneable<CalliopeCustom_ComboCondition>
{
	private static readonly MessageParser<CalliopeCustom_ComboCondition> _parser = new MessageParser<CalliopeCustom_ComboCondition>(() => new CalliopeCustom_ComboCondition());

	private UnknownFieldSet _unknownFields;

	private int conditionType_;

	private int unitState_;

	private int simpleState_;

	private int attrFloatType_;

	private int compareOperation_;

	private float compareValue_;

	private int buffId_;

	private int talentId_;

	private int comparePotentialEnergyOperation_;

	private int potentialEnergyLevel_;

	private int compareChargeOperation_;

	private int chargeLevel_;

	private int compareCeilingHeightOperation_;

	private int ceilingHeight_;

	private string conditionIdentity_ = "";

	private int stanceType_;

	private static readonly FieldCodec<int> _repeated_skillIdList_codec = FieldCodec.ForInt32(138u);

	private readonly RepeatedField<int> skillIdList_ = new RepeatedField<int>();

	private int moveMode_;

	public static MessageParser<CalliopeCustom_ComboCondition> Parser => _parser;

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

	public int TalentId
	{
		get
		{
			return talentId_;
		}
		set
		{
			talentId_ = value;
		}
	}

	public int ComparePotentialEnergyOperation
	{
		get
		{
			return comparePotentialEnergyOperation_;
		}
		set
		{
			comparePotentialEnergyOperation_ = value;
		}
	}

	public int PotentialEnergyLevel
	{
		get
		{
			return potentialEnergyLevel_;
		}
		set
		{
			potentialEnergyLevel_ = value;
		}
	}

	public int CompareChargeOperation
	{
		get
		{
			return compareChargeOperation_;
		}
		set
		{
			compareChargeOperation_ = value;
		}
	}

	public int ChargeLevel
	{
		get
		{
			return chargeLevel_;
		}
		set
		{
			chargeLevel_ = value;
		}
	}

	public int CompareCeilingHeightOperation
	{
		get
		{
			return compareCeilingHeightOperation_;
		}
		set
		{
			compareCeilingHeightOperation_ = value;
		}
	}

	public int CeilingHeight
	{
		get
		{
			return ceilingHeight_;
		}
		set
		{
			ceilingHeight_ = value;
		}
	}

	public string ConditionIdentity
	{
		get
		{
			return conditionIdentity_;
		}
		set
		{
			conditionIdentity_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int StanceType
	{
		get
		{
			return stanceType_;
		}
		set
		{
			stanceType_ = value;
		}
	}

	public RepeatedField<int> SkillIdList => skillIdList_;

	public int MoveMode
	{
		get
		{
			return moveMode_;
		}
		set
		{
			moveMode_ = value;
		}
	}

	public CalliopeCustom_ComboCondition()
	{
	}

	public CalliopeCustom_ComboCondition(CalliopeCustom_ComboCondition other)
		: this()
	{
		conditionType_ = other.conditionType_;
		unitState_ = other.unitState_;
		simpleState_ = other.simpleState_;
		attrFloatType_ = other.attrFloatType_;
		compareOperation_ = other.compareOperation_;
		compareValue_ = other.compareValue_;
		buffId_ = other.buffId_;
		talentId_ = other.talentId_;
		comparePotentialEnergyOperation_ = other.comparePotentialEnergyOperation_;
		potentialEnergyLevel_ = other.potentialEnergyLevel_;
		compareChargeOperation_ = other.compareChargeOperation_;
		chargeLevel_ = other.chargeLevel_;
		compareCeilingHeightOperation_ = other.compareCeilingHeightOperation_;
		ceilingHeight_ = other.ceilingHeight_;
		conditionIdentity_ = other.conditionIdentity_;
		stanceType_ = other.stanceType_;
		skillIdList_ = other.skillIdList_.Clone();
		moveMode_ = other.moveMode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_ComboCondition Clone()
	{
		return new CalliopeCustom_ComboCondition(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_ComboCondition);
	}

	public bool Equals(CalliopeCustom_ComboCondition other)
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
		if (TalentId != other.TalentId)
		{
			return false;
		}
		if (ComparePotentialEnergyOperation != other.ComparePotentialEnergyOperation)
		{
			return false;
		}
		if (PotentialEnergyLevel != other.PotentialEnergyLevel)
		{
			return false;
		}
		if (CompareChargeOperation != other.CompareChargeOperation)
		{
			return false;
		}
		if (ChargeLevel != other.ChargeLevel)
		{
			return false;
		}
		if (CompareCeilingHeightOperation != other.CompareCeilingHeightOperation)
		{
			return false;
		}
		if (CeilingHeight != other.CeilingHeight)
		{
			return false;
		}
		if (ConditionIdentity != other.ConditionIdentity)
		{
			return false;
		}
		if (StanceType != other.StanceType)
		{
			return false;
		}
		if (!skillIdList_.Equals(other.skillIdList_))
		{
			return false;
		}
		if (MoveMode != other.MoveMode)
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
		if (TalentId != 0)
		{
			num ^= TalentId.GetHashCode();
		}
		if (ComparePotentialEnergyOperation != 0)
		{
			num ^= ComparePotentialEnergyOperation.GetHashCode();
		}
		if (PotentialEnergyLevel != 0)
		{
			num ^= PotentialEnergyLevel.GetHashCode();
		}
		if (CompareChargeOperation != 0)
		{
			num ^= CompareChargeOperation.GetHashCode();
		}
		if (ChargeLevel != 0)
		{
			num ^= ChargeLevel.GetHashCode();
		}
		if (CompareCeilingHeightOperation != 0)
		{
			num ^= CompareCeilingHeightOperation.GetHashCode();
		}
		if (CeilingHeight != 0)
		{
			num ^= CeilingHeight.GetHashCode();
		}
		if (ConditionIdentity.Length != 0)
		{
			num ^= ConditionIdentity.GetHashCode();
		}
		if (StanceType != 0)
		{
			num ^= StanceType.GetHashCode();
		}
		num ^= skillIdList_.GetHashCode();
		if (MoveMode != 0)
		{
			num ^= MoveMode.GetHashCode();
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
		if (UnitState != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(UnitState);
		}
		if (SimpleState != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(SimpleState);
		}
		if (AttrFloatType != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(AttrFloatType);
		}
		if (CompareOperation != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(CompareOperation);
		}
		if (CompareValue != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(CompareValue);
		}
		if (BuffId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(BuffId);
		}
		if (TalentId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(TalentId);
		}
		if (ComparePotentialEnergyOperation != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(ComparePotentialEnergyOperation);
		}
		if (PotentialEnergyLevel != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(PotentialEnergyLevel);
		}
		if (CompareChargeOperation != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(CompareChargeOperation);
		}
		if (ChargeLevel != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(ChargeLevel);
		}
		if (CompareCeilingHeightOperation != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(CompareCeilingHeightOperation);
		}
		if (CeilingHeight != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(CeilingHeight);
		}
		if (ConditionIdentity.Length != 0)
		{
			output.WriteRawTag(122);
			output.WriteString(ConditionIdentity);
		}
		if (StanceType != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(StanceType);
		}
		skillIdList_.WriteTo(output, _repeated_skillIdList_codec);
		if (MoveMode != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(MoveMode);
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
		if (TalentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TalentId);
		}
		if (ComparePotentialEnergyOperation != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ComparePotentialEnergyOperation);
		}
		if (PotentialEnergyLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PotentialEnergyLevel);
		}
		if (CompareChargeOperation != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CompareChargeOperation);
		}
		if (ChargeLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChargeLevel);
		}
		if (CompareCeilingHeightOperation != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CompareCeilingHeightOperation);
		}
		if (CeilingHeight != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CeilingHeight);
		}
		if (ConditionIdentity.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ConditionIdentity);
		}
		if (StanceType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(StanceType);
		}
		num += skillIdList_.CalculateSize(_repeated_skillIdList_codec);
		if (MoveMode != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MoveMode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_ComboCondition other)
	{
		if (other != null)
		{
			if (other.ConditionType != 0)
			{
				ConditionType = other.ConditionType;
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
			if (other.TalentId != 0)
			{
				TalentId = other.TalentId;
			}
			if (other.ComparePotentialEnergyOperation != 0)
			{
				ComparePotentialEnergyOperation = other.ComparePotentialEnergyOperation;
			}
			if (other.PotentialEnergyLevel != 0)
			{
				PotentialEnergyLevel = other.PotentialEnergyLevel;
			}
			if (other.CompareChargeOperation != 0)
			{
				CompareChargeOperation = other.CompareChargeOperation;
			}
			if (other.ChargeLevel != 0)
			{
				ChargeLevel = other.ChargeLevel;
			}
			if (other.CompareCeilingHeightOperation != 0)
			{
				CompareCeilingHeightOperation = other.CompareCeilingHeightOperation;
			}
			if (other.CeilingHeight != 0)
			{
				CeilingHeight = other.CeilingHeight;
			}
			if (other.ConditionIdentity.Length != 0)
			{
				ConditionIdentity = other.ConditionIdentity;
			}
			if (other.StanceType != 0)
			{
				StanceType = other.StanceType;
			}
			skillIdList_.Add(other.skillIdList_);
			if (other.MoveMode != 0)
			{
				MoveMode = other.MoveMode;
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
				UnitState = input.ReadInt32();
				break;
			case 24u:
				SimpleState = input.ReadInt32();
				break;
			case 32u:
				AttrFloatType = input.ReadInt32();
				break;
			case 40u:
				CompareOperation = input.ReadInt32();
				break;
			case 53u:
				CompareValue = input.ReadFloat();
				break;
			case 56u:
				BuffId = input.ReadInt32();
				break;
			case 64u:
				TalentId = input.ReadInt32();
				break;
			case 72u:
				ComparePotentialEnergyOperation = input.ReadInt32();
				break;
			case 80u:
				PotentialEnergyLevel = input.ReadInt32();
				break;
			case 88u:
				CompareChargeOperation = input.ReadInt32();
				break;
			case 96u:
				ChargeLevel = input.ReadInt32();
				break;
			case 104u:
				CompareCeilingHeightOperation = input.ReadInt32();
				break;
			case 112u:
				CeilingHeight = input.ReadInt32();
				break;
			case 122u:
				ConditionIdentity = input.ReadString();
				break;
			case 128u:
				StanceType = input.ReadInt32();
				break;
			case 136u:
			case 138u:
				skillIdList_.AddEntriesFrom(input, _repeated_skillIdList_codec);
				break;
			case 144u:
				MoveMode = input.ReadInt32();
				break;
			}
		}
	}
}
