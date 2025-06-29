using System;
using System.Collections.Generic;
using System.Linq;
using b1.ECS;
using BtlB1;
using BtlShare;
using GurCalliopeState;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_CheckData : IBUC_CheckData, IPersistentECSData
{
	public TWeakObject<AActor> Owner { get; set; }

	public IBUC_TargetInfoData TargetInfoData { get; set; }

	public IBUC_AttrContainer AttrContainer { get; set; }

	public IBUC_SimpleStateData SimpleStateData { get; set; }

	public IBUC_UnitStateData UnitStateData { get; set; }

	public IBUC_BuffData BuffData { get; set; }

	public IBUC_FsmData FsmData { get; set; }

	public IBUC_BeAttackData BeAttackData { get; set; }

	public IBUC_MasterData MasterData { get; set; }

	public IBUC_GuidData GuidData { get; set; }

	public IBUC_SkillInstsData SkillInstsData { get; set; }

	public IBUC_ActorTransformInfoData TransformInfoData { get; set; }

	public IBUC_EnvironmentInteractionMgrData EnvironmentInteractionMgrData { get; set; }

	private IBUC_FollowPartnerData FollowPartnerData { get; set; }

	public IBIC_GlobalActorData GlobalActorData { get; set; }

	public IBGC_CircusControlData TamerFamilyTreeData { get; set; }

	public IBPC_PlayerRoleData PlayerRoleData { get; set; }

	public Dictionary<Guid, GSGameplayCounter> GameplayCounters { get; } = new Dictionary<Guid, GSGameplayCounter>();

	public List<Guid> CompletedCounters { get; } = new List<Guid>();

	public bool CheckDetectCondition(FDetectConditionForCheck DetectCondition)
	{
		if (!Owner.IsValid())
		{
			return false;
		}
		bool flag = false;
		switch (DetectCondition.DetectedElementType)
		{
		case EDetectedElementType.SimpleState:
			flag = OnCheckSimpleState(DetectCondition.SimpleState);
			break;
		case EDetectedElementType.UnitState:
			flag = OnCheckUnitState(DetectCondition.UnitState);
			break;
		case EDetectedElementType.HasBuff:
			flag = OnCheckBuff(DetectCondition.BuffId);
			break;
		case EDetectedElementType.UnitAttr:
			flag = OnCheckUnitAttr(DetectCondition.AttrFloatType, DetectCondition.CompareOperation, DetectCondition.CompareValue);
			break;
		case EDetectedElementType.UnitActived:
			flag = OnCheckUnitActive(bActiveOrInactive: true);
			break;
		case EDetectedElementType.UnitInActived:
			flag = OnCheckUnitActive(bActiveOrInactive: false);
			break;
		case EDetectedElementType.FsmState:
			flag = OnCheckFsmState(DetectCondition.FsmState);
			break;
		case EDetectedElementType.SkillCoolDown:
			flag = OnCheckSkillCoolDown(DetectCondition.SkillId);
			break;
		case EDetectedElementType.DistanceFromTarget:
			flag = OnCheckDistanceFromTarget(DetectCondition.DistanceCompareOperations, DetectCondition.DistanceCompareValue);
			break;
		case EDetectedElementType.DistanceFromMaster:
			flag = OnCheckDistanceFromMaster(DetectCondition.DistanceCompareOperations, DetectCondition.DistanceCompareValue);
			break;
		case EDetectedElementType.SkillCanCast:
			flag = OnCheckSkillCanCast(DetectCondition.SkillId);
			break;
		case EDetectedElementType.CustomFsmState:
			flag = OnCheckCustomFsmState(DetectCondition.CustomFsmState);
			break;
		case EDetectedElementType.LastBeAttackedStiffLevel:
			flag = OnCheckLastBeAttackedStiffLevel(DetectCondition.CompareOperation, DetectCondition.CompareValueInt);
			break;
		case EDetectedElementType.CurrentBeAttackedStiffLevel:
			flag = OnCheckCurrentBeAttackedStiffLevel(DetectCondition.CompareOperation, DetectCondition.CompareValueInt);
			break;
		case EDetectedElementType.ActorYawRotation:
			flag = OnCheckActorYawRotation(DetectCondition.BaseDirection, DetectCondition.MinYawAngle, DetectCondition.MaxYawAngle);
			break;
		case EDetectedElementType.GlobalCastSkillCount:
			flag = OnCheckGlobalCastSkillCount(DetectCondition.SkillId, DetectCondition.CompareOperation, DetectCondition.CompareValueInt);
			break;
		case EDetectedElementType.AbnormalState:
			flag = OnCheckAbnormalState(DetectCondition.AbnormalStateType);
			break;
		case EDetectedElementType.DurCastSkill:
			flag = OnCheckDurCastSkill(DetectCondition.SkillIdList);
			break;
		case EDetectedElementType.CurSkillCostDmgNum:
			flag = CurSkill_CostDmgNum(DetectCondition.CompareOperation, DetectCondition.CompareValueInt);
			break;
		case EDetectedElementType.SocketUnitsDead:
			flag = OnSocketUnitsDead(DetectCondition.MatchInfo);
			break;
		case EDetectedElementType.DistanceFromNearestPlayer:
			flag = OnDistanceFromNearestPlayer(DetectCondition.CompareOperation, DetectCondition.CompareValueInt);
			break;
		case EDetectedElementType.SpecifyResIdUnitsDead:
			flag = OnSpecifyResIdUnitsDead(DetectCondition.ResId);
			break;
		case EDetectedElementType.FamilySpecifyUnitAttr:
			flag = OnCheckFamilySpecifyUnitAttr(DetectCondition.MatchInfo, DetectCondition.AttrFloatType, DetectCondition.CompareOperation, DetectCondition.CompareValue);
			break;
		case EDetectedElementType.Random:
			flag = CheckSuccessRate(DetectCondition.SuccessRate);
			break;
		case EDetectedElementType.FamilyUnitAliveNum:
			flag = CheckFamilyUnitAliveNum(DetectCondition.MatchInfo, DetectCondition.CompareOperation, DetectCondition.DeadUnitNum);
			break;
		case EDetectedElementType.TargetInAngleRange:
			flag = OnCheckTargetInAngleRange(DetectCondition.MinYawAngle, DetectCondition.MaxYawAngle);
			break;
		case EDetectedElementType.CompareBuffLayer:
			flag = CheckBuffLayer(DetectCondition.BuffId, DetectCondition.BuffLayer, DetectCondition.OperationType);
			break;
		case EDetectedElementType.CompareGamePlusCount:
			flag = CheckGamePlusCount(DetectCondition.GamePlusCount, DetectCondition.OperationType);
			break;
		case EDetectedElementType.CheckSurfaceType:
			flag = CheckSurfaceType(DetectCondition.SurfaceType);
			break;
		case EDetectedElementType.HasStoryCanTalkInThisLevel:
			flag = CheckHasStoryCanTalkInThisLevelThisArea();
			break;
		case EDetectedElementType.StoryInCollingOffPeriod:
			flag = CheckStoryInCollingOffPeriod();
			break;
		case EDetectedElementType.PlayerLeisureOverTime:
			flag = CheckPlayerLeisureOverTime(DetectCondition.CompareValue);
			break;
		}
		if (DetectCondition.bReverseCondition)
		{
			return !flag;
		}
		return flag;
	}

	public bool CheckDetectCondition(CalliopeCustom_DetectCondition DetectCondition)
	{
		if (!Owner.IsValid())
		{
			return false;
		}
		bool flag = false;
		switch ((EDetectedElementType)(byte)DetectCondition.DetectedElementType)
		{
		case EDetectedElementType.SimpleState:
			flag = OnCheckSimpleState((EBGUSimpleState)DetectCondition.SimpleState.SimpleState);
			break;
		case EDetectedElementType.UnitState:
			flag = OnCheckUnitState((EBGUUnitState)DetectCondition.UnitState.UnitState);
			break;
		case EDetectedElementType.HasBuff:
			flag = OnCheckBuff(DetectCondition.HasBuff.BuffId);
			break;
		case EDetectedElementType.UnitAttr:
			flag = OnCheckUnitAttr((EBGUAttrFloat)DetectCondition.UnitAttr.AttrFloatType, (EValueCompareOperations)DetectCondition.UnitAttr.CompareOperation, DetectCondition.UnitAttr.CompareValue);
			break;
		case EDetectedElementType.UnitActived:
			flag = OnCheckUnitActive(bActiveOrInactive: true);
			break;
		case EDetectedElementType.UnitInActived:
			flag = OnCheckUnitActive(bActiveOrInactive: false);
			break;
		case EDetectedElementType.FsmState:
			flag = OnCheckFsmState((EBGUFSMStateName)DetectCondition.FsmState.FsmState);
			break;
		case EDetectedElementType.SkillCoolDown:
			flag = OnCheckSkillCoolDown(DetectCondition.SkillCoolDown.SkillId);
			break;
		case EDetectedElementType.DistanceFromTarget:
			flag = OnCheckDistanceFromTarget((EValueCompareOperations)DetectCondition.DistanceFromTarget.DistanceCompareOperations, DetectCondition.DistanceFromTarget.DistanceCompareValue);
			break;
		case EDetectedElementType.DistanceFromMaster:
			flag = OnCheckDistanceFromMaster((EValueCompareOperations)DetectCondition.DistanceFromMaster.DistanceCompareOperations, DetectCondition.DistanceFromMaster.DistanceCompareValue);
			break;
		case EDetectedElementType.SkillCanCast:
			flag = OnCheckSkillCanCast(DetectCondition.SkillCanCast.SkillId);
			break;
		case EDetectedElementType.CustomFsmState:
			flag = OnCheckCustomFsmState(GameplayTagExtension.MakeGameplayTag(DetectCondition.CustomFsmState.CustomFsmState));
			break;
		case EDetectedElementType.LastBeAttackedStiffLevel:
			flag = OnCheckLastBeAttackedStiffLevel((EValueCompareOperations)DetectCondition.LastBeAttackedStiffLevel.CompareOperation, DetectCondition.LastBeAttackedStiffLevel.CompareValueInt);
			break;
		case EDetectedElementType.CurrentBeAttackedStiffLevel:
			flag = OnCheckCurrentBeAttackedStiffLevel((EValueCompareOperations)DetectCondition.CurrentBeAttackedStiffLevel.CompareOperation, DetectCondition.CurrentBeAttackedStiffLevel.CompareValueInt);
			break;
		case EDetectedElementType.ActorYawRotation:
			flag = OnCheckActorYawRotation((ERotationBaseDirection)DetectCondition.ActorYawRotation.BaseDirection, DetectCondition.ActorYawRotation.MinYawAngle, DetectCondition.ActorYawRotation.MaxYawAngle);
			break;
		case EDetectedElementType.GlobalCastSkillCount:
			flag = OnCheckGlobalCastSkillCount(DetectCondition.GlobalCastSkillCount.SkillId, (EValueCompareOperations)DetectCondition.GlobalCastSkillCount.CompareOperation, DetectCondition.GlobalCastSkillCount.CompareValueInt);
			break;
		case EDetectedElementType.AbnormalState:
			flag = OnCheckAbnormalState((EAbnormalStateType)DetectCondition.AbnormalState.AbnormalStateType);
			break;
		case EDetectedElementType.DurCastSkill:
			flag = OnCheckDurCastSkill(DetectCondition.DurCastSkill.SkillIdList);
			break;
		case EDetectedElementType.CurSkillCostDmgNum:
			flag = CurSkill_CostDmgNum((EValueCompareOperations)DetectCondition.CurSkillCostDmgNum.CompareOperation, DetectCondition.CurSkillCostDmgNum.CompareValueInt);
			break;
		case EDetectedElementType.SocketUnitsDead:
			flag = OnSocketUnitsDead(BED_CalliopeFuncLib.Deserialize(DetectCondition.SocketUnitsDead.MatchInfo));
			break;
		case EDetectedElementType.DistanceFromNearestPlayer:
			flag = OnDistanceFromNearestPlayer((EValueCompareOperations)DetectCondition.DistanceFromNearestPlayer.CompareOperation, DetectCondition.DistanceFromNearestPlayer.CompareValueInt);
			break;
		case EDetectedElementType.SpecifyResIdUnitsDead:
			flag = OnSpecifyResIdUnitsDead(DetectCondition.SpecifyResIdUnitsDead.ResId);
			break;
		case EDetectedElementType.FamilySpecifyUnitAttr:
			flag = OnCheckFamilySpecifyUnitAttr(BED_CalliopeFuncLib.Deserialize(DetectCondition.FamilySpecifyUnitAttr.MatchInfo), (EBGUAttrFloat)DetectCondition.FamilySpecifyUnitAttr.AttrFloatType, (EValueCompareOperations)DetectCondition.FamilySpecifyUnitAttr.CompareOperation, DetectCondition.FamilySpecifyUnitAttr.CompareValue);
			break;
		case EDetectedElementType.Random:
			flag = CheckSuccessRate(DetectCondition.Random.SuccessRate);
			break;
		case EDetectedElementType.FamilyUnitAliveNum:
			flag = CheckFamilyUnitAliveNum(BED_CalliopeFuncLib.Deserialize(DetectCondition.FamilyUnitAliveNum.MatchInfo), (EValueCompareOperations)DetectCondition.FamilyUnitAliveNum.CompareOperation, DetectCondition.FamilyUnitAliveNum.AliveUnitNum);
			break;
		case EDetectedElementType.TargetInAngleRange:
			flag = OnCheckTargetInAngleRange(DetectCondition.TargetInAngleRange.MinYawAngle, DetectCondition.TargetInAngleRange.MaxYawAngle);
			break;
		case EDetectedElementType.CompareBuffLayer:
			flag = CheckBuffLayer(DetectCondition.CompareBuffLayer.BuffId, DetectCondition.CompareBuffLayer.BuffLayer, (EValueCompareOperationType)DetectCondition.CompareBuffLayer.OperationType);
			break;
		case EDetectedElementType.CompareGamePlusCount:
			flag = CheckGamePlusCount(DetectCondition.CompareGamePlusCount.GamePlusCount, (EValueCompareOperationType)DetectCondition.CompareGamePlusCount.OperationType);
			break;
		case EDetectedElementType.CheckSurfaceType:
			flag = CheckSurfaceType((ESceneItemSurfaceType)DetectCondition.CheckSurfaceType.SurfaceType);
			break;
		case EDetectedElementType.HasStoryCanTalkInThisLevel:
			flag = CheckHasStoryCanTalkInThisLevelThisArea();
			break;
		case EDetectedElementType.StoryInCollingOffPeriod:
			flag = CheckStoryInCollingOffPeriod();
			break;
		case EDetectedElementType.PlayerLeisureOverTime:
			flag = CheckPlayerLeisureOverTime(DetectCondition.PlayerLeisureOverTime.PlayerLeisureOverTime);
			break;
		}
		if (DetectCondition.IsReverseCondition)
		{
			return !flag;
		}
		return flag;
	}

	public bool CheckObserveCondition(FlowObserveCondition ObserveCondition)
	{
		if (!Owner.IsValid())
		{
			return false;
		}
		return ObserveCondition.ConditionType switch
		{
			EObserveConditionType.UnitActive => OnCheckUnitActive(bActiveOrInactive: true), 
			EObserveConditionType.UnitInActive => OnCheckUnitActive(bActiveOrInactive: false), 
			EObserveConditionType.UnitAttr => OnCheckUnitAttr(ObserveCondition.AttrFloatType, ObserveCondition.CompareOperation, ObserveCondition.CompareValue), 
			EObserveConditionType.SimpleState => OnCheckSimpleState(ObserveCondition.SimpleState), 
			EObserveConditionType.UnitState => OnCheckUnitState(ObserveCondition.UnitState), 
			EObserveConditionType.HasBuff => OnCheckBuff(ObserveCondition.BuffId), 
			_ => false, 
		};
	}

	private bool OnCheckUnitActive(bool bActiveOrInactive)
	{
		return TargetInfoData.GetTargetInfo().LockTargetEntity != Entity.Null == bActiveOrInactive;
	}

	private bool OnCheckUnitAttr(EBGUAttrFloat AttrFloatType, EValueCompareOperations CompareOperation, float CompareValue)
	{
		if (AttrContainer == null)
		{
			return false;
		}
		float floatValue = AttrContainer.GetFloatValue(AttrFloatType);
		float floatValMin = AttrContainer.GetFloatValMin(AttrFloatType);
		float floatValMax = AttrContainer.GetFloatValMax(AttrFloatType);
		float num = (floatValue - floatValMin) / (floatValMax - floatValMin) * 100f;
		bool result = false;
		switch (CompareOperation)
		{
		case EValueCompareOperations.EqualTo:
			result = Math.Abs(floatValue - CompareValue) < 1E-08f;
			break;
		case EValueCompareOperations.NotEqualTo:
			result = Math.Abs(floatValue - CompareValue) > 1E-08f;
			break;
		case EValueCompareOperations.LessThan:
			result = floatValue < CompareValue;
			break;
		case EValueCompareOperations.LessThanOrEqualTo:
			result = floatValue <= CompareValue;
			break;
		case EValueCompareOperations.GreaterThan:
			result = floatValue > CompareValue;
			break;
		case EValueCompareOperations.GreaterThanOrEqualTo:
			result = floatValue >= CompareValue;
			break;
		case EValueCompareOperations.LessThanPercentage:
			result = num < CompareValue;
			break;
		case EValueCompareOperations.LessThanOrEqualToPercentage:
			result = num <= CompareValue;
			break;
		case EValueCompareOperations.GreaterThanPercentage:
			result = num > CompareValue;
			break;
		case EValueCompareOperations.GreaterThanOrEqualToPercentage:
			result = num >= CompareValue;
			break;
		}
		return result;
	}

	private bool OnCheckSimpleState(EBGUSimpleState SimpleState)
	{
		return SimpleStateData.HasSimpleState(SimpleState);
	}

	private bool OnCheckUnitState(EBGUUnitState UnitState)
	{
		return UnitStateData.HasState(UnitState);
	}

	private bool OnCheckBuff(int BuffId)
	{
		return BuffData.HasBuff(BuffId);
	}

	private bool CheckBuffLayer(int BuffID, int BuffLayer, EValueCompareOperationType OperationType)
	{
		int num = 0;
		if (this.BuffData.GetBuffInstData(BuffID, out var BuffData))
		{
			num = BuffData.Layer;
		}
		return OperationType switch
		{
			EValueCompareOperationType.EqualTo => num == BuffLayer, 
			EValueCompareOperationType.NotEqualTo => num != BuffLayer, 
			EValueCompareOperationType.LessThan => num < BuffLayer, 
			EValueCompareOperationType.LessThanOrEqualTo => num <= BuffLayer, 
			EValueCompareOperationType.GreaterThan => num > BuffLayer, 
			EValueCompareOperationType.GreaterThanOrEqualTo => num >= BuffLayer, 
			_ => false, 
		};
	}

	private bool CheckGamePlusCount(int GamePlusCount, EValueCompareOperationType OperationType)
	{
		int num = BGW_GamePlayCountUtil.GetCurGamePlayCount(Owner.Get(), PlayerRoleData);
		if (DebugConfig.DebugGameCount > 0)
		{
			num = DebugConfig.DebugGameCount;
		}
		return OperationType switch
		{
			EValueCompareOperationType.EqualTo => num == GamePlusCount, 
			EValueCompareOperationType.NotEqualTo => num != GamePlusCount, 
			EValueCompareOperationType.LessThan => num < GamePlusCount, 
			EValueCompareOperationType.LessThanOrEqualTo => num <= GamePlusCount, 
			EValueCompareOperationType.GreaterThan => num > GamePlusCount, 
			EValueCompareOperationType.GreaterThanOrEqualTo => num >= GamePlusCount, 
			_ => false, 
		};
	}

	private bool CheckSurfaceType(ESceneItemSurfaceType SurfaceType)
	{
		if (EnvironmentInteractionMgrData != null)
		{
			return EnvironmentInteractionMgrData.ResultSurfaceType == SurfaceType;
		}
		return false;
	}

	private bool CheckHasStoryCanTalkInThisLevelThisArea()
	{
		AActor aActor = Owner.Get();
		if (aActor.IsNullOrDestroyed())
		{
			return false;
		}
		return ((IBGC_PigsyStoryData)BGU_DataUtil.GetGameStateReadonlyData<BGC_PigsyStoryData>(aActor))?.HasStoryCanTalk_CurArea() ?? false;
	}

	private bool CheckStoryInCollingOffPeriod()
	{
		AActor aActor = Owner.Get();
		if (aActor.IsNullOrDestroyed())
		{
			return false;
		}
		return BGU_DataUtil.GetReadOnlyData<b1.IBUC_PigsyStoryData, BUC_PigsyStoryData>(aActor)?.CheckStoryInCollingOffPeriod() ?? false;
	}

	private bool CheckPlayerLeisureOverTime(float LeisureOverTime)
	{
		if (FollowPartnerData == null)
		{
			AActor aActor = Owner.Get();
			if (aActor.IsNullOrDestroyed())
			{
				return false;
			}
			FollowPartnerData = BGU_DataUtil.GetReadOnlyData<IBUC_FollowPartnerData, b1.BUC_FollowPartnerData>(aActor);
		}
		if (FollowPartnerData != null)
		{
			return FollowPartnerData.PlayerBattleLeisureTime >= LeisureOverTime;
		}
		return false;
	}

	private bool OnCheckSkillCoolDown(int SkillId)
	{
		if (Owner.IsValid())
		{
			return BGU_CommonUtil.IsSkillInCoolDown(SkillId, Owner.Get());
		}
		return false;
	}

	private bool OnCheckFsmState(EBGUFSMStateName FsmState)
	{
		return FsmData.IsInFsmState(FsmState);
	}

	private bool OnCheckCustomFsmState(FGameplayTag FsmStateName)
	{
		return FsmData.IsInFsmState(FsmStateName);
	}

	private bool OnCheckLastBeAttackedStiffLevel(EValueCompareOperations CompareOperation, int CompareValue)
	{
		int lastBeAttackedStiffLevel = BeAttackData.GetLastBeAttackedStiffLevel();
		return CompareOperation switch
		{
			EValueCompareOperations.EqualTo => lastBeAttackedStiffLevel == CompareValue, 
			EValueCompareOperations.NotEqualTo => lastBeAttackedStiffLevel != CompareValue, 
			EValueCompareOperations.LessThan => lastBeAttackedStiffLevel < CompareValue, 
			EValueCompareOperations.LessThanOrEqualTo => lastBeAttackedStiffLevel <= CompareValue, 
			EValueCompareOperations.GreaterThan => lastBeAttackedStiffLevel > CompareValue, 
			EValueCompareOperations.GreaterThanOrEqualTo => lastBeAttackedStiffLevel >= CompareValue, 
			_ => false, 
		};
	}

	private bool OnCheckCurrentBeAttackedStiffLevel(EValueCompareOperations CompareOperation, int CompareValue)
	{
		int currentBeAttackedStiffLevel = BeAttackData.GetCurrentBeAttackedStiffLevel();
		return CompareOperation switch
		{
			EValueCompareOperations.EqualTo => currentBeAttackedStiffLevel == CompareValue, 
			EValueCompareOperations.NotEqualTo => currentBeAttackedStiffLevel != CompareValue, 
			EValueCompareOperations.LessThan => currentBeAttackedStiffLevel < CompareValue, 
			EValueCompareOperations.LessThanOrEqualTo => currentBeAttackedStiffLevel <= CompareValue, 
			EValueCompareOperations.GreaterThan => currentBeAttackedStiffLevel > CompareValue, 
			EValueCompareOperations.GreaterThanOrEqualTo => currentBeAttackedStiffLevel >= CompareValue, 
			_ => false, 
		};
	}

	private bool OnCheckDistanceFromTarget(EValueCompareOperations CompareOperations, float CompareValue)
	{
		AActor lockTargetActor = TargetInfoData.GetTargetInfo().LockTargetActor;
		float num = float.MaxValue;
		if (lockTargetActor != null)
		{
			TransformInfoData.GetNextUpdateLocation(out var OutLocation);
			num = (BGUFuncLibActorTransformCS.BGUGetActorLocation(lockTargetActor) - OutLocation).Size2D();
		}
		return CompareOperations switch
		{
			EValueCompareOperations.EqualTo => Math.Abs(num - CompareValue) < 1E-08f, 
			EValueCompareOperations.NotEqualTo => Math.Abs(num - CompareValue) > 1E-08f, 
			EValueCompareOperations.LessThan => num < CompareValue, 
			EValueCompareOperations.LessThanOrEqualTo => num <= CompareValue, 
			EValueCompareOperations.GreaterThan => num > CompareValue, 
			EValueCompareOperations.GreaterThanOrEqualTo => num >= CompareValue, 
			_ => false, 
		};
	}

	private bool OnCheckDistanceFromMaster(EValueCompareOperations CompareOperations, float CompareValue)
	{
		AActor masterActor = MasterData.GetMasterActor();
		float num = float.MaxValue;
		if (masterActor != null)
		{
			TransformInfoData.GetNextUpdateLocation(out var OutLocation);
			num = (BGUFuncLibActorTransformCS.BGUGetActorLocation(masterActor) - OutLocation).Size2D();
		}
		return CompareOperations switch
		{
			EValueCompareOperations.EqualTo => Math.Abs(num - CompareValue) < 1E-08f, 
			EValueCompareOperations.NotEqualTo => Math.Abs(num - CompareValue) > 1E-08f, 
			EValueCompareOperations.LessThan => num < CompareValue, 
			EValueCompareOperations.LessThanOrEqualTo => num <= CompareValue, 
			EValueCompareOperations.GreaterThan => num > CompareValue, 
			EValueCompareOperations.GreaterThanOrEqualTo => num >= CompareValue, 
			_ => false, 
		};
	}

	private bool OnCheckSkillCanCast(int SkillId)
	{
		return BGU_CommonUtil.CheckSkillCanCast(Owner.Get(), SkillId, SkillId) == ECanCastSkillResult.CCSR_OK;
	}

	private bool OnCheckActorYawRotation(ERotationBaseDirection BaseDirection, float MinYawAngle, float MaxYawAngle)
	{
		FVector fVector = FVector.ZeroVector;
		switch (BaseDirection)
		{
		case ERotationBaseDirection.WorldSpaceXAxis:
			fVector = FVector.ForwardVector;
			break;
		case ERotationBaseDirection.LineToTarget:
		{
			AActor lockTargetActor = TargetInfoData.GetTargetInfo().LockTargetActor;
			if (lockTargetActor != null)
			{
				TransformInfoData.GetNextUpdateLocation(out var OutLocation);
				fVector = (BGUFuncLibActorTransformCS.BGUGetActorLocation(lockTargetActor) - OutLocation).GetSafeNormal2D();
			}
			break;
		}
		}
		if (fVector == FVector.ZeroVector)
		{
			return false;
		}
		float yaw = MathLib.NormalizedDeltaRotator(BGUFuncLibActorTransformCS.BGUGetActorRotation(Owner.Get()), fVector.Rotation()).Yaw;
		if (MinYawAngle <= yaw)
		{
			return yaw <= MaxYawAngle;
		}
		return false;
	}

	private bool OnCheckGlobalCastSkillCount(int SkillID, EValueCompareOperations CompareOperations, int CompareValue)
	{
		string finalGuid = GuidData.GetFinalGuid();
		int actorCastSkillCount = GlobalActorData.GetActorCastSkillCount(finalGuid, SkillID);
		return CompareOperations switch
		{
			EValueCompareOperations.EqualTo => actorCastSkillCount == CompareValue, 
			EValueCompareOperations.NotEqualTo => actorCastSkillCount != CompareValue, 
			EValueCompareOperations.LessThan => actorCastSkillCount < CompareValue, 
			EValueCompareOperations.LessThanOrEqualTo => actorCastSkillCount <= CompareValue, 
			EValueCompareOperations.GreaterThan => actorCastSkillCount > CompareValue, 
			EValueCompareOperations.GreaterThanOrEqualTo => actorCastSkillCount >= CompareValue, 
			_ => false, 
		};
	}

	private bool OnCheckAbnormalState(EAbnormalStateType AbnormalStateType)
	{
		return BGUFuncLib_AbnormalState.IsInFinalAbnormalState(Owner.Get(), AbnormalStateType);
	}

	private bool OnCheckDurCastSkill(IList<int> SkillIdList)
	{
		if (SkillInstsData != null)
		{
			foreach (int SkillId in SkillIdList)
			{
				if (SkillInstsData.CurrentCastingSkillID == SkillId)
				{
					return true;
				}
			}
		}
		return false;
	}

	private bool CurSkill_CostDmgNum(EValueCompareOperations CompareOperations, int CompareValue)
	{
		if (SkillInstsData != null)
		{
			int curSkillCostDmgCounter = SkillInstsData.CurSkillCostDmgCounter;
			switch (CompareOperations)
			{
			case EValueCompareOperations.EqualTo:
				return curSkillCostDmgCounter == CompareValue;
			case EValueCompareOperations.NotEqualTo:
				return curSkillCostDmgCounter != CompareValue;
			case EValueCompareOperations.LessThan:
				return curSkillCostDmgCounter < CompareValue;
			case EValueCompareOperations.LessThanOrEqualTo:
				return curSkillCostDmgCounter <= CompareValue;
			case EValueCompareOperations.GreaterThan:
				return curSkillCostDmgCounter > CompareValue;
			case EValueCompareOperations.GreaterThanOrEqualTo:
				return curSkillCostDmgCounter >= CompareValue;
			}
		}
		return false;
	}

	private bool OnSocketUnitsDead(FTamerFamilyMatchChildInfo MatchInfo)
	{
		List<string> list = BGUFunctionLibraryCS.FetchChildActorGuidByMatchInfo(Owner.Get(), MatchInfo);
		if (!list.Any())
		{
			return false;
		}
		foreach (string item in list)
		{
			if (GlobalActorData.GetActorAliveState(item))
			{
				return false;
			}
		}
		return true;
	}

	private bool OnDistanceFromNearestPlayer(EValueCompareOperations CompareOperations, int CompareValue)
	{
		BGUPlayerCharacterCS[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUPlayerCharacterCS>(Owner.Get());
		int num = int.MaxValue;
		BGUPlayerCharacterCS[] array = allActorsOfClass;
		foreach (BGUPlayerCharacterCS obj in array)
		{
			TransformInfoData.GetNextUpdateLocation(out var OutLocation);
			int num2 = (int)FVector.Distance(obj.GetActorLocation(), OutLocation);
			if (num2 < num)
			{
				num = num2;
			}
		}
		return CompareOperations switch
		{
			EValueCompareOperations.EqualTo => num == CompareValue, 
			EValueCompareOperations.NotEqualTo => num != CompareValue, 
			EValueCompareOperations.LessThan => num < CompareValue, 
			EValueCompareOperations.LessThanOrEqualTo => num <= CompareValue, 
			EValueCompareOperations.GreaterThan => num > CompareValue, 
			EValueCompareOperations.GreaterThanOrEqualTo => num >= CompareValue, 
			_ => false, 
		};
	}

	private bool OnSpecifyResIdUnitsDead(int ResId)
	{
		List<string> Guids = new List<string>();
		TamerFamilyTreeData.TravelCircus(Owner.Get(), delegate(CircusMember Node)
		{
			if (Node.ResId == ResId)
			{
				Guids.Add(Node.ActorGuid);
			}
		});
		if (!Guids.Any())
		{
			return false;
		}
		foreach (string item in Guids)
		{
			if (GlobalActorData.GetActorAliveState(item))
			{
				return false;
			}
		}
		return true;
	}

	private bool OnCheckFamilySpecifyUnitAttr(FTamerFamilyMatchChildInfo MatchInfo, EBGUAttrFloat AttrFloatType, EValueCompareOperations CompareOperation, float CompareValue)
	{
		AActor aActor = null;
		List<string> list = BGUFunctionLibraryCS.FetchChildActorGuidByMatchInfo(Owner.Get(), MatchInfo);
		if (list.Count < 1)
		{
			return false;
		}
		aActor = BGU_DataUtil.GetActorByGuid(Owner.Get(), list[0]);
		if (aActor == null)
		{
			return false;
		}
		IBUC_AttrContainer readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(aActor);
		float floatValue = readOnlyData.GetFloatValue(AttrFloatType);
		float floatValMin = readOnlyData.GetFloatValMin(AttrFloatType);
		float floatValMax = readOnlyData.GetFloatValMax(AttrFloatType);
		float num = (floatValue - floatValMin) / (floatValMax - floatValMin) * 100f;
		bool result = false;
		switch (CompareOperation)
		{
		case EValueCompareOperations.EqualTo:
			result = Math.Abs(floatValue - CompareValue) < 1E-08f;
			break;
		case EValueCompareOperations.NotEqualTo:
			result = Math.Abs(floatValue - CompareValue) > 1E-08f;
			break;
		case EValueCompareOperations.LessThan:
			result = floatValue < CompareValue;
			break;
		case EValueCompareOperations.LessThanOrEqualTo:
			result = floatValue <= CompareValue;
			break;
		case EValueCompareOperations.GreaterThan:
			result = floatValue > CompareValue;
			break;
		case EValueCompareOperations.GreaterThanOrEqualTo:
			result = floatValue >= CompareValue;
			break;
		case EValueCompareOperations.LessThanPercentage:
			result = num < CompareValue;
			break;
		case EValueCompareOperations.LessThanOrEqualToPercentage:
			result = num <= CompareValue;
			break;
		case EValueCompareOperations.GreaterThanPercentage:
			result = num > CompareValue;
			break;
		case EValueCompareOperations.GreaterThanOrEqualToPercentage:
			result = num >= CompareValue;
			break;
		}
		return result;
	}

	private bool CheckSuccessRate(float InSuccessRate)
	{
		float num = FMath.FRand();
		if (InSuccessRate.Equals(0f))
		{
			return false;
		}
		if (InSuccessRate.Equals(1f))
		{
			return true;
		}
		return num <= InSuccessRate;
	}

	private bool CheckFamilyUnitAliveNum(FTamerFamilyMatchChildInfo MatchInfo, EValueCompareOperations CompareOperation, int AliveUnitNum)
	{
		int num = 0;
		List<string> list = BGUFunctionLibraryCS.FetchChildActorGuidByMatchInfo(Owner.Get(), MatchInfo);
		if (!list.Any())
		{
			return false;
		}
		foreach (string item in list)
		{
			if (!GlobalActorData.HasActorAliveState(item))
			{
				num++;
			}
			else if (GlobalActorData.GetActorAliveState(item))
			{
				num++;
			}
		}
		bool result = false;
		switch (CompareOperation)
		{
		case EValueCompareOperations.EqualTo:
			result = num == AliveUnitNum;
			break;
		case EValueCompareOperations.NotEqualTo:
			result = num != AliveUnitNum;
			break;
		case EValueCompareOperations.LessThan:
			result = num < AliveUnitNum;
			break;
		case EValueCompareOperations.LessThanOrEqualTo:
			result = num <= AliveUnitNum;
			break;
		case EValueCompareOperations.GreaterThan:
			result = num > AliveUnitNum;
			break;
		case EValueCompareOperations.GreaterThanOrEqualTo:
			result = num >= AliveUnitNum;
			break;
		}
		return result;
	}

	private bool OnCheckTargetInAngleRange(float MinYawAngle, float MaxYawAngle)
	{
		FVector fVector = FVector.ZeroVector;
		AActor lockTargetActor = TargetInfoData.GetTargetInfo().LockTargetActor;
		if (lockTargetActor != null)
		{
			TransformInfoData.GetNextUpdateLocation(out var OutLocation);
			fVector = (BGUFuncLibActorTransformCS.BGUGetActorLocation(lockTargetActor) - OutLocation).GetSafeNormal2D();
		}
		if (fVector == FVector.ZeroVector)
		{
			return false;
		}
		float yaw = MathLib.NormalizedDeltaRotator(fVector.Rotation(), BGUFuncLibActorTransformCS.BGUGetActorRotation(Owner.Get())).Yaw;
		if (MinYawAngle <= yaw)
		{
			return yaw <= MaxYawAngle;
		}
		return false;
	}
}
