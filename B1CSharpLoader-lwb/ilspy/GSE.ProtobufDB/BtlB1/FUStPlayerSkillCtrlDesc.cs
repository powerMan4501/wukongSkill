using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStPlayerSkillCtrlDesc : IMessage<FUStPlayerSkillCtrlDesc>, IMessage, IEquatable<FUStPlayerSkillCtrlDesc>, IDeepCloneable<FUStPlayerSkillCtrlDesc>
{
	private static readonly MessageParser<FUStPlayerSkillCtrlDesc> _parser = new MessageParser<FUStPlayerSkillCtrlDesc>(() => new FUStPlayerSkillCtrlDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private ESmartSelectTargetType smartSelectTargetType_;

	private EGSYesNo lockSmartSelectTarget_;

	private EGSYesNo resetManualSelectTarget_;

	private EGSYesNo canEmptyCast_;

	private float searchRange_;

	private float runTraceRange_;

	private EGSYesNo ignoreAttackRangeWhenHasTarget_;

	private float attackRange_;

	private float attackSelectZLimit_;

	private EGSYesNo isShowAttackRange_;

	private string smartSelectHelpActorPath_ = "";

	private string smartSelectUIName_ = "";

	private ESmartSelectShapeType smartSelectShapeType_;

	private float selectShapeParam1_;

	private float selectShapeParam2_;

	private float selectShapeParam3_;

	private string skillIcon_ = "";

	private string hintDesc_ = "";

	private EGSYesNo canShowSelectShapeAndRangeInCD_;

	private float skillSpecificMoveTime_;

	private float distScoreRating_;

	private float heightScoreRating_;

	private float angleScoreRating_;

	private EGSYesNo hasSkillWheel_;

	private int movingToAttackBuff_;

	private float movingToAttackToleranceDistance_;

	private EGSYesNo cancelSelectWhenCameraLockCleared_;

	private ESkillSelectOpType skillSelectOpType_;

	private static readonly FieldCodec<int> _repeated_skillSelectBuffList_codec = FieldCodec.ForInt32(258u);

	private readonly RepeatedField<int> skillSelectBuffList_ = new RepeatedField<int>();

	private EGSYesNo autoLockPreferPelvis_;

	private float pelvisExtraScore_;

	public static MessageParser<FUStPlayerSkillCtrlDesc> Parser => _parser;

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

	public ESmartSelectTargetType SmartSelectTargetType
	{
		get
		{
			return smartSelectTargetType_;
		}
		set
		{
			smartSelectTargetType_ = value;
		}
	}

	public EGSYesNo LockSmartSelectTarget
	{
		get
		{
			return lockSmartSelectTarget_;
		}
		set
		{
			lockSmartSelectTarget_ = value;
		}
	}

	public EGSYesNo ResetManualSelectTarget
	{
		get
		{
			return resetManualSelectTarget_;
		}
		set
		{
			resetManualSelectTarget_ = value;
		}
	}

	public EGSYesNo CanEmptyCast
	{
		get
		{
			return canEmptyCast_;
		}
		set
		{
			canEmptyCast_ = value;
		}
	}

	public float SearchRange
	{
		get
		{
			return searchRange_;
		}
		set
		{
			searchRange_ = value;
		}
	}

	public float RunTraceRange
	{
		get
		{
			return runTraceRange_;
		}
		set
		{
			runTraceRange_ = value;
		}
	}

	public EGSYesNo IgnoreAttackRangeWhenHasTarget
	{
		get
		{
			return ignoreAttackRangeWhenHasTarget_;
		}
		set
		{
			ignoreAttackRangeWhenHasTarget_ = value;
		}
	}

	public float AttackRange
	{
		get
		{
			return attackRange_;
		}
		set
		{
			attackRange_ = value;
		}
	}

	public float AttackSelectZLimit
	{
		get
		{
			return attackSelectZLimit_;
		}
		set
		{
			attackSelectZLimit_ = value;
		}
	}

	public EGSYesNo IsShowAttackRange
	{
		get
		{
			return isShowAttackRange_;
		}
		set
		{
			isShowAttackRange_ = value;
		}
	}

	public string SmartSelectHelpActorPath
	{
		get
		{
			return smartSelectHelpActorPath_;
		}
		set
		{
			smartSelectHelpActorPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string SmartSelectUIName
	{
		get
		{
			return smartSelectUIName_;
		}
		set
		{
			smartSelectUIName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ESmartSelectShapeType SmartSelectShapeType
	{
		get
		{
			return smartSelectShapeType_;
		}
		set
		{
			smartSelectShapeType_ = value;
		}
	}

	public float SelectShapeParam1
	{
		get
		{
			return selectShapeParam1_;
		}
		set
		{
			selectShapeParam1_ = value;
		}
	}

	public float SelectShapeParam2
	{
		get
		{
			return selectShapeParam2_;
		}
		set
		{
			selectShapeParam2_ = value;
		}
	}

	public float SelectShapeParam3
	{
		get
		{
			return selectShapeParam3_;
		}
		set
		{
			selectShapeParam3_ = value;
		}
	}

	public string SkillIcon
	{
		get
		{
			return skillIcon_;
		}
		set
		{
			skillIcon_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string HintDesc
	{
		get
		{
			return hintDesc_;
		}
		set
		{
			hintDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EGSYesNo CanShowSelectShapeAndRangeInCD
	{
		get
		{
			return canShowSelectShapeAndRangeInCD_;
		}
		set
		{
			canShowSelectShapeAndRangeInCD_ = value;
		}
	}

	public float SkillSpecificMoveTime
	{
		get
		{
			return skillSpecificMoveTime_;
		}
		set
		{
			skillSpecificMoveTime_ = value;
		}
	}

	public float DistScoreRating
	{
		get
		{
			return distScoreRating_;
		}
		set
		{
			distScoreRating_ = value;
		}
	}

	public float HeightScoreRating
	{
		get
		{
			return heightScoreRating_;
		}
		set
		{
			heightScoreRating_ = value;
		}
	}

	public float AngleScoreRating
	{
		get
		{
			return angleScoreRating_;
		}
		set
		{
			angleScoreRating_ = value;
		}
	}

	public EGSYesNo HasSkillWheel
	{
		get
		{
			return hasSkillWheel_;
		}
		set
		{
			hasSkillWheel_ = value;
		}
	}

	public int MovingToAttackBuff
	{
		get
		{
			return movingToAttackBuff_;
		}
		set
		{
			movingToAttackBuff_ = value;
		}
	}

	public float MovingToAttackToleranceDistance
	{
		get
		{
			return movingToAttackToleranceDistance_;
		}
		set
		{
			movingToAttackToleranceDistance_ = value;
		}
	}

	public EGSYesNo CancelSelectWhenCameraLockCleared
	{
		get
		{
			return cancelSelectWhenCameraLockCleared_;
		}
		set
		{
			cancelSelectWhenCameraLockCleared_ = value;
		}
	}

	public ESkillSelectOpType SkillSelectOpType
	{
		get
		{
			return skillSelectOpType_;
		}
		set
		{
			skillSelectOpType_ = value;
		}
	}

	public RepeatedField<int> SkillSelectBuffList => skillSelectBuffList_;

	public EGSYesNo AutoLockPreferPelvis
	{
		get
		{
			return autoLockPreferPelvis_;
		}
		set
		{
			autoLockPreferPelvis_ = value;
		}
	}

	public float PelvisExtraScore
	{
		get
		{
			return pelvisExtraScore_;
		}
		set
		{
			pelvisExtraScore_ = value;
		}
	}

	public FUStPlayerSkillCtrlDesc()
	{
	}

	public FUStPlayerSkillCtrlDesc(FUStPlayerSkillCtrlDesc other)
		: this()
	{
		iD_ = other.iD_;
		smartSelectTargetType_ = other.smartSelectTargetType_;
		lockSmartSelectTarget_ = other.lockSmartSelectTarget_;
		resetManualSelectTarget_ = other.resetManualSelectTarget_;
		canEmptyCast_ = other.canEmptyCast_;
		searchRange_ = other.searchRange_;
		runTraceRange_ = other.runTraceRange_;
		ignoreAttackRangeWhenHasTarget_ = other.ignoreAttackRangeWhenHasTarget_;
		attackRange_ = other.attackRange_;
		attackSelectZLimit_ = other.attackSelectZLimit_;
		isShowAttackRange_ = other.isShowAttackRange_;
		smartSelectHelpActorPath_ = other.smartSelectHelpActorPath_;
		smartSelectUIName_ = other.smartSelectUIName_;
		smartSelectShapeType_ = other.smartSelectShapeType_;
		selectShapeParam1_ = other.selectShapeParam1_;
		selectShapeParam2_ = other.selectShapeParam2_;
		selectShapeParam3_ = other.selectShapeParam3_;
		skillIcon_ = other.skillIcon_;
		hintDesc_ = other.hintDesc_;
		canShowSelectShapeAndRangeInCD_ = other.canShowSelectShapeAndRangeInCD_;
		skillSpecificMoveTime_ = other.skillSpecificMoveTime_;
		distScoreRating_ = other.distScoreRating_;
		heightScoreRating_ = other.heightScoreRating_;
		angleScoreRating_ = other.angleScoreRating_;
		hasSkillWheel_ = other.hasSkillWheel_;
		movingToAttackBuff_ = other.movingToAttackBuff_;
		movingToAttackToleranceDistance_ = other.movingToAttackToleranceDistance_;
		cancelSelectWhenCameraLockCleared_ = other.cancelSelectWhenCameraLockCleared_;
		skillSelectOpType_ = other.skillSelectOpType_;
		skillSelectBuffList_ = other.skillSelectBuffList_.Clone();
		autoLockPreferPelvis_ = other.autoLockPreferPelvis_;
		pelvisExtraScore_ = other.pelvisExtraScore_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStPlayerSkillCtrlDesc Clone()
	{
		return new FUStPlayerSkillCtrlDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStPlayerSkillCtrlDesc);
	}

	public bool Equals(FUStPlayerSkillCtrlDesc other)
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
		if (SmartSelectTargetType != other.SmartSelectTargetType)
		{
			return false;
		}
		if (LockSmartSelectTarget != other.LockSmartSelectTarget)
		{
			return false;
		}
		if (ResetManualSelectTarget != other.ResetManualSelectTarget)
		{
			return false;
		}
		if (CanEmptyCast != other.CanEmptyCast)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SearchRange, other.SearchRange))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(RunTraceRange, other.RunTraceRange))
		{
			return false;
		}
		if (IgnoreAttackRangeWhenHasTarget != other.IgnoreAttackRangeWhenHasTarget)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AttackRange, other.AttackRange))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AttackSelectZLimit, other.AttackSelectZLimit))
		{
			return false;
		}
		if (IsShowAttackRange != other.IsShowAttackRange)
		{
			return false;
		}
		if (SmartSelectHelpActorPath != other.SmartSelectHelpActorPath)
		{
			return false;
		}
		if (SmartSelectUIName != other.SmartSelectUIName)
		{
			return false;
		}
		if (SmartSelectShapeType != other.SmartSelectShapeType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SelectShapeParam1, other.SelectShapeParam1))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SelectShapeParam2, other.SelectShapeParam2))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SelectShapeParam3, other.SelectShapeParam3))
		{
			return false;
		}
		if (SkillIcon != other.SkillIcon)
		{
			return false;
		}
		if (HintDesc != other.HintDesc)
		{
			return false;
		}
		if (CanShowSelectShapeAndRangeInCD != other.CanShowSelectShapeAndRangeInCD)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SkillSpecificMoveTime, other.SkillSpecificMoveTime))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DistScoreRating, other.DistScoreRating))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(HeightScoreRating, other.HeightScoreRating))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AngleScoreRating, other.AngleScoreRating))
		{
			return false;
		}
		if (HasSkillWheel != other.HasSkillWheel)
		{
			return false;
		}
		if (MovingToAttackBuff != other.MovingToAttackBuff)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MovingToAttackToleranceDistance, other.MovingToAttackToleranceDistance))
		{
			return false;
		}
		if (CancelSelectWhenCameraLockCleared != other.CancelSelectWhenCameraLockCleared)
		{
			return false;
		}
		if (SkillSelectOpType != other.SkillSelectOpType)
		{
			return false;
		}
		if (!skillSelectBuffList_.Equals(other.skillSelectBuffList_))
		{
			return false;
		}
		if (AutoLockPreferPelvis != other.AutoLockPreferPelvis)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PelvisExtraScore, other.PelvisExtraScore))
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
		if (SmartSelectTargetType != ESmartSelectTargetType.None)
		{
			num ^= SmartSelectTargetType.GetHashCode();
		}
		if (LockSmartSelectTarget != EGSYesNo.No)
		{
			num ^= LockSmartSelectTarget.GetHashCode();
		}
		if (ResetManualSelectTarget != EGSYesNo.No)
		{
			num ^= ResetManualSelectTarget.GetHashCode();
		}
		if (CanEmptyCast != EGSYesNo.No)
		{
			num ^= CanEmptyCast.GetHashCode();
		}
		if (SearchRange != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SearchRange);
		}
		if (RunTraceRange != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(RunTraceRange);
		}
		if (IgnoreAttackRangeWhenHasTarget != EGSYesNo.No)
		{
			num ^= IgnoreAttackRangeWhenHasTarget.GetHashCode();
		}
		if (AttackRange != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AttackRange);
		}
		if (AttackSelectZLimit != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AttackSelectZLimit);
		}
		if (IsShowAttackRange != EGSYesNo.No)
		{
			num ^= IsShowAttackRange.GetHashCode();
		}
		if (SmartSelectHelpActorPath.Length != 0)
		{
			num ^= SmartSelectHelpActorPath.GetHashCode();
		}
		if (SmartSelectUIName.Length != 0)
		{
			num ^= SmartSelectUIName.GetHashCode();
		}
		if (SmartSelectShapeType != ESmartSelectShapeType.SssNone)
		{
			num ^= SmartSelectShapeType.GetHashCode();
		}
		if (SelectShapeParam1 != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SelectShapeParam1);
		}
		if (SelectShapeParam2 != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SelectShapeParam2);
		}
		if (SelectShapeParam3 != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SelectShapeParam3);
		}
		if (SkillIcon.Length != 0)
		{
			num ^= SkillIcon.GetHashCode();
		}
		if (HintDesc.Length != 0)
		{
			num ^= HintDesc.GetHashCode();
		}
		if (CanShowSelectShapeAndRangeInCD != EGSYesNo.No)
		{
			num ^= CanShowSelectShapeAndRangeInCD.GetHashCode();
		}
		if (SkillSpecificMoveTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SkillSpecificMoveTime);
		}
		if (DistScoreRating != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DistScoreRating);
		}
		if (HeightScoreRating != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(HeightScoreRating);
		}
		if (AngleScoreRating != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AngleScoreRating);
		}
		if (HasSkillWheel != EGSYesNo.No)
		{
			num ^= HasSkillWheel.GetHashCode();
		}
		if (MovingToAttackBuff != 0)
		{
			num ^= MovingToAttackBuff.GetHashCode();
		}
		if (MovingToAttackToleranceDistance != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MovingToAttackToleranceDistance);
		}
		if (CancelSelectWhenCameraLockCleared != EGSYesNo.No)
		{
			num ^= CancelSelectWhenCameraLockCleared.GetHashCode();
		}
		if (SkillSelectOpType != ESkillSelectOpType.Free)
		{
			num ^= SkillSelectOpType.GetHashCode();
		}
		num ^= skillSelectBuffList_.GetHashCode();
		if (AutoLockPreferPelvis != EGSYesNo.No)
		{
			num ^= AutoLockPreferPelvis.GetHashCode();
		}
		if (PelvisExtraScore != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PelvisExtraScore);
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
		if (SmartSelectTargetType != ESmartSelectTargetType.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)SmartSelectTargetType);
		}
		if (LockSmartSelectTarget != EGSYesNo.No)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)LockSmartSelectTarget);
		}
		if (ResetManualSelectTarget != EGSYesNo.No)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)ResetManualSelectTarget);
		}
		if (CanEmptyCast != EGSYesNo.No)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)CanEmptyCast);
		}
		if (SearchRange != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(SearchRange);
		}
		if (RunTraceRange != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(RunTraceRange);
		}
		if (IgnoreAttackRangeWhenHasTarget != EGSYesNo.No)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)IgnoreAttackRangeWhenHasTarget);
		}
		if (AttackRange != 0f)
		{
			output.WriteRawTag(77);
			output.WriteFloat(AttackRange);
		}
		if (AttackSelectZLimit != 0f)
		{
			output.WriteRawTag(85);
			output.WriteFloat(AttackSelectZLimit);
		}
		if (IsShowAttackRange != EGSYesNo.No)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)IsShowAttackRange);
		}
		if (SmartSelectHelpActorPath.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(SmartSelectHelpActorPath);
		}
		if (SmartSelectUIName.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(SmartSelectUIName);
		}
		if (SmartSelectShapeType != ESmartSelectShapeType.SssNone)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)SmartSelectShapeType);
		}
		if (SelectShapeParam1 != 0f)
		{
			output.WriteRawTag(125);
			output.WriteFloat(SelectShapeParam1);
		}
		if (SelectShapeParam2 != 0f)
		{
			output.WriteRawTag(133, 1);
			output.WriteFloat(SelectShapeParam2);
		}
		if (SelectShapeParam3 != 0f)
		{
			output.WriteRawTag(141, 1);
			output.WriteFloat(SelectShapeParam3);
		}
		if (SkillIcon.Length != 0)
		{
			output.WriteRawTag(146, 1);
			output.WriteString(SkillIcon);
		}
		if (HintDesc.Length != 0)
		{
			output.WriteRawTag(154, 1);
			output.WriteString(HintDesc);
		}
		if (CanShowSelectShapeAndRangeInCD != EGSYesNo.No)
		{
			output.WriteRawTag(160, 1);
			output.WriteEnum((int)CanShowSelectShapeAndRangeInCD);
		}
		if (SkillSpecificMoveTime != 0f)
		{
			output.WriteRawTag(173, 1);
			output.WriteFloat(SkillSpecificMoveTime);
		}
		if (DistScoreRating != 0f)
		{
			output.WriteRawTag(181, 1);
			output.WriteFloat(DistScoreRating);
		}
		if (HeightScoreRating != 0f)
		{
			output.WriteRawTag(189, 1);
			output.WriteFloat(HeightScoreRating);
		}
		if (AngleScoreRating != 0f)
		{
			output.WriteRawTag(197, 1);
			output.WriteFloat(AngleScoreRating);
		}
		if (HasSkillWheel != EGSYesNo.No)
		{
			output.WriteRawTag(200, 1);
			output.WriteEnum((int)HasSkillWheel);
		}
		if (MovingToAttackBuff != 0)
		{
			output.WriteRawTag(208, 1);
			output.WriteInt32(MovingToAttackBuff);
		}
		if (MovingToAttackToleranceDistance != 0f)
		{
			output.WriteRawTag(221, 1);
			output.WriteFloat(MovingToAttackToleranceDistance);
		}
		if (CancelSelectWhenCameraLockCleared != EGSYesNo.No)
		{
			output.WriteRawTag(232, 1);
			output.WriteEnum((int)CancelSelectWhenCameraLockCleared);
		}
		if (SkillSelectOpType != ESkillSelectOpType.Free)
		{
			output.WriteRawTag(248, 1);
			output.WriteEnum((int)SkillSelectOpType);
		}
		skillSelectBuffList_.WriteTo(output, _repeated_skillSelectBuffList_codec);
		if (AutoLockPreferPelvis != EGSYesNo.No)
		{
			output.WriteRawTag(136, 2);
			output.WriteEnum((int)AutoLockPreferPelvis);
		}
		if (PelvisExtraScore != 0f)
		{
			output.WriteRawTag(149, 2);
			output.WriteFloat(PelvisExtraScore);
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
		if (SmartSelectTargetType != ESmartSelectTargetType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SmartSelectTargetType);
		}
		if (LockSmartSelectTarget != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LockSmartSelectTarget);
		}
		if (ResetManualSelectTarget != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ResetManualSelectTarget);
		}
		if (CanEmptyCast != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CanEmptyCast);
		}
		if (SearchRange != 0f)
		{
			num += 5;
		}
		if (RunTraceRange != 0f)
		{
			num += 5;
		}
		if (IgnoreAttackRangeWhenHasTarget != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IgnoreAttackRangeWhenHasTarget);
		}
		if (AttackRange != 0f)
		{
			num += 5;
		}
		if (AttackSelectZLimit != 0f)
		{
			num += 5;
		}
		if (IsShowAttackRange != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsShowAttackRange);
		}
		if (SmartSelectHelpActorPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SmartSelectHelpActorPath);
		}
		if (SmartSelectUIName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SmartSelectUIName);
		}
		if (SmartSelectShapeType != ESmartSelectShapeType.SssNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SmartSelectShapeType);
		}
		if (SelectShapeParam1 != 0f)
		{
			num += 5;
		}
		if (SelectShapeParam2 != 0f)
		{
			num += 6;
		}
		if (SelectShapeParam3 != 0f)
		{
			num += 6;
		}
		if (SkillIcon.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(SkillIcon);
		}
		if (HintDesc.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(HintDesc);
		}
		if (CanShowSelectShapeAndRangeInCD != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)CanShowSelectShapeAndRangeInCD);
		}
		if (SkillSpecificMoveTime != 0f)
		{
			num += 6;
		}
		if (DistScoreRating != 0f)
		{
			num += 6;
		}
		if (HeightScoreRating != 0f)
		{
			num += 6;
		}
		if (AngleScoreRating != 0f)
		{
			num += 6;
		}
		if (HasSkillWheel != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)HasSkillWheel);
		}
		if (MovingToAttackBuff != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MovingToAttackBuff);
		}
		if (MovingToAttackToleranceDistance != 0f)
		{
			num += 6;
		}
		if (CancelSelectWhenCameraLockCleared != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)CancelSelectWhenCameraLockCleared);
		}
		if (SkillSelectOpType != ESkillSelectOpType.Free)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)SkillSelectOpType);
		}
		num += skillSelectBuffList_.CalculateSize(_repeated_skillSelectBuffList_codec);
		if (AutoLockPreferPelvis != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)AutoLockPreferPelvis);
		}
		if (PelvisExtraScore != 0f)
		{
			num += 6;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStPlayerSkillCtrlDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.SmartSelectTargetType != ESmartSelectTargetType.None)
			{
				SmartSelectTargetType = other.SmartSelectTargetType;
			}
			if (other.LockSmartSelectTarget != EGSYesNo.No)
			{
				LockSmartSelectTarget = other.LockSmartSelectTarget;
			}
			if (other.ResetManualSelectTarget != EGSYesNo.No)
			{
				ResetManualSelectTarget = other.ResetManualSelectTarget;
			}
			if (other.CanEmptyCast != EGSYesNo.No)
			{
				CanEmptyCast = other.CanEmptyCast;
			}
			if (other.SearchRange != 0f)
			{
				SearchRange = other.SearchRange;
			}
			if (other.RunTraceRange != 0f)
			{
				RunTraceRange = other.RunTraceRange;
			}
			if (other.IgnoreAttackRangeWhenHasTarget != EGSYesNo.No)
			{
				IgnoreAttackRangeWhenHasTarget = other.IgnoreAttackRangeWhenHasTarget;
			}
			if (other.AttackRange != 0f)
			{
				AttackRange = other.AttackRange;
			}
			if (other.AttackSelectZLimit != 0f)
			{
				AttackSelectZLimit = other.AttackSelectZLimit;
			}
			if (other.IsShowAttackRange != EGSYesNo.No)
			{
				IsShowAttackRange = other.IsShowAttackRange;
			}
			if (other.SmartSelectHelpActorPath.Length != 0)
			{
				SmartSelectHelpActorPath = other.SmartSelectHelpActorPath;
			}
			if (other.SmartSelectUIName.Length != 0)
			{
				SmartSelectUIName = other.SmartSelectUIName;
			}
			if (other.SmartSelectShapeType != ESmartSelectShapeType.SssNone)
			{
				SmartSelectShapeType = other.SmartSelectShapeType;
			}
			if (other.SelectShapeParam1 != 0f)
			{
				SelectShapeParam1 = other.SelectShapeParam1;
			}
			if (other.SelectShapeParam2 != 0f)
			{
				SelectShapeParam2 = other.SelectShapeParam2;
			}
			if (other.SelectShapeParam3 != 0f)
			{
				SelectShapeParam3 = other.SelectShapeParam3;
			}
			if (other.SkillIcon.Length != 0)
			{
				SkillIcon = other.SkillIcon;
			}
			if (other.HintDesc.Length != 0)
			{
				HintDesc = other.HintDesc;
			}
			if (other.CanShowSelectShapeAndRangeInCD != EGSYesNo.No)
			{
				CanShowSelectShapeAndRangeInCD = other.CanShowSelectShapeAndRangeInCD;
			}
			if (other.SkillSpecificMoveTime != 0f)
			{
				SkillSpecificMoveTime = other.SkillSpecificMoveTime;
			}
			if (other.DistScoreRating != 0f)
			{
				DistScoreRating = other.DistScoreRating;
			}
			if (other.HeightScoreRating != 0f)
			{
				HeightScoreRating = other.HeightScoreRating;
			}
			if (other.AngleScoreRating != 0f)
			{
				AngleScoreRating = other.AngleScoreRating;
			}
			if (other.HasSkillWheel != EGSYesNo.No)
			{
				HasSkillWheel = other.HasSkillWheel;
			}
			if (other.MovingToAttackBuff != 0)
			{
				MovingToAttackBuff = other.MovingToAttackBuff;
			}
			if (other.MovingToAttackToleranceDistance != 0f)
			{
				MovingToAttackToleranceDistance = other.MovingToAttackToleranceDistance;
			}
			if (other.CancelSelectWhenCameraLockCleared != EGSYesNo.No)
			{
				CancelSelectWhenCameraLockCleared = other.CancelSelectWhenCameraLockCleared;
			}
			if (other.SkillSelectOpType != ESkillSelectOpType.Free)
			{
				SkillSelectOpType = other.SkillSelectOpType;
			}
			skillSelectBuffList_.Add(other.skillSelectBuffList_);
			if (other.AutoLockPreferPelvis != EGSYesNo.No)
			{
				AutoLockPreferPelvis = other.AutoLockPreferPelvis;
			}
			if (other.PelvisExtraScore != 0f)
			{
				PelvisExtraScore = other.PelvisExtraScore;
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
				SmartSelectTargetType = (ESmartSelectTargetType)input.ReadEnum();
				break;
			case 24u:
				LockSmartSelectTarget = (EGSYesNo)input.ReadEnum();
				break;
			case 32u:
				ResetManualSelectTarget = (EGSYesNo)input.ReadEnum();
				break;
			case 40u:
				CanEmptyCast = (EGSYesNo)input.ReadEnum();
				break;
			case 53u:
				SearchRange = input.ReadFloat();
				break;
			case 61u:
				RunTraceRange = input.ReadFloat();
				break;
			case 64u:
				IgnoreAttackRangeWhenHasTarget = (EGSYesNo)input.ReadEnum();
				break;
			case 77u:
				AttackRange = input.ReadFloat();
				break;
			case 85u:
				AttackSelectZLimit = input.ReadFloat();
				break;
			case 88u:
				IsShowAttackRange = (EGSYesNo)input.ReadEnum();
				break;
			case 98u:
				SmartSelectHelpActorPath = input.ReadString();
				break;
			case 106u:
				SmartSelectUIName = input.ReadString();
				break;
			case 112u:
				SmartSelectShapeType = (ESmartSelectShapeType)input.ReadEnum();
				break;
			case 125u:
				SelectShapeParam1 = input.ReadFloat();
				break;
			case 133u:
				SelectShapeParam2 = input.ReadFloat();
				break;
			case 141u:
				SelectShapeParam3 = input.ReadFloat();
				break;
			case 146u:
				SkillIcon = input.ReadString();
				break;
			case 154u:
				HintDesc = input.ReadString();
				break;
			case 160u:
				CanShowSelectShapeAndRangeInCD = (EGSYesNo)input.ReadEnum();
				break;
			case 173u:
				SkillSpecificMoveTime = input.ReadFloat();
				break;
			case 181u:
				DistScoreRating = input.ReadFloat();
				break;
			case 189u:
				HeightScoreRating = input.ReadFloat();
				break;
			case 197u:
				AngleScoreRating = input.ReadFloat();
				break;
			case 200u:
				HasSkillWheel = (EGSYesNo)input.ReadEnum();
				break;
			case 208u:
				MovingToAttackBuff = input.ReadInt32();
				break;
			case 221u:
				MovingToAttackToleranceDistance = input.ReadFloat();
				break;
			case 232u:
				CancelSelectWhenCameraLockCleared = (EGSYesNo)input.ReadEnum();
				break;
			case 248u:
				SkillSelectOpType = (ESkillSelectOpType)input.ReadEnum();
				break;
			case 256u:
			case 258u:
				skillSelectBuffList_.AddEntriesFrom(input, _repeated_skillSelectBuffList_codec);
				break;
			case 264u:
				AutoLockPreferPelvis = (EGSYesNo)input.ReadEnum();
				break;
			case 277u:
				PelvisExtraScore = input.ReadFloat();
				break;
			}
		}
	}
}
