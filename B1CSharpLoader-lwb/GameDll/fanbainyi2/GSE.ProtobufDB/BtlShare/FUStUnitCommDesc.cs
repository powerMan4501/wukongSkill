using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class FUStUnitCommDesc : IMessage<FUStUnitCommDesc>, IMessage, IEquatable<FUStUnitCommDesc>, IDeepCloneable<FUStUnitCommDesc>
{
	private static readonly MessageParser<FUStUnitCommDesc> _parser = new MessageParser<FUStUnitCommDesc>(() => new FUStUnitCommDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int teamID_;

	private EUnitBodyType unitBodyType_;

	private EUnitSquadMemberType squadMemberType_;

	private int exAnimDataID_;

	private int defaultBattleInfoExtendID_;

	private int defaultBeAttackedInfoID_;

	private int defaultPartRuleInfoID_;

	private float hPBarHeightOffset_;

	private EGSYesNo cantBeHitInDingShen_;

	private EGSYesNo canReduceStunValue_;

	private EGSYesNo canReduceBRKShieldValue_;

	private EGSYesNo canReduceSuperArmorValue_;

	private EGSYesNo canTriggerAdditiveBeHitAnim_;

	private float bRKShieldWeakLoopTime_;

	private float breakSSARecoverBRKShieldValue_;

	private float triggerQTEAngleMin_;

	private float triggerQTEAngleMax_;

	private int physicalHitBoneRuleID_;

	private float maxSkillSuperArmorValue_;

	private float maxBlindSlotValue_;

	private float moveSpeedFast_;

	private float moveSpeedNormal_;

	private float moveSpeedSlow_;

	private float kPTTrunSpeed_;

	private float turnSpeed_;

	private float bigTurnSpeed_;

	private float dingShenDef_;

	private float stun_;

	private float stunDuration_;

	private int stunBuffID_;

	private int atkReboundBuffID_;

	private float qTEBeSelectedDist_;

	private int defaultTenacity_;

	private float defaultEarPlug_;

	private float partDamageRadio_;

	private float cameraLockDist_;

	private float cameraLockDistTolerance_;

	private string weaponSharpSkillEffectAssetPath_ = "";

	private string weaponSharpCritSkillEffectAssetPath_ = "";

	private EBGUResetType resetType_;

	private int deadInfoID_;

	private float tickRateDisRatio_;

	private EGSYesNo canApplyFreezeFrame_;

	private float victimFreezeFrameGap_;

	private float footHeightThreshold_;

	private float sprintFootSpeedThreshold_;

	private float runFootSpeedThreshold_;

	private float walkFootSpeedThreshold_;

	private string leftFootSpeedRefBone_ = "";

	private string rightFootSpeedRefBone_ = "";

	private string leftFootBone_ = "";

	private string rightFootBone_ = "";

	private string leftFootFrontSocket_ = "";

	private string rightFootFrontSocket_ = "";

	private EGSYesNo noEnemyBeHitFX_;

	private EGSYesNo isElite_;

	private float partnerAutoRebirthTime_;

	private float simpleOverlapRadius_;

	private EGSYesNo hPHideImmediately_;

	private string aimOffsetEyeSocketName_ = "";

	private string aimOffsetBeWatchedSocketName_ = "";

	private EGSYesNo enableDynamicMaterialQualitySwitch_;

	private string guard_ = "";

	public static MessageParser<FUStUnitCommDesc> Parser => _parser;

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

	public int TeamID
	{
		get
		{
			return teamID_;
		}
		set
		{
			teamID_ = value;
		}
	}

	public EUnitBodyType UnitBodyType
	{
		get
		{
			return unitBodyType_;
		}
		set
		{
			unitBodyType_ = value;
		}
	}

	public EUnitSquadMemberType SquadMemberType
	{
		get
		{
			return squadMemberType_;
		}
		set
		{
			squadMemberType_ = value;
		}
	}

	public int ExAnimDataID
	{
		get
		{
			return exAnimDataID_;
		}
		set
		{
			exAnimDataID_ = value;
		}
	}

	public int DefaultBattleInfoExtendID
	{
		get
		{
			return defaultBattleInfoExtendID_;
		}
		set
		{
			defaultBattleInfoExtendID_ = value;
		}
	}

	public int DefaultBeAttackedInfoID
	{
		get
		{
			return defaultBeAttackedInfoID_;
		}
		set
		{
			defaultBeAttackedInfoID_ = value;
		}
	}

	public int DefaultPartRuleInfoID
	{
		get
		{
			return defaultPartRuleInfoID_;
		}
		set
		{
			defaultPartRuleInfoID_ = value;
		}
	}

	public float HPBarHeightOffset
	{
		get
		{
			return hPBarHeightOffset_;
		}
		set
		{
			hPBarHeightOffset_ = value;
		}
	}

	public EGSYesNo CantBeHitInDingShen
	{
		get
		{
			return cantBeHitInDingShen_;
		}
		set
		{
			cantBeHitInDingShen_ = value;
		}
	}

	public EGSYesNo CanReduceStunValue
	{
		get
		{
			return canReduceStunValue_;
		}
		set
		{
			canReduceStunValue_ = value;
		}
	}

	public EGSYesNo CanReduceBRKShieldValue
	{
		get
		{
			return canReduceBRKShieldValue_;
		}
		set
		{
			canReduceBRKShieldValue_ = value;
		}
	}

	public EGSYesNo CanReduceSuperArmorValue
	{
		get
		{
			return canReduceSuperArmorValue_;
		}
		set
		{
			canReduceSuperArmorValue_ = value;
		}
	}

	public EGSYesNo CanTriggerAdditiveBeHitAnim
	{
		get
		{
			return canTriggerAdditiveBeHitAnim_;
		}
		set
		{
			canTriggerAdditiveBeHitAnim_ = value;
		}
	}

	public float BRKShieldWeakLoopTime
	{
		get
		{
			return bRKShieldWeakLoopTime_;
		}
		set
		{
			bRKShieldWeakLoopTime_ = value;
		}
	}

	public float BreakSSARecoverBRKShieldValue
	{
		get
		{
			return breakSSARecoverBRKShieldValue_;
		}
		set
		{
			breakSSARecoverBRKShieldValue_ = value;
		}
	}

	public float TriggerQTEAngleMin
	{
		get
		{
			return triggerQTEAngleMin_;
		}
		set
		{
			triggerQTEAngleMin_ = value;
		}
	}

	public float TriggerQTEAngleMax
	{
		get
		{
			return triggerQTEAngleMax_;
		}
		set
		{
			triggerQTEAngleMax_ = value;
		}
	}

	public int PhysicalHitBoneRuleID
	{
		get
		{
			return physicalHitBoneRuleID_;
		}
		set
		{
			physicalHitBoneRuleID_ = value;
		}
	}

	public float MaxSkillSuperArmorValue
	{
		get
		{
			return maxSkillSuperArmorValue_;
		}
		set
		{
			maxSkillSuperArmorValue_ = value;
		}
	}

	public float MaxBlindSlotValue
	{
		get
		{
			return maxBlindSlotValue_;
		}
		set
		{
			maxBlindSlotValue_ = value;
		}
	}

	public float MoveSpeedFast
	{
		get
		{
			return moveSpeedFast_;
		}
		set
		{
			moveSpeedFast_ = value;
		}
	}

	public float MoveSpeedNormal
	{
		get
		{
			return moveSpeedNormal_;
		}
		set
		{
			moveSpeedNormal_ = value;
		}
	}

	public float MoveSpeedSlow
	{
		get
		{
			return moveSpeedSlow_;
		}
		set
		{
			moveSpeedSlow_ = value;
		}
	}

	public float KPTTrunSpeed
	{
		get
		{
			return kPTTrunSpeed_;
		}
		set
		{
			kPTTrunSpeed_ = value;
		}
	}

	public float TurnSpeed
	{
		get
		{
			return turnSpeed_;
		}
		set
		{
			turnSpeed_ = value;
		}
	}

	public float BigTurnSpeed
	{
		get
		{
			return bigTurnSpeed_;
		}
		set
		{
			bigTurnSpeed_ = value;
		}
	}

	public float DingShenDef
	{
		get
		{
			return dingShenDef_;
		}
		set
		{
			dingShenDef_ = value;
		}
	}

	public float Stun
	{
		get
		{
			return stun_;
		}
		set
		{
			stun_ = value;
		}
	}

	public float StunDuration
	{
		get
		{
			return stunDuration_;
		}
		set
		{
			stunDuration_ = value;
		}
	}

	public int StunBuffID
	{
		get
		{
			return stunBuffID_;
		}
		set
		{
			stunBuffID_ = value;
		}
	}

	public int AtkReboundBuffID
	{
		get
		{
			return atkReboundBuffID_;
		}
		set
		{
			atkReboundBuffID_ = value;
		}
	}

	public float QTEBeSelectedDist
	{
		get
		{
			return qTEBeSelectedDist_;
		}
		set
		{
			qTEBeSelectedDist_ = value;
		}
	}

	public int DefaultTenacity
	{
		get
		{
			return defaultTenacity_;
		}
		set
		{
			defaultTenacity_ = value;
		}
	}

	public float DefaultEarPlug
	{
		get
		{
			return defaultEarPlug_;
		}
		set
		{
			defaultEarPlug_ = value;
		}
	}

	public float PartDamageRadio
	{
		get
		{
			return partDamageRadio_;
		}
		set
		{
			partDamageRadio_ = value;
		}
	}

	public float CameraLockDist
	{
		get
		{
			return cameraLockDist_;
		}
		set
		{
			cameraLockDist_ = value;
		}
	}

	public float CameraLockDistTolerance
	{
		get
		{
			return cameraLockDistTolerance_;
		}
		set
		{
			cameraLockDistTolerance_ = value;
		}
	}

	public string WeaponSharpSkillEffectAssetPath
	{
		get
		{
			return weaponSharpSkillEffectAssetPath_;
		}
		set
		{
			weaponSharpSkillEffectAssetPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string WeaponSharpCritSkillEffectAssetPath
	{
		get
		{
			return weaponSharpCritSkillEffectAssetPath_;
		}
		set
		{
			weaponSharpCritSkillEffectAssetPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EBGUResetType ResetType
	{
		get
		{
			return resetType_;
		}
		set
		{
			resetType_ = value;
		}
	}

	public int DeadInfoID
	{
		get
		{
			return deadInfoID_;
		}
		set
		{
			deadInfoID_ = value;
		}
	}

	public float TickRateDisRatio
	{
		get
		{
			return tickRateDisRatio_;
		}
		set
		{
			tickRateDisRatio_ = value;
		}
	}

	public EGSYesNo CanApplyFreezeFrame
	{
		get
		{
			return canApplyFreezeFrame_;
		}
		set
		{
			canApplyFreezeFrame_ = value;
		}
	}

	public float VictimFreezeFrameGap
	{
		get
		{
			return victimFreezeFrameGap_;
		}
		set
		{
			victimFreezeFrameGap_ = value;
		}
	}

	public float FootHeightThreshold
	{
		get
		{
			return footHeightThreshold_;
		}
		set
		{
			footHeightThreshold_ = value;
		}
	}

	public float SprintFootSpeedThreshold
	{
		get
		{
			return sprintFootSpeedThreshold_;
		}
		set
		{
			sprintFootSpeedThreshold_ = value;
		}
	}

	public float RunFootSpeedThreshold
	{
		get
		{
			return runFootSpeedThreshold_;
		}
		set
		{
			runFootSpeedThreshold_ = value;
		}
	}

	public float WalkFootSpeedThreshold
	{
		get
		{
			return walkFootSpeedThreshold_;
		}
		set
		{
			walkFootSpeedThreshold_ = value;
		}
	}

	public string LeftFootSpeedRefBone
	{
		get
		{
			return leftFootSpeedRefBone_;
		}
		set
		{
			leftFootSpeedRefBone_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string RightFootSpeedRefBone
	{
		get
		{
			return rightFootSpeedRefBone_;
		}
		set
		{
			rightFootSpeedRefBone_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string LeftFootBone
	{
		get
		{
			return leftFootBone_;
		}
		set
		{
			leftFootBone_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string RightFootBone
	{
		get
		{
			return rightFootBone_;
		}
		set
		{
			rightFootBone_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string LeftFootFrontSocket
	{
		get
		{
			return leftFootFrontSocket_;
		}
		set
		{
			leftFootFrontSocket_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string RightFootFrontSocket
	{
		get
		{
			return rightFootFrontSocket_;
		}
		set
		{
			rightFootFrontSocket_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EGSYesNo NoEnemyBeHitFX
	{
		get
		{
			return noEnemyBeHitFX_;
		}
		set
		{
			noEnemyBeHitFX_ = value;
		}
	}

	public EGSYesNo IsElite
	{
		get
		{
			return isElite_;
		}
		set
		{
			isElite_ = value;
		}
	}

	public float PartnerAutoRebirthTime
	{
		get
		{
			return partnerAutoRebirthTime_;
		}
		set
		{
			partnerAutoRebirthTime_ = value;
		}
	}

	public float SimpleOverlapRadius
	{
		get
		{
			return simpleOverlapRadius_;
		}
		set
		{
			simpleOverlapRadius_ = value;
		}
	}

	public EGSYesNo HPHideImmediately
	{
		get
		{
			return hPHideImmediately_;
		}
		set
		{
			hPHideImmediately_ = value;
		}
	}

	public string AimOffsetEyeSocketName
	{
		get
		{
			return aimOffsetEyeSocketName_;
		}
		set
		{
			aimOffsetEyeSocketName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string AimOffsetBeWatchedSocketName
	{
		get
		{
			return aimOffsetBeWatchedSocketName_;
		}
		set
		{
			aimOffsetBeWatchedSocketName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EGSYesNo EnableDynamicMaterialQualitySwitch
	{
		get
		{
			return enableDynamicMaterialQualitySwitch_;
		}
		set
		{
			enableDynamicMaterialQualitySwitch_ = value;
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

	public FUStUnitCommDesc()
	{
	}

	public FUStUnitCommDesc(FUStUnitCommDesc other)
		: this()
	{
		iD_ = other.iD_;
		teamID_ = other.teamID_;
		unitBodyType_ = other.unitBodyType_;
		squadMemberType_ = other.squadMemberType_;
		exAnimDataID_ = other.exAnimDataID_;
		defaultBattleInfoExtendID_ = other.defaultBattleInfoExtendID_;
		defaultBeAttackedInfoID_ = other.defaultBeAttackedInfoID_;
		defaultPartRuleInfoID_ = other.defaultPartRuleInfoID_;
		hPBarHeightOffset_ = other.hPBarHeightOffset_;
		cantBeHitInDingShen_ = other.cantBeHitInDingShen_;
		canReduceStunValue_ = other.canReduceStunValue_;
		canReduceBRKShieldValue_ = other.canReduceBRKShieldValue_;
		canReduceSuperArmorValue_ = other.canReduceSuperArmorValue_;
		canTriggerAdditiveBeHitAnim_ = other.canTriggerAdditiveBeHitAnim_;
		bRKShieldWeakLoopTime_ = other.bRKShieldWeakLoopTime_;
		breakSSARecoverBRKShieldValue_ = other.breakSSARecoverBRKShieldValue_;
		triggerQTEAngleMin_ = other.triggerQTEAngleMin_;
		triggerQTEAngleMax_ = other.triggerQTEAngleMax_;
		physicalHitBoneRuleID_ = other.physicalHitBoneRuleID_;
		maxSkillSuperArmorValue_ = other.maxSkillSuperArmorValue_;
		maxBlindSlotValue_ = other.maxBlindSlotValue_;
		moveSpeedFast_ = other.moveSpeedFast_;
		moveSpeedNormal_ = other.moveSpeedNormal_;
		moveSpeedSlow_ = other.moveSpeedSlow_;
		kPTTrunSpeed_ = other.kPTTrunSpeed_;
		turnSpeed_ = other.turnSpeed_;
		bigTurnSpeed_ = other.bigTurnSpeed_;
		dingShenDef_ = other.dingShenDef_;
		stun_ = other.stun_;
		stunDuration_ = other.stunDuration_;
		stunBuffID_ = other.stunBuffID_;
		atkReboundBuffID_ = other.atkReboundBuffID_;
		qTEBeSelectedDist_ = other.qTEBeSelectedDist_;
		defaultTenacity_ = other.defaultTenacity_;
		defaultEarPlug_ = other.defaultEarPlug_;
		partDamageRadio_ = other.partDamageRadio_;
		cameraLockDist_ = other.cameraLockDist_;
		cameraLockDistTolerance_ = other.cameraLockDistTolerance_;
		weaponSharpSkillEffectAssetPath_ = other.weaponSharpSkillEffectAssetPath_;
		weaponSharpCritSkillEffectAssetPath_ = other.weaponSharpCritSkillEffectAssetPath_;
		resetType_ = other.resetType_;
		deadInfoID_ = other.deadInfoID_;
		tickRateDisRatio_ = other.tickRateDisRatio_;
		canApplyFreezeFrame_ = other.canApplyFreezeFrame_;
		victimFreezeFrameGap_ = other.victimFreezeFrameGap_;
		footHeightThreshold_ = other.footHeightThreshold_;
		sprintFootSpeedThreshold_ = other.sprintFootSpeedThreshold_;
		runFootSpeedThreshold_ = other.runFootSpeedThreshold_;
		walkFootSpeedThreshold_ = other.walkFootSpeedThreshold_;
		leftFootSpeedRefBone_ = other.leftFootSpeedRefBone_;
		rightFootSpeedRefBone_ = other.rightFootSpeedRefBone_;
		leftFootBone_ = other.leftFootBone_;
		rightFootBone_ = other.rightFootBone_;
		leftFootFrontSocket_ = other.leftFootFrontSocket_;
		rightFootFrontSocket_ = other.rightFootFrontSocket_;
		noEnemyBeHitFX_ = other.noEnemyBeHitFX_;
		isElite_ = other.isElite_;
		partnerAutoRebirthTime_ = other.partnerAutoRebirthTime_;
		simpleOverlapRadius_ = other.simpleOverlapRadius_;
		hPHideImmediately_ = other.hPHideImmediately_;
		aimOffsetEyeSocketName_ = other.aimOffsetEyeSocketName_;
		aimOffsetBeWatchedSocketName_ = other.aimOffsetBeWatchedSocketName_;
		enableDynamicMaterialQualitySwitch_ = other.enableDynamicMaterialQualitySwitch_;
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStUnitCommDesc Clone()
	{
		return new FUStUnitCommDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStUnitCommDesc);
	}

	public bool Equals(FUStUnitCommDesc other)
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
		if (TeamID != other.TeamID)
		{
			return false;
		}
		if (UnitBodyType != other.UnitBodyType)
		{
			return false;
		}
		if (SquadMemberType != other.SquadMemberType)
		{
			return false;
		}
		if (ExAnimDataID != other.ExAnimDataID)
		{
			return false;
		}
		if (DefaultBattleInfoExtendID != other.DefaultBattleInfoExtendID)
		{
			return false;
		}
		if (DefaultBeAttackedInfoID != other.DefaultBeAttackedInfoID)
		{
			return false;
		}
		if (DefaultPartRuleInfoID != other.DefaultPartRuleInfoID)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(HPBarHeightOffset, other.HPBarHeightOffset))
		{
			return false;
		}
		if (CantBeHitInDingShen != other.CantBeHitInDingShen)
		{
			return false;
		}
		if (CanReduceStunValue != other.CanReduceStunValue)
		{
			return false;
		}
		if (CanReduceBRKShieldValue != other.CanReduceBRKShieldValue)
		{
			return false;
		}
		if (CanReduceSuperArmorValue != other.CanReduceSuperArmorValue)
		{
			return false;
		}
		if (CanTriggerAdditiveBeHitAnim != other.CanTriggerAdditiveBeHitAnim)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BRKShieldWeakLoopTime, other.BRKShieldWeakLoopTime))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BreakSSARecoverBRKShieldValue, other.BreakSSARecoverBRKShieldValue))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TriggerQTEAngleMin, other.TriggerQTEAngleMin))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TriggerQTEAngleMax, other.TriggerQTEAngleMax))
		{
			return false;
		}
		if (PhysicalHitBoneRuleID != other.PhysicalHitBoneRuleID)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MaxSkillSuperArmorValue, other.MaxSkillSuperArmorValue))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MaxBlindSlotValue, other.MaxBlindSlotValue))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MoveSpeedFast, other.MoveSpeedFast))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MoveSpeedNormal, other.MoveSpeedNormal))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MoveSpeedSlow, other.MoveSpeedSlow))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(KPTTrunSpeed, other.KPTTrunSpeed))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TurnSpeed, other.TurnSpeed))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BigTurnSpeed, other.BigTurnSpeed))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DingShenDef, other.DingShenDef))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Stun, other.Stun))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(StunDuration, other.StunDuration))
		{
			return false;
		}
		if (StunBuffID != other.StunBuffID)
		{
			return false;
		}
		if (AtkReboundBuffID != other.AtkReboundBuffID)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(QTEBeSelectedDist, other.QTEBeSelectedDist))
		{
			return false;
		}
		if (DefaultTenacity != other.DefaultTenacity)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DefaultEarPlug, other.DefaultEarPlug))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PartDamageRadio, other.PartDamageRadio))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CameraLockDist, other.CameraLockDist))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CameraLockDistTolerance, other.CameraLockDistTolerance))
		{
			return false;
		}
		if (WeaponSharpSkillEffectAssetPath != other.WeaponSharpSkillEffectAssetPath)
		{
			return false;
		}
		if (WeaponSharpCritSkillEffectAssetPath != other.WeaponSharpCritSkillEffectAssetPath)
		{
			return false;
		}
		if (ResetType != other.ResetType)
		{
			return false;
		}
		if (DeadInfoID != other.DeadInfoID)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TickRateDisRatio, other.TickRateDisRatio))
		{
			return false;
		}
		if (CanApplyFreezeFrame != other.CanApplyFreezeFrame)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(VictimFreezeFrameGap, other.VictimFreezeFrameGap))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FootHeightThreshold, other.FootHeightThreshold))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SprintFootSpeedThreshold, other.SprintFootSpeedThreshold))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(RunFootSpeedThreshold, other.RunFootSpeedThreshold))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(WalkFootSpeedThreshold, other.WalkFootSpeedThreshold))
		{
			return false;
		}
		if (LeftFootSpeedRefBone != other.LeftFootSpeedRefBone)
		{
			return false;
		}
		if (RightFootSpeedRefBone != other.RightFootSpeedRefBone)
		{
			return false;
		}
		if (LeftFootBone != other.LeftFootBone)
		{
			return false;
		}
		if (RightFootBone != other.RightFootBone)
		{
			return false;
		}
		if (LeftFootFrontSocket != other.LeftFootFrontSocket)
		{
			return false;
		}
		if (RightFootFrontSocket != other.RightFootFrontSocket)
		{
			return false;
		}
		if (NoEnemyBeHitFX != other.NoEnemyBeHitFX)
		{
			return false;
		}
		if (IsElite != other.IsElite)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PartnerAutoRebirthTime, other.PartnerAutoRebirthTime))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SimpleOverlapRadius, other.SimpleOverlapRadius))
		{
			return false;
		}
		if (HPHideImmediately != other.HPHideImmediately)
		{
			return false;
		}
		if (AimOffsetEyeSocketName != other.AimOffsetEyeSocketName)
		{
			return false;
		}
		if (AimOffsetBeWatchedSocketName != other.AimOffsetBeWatchedSocketName)
		{
			return false;
		}
		if (EnableDynamicMaterialQualitySwitch != other.EnableDynamicMaterialQualitySwitch)
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
		if (TeamID != 0)
		{
			num ^= TeamID.GetHashCode();
		}
		if (UnitBodyType != EUnitBodyType.None)
		{
			num ^= UnitBodyType.GetHashCode();
		}
		if (SquadMemberType != EUnitSquadMemberType.None)
		{
			num ^= SquadMemberType.GetHashCode();
		}
		if (ExAnimDataID != 0)
		{
			num ^= ExAnimDataID.GetHashCode();
		}
		if (DefaultBattleInfoExtendID != 0)
		{
			num ^= DefaultBattleInfoExtendID.GetHashCode();
		}
		if (DefaultBeAttackedInfoID != 0)
		{
			num ^= DefaultBeAttackedInfoID.GetHashCode();
		}
		if (DefaultPartRuleInfoID != 0)
		{
			num ^= DefaultPartRuleInfoID.GetHashCode();
		}
		if (HPBarHeightOffset != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(HPBarHeightOffset);
		}
		if (CantBeHitInDingShen != EGSYesNo.No)
		{
			num ^= CantBeHitInDingShen.GetHashCode();
		}
		if (CanReduceStunValue != EGSYesNo.No)
		{
			num ^= CanReduceStunValue.GetHashCode();
		}
		if (CanReduceBRKShieldValue != EGSYesNo.No)
		{
			num ^= CanReduceBRKShieldValue.GetHashCode();
		}
		if (CanReduceSuperArmorValue != EGSYesNo.No)
		{
			num ^= CanReduceSuperArmorValue.GetHashCode();
		}
		if (CanTriggerAdditiveBeHitAnim != EGSYesNo.No)
		{
			num ^= CanTriggerAdditiveBeHitAnim.GetHashCode();
		}
		if (BRKShieldWeakLoopTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BRKShieldWeakLoopTime);
		}
		if (BreakSSARecoverBRKShieldValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BreakSSARecoverBRKShieldValue);
		}
		if (TriggerQTEAngleMin != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TriggerQTEAngleMin);
		}
		if (TriggerQTEAngleMax != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TriggerQTEAngleMax);
		}
		if (PhysicalHitBoneRuleID != 0)
		{
			num ^= PhysicalHitBoneRuleID.GetHashCode();
		}
		if (MaxSkillSuperArmorValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MaxSkillSuperArmorValue);
		}
		if (MaxBlindSlotValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MaxBlindSlotValue);
		}
		if (MoveSpeedFast != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MoveSpeedFast);
		}
		if (MoveSpeedNormal != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MoveSpeedNormal);
		}
		if (MoveSpeedSlow != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MoveSpeedSlow);
		}
		if (KPTTrunSpeed != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(KPTTrunSpeed);
		}
		if (TurnSpeed != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TurnSpeed);
		}
		if (BigTurnSpeed != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BigTurnSpeed);
		}
		if (DingShenDef != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DingShenDef);
		}
		if (Stun != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Stun);
		}
		if (StunDuration != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(StunDuration);
		}
		if (StunBuffID != 0)
		{
			num ^= StunBuffID.GetHashCode();
		}
		if (AtkReboundBuffID != 0)
		{
			num ^= AtkReboundBuffID.GetHashCode();
		}
		if (QTEBeSelectedDist != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(QTEBeSelectedDist);
		}
		if (DefaultTenacity != 0)
		{
			num ^= DefaultTenacity.GetHashCode();
		}
		if (DefaultEarPlug != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DefaultEarPlug);
		}
		if (PartDamageRadio != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PartDamageRadio);
		}
		if (CameraLockDist != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CameraLockDist);
		}
		if (CameraLockDistTolerance != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CameraLockDistTolerance);
		}
		if (WeaponSharpSkillEffectAssetPath.Length != 0)
		{
			num ^= WeaponSharpSkillEffectAssetPath.GetHashCode();
		}
		if (WeaponSharpCritSkillEffectAssetPath.Length != 0)
		{
			num ^= WeaponSharpCritSkillEffectAssetPath.GetHashCode();
		}
		if (ResetType != EBGUResetType.No)
		{
			num ^= ResetType.GetHashCode();
		}
		if (DeadInfoID != 0)
		{
			num ^= DeadInfoID.GetHashCode();
		}
		if (TickRateDisRatio != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TickRateDisRatio);
		}
		if (CanApplyFreezeFrame != EGSYesNo.No)
		{
			num ^= CanApplyFreezeFrame.GetHashCode();
		}
		if (VictimFreezeFrameGap != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(VictimFreezeFrameGap);
		}
		if (FootHeightThreshold != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FootHeightThreshold);
		}
		if (SprintFootSpeedThreshold != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SprintFootSpeedThreshold);
		}
		if (RunFootSpeedThreshold != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(RunFootSpeedThreshold);
		}
		if (WalkFootSpeedThreshold != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(WalkFootSpeedThreshold);
		}
		if (LeftFootSpeedRefBone.Length != 0)
		{
			num ^= LeftFootSpeedRefBone.GetHashCode();
		}
		if (RightFootSpeedRefBone.Length != 0)
		{
			num ^= RightFootSpeedRefBone.GetHashCode();
		}
		if (LeftFootBone.Length != 0)
		{
			num ^= LeftFootBone.GetHashCode();
		}
		if (RightFootBone.Length != 0)
		{
			num ^= RightFootBone.GetHashCode();
		}
		if (LeftFootFrontSocket.Length != 0)
		{
			num ^= LeftFootFrontSocket.GetHashCode();
		}
		if (RightFootFrontSocket.Length != 0)
		{
			num ^= RightFootFrontSocket.GetHashCode();
		}
		if (NoEnemyBeHitFX != EGSYesNo.No)
		{
			num ^= NoEnemyBeHitFX.GetHashCode();
		}
		if (IsElite != EGSYesNo.No)
		{
			num ^= IsElite.GetHashCode();
		}
		if (PartnerAutoRebirthTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PartnerAutoRebirthTime);
		}
		if (SimpleOverlapRadius != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SimpleOverlapRadius);
		}
		if (HPHideImmediately != EGSYesNo.No)
		{
			num ^= HPHideImmediately.GetHashCode();
		}
		if (AimOffsetEyeSocketName.Length != 0)
		{
			num ^= AimOffsetEyeSocketName.GetHashCode();
		}
		if (AimOffsetBeWatchedSocketName.Length != 0)
		{
			num ^= AimOffsetBeWatchedSocketName.GetHashCode();
		}
		if (EnableDynamicMaterialQualitySwitch != EGSYesNo.No)
		{
			num ^= EnableDynamicMaterialQualitySwitch.GetHashCode();
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
		if (TeamID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(TeamID);
		}
		if (UnitBodyType != EUnitBodyType.None)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)UnitBodyType);
		}
		if (SquadMemberType != EUnitSquadMemberType.None)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)SquadMemberType);
		}
		if (ExAnimDataID != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(ExAnimDataID);
		}
		if (DefaultBattleInfoExtendID != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(DefaultBattleInfoExtendID);
		}
		if (DefaultBeAttackedInfoID != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(DefaultBeAttackedInfoID);
		}
		if (DefaultPartRuleInfoID != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(DefaultPartRuleInfoID);
		}
		if (HPBarHeightOffset != 0f)
		{
			output.WriteRawTag(77);
			output.WriteFloat(HPBarHeightOffset);
		}
		if (CantBeHitInDingShen != EGSYesNo.No)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)CantBeHitInDingShen);
		}
		if (CanReduceStunValue != EGSYesNo.No)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)CanReduceStunValue);
		}
		if (CanReduceBRKShieldValue != EGSYesNo.No)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)CanReduceBRKShieldValue);
		}
		if (CanReduceSuperArmorValue != EGSYesNo.No)
		{
			output.WriteRawTag(104);
			output.WriteEnum((int)CanReduceSuperArmorValue);
		}
		if (CanTriggerAdditiveBeHitAnim != EGSYesNo.No)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)CanTriggerAdditiveBeHitAnim);
		}
		if (BRKShieldWeakLoopTime != 0f)
		{
			output.WriteRawTag(125);
			output.WriteFloat(BRKShieldWeakLoopTime);
		}
		if (BreakSSARecoverBRKShieldValue != 0f)
		{
			output.WriteRawTag(133, 1);
			output.WriteFloat(BreakSSARecoverBRKShieldValue);
		}
		if (TriggerQTEAngleMin != 0f)
		{
			output.WriteRawTag(141, 1);
			output.WriteFloat(TriggerQTEAngleMin);
		}
		if (TriggerQTEAngleMax != 0f)
		{
			output.WriteRawTag(149, 1);
			output.WriteFloat(TriggerQTEAngleMax);
		}
		if (PhysicalHitBoneRuleID != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(PhysicalHitBoneRuleID);
		}
		if (MaxSkillSuperArmorValue != 0f)
		{
			output.WriteRawTag(165, 1);
			output.WriteFloat(MaxSkillSuperArmorValue);
		}
		if (MaxBlindSlotValue != 0f)
		{
			output.WriteRawTag(173, 1);
			output.WriteFloat(MaxBlindSlotValue);
		}
		if (MoveSpeedFast != 0f)
		{
			output.WriteRawTag(181, 1);
			output.WriteFloat(MoveSpeedFast);
		}
		if (MoveSpeedNormal != 0f)
		{
			output.WriteRawTag(189, 1);
			output.WriteFloat(MoveSpeedNormal);
		}
		if (MoveSpeedSlow != 0f)
		{
			output.WriteRawTag(197, 1);
			output.WriteFloat(MoveSpeedSlow);
		}
		if (KPTTrunSpeed != 0f)
		{
			output.WriteRawTag(205, 1);
			output.WriteFloat(KPTTrunSpeed);
		}
		if (TurnSpeed != 0f)
		{
			output.WriteRawTag(213, 1);
			output.WriteFloat(TurnSpeed);
		}
		if (BigTurnSpeed != 0f)
		{
			output.WriteRawTag(221, 1);
			output.WriteFloat(BigTurnSpeed);
		}
		if (DingShenDef != 0f)
		{
			output.WriteRawTag(229, 1);
			output.WriteFloat(DingShenDef);
		}
		if (Stun != 0f)
		{
			output.WriteRawTag(237, 1);
			output.WriteFloat(Stun);
		}
		if (StunDuration != 0f)
		{
			output.WriteRawTag(245, 1);
			output.WriteFloat(StunDuration);
		}
		if (StunBuffID != 0)
		{
			output.WriteRawTag(248, 1);
			output.WriteInt32(StunBuffID);
		}
		if (AtkReboundBuffID != 0)
		{
			output.WriteRawTag(128, 2);
			output.WriteInt32(AtkReboundBuffID);
		}
		if (QTEBeSelectedDist != 0f)
		{
			output.WriteRawTag(141, 2);
			output.WriteFloat(QTEBeSelectedDist);
		}
		if (DefaultTenacity != 0)
		{
			output.WriteRawTag(144, 2);
			output.WriteInt32(DefaultTenacity);
		}
		if (DefaultEarPlug != 0f)
		{
			output.WriteRawTag(157, 2);
			output.WriteFloat(DefaultEarPlug);
		}
		if (PartDamageRadio != 0f)
		{
			output.WriteRawTag(165, 2);
			output.WriteFloat(PartDamageRadio);
		}
		if (CameraLockDist != 0f)
		{
			output.WriteRawTag(173, 2);
			output.WriteFloat(CameraLockDist);
		}
		if (CameraLockDistTolerance != 0f)
		{
			output.WriteRawTag(181, 2);
			output.WriteFloat(CameraLockDistTolerance);
		}
		if (WeaponSharpSkillEffectAssetPath.Length != 0)
		{
			output.WriteRawTag(186, 2);
			output.WriteString(WeaponSharpSkillEffectAssetPath);
		}
		if (WeaponSharpCritSkillEffectAssetPath.Length != 0)
		{
			output.WriteRawTag(194, 2);
			output.WriteString(WeaponSharpCritSkillEffectAssetPath);
		}
		if (ResetType != EBGUResetType.No)
		{
			output.WriteRawTag(200, 2);
			output.WriteEnum((int)ResetType);
		}
		if (DeadInfoID != 0)
		{
			output.WriteRawTag(208, 2);
			output.WriteInt32(DeadInfoID);
		}
		if (TickRateDisRatio != 0f)
		{
			output.WriteRawTag(221, 2);
			output.WriteFloat(TickRateDisRatio);
		}
		if (CanApplyFreezeFrame != EGSYesNo.No)
		{
			output.WriteRawTag(224, 2);
			output.WriteEnum((int)CanApplyFreezeFrame);
		}
		if (VictimFreezeFrameGap != 0f)
		{
			output.WriteRawTag(237, 2);
			output.WriteFloat(VictimFreezeFrameGap);
		}
		if (FootHeightThreshold != 0f)
		{
			output.WriteRawTag(245, 2);
			output.WriteFloat(FootHeightThreshold);
		}
		if (SprintFootSpeedThreshold != 0f)
		{
			output.WriteRawTag(253, 2);
			output.WriteFloat(SprintFootSpeedThreshold);
		}
		if (RunFootSpeedThreshold != 0f)
		{
			output.WriteRawTag(133, 3);
			output.WriteFloat(RunFootSpeedThreshold);
		}
		if (WalkFootSpeedThreshold != 0f)
		{
			output.WriteRawTag(141, 3);
			output.WriteFloat(WalkFootSpeedThreshold);
		}
		if (LeftFootSpeedRefBone.Length != 0)
		{
			output.WriteRawTag(146, 3);
			output.WriteString(LeftFootSpeedRefBone);
		}
		if (RightFootSpeedRefBone.Length != 0)
		{
			output.WriteRawTag(154, 3);
			output.WriteString(RightFootSpeedRefBone);
		}
		if (LeftFootBone.Length != 0)
		{
			output.WriteRawTag(162, 3);
			output.WriteString(LeftFootBone);
		}
		if (RightFootBone.Length != 0)
		{
			output.WriteRawTag(170, 3);
			output.WriteString(RightFootBone);
		}
		if (LeftFootFrontSocket.Length != 0)
		{
			output.WriteRawTag(178, 3);
			output.WriteString(LeftFootFrontSocket);
		}
		if (RightFootFrontSocket.Length != 0)
		{
			output.WriteRawTag(186, 3);
			output.WriteString(RightFootFrontSocket);
		}
		if (NoEnemyBeHitFX != EGSYesNo.No)
		{
			output.WriteRawTag(192, 3);
			output.WriteEnum((int)NoEnemyBeHitFX);
		}
		if (IsElite != EGSYesNo.No)
		{
			output.WriteRawTag(200, 3);
			output.WriteEnum((int)IsElite);
		}
		if (PartnerAutoRebirthTime != 0f)
		{
			output.WriteRawTag(213, 3);
			output.WriteFloat(PartnerAutoRebirthTime);
		}
		if (SimpleOverlapRadius != 0f)
		{
			output.WriteRawTag(221, 3);
			output.WriteFloat(SimpleOverlapRadius);
		}
		if (HPHideImmediately != EGSYesNo.No)
		{
			output.WriteRawTag(224, 3);
			output.WriteEnum((int)HPHideImmediately);
		}
		if (AimOffsetEyeSocketName.Length != 0)
		{
			output.WriteRawTag(234, 3);
			output.WriteString(AimOffsetEyeSocketName);
		}
		if (AimOffsetBeWatchedSocketName.Length != 0)
		{
			output.WriteRawTag(242, 3);
			output.WriteString(AimOffsetBeWatchedSocketName);
		}
		if (EnableDynamicMaterialQualitySwitch != EGSYesNo.No)
		{
			output.WriteRawTag(248, 3);
			output.WriteEnum((int)EnableDynamicMaterialQualitySwitch);
		}
		if (Guard.Length != 0)
		{
			output.WriteRawTag(130, 4);
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
		if (TeamID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TeamID);
		}
		if (UnitBodyType != EUnitBodyType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)UnitBodyType);
		}
		if (SquadMemberType != EUnitSquadMemberType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SquadMemberType);
		}
		if (ExAnimDataID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExAnimDataID);
		}
		if (DefaultBattleInfoExtendID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DefaultBattleInfoExtendID);
		}
		if (DefaultBeAttackedInfoID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DefaultBeAttackedInfoID);
		}
		if (DefaultPartRuleInfoID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DefaultPartRuleInfoID);
		}
		if (HPBarHeightOffset != 0f)
		{
			num += 5;
		}
		if (CantBeHitInDingShen != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CantBeHitInDingShen);
		}
		if (CanReduceStunValue != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CanReduceStunValue);
		}
		if (CanReduceBRKShieldValue != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CanReduceBRKShieldValue);
		}
		if (CanReduceSuperArmorValue != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CanReduceSuperArmorValue);
		}
		if (CanTriggerAdditiveBeHitAnim != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CanTriggerAdditiveBeHitAnim);
		}
		if (BRKShieldWeakLoopTime != 0f)
		{
			num += 5;
		}
		if (BreakSSARecoverBRKShieldValue != 0f)
		{
			num += 6;
		}
		if (TriggerQTEAngleMin != 0f)
		{
			num += 6;
		}
		if (TriggerQTEAngleMax != 0f)
		{
			num += 6;
		}
		if (PhysicalHitBoneRuleID != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PhysicalHitBoneRuleID);
		}
		if (MaxSkillSuperArmorValue != 0f)
		{
			num += 6;
		}
		if (MaxBlindSlotValue != 0f)
		{
			num += 6;
		}
		if (MoveSpeedFast != 0f)
		{
			num += 6;
		}
		if (MoveSpeedNormal != 0f)
		{
			num += 6;
		}
		if (MoveSpeedSlow != 0f)
		{
			num += 6;
		}
		if (KPTTrunSpeed != 0f)
		{
			num += 6;
		}
		if (TurnSpeed != 0f)
		{
			num += 6;
		}
		if (BigTurnSpeed != 0f)
		{
			num += 6;
		}
		if (DingShenDef != 0f)
		{
			num += 6;
		}
		if (Stun != 0f)
		{
			num += 6;
		}
		if (StunDuration != 0f)
		{
			num += 6;
		}
		if (StunBuffID != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(StunBuffID);
		}
		if (AtkReboundBuffID != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(AtkReboundBuffID);
		}
		if (QTEBeSelectedDist != 0f)
		{
			num += 6;
		}
		if (DefaultTenacity != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DefaultTenacity);
		}
		if (DefaultEarPlug != 0f)
		{
			num += 6;
		}
		if (PartDamageRadio != 0f)
		{
			num += 6;
		}
		if (CameraLockDist != 0f)
		{
			num += 6;
		}
		if (CameraLockDistTolerance != 0f)
		{
			num += 6;
		}
		if (WeaponSharpSkillEffectAssetPath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(WeaponSharpSkillEffectAssetPath);
		}
		if (WeaponSharpCritSkillEffectAssetPath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(WeaponSharpCritSkillEffectAssetPath);
		}
		if (ResetType != EBGUResetType.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)ResetType);
		}
		if (DeadInfoID != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DeadInfoID);
		}
		if (TickRateDisRatio != 0f)
		{
			num += 6;
		}
		if (CanApplyFreezeFrame != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)CanApplyFreezeFrame);
		}
		if (VictimFreezeFrameGap != 0f)
		{
			num += 6;
		}
		if (FootHeightThreshold != 0f)
		{
			num += 6;
		}
		if (SprintFootSpeedThreshold != 0f)
		{
			num += 6;
		}
		if (RunFootSpeedThreshold != 0f)
		{
			num += 6;
		}
		if (WalkFootSpeedThreshold != 0f)
		{
			num += 6;
		}
		if (LeftFootSpeedRefBone.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LeftFootSpeedRefBone);
		}
		if (RightFootSpeedRefBone.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(RightFootSpeedRefBone);
		}
		if (LeftFootBone.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LeftFootBone);
		}
		if (RightFootBone.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(RightFootBone);
		}
		if (LeftFootFrontSocket.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LeftFootFrontSocket);
		}
		if (RightFootFrontSocket.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(RightFootFrontSocket);
		}
		if (NoEnemyBeHitFX != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)NoEnemyBeHitFX);
		}
		if (IsElite != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)IsElite);
		}
		if (PartnerAutoRebirthTime != 0f)
		{
			num += 6;
		}
		if (SimpleOverlapRadius != 0f)
		{
			num += 6;
		}
		if (HPHideImmediately != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)HPHideImmediately);
		}
		if (AimOffsetEyeSocketName.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(AimOffsetEyeSocketName);
		}
		if (AimOffsetBeWatchedSocketName.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(AimOffsetBeWatchedSocketName);
		}
		if (EnableDynamicMaterialQualitySwitch != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)EnableDynamicMaterialQualitySwitch);
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

	public void MergeFrom(FUStUnitCommDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.TeamID != 0)
			{
				TeamID = other.TeamID;
			}
			if (other.UnitBodyType != EUnitBodyType.None)
			{
				UnitBodyType = other.UnitBodyType;
			}
			if (other.SquadMemberType != EUnitSquadMemberType.None)
			{
				SquadMemberType = other.SquadMemberType;
			}
			if (other.ExAnimDataID != 0)
			{
				ExAnimDataID = other.ExAnimDataID;
			}
			if (other.DefaultBattleInfoExtendID != 0)
			{
				DefaultBattleInfoExtendID = other.DefaultBattleInfoExtendID;
			}
			if (other.DefaultBeAttackedInfoID != 0)
			{
				DefaultBeAttackedInfoID = other.DefaultBeAttackedInfoID;
			}
			if (other.DefaultPartRuleInfoID != 0)
			{
				DefaultPartRuleInfoID = other.DefaultPartRuleInfoID;
			}
			if (other.HPBarHeightOffset != 0f)
			{
				HPBarHeightOffset = other.HPBarHeightOffset;
			}
			if (other.CantBeHitInDingShen != EGSYesNo.No)
			{
				CantBeHitInDingShen = other.CantBeHitInDingShen;
			}
			if (other.CanReduceStunValue != EGSYesNo.No)
			{
				CanReduceStunValue = other.CanReduceStunValue;
			}
			if (other.CanReduceBRKShieldValue != EGSYesNo.No)
			{
				CanReduceBRKShieldValue = other.CanReduceBRKShieldValue;
			}
			if (other.CanReduceSuperArmorValue != EGSYesNo.No)
			{
				CanReduceSuperArmorValue = other.CanReduceSuperArmorValue;
			}
			if (other.CanTriggerAdditiveBeHitAnim != EGSYesNo.No)
			{
				CanTriggerAdditiveBeHitAnim = other.CanTriggerAdditiveBeHitAnim;
			}
			if (other.BRKShieldWeakLoopTime != 0f)
			{
				BRKShieldWeakLoopTime = other.BRKShieldWeakLoopTime;
			}
			if (other.BreakSSARecoverBRKShieldValue != 0f)
			{
				BreakSSARecoverBRKShieldValue = other.BreakSSARecoverBRKShieldValue;
			}
			if (other.TriggerQTEAngleMin != 0f)
			{
				TriggerQTEAngleMin = other.TriggerQTEAngleMin;
			}
			if (other.TriggerQTEAngleMax != 0f)
			{
				TriggerQTEAngleMax = other.TriggerQTEAngleMax;
			}
			if (other.PhysicalHitBoneRuleID != 0)
			{
				PhysicalHitBoneRuleID = other.PhysicalHitBoneRuleID;
			}
			if (other.MaxSkillSuperArmorValue != 0f)
			{
				MaxSkillSuperArmorValue = other.MaxSkillSuperArmorValue;
			}
			if (other.MaxBlindSlotValue != 0f)
			{
				MaxBlindSlotValue = other.MaxBlindSlotValue;
			}
			if (other.MoveSpeedFast != 0f)
			{
				MoveSpeedFast = other.MoveSpeedFast;
			}
			if (other.MoveSpeedNormal != 0f)
			{
				MoveSpeedNormal = other.MoveSpeedNormal;
			}
			if (other.MoveSpeedSlow != 0f)
			{
				MoveSpeedSlow = other.MoveSpeedSlow;
			}
			if (other.KPTTrunSpeed != 0f)
			{
				KPTTrunSpeed = other.KPTTrunSpeed;
			}
			if (other.TurnSpeed != 0f)
			{
				TurnSpeed = other.TurnSpeed;
			}
			if (other.BigTurnSpeed != 0f)
			{
				BigTurnSpeed = other.BigTurnSpeed;
			}
			if (other.DingShenDef != 0f)
			{
				DingShenDef = other.DingShenDef;
			}
			if (other.Stun != 0f)
			{
				Stun = other.Stun;
			}
			if (other.StunDuration != 0f)
			{
				StunDuration = other.StunDuration;
			}
			if (other.StunBuffID != 0)
			{
				StunBuffID = other.StunBuffID;
			}
			if (other.AtkReboundBuffID != 0)
			{
				AtkReboundBuffID = other.AtkReboundBuffID;
			}
			if (other.QTEBeSelectedDist != 0f)
			{
				QTEBeSelectedDist = other.QTEBeSelectedDist;
			}
			if (other.DefaultTenacity != 0)
			{
				DefaultTenacity = other.DefaultTenacity;
			}
			if (other.DefaultEarPlug != 0f)
			{
				DefaultEarPlug = other.DefaultEarPlug;
			}
			if (other.PartDamageRadio != 0f)
			{
				PartDamageRadio = other.PartDamageRadio;
			}
			if (other.CameraLockDist != 0f)
			{
				CameraLockDist = other.CameraLockDist;
			}
			if (other.CameraLockDistTolerance != 0f)
			{
				CameraLockDistTolerance = other.CameraLockDistTolerance;
			}
			if (other.WeaponSharpSkillEffectAssetPath.Length != 0)
			{
				WeaponSharpSkillEffectAssetPath = other.WeaponSharpSkillEffectAssetPath;
			}
			if (other.WeaponSharpCritSkillEffectAssetPath.Length != 0)
			{
				WeaponSharpCritSkillEffectAssetPath = other.WeaponSharpCritSkillEffectAssetPath;
			}
			if (other.ResetType != EBGUResetType.No)
			{
				ResetType = other.ResetType;
			}
			if (other.DeadInfoID != 0)
			{
				DeadInfoID = other.DeadInfoID;
			}
			if (other.TickRateDisRatio != 0f)
			{
				TickRateDisRatio = other.TickRateDisRatio;
			}
			if (other.CanApplyFreezeFrame != EGSYesNo.No)
			{
				CanApplyFreezeFrame = other.CanApplyFreezeFrame;
			}
			if (other.VictimFreezeFrameGap != 0f)
			{
				VictimFreezeFrameGap = other.VictimFreezeFrameGap;
			}
			if (other.FootHeightThreshold != 0f)
			{
				FootHeightThreshold = other.FootHeightThreshold;
			}
			if (other.SprintFootSpeedThreshold != 0f)
			{
				SprintFootSpeedThreshold = other.SprintFootSpeedThreshold;
			}
			if (other.RunFootSpeedThreshold != 0f)
			{
				RunFootSpeedThreshold = other.RunFootSpeedThreshold;
			}
			if (other.WalkFootSpeedThreshold != 0f)
			{
				WalkFootSpeedThreshold = other.WalkFootSpeedThreshold;
			}
			if (other.LeftFootSpeedRefBone.Length != 0)
			{
				LeftFootSpeedRefBone = other.LeftFootSpeedRefBone;
			}
			if (other.RightFootSpeedRefBone.Length != 0)
			{
				RightFootSpeedRefBone = other.RightFootSpeedRefBone;
			}
			if (other.LeftFootBone.Length != 0)
			{
				LeftFootBone = other.LeftFootBone;
			}
			if (other.RightFootBone.Length != 0)
			{
				RightFootBone = other.RightFootBone;
			}
			if (other.LeftFootFrontSocket.Length != 0)
			{
				LeftFootFrontSocket = other.LeftFootFrontSocket;
			}
			if (other.RightFootFrontSocket.Length != 0)
			{
				RightFootFrontSocket = other.RightFootFrontSocket;
			}
			if (other.NoEnemyBeHitFX != EGSYesNo.No)
			{
				NoEnemyBeHitFX = other.NoEnemyBeHitFX;
			}
			if (other.IsElite != EGSYesNo.No)
			{
				IsElite = other.IsElite;
			}
			if (other.PartnerAutoRebirthTime != 0f)
			{
				PartnerAutoRebirthTime = other.PartnerAutoRebirthTime;
			}
			if (other.SimpleOverlapRadius != 0f)
			{
				SimpleOverlapRadius = other.SimpleOverlapRadius;
			}
			if (other.HPHideImmediately != EGSYesNo.No)
			{
				HPHideImmediately = other.HPHideImmediately;
			}
			if (other.AimOffsetEyeSocketName.Length != 0)
			{
				AimOffsetEyeSocketName = other.AimOffsetEyeSocketName;
			}
			if (other.AimOffsetBeWatchedSocketName.Length != 0)
			{
				AimOffsetBeWatchedSocketName = other.AimOffsetBeWatchedSocketName;
			}
			if (other.EnableDynamicMaterialQualitySwitch != EGSYesNo.No)
			{
				EnableDynamicMaterialQualitySwitch = other.EnableDynamicMaterialQualitySwitch;
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
				TeamID = input.ReadInt32();
				break;
			case 24u:
				UnitBodyType = (EUnitBodyType)input.ReadEnum();
				break;
			case 32u:
				SquadMemberType = (EUnitSquadMemberType)input.ReadEnum();
				break;
			case 40u:
				ExAnimDataID = input.ReadInt32();
				break;
			case 48u:
				DefaultBattleInfoExtendID = input.ReadInt32();
				break;
			case 56u:
				DefaultBeAttackedInfoID = input.ReadInt32();
				break;
			case 64u:
				DefaultPartRuleInfoID = input.ReadInt32();
				break;
			case 77u:
				HPBarHeightOffset = input.ReadFloat();
				break;
			case 80u:
				CantBeHitInDingShen = (EGSYesNo)input.ReadEnum();
				break;
			case 88u:
				CanReduceStunValue = (EGSYesNo)input.ReadEnum();
				break;
			case 96u:
				CanReduceBRKShieldValue = (EGSYesNo)input.ReadEnum();
				break;
			case 104u:
				CanReduceSuperArmorValue = (EGSYesNo)input.ReadEnum();
				break;
			case 112u:
				CanTriggerAdditiveBeHitAnim = (EGSYesNo)input.ReadEnum();
				break;
			case 125u:
				BRKShieldWeakLoopTime = input.ReadFloat();
				break;
			case 133u:
				BreakSSARecoverBRKShieldValue = input.ReadFloat();
				break;
			case 141u:
				TriggerQTEAngleMin = input.ReadFloat();
				break;
			case 149u:
				TriggerQTEAngleMax = input.ReadFloat();
				break;
			case 152u:
				PhysicalHitBoneRuleID = input.ReadInt32();
				break;
			case 165u:
				MaxSkillSuperArmorValue = input.ReadFloat();
				break;
			case 173u:
				MaxBlindSlotValue = input.ReadFloat();
				break;
			case 181u:
				MoveSpeedFast = input.ReadFloat();
				break;
			case 189u:
				MoveSpeedNormal = input.ReadFloat();
				break;
			case 197u:
				MoveSpeedSlow = input.ReadFloat();
				break;
			case 205u:
				KPTTrunSpeed = input.ReadFloat();
				break;
			case 213u:
				TurnSpeed = input.ReadFloat();
				break;
			case 221u:
				BigTurnSpeed = input.ReadFloat();
				break;
			case 229u:
				DingShenDef = input.ReadFloat();
				break;
			case 237u:
				Stun = input.ReadFloat();
				break;
			case 245u:
				StunDuration = input.ReadFloat();
				break;
			case 248u:
				StunBuffID = input.ReadInt32();
				break;
			case 256u:
				AtkReboundBuffID = input.ReadInt32();
				break;
			case 269u:
				QTEBeSelectedDist = input.ReadFloat();
				break;
			case 272u:
				DefaultTenacity = input.ReadInt32();
				break;
			case 285u:
				DefaultEarPlug = input.ReadFloat();
				break;
			case 293u:
				PartDamageRadio = input.ReadFloat();
				break;
			case 301u:
				CameraLockDist = input.ReadFloat();
				break;
			case 309u:
				CameraLockDistTolerance = input.ReadFloat();
				break;
			case 314u:
				WeaponSharpSkillEffectAssetPath = input.ReadString();
				break;
			case 322u:
				WeaponSharpCritSkillEffectAssetPath = input.ReadString();
				break;
			case 328u:
				ResetType = (EBGUResetType)input.ReadEnum();
				break;
			case 336u:
				DeadInfoID = input.ReadInt32();
				break;
			case 349u:
				TickRateDisRatio = input.ReadFloat();
				break;
			case 352u:
				CanApplyFreezeFrame = (EGSYesNo)input.ReadEnum();
				break;
			case 365u:
				VictimFreezeFrameGap = input.ReadFloat();
				break;
			case 373u:
				FootHeightThreshold = input.ReadFloat();
				break;
			case 381u:
				SprintFootSpeedThreshold = input.ReadFloat();
				break;
			case 389u:
				RunFootSpeedThreshold = input.ReadFloat();
				break;
			case 397u:
				WalkFootSpeedThreshold = input.ReadFloat();
				break;
			case 402u:
				LeftFootSpeedRefBone = input.ReadString();
				break;
			case 410u:
				RightFootSpeedRefBone = input.ReadString();
				break;
			case 418u:
				LeftFootBone = input.ReadString();
				break;
			case 426u:
				RightFootBone = input.ReadString();
				break;
			case 434u:
				LeftFootFrontSocket = input.ReadString();
				break;
			case 442u:
				RightFootFrontSocket = input.ReadString();
				break;
			case 448u:
				NoEnemyBeHitFX = (EGSYesNo)input.ReadEnum();
				break;
			case 456u:
				IsElite = (EGSYesNo)input.ReadEnum();
				break;
			case 469u:
				PartnerAutoRebirthTime = input.ReadFloat();
				break;
			case 477u:
				SimpleOverlapRadius = input.ReadFloat();
				break;
			case 480u:
				HPHideImmediately = (EGSYesNo)input.ReadEnum();
				break;
			case 490u:
				AimOffsetEyeSocketName = input.ReadString();
				break;
			case 498u:
				AimOffsetBeWatchedSocketName = input.ReadString();
				break;
			case 504u:
				EnableDynamicMaterialQualitySwitch = (EGSYesNo)input.ReadEnum();
				break;
			case 514u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
