using System.Collections.Generic;
using b1.BGW;
using b1.ECS;
using b1.EventDelDefine;
using b1.Prediction;
using BtlB1;
using BtlShare;
using ResB1;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_SmartCastSkillComp : UActorCompBaseCS
{
	protected APlayerCameraManager PlayerCameraManager;

	private static readonly FName BG_LOG_CATEGORY = B1GlobalFNames.SkillSelectComp;

	private string SkillSelectHelperResPath;

	private USceneComponent ShootCon;

	private b1.BUC_SmartCastSkillData SmartCastSkillData;

	private IBUC_SkillSelectHelperData SkillSelectHelperData;

	private IBUC_SkillInputAssistData SkillInputAssistData;

	private IBUC_SkillInstsData SkillInstsData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_TargetInfoData TargetInfoData;

	private IBPC_InputData InputData;

	public override void OnAttach()
	{
		SmartCastSkillData = RequireWritableData<b1.BUC_SmartCastSkillData>();
		SkillSelectHelperData = RequireReadOnlyData<IBUC_SkillSelectHelperData, BUC_SkillSelectHelperData>();
		SkillInputAssistData = RequireReadOnlyData<IBUC_SkillInputAssistData, BUC_SkillInputAssistData>();
		SkillInstsData = RequireReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		TargetInfoData = RequireReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>();
		InputData = RequireReadOnlyControlledPlayerControlData<IBPC_InputData, BPC_InputData>();
		base.BUSEventCollection.Evt_RequestSmartCastSkill += new Del_RequestSmartCastSkill(OnRequestSmartCastSkill);
		base.BUSEventCollection.Evt_SmartCastSkillTry.Predict += new GSDel_SmartCastSkillTry_IPK_Del.Del_Predict(AutoSmartCastSkill_Predict);
		base.BUSEventCollection.Evt_SmartCastSkillTry.Cue += new GSDel_SmartCastSkillTry_IPK_Del.Del_Predict(AutoSmartCastSkill);
		base.BUSEventCollection.Evt_ResetAttackTracing += new Del_Void(OnResetAttackTracing);
		base.BUSEventCollection.Evt_AIPathMoveComplete += new Del_AIPathMoveComplete(OnAIPathMoveComplete);
	}

	public override void PreBeginPlay()
	{
		InitSmartCastSkillData();
	}

	public override void OnBeginPlay()
	{
		InitSceneComp();
		SkillSelectHelperResPath = "/Game/00Main/BPLibrary/UnitBase/BP_SkillSelectHelper.BP_SkillSelectHelper_C";
		APlayerController aPlayerController = OwnerAsCharacterCS?.GetController() as APlayerController;
		if (aPlayerController != null)
		{
			PlayerCameraManager = aPlayerController.PlayerCameraManager;
		}
	}

	private void InitSceneComp()
	{
		List<UActorComponent> componentsByClass = GetOwner().GetComponentsByClass(UClass.GetClass<USceneComponent>());
		if (componentsByClass == null)
		{
			return;
		}
		foreach (UActorComponent item in componentsByClass)
		{
			if (ShootCon == null && item.ComponentHasTag(B1GlobalFNames.ShootCon))
			{
				ShootCon = item as USceneComponent;
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		TickForAttackTracing(DeltaTime);
		TickForMovingToAttack(DeltaTime);
		UpdateForAutoLockTarget();
	}

	private void TickForAttackTracing(float DeltaTime)
	{
		if (!SmartCastSkillData.IsInAttackRunTracing)
		{
			return;
		}
		if (SmartCastSkillData.IgnoreWeakCtrlTime > 0f)
		{
			SmartCastSkillData.IgnoreWeakCtrlTime -= DeltaTime;
			if (SmartCastSkillData.IgnoreWeakCtrlTime < 0f)
			{
				SmartCastSkillData.IgnoreWeakCtrlTime = 0f;
			}
		}
		AActor owner = GetOwner();
		AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(owner);
		if (!(aActor != null))
		{
			return;
		}
		int attackRunTraceSkillID = SmartCastSkillData.AttackRunTraceSkillID;
		FUStPlayerSkillCtrlDesc playerSkillCtrlDesc = BGW_GameDB.GetPlayerSkillCtrlDesc(attackRunTraceSkillID, owner);
		if (!BGW_LogUtil.LogIfNull(playerSkillCtrlDesc, "Find GetPlayerSkillCtrlDesc failed! SkillID: {0}", attackRunTraceSkillID))
		{
			float num = playerSkillCtrlDesc.AttackRange * playerSkillCtrlDesc.AttackRange;
			float num2 = (float)BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor).Vector_DistanceSquared(BGUFuncLibActorTransformCS.BGUGetActorLocation(owner));
			if (num >= num2)
			{
				base.BUSEventCollection.Evt_RequestSmartCastSkill.Invoke(attackRunTraceSkillID, null);
				base.BUSEventCollection.Evt_ResetAttackTracing.Invoke();
			}
		}
	}

	private void TickForMovingToAttack(float InDeltaTime)
	{
		if (SmartCastSkillData.IsMovingToAttack && !SmartCastSkillData.IsUnpausingBT)
		{
			FUStPlayerSkillCtrlDesc playerSkillCtrlDesc = BGW_GameDB.GetPlayerSkillCtrlDesc(SmartCastSkillData.MovingToAttackSkillID, GetOwner());
			if (playerSkillCtrlDesc == null)
			{
				return;
			}
			SmartCastSkillData.MovingToAttackTimer += InDeltaTime;
			AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(GetOwner());
			if (aActor == null)
			{
				return;
			}
			float movingToAttackToleranceDistance = playerSkillCtrlDesc.MovingToAttackToleranceDistance;
			FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner());
			FVector v2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor);
			bool flag = SmartCastSkillData.MovingToAttackTimer > SmartCastSkillData.MovingToAttackFallbackTime && GetOwner().GetVelocity().Size() <= 0.01f;
			bool flag2 = FVector.Distance(v, v2) <= movingToAttackToleranceDistance;
			if (flag2 || flag)
			{
				if (flag && !flag2)
				{
					UpdateSkillSelectTarget(out var OutTarget, flag);
					BGUFuncLibActorTransformCS.BGUSetActorLocation(OutTarget, BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner()), bSweep: false, bTeleport: true);
				}
				SmartCastSkillData.IsMovingToAttack = false;
				base.BUSEventCollection.Evt_UnitCastSkillTryCMultiCast.Invoke(new FCastSkillInfo(SmartCastSkillData.MovingToAttackSkillID, ECastSkillSourceType.SmartCastSkill));
				SmartCastSkillData.IsUnpausingBT = true;
				SmartCastSkillData.MovingToAttackSkillID = 0;
				if (playerSkillCtrlDesc.MovingToAttackBuff != 0)
				{
					BGUFunctionLibraryCS.BGURemoveBuffImmediately(GetOwner(), playerSkillCtrlDesc.MovingToAttackBuff, EBuffEffectTriggerType.None);
				}
			}
		}
		if (SmartCastSkillData.IsUnpausingBT && !UnitStateData.HasState(EBGUUnitState.Attacking))
		{
			base.BUSEventCollection.Evt_AIPauseBT.Invoke(P1: false);
			SmartCastSkillData.IsUnpausingBT = false;
		}
	}

	private void OnResetAttackTracing()
	{
		SmartCastSkillData.IsInAttackRunTracing = false;
		SmartCastSkillData.AttackRunTraceSkillID = 0;
		SmartCastSkillData.AttackRunTraceMoveIdx = -1;
		SmartCastSkillData.IgnoreWeakCtrlTime = 0f;
	}

	private void InitSmartCastSkillData()
	{
		SmartCastSkillData.TryCastingSkillID = 0;
		SmartCastSkillData.LastAutoActionType = ECtrlActionType.CatNone;
		OnResetAttackTracing();
		SmartCastSkillData.MovingToAttackSkillID = 0;
		SmartCastSkillData.IsMovingToAttack = false;
		SmartCastSkillData.IsUnpausingBT = false;
		SmartCastSkillData.MovingToAttackTimer = 0f;
		SmartCastSkillData.MovingToAttackFallbackTime = 1.5f;
	}

	private void OnRequestSmartCastSkill(int SkillID, List<int> MappingRuleIDList, EMontageBindReason Reason, bool bNeedCheckSkillCanCast, ECastSkillSourceType SourceType)
	{
		ESkillDirection skillDirection = ESkillDirection.Forward;
		if (OwnerAsCharacterCS != null && PlayerCameraManager != null)
		{
			float inputValue = InputData.GetInputValue(GSBattleActionEn.MoveForward);
			float inputValue2 = InputData.GetInputValue(GSBattleActionEn.MoveSideways);
			if (FMath.Abs(inputValue2) + FMath.Abs(inputValue) < 0.01f)
			{
				skillDirection = ESkillDirection.Forward;
			}
			else
			{
				float num = FRotator.NormalizeAxis(BGUFunctionLibraryCS.CalcDirWithInput(BGUFunctionLibraryCS.GetMoveYawDirection(OwnerAsCharacterCS.GetController(), PlayerCameraManager), inputValue, inputValue2).Yaw - Owner.GetActorRotation().Yaw);
				skillDirection = ((-46f <= num && num <= 46f) ? ESkillDirection.Forward : ((num <= -134f || num >= 134f) ? ESkillDirection.Backward : ((!(-135f <= num) || !(num <= -45f)) ? ESkillDirection.Right : ESkillDirection.Left)));
			}
		}
		base.BUSEventCollection.Evt_SmartCastSkillTry.Invoke(SkillID, MappingRuleIDList, Reason, skillDirection, bNeedCheckSkillCanCast, SourceType);
	}

	private void AutoSmartCastSkill_Predict(int SkillID, List<int> MappingRuleIDList, EMontageBindReason Reason, ESkillDirection SkillDirection, bool bNeedCheckSkillCanCast, ECastSkillSourceType SourceType, GSPredictionKey PredictionKey)
	{
		AutoSmartCastSkill(SkillID, MappingRuleIDList, Reason, SkillDirection, bNeedCheckSkillCanCast, SourceType, null);
	}

	private void AutoSmartCastSkill(int SkillID, List<int> MappingRuleIDList, EMontageBindReason Reason, ESkillDirection SkillDirection, bool bNeedCheckSkillCanCast, ECastSkillSourceType SourceType, GSPredictionKey PredictionKey)
	{
		if (PredictionKey != null)
		{
			return;
		}
		SmartCastSkillData.TryCastingSkillID = 0;
		if (SkillSelectHelperData.GetWillCancelSkill())
		{
			return;
		}
		SmartCastSkillData.TryCastingSkillID = SkillID;
		FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(SmartCastSkillData.TryCastingSkillID, GetOwner());
		if (BGW_LogUtil.LogIfNull(skillSDesc, "Find GetSkillSDesc failed! SkillID: {0}", SmartCastSkillData.TryCastingSkillID))
		{
			return;
		}
		ECtrlActionType eCtrlActionType = ECtrlActionType.CatNone;
		SmartCastSkillData.LastAutoActionType = ECtrlActionType.CatNone;
		FUStPlayerSkillCtrlDesc PlayerSkillCtrlDesc = BGW_GameDB.GetPlayerSkillCtrlDesc(SmartCastSkillData.TryCastingSkillID, GetOwner());
		if (PlayerSkillCtrlDesc == null)
		{
			if (TryCastSkill(SmartCastSkillData.TryCastingSkillID, Reason, SkillDirection, bNeedCheckSkillCanCast, SourceType))
			{
				SmartCastSkillData.LastAutoActionType = ECtrlActionType.CatAttack;
			}
			return;
		}
		AActor OutTarget = null;
		AActor owner = GetOwner();
		FVector myPos = BGUFuncLibActorTransformCS.BGUGetActorLocation(owner);
		if (skillSDesc.IsCanMoveAttack == EGSYesNo.Yes)
		{
			float time = ((PlayerSkillCtrlDesc.SkillSpecificMoveTime == 0f) ? BMGlobalConf.PlayerMoveAttackKeepSideWalkTime : PlayerSkillCtrlDesc.SkillSpecificMoveTime);
			base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.BMMoveAttackTrigger, time);
		}
		if (PlayerSkillCtrlDesc.SmartSelectTargetType == ESmartSelectTargetType.SstSelf)
		{
			if (TryCastSkill(SmartCastSkillData.TryCastingSkillID, Reason, SkillDirection, bNeedCheckSkillCanCast, SourceType))
			{
				SmartCastSkillData.LastAutoActionType = ECtrlActionType.CatAttack;
			}
			return;
		}
		UnitLockTargetInfo unitLockTargetInfo = BGUFunctionLibraryCS.BGUGetTargetInfo(owner);
		AActor aActor = unitLockTargetInfo.LockTargetActor;
		if (!BGU_CommonUtil.IsValidTarget(owner, aActor))
		{
			aActor = null;
		}
		if (PlayerSkillCtrlDesc.ResetManualSelectTarget == EGSYesNo.No && unitLockTargetInfo.LockTargetWayType == ELockTargetWayType.Manual)
		{
			OutTarget = aActor;
		}
		if (OutTarget == null)
		{
			if (!SkillInputAssistData.GetIsInSkillManualSelecting())
			{
				OutTarget = GetUpdatedTarget(owner, SmartCastSkillData.TryCastingSkillID);
			}
			else
			{
				switch (PlayerSkillCtrlDesc.SmartSelectShapeType)
				{
				case ESmartSelectShapeType.SssCircle:
				case ESmartSelectShapeType.SssArrowToCircle:
					UpdateSkillSelectTarget(out OutTarget);
					break;
				case ESmartSelectShapeType.SssShootUi:
					UpdateSkillSelectShootTarget(out OutTarget);
					break;
				}
			}
		}
		UpdateManualLockTargetInfo(in PlayerSkillCtrlDesc, SmartCastSkillData.TryCastingSkillID);
		if (!OutTarget.IsNullOrDestroyed())
		{
			if (MappingRuleIDList != null && MappingRuleIDList.Count > 0)
			{
				UnitLockTargetInfo targetInfo = TargetInfoData.GetTargetInfo();
				if (targetInfo != null)
				{
					AActor lockTargetActor = targetInfo.LockTargetActor;
					if (lockTargetActor != null && (targetInfo.LockTargetWayType == ELockTargetWayType.Manual || targetInfo.LockTargetWayType == ELockTargetWayType.Auto))
					{
						int actorResID = BGU_DataUtil.GetActorResID(lockTargetActor);
						foreach (int MappingRuleID in MappingRuleIDList)
						{
							FUStCCGCastSkillMappingRuleDesc cCGCastSkillMappingRuleDesc = BGW_GameDB.GetCCGCastSkillMappingRuleDesc(MappingRuleID);
							if (cCGCastSkillMappingRuleDesc != null && cCGCastSkillMappingRuleDesc.LockRuleInfo != null && cCGCastSkillMappingRuleDesc.LockRuleInfo.UnitResIDList.Contains(actorResID))
							{
								if (cCGCastSkillMappingRuleDesc.LockRuleInfo.OnlyManualLock == EGSYesNo.Yes)
								{
									SmartCastSkillData.TryCastingSkillID = ((targetInfo.LockTargetWayType == ELockTargetWayType.Manual) ? cCGCastSkillMappingRuleDesc.LockRuleInfo.MappingSkillID : SkillID);
								}
								else
								{
									SmartCastSkillData.TryCastingSkillID = cCGCastSkillMappingRuleDesc.LockRuleInfo.MappingSkillID;
								}
								break;
							}
						}
					}
				}
			}
			eCtrlActionType = CalcCtrlActionType(PlayerSkillCtrlDesc, myPos, OutTarget);
			if (eCtrlActionType == ECtrlActionType.CatMoveToCast)
			{
				MoveToCastSkill(SmartCastSkillData.TryCastingSkillID, Reason);
			}
			if (eCtrlActionType == ECtrlActionType.CatRunTrace)
			{
				StartAttackTracing(SmartCastSkillData.TryCastingSkillID);
			}
			if (eCtrlActionType == ECtrlActionType.CatAttack)
			{
				TryCastSkill(SmartCastSkillData.TryCastingSkillID, Reason, SkillDirection, bNeedCheckSkillCanCast, SourceType);
				if (BGW_SettingMgrV2.Get(GetOwner()).GetCVBoolByType(UISettingConfigType.AutoLockAttackTarget))
				{
					BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
					if (bGUCharacterCS != null && bGUCharacterCS.IsPlayerCharacterCS())
					{
						UnitLockTargetInfo unitLockTargetInfo2 = BGUFunctionLibraryCS.BGUGetTargetInfo(Owner);
						if (unitLockTargetInfo2.LockTargetEntity == Entity.Null || unitLockTargetInfo2.LockTargetWayType != ELockTargetWayType.Manual)
						{
							BUS_EventCollectionCS.Get(GetOwner()).Evt_CameraLockTarget.Invoke(new UnitLockTargetInfo(OutTarget, ETargetSourceType.None));
						}
					}
				}
			}
			SmartCastSkillData.LastAutoActionType = eCtrlActionType;
			BUS_EventCollectionCS.Get(OutTarget)?.Evt_BePlayerAddTargeted.Invoke();
		}
		else
		{
			base.BUSEventCollection.Evt_ClearTargetInfo.Invoke();
			if (PlayerSkillCtrlDesc.CanEmptyCast == EGSYesNo.Yes && TryCastSkill(SmartCastSkillData.TryCastingSkillID, Reason, SkillDirection, bNeedCheckSkillCanCast, SourceType))
			{
				SmartCastSkillData.LastAutoActionType = ECtrlActionType.CatAttack;
			}
		}
	}

	private void StartAttackTracing(int SkillID)
	{
		FUStPlayerSkillCtrlDesc playerSkillCtrlDesc = BGW_GameDB.GetPlayerSkillCtrlDesc(SkillID, GetOwner());
		if (playerSkillCtrlDesc != null)
		{
			int num = -1;
			AActor targetActor = BGUFunctionLibraryCS.BGUGetTarget(GetOwner());
			UnitLockTargetInfo unitLockTargetInfo = BGUFunctionLibraryCS.BGUGetTargetInfo(GetOwner());
			num = ((unitLockTargetInfo != null && !(unitLockTargetInfo.LockTargetActor == null)) ? BGUFuncLibAICS.BGURequestAIMoveToTarget(GetOwner(), unitLockTargetInfo, EAIMoveSpeedType.SPRINT, playerSkillCtrlDesc.AttackRange, EBGUMoveAIType.None, IncludeSelfRadius: false, IncludeTargetRadius: false) : BGUFuncLibAICS.BGURequestAIMoveToTarget(GetOwner(), targetActor, EAIMoveSpeedType.SPRINT, playerSkillCtrlDesc.AttackRange, EBGUMoveAIType.None, IncludeSelfRadius: false, IncludeTargetRadius: false));
			SmartCastSkillData.IsInAttackRunTracing = true;
			SmartCastSkillData.AttackRunTraceSkillID = SkillID;
			SmartCastSkillData.AttackRunTraceMoveIdx = num;
			SmartCastSkillData.IgnoreWeakCtrlTime = BMGlobalConf.RunTracingIgnorePlayerWeakCtrlTime;
		}
	}

	private void MoveToCastSkill(int SkillID, EMontageBindReason Reason = EMontageBindReason.Default)
	{
		FUStPlayerSkillCtrlDesc playerSkillCtrlDesc = BGW_GameDB.GetPlayerSkillCtrlDesc(SkillID, GetOwner());
		if (playerSkillCtrlDesc == null)
		{
			return;
		}
		UnitLockTargetInfo unitLockTargetInfo = BGUFunctionLibraryCS.BGUGetTargetInfo(GetOwner());
		if (unitLockTargetInfo.LockTargetActor.IsNullOrDestroyed())
		{
			base.BUSEventCollection.Evt_AIPauseBT.Invoke(P1: false);
			FCastSkillInfo cSI = new FCastSkillInfo(SkillID, ECastSkillSourceType.SmartCastSkill);
			cSI.Reason = Reason;
			base.BUSEventCollection.Evt_UnitCastSkillTryCMultiCast.Invoke(cSI);
			return;
		}
		base.BUSEventCollection.Evt_AIPauseBT.Invoke(P1: true);
		SmartCastSkillData.MovingToAttackSkillID = SkillID;
		base.BUSEventCollection.Evt_AIMoveTo.Invoke(BGUFuncLibActorTransformCS.BGUGetActorLocation(unitLockTargetInfo.LockTargetActor), unitLockTargetInfo.LockTargetActor, EAIMoveSpeedType.SPRINT, playerSkillCtrlDesc.MovingToAttackToleranceDistance, EBGUMoveAIType.None, IncludeSelfRadius: false, IncludeTargetRadius: false, unitLockTargetInfo.LockTargetSceneCompName, unitLockTargetInfo.LockTargetSkeletonSocketName);
		SmartCastSkillData.IsMovingToAttack = true;
		SmartCastSkillData.MovingToAttackTimer = 0f;
		if (playerSkillCtrlDesc.MovingToAttackBuff != 0)
		{
			BGUFunctionLibraryCS.BGUAddBuff(GetOwner(), GetOwner(), playerSkillCtrlDesc.MovingToAttackBuff, EBuffSourceType.SmartCastSkill);
		}
	}

	private ECtrlActionType CalcCtrlActionType(FUStPlayerSkillCtrlDesc PlayerSkillCtrlDesc, FVector MyPos, AActor CurTarget)
	{
		if (CurTarget == null)
		{
			return ECtrlActionType.CatNone;
		}
		if (PlayerSkillCtrlDesc.SmartSelectShapeType == ESmartSelectShapeType.SssArrowToCircle)
		{
			return ECtrlActionType.CatMoveToCast;
		}
		if (SkillInputAssistData.GetIsInSkillManualSelecting())
		{
			return ECtrlActionType.CatAttack;
		}
		if (PlayerSkillCtrlDesc.IgnoreAttackRangeWhenHasTarget == EGSYesNo.Yes)
		{
			return ECtrlActionType.CatAttack;
		}
		FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(CurTarget);
		float num = FVector.Dist(MyPos, v);
		if (num <= PlayerSkillCtrlDesc.AttackRange)
		{
			return ECtrlActionType.CatAttack;
		}
		if (PlayerSkillCtrlDesc.RunTraceRange <= 0f)
		{
			return ECtrlActionType.CatNone;
		}
		if (num <= PlayerSkillCtrlDesc.RunTraceRange)
		{
			return ECtrlActionType.CatRunTrace;
		}
		return ECtrlActionType.CatTooFar;
	}

	private void UpdateManualLockTargetInfo(in FUStPlayerSkillCtrlDesc PlayerSkillCtrlDesc, int SkillID)
	{
		AActor owner = GetOwner();
		if (BGUFunctionLibraryCS.BGUGetTargetInfo(owner).LockTargetType == ELockTargetType.SkeletonSocket)
		{
			return;
		}
		FUStPlayerCommDesc playerCommDesc = BGW_GameDB.GetPlayerCommDesc(BGU_DataUtil.GetActorResID(owner), owner);
		if (playerCommDesc == null || playerCommDesc.EnableMultipointLockMode != EGSYesNo.Yes)
		{
			return;
		}
		FGSMeleeAutoLockSetting fGSMeleeAutoLockSetting = BGUFuncLibSkillCS.BGUGetCurrentMeleeAutoLockSetting(owner, SkillID);
		FRotator myDir = BGUFuncLibActorTransformCS.BGUGetActorRotation(GetOwner());
		float angleMax = fGSMeleeAutoLockSetting.AngleMax;
		float distScoreRating = fGSMeleeAutoLockSetting.DistScoreRating;
		float angleScoreRating = 1f;
		float heightScoreRating = 0f;
		float z_Limit = 0f;
		if (PlayerSkillCtrlDesc != null)
		{
			if (PlayerSkillCtrlDesc.SmartSelectTargetType != ESmartSelectTargetType.SstMeleeAutoLock)
			{
				angleMax = PlayerSkillCtrlDesc.SelectShapeParam3;
				distScoreRating = PlayerSkillCtrlDesc.DistScoreRating;
			}
			angleScoreRating = PlayerSkillCtrlDesc.AngleScoreRating;
			heightScoreRating = PlayerSkillCtrlDesc.HeightScoreRating;
			z_Limit = PlayerSkillCtrlDesc.AttackSelectZLimit;
		}
		UnitLockTargetInfo BestLockTargetInfo = TargetInfoData.GetTargetInfo();
		List<string> compTags = new List<string> { "AutoLockPoint", "AutoLockPoint_SP" };
		BGU_SelectTargetUtil.UpdateAutoLockPointInfoByTargetActor(owner, ref BestLockTargetInfo, BGUFuncLibActorTransformCS.BGUGetActorLocation(owner), myDir, angleMax, angleScoreRating, distScoreRating, heightScoreRating, z_Limit, compTags, PlayerSkillCtrlDesc.AttackRange, PlayerSkillCtrlDesc.PelvisExtraScore, PlayerSkillCtrlDesc.AutoLockPreferPelvis == EGSYesNo.Yes);
		BGUFunctionLibraryCS.BGUSetTargetInfo(IsOnline(), Owner, BestLockTargetInfo);
	}

	protected void UpdateSkillSelectTarget(out AActor OutTarget, bool IsFallBackTarget = false)
	{
		OutTarget = null;
		if (!GetOwner().IsNullOrDestroyed())
		{
			FVector Location = (IsFallBackTarget ? BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner()) : SkillSelectHelperData.GetDesiredSkillLocation());
			FRotator Rotation = (IsFallBackTarget ? BGUFuncLibActorTransformCS.BGUGetActorRotation(GetOwner()) : SkillSelectHelperData.GetDesiredSkillRotation());
			UClass cls = BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<UClass>(SkillSelectHelperResPath, ELoadResourceType.SyncLoadAndCache);
			BGUSkillSelectHelperActor bGUSkillSelectHelperActor = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(GetOwner().World, cls, in Location, in Rotation) as BGUSkillSelectHelperActor;
			BGUFunctionLibraryCS.BGUSetTargetInfo(IsOnline(), Owner, new UnitLockTargetInfo(bGUSkillSelectHelperActor, ETargetSourceType.None, ELockTargetWayType.Auto));
			OutTarget = bGUSkillSelectHelperActor;
		}
	}

	private void UpdateSkillSelectShootTarget(out AActor OutTarget)
	{
		OutTarget = null;
		AActor owner = GetOwner();
		FUStPlayerSkillCtrlDesc playerSkillCtrlDesc = BGW_GameDB.GetPlayerSkillCtrlDesc(SkillInputAssistData.InputSelectingSkillID, owner);
		if (playerSkillCtrlDesc == null)
		{
			return;
		}
		FRotator Rotation = MathLib.Conv_VectorToRotator(SkillSelectHelperData.GetDesiredSkillDirection());
		FVector fVector = ((ShootCon != null) ? ShootCon.GetWorldLocation() : BGUFuncLibActorTransformCS.BGUGetActorLocation(owner));
		FVector fVector2 = fVector + SkillSelectHelperData.GetDesiredSkillDirection() * playerSkillCtrlDesc.AttackRange;
		FVector Location;
		if (UBGUSelectUtil.LineTraceSimple(owner, fVector, fVector2, ETraceTypeQuery.TraceTypeQuery3, bDebug: false, out var HitResult, null) == 1)
		{
			if (HitResult.HitActor as ACharacter != null)
			{
				OutTarget = HitResult.HitActor;
			}
			Location = HitResult.HitLocation;
		}
		else
		{
			Location = fVector2;
		}
		if (OutTarget == null)
		{
			UClass cls = BGW_PreloadAssetMgr.Get(owner).TryGetCachedResourceObj<UClass>(SkillSelectHelperResPath, ELoadResourceType.SyncLoadAndCache);
			OutTarget = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(owner.World, cls, in Location, in Rotation) as BGUSkillSelectHelperActor;
		}
		BGUFunctionLibraryCS.BGUSetTargetInfo(IsOnline(), owner, new UnitLockTargetInfo(OutTarget, ETargetSourceType.None, ELockTargetWayType.Auto));
	}

	protected bool TryCastSkill(int SkillID, EMontageBindReason Reason = EMontageBindReason.Default, ESkillDirection SkillDirection = ESkillDirection.None, bool bNeedCehckSkillCanCast = true, ECastSkillSourceType SourceType = ECastSkillSourceType.SmartCastSkill)
	{
		base.BUSEventCollection.Evt_UnitCastSkillTryCMultiCast.Invoke(new FCastSkillInfo(SkillID, SourceType)
		{
			Reason = Reason,
			SkillDirection = SkillDirection,
			NeedCheckSkillCanCast = bNeedCehckSkillCanCast
		});
		SmartCastSkillData.TryCastingSkillID = 0;
		return SkillInstsData.GetLastSkillCastResult() == ECastSkillResult.CSR_OK;
	}

	private AActor GetUpdatedTarget(AActor MyActor, int SkillID)
	{
		if (MyActor.IsNullOrDestroyed())
		{
			return null;
		}
		FUStPlayerSkillCtrlDesc playerSkillCtrlDesc = BGW_GameDB.GetPlayerSkillCtrlDesc(SkillID, MyActor);
		if (playerSkillCtrlDesc == null)
		{
			return null;
		}
		UnitLockTargetInfo TargetInfo;
		AActor bestTarget = BGW_EffectTemplateList.Get(MyActor).GetSkillSelectTargetTemplate(playerSkillCtrlDesc.SmartSelectTargetType).GetBestTarget(MyActor, SkillID, out TargetInfo);
		if (TargetInfo != null && TargetInfo.LockTargetEntity != Entity.Null)
		{
			if (TargetInfo.LockTargetType == ELockTargetType.SceneComp)
			{
				FUStPlayerCommDesc playerCommDesc = BGW_GameDB.GetPlayerCommDesc(BGU_DataUtil.GetActorResID(MyActor), MyActor);
				if (playerCommDesc != null && playerCommDesc.EnableMultipointLockMode == EGSYesNo.No)
				{
					TargetInfo.LockTargetType = ELockTargetType.Actor;
				}
			}
			if (playerSkillCtrlDesc.LockSmartSelectTarget == EGSYesNo.Yes || SmartCastSkillData.bAutoCameraLock || GSGameplayCVar.CVar_ForceEnableAutoCameraLock.GetValueInGameThread() != 0)
			{
				TargetInfo.LockTargetWayType = ELockTargetWayType.Manual;
				base.BUSEventCollection.Evt_CameraLockTarget.Invoke(TargetInfo);
				return bestTarget;
			}
			BGUFunctionLibraryCS.BGUSetTargetInfo(IsOnline(), Owner, TargetInfo);
		}
		return bestTarget;
	}

	private void OnAIPathMoveComplete(int MoveIdx, EPathFollowingResult Result)
	{
		if (MoveIdx == SmartCastSkillData.AttackRunTraceMoveIdx)
		{
			base.BUSEventCollection.Evt_ClearMoveToTarget.Invoke();
			OnResetAttackTracing();
		}
	}

	private void UpdateForAutoLockTarget()
	{
		UnitLockTargetInfo TargetInfo = BGUFunctionLibraryCS.BGUGetTargetInfo(GetOwner());
		if (GSGameplayCVar.CVar_EnableAutoLockTargetDebug.GetValueInGameThread() > 0 && TargetInfo.LockTargetWayType == ELockTargetWayType.Auto)
		{
			AActor lockTargetActor = TargetInfo.LockTargetActor;
			FVector fVector = FVector.ZeroVector;
			switch (TargetInfo.LockTargetType)
			{
			case ELockTargetType.SceneComp:
			{
				fVector = BGU_SelectTargetUtil.GetTargetPositionByTargetInfo(in TargetInfo, out var _);
				break;
			}
			default:
				if (!(lockTargetActor is ACharacter aCharacter) || !(aCharacter.Mesh != null))
				{
					break;
				}
				if (TargetInfo.LockTargetSkeletonSocketName.Length > 0)
				{
					fVector = aCharacter.Mesh.GetSocketLocation(new FName(TargetInfo.LockTargetSkeletonSocketName));
				}
				switch (TargetInfo.LockTargetType)
				{
				case ELockTargetType.Actor:
					if (aCharacter.Mesh.DoesSocketExist(B1GlobalFNames.CAMERA_LOCK))
					{
						fVector = aCharacter.Mesh.GetSocketLocation(B1GlobalFNames.CAMERA_LOCK);
					}
					break;
				case ELockTargetType.SkeletonSocket:
					fVector = aCharacter.Mesh.GetSocketLocation(new FName(TargetInfo.LockTargetSkeletonSocketName));
					break;
				default:
					fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter);
					break;
				}
				break;
			}
			UBGUFunctionLibraryForCS.BGUDrawLineArrowEx(Owner.World, BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner), fVector, 10f, FColor.Red, IsPersistentLines: false, 2f);
			UBGUFunctionLibraryForCS.BGUDrawDebugSphereEx(Owner.World, fVector, 40f, 2f, FColor.Red);
		}
		if (!SmartCastSkillData.IsInAttackRunTracing && TargetInfo.LockTargetWayType == ELockTargetWayType.Auto)
		{
			Entity lockTargetEntity = TargetInfo.LockTargetEntity;
			bool flag = false;
			if (!UnitStateData.HasState(EBGUUnitState.Attacking))
			{
				flag = true;
			}
			if (BGUFunctionLibraryCS.BGUIsUnitDead(ECSExtension.ToActor(lockTargetEntity)))
			{
				flag = true;
			}
			if (flag)
			{
				base.BUSEventCollection.Evt_ClearTargetInfo.Invoke();
			}
		}
	}
}
