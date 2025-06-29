using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlX2;

public sealed class FUStB2DSkillEffectDesc : IMessage<FUStB2DSkillEffectDesc>, IMessage, IEquatable<FUStB2DSkillEffectDesc>, IDeepCloneable<FUStB2DSkillEffectDesc>
{
	private static readonly MessageParser<FUStB2DSkillEffectDesc> _parser = new MessageParser<FUStB2DSkillEffectDesc>(() => new FUStB2DSkillEffectDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int targetBaseParam1_;

	private int targetBaseParam2_;

	private int targetBaseParam3_;

	private int targetBaseParam4_;

	private EB2DBuffAndSkillEffectType effectType_;

	private static readonly FieldCodec<int> _repeated_effectParamsInt_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> effectParamsInt_ = new RepeatedField<int>();

	private static readonly FieldCodec<float> _repeated_effectParamsFloat_codec = FieldCodec.ForFloat(66u);

	private readonly RepeatedField<float> effectParamsFloat_ = new RepeatedField<float>();

	private static readonly FieldCodec<string> _repeated_effectParamsStr_codec = FieldCodec.ForString(74u);

	private readonly RepeatedField<string> effectParamsStr_ = new RepeatedField<string>();

	private int targetFilter_;

	private EB2DEffectRangeTargetBase targetBase_;

	private int targetCount_;

	private FUStB2DRange range_;

	private EB2DSEffectTriggerType effectTriggerType_;

	private int effectTriggerTypeParam1_;

	private int effectTriggerTypeParam2_;

	private int mpAdd_;

	private string hitEfxPath_ = "";

	private float hitEfxDuration_;

	private EB2DDispPredefineDir hitEfxAttackFrom_;

	private string hitEfxAnchor_ = "";

	private int targetFlickerType_;

	private int targetFlickerPriority_;

	private float targetFlickerDuration_;

	private int targetFlickerLoop_;

	private static readonly FieldCodec<int> _repeated_effectFollowLevel_codec = FieldCodec.ForInt32(210u);

	private readonly RepeatedField<int> effectFollowLevel_ = new RepeatedField<int>();

	private string attackEfxPath_ = "";

	private float attackEfxDuration_;

	private FUStB2DSkillShakeData shakeData_;

	private float breakSkillAngle_;

	private int wieldAir_;

	private int wieldAirWithEffect_;

	public static MessageParser<FUStB2DSkillEffectDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public int TargetBaseParam1
	{
		get
		{
			return targetBaseParam1_;
		}
		set
		{
			targetBaseParam1_ = value;
		}
	}

	public int TargetBaseParam2
	{
		get
		{
			return targetBaseParam2_;
		}
		set
		{
			targetBaseParam2_ = value;
		}
	}

	public int TargetBaseParam3
	{
		get
		{
			return targetBaseParam3_;
		}
		set
		{
			targetBaseParam3_ = value;
		}
	}

	public int TargetBaseParam4
	{
		get
		{
			return targetBaseParam4_;
		}
		set
		{
			targetBaseParam4_ = value;
		}
	}

	public EB2DBuffAndSkillEffectType EffectType
	{
		get
		{
			return effectType_;
		}
		set
		{
			effectType_ = value;
		}
	}

	public RepeatedField<int> EffectParamsInt => effectParamsInt_;

	public RepeatedField<float> EffectParamsFloat => effectParamsFloat_;

	public RepeatedField<string> EffectParamsStr => effectParamsStr_;

	public int TargetFilter
	{
		get
		{
			return targetFilter_;
		}
		set
		{
			targetFilter_ = value;
		}
	}

	public EB2DEffectRangeTargetBase TargetBase
	{
		get
		{
			return targetBase_;
		}
		set
		{
			targetBase_ = value;
		}
	}

	public int TargetCount
	{
		get
		{
			return targetCount_;
		}
		set
		{
			targetCount_ = value;
		}
	}

	public FUStB2DRange Range
	{
		get
		{
			return range_;
		}
		set
		{
			range_ = value;
		}
	}

	public EB2DSEffectTriggerType EffectTriggerType
	{
		get
		{
			return effectTriggerType_;
		}
		set
		{
			effectTriggerType_ = value;
		}
	}

	public int EffectTriggerTypeParam1
	{
		get
		{
			return effectTriggerTypeParam1_;
		}
		set
		{
			effectTriggerTypeParam1_ = value;
		}
	}

	public int EffectTriggerTypeParam2
	{
		get
		{
			return effectTriggerTypeParam2_;
		}
		set
		{
			effectTriggerTypeParam2_ = value;
		}
	}

	public int MpAdd
	{
		get
		{
			return mpAdd_;
		}
		set
		{
			mpAdd_ = value;
		}
	}

	public string HitEfxPath
	{
		get
		{
			return hitEfxPath_;
		}
		set
		{
			hitEfxPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float HitEfxDuration
	{
		get
		{
			return hitEfxDuration_;
		}
		set
		{
			hitEfxDuration_ = value;
		}
	}

	public EB2DDispPredefineDir HitEfxAttackFrom
	{
		get
		{
			return hitEfxAttackFrom_;
		}
		set
		{
			hitEfxAttackFrom_ = value;
		}
	}

	public string HitEfxAnchor
	{
		get
		{
			return hitEfxAnchor_;
		}
		set
		{
			hitEfxAnchor_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int TargetFlickerType
	{
		get
		{
			return targetFlickerType_;
		}
		set
		{
			targetFlickerType_ = value;
		}
	}

	public int TargetFlickerPriority
	{
		get
		{
			return targetFlickerPriority_;
		}
		set
		{
			targetFlickerPriority_ = value;
		}
	}

	public float TargetFlickerDuration
	{
		get
		{
			return targetFlickerDuration_;
		}
		set
		{
			targetFlickerDuration_ = value;
		}
	}

	public int TargetFlickerLoop
	{
		get
		{
			return targetFlickerLoop_;
		}
		set
		{
			targetFlickerLoop_ = value;
		}
	}

	public RepeatedField<int> EffectFollowLevel => effectFollowLevel_;

	public string AttackEfxPath
	{
		get
		{
			return attackEfxPath_;
		}
		set
		{
			attackEfxPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float AttackEfxDuration
	{
		get
		{
			return attackEfxDuration_;
		}
		set
		{
			attackEfxDuration_ = value;
		}
	}

	public FUStB2DSkillShakeData ShakeData
	{
		get
		{
			return shakeData_;
		}
		set
		{
			shakeData_ = value;
		}
	}

	public float BreakSkillAngle
	{
		get
		{
			return breakSkillAngle_;
		}
		set
		{
			breakSkillAngle_ = value;
		}
	}

	public int WieldAir
	{
		get
		{
			return wieldAir_;
		}
		set
		{
			wieldAir_ = value;
		}
	}

	public int WieldAirWithEffect
	{
		get
		{
			return wieldAirWithEffect_;
		}
		set
		{
			wieldAirWithEffect_ = value;
		}
	}

	public FUStB2DSkillEffectDesc()
	{
	}

	public FUStB2DSkillEffectDesc(FUStB2DSkillEffectDesc other)
		: this()
	{
		id_ = other.id_;
		targetBaseParam1_ = other.targetBaseParam1_;
		targetBaseParam2_ = other.targetBaseParam2_;
		targetBaseParam3_ = other.targetBaseParam3_;
		targetBaseParam4_ = other.targetBaseParam4_;
		effectType_ = other.effectType_;
		effectParamsInt_ = other.effectParamsInt_.Clone();
		effectParamsFloat_ = other.effectParamsFloat_.Clone();
		effectParamsStr_ = other.effectParamsStr_.Clone();
		targetFilter_ = other.targetFilter_;
		targetBase_ = other.targetBase_;
		targetCount_ = other.targetCount_;
		range_ = ((other.range_ != null) ? other.range_.Clone() : null);
		effectTriggerType_ = other.effectTriggerType_;
		effectTriggerTypeParam1_ = other.effectTriggerTypeParam1_;
		effectTriggerTypeParam2_ = other.effectTriggerTypeParam2_;
		mpAdd_ = other.mpAdd_;
		hitEfxPath_ = other.hitEfxPath_;
		hitEfxDuration_ = other.hitEfxDuration_;
		hitEfxAttackFrom_ = other.hitEfxAttackFrom_;
		hitEfxAnchor_ = other.hitEfxAnchor_;
		targetFlickerType_ = other.targetFlickerType_;
		targetFlickerPriority_ = other.targetFlickerPriority_;
		targetFlickerDuration_ = other.targetFlickerDuration_;
		targetFlickerLoop_ = other.targetFlickerLoop_;
		effectFollowLevel_ = other.effectFollowLevel_.Clone();
		attackEfxPath_ = other.attackEfxPath_;
		attackEfxDuration_ = other.attackEfxDuration_;
		shakeData_ = ((other.shakeData_ != null) ? other.shakeData_.Clone() : null);
		breakSkillAngle_ = other.breakSkillAngle_;
		wieldAir_ = other.wieldAir_;
		wieldAirWithEffect_ = other.wieldAirWithEffect_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DSkillEffectDesc Clone()
	{
		return new FUStB2DSkillEffectDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DSkillEffectDesc);
	}

	public bool Equals(FUStB2DSkillEffectDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (TargetBaseParam1 != other.TargetBaseParam1)
		{
			return false;
		}
		if (TargetBaseParam2 != other.TargetBaseParam2)
		{
			return false;
		}
		if (TargetBaseParam3 != other.TargetBaseParam3)
		{
			return false;
		}
		if (TargetBaseParam4 != other.TargetBaseParam4)
		{
			return false;
		}
		if (EffectType != other.EffectType)
		{
			return false;
		}
		if (!effectParamsInt_.Equals(other.effectParamsInt_))
		{
			return false;
		}
		if (!effectParamsFloat_.Equals(other.effectParamsFloat_))
		{
			return false;
		}
		if (!effectParamsStr_.Equals(other.effectParamsStr_))
		{
			return false;
		}
		if (TargetFilter != other.TargetFilter)
		{
			return false;
		}
		if (TargetBase != other.TargetBase)
		{
			return false;
		}
		if (TargetCount != other.TargetCount)
		{
			return false;
		}
		if (!object.Equals(Range, other.Range))
		{
			return false;
		}
		if (EffectTriggerType != other.EffectTriggerType)
		{
			return false;
		}
		if (EffectTriggerTypeParam1 != other.EffectTriggerTypeParam1)
		{
			return false;
		}
		if (EffectTriggerTypeParam2 != other.EffectTriggerTypeParam2)
		{
			return false;
		}
		if (MpAdd != other.MpAdd)
		{
			return false;
		}
		if (HitEfxPath != other.HitEfxPath)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(HitEfxDuration, other.HitEfxDuration))
		{
			return false;
		}
		if (HitEfxAttackFrom != other.HitEfxAttackFrom)
		{
			return false;
		}
		if (HitEfxAnchor != other.HitEfxAnchor)
		{
			return false;
		}
		if (TargetFlickerType != other.TargetFlickerType)
		{
			return false;
		}
		if (TargetFlickerPriority != other.TargetFlickerPriority)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TargetFlickerDuration, other.TargetFlickerDuration))
		{
			return false;
		}
		if (TargetFlickerLoop != other.TargetFlickerLoop)
		{
			return false;
		}
		if (!effectFollowLevel_.Equals(other.effectFollowLevel_))
		{
			return false;
		}
		if (AttackEfxPath != other.AttackEfxPath)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AttackEfxDuration, other.AttackEfxDuration))
		{
			return false;
		}
		if (!object.Equals(ShakeData, other.ShakeData))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BreakSkillAngle, other.BreakSkillAngle))
		{
			return false;
		}
		if (WieldAir != other.WieldAir)
		{
			return false;
		}
		if (WieldAirWithEffect != other.WieldAirWithEffect)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (TargetBaseParam1 != 0)
		{
			num ^= TargetBaseParam1.GetHashCode();
		}
		if (TargetBaseParam2 != 0)
		{
			num ^= TargetBaseParam2.GetHashCode();
		}
		if (TargetBaseParam3 != 0)
		{
			num ^= TargetBaseParam3.GetHashCode();
		}
		if (TargetBaseParam4 != 0)
		{
			num ^= TargetBaseParam4.GetHashCode();
		}
		if (EffectType != EB2DBuffAndSkillEffectType.None)
		{
			num ^= EffectType.GetHashCode();
		}
		num ^= effectParamsInt_.GetHashCode();
		num ^= effectParamsFloat_.GetHashCode();
		num ^= effectParamsStr_.GetHashCode();
		if (TargetFilter != 0)
		{
			num ^= TargetFilter.GetHashCode();
		}
		if (TargetBase != EB2DEffectRangeTargetBase.Auto)
		{
			num ^= TargetBase.GetHashCode();
		}
		if (TargetCount != 0)
		{
			num ^= TargetCount.GetHashCode();
		}
		if (range_ != null)
		{
			num ^= Range.GetHashCode();
		}
		if (EffectTriggerType != EB2DSEffectTriggerType.Default)
		{
			num ^= EffectTriggerType.GetHashCode();
		}
		if (EffectTriggerTypeParam1 != 0)
		{
			num ^= EffectTriggerTypeParam1.GetHashCode();
		}
		if (EffectTriggerTypeParam2 != 0)
		{
			num ^= EffectTriggerTypeParam2.GetHashCode();
		}
		if (MpAdd != 0)
		{
			num ^= MpAdd.GetHashCode();
		}
		if (HitEfxPath.Length != 0)
		{
			num ^= HitEfxPath.GetHashCode();
		}
		if (HitEfxDuration != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(HitEfxDuration);
		}
		if (HitEfxAttackFrom != EB2DDispPredefineDir.Null)
		{
			num ^= HitEfxAttackFrom.GetHashCode();
		}
		if (HitEfxAnchor.Length != 0)
		{
			num ^= HitEfxAnchor.GetHashCode();
		}
		if (TargetFlickerType != 0)
		{
			num ^= TargetFlickerType.GetHashCode();
		}
		if (TargetFlickerPriority != 0)
		{
			num ^= TargetFlickerPriority.GetHashCode();
		}
		if (TargetFlickerDuration != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TargetFlickerDuration);
		}
		if (TargetFlickerLoop != 0)
		{
			num ^= TargetFlickerLoop.GetHashCode();
		}
		num ^= effectFollowLevel_.GetHashCode();
		if (AttackEfxPath.Length != 0)
		{
			num ^= AttackEfxPath.GetHashCode();
		}
		if (AttackEfxDuration != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AttackEfxDuration);
		}
		if (shakeData_ != null)
		{
			num ^= ShakeData.GetHashCode();
		}
		if (BreakSkillAngle != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BreakSkillAngle);
		}
		if (WieldAir != 0)
		{
			num ^= WieldAir.GetHashCode();
		}
		if (WieldAirWithEffect != 0)
		{
			num ^= WieldAirWithEffect.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (TargetBaseParam1 != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(TargetBaseParam1);
		}
		if (TargetBaseParam2 != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(TargetBaseParam2);
		}
		if (TargetBaseParam3 != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(TargetBaseParam3);
		}
		if (TargetBaseParam4 != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(TargetBaseParam4);
		}
		if (EffectType != EB2DBuffAndSkillEffectType.None)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)EffectType);
		}
		effectParamsInt_.WriteTo(output, _repeated_effectParamsInt_codec);
		effectParamsFloat_.WriteTo(output, _repeated_effectParamsFloat_codec);
		effectParamsStr_.WriteTo(output, _repeated_effectParamsStr_codec);
		if (TargetFilter != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(TargetFilter);
		}
		if (TargetBase != EB2DEffectRangeTargetBase.Auto)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)TargetBase);
		}
		if (TargetCount != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(TargetCount);
		}
		if (range_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(Range);
		}
		if (EffectTriggerType != EB2DSEffectTriggerType.Default)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)EffectTriggerType);
		}
		if (EffectTriggerTypeParam1 != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(EffectTriggerTypeParam1);
		}
		if (EffectTriggerTypeParam2 != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(EffectTriggerTypeParam2);
		}
		if (MpAdd != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(MpAdd);
		}
		if (HitEfxPath.Length != 0)
		{
			output.WriteRawTag(146, 1);
			output.WriteString(HitEfxPath);
		}
		if (HitEfxDuration != 0f)
		{
			output.WriteRawTag(157, 1);
			output.WriteFloat(HitEfxDuration);
		}
		if (HitEfxAttackFrom != EB2DDispPredefineDir.Null)
		{
			output.WriteRawTag(160, 1);
			output.WriteEnum((int)HitEfxAttackFrom);
		}
		if (HitEfxAnchor.Length != 0)
		{
			output.WriteRawTag(170, 1);
			output.WriteString(HitEfxAnchor);
		}
		if (TargetFlickerType != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(TargetFlickerType);
		}
		if (TargetFlickerPriority != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteInt32(TargetFlickerPriority);
		}
		if (TargetFlickerDuration != 0f)
		{
			output.WriteRawTag(197, 1);
			output.WriteFloat(TargetFlickerDuration);
		}
		if (TargetFlickerLoop != 0)
		{
			output.WriteRawTag(200, 1);
			output.WriteInt32(TargetFlickerLoop);
		}
		effectFollowLevel_.WriteTo(output, _repeated_effectFollowLevel_codec);
		if (AttackEfxPath.Length != 0)
		{
			output.WriteRawTag(218, 1);
			output.WriteString(AttackEfxPath);
		}
		if (AttackEfxDuration != 0f)
		{
			output.WriteRawTag(229, 1);
			output.WriteFloat(AttackEfxDuration);
		}
		if (shakeData_ != null)
		{
			output.WriteRawTag(234, 1);
			output.WriteMessage(ShakeData);
		}
		if (BreakSkillAngle != 0f)
		{
			output.WriteRawTag(245, 1);
			output.WriteFloat(BreakSkillAngle);
		}
		if (WieldAir != 0)
		{
			output.WriteRawTag(248, 1);
			output.WriteInt32(WieldAir);
		}
		if (WieldAirWithEffect != 0)
		{
			output.WriteRawTag(128, 2);
			output.WriteInt32(WieldAirWithEffect);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (TargetBaseParam1 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetBaseParam1);
		}
		if (TargetBaseParam2 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetBaseParam2);
		}
		if (TargetBaseParam3 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetBaseParam3);
		}
		if (TargetBaseParam4 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetBaseParam4);
		}
		if (EffectType != EB2DBuffAndSkillEffectType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EffectType);
		}
		num += effectParamsInt_.CalculateSize(_repeated_effectParamsInt_codec);
		num += effectParamsFloat_.CalculateSize(_repeated_effectParamsFloat_codec);
		num += effectParamsStr_.CalculateSize(_repeated_effectParamsStr_codec);
		if (TargetFilter != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetFilter);
		}
		if (TargetBase != EB2DEffectRangeTargetBase.Auto)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)TargetBase);
		}
		if (TargetCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetCount);
		}
		if (range_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Range);
		}
		if (EffectTriggerType != EB2DSEffectTriggerType.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EffectTriggerType);
		}
		if (EffectTriggerTypeParam1 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EffectTriggerTypeParam1);
		}
		if (EffectTriggerTypeParam2 != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(EffectTriggerTypeParam2);
		}
		if (MpAdd != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MpAdd);
		}
		if (HitEfxPath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(HitEfxPath);
		}
		if (HitEfxDuration != 0f)
		{
			num += 6;
		}
		if (HitEfxAttackFrom != EB2DDispPredefineDir.Null)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)HitEfxAttackFrom);
		}
		if (HitEfxAnchor.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(HitEfxAnchor);
		}
		if (TargetFlickerType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TargetFlickerType);
		}
		if (TargetFlickerPriority != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TargetFlickerPriority);
		}
		if (TargetFlickerDuration != 0f)
		{
			num += 6;
		}
		if (TargetFlickerLoop != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TargetFlickerLoop);
		}
		num += effectFollowLevel_.CalculateSize(_repeated_effectFollowLevel_codec);
		if (AttackEfxPath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(AttackEfxPath);
		}
		if (AttackEfxDuration != 0f)
		{
			num += 6;
		}
		if (shakeData_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ShakeData);
		}
		if (BreakSkillAngle != 0f)
		{
			num += 6;
		}
		if (WieldAir != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(WieldAir);
		}
		if (WieldAirWithEffect != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(WieldAirWithEffect);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DSkillEffectDesc other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Id != 0)
		{
			Id = other.Id;
		}
		if (other.TargetBaseParam1 != 0)
		{
			TargetBaseParam1 = other.TargetBaseParam1;
		}
		if (other.TargetBaseParam2 != 0)
		{
			TargetBaseParam2 = other.TargetBaseParam2;
		}
		if (other.TargetBaseParam3 != 0)
		{
			TargetBaseParam3 = other.TargetBaseParam3;
		}
		if (other.TargetBaseParam4 != 0)
		{
			TargetBaseParam4 = other.TargetBaseParam4;
		}
		if (other.EffectType != EB2DBuffAndSkillEffectType.None)
		{
			EffectType = other.EffectType;
		}
		effectParamsInt_.Add(other.effectParamsInt_);
		effectParamsFloat_.Add(other.effectParamsFloat_);
		effectParamsStr_.Add(other.effectParamsStr_);
		if (other.TargetFilter != 0)
		{
			TargetFilter = other.TargetFilter;
		}
		if (other.TargetBase != EB2DEffectRangeTargetBase.Auto)
		{
			TargetBase = other.TargetBase;
		}
		if (other.TargetCount != 0)
		{
			TargetCount = other.TargetCount;
		}
		if (other.range_ != null)
		{
			if (range_ == null)
			{
				Range = new FUStB2DRange();
			}
			Range.MergeFrom(other.Range);
		}
		if (other.EffectTriggerType != EB2DSEffectTriggerType.Default)
		{
			EffectTriggerType = other.EffectTriggerType;
		}
		if (other.EffectTriggerTypeParam1 != 0)
		{
			EffectTriggerTypeParam1 = other.EffectTriggerTypeParam1;
		}
		if (other.EffectTriggerTypeParam2 != 0)
		{
			EffectTriggerTypeParam2 = other.EffectTriggerTypeParam2;
		}
		if (other.MpAdd != 0)
		{
			MpAdd = other.MpAdd;
		}
		if (other.HitEfxPath.Length != 0)
		{
			HitEfxPath = other.HitEfxPath;
		}
		if (other.HitEfxDuration != 0f)
		{
			HitEfxDuration = other.HitEfxDuration;
		}
		if (other.HitEfxAttackFrom != EB2DDispPredefineDir.Null)
		{
			HitEfxAttackFrom = other.HitEfxAttackFrom;
		}
		if (other.HitEfxAnchor.Length != 0)
		{
			HitEfxAnchor = other.HitEfxAnchor;
		}
		if (other.TargetFlickerType != 0)
		{
			TargetFlickerType = other.TargetFlickerType;
		}
		if (other.TargetFlickerPriority != 0)
		{
			TargetFlickerPriority = other.TargetFlickerPriority;
		}
		if (other.TargetFlickerDuration != 0f)
		{
			TargetFlickerDuration = other.TargetFlickerDuration;
		}
		if (other.TargetFlickerLoop != 0)
		{
			TargetFlickerLoop = other.TargetFlickerLoop;
		}
		effectFollowLevel_.Add(other.effectFollowLevel_);
		if (other.AttackEfxPath.Length != 0)
		{
			AttackEfxPath = other.AttackEfxPath;
		}
		if (other.AttackEfxDuration != 0f)
		{
			AttackEfxDuration = other.AttackEfxDuration;
		}
		if (other.shakeData_ != null)
		{
			if (shakeData_ == null)
			{
				ShakeData = new FUStB2DSkillShakeData();
			}
			ShakeData.MergeFrom(other.ShakeData);
		}
		if (other.BreakSkillAngle != 0f)
		{
			BreakSkillAngle = other.BreakSkillAngle;
		}
		if (other.WieldAir != 0)
		{
			WieldAir = other.WieldAir;
		}
		if (other.WieldAirWithEffect != 0)
		{
			WieldAirWithEffect = other.WieldAirWithEffect;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				Id = input.ReadInt32();
				break;
			case 16u:
				TargetBaseParam1 = input.ReadInt32();
				break;
			case 24u:
				TargetBaseParam2 = input.ReadInt32();
				break;
			case 32u:
				TargetBaseParam3 = input.ReadInt32();
				break;
			case 40u:
				TargetBaseParam4 = input.ReadInt32();
				break;
			case 48u:
				EffectType = (EB2DBuffAndSkillEffectType)input.ReadEnum();
				break;
			case 56u:
			case 58u:
				effectParamsInt_.AddEntriesFrom(input, _repeated_effectParamsInt_codec);
				break;
			case 66u:
			case 69u:
				effectParamsFloat_.AddEntriesFrom(input, _repeated_effectParamsFloat_codec);
				break;
			case 74u:
				effectParamsStr_.AddEntriesFrom(input, _repeated_effectParamsStr_codec);
				break;
			case 80u:
				TargetFilter = input.ReadInt32();
				break;
			case 88u:
				TargetBase = (EB2DEffectRangeTargetBase)input.ReadEnum();
				break;
			case 96u:
				TargetCount = input.ReadInt32();
				break;
			case 106u:
				if (range_ == null)
				{
					Range = new FUStB2DRange();
				}
				input.ReadMessage(Range);
				break;
			case 112u:
				EffectTriggerType = (EB2DSEffectTriggerType)input.ReadEnum();
				break;
			case 120u:
				EffectTriggerTypeParam1 = input.ReadInt32();
				break;
			case 128u:
				EffectTriggerTypeParam2 = input.ReadInt32();
				break;
			case 136u:
				MpAdd = input.ReadInt32();
				break;
			case 146u:
				HitEfxPath = input.ReadString();
				break;
			case 157u:
				HitEfxDuration = input.ReadFloat();
				break;
			case 160u:
				HitEfxAttackFrom = (EB2DDispPredefineDir)input.ReadEnum();
				break;
			case 170u:
				HitEfxAnchor = input.ReadString();
				break;
			case 176u:
				TargetFlickerType = input.ReadInt32();
				break;
			case 184u:
				TargetFlickerPriority = input.ReadInt32();
				break;
			case 197u:
				TargetFlickerDuration = input.ReadFloat();
				break;
			case 200u:
				TargetFlickerLoop = input.ReadInt32();
				break;
			case 208u:
			case 210u:
				effectFollowLevel_.AddEntriesFrom(input, _repeated_effectFollowLevel_codec);
				break;
			case 218u:
				AttackEfxPath = input.ReadString();
				break;
			case 229u:
				AttackEfxDuration = input.ReadFloat();
				break;
			case 234u:
				if (shakeData_ == null)
				{
					ShakeData = new FUStB2DSkillShakeData();
				}
				input.ReadMessage(ShakeData);
				break;
			case 245u:
				BreakSkillAngle = input.ReadFloat();
				break;
			case 248u:
				WieldAir = input.ReadInt32();
				break;
			case 256u:
				WieldAirWithEffect = input.ReadInt32();
				break;
			}
		}
	}
}
