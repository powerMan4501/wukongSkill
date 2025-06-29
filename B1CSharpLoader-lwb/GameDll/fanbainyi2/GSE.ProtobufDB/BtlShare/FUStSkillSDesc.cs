using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class FUStSkillSDesc : IMessage<FUStSkillSDesc>, IMessage, IEquatable<FUStSkillSDesc>, IDeepCloneable<FUStSkillSDesc>
{
	private static readonly MessageParser<FUStSkillSDesc> _parser = new MessageParser<FUStSkillSDesc>(() => new FUStSkillSDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private ESkillBaseTarget skillBaseTarget_;

	private static readonly FieldCodec<int> _repeated_skillBaseTargetIntParams_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> skillBaseTargetIntParams_ = new RepeatedField<int>();

	private string skillBaseTargetStringParam_ = "";

	private ESkillType skillType_;

	private float moveSkillDisMinRate_;

	private float moveSkillDisMaxRate_;

	private string templatePath_ = "";

	private float noiseLoudness_;

	private EAttrCostType minAttrCostType1_;

	private float minAttrCostBase1_;

	private float minAttrCostRatio1_;

	private EAttrCostType minAttrCostType2_;

	private float minAttrCostBase2_;

	private float minAttrCostRatio2_;

	private float preCooldownTime_;

	private float cooldownTime_;

	private ESkillCooldownType cooldownType_;

	private EDmgRangeType dmgRangeType_;

	private ESkillRotateType skillRotateType_;

	private EGSYesNo onlyPlayerControlledSkillRotate_;

	private int doneAddBuffID_;

	private int skillHitSetSimpleState_;

	private string atkReboundingMontage_ = "";

	private string lowAtkReboundingMontage_ = "";

	private string skillArmorBrokeMontage_ = "";

	private EGSYesNo isComboSkill_;

	private EGSYesNo isOverlying_;

	private EGSYesNo isCanMoveAttack_;

	private string cooldownSkills_ = "";

	private float additionalHatredValue_;

	private string guard_ = "";

	public static MessageParser<FUStSkillSDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public ESkillBaseTarget SkillBaseTarget
	{
		get
		{
			return skillBaseTarget_;
		}
		set
		{
			skillBaseTarget_ = value;
		}
	}

	public RepeatedField<int> SkillBaseTargetIntParams => skillBaseTargetIntParams_;

	public string SkillBaseTargetStringParam
	{
		get
		{
			return skillBaseTargetStringParam_;
		}
		set
		{
			skillBaseTargetStringParam_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ESkillType SkillType
	{
		get
		{
			return skillType_;
		}
		set
		{
			skillType_ = value;
		}
	}

	public float MoveSkillDisMinRate
	{
		get
		{
			return moveSkillDisMinRate_;
		}
		set
		{
			moveSkillDisMinRate_ = value;
		}
	}

	public float MoveSkillDisMaxRate
	{
		get
		{
			return moveSkillDisMaxRate_;
		}
		set
		{
			moveSkillDisMaxRate_ = value;
		}
	}

	public string TemplatePath
	{
		get
		{
			return templatePath_;
		}
		set
		{
			templatePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float NoiseLoudness
	{
		get
		{
			return noiseLoudness_;
		}
		set
		{
			noiseLoudness_ = value;
		}
	}

	public EAttrCostType MinAttrCostType1
	{
		get
		{
			return minAttrCostType1_;
		}
		set
		{
			minAttrCostType1_ = value;
		}
	}

	public float MinAttrCostBase1
	{
		get
		{
			return minAttrCostBase1_;
		}
		set
		{
			minAttrCostBase1_ = value;
		}
	}

	public float MinAttrCostRatio1
	{
		get
		{
			return minAttrCostRatio1_;
		}
		set
		{
			minAttrCostRatio1_ = value;
		}
	}

	public EAttrCostType MinAttrCostType2
	{
		get
		{
			return minAttrCostType2_;
		}
		set
		{
			minAttrCostType2_ = value;
		}
	}

	public float MinAttrCostBase2
	{
		get
		{
			return minAttrCostBase2_;
		}
		set
		{
			minAttrCostBase2_ = value;
		}
	}

	public float MinAttrCostRatio2
	{
		get
		{
			return minAttrCostRatio2_;
		}
		set
		{
			minAttrCostRatio2_ = value;
		}
	}

	public float PreCooldownTime
	{
		get
		{
			return preCooldownTime_;
		}
		set
		{
			preCooldownTime_ = value;
		}
	}

	public float CooldownTime
	{
		get
		{
			return cooldownTime_;
		}
		set
		{
			cooldownTime_ = value;
		}
	}

	public ESkillCooldownType CooldownType
	{
		get
		{
			return cooldownType_;
		}
		set
		{
			cooldownType_ = value;
		}
	}

	public EDmgRangeType DmgRangeType
	{
		get
		{
			return dmgRangeType_;
		}
		set
		{
			dmgRangeType_ = value;
		}
	}

	public ESkillRotateType SkillRotateType
	{
		get
		{
			return skillRotateType_;
		}
		set
		{
			skillRotateType_ = value;
		}
	}

	public EGSYesNo OnlyPlayerControlledSkillRotate
	{
		get
		{
			return onlyPlayerControlledSkillRotate_;
		}
		set
		{
			onlyPlayerControlledSkillRotate_ = value;
		}
	}

	public int DoneAddBuffID
	{
		get
		{
			return doneAddBuffID_;
		}
		set
		{
			doneAddBuffID_ = value;
		}
	}

	public int SkillHitSetSimpleState
	{
		get
		{
			return skillHitSetSimpleState_;
		}
		set
		{
			skillHitSetSimpleState_ = value;
		}
	}

	public string AtkReboundingMontage
	{
		get
		{
			return atkReboundingMontage_;
		}
		set
		{
			atkReboundingMontage_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string LowAtkReboundingMontage
	{
		get
		{
			return lowAtkReboundingMontage_;
		}
		set
		{
			lowAtkReboundingMontage_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string SkillArmorBrokeMontage
	{
		get
		{
			return skillArmorBrokeMontage_;
		}
		set
		{
			skillArmorBrokeMontage_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EGSYesNo IsComboSkill
	{
		get
		{
			return isComboSkill_;
		}
		set
		{
			isComboSkill_ = value;
		}
	}

	public EGSYesNo IsOverlying
	{
		get
		{
			return isOverlying_;
		}
		set
		{
			isOverlying_ = value;
		}
	}

	public EGSYesNo IsCanMoveAttack
	{
		get
		{
			return isCanMoveAttack_;
		}
		set
		{
			isCanMoveAttack_ = value;
		}
	}

	public string CooldownSkills
	{
		get
		{
			return cooldownSkills_;
		}
		set
		{
			cooldownSkills_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float AdditionalHatredValue
	{
		get
		{
			return additionalHatredValue_;
		}
		set
		{
			additionalHatredValue_ = value;
		}
	}

	public string Guard
	{
		get
		{
			return guard_;
		}
		set
		{
			guard_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStSkillSDesc()
	{
	}

	public FUStSkillSDesc(FUStSkillSDesc other)
		: this()
	{
		iD_ = other.iD_;
		skillBaseTarget_ = other.skillBaseTarget_;
		skillBaseTargetIntParams_ = other.skillBaseTargetIntParams_.Clone();
		skillBaseTargetStringParam_ = other.skillBaseTargetStringParam_;
		skillType_ = other.skillType_;
		moveSkillDisMinRate_ = other.moveSkillDisMinRate_;
		moveSkillDisMaxRate_ = other.moveSkillDisMaxRate_;
		templatePath_ = other.templatePath_;
		noiseLoudness_ = other.noiseLoudness_;
		minAttrCostType1_ = other.minAttrCostType1_;
		minAttrCostBase1_ = other.minAttrCostBase1_;
		minAttrCostRatio1_ = other.minAttrCostRatio1_;
		minAttrCostType2_ = other.minAttrCostType2_;
		minAttrCostBase2_ = other.minAttrCostBase2_;
		minAttrCostRatio2_ = other.minAttrCostRatio2_;
		preCooldownTime_ = other.preCooldownTime_;
		cooldownTime_ = other.cooldownTime_;
		cooldownType_ = other.cooldownType_;
		dmgRangeType_ = other.dmgRangeType_;
		skillRotateType_ = other.skillRotateType_;
		onlyPlayerControlledSkillRotate_ = other.onlyPlayerControlledSkillRotate_;
		doneAddBuffID_ = other.doneAddBuffID_;
		skillHitSetSimpleState_ = other.skillHitSetSimpleState_;
		atkReboundingMontage_ = other.atkReboundingMontage_;
		lowAtkReboundingMontage_ = other.lowAtkReboundingMontage_;
		skillArmorBrokeMontage_ = other.skillArmorBrokeMontage_;
		isComboSkill_ = other.isComboSkill_;
		isOverlying_ = other.isOverlying_;
		isCanMoveAttack_ = other.isCanMoveAttack_;
		cooldownSkills_ = other.cooldownSkills_;
		additionalHatredValue_ = other.additionalHatredValue_;
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStSkillSDesc Clone()
	{
		return new FUStSkillSDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStSkillSDesc);
	}

	public bool Equals(FUStSkillSDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (SkillBaseTarget != other.SkillBaseTarget)
		{
			return false;
		}
		if (!skillBaseTargetIntParams_.Equals(other.skillBaseTargetIntParams_))
		{
			return false;
		}
		if (SkillBaseTargetStringParam != other.SkillBaseTargetStringParam)
		{
			return false;
		}
		if (SkillType != other.SkillType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MoveSkillDisMinRate, other.MoveSkillDisMinRate))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MoveSkillDisMaxRate, other.MoveSkillDisMaxRate))
		{
			return false;
		}
		if (TemplatePath != other.TemplatePath)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(NoiseLoudness, other.NoiseLoudness))
		{
			return false;
		}
		if (MinAttrCostType1 != other.MinAttrCostType1)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MinAttrCostBase1, other.MinAttrCostBase1))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MinAttrCostRatio1, other.MinAttrCostRatio1))
		{
			return false;
		}
		if (MinAttrCostType2 != other.MinAttrCostType2)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MinAttrCostBase2, other.MinAttrCostBase2))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MinAttrCostRatio2, other.MinAttrCostRatio2))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PreCooldownTime, other.PreCooldownTime))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CooldownTime, other.CooldownTime))
		{
			return false;
		}
		if (CooldownType != other.CooldownType)
		{
			return false;
		}
		if (DmgRangeType != other.DmgRangeType)
		{
			return false;
		}
		if (SkillRotateType != other.SkillRotateType)
		{
			return false;
		}
		if (OnlyPlayerControlledSkillRotate != other.OnlyPlayerControlledSkillRotate)
		{
			return false;
		}
		if (DoneAddBuffID != other.DoneAddBuffID)
		{
			return false;
		}
		if (SkillHitSetSimpleState != other.SkillHitSetSimpleState)
		{
			return false;
		}
		if (AtkReboundingMontage != other.AtkReboundingMontage)
		{
			return false;
		}
		if (LowAtkReboundingMontage != other.LowAtkReboundingMontage)
		{
			return false;
		}
		if (SkillArmorBrokeMontage != other.SkillArmorBrokeMontage)
		{
			return false;
		}
		if (IsComboSkill != other.IsComboSkill)
		{
			return false;
		}
		if (IsOverlying != other.IsOverlying)
		{
			return false;
		}
		if (IsCanMoveAttack != other.IsCanMoveAttack)
		{
			return false;
		}
		if (CooldownSkills != other.CooldownSkills)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AdditionalHatredValue, other.AdditionalHatredValue))
		{
			return false;
		}
		if (Guard != other.Guard)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (SkillBaseTarget != ESkillBaseTarget.NoneOrCurrenttarget)
		{
			num ^= SkillBaseTarget.GetHashCode();
		}
		num ^= skillBaseTargetIntParams_.GetHashCode();
		if (SkillBaseTargetStringParam.Length != 0)
		{
			num ^= SkillBaseTargetStringParam.GetHashCode();
		}
		if (SkillType != ESkillType.NormalSkill)
		{
			num ^= SkillType.GetHashCode();
		}
		if (MoveSkillDisMinRate != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MoveSkillDisMinRate);
		}
		if (MoveSkillDisMaxRate != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MoveSkillDisMaxRate);
		}
		if (TemplatePath.Length != 0)
		{
			num ^= TemplatePath.GetHashCode();
		}
		if (NoiseLoudness != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(NoiseLoudness);
		}
		if (MinAttrCostType1 != EAttrCostType.None)
		{
			num ^= MinAttrCostType1.GetHashCode();
		}
		if (MinAttrCostBase1 != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MinAttrCostBase1);
		}
		if (MinAttrCostRatio1 != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MinAttrCostRatio1);
		}
		if (MinAttrCostType2 != EAttrCostType.None)
		{
			num ^= MinAttrCostType2.GetHashCode();
		}
		if (MinAttrCostBase2 != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MinAttrCostBase2);
		}
		if (MinAttrCostRatio2 != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MinAttrCostRatio2);
		}
		if (PreCooldownTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PreCooldownTime);
		}
		if (CooldownTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CooldownTime);
		}
		if (CooldownType != ESkillCooldownType.TryToCast)
		{
			num ^= CooldownType.GetHashCode();
		}
		if (DmgRangeType != EDmgRangeType.Default)
		{
			num ^= DmgRangeType.GetHashCode();
		}
		if (SkillRotateType != ESkillRotateType.None)
		{
			num ^= SkillRotateType.GetHashCode();
		}
		if (OnlyPlayerControlledSkillRotate != EGSYesNo.No)
		{
			num ^= OnlyPlayerControlledSkillRotate.GetHashCode();
		}
		if (DoneAddBuffID != 0)
		{
			num ^= DoneAddBuffID.GetHashCode();
		}
		if (SkillHitSetSimpleState != 0)
		{
			num ^= SkillHitSetSimpleState.GetHashCode();
		}
		if (AtkReboundingMontage.Length != 0)
		{
			num ^= AtkReboundingMontage.GetHashCode();
		}
		if (LowAtkReboundingMontage.Length != 0)
		{
			num ^= LowAtkReboundingMontage.GetHashCode();
		}
		if (SkillArmorBrokeMontage.Length != 0)
		{
			num ^= SkillArmorBrokeMontage.GetHashCode();
		}
		if (IsComboSkill != EGSYesNo.No)
		{
			num ^= IsComboSkill.GetHashCode();
		}
		if (IsOverlying != EGSYesNo.No)
		{
			num ^= IsOverlying.GetHashCode();
		}
		if (IsCanMoveAttack != EGSYesNo.No)
		{
			num ^= IsCanMoveAttack.GetHashCode();
		}
		if (CooldownSkills.Length != 0)
		{
			num ^= CooldownSkills.GetHashCode();
		}
		if (AdditionalHatredValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AdditionalHatredValue);
		}
		if (Guard.Length != 0)
		{
			num ^= Guard.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (SkillBaseTarget != ESkillBaseTarget.NoneOrCurrenttarget)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)SkillBaseTarget);
		}
		skillBaseTargetIntParams_.WriteTo(output, _repeated_skillBaseTargetIntParams_codec);
		if (SkillBaseTargetStringParam.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(SkillBaseTargetStringParam);
		}
		if (SkillType != ESkillType.NormalSkill)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)SkillType);
		}
		if (MoveSkillDisMinRate != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(MoveSkillDisMinRate);
		}
		if (MoveSkillDisMaxRate != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(MoveSkillDisMaxRate);
		}
		if (TemplatePath.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(TemplatePath);
		}
		if (NoiseLoudness != 0f)
		{
			output.WriteRawTag(77);
			output.WriteFloat(NoiseLoudness);
		}
		if (MinAttrCostType1 != EAttrCostType.None)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)MinAttrCostType1);
		}
		if (MinAttrCostBase1 != 0f)
		{
			output.WriteRawTag(93);
			output.WriteFloat(MinAttrCostBase1);
		}
		if (MinAttrCostRatio1 != 0f)
		{
			output.WriteRawTag(101);
			output.WriteFloat(MinAttrCostRatio1);
		}
		if (MinAttrCostType2 != EAttrCostType.None)
		{
			output.WriteRawTag(104);
			output.WriteEnum((int)MinAttrCostType2);
		}
		if (MinAttrCostBase2 != 0f)
		{
			output.WriteRawTag(117);
			output.WriteFloat(MinAttrCostBase2);
		}
		if (MinAttrCostRatio2 != 0f)
		{
			output.WriteRawTag(125);
			output.WriteFloat(MinAttrCostRatio2);
		}
		if (PreCooldownTime != 0f)
		{
			output.WriteRawTag(133, 1);
			output.WriteFloat(PreCooldownTime);
		}
		if (CooldownTime != 0f)
		{
			output.WriteRawTag(141, 1);
			output.WriteFloat(CooldownTime);
		}
		if (CooldownType != ESkillCooldownType.TryToCast)
		{
			output.WriteRawTag(144, 1);
			output.WriteEnum((int)CooldownType);
		}
		if (DmgRangeType != EDmgRangeType.Default)
		{
			output.WriteRawTag(152, 1);
			output.WriteEnum((int)DmgRangeType);
		}
		if (SkillRotateType != ESkillRotateType.None)
		{
			output.WriteRawTag(160, 1);
			output.WriteEnum((int)SkillRotateType);
		}
		if (OnlyPlayerControlledSkillRotate != EGSYesNo.No)
		{
			output.WriteRawTag(168, 1);
			output.WriteEnum((int)OnlyPlayerControlledSkillRotate);
		}
		if (DoneAddBuffID != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(DoneAddBuffID);
		}
		if (SkillHitSetSimpleState != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteInt32(SkillHitSetSimpleState);
		}
		if (AtkReboundingMontage.Length != 0)
		{
			output.WriteRawTag(194, 1);
			output.WriteString(AtkReboundingMontage);
		}
		if (LowAtkReboundingMontage.Length != 0)
		{
			output.WriteRawTag(202, 1);
			output.WriteString(LowAtkReboundingMontage);
		}
		if (SkillArmorBrokeMontage.Length != 0)
		{
			output.WriteRawTag(210, 1);
			output.WriteString(SkillArmorBrokeMontage);
		}
		if (IsComboSkill != EGSYesNo.No)
		{
			output.WriteRawTag(216, 1);
			output.WriteEnum((int)IsComboSkill);
		}
		if (IsOverlying != EGSYesNo.No)
		{
			output.WriteRawTag(224, 1);
			output.WriteEnum((int)IsOverlying);
		}
		if (IsCanMoveAttack != EGSYesNo.No)
		{
			output.WriteRawTag(232, 1);
			output.WriteEnum((int)IsCanMoveAttack);
		}
		if (CooldownSkills.Length != 0)
		{
			output.WriteRawTag(242, 1);
			output.WriteString(CooldownSkills);
		}
		if (AdditionalHatredValue != 0f)
		{
			output.WriteRawTag(253, 1);
			output.WriteFloat(AdditionalHatredValue);
		}
		if (Guard.Length != 0)
		{
			output.WriteRawTag(130, 2);
			output.WriteString(Guard);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (SkillBaseTarget != ESkillBaseTarget.NoneOrCurrenttarget)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SkillBaseTarget);
		}
		num += skillBaseTargetIntParams_.CalculateSize(_repeated_skillBaseTargetIntParams_codec);
		if (SkillBaseTargetStringParam.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SkillBaseTargetStringParam);
		}
		if (SkillType != ESkillType.NormalSkill)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SkillType);
		}
		if (MoveSkillDisMinRate != 0f)
		{
			num += 5;
		}
		if (MoveSkillDisMaxRate != 0f)
		{
			num += 5;
		}
		if (TemplatePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TemplatePath);
		}
		if (NoiseLoudness != 0f)
		{
			num += 5;
		}
		if (MinAttrCostType1 != EAttrCostType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MinAttrCostType1);
		}
		if (MinAttrCostBase1 != 0f)
		{
			num += 5;
		}
		if (MinAttrCostRatio1 != 0f)
		{
			num += 5;
		}
		if (MinAttrCostType2 != EAttrCostType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MinAttrCostType2);
		}
		if (MinAttrCostBase2 != 0f)
		{
			num += 5;
		}
		if (MinAttrCostRatio2 != 0f)
		{
			num += 5;
		}
		if (PreCooldownTime != 0f)
		{
			num += 6;
		}
		if (CooldownTime != 0f)
		{
			num += 6;
		}
		if (CooldownType != ESkillCooldownType.TryToCast)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)CooldownType);
		}
		if (DmgRangeType != EDmgRangeType.Default)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)DmgRangeType);
		}
		if (SkillRotateType != ESkillRotateType.None)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)SkillRotateType);
		}
		if (OnlyPlayerControlledSkillRotate != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)OnlyPlayerControlledSkillRotate);
		}
		if (DoneAddBuffID != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DoneAddBuffID);
		}
		if (SkillHitSetSimpleState != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SkillHitSetSimpleState);
		}
		if (AtkReboundingMontage.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(AtkReboundingMontage);
		}
		if (LowAtkReboundingMontage.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LowAtkReboundingMontage);
		}
		if (SkillArmorBrokeMontage.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(SkillArmorBrokeMontage);
		}
		if (IsComboSkill != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)IsComboSkill);
		}
		if (IsOverlying != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)IsOverlying);
		}
		if (IsCanMoveAttack != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)IsCanMoveAttack);
		}
		if (CooldownSkills.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(CooldownSkills);
		}
		if (AdditionalHatredValue != 0f)
		{
			num += 6;
		}
		if (Guard.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(Guard);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStSkillSDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.SkillBaseTarget != ESkillBaseTarget.NoneOrCurrenttarget)
			{
				SkillBaseTarget = other.SkillBaseTarget;
			}
			skillBaseTargetIntParams_.Add(other.skillBaseTargetIntParams_);
			if (other.SkillBaseTargetStringParam.Length != 0)
			{
				SkillBaseTargetStringParam = other.SkillBaseTargetStringParam;
			}
			if (other.SkillType != ESkillType.NormalSkill)
			{
				SkillType = other.SkillType;
			}
			if (other.MoveSkillDisMinRate != 0f)
			{
				MoveSkillDisMinRate = other.MoveSkillDisMinRate;
			}
			if (other.MoveSkillDisMaxRate != 0f)
			{
				MoveSkillDisMaxRate = other.MoveSkillDisMaxRate;
			}
			if (other.TemplatePath.Length != 0)
			{
				TemplatePath = other.TemplatePath;
			}
			if (other.NoiseLoudness != 0f)
			{
				NoiseLoudness = other.NoiseLoudness;
			}
			if (other.MinAttrCostType1 != EAttrCostType.None)
			{
				MinAttrCostType1 = other.MinAttrCostType1;
			}
			if (other.MinAttrCostBase1 != 0f)
			{
				MinAttrCostBase1 = other.MinAttrCostBase1;
			}
			if (other.MinAttrCostRatio1 != 0f)
			{
				MinAttrCostRatio1 = other.MinAttrCostRatio1;
			}
			if (other.MinAttrCostType2 != EAttrCostType.None)
			{
				MinAttrCostType2 = other.MinAttrCostType2;
			}
			if (other.MinAttrCostBase2 != 0f)
			{
				MinAttrCostBase2 = other.MinAttrCostBase2;
			}
			if (other.MinAttrCostRatio2 != 0f)
			{
				MinAttrCostRatio2 = other.MinAttrCostRatio2;
			}
			if (other.PreCooldownTime != 0f)
			{
				PreCooldownTime = other.PreCooldownTime;
			}
			if (other.CooldownTime != 0f)
			{
				CooldownTime = other.CooldownTime;
			}
			if (other.CooldownType != ESkillCooldownType.TryToCast)
			{
				CooldownType = other.CooldownType;
			}
			if (other.DmgRangeType != EDmgRangeType.Default)
			{
				DmgRangeType = other.DmgRangeType;
			}
			if (other.SkillRotateType != ESkillRotateType.None)
			{
				SkillRotateType = other.SkillRotateType;
			}
			if (other.OnlyPlayerControlledSkillRotate != EGSYesNo.No)
			{
				OnlyPlayerControlledSkillRotate = other.OnlyPlayerControlledSkillRotate;
			}
			if (other.DoneAddBuffID != 0)
			{
				DoneAddBuffID = other.DoneAddBuffID;
			}
			if (other.SkillHitSetSimpleState != 0)
			{
				SkillHitSetSimpleState = other.SkillHitSetSimpleState;
			}
			if (other.AtkReboundingMontage.Length != 0)
			{
				AtkReboundingMontage = other.AtkReboundingMontage;
			}
			if (other.LowAtkReboundingMontage.Length != 0)
			{
				LowAtkReboundingMontage = other.LowAtkReboundingMontage;
			}
			if (other.SkillArmorBrokeMontage.Length != 0)
			{
				SkillArmorBrokeMontage = other.SkillArmorBrokeMontage;
			}
			if (other.IsComboSkill != EGSYesNo.No)
			{
				IsComboSkill = other.IsComboSkill;
			}
			if (other.IsOverlying != EGSYesNo.No)
			{
				IsOverlying = other.IsOverlying;
			}
			if (other.IsCanMoveAttack != EGSYesNo.No)
			{
				IsCanMoveAttack = other.IsCanMoveAttack;
			}
			if (other.CooldownSkills.Length != 0)
			{
				CooldownSkills = other.CooldownSkills;
			}
			if (other.AdditionalHatredValue != 0f)
			{
				AdditionalHatredValue = other.AdditionalHatredValue;
			}
			if (other.Guard.Length != 0)
			{
				Guard = other.Guard;
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
				ID = input.ReadInt32();
				break;
			case 16u:
				SkillBaseTarget = (ESkillBaseTarget)input.ReadEnum();
				break;
			case 24u:
			case 26u:
				skillBaseTargetIntParams_.AddEntriesFrom(input, _repeated_skillBaseTargetIntParams_codec);
				break;
			case 34u:
				SkillBaseTargetStringParam = input.ReadString();
				break;
			case 40u:
				SkillType = (ESkillType)input.ReadEnum();
				break;
			case 53u:
				MoveSkillDisMinRate = input.ReadFloat();
				break;
			case 61u:
				MoveSkillDisMaxRate = input.ReadFloat();
				break;
			case 66u:
				TemplatePath = input.ReadString();
				break;
			case 77u:
				NoiseLoudness = input.ReadFloat();
				break;
			case 80u:
				MinAttrCostType1 = (EAttrCostType)input.ReadEnum();
				break;
			case 93u:
				MinAttrCostBase1 = input.ReadFloat();
				break;
			case 101u:
				MinAttrCostRatio1 = input.ReadFloat();
				break;
			case 104u:
				MinAttrCostType2 = (EAttrCostType)input.ReadEnum();
				break;
			case 117u:
				MinAttrCostBase2 = input.ReadFloat();
				break;
			case 125u:
				MinAttrCostRatio2 = input.ReadFloat();
				break;
			case 133u:
				PreCooldownTime = input.ReadFloat();
				break;
			case 141u:
				CooldownTime = input.ReadFloat();
				break;
			case 144u:
				CooldownType = (ESkillCooldownType)input.ReadEnum();
				break;
			case 152u:
				DmgRangeType = (EDmgRangeType)input.ReadEnum();
				break;
			case 160u:
				SkillRotateType = (ESkillRotateType)input.ReadEnum();
				break;
			case 168u:
				OnlyPlayerControlledSkillRotate = (EGSYesNo)input.ReadEnum();
				break;
			case 176u:
				DoneAddBuffID = input.ReadInt32();
				break;
			case 184u:
				SkillHitSetSimpleState = input.ReadInt32();
				break;
			case 194u:
				AtkReboundingMontage = input.ReadString();
				break;
			case 202u:
				LowAtkReboundingMontage = input.ReadString();
				break;
			case 210u:
				SkillArmorBrokeMontage = input.ReadString();
				break;
			case 216u:
				IsComboSkill = (EGSYesNo)input.ReadEnum();
				break;
			case 224u:
				IsOverlying = (EGSYesNo)input.ReadEnum();
				break;
			case 232u:
				IsCanMoveAttack = (EGSYesNo)input.ReadEnum();
				break;
			case 242u:
				CooldownSkills = input.ReadString();
				break;
			case 253u:
				AdditionalHatredValue = input.ReadFloat();
				break;
			case 258u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
