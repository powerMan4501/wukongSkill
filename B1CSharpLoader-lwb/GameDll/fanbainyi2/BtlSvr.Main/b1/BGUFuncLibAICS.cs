using System;
using System.Collections.Generic;
using b1.FUnctionLibUtil;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUFuncLibAICS")]
public class BGUFuncLibAICS : UBlueprintFunctionLibrary
{
	private static bool BGUAISideWalk_IsValid;

	private static IntPtr BGUAISideWalk_FunctionAddress;

	private static int BGUAISideWalk_ParamsSize;

	private static bool BGUAISideWalk_Unit_IsValid;

	private static int BGUAISideWalk_Unit_Offset;

	private static bool BGUAISideWalk_MoveForwardValue_IsValid;

	private static int BGUAISideWalk_MoveForwardValue_Offset;

	private static bool BGUAISideWalk_MoveHorizonValue_IsValid;

	private static int BGUAISideWalk_MoveHorizonValue_Offset;

	private static bool BGUAISideWalk_ReturnValue_IsValid;

	private static int BGUAISideWalk_ReturnValue_Offset;

	private static bool BGUCancelAIMoveTo_IsValid;

	private static IntPtr BGUCancelAIMoveTo_FunctionAddress;

	private static int BGUCancelAIMoveTo_ParamsSize;

	private static bool BGUCancelAIMoveTo_Unit_IsValid;

	private static int BGUCancelAIMoveTo_Unit_Offset;

	private static bool BGUCancelAIMoveTo_RequestIdx_IsValid;

	private static int BGUCancelAIMoveTo_RequestIdx_Offset;

	private static bool BGUAISwitchSideWalk_IsValid;

	private static IntPtr BGUAISwitchSideWalk_FunctionAddress;

	private static int BGUAISwitchSideWalk_ParamsSize;

	private static bool BGUAISwitchSideWalk_Unit_IsValid;

	private static int BGUAISwitchSideWalk_Unit_Offset;

	private static bool BGUAISwitchSideWalk_bEnable_IsValid;

	private static int BGUAISwitchSideWalk_bEnable_Offset;

	private static FFieldAddress BGUAISwitchSideWalk_bEnable_PropertyAddress;

	private static bool BGUAITriggerFSMEvent_IsValid;

	private static IntPtr BGUAITriggerFSMEvent_FunctionAddress;

	private static int BGUAITriggerFSMEvent_ParamsSize;

	private static bool BGUAITriggerFSMEvent_Unit_IsValid;

	private static int BGUAITriggerFSMEvent_Unit_Offset;

	private static bool BGUAITriggerFSMEvent_FSMEvent_IsValid;

	private static int BGUAITriggerFSMEvent_FSMEvent_Offset;

	private static FFieldAddress BGUAITriggerFSMEvent_FSMEvent_PropertyAddress;

	private static bool BGUCancelAICurrentMove_IsValid;

	private static IntPtr BGUCancelAICurrentMove_FunctionAddress;

	private static int BGUCancelAICurrentMove_ParamsSize;

	private static bool BGUCancelAICurrentMove_Unit_IsValid;

	private static int BGUCancelAICurrentMove_Unit_Offset;

	private static bool BGUUpdateUnitBattleState_IsValid;

	private static IntPtr BGUUpdateUnitBattleState_FunctionAddress;

	private static int BGUUpdateUnitBattleState_ParamsSize;

	private static bool BGUUpdateUnitBattleState_Unit_IsValid;

	private static int BGUUpdateUnitBattleState_Unit_Offset;

	private static bool BGUUpdateUnitBattleState_IsInBattle_IsValid;

	private static int BGUUpdateUnitBattleState_IsInBattle_Offset;

	private static FFieldAddress BGUUpdateUnitBattleState_IsInBattle_PropertyAddress;

	private static bool BGURequestAIMontageMoveTo_IsValid;

	private static IntPtr BGURequestAIMontageMoveTo_FunctionAddress;

	private static int BGURequestAIMontageMoveTo_ParamsSize;

	private static bool BGURequestAIMontageMoveTo_Unit_IsValid;

	private static int BGURequestAIMontageMoveTo_Unit_Offset;

	private static bool BGURequestAIMontageMoveTo_Montage_IsValid;

	private static int BGURequestAIMontageMoveTo_Montage_Offset;

	private static bool BGURequestAIMontageMoveTo_ScaleRate_IsValid;

	private static int BGURequestAIMontageMoveTo_ScaleRate_Offset;

	private static bool BGURequestAIMontageMoveTo_PlayTimeRate_IsValid;

	private static int BGURequestAIMontageMoveTo_PlayTimeRate_Offset;

	private static bool BGURequestAIMontageMoveTo_PosOffset_IsValid;

	private static int BGURequestAIMontageMoveTo_PosOffset_Offset;

	private static bool BGURequestAIMontageMoveTo_ReturnValue_IsValid;

	private static int BGURequestAIMontageMoveTo_ReturnValue_Offset;

	private static bool BGUAISetUnitTargetAsPlayer_IsValid;

	private static IntPtr BGUAISetUnitTargetAsPlayer_FunctionAddress;

	private static int BGUAISetUnitTargetAsPlayer_ParamsSize;

	private static bool BGUAISetUnitTargetAsPlayer_Unit_IsValid;

	private static int BGUAISetUnitTargetAsPlayer_Unit_Offset;

	private static bool BGURequestAIMoveToLocation_IsValid;

	private static IntPtr BGURequestAIMoveToLocation_FunctionAddress;

	private static int BGURequestAIMoveToLocation_ParamsSize;

	private static bool BGURequestAIMoveToLocation_Unit_IsValid;

	private static int BGURequestAIMoveToLocation_Unit_Offset;

	private static bool BGURequestAIMoveToLocation_Position_IsValid;

	private static int BGURequestAIMoveToLocation_Position_Offset;

	private static FFieldAddress BGURequestAIMoveToLocation_Position_PropertyAddress;

	private static bool BGURequestAIMoveToLocation_SpeedRateType_IsValid;

	private static int BGURequestAIMoveToLocation_SpeedRateType_Offset;

	private static FFieldAddress BGURequestAIMoveToLocation_SpeedRateType_PropertyAddress;

	private static bool BGURequestAIMoveToLocation_AcceptableRadius_IsValid;

	private static int BGURequestAIMoveToLocation_AcceptableRadius_Offset;

	private static bool BGURequestAIMoveToLocation_MoveAIType_IsValid;

	private static int BGURequestAIMoveToLocation_MoveAIType_Offset;

	private static FFieldAddress BGURequestAIMoveToLocation_MoveAIType_PropertyAddress;

	private static bool BGURequestAIMoveToLocation_IncludeSelfRadius_IsValid;

	private static int BGURequestAIMoveToLocation_IncludeSelfRadius_Offset;

	private static FFieldAddress BGURequestAIMoveToLocation_IncludeSelfRadius_PropertyAddress;

	private static bool BGURequestAIMoveToLocation_IncludeTargetRadius_IsValid;

	private static int BGURequestAIMoveToLocation_IncludeTargetRadius_Offset;

	private static FFieldAddress BGURequestAIMoveToLocation_IncludeTargetRadius_PropertyAddress;

	private static bool BGURequestAIMoveToLocation_ReturnValue_IsValid;

	private static int BGURequestAIMoveToLocation_ReturnValue_Offset;

	private static bool BGUAISetUnitsTargetAsPlayer_IsValid;

	private static IntPtr BGUAISetUnitsTargetAsPlayer_FunctionAddress;

	private static int BGUAISetUnitsTargetAsPlayer_ParamsSize;

	private static bool BGUAISetUnitsTargetAsPlayer_WorldContextObject_IsValid;

	private static int BGUAISetUnitsTargetAsPlayer_WorldContextObject_Offset;

	private static bool BGURequestAIUseSkillWithSkillID_IsValid;

	private static IntPtr BGURequestAIUseSkillWithSkillID_FunctionAddress;

	private static int BGURequestAIUseSkillWithSkillID_ParamsSize;

	private static bool BGURequestAIUseSkillWithSkillID_Unit_IsValid;

	private static int BGURequestAIUseSkillWithSkillID_Unit_Offset;

	private static bool BGURequestAIUseSkillWithSkillID_SkillID_IsValid;

	private static int BGURequestAIUseSkillWithSkillID_SkillID_Offset;

	private static bool BGURequestAIUseSkillWithSkillID_SourceType_IsValid;

	private static int BGURequestAIUseSkillWithSkillID_SourceType_Offset;

	private static FFieldAddress BGURequestAIUseSkillWithSkillID_SourceType_PropertyAddress;

	private static bool BGURequestAIUseSkillWithSkillID_ReturnValue_IsValid;

	private static int BGURequestAIUseSkillWithSkillID_ReturnValue_Offset;

	private static bool BGURequestAIMoveToLocationWithMM_IsValid;

	private static IntPtr BGURequestAIMoveToLocationWithMM_FunctionAddress;

	private static int BGURequestAIMoveToLocationWithMM_ParamsSize;

	private static bool BGURequestAIMoveToLocationWithMM_Unit_IsValid;

	private static int BGURequestAIMoveToLocationWithMM_Unit_Offset;

	private static bool BGURequestAIMoveToLocationWithMM_Position_IsValid;

	private static int BGURequestAIMoveToLocationWithMM_Position_Offset;

	private static FFieldAddress BGURequestAIMoveToLocationWithMM_Position_PropertyAddress;

	private static bool BGURequestAIMoveToLocationWithMM_SpeedRateType_IsValid;

	private static int BGURequestAIMoveToLocationWithMM_SpeedRateType_Offset;

	private static FFieldAddress BGURequestAIMoveToLocationWithMM_SpeedRateType_PropertyAddress;

	private static bool BGURequestAIMoveToLocationWithMM_AcceptableRadius_IsValid;

	private static int BGURequestAIMoveToLocationWithMM_AcceptableRadius_Offset;

	private static bool BGURequestAIMoveToLocationWithMM_MoveAIType_IsValid;

	private static int BGURequestAIMoveToLocationWithMM_MoveAIType_Offset;

	private static FFieldAddress BGURequestAIMoveToLocationWithMM_MoveAIType_PropertyAddress;

	private static bool BGURequestAIMoveToLocationWithMM_IncludeSelfRadius_IsValid;

	private static int BGURequestAIMoveToLocationWithMM_IncludeSelfRadius_Offset;

	private static FFieldAddress BGURequestAIMoveToLocationWithMM_IncludeSelfRadius_PropertyAddress;

	private static bool BGURequestAIMoveToLocationWithMM_IncludeTargetRadius_IsValid;

	private static int BGURequestAIMoveToLocationWithMM_IncludeTargetRadius_Offset;

	private static FFieldAddress BGURequestAIMoveToLocationWithMM_IncludeTargetRadius_PropertyAddress;

	private static bool BGURequestAIMoveToLocationWithMM_MotionMatchingState_IsValid;

	private static int BGURequestAIMoveToLocationWithMM_MotionMatchingState_Offset;

	private static FFieldAddress BGURequestAIMoveToLocationWithMM_MotionMatchingState_PropertyAddress;

	private static bool BGURequestAIMoveToLocationWithMM_ReturnValue_IsValid;

	private static int BGURequestAIMoveToLocationWithMM_ReturnValue_Offset;

	private static bool BGURequestAIWallAndCellMoveToLocation_IsValid;

	private static IntPtr BGURequestAIWallAndCellMoveToLocation_FunctionAddress;

	private static int BGURequestAIWallAndCellMoveToLocation_ParamsSize;

	private static bool BGURequestAIWallAndCellMoveToLocation_Unit_IsValid;

	private static int BGURequestAIWallAndCellMoveToLocation_Unit_Offset;

	private static bool BGURequestAIWallAndCellMoveToLocation_Position_IsValid;

	private static int BGURequestAIWallAndCellMoveToLocation_Position_Offset;

	private static FFieldAddress BGURequestAIWallAndCellMoveToLocation_Position_PropertyAddress;

	private static bool BGURequestAIWallAndCellMoveToLocation_SpeedRateType_IsValid;

	private static int BGURequestAIWallAndCellMoveToLocation_SpeedRateType_Offset;

	private static FFieldAddress BGURequestAIWallAndCellMoveToLocation_SpeedRateType_PropertyAddress;

	private static bool BGURequestAIWallAndCellMoveToLocation_TurnSpeed_IsValid;

	private static int BGURequestAIWallAndCellMoveToLocation_TurnSpeed_Offset;

	private static bool BGURequestAIWallAndCellMoveToLocation_AcceptableRadius_IsValid;

	private static int BGURequestAIWallAndCellMoveToLocation_AcceptableRadius_Offset;

	private static bool BGURequestAIWallAndCellMoveToLocation_IncludeSelfRadius_IsValid;

	private static int BGURequestAIWallAndCellMoveToLocation_IncludeSelfRadius_Offset;

	private static FFieldAddress BGURequestAIWallAndCellMoveToLocation_IncludeSelfRadius_PropertyAddress;

	private static bool BGURequestAIWallAndCellMoveToLocation_ReturnValue_IsValid;

	private static int BGURequestAIWallAndCellMoveToLocation_ReturnValue_Offset;

	private static bool BGUAISetUnitsTargetAsPlayerByTamerActorTag_IsValid;

	private static IntPtr BGUAISetUnitsTargetAsPlayerByTamerActorTag_FunctionAddress;

	private static int BGUAISetUnitsTargetAsPlayerByTamerActorTag_ParamsSize;

	private static bool BGUAISetUnitsTargetAsPlayerByTamerActorTag_WorldContextObject_IsValid;

	private static int BGUAISetUnitsTargetAsPlayerByTamerActorTag_WorldContextObject_Offset;

	private static bool BGUAISetUnitsTargetAsPlayerByTamerActorTag_MatchTag_IsValid;

	private static int BGUAISetUnitsTargetAsPlayerByTamerActorTag_MatchTag_Offset;

	[Category("BGU|AI")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAICS:BGURequestAIMoveToLocation")]
	public static int BGURequestAIMoveToLocation(AActor Unit, FVector Position, EAIMoveSpeedType SpeedRateType, float AcceptableRadius, EBGUMoveAIType MoveAIType, bool IncludeSelfRadius, bool IncludeTargetRadius)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Unit))
		{
			return 0;
		}
		if (Unit.IsNullOrDestroyed())
		{
			return 0;
		}
		if (Unit is BUTamerActor bUTamerActor)
		{
			Unit = bUTamerActor.GetMonster();
			if (Unit == null)
			{
				return -1;
			}
		}
		BUC_ActionRequestData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ActionRequestData>(Unit);
		if (unPersistentReadOnlyData == null)
		{
			return 0;
		}
		int lastMoveIdx = unPersistentReadOnlyData.GetLastMoveIdx();
		BUS_EventCollectionCS.Get(Unit).Evt_AIMoveTo.Invoke(Position, null, SpeedRateType, AcceptableRadius, MoveAIType, IncludeSelfRadius, IncludeTargetRadius, "", "");
		int lastMoveIdx2 = unPersistentReadOnlyData.GetLastMoveIdx();
		if (lastMoveIdx2 > 0 && lastMoveIdx2 != lastMoveIdx)
		{
			return lastMoveIdx2;
		}
		return 0;
	}

	[BlueprintCallable]
	[UFunction]
	[Category("BGU|AI")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAICS:BGURequestAIMoveToLocationWithMM")]
	public static int BGURequestAIMoveToLocationWithMM(AActor Unit, FVector Position, EAIMoveSpeedType SpeedRateType, float AcceptableRadius, EBGUMoveAIType MoveAIType, bool IncludeSelfRadius, bool IncludeTargetRadius, EState_MM MotionMatchingState = EState_MM.None)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Unit))
		{
			return 0;
		}
		if (Unit.IsNullOrDestroyed())
		{
			return 0;
		}
		if (Unit is BUTamerActor bUTamerActor)
		{
			Unit = bUTamerActor.GetMonster();
			if (Unit == null)
			{
				return -1;
			}
		}
		BUC_ActionRequestData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ActionRequestData>(Unit);
		if (unPersistentReadOnlyData == null)
		{
			return 0;
		}
		int lastMoveIdx = unPersistentReadOnlyData.GetLastMoveIdx();
		BUS_EventCollectionCS.Get(Unit).Evt_ChangeMotionMatchingState.Invoke(MotionMatchingState);
		BUS_EventCollectionCS.Get(Unit).Evt_AIMoveTo.Invoke(Position, null, SpeedRateType, AcceptableRadius, MoveAIType, IncludeSelfRadius, IncludeTargetRadius, "", "");
		int lastMoveIdx2 = unPersistentReadOnlyData.GetLastMoveIdx();
		if (lastMoveIdx2 > 0 && lastMoveIdx2 != lastMoveIdx)
		{
			return lastMoveIdx2;
		}
		return 0;
	}

	public static int BGURequestAIMoveToTarget(AActor Unit, UnitLockTargetInfo TargetData, EAIMoveSpeedType SpeedRateType, float AcceptableRadius, EBGUMoveAIType MoveAIType, bool IncludeSelfRadius, bool IncludeTargetRadius)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Unit))
		{
			return 0;
		}
		if (Unit.IsNullOrDestroyed() || TargetData == null || TargetData.LockTargetActor == null || TargetData.LockTargetActor.IsNullOrDestroyed())
		{
			return 0;
		}
		if (Unit is BUTamerActor bUTamerActor)
		{
			Unit = bUTamerActor.GetMonster();
			if (Unit == null)
			{
				return -1;
			}
		}
		AActor aActor = TargetData.LockTargetActor;
		if (aActor is BUTamerActor bUTamerActor2)
		{
			aActor = bUTamerActor2.GetMonster();
			if (aActor == null)
			{
				return -1;
			}
		}
		BUC_ActionRequestData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ActionRequestData>(Unit);
		if (unPersistentReadOnlyData == null)
		{
			return 0;
		}
		int lastMoveIdx = unPersistentReadOnlyData.GetLastMoveIdx();
		FVector targetLocation = BGUAIGetTargetInfoRealLockPoint(TargetData);
		BUS_EventCollectionCS.Get(Unit).Evt_AIMoveTo.Invoke(targetLocation, aActor, SpeedRateType, AcceptableRadius, MoveAIType, IncludeSelfRadius, IncludeTargetRadius, TargetData.LockTargetSceneCompName, TargetData.LockTargetSkeletonSocketName);
		int lastMoveIdx2 = unPersistentReadOnlyData.GetLastMoveIdx();
		if (lastMoveIdx2 > 0 && lastMoveIdx2 != lastMoveIdx)
		{
			return lastMoveIdx2;
		}
		return 0;
	}

	public static int BGURequestAIMoveToTarget(AActor Unit, AActor TargetActor, EAIMoveSpeedType SpeedRateType, float AcceptableRadius, EBGUMoveAIType MoveAIType, bool IncludeSelfRadius, bool IncludeTargetRadius)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Unit))
		{
			return 0;
		}
		if (Unit.IsNullOrDestroyed() || TargetActor == null || TargetActor.IsNullOrDestroyed())
		{
			return 0;
		}
		if (Unit is BUTamerActor bUTamerActor)
		{
			Unit = bUTamerActor.GetMonster();
			if (Unit == null)
			{
				return -1;
			}
		}
		if (TargetActor is BUTamerActor bUTamerActor2)
		{
			TargetActor = bUTamerActor2.GetMonster();
			if (TargetActor == null)
			{
				return -1;
			}
		}
		BUC_ActionRequestData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ActionRequestData>(Unit);
		if (unPersistentReadOnlyData == null)
		{
			return 0;
		}
		int lastMoveIdx = unPersistentReadOnlyData.GetLastMoveIdx();
		BUS_EventCollectionCS.Get(Unit).Evt_AIMoveTo.Invoke(BGUFuncLibActorTransformCS.BGUGetActorLocation(TargetActor), TargetActor, SpeedRateType, AcceptableRadius, MoveAIType, IncludeSelfRadius, IncludeTargetRadius, "", "");
		int lastMoveIdx2 = unPersistentReadOnlyData.GetLastMoveIdx();
		if (lastMoveIdx2 > 0 && lastMoveIdx2 != lastMoveIdx)
		{
			return lastMoveIdx2;
		}
		return 0;
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|AI")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAICS:BGURequestAIWallAndCellMoveToLocation")]
	public static int BGURequestAIWallAndCellMoveToLocation(AActor Unit, FVector Position, EAIMoveSpeedType SpeedRateType, float TurnSpeed, float AcceptableRadius, bool IncludeSelfRadius)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Unit))
		{
			return 0;
		}
		if (Unit.IsNullOrDestroyed())
		{
			return 0;
		}
		BUC_ActionRequestData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ActionRequestData>(Unit);
		if (unPersistentReadOnlyData == null)
		{
			return 0;
		}
		int lastMoveIdx = unPersistentReadOnlyData.GetLastMoveIdx();
		BUS_EventCollectionCS.Get(Unit).Evt_AIWallAndCellMoveTo.Invoke(Position, SpeedRateType, TurnSpeed, AcceptableRadius, IncludeSelfRadius);
		int lastMoveIdx2 = unPersistentReadOnlyData.GetLastMoveIdx();
		if (lastMoveIdx2 > 0 && lastMoveIdx2 != lastMoveIdx)
		{
			return lastMoveIdx2;
		}
		return 0;
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|AI")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAICS:BGURequestAIMontageMoveTo")]
	public static int BGURequestAIMontageMoveTo(AActor Unit, UAnimMontage Montage, float ScaleRate, float PlayTimeRate, float PosOffset)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Unit))
		{
			return 0;
		}
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Montage))
		{
			return 0;
		}
		if (!Unit.IsNullOrDestroyed() && !Montage.IsNullOrDestroyed())
		{
			BUC_ActionRequestData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ActionRequestData>(Unit);
			if (unPersistentReadOnlyData == null)
			{
				return 0;
			}
			int lastMoveIdx = unPersistentReadOnlyData.GetLastMoveIdx();
			BGUFuncLibAnim.BGUActorTryPlayMontage(Unit, Montage, FName.None, EMontageBindReason.Default, ScaleRate, PlayTimeRate, PosOffset);
			int lastMoveIdx2 = unPersistentReadOnlyData.GetLastMoveIdx();
			if (lastMoveIdx2 > 0 && lastMoveIdx2 != lastMoveIdx)
			{
				return lastMoveIdx2;
			}
		}
		return 0;
	}

	[Category("BGU|AI")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAICS:BGUCancelAIMoveTo")]
	public static void BGUCancelAIMoveTo(AActor Unit, int RequestIdx)
	{
		if (!b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Unit) && Unit != null)
		{
			BUS_EventCollectionCS.Get(Unit).Evt_MovementStopWithIdx.Invoke(RequestIdx);
		}
	}

	[BlueprintCallable]
	[Category("BGU|AI")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAICS:BGUCancelAICurrentMove")]
	public static void BGUCancelAICurrentMove(AActor Unit)
	{
		if (!b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Unit) && Unit != null)
		{
			BUS_EventCollectionCS.Get(Unit).Evt_StopCurrentMove.Invoke();
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|AI")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAICS:BGUAISwitchSideWalk")]
	public static void BGUAISwitchSideWalk(AActor Unit, bool bEnable)
	{
		if (!b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Unit) && Unit != null)
		{
			BUS_EventCollectionCS.Get(Unit).Evt_MovementSwitchWalkType.Invoke(bEnable);
		}
	}

	[Category("BGU|AI")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAICS:BGUAISideWalk")]
	public static int BGUAISideWalk(AActor Unit, float MoveForwardValue, float MoveHorizonValue)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Unit))
		{
			return 0;
		}
		if (Unit == null)
		{
			return 0;
		}
		BUS_EventCollectionCS.Get(Unit).Evt_AISideWalk.Invoke(MoveForwardValue, MoveHorizonValue);
		return 0;
	}

	[Category("BGU|AI")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAICS:BGURequestAIUseSkillWithSkillID")]
	public static int BGURequestAIUseSkillWithSkillID(AActor Unit, int SkillID, ECastSkillSourceType SourceType)
	{
		return BGURequestAIUseSkillWithSkillID_Internal(Unit, SkillID, SourceType);
	}

	public static int BGURequestAIUseSkillWithSkillID_CSharp(AActor Unit, int SkillID, ECastSkillSourceType SourceType)
	{
		return BGURequestAIUseSkillWithSkillID_Internal(Unit, SkillID, SourceType);
	}

	private static int BGURequestAIUseSkillWithSkillID_Internal(AActor Unit, int SkillID, ECastSkillSourceType SourceType)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Unit))
		{
			return 0;
		}
		if (Unit.IsNullOrDestroyed())
		{
			return 0;
		}
		BUC_ActionRequestData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ActionRequestData>(Unit);
		int lastSkillIdx = unPersistentReadOnlyData.GetLastSkillIdx();
		BUS_EventCollectionCS.Get(Unit).Evt_AICastSkillWithSkillID.Invoke(SkillID, SourceType);
		int lastSkillIdx2 = unPersistentReadOnlyData.GetLastSkillIdx();
		if (lastSkillIdx2 == lastSkillIdx)
		{
			return 0;
		}
		return lastSkillIdx2;
	}

	public static int BGURequestAIUseBestComboSkill(AActor Unit, UnitLockTargetInfo TargetData, List<int> SkillIDList, bool IsFirstSkill, int CurComboSkillNum, int CurComboStage, bool IsGetTopRange, int TopPercent, bool EnableForceComboRelation, bool UseComboCondition, bool UsePursuitAnyWhere, bool NeedCheckSkillCanCast, bool CastFakeComboSkill = false, int LastCastSkillID = -1)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Unit))
		{
			return 0;
		}
		if (Unit.IsNullOrDestroyed())
		{
			return 0;
		}
		if (TargetData == null || TargetData.LockTargetActor == null)
		{
			TargetData = BGUFunctionLibraryCS.BGUGetTargetInfo(Unit);
		}
		BUC_ActionRequestData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ActionRequestData>(Unit);
		int lastSkillIdx = unPersistentReadOnlyData.GetLastSkillIdx();
		BUS_EventCollectionCS.Get(Unit).Evt_AICastBestComboSkill.Invoke(TargetData, SkillIDList, IsFirstSkill, CurComboSkillNum, CurComboStage, IsGetTopRange, TopPercent, EnableForceComboRelation, UseComboCondition, UsePursuitAnyWhere, NeedCheckSkillCanCast, CastFakeComboSkill, LastCastSkillID);
		int lastSkillIdx2 = unPersistentReadOnlyData.GetLastSkillIdx();
		if (lastSkillIdx2 == lastSkillIdx)
		{
			return 0;
		}
		return lastSkillIdx2;
	}

	public static EComboSkillType BGUAIGetComboSkillTypeBySkillID(AActor CastSkillActor, int CurrentCastingSkillID)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(CastSkillActor))
		{
			return EComboSkillType.None;
		}
		if (CastSkillActor == null)
		{
			return EComboSkillType.None;
		}
		if (CurrentCastingSkillID == -1)
		{
			return EComboSkillType.None;
		}
		BUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AIData>(CastSkillActor);
		if (BGU_DataUtil.GetReadOnlyData<BUC_SkillInstsData>(CastSkillActor) == null || unPersistentReadOnlyData == null)
		{
			return EComboSkillType.None;
		}
		FUStSkillAIDesc skillAIDesc = BGW_GameDB.GetSkillAIDesc(CurrentCastingSkillID);
		if (skillAIDesc == null)
		{
			return EComboSkillType.None;
		}
		if (skillAIDesc.NextSkillList.Count <= 0)
		{
			if (BGUAICheckIsInRealComboSkill(CastSkillActor, CurrentCastingSkillID))
			{
				return EComboSkillType.RealComboSkillEnd;
			}
			return EComboSkillType.FakeComboSkill;
		}
		if (BGUAICheckIsInRealComboSkill(CastSkillActor, CurrentCastingSkillID))
		{
			return EComboSkillType.RealComboSkillMiddle;
		}
		return EComboSkillType.RealComboSkillBegin;
	}

	public static void BGUAIFilterComboRelationSkill(AActor CastSkillActor, ref List<int> SkillIDList, int LastCastSkillID)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(CastSkillActor) || CastSkillActor == null)
		{
			return;
		}
		BUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AIData>(CastSkillActor);
		if (BGU_DataUtil.GetReadOnlyData<BUC_SkillInstsData>(CastSkillActor) == null || unPersistentReadOnlyData == null)
		{
			return;
		}
		FUStSkillAIDesc skillAIDesc = BGW_GameDB.GetSkillAIDesc(LastCastSkillID);
		if (skillAIDesc == null)
		{
			return;
		}
		switch (BGUAIGetComboSkillTypeBySkillID(CastSkillActor, LastCastSkillID))
		{
		case EComboSkillType.RealComboSkillEnd:
			SkillIDList.Clear();
			break;
		case EComboSkillType.FakeComboSkill:
		{
			for (int num3 = SkillIDList.Count - 1; num3 >= 0; num3--)
			{
				int num4 = SkillIDList[num3];
				FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(num4, CastSkillActor);
				FUStSkillAIDesc skillAIDesc2 = BGW_GameDB.GetSkillAIDesc(num4);
				if (skillSDesc != null && skillAIDesc2 != null && (BGUAICheckIsInRealComboSkill(CastSkillActor, num4) || skillAIDesc2.NextSkillList.Count > 0))
				{
					SkillIDList.RemoveAt(num3);
				}
			}
			break;
		}
		case EComboSkillType.RealComboSkillMiddle:
		case EComboSkillType.RealComboSkillBegin:
		{
			for (int num = SkillIDList.Count - 1; num >= 0; num--)
			{
				int num2 = SkillIDList[num];
				if (BGW_GameDB.GetSkillSDesc(num2, CastSkillActor) != null && !skillAIDesc.NextSkillList.Contains(num2))
				{
					SkillIDList.RemoveAt(num);
				}
			}
			break;
		}
		}
	}

	public static List<int> BGUGetUnitAllSkillID(AActor Unit)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Unit))
		{
			return new List<int>();
		}
		List<int> list = new List<int>();
		if (Unit == null)
		{
			return list;
		}
		if (Unit is BGUCharacterCS)
		{
			int actorResID = BGU_DataUtil.GetActorResID(Unit);
			int num = 100;
			if (actorResID >= 1 && actorResID <= 100)
			{
				num = 1000;
			}
			int num2 = actorResID * num;
			for (int i = 0; i < num; i++)
			{
				if (BGW_GameDB.GetSkillSDesc(num2 + i, Unit) != null)
				{
					list.Add(num2 + i);
				}
			}
		}
		else if (Unit is BUTamerActor bUTamerActor)
		{
			int resID = bUTamerActor.GetResID();
			int num3 = 100;
			if (resID >= 1 && resID <= 100)
			{
				num3 = 1000;
			}
			int num4 = resID * num3;
			for (int j = 0; j < num3; j++)
			{
				if (BGW_GameDB.GetSkillSDesc(num4 + j, Unit) != null)
				{
					list.Add(num4 + j);
				}
			}
		}
		return list;
	}

	public static bool BGUAICheckIsInRealComboSkill(AActor Unit, int CheckSkillID)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Unit))
		{
			return false;
		}
		if (Unit != null)
		{
			if (BGW_GameDB.GetSkillSDesc(CheckSkillID, Unit) == null)
			{
				return false;
			}
			foreach (int item in BGUGetUnitAllSkillID(Unit))
			{
				FUStSkillAIDesc skillAIDesc = BGW_GameDB.GetSkillAIDesc(item);
				if (skillAIDesc != null && skillAIDesc.NextSkillList.Contains(CheckSkillID))
				{
					return true;
				}
			}
		}
		return false;
	}

	public static string GetAICastComboSkillFailedResultString(ECanCastSkillResult CanCastSkillResult)
	{
		if (CanCastSkillResult <= ECanCastSkillResult.CCSR_MAGIC_STATE)
		{
			if (CanCastSkillResult <= ECanCastSkillResult.CCSR_OTHER)
			{
				if (CanCastSkillResult <= ECanCastSkillResult.CCSR_PRECOOLDOWN)
				{
					ECanCastSkillResult num = CanCastSkillResult - 1;
					if ((ulong)num <= 3uL)
					{
						switch (num)
						{
						case ECanCastSkillResult.CCSR_OK | ECanCastSkillResult.CCSR_NOT_ENOUGH_ATTR:
							return "在CD中";
						case (ECanCastSkillResult)0L:
						case ECanCastSkillResult.CCSR_OK:
						case ECanCastSkillResult.CCSR_NOT_ENOUGH_ATTR:
							goto IL_01aa;
						}
					}
					if (CanCastSkillResult == ECanCastSkillResult.CCSR_PRECOOLDOWN)
					{
						return "在预置CD中";
					}
				}
				else
				{
					switch (CanCastSkillResult)
					{
					}
				}
			}
			else
			{
				switch (CanCastSkillResult)
				{
				case ECanCastSkillResult.CCSR_NOSKILL:
					return "SkillAI或者SkillS表里没有这个技能";
				case ECanCastSkillResult.CCSR_INVALID_CASTER:
					return "非法释放者";
				case ECanCastSkillResult.CCSR_EMPTY_SKILLIST:
					return "传入空的技能列表";
				}
			}
		}
		else
		{
			switch (CanCastSkillResult)
			{
			case ECanCastSkillResult.CCSR_NULL_DATA:
				return "获取BGUData失败";
			case ECanCastSkillResult.CCSR_COMBO_VALIDSKILLID:
				return "错误的SkillID，请检查ResID和SkillID的匹配";
			case ECanCastSkillResult.CCSR_COMBO_PREFERRANGE:
				return "不满足可释放距离";
			case ECanCastSkillResult.CCSR_COMBO_PREFERHEIGHT:
				return "不满足可释放高度";
			case ECanCastSkillResult.CCSR_COMBO_COMBOCONDITION:
				return "连招中已经释放过的技能";
			case ECanCastSkillResult.CCSR_COMBO_ANGLESCORE:
				return "角度分为0";
			}
		}
		goto IL_01aa;
		IL_01aa:
		return CanCastSkillResult.ToString();
	}

	public static bool BGUAICheckIsAllSkillsInCD(AActor CastSkillActor, List<int> SkillIDList)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(CastSkillActor))
		{
			return false;
		}
		bool result = false;
		if (CastSkillActor == null || SkillIDList == null || SkillIDList.Count <= 0)
		{
			return result;
		}
		IBUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AIData, BUC_AIData>(CastSkillActor);
		IBUC_SkillInstsData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>(CastSkillActor);
		if (unPersistentReadOnlyData != null && unPersistentReadOnlyData2 != null)
		{
			int num = 0;
			foreach (int SkillID in SkillIDList)
			{
				if (BGW_GameDB.GetSkillSDesc(SkillID, CastSkillActor) != null && !unPersistentReadOnlyData2.GetSkillCanCastByCDCondition(SkillID))
				{
					num++;
				}
			}
			if (num == SkillIDList.Count)
			{
				result = true;
			}
		}
		return result;
	}

	public static float BGUCalAngleWith2PointAndDir(FVector StartPoint, FRotator MyDirRot, FVector EndPoint)
	{
		FVector x = EndPoint - StartPoint;
		FRotator fRotator = MathLib.MakeRotFromX(x);
		return FMath.FindDeltaAngleDegrees(MyDirRot.Yaw, fRotator.Yaw);
	}

	public static UnitLockTargetInfo BGUAIGetAutoLockTargetInfo(AActor TargetActor, ETargetSourceType SourceType = ETargetSourceType.None, ELockTargetWayType TartgetWayType = ELockTargetWayType.Manual)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(TargetActor))
		{
			return null;
		}
		if (TargetActor == null || TargetActor.IsNullOrDestroyed())
		{
			return null;
		}
		if (TargetActor is BGUSceneItemBase targetActor)
		{
			return new UnitLockTargetInfo(targetActor, SourceType, TartgetWayType);
		}
		if (TargetActor is BUTamerActor bUTamerActor)
		{
			TargetActor = bUTamerActor.GetMonster();
			if (TargetActor == null || TargetActor.IsNullOrDestroyed())
			{
				return null;
			}
		}
		if (TargetActor as BGUCharacterCS == null)
		{
			return null;
		}
		return new UnitLockTargetInfo(TargetActor, SourceType, TartgetWayType);
	}

	public static FVector BGUAIGetTargetInfoRealLockPoint(UnitLockTargetInfo TargetData)
	{
		FVector result = default(FVector);
		if (TargetData.LockTargetActor is BGUSceneItemBase needGetInfoActor)
		{
			return BGUFuncLibActorTransformCS.BGUGetActorLocation(needGetInfoActor);
		}
		BGUCharacterCS bGUCharacterCS = TargetData.LockTargetActor as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			result = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS);
		}
		if (TargetData.LockTargetType == ELockTargetType.Actor && bGUCharacterCS != null)
		{
			return result;
		}
		if (TargetData.LockTargetType == ELockTargetType.SkeletonSocket && bGUCharacterCS != null)
		{
			if (string.IsNullOrEmpty(TargetData.LockTargetSkeletonSocketName))
			{
				return result;
			}
			return bGUCharacterCS.Mesh.GetSocketLocation(new FName(TargetData.LockTargetSkeletonSocketName));
		}
		if (TargetData.LockTargetType == ELockTargetType.SceneComp && bGUCharacterCS != null)
		{
			if (string.IsNullOrEmpty(TargetData.LockTargetSceneCompName))
			{
				return result;
			}
			bool FoundComp;
			return BGU_SelectTargetUtil.GetTargetPositionByTargetInfo(in TargetData, new List<string> { "AutoLockPoint" }, out FoundComp);
		}
		if (TargetData.LockTargetType == ELockTargetType.Point)
		{
			return TargetData.LockPointLocation;
		}
		return result;
	}

	public static void SearchTargetSP(AActor Searcher)
	{
		if (!b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Searcher))
		{
			BUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AIData>(Searcher);
			if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.CanSearchTargetWhenSetTeamID && unPersistentReadOnlyData.UnitAIAttackType != EUnitAIAttackType.PassiveAttack)
			{
				BUS_EventCollectionCS.Get(Searcher)?.Evt_AISearchAndCatchTarget.Invoke(Searcher, (int)unPersistentReadOnlyData.SightRange, 4, 1, EAISearchTargetWay.FindTargetNearest);
			}
		}
	}

	[BlueprintCallable]
	[Category("BGU|AI")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAICS:BGUAITriggerFSMEvent")]
	public static void BGUAITriggerFSMEvent(AActor Unit, EBGUFSMEventName FSMEvent)
	{
		if (!b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Unit) && !(Unit == null))
		{
			BUS_EventCollectionCS.Get(Unit).Evt_FSMEventTrigger.Invoke(FSMEvent);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|AI")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAICS:BGUAISetUnitTargetAsPlayer")]
	public static void BGUAISetUnitTargetAsPlayer(AActor Unit)
	{
		if (!b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Unit) && !(Unit == null))
		{
			ACharacter targetActor = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Unit.World).GetControlledPawn() as ACharacter;
			BUS_EventCollectionCS.Get(Unit).Evt_AICatchTarget.Invoke(targetActor, ETargetSourceType.Target_AssignPlayerAsTarget);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|AI")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAICS:BGUUpdateUnitBattleState")]
	public static void BGUUpdateUnitBattleState(BGUCharacterCS Unit, bool IsInBattle)
	{
		if (!b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Unit))
		{
			BGS_EventCollectionCS.Get(Unit).Evt_BGS_UnitBattleStateUpdate.Invoke(Unit, IsInBattle);
		}
	}

	[Category("BGU|AI")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAICS:BGUAISetUnitsTargetAsPlayer")]
	public static void BGUAISetUnitsTargetAsPlayer(UObject WorldContextObject)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(WorldContextObject) || WorldContextObject == null)
		{
			return;
		}
		List<AActor> allActorsOfClassList = UGameplayStatics.GetAllActorsOfClassList(WorldContextObject, UClass.GetClass<ABGUCharacter>());
		ACharacter aCharacter = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContextObject).GetControlledPawn() as ACharacter;
		if (allActorsOfClassList == null || allActorsOfClassList.Count <= 0 || !(aCharacter != null))
		{
			return;
		}
		foreach (AActor item in allActorsOfClassList)
		{
			AActor aActor = item as ABGUCharacter;
			if (aActor != null)
			{
				IBUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AIData, BUC_AIData>(aActor);
				if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.IsAI)
				{
					BUS_EventCollectionCS.Get(aActor).Evt_AICatchTarget.Invoke(aCharacter, ETargetSourceType.Target_AssignPlayerAsTarget);
				}
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|AI")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibAICS:BGUAISetUnitsTargetAsPlayerByTamerActorTag")]
	public static void BGUAISetUnitsTargetAsPlayerByTamerActorTag(UObject WorldContextObject, FName MatchTag)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(WorldContextObject) || WorldContextObject == null || MatchTag.Equals(FName.None))
		{
			return;
		}
		List<AActor> allActorsOfClassList = UGameplayStatics.GetAllActorsOfClassList(WorldContextObject, UClass.GetClass<ABGUCharacter>());
		ACharacter aCharacter = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContextObject).GetControlledPawn() as ACharacter;
		IBGC_TamerData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_TamerData, BGC_TamerData>(WorldContextObject);
		if (allActorsOfClassList == null || allActorsOfClassList.Count <= 0 || !(aCharacter != null) || gameStateReadonlyData == null)
		{
			return;
		}
		foreach (AActor item in allActorsOfClassList)
		{
			ABGUCharacter aBGUCharacter = item as ABGUCharacter;
			if (!(aBGUCharacter != null))
			{
				continue;
			}
			IBUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AIData, BUC_AIData>(aBGUCharacter);
			IBUC_GuidData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_GuidData, BUC_GuidData>(aBGUCharacter);
			if (unPersistentReadOnlyData != null && readOnlyData != null && unPersistentReadOnlyData.IsAI && gameStateReadonlyData.TryGetTamerEntityRef(readOnlyData.GetFinalGuid(), out var OutTamerRef))
			{
				BUTamerActor value = OutTamerRef.InstancePtr.Value;
				if (value != null && value.Tags.Contains(MatchTag))
				{
					BUS_EventCollectionCS.Get(aBGUCharacter).Evt_AICatchTarget.Invoke(aCharacter, ETargetSourceType.Target_AssignPlayerAsTarget);
				}
			}
		}
	}

	public static bool JudgeActorCanBeAITarget(AActor OwnerActor, AActor TargetActor, IBGC_TeamRelationData TeamRelationData, IBUC_UnitHatredCacheData OwnerActorHatredCacheData, bool bIgnoreTeamRelastion = false)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(TargetActor))
		{
			return false;
		}
		BGUCharacterCS bGUCharacterCS = OwnerActor as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return false;
		}
		if (OwnerActor == TargetActor)
		{
			return false;
		}
		if (!bIgnoreTeamRelastion && TeamRelationData != null && !TeamRelationData.IsEnemyTeam(OwnerActor, TargetActor))
		{
			return false;
		}
		IBUC_UnitStateData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(TargetActor);
		if (unPersistentReadOnlyData == null || unPersistentReadOnlyData.HasState(EBGUUnitState.Dead))
		{
			return false;
		}
		IBUC_SimpleStateData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(TargetActor);
		if (unPersistentReadOnlyData2 == null || unPersistentReadOnlyData2.HasSimpleState(EBGUSimpleState.CantBeBaseTarget))
		{
			return false;
		}
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = OwnerActorHatredCacheData.UnitBattleInfoExtendDesc;
		if (unitBattleInfoExtendDesc != null && unitBattleInfoExtendDesc.CanFindInvisibleUnit == EGSYesNo.No && !BGUFunctionLibraryCS.BGUHasUnitSimpleState(OwnerActor, EBGUSimpleState.Sentry))
		{
			if (unPersistentReadOnlyData2.HasSimpleState(EBGUSimpleState.Imperceptible))
			{
				return false;
			}
			IBUC_PhantomRushData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PhantomRushData, BUC_PhantomRushData>(TargetActor);
			if (readOnlyData != null && readOnlyData.Imperceptible)
			{
				return false;
			}
			if (unPersistentReadOnlyData2.HasSimpleState(EBGUSimpleState.Camouflage))
			{
				bool result = false;
				IBUC_AIData unPersistentReadOnlyData3 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AIData, BUC_AIData>(bGUCharacterCS);
				if (unPersistentReadOnlyData3 != null && FVector.Dist2D(BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerActor), BGUFuncLibActorTransformCS.BGUGetActorLocation(TargetActor)) <= unPersistentReadOnlyData3.StrongPerceptionDistance)
				{
					result = true;
				}
				IBUC_TargetInfoData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(OwnerActor);
				if (readOnlyData2 == null)
				{
					return result;
				}
				UnitLockTargetInfo targetInfo = readOnlyData2.GetTargetInfo();
				if (targetInfo == null || !(targetInfo.LockTargetActor != null))
				{
					return result;
				}
				if (targetInfo.LockTargetActor != TargetActor)
				{
					return result;
				}
			}
		}
		return true;
	}

	public static FVector BGUGetHotZonePointWorldLocation(FVector PlayerLocation, FRotator PlayerRotation, FRotator PlayerCamRot, FVector2D HotZonePointPos)
	{
		PlayerRotation.Yaw = PlayerCamRot.Yaw;
		return PlayerRotation.RotateVector(new FVector(HotZonePointPos.X, HotZonePointPos.Y, 0.0)) + PlayerLocation;
	}

	public static bool BGUCheckCanTriggerForceReturnHome(int ResID, int BattleInfoExtendID, string FinalGuid, IBUC_AIData AIData, in IBUC_GroupAIData GroupAIData, in IBUC_FollowPartnerData FollowPartnerData, in IBGC_GlobalBattleStateData GlobalBattleStateData, in IBGC_TamerData TamerData)
	{
		EFsmSolverType currentFsmSolverType = AIData.GetCurrentFsmSolverType();
		bool flag = false;
		if (!GroupAIData.IsForceDisableGroupAI)
		{
			FUStGroupAISDesc groupAIDesc = BGW_GameDB.GetGroupAIDesc(ResID);
			if (groupAIDesc != null && groupAIDesc.DefaultCanJoinGroupAI == EGSYesNo.Yes)
			{
				flag = GroupAIData.GetIsCtrlByGroupAI() || currentFsmSolverType == EFsmSolverType.GroupAi;
			}
		}
		bool flag2 = false;
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(BattleInfoExtendID);
		if (unitBattleInfoExtendDesc != null)
		{
			flag2 = (int)unitBattleInfoExtendDesc.QualityType <= 3 && unitBattleInfoExtendDesc.VigourDropId <= 0;
		}
		bool flag3 = false;
		if (TamerData.GetTamerType(FinalGuid, out var OutTamerType))
		{
			flag3 = OutTamerType == ETamerType.Spawned || OutTamerType == ETamerType.Summoned;
		}
		bool flag4 = FollowPartnerData.IsAssociationUnit || FollowPartnerData.IsFollowPartnerUnit;
		bool flag5 = GlobalBattleStateData.IsBossRoomMonster(FinalGuid);
		return !flag && !flag3 && !flag4 && !flag5 && flag2;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAICS:BGUAISideWalk")]
	private static void BGUAISideWalk__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUAISideWalk_Unit_Offset));
		float moveForwardValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUAISideWalk_MoveForwardValue_Offset));
		float moveHorizonValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUAISideWalk_MoveHorizonValue_Offset));
		int value = BGUAISideWalk(unit, moveForwardValue, moveHorizonValue);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, BGUAISideWalk_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAICS:BGUCancelAIMoveTo")]
	private static void BGUCancelAIMoveTo__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUCancelAIMoveTo_Unit_Offset));
		int requestIdx = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, BGUCancelAIMoveTo_RequestIdx_Offset));
		BGUCancelAIMoveTo(unit, requestIdx);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAICS:BGUAISwitchSideWalk")]
	private static void BGUAISwitchSideWalk__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUAISwitchSideWalk_Unit_Offset));
		bool bEnable = BoolMarshaler.FromNative(IntPtr.Add(buffer, BGUAISwitchSideWalk_bEnable_Offset), 0, BGUAISwitchSideWalk_bEnable_PropertyAddress.Address);
		BGUAISwitchSideWalk(unit, bEnable);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAICS:BGUAITriggerFSMEvent")]
	private static void BGUAITriggerFSMEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUAITriggerFSMEvent_Unit_Offset));
		EBGUFSMEventName fSMEvent = EnumMarshaler<EBGUFSMEventName>.FromNative(IntPtr.Add(buffer, BGUAITriggerFSMEvent_FSMEvent_Offset), 0, BGUAITriggerFSMEvent_FSMEvent_PropertyAddress.Address);
		BGUAITriggerFSMEvent(unit, fSMEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAICS:BGUCancelAICurrentMove")]
	private static void BGUCancelAICurrentMove__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUCancelAICurrentMove_Unit_Offset));
		BGUCancelAICurrentMove(unit);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAICS:BGUUpdateUnitBattleState")]
	private static void BGUUpdateUnitBattleState__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUCharacterCS unit = UObjectMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(buffer, BGUUpdateUnitBattleState_Unit_Offset));
		bool isInBattle = BoolMarshaler.FromNative(IntPtr.Add(buffer, BGUUpdateUnitBattleState_IsInBattle_Offset), 0, BGUUpdateUnitBattleState_IsInBattle_PropertyAddress.Address);
		BGUUpdateUnitBattleState(unit, isInBattle);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAICS:BGURequestAIMontageMoveTo")]
	private static void BGURequestAIMontageMoveTo__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGURequestAIMontageMoveTo_Unit_Offset));
		UAnimMontage montage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(buffer, BGURequestAIMontageMoveTo_Montage_Offset));
		float scaleRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGURequestAIMontageMoveTo_ScaleRate_Offset));
		float playTimeRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGURequestAIMontageMoveTo_PlayTimeRate_Offset));
		float posOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGURequestAIMontageMoveTo_PosOffset_Offset));
		int value = BGURequestAIMontageMoveTo(unit, montage, scaleRate, playTimeRate, posOffset);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, BGURequestAIMontageMoveTo_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAICS:BGUAISetUnitTargetAsPlayer")]
	private static void BGUAISetUnitTargetAsPlayer__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUAISetUnitTargetAsPlayer_Unit_Offset));
		BGUAISetUnitTargetAsPlayer(unit);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAICS:BGURequestAIMoveToLocation")]
	private static void BGURequestAIMoveToLocation__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGURequestAIMoveToLocation_Unit_Offset));
		FVector position = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, BGURequestAIMoveToLocation_Position_Offset));
		EAIMoveSpeedType speedRateType = EnumMarshaler<EAIMoveSpeedType>.FromNative(IntPtr.Add(buffer, BGURequestAIMoveToLocation_SpeedRateType_Offset), 0, BGURequestAIMoveToLocation_SpeedRateType_PropertyAddress.Address);
		float acceptableRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGURequestAIMoveToLocation_AcceptableRadius_Offset));
		EBGUMoveAIType moveAIType = EnumMarshaler<EBGUMoveAIType>.FromNative(IntPtr.Add(buffer, BGURequestAIMoveToLocation_MoveAIType_Offset), 0, BGURequestAIMoveToLocation_MoveAIType_PropertyAddress.Address);
		bool includeSelfRadius = BoolMarshaler.FromNative(IntPtr.Add(buffer, BGURequestAIMoveToLocation_IncludeSelfRadius_Offset), 0, BGURequestAIMoveToLocation_IncludeSelfRadius_PropertyAddress.Address);
		bool includeTargetRadius = BoolMarshaler.FromNative(IntPtr.Add(buffer, BGURequestAIMoveToLocation_IncludeTargetRadius_Offset), 0, BGURequestAIMoveToLocation_IncludeTargetRadius_PropertyAddress.Address);
		int value = BGURequestAIMoveToLocation(unit, position, speedRateType, acceptableRadius, moveAIType, includeSelfRadius, includeTargetRadius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, BGURequestAIMoveToLocation_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAICS:BGUAISetUnitsTargetAsPlayer")]
	private static void BGUAISetUnitsTargetAsPlayer__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContextObject = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, BGUAISetUnitsTargetAsPlayer_WorldContextObject_Offset));
		BGUAISetUnitsTargetAsPlayer(worldContextObject);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAICS:BGURequestAIUseSkillWithSkillID")]
	private static void BGURequestAIUseSkillWithSkillID__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGURequestAIUseSkillWithSkillID_Unit_Offset));
		int skillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, BGURequestAIUseSkillWithSkillID_SkillID_Offset));
		ECastSkillSourceType sourceType = EnumMarshaler<ECastSkillSourceType>.FromNative(IntPtr.Add(buffer, BGURequestAIUseSkillWithSkillID_SourceType_Offset), 0, BGURequestAIUseSkillWithSkillID_SourceType_PropertyAddress.Address);
		int value = BGURequestAIUseSkillWithSkillID(unit, skillID, sourceType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, BGURequestAIUseSkillWithSkillID_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAICS:BGURequestAIMoveToLocationWithMM")]
	private static void BGURequestAIMoveToLocationWithMM__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGURequestAIMoveToLocationWithMM_Unit_Offset));
		FVector position = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, BGURequestAIMoveToLocationWithMM_Position_Offset));
		EAIMoveSpeedType speedRateType = EnumMarshaler<EAIMoveSpeedType>.FromNative(IntPtr.Add(buffer, BGURequestAIMoveToLocationWithMM_SpeedRateType_Offset), 0, BGURequestAIMoveToLocationWithMM_SpeedRateType_PropertyAddress.Address);
		float acceptableRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGURequestAIMoveToLocationWithMM_AcceptableRadius_Offset));
		EBGUMoveAIType moveAIType = EnumMarshaler<EBGUMoveAIType>.FromNative(IntPtr.Add(buffer, BGURequestAIMoveToLocationWithMM_MoveAIType_Offset), 0, BGURequestAIMoveToLocationWithMM_MoveAIType_PropertyAddress.Address);
		bool includeSelfRadius = BoolMarshaler.FromNative(IntPtr.Add(buffer, BGURequestAIMoveToLocationWithMM_IncludeSelfRadius_Offset), 0, BGURequestAIMoveToLocationWithMM_IncludeSelfRadius_PropertyAddress.Address);
		bool includeTargetRadius = BoolMarshaler.FromNative(IntPtr.Add(buffer, BGURequestAIMoveToLocationWithMM_IncludeTargetRadius_Offset), 0, BGURequestAIMoveToLocationWithMM_IncludeTargetRadius_PropertyAddress.Address);
		EState_MM motionMatchingState = EnumMarshaler<EState_MM>.FromNative(IntPtr.Add(buffer, BGURequestAIMoveToLocationWithMM_MotionMatchingState_Offset), 0, BGURequestAIMoveToLocationWithMM_MotionMatchingState_PropertyAddress.Address);
		int value = BGURequestAIMoveToLocationWithMM(unit, position, speedRateType, acceptableRadius, moveAIType, includeSelfRadius, includeTargetRadius, motionMatchingState);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, BGURequestAIMoveToLocationWithMM_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAICS:BGURequestAIWallAndCellMoveToLocation")]
	private static void BGURequestAIWallAndCellMoveToLocation__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGURequestAIWallAndCellMoveToLocation_Unit_Offset));
		FVector position = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, BGURequestAIWallAndCellMoveToLocation_Position_Offset));
		EAIMoveSpeedType speedRateType = EnumMarshaler<EAIMoveSpeedType>.FromNative(IntPtr.Add(buffer, BGURequestAIWallAndCellMoveToLocation_SpeedRateType_Offset), 0, BGURequestAIWallAndCellMoveToLocation_SpeedRateType_PropertyAddress.Address);
		float turnSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGURequestAIWallAndCellMoveToLocation_TurnSpeed_Offset));
		float acceptableRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGURequestAIWallAndCellMoveToLocation_AcceptableRadius_Offset));
		bool includeSelfRadius = BoolMarshaler.FromNative(IntPtr.Add(buffer, BGURequestAIWallAndCellMoveToLocation_IncludeSelfRadius_Offset), 0, BGURequestAIWallAndCellMoveToLocation_IncludeSelfRadius_PropertyAddress.Address);
		int value = BGURequestAIWallAndCellMoveToLocation(unit, position, speedRateType, turnSpeed, acceptableRadius, includeSelfRadius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, BGURequestAIWallAndCellMoveToLocation_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibAICS:BGUAISetUnitsTargetAsPlayerByTamerActorTag")]
	private static void BGUAISetUnitsTargetAsPlayerByTamerActorTag__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContextObject = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, BGUAISetUnitsTargetAsPlayerByTamerActorTag_WorldContextObject_Offset));
		FName matchTag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, BGUAISetUnitsTargetAsPlayerByTamerActorTag_MatchTag_Offset));
		BGUAISetUnitsTargetAsPlayerByTamerActorTag(worldContextObject, matchTag);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGUFuncLibAICS");
		BGUAISideWalk_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUAISideWalk");
		BGUAISideWalk_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUAISideWalk_FunctionAddress);
		BGUAISideWalk_Unit_Offset = NativeReflection.GetPropertyOffset(BGUAISideWalk_FunctionAddress, "Unit");
		BGUAISideWalk_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUAISideWalk_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGUAISideWalk_MoveForwardValue_Offset = NativeReflection.GetPropertyOffset(BGUAISideWalk_FunctionAddress, "MoveForwardValue");
		BGUAISideWalk_MoveForwardValue_IsValid = NativeReflection.ValidatePropertyClass(BGUAISideWalk_FunctionAddress, "MoveForwardValue", Classes.FFloatProperty);
		BGUAISideWalk_MoveHorizonValue_Offset = NativeReflection.GetPropertyOffset(BGUAISideWalk_FunctionAddress, "MoveHorizonValue");
		BGUAISideWalk_MoveHorizonValue_IsValid = NativeReflection.ValidatePropertyClass(BGUAISideWalk_FunctionAddress, "MoveHorizonValue", Classes.FFloatProperty);
		BGUAISideWalk_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUAISideWalk_FunctionAddress, "ReturnValue");
		BGUAISideWalk_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUAISideWalk_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BGUAISideWalk_IsValid = BGUAISideWalk_FunctionAddress != IntPtr.Zero && BGUAISideWalk_Unit_IsValid && BGUAISideWalk_MoveForwardValue_IsValid && BGUAISideWalk_MoveHorizonValue_IsValid && BGUAISideWalk_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAICS:BGUAISideWalk", BGUAISideWalk_IsValid);
		BGUCancelAIMoveTo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUCancelAIMoveTo");
		BGUCancelAIMoveTo_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUCancelAIMoveTo_FunctionAddress);
		BGUCancelAIMoveTo_Unit_Offset = NativeReflection.GetPropertyOffset(BGUCancelAIMoveTo_FunctionAddress, "Unit");
		BGUCancelAIMoveTo_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUCancelAIMoveTo_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGUCancelAIMoveTo_RequestIdx_Offset = NativeReflection.GetPropertyOffset(BGUCancelAIMoveTo_FunctionAddress, "RequestIdx");
		BGUCancelAIMoveTo_RequestIdx_IsValid = NativeReflection.ValidatePropertyClass(BGUCancelAIMoveTo_FunctionAddress, "RequestIdx", Classes.FIntProperty);
		BGUCancelAIMoveTo_IsValid = BGUCancelAIMoveTo_FunctionAddress != IntPtr.Zero && BGUCancelAIMoveTo_Unit_IsValid && BGUCancelAIMoveTo_RequestIdx_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAICS:BGUCancelAIMoveTo", BGUCancelAIMoveTo_IsValid);
		BGUAISwitchSideWalk_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUAISwitchSideWalk");
		BGUAISwitchSideWalk_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUAISwitchSideWalk_FunctionAddress);
		BGUAISwitchSideWalk_Unit_Offset = NativeReflection.GetPropertyOffset(BGUAISwitchSideWalk_FunctionAddress, "Unit");
		BGUAISwitchSideWalk_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUAISwitchSideWalk_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUAISwitchSideWalk_bEnable_PropertyAddress, BGUAISwitchSideWalk_FunctionAddress, "bEnable");
		BGUAISwitchSideWalk_bEnable_Offset = NativeReflection.GetPropertyOffset(BGUAISwitchSideWalk_FunctionAddress, "bEnable");
		BGUAISwitchSideWalk_bEnable_IsValid = NativeReflection.ValidatePropertyClass(BGUAISwitchSideWalk_FunctionAddress, "bEnable", Classes.FBoolProperty);
		BGUAISwitchSideWalk_IsValid = BGUAISwitchSideWalk_FunctionAddress != IntPtr.Zero && BGUAISwitchSideWalk_Unit_IsValid && BGUAISwitchSideWalk_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAICS:BGUAISwitchSideWalk", BGUAISwitchSideWalk_IsValid);
		BGUAITriggerFSMEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUAITriggerFSMEvent");
		BGUAITriggerFSMEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUAITriggerFSMEvent_FunctionAddress);
		BGUAITriggerFSMEvent_Unit_Offset = NativeReflection.GetPropertyOffset(BGUAITriggerFSMEvent_FunctionAddress, "Unit");
		BGUAITriggerFSMEvent_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUAITriggerFSMEvent_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUAITriggerFSMEvent_FSMEvent_PropertyAddress, BGUAITriggerFSMEvent_FunctionAddress, "FSMEvent");
		BGUAITriggerFSMEvent_FSMEvent_Offset = NativeReflection.GetPropertyOffset(BGUAITriggerFSMEvent_FunctionAddress, "FSMEvent");
		BGUAITriggerFSMEvent_FSMEvent_IsValid = NativeReflection.ValidatePropertyClass(BGUAITriggerFSMEvent_FunctionAddress, "FSMEvent", Classes.FEnumProperty);
		BGUAITriggerFSMEvent_IsValid = BGUAITriggerFSMEvent_FunctionAddress != IntPtr.Zero && BGUAITriggerFSMEvent_Unit_IsValid && BGUAITriggerFSMEvent_FSMEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAICS:BGUAITriggerFSMEvent", BGUAITriggerFSMEvent_IsValid);
		BGUCancelAICurrentMove_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUCancelAICurrentMove");
		BGUCancelAICurrentMove_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUCancelAICurrentMove_FunctionAddress);
		BGUCancelAICurrentMove_Unit_Offset = NativeReflection.GetPropertyOffset(BGUCancelAICurrentMove_FunctionAddress, "Unit");
		BGUCancelAICurrentMove_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUCancelAICurrentMove_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGUCancelAICurrentMove_IsValid = BGUCancelAICurrentMove_FunctionAddress != IntPtr.Zero && BGUCancelAICurrentMove_Unit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAICS:BGUCancelAICurrentMove", BGUCancelAICurrentMove_IsValid);
		BGUUpdateUnitBattleState_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUUpdateUnitBattleState");
		BGUUpdateUnitBattleState_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUUpdateUnitBattleState_FunctionAddress);
		BGUUpdateUnitBattleState_Unit_Offset = NativeReflection.GetPropertyOffset(BGUUpdateUnitBattleState_FunctionAddress, "Unit");
		BGUUpdateUnitBattleState_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUUpdateUnitBattleState_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUUpdateUnitBattleState_IsInBattle_PropertyAddress, BGUUpdateUnitBattleState_FunctionAddress, "IsInBattle");
		BGUUpdateUnitBattleState_IsInBattle_Offset = NativeReflection.GetPropertyOffset(BGUUpdateUnitBattleState_FunctionAddress, "IsInBattle");
		BGUUpdateUnitBattleState_IsInBattle_IsValid = NativeReflection.ValidatePropertyClass(BGUUpdateUnitBattleState_FunctionAddress, "IsInBattle", Classes.FBoolProperty);
		BGUUpdateUnitBattleState_IsValid = BGUUpdateUnitBattleState_FunctionAddress != IntPtr.Zero && BGUUpdateUnitBattleState_Unit_IsValid && BGUUpdateUnitBattleState_IsInBattle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAICS:BGUUpdateUnitBattleState", BGUUpdateUnitBattleState_IsValid);
		BGURequestAIMontageMoveTo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGURequestAIMontageMoveTo");
		BGURequestAIMontageMoveTo_ParamsSize = NativeReflection.GetFunctionParamsSize(BGURequestAIMontageMoveTo_FunctionAddress);
		BGURequestAIMontageMoveTo_Unit_Offset = NativeReflection.GetPropertyOffset(BGURequestAIMontageMoveTo_FunctionAddress, "Unit");
		BGURequestAIMontageMoveTo_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIMontageMoveTo_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGURequestAIMontageMoveTo_Montage_Offset = NativeReflection.GetPropertyOffset(BGURequestAIMontageMoveTo_FunctionAddress, "Montage");
		BGURequestAIMontageMoveTo_Montage_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIMontageMoveTo_FunctionAddress, "Montage", Classes.FObjectProperty);
		BGURequestAIMontageMoveTo_ScaleRate_Offset = NativeReflection.GetPropertyOffset(BGURequestAIMontageMoveTo_FunctionAddress, "ScaleRate");
		BGURequestAIMontageMoveTo_ScaleRate_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIMontageMoveTo_FunctionAddress, "ScaleRate", Classes.FFloatProperty);
		BGURequestAIMontageMoveTo_PlayTimeRate_Offset = NativeReflection.GetPropertyOffset(BGURequestAIMontageMoveTo_FunctionAddress, "PlayTimeRate");
		BGURequestAIMontageMoveTo_PlayTimeRate_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIMontageMoveTo_FunctionAddress, "PlayTimeRate", Classes.FFloatProperty);
		BGURequestAIMontageMoveTo_PosOffset_Offset = NativeReflection.GetPropertyOffset(BGURequestAIMontageMoveTo_FunctionAddress, "PosOffset");
		BGURequestAIMontageMoveTo_PosOffset_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIMontageMoveTo_FunctionAddress, "PosOffset", Classes.FFloatProperty);
		BGURequestAIMontageMoveTo_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGURequestAIMontageMoveTo_FunctionAddress, "ReturnValue");
		BGURequestAIMontageMoveTo_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIMontageMoveTo_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BGURequestAIMontageMoveTo_IsValid = BGURequestAIMontageMoveTo_FunctionAddress != IntPtr.Zero && BGURequestAIMontageMoveTo_Unit_IsValid && BGURequestAIMontageMoveTo_Montage_IsValid && BGURequestAIMontageMoveTo_ScaleRate_IsValid && BGURequestAIMontageMoveTo_PlayTimeRate_IsValid && BGURequestAIMontageMoveTo_PosOffset_IsValid && BGURequestAIMontageMoveTo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAICS:BGURequestAIMontageMoveTo", BGURequestAIMontageMoveTo_IsValid);
		BGUAISetUnitTargetAsPlayer_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUAISetUnitTargetAsPlayer");
		BGUAISetUnitTargetAsPlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUAISetUnitTargetAsPlayer_FunctionAddress);
		BGUAISetUnitTargetAsPlayer_Unit_Offset = NativeReflection.GetPropertyOffset(BGUAISetUnitTargetAsPlayer_FunctionAddress, "Unit");
		BGUAISetUnitTargetAsPlayer_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUAISetUnitTargetAsPlayer_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGUAISetUnitTargetAsPlayer_IsValid = BGUAISetUnitTargetAsPlayer_FunctionAddress != IntPtr.Zero && BGUAISetUnitTargetAsPlayer_Unit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAICS:BGUAISetUnitTargetAsPlayer", BGUAISetUnitTargetAsPlayer_IsValid);
		BGURequestAIMoveToLocation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGURequestAIMoveToLocation");
		BGURequestAIMoveToLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(BGURequestAIMoveToLocation_FunctionAddress);
		BGURequestAIMoveToLocation_Unit_Offset = NativeReflection.GetPropertyOffset(BGURequestAIMoveToLocation_FunctionAddress, "Unit");
		BGURequestAIMoveToLocation_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIMoveToLocation_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGURequestAIMoveToLocation_Position_PropertyAddress, BGURequestAIMoveToLocation_FunctionAddress, "Position");
		BGURequestAIMoveToLocation_Position_Offset = NativeReflection.GetPropertyOffset(BGURequestAIMoveToLocation_FunctionAddress, "Position");
		BGURequestAIMoveToLocation_Position_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIMoveToLocation_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref BGURequestAIMoveToLocation_SpeedRateType_PropertyAddress, BGURequestAIMoveToLocation_FunctionAddress, "SpeedRateType");
		BGURequestAIMoveToLocation_SpeedRateType_Offset = NativeReflection.GetPropertyOffset(BGURequestAIMoveToLocation_FunctionAddress, "SpeedRateType");
		BGURequestAIMoveToLocation_SpeedRateType_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIMoveToLocation_FunctionAddress, "SpeedRateType", Classes.FEnumProperty);
		BGURequestAIMoveToLocation_AcceptableRadius_Offset = NativeReflection.GetPropertyOffset(BGURequestAIMoveToLocation_FunctionAddress, "AcceptableRadius");
		BGURequestAIMoveToLocation_AcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIMoveToLocation_FunctionAddress, "AcceptableRadius", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref BGURequestAIMoveToLocation_MoveAIType_PropertyAddress, BGURequestAIMoveToLocation_FunctionAddress, "MoveAIType");
		BGURequestAIMoveToLocation_MoveAIType_Offset = NativeReflection.GetPropertyOffset(BGURequestAIMoveToLocation_FunctionAddress, "MoveAIType");
		BGURequestAIMoveToLocation_MoveAIType_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIMoveToLocation_FunctionAddress, "MoveAIType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref BGURequestAIMoveToLocation_IncludeSelfRadius_PropertyAddress, BGURequestAIMoveToLocation_FunctionAddress, "IncludeSelfRadius");
		BGURequestAIMoveToLocation_IncludeSelfRadius_Offset = NativeReflection.GetPropertyOffset(BGURequestAIMoveToLocation_FunctionAddress, "IncludeSelfRadius");
		BGURequestAIMoveToLocation_IncludeSelfRadius_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIMoveToLocation_FunctionAddress, "IncludeSelfRadius", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref BGURequestAIMoveToLocation_IncludeTargetRadius_PropertyAddress, BGURequestAIMoveToLocation_FunctionAddress, "IncludeTargetRadius");
		BGURequestAIMoveToLocation_IncludeTargetRadius_Offset = NativeReflection.GetPropertyOffset(BGURequestAIMoveToLocation_FunctionAddress, "IncludeTargetRadius");
		BGURequestAIMoveToLocation_IncludeTargetRadius_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIMoveToLocation_FunctionAddress, "IncludeTargetRadius", Classes.FBoolProperty);
		BGURequestAIMoveToLocation_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGURequestAIMoveToLocation_FunctionAddress, "ReturnValue");
		BGURequestAIMoveToLocation_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIMoveToLocation_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BGURequestAIMoveToLocation_IsValid = BGURequestAIMoveToLocation_FunctionAddress != IntPtr.Zero && BGURequestAIMoveToLocation_Unit_IsValid && BGURequestAIMoveToLocation_Position_IsValid && BGURequestAIMoveToLocation_SpeedRateType_IsValid && BGURequestAIMoveToLocation_AcceptableRadius_IsValid && BGURequestAIMoveToLocation_MoveAIType_IsValid && BGURequestAIMoveToLocation_IncludeSelfRadius_IsValid && BGURequestAIMoveToLocation_IncludeTargetRadius_IsValid && BGURequestAIMoveToLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAICS:BGURequestAIMoveToLocation", BGURequestAIMoveToLocation_IsValid);
		BGUAISetUnitsTargetAsPlayer_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUAISetUnitsTargetAsPlayer");
		BGUAISetUnitsTargetAsPlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUAISetUnitsTargetAsPlayer_FunctionAddress);
		BGUAISetUnitsTargetAsPlayer_WorldContextObject_Offset = NativeReflection.GetPropertyOffset(BGUAISetUnitsTargetAsPlayer_FunctionAddress, "WorldContextObject");
		BGUAISetUnitsTargetAsPlayer_WorldContextObject_IsValid = NativeReflection.ValidatePropertyClass(BGUAISetUnitsTargetAsPlayer_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		BGUAISetUnitsTargetAsPlayer_IsValid = BGUAISetUnitsTargetAsPlayer_FunctionAddress != IntPtr.Zero && BGUAISetUnitsTargetAsPlayer_WorldContextObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAICS:BGUAISetUnitsTargetAsPlayer", BGUAISetUnitsTargetAsPlayer_IsValid);
		BGURequestAIUseSkillWithSkillID_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGURequestAIUseSkillWithSkillID");
		BGURequestAIUseSkillWithSkillID_ParamsSize = NativeReflection.GetFunctionParamsSize(BGURequestAIUseSkillWithSkillID_FunctionAddress);
		BGURequestAIUseSkillWithSkillID_Unit_Offset = NativeReflection.GetPropertyOffset(BGURequestAIUseSkillWithSkillID_FunctionAddress, "Unit");
		BGURequestAIUseSkillWithSkillID_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIUseSkillWithSkillID_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGURequestAIUseSkillWithSkillID_SkillID_Offset = NativeReflection.GetPropertyOffset(BGURequestAIUseSkillWithSkillID_FunctionAddress, "SkillID");
		BGURequestAIUseSkillWithSkillID_SkillID_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIUseSkillWithSkillID_FunctionAddress, "SkillID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref BGURequestAIUseSkillWithSkillID_SourceType_PropertyAddress, BGURequestAIUseSkillWithSkillID_FunctionAddress, "SourceType");
		BGURequestAIUseSkillWithSkillID_SourceType_Offset = NativeReflection.GetPropertyOffset(BGURequestAIUseSkillWithSkillID_FunctionAddress, "SourceType");
		BGURequestAIUseSkillWithSkillID_SourceType_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIUseSkillWithSkillID_FunctionAddress, "SourceType", Classes.FEnumProperty);
		BGURequestAIUseSkillWithSkillID_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGURequestAIUseSkillWithSkillID_FunctionAddress, "ReturnValue");
		BGURequestAIUseSkillWithSkillID_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIUseSkillWithSkillID_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BGURequestAIUseSkillWithSkillID_IsValid = BGURequestAIUseSkillWithSkillID_FunctionAddress != IntPtr.Zero && BGURequestAIUseSkillWithSkillID_Unit_IsValid && BGURequestAIUseSkillWithSkillID_SkillID_IsValid && BGURequestAIUseSkillWithSkillID_SourceType_IsValid && BGURequestAIUseSkillWithSkillID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAICS:BGURequestAIUseSkillWithSkillID", BGURequestAIUseSkillWithSkillID_IsValid);
		BGURequestAIMoveToLocationWithMM_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGURequestAIMoveToLocationWithMM");
		BGURequestAIMoveToLocationWithMM_ParamsSize = NativeReflection.GetFunctionParamsSize(BGURequestAIMoveToLocationWithMM_FunctionAddress);
		BGURequestAIMoveToLocationWithMM_Unit_Offset = NativeReflection.GetPropertyOffset(BGURequestAIMoveToLocationWithMM_FunctionAddress, "Unit");
		BGURequestAIMoveToLocationWithMM_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIMoveToLocationWithMM_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGURequestAIMoveToLocationWithMM_Position_PropertyAddress, BGURequestAIMoveToLocationWithMM_FunctionAddress, "Position");
		BGURequestAIMoveToLocationWithMM_Position_Offset = NativeReflection.GetPropertyOffset(BGURequestAIMoveToLocationWithMM_FunctionAddress, "Position");
		BGURequestAIMoveToLocationWithMM_Position_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIMoveToLocationWithMM_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref BGURequestAIMoveToLocationWithMM_SpeedRateType_PropertyAddress, BGURequestAIMoveToLocationWithMM_FunctionAddress, "SpeedRateType");
		BGURequestAIMoveToLocationWithMM_SpeedRateType_Offset = NativeReflection.GetPropertyOffset(BGURequestAIMoveToLocationWithMM_FunctionAddress, "SpeedRateType");
		BGURequestAIMoveToLocationWithMM_SpeedRateType_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIMoveToLocationWithMM_FunctionAddress, "SpeedRateType", Classes.FEnumProperty);
		BGURequestAIMoveToLocationWithMM_AcceptableRadius_Offset = NativeReflection.GetPropertyOffset(BGURequestAIMoveToLocationWithMM_FunctionAddress, "AcceptableRadius");
		BGURequestAIMoveToLocationWithMM_AcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIMoveToLocationWithMM_FunctionAddress, "AcceptableRadius", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref BGURequestAIMoveToLocationWithMM_MoveAIType_PropertyAddress, BGURequestAIMoveToLocationWithMM_FunctionAddress, "MoveAIType");
		BGURequestAIMoveToLocationWithMM_MoveAIType_Offset = NativeReflection.GetPropertyOffset(BGURequestAIMoveToLocationWithMM_FunctionAddress, "MoveAIType");
		BGURequestAIMoveToLocationWithMM_MoveAIType_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIMoveToLocationWithMM_FunctionAddress, "MoveAIType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref BGURequestAIMoveToLocationWithMM_IncludeSelfRadius_PropertyAddress, BGURequestAIMoveToLocationWithMM_FunctionAddress, "IncludeSelfRadius");
		BGURequestAIMoveToLocationWithMM_IncludeSelfRadius_Offset = NativeReflection.GetPropertyOffset(BGURequestAIMoveToLocationWithMM_FunctionAddress, "IncludeSelfRadius");
		BGURequestAIMoveToLocationWithMM_IncludeSelfRadius_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIMoveToLocationWithMM_FunctionAddress, "IncludeSelfRadius", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref BGURequestAIMoveToLocationWithMM_IncludeTargetRadius_PropertyAddress, BGURequestAIMoveToLocationWithMM_FunctionAddress, "IncludeTargetRadius");
		BGURequestAIMoveToLocationWithMM_IncludeTargetRadius_Offset = NativeReflection.GetPropertyOffset(BGURequestAIMoveToLocationWithMM_FunctionAddress, "IncludeTargetRadius");
		BGURequestAIMoveToLocationWithMM_IncludeTargetRadius_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIMoveToLocationWithMM_FunctionAddress, "IncludeTargetRadius", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref BGURequestAIMoveToLocationWithMM_MotionMatchingState_PropertyAddress, BGURequestAIMoveToLocationWithMM_FunctionAddress, "MotionMatchingState");
		BGURequestAIMoveToLocationWithMM_MotionMatchingState_Offset = NativeReflection.GetPropertyOffset(BGURequestAIMoveToLocationWithMM_FunctionAddress, "MotionMatchingState");
		BGURequestAIMoveToLocationWithMM_MotionMatchingState_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIMoveToLocationWithMM_FunctionAddress, "MotionMatchingState", Classes.FEnumProperty);
		BGURequestAIMoveToLocationWithMM_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGURequestAIMoveToLocationWithMM_FunctionAddress, "ReturnValue");
		BGURequestAIMoveToLocationWithMM_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIMoveToLocationWithMM_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BGURequestAIMoveToLocationWithMM_IsValid = BGURequestAIMoveToLocationWithMM_FunctionAddress != IntPtr.Zero && BGURequestAIMoveToLocationWithMM_Unit_IsValid && BGURequestAIMoveToLocationWithMM_Position_IsValid && BGURequestAIMoveToLocationWithMM_SpeedRateType_IsValid && BGURequestAIMoveToLocationWithMM_AcceptableRadius_IsValid && BGURequestAIMoveToLocationWithMM_MoveAIType_IsValid && BGURequestAIMoveToLocationWithMM_IncludeSelfRadius_IsValid && BGURequestAIMoveToLocationWithMM_IncludeTargetRadius_IsValid && BGURequestAIMoveToLocationWithMM_MotionMatchingState_IsValid && BGURequestAIMoveToLocationWithMM_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAICS:BGURequestAIMoveToLocationWithMM", BGURequestAIMoveToLocationWithMM_IsValid);
		BGURequestAIWallAndCellMoveToLocation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGURequestAIWallAndCellMoveToLocation");
		BGURequestAIWallAndCellMoveToLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(BGURequestAIWallAndCellMoveToLocation_FunctionAddress);
		BGURequestAIWallAndCellMoveToLocation_Unit_Offset = NativeReflection.GetPropertyOffset(BGURequestAIWallAndCellMoveToLocation_FunctionAddress, "Unit");
		BGURequestAIWallAndCellMoveToLocation_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIWallAndCellMoveToLocation_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGURequestAIWallAndCellMoveToLocation_Position_PropertyAddress, BGURequestAIWallAndCellMoveToLocation_FunctionAddress, "Position");
		BGURequestAIWallAndCellMoveToLocation_Position_Offset = NativeReflection.GetPropertyOffset(BGURequestAIWallAndCellMoveToLocation_FunctionAddress, "Position");
		BGURequestAIWallAndCellMoveToLocation_Position_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIWallAndCellMoveToLocation_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref BGURequestAIWallAndCellMoveToLocation_SpeedRateType_PropertyAddress, BGURequestAIWallAndCellMoveToLocation_FunctionAddress, "SpeedRateType");
		BGURequestAIWallAndCellMoveToLocation_SpeedRateType_Offset = NativeReflection.GetPropertyOffset(BGURequestAIWallAndCellMoveToLocation_FunctionAddress, "SpeedRateType");
		BGURequestAIWallAndCellMoveToLocation_SpeedRateType_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIWallAndCellMoveToLocation_FunctionAddress, "SpeedRateType", Classes.FEnumProperty);
		BGURequestAIWallAndCellMoveToLocation_TurnSpeed_Offset = NativeReflection.GetPropertyOffset(BGURequestAIWallAndCellMoveToLocation_FunctionAddress, "TurnSpeed");
		BGURequestAIWallAndCellMoveToLocation_TurnSpeed_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIWallAndCellMoveToLocation_FunctionAddress, "TurnSpeed", Classes.FFloatProperty);
		BGURequestAIWallAndCellMoveToLocation_AcceptableRadius_Offset = NativeReflection.GetPropertyOffset(BGURequestAIWallAndCellMoveToLocation_FunctionAddress, "AcceptableRadius");
		BGURequestAIWallAndCellMoveToLocation_AcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIWallAndCellMoveToLocation_FunctionAddress, "AcceptableRadius", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref BGURequestAIWallAndCellMoveToLocation_IncludeSelfRadius_PropertyAddress, BGURequestAIWallAndCellMoveToLocation_FunctionAddress, "IncludeSelfRadius");
		BGURequestAIWallAndCellMoveToLocation_IncludeSelfRadius_Offset = NativeReflection.GetPropertyOffset(BGURequestAIWallAndCellMoveToLocation_FunctionAddress, "IncludeSelfRadius");
		BGURequestAIWallAndCellMoveToLocation_IncludeSelfRadius_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIWallAndCellMoveToLocation_FunctionAddress, "IncludeSelfRadius", Classes.FBoolProperty);
		BGURequestAIWallAndCellMoveToLocation_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGURequestAIWallAndCellMoveToLocation_FunctionAddress, "ReturnValue");
		BGURequestAIWallAndCellMoveToLocation_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGURequestAIWallAndCellMoveToLocation_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BGURequestAIWallAndCellMoveToLocation_IsValid = BGURequestAIWallAndCellMoveToLocation_FunctionAddress != IntPtr.Zero && BGURequestAIWallAndCellMoveToLocation_Unit_IsValid && BGURequestAIWallAndCellMoveToLocation_Position_IsValid && BGURequestAIWallAndCellMoveToLocation_SpeedRateType_IsValid && BGURequestAIWallAndCellMoveToLocation_TurnSpeed_IsValid && BGURequestAIWallAndCellMoveToLocation_AcceptableRadius_IsValid && BGURequestAIWallAndCellMoveToLocation_IncludeSelfRadius_IsValid && BGURequestAIWallAndCellMoveToLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAICS:BGURequestAIWallAndCellMoveToLocation", BGURequestAIWallAndCellMoveToLocation_IsValid);
		BGUAISetUnitsTargetAsPlayerByTamerActorTag_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUAISetUnitsTargetAsPlayerByTamerActorTag");
		BGUAISetUnitsTargetAsPlayerByTamerActorTag_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUAISetUnitsTargetAsPlayerByTamerActorTag_FunctionAddress);
		BGUAISetUnitsTargetAsPlayerByTamerActorTag_WorldContextObject_Offset = NativeReflection.GetPropertyOffset(BGUAISetUnitsTargetAsPlayerByTamerActorTag_FunctionAddress, "WorldContextObject");
		BGUAISetUnitsTargetAsPlayerByTamerActorTag_WorldContextObject_IsValid = NativeReflection.ValidatePropertyClass(BGUAISetUnitsTargetAsPlayerByTamerActorTag_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		BGUAISetUnitsTargetAsPlayerByTamerActorTag_MatchTag_Offset = NativeReflection.GetPropertyOffset(BGUAISetUnitsTargetAsPlayerByTamerActorTag_FunctionAddress, "MatchTag");
		BGUAISetUnitsTargetAsPlayerByTamerActorTag_MatchTag_IsValid = NativeReflection.ValidatePropertyClass(BGUAISetUnitsTargetAsPlayerByTamerActorTag_FunctionAddress, "MatchTag", Classes.FNameProperty);
		BGUAISetUnitsTargetAsPlayerByTamerActorTag_IsValid = BGUAISetUnitsTargetAsPlayerByTamerActorTag_FunctionAddress != IntPtr.Zero && BGUAISetUnitsTargetAsPlayerByTamerActorTag_WorldContextObject_IsValid && BGUAISetUnitsTargetAsPlayerByTamerActorTag_MatchTag_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibAICS:BGUAISetUnitsTargetAsPlayerByTamerActorTag", BGUAISetUnitsTargetAsPlayerByTamerActorTag_IsValid);
	}

	static BGUFuncLibAICS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUFuncLibAICS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUFuncLibAICS));
	}
}
