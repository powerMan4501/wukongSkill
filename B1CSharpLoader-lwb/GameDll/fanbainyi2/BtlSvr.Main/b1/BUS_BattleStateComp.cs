using System;
using System.Collections.Generic;
using System.Linq;
using b1.BGW;
using b1.ECS;
using b1.EventDelDefine;
using BtlShare;
using CsB1;
using Diana.Common;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_BattleStateComp : UActorCompBaseCS
{
	private BUC_BattleStateData BattleStateData;

	private BUC_UnitHatredData HatredData;

	private BUC_UnitHatredCacheData HatredCacheData;

	private BUC_TargetInfoData TargetInfoData;

	private IBUC_AttrContainer AttrContainerData;

	private IBUC_GuidData GuidData;

	private IBUC_AIData AIData;

	private IBUC_TickRateData TickRateData;

	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_BossControlData BossControlData;

	private IBUC_FollowPartnerData FollowPartnerData;

	private IBUC_GroupAIData GroupAIData;

	private b1.IBGC_SimpleOverlapMgrData BGSimpleOverlapMgrData;

	private IBGC_TeamRelationData TeamRelationData;

	private IBGC_UnrealGameplayData UnrealGameplayData;

	private IBGC_GlobalBattleStateData GlobalBattleStateData;

	private IBGC_TamerData TamerData;

	private float HATRED_REMOVE_TIME = 10f;

	private int SearchAOTargetXYDistance = -1;

	private int SearchAOTargetZDistance = -1;

	private float SearchAOTargetAngleDegrees = -1f;

	private int LeaveAOTargetXYDistance = -1;

	private int LeaveAOTargetZDistance = -1;

	private float AOTickDuration = 1f;

	private float AOTickTimer;

	private float _TargetCompInfoUpdateTimer;

	private bool bOwnerIsPlayer;

	private const float TICK_TARGET_COMP_INFO_DURATION = 2f;

	public override void OnAttach()
	{
		BattleStateData = RequireWritableData<BUC_BattleStateData>();
		TargetInfoData = RequireWritableData<BUC_TargetInfoData>();
		HatredData = RequireWritableData<BUC_UnitHatredData>();
		HatredCacheData = RequireWritableData<BUC_UnitHatredCacheData>();
		AIData = RequireReadOnlyData<IBUC_AIData, BUC_AIData>();
		TickRateData = RequireReadOnlyData<IBUC_TickRateData, BUC_TickRateData>();
		AttrContainerData = RequireReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		BossControlData = RequireReadOnlyData<IBUC_BossControlData, BUC_BossControlData>();
		FollowPartnerData = RequireReadOnlyData<IBUC_FollowPartnerData, b1.BUC_FollowPartnerData>();
		GroupAIData = RequireReadOnlyData<IBUC_GroupAIData, BUC_GroupAIData>();
		BGSimpleOverlapMgrData = RequireReadOnlyGameStateData<b1.IBGC_SimpleOverlapMgrData, BGC_SimpleOverlapMgrData>();
		TeamRelationData = RequireReadOnlyGameStateData<IBGC_TeamRelationData, BGC_TeamRelationData>();
		UnrealGameplayData = RequireReadOnlyGameStateData<IBGC_UnrealGameplayData, BGC_UnrealGameplayData>();
		GlobalBattleStateData = RequireReadOnlyGameStateData<IBGC_GlobalBattleStateData, BGC_GlobalBattleStateData>();
		TamerData = RequireReadOnlyGameStateData<IBGC_TamerData, BGC_TamerData>();
		base.BUSEventCollection.Evt_OnLeaveFight += new Del_Void(OnLeaveFight);
		base.BUSEventCollection.Evt_UnitTriggerDead += new Del_UnitTriggerDead(OnUnitTriggerDead);
		base.BUSEventCollection.Evt_ResetActorStatusPre += new Del_Void_ResetActorReason(OnResetActorStatusPre);
		base.BUSEventCollection.Evt_CalculateTargetHatredValueByDamage += new Del_Void_ActorIntFloat(CalculateTargetHatredValueByDamage);
		base.BUSEventCollection.Evt_TriggerBeTaunted += new Del_TriggerBeTaunted(OnTriggerBeTaunted);
		base.BUSEventCollection.Evt_RefreshHatredInfo += new Del_Void(OnRefreshHatredInfo);
		base.BUSEventCollection.Evt_UnitCastSkillSuccess += new Del_UnitCastSkillSuccess(OnUnitCastSkillSuccess);
		base.BUSEventCollection.Evt_EnableCanUpdateHatred += new Del_Void_Bool(OnEnableCanUpdateHatred);
		base.BUSEventCollection.Evt_SetCanSetTargetByHatred += new Del_Void_Bool(OnSetCanSetTargetByHatred);
		base.BUSEventCollection.Evt_ClearHatredList += new Del_Void(OnClearHatredList);
		base.BUSEventCollection.Evt_ChangeTargetedCount += new Del_Void_BoolActor(OnChangeTargetedCount);
		base.BUSEventCollection.Evt_EnableCanSetTarget += new Del_Void_Bool(OnEnableCanSetTarget);
		base.BUSEventCollection.Evt_SetCameraLockPointEnabled += new Del_Void_StringBool(OnSetCameraLockPointEnabled);
		base.BUSEventCollection.Evt_SetAutoLockPointEnabled += new Del_Void_StringBool(OnSetAutoLockPointEnabled);
		base.BUSEventCollection.Evt_ClearAllTarget += new Del_Void(OnClearAllTarget);
		base.BUSEventCollection.Evt_DoFreshMultiTarget += new Del_DoFreshMultiTarget(OnDoFreshMultiTarget);
		base.BUSEventCollection.Evt_SetSkillBaseTarget += new Del_SetSkillBaseTarget(OnSetSkillBaseTarget);
		base.BUSEventCollection.Evt_ClearSkillBaseTarget += new Del_Void(OnClearSkillBaseTarget);
		base.BUSEventCollection.Evt_SetTargetInfo += new Del_SetTargetInfo(OnSetTargetInfo);
		base.BUSEventCollection.Evt_SetTargetInfoServer += new Del_SetTargetInfoServer(OnSetTargetInfoServer);
		base.BUSEventCollection.Evt_SetTargetInfoWithCameraLocking += new Del_SetTargetInfoWithCameraLocking(OnSetTargetInfoWithCameraLocking);
		base.BUSEventCollection.Evt_SetTargetInfoWithCameraLockingServer += new Del_SetTargetInfoWithCameraLockingServer(OnSetTargetInfoWithCameraLockingServer);
		base.BUSEventCollection.Evt_ClearTargetInfo += new Del_Void(OnClearTargetInfo);
		base.BUSEventCollection.Evt_SetMoveToTarget += new Del_SetMoveToTarget(OnSetMoveToTarget);
		base.BUSEventCollection.Evt_ClearMoveToTarget += new Del_Void(OnClearMoveToTarget);
		base.BUSEventCollection.Evt_SetComboTarget += new Del_SetComboTarget(OnSetComboTarget);
		base.BUSEventCollection.Evt_ClearComboTarget += new Del_Void(OnClearComboTarget);
		base.BGSEventCollection.Evt_BGS_NotifyCopyHatredInfo += new Del_BGS_NotifyCopyHatredInfo(OnNotifyCopyHatredInfo);
		base.BGSEventCollection.Evt_BGS_FightVanished += new Del_BGS_FightVanished(OnFightVanished);
		base.BGSEventCollection.Evt_BGS_NotifySwitchTarget += new Del_BGS_NotifySwitchTarget(OnNotifySwitchTarget);
		base.BGSEventCollection.Evt_BGS_OnUnitTransited += new Del_BGS_OnUnitTransited(OnUnitTransited);
		if (OwnerAsCharacterCS != null)
		{
			if (OwnerAsCharacterCS.ECSArcheType == 5)
			{
				BattleStateData.IsPlayerUnit = true;
				if (base.BUSEventCollection != null)
				{
					base.BUSEventCollection.Evt_CollectCatchTargetAsPlayerInfo += new Del_Void_Actor(OnCollectCatchTargetAsPlayerInfo);
					base.BUSEventCollection.Evt_CollectAddHatredUnitAsPlayerInfo += new Del_Void_Actor(OnCollectAddHatredUnitAsPlayerInfo);
					base.BUSEventCollection.Evt_ClearCollectedTargetInfo += new Del_Void_Actor(OnClearCollectedTargetInfo);
					base.BUSEventCollection.Evt_ClearCollectedHatredInfo += new Del_Void_Actor(OnClearCollectedHatredInfo);
				}
			}
			else
			{
				BattleStateData.IsPlayerUnit = false;
			}
		}
		TargetInfoData.OnTargetInfoChg += OnTagetInfoChange;
		if (!BattleStateData.IsPlayerUnit)
		{
			HatredData.HatredTargetInfoList.OnAdd += OnHatredTargetInfoListAdd;
			HatredData.HatredTargetInfoList.OnRemove += OnHatredTargetInfoListRemove;
		}
	}

	public override void PreBeginPlay()
	{
		int actorResID = GetActorResID();
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(GetFinalBattleInfoExtendID());
		if (unitBattleInfoExtendDesc != null)
		{
			SearchAOTargetXYDistance = unitBattleInfoExtendDesc.SearchAOTargetXYDistance;
			SearchAOTargetZDistance = unitBattleInfoExtendDesc.SearchAOTargetZDistance;
			SearchAOTargetXYDistance = (int)FMath.Min(SearchAOTargetXYDistance, (AIData.SightRange > 0f) ? AIData.SightRange : ((float)SearchAOTargetXYDistance));
			SearchAOTargetAngleDegrees = ((AIData.VisionAngleDegrees > 0f) ? AIData.VisionAngleDegrees : 90f);
			LeaveAOTargetXYDistance = ((unitBattleInfoExtendDesc.LeaveAOTargetXYDistance >= SearchAOTargetXYDistance) ? unitBattleInfoExtendDesc.LeaveAOTargetXYDistance : (SearchAOTargetXYDistance + 1000));
			LeaveAOTargetZDistance = ((unitBattleInfoExtendDesc.LeaveAOTargetZDistance >= SearchAOTargetZDistance) ? unitBattleInfoExtendDesc.LeaveAOTargetZDistance : (SearchAOTargetZDistance + 1000));
		}
		AOTickTimer = AOTickDuration;
		List<string> multiPointLockOfUnitByCameraConfigDesc = BGW_GameDB.GetMultiPointLockOfUnitByCameraConfigDesc(actorResID);
		if (OwnerAsCharacterCS != null)
		{
			List<FName> allSocketNames = OwnerAsCharacterCS.Mesh.GetAllSocketNames();
			if (multiPointLockOfUnitByCameraConfigDesc != null)
			{
				foreach (FName item in allSocketNames)
				{
					string text = item.ToString();
					if (text.StartsWith(B1GlobalFNames.CAMERA_LOCK.PlainName) && multiPointLockOfUnitByCameraConfigDesc.Contains(text))
					{
						TargetInfoData.CachedLockSkeletonSocket.Add(text);
					}
				}
			}
			else if (allSocketNames.Contains(B1GlobalFNames.CAMERA_LOCK))
			{
				TargetInfoData.CachedLockSkeletonSocket.Add(B1GlobalFNames.CAMERA_LOCK.PlainName);
			}
		}
		if (BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.HatredLeaveTime, out var ConfigInfo))
		{
			HATRED_REMOVE_TIME = ConfigInfo.FloatValue;
		}
		HatredData.SetCanSetTargetByHatred(bEnable: true);
		HatredCacheData.HatredConfigDataAsset = BGW_PreloadAssetMgr.Get(this).HatredConfigDataAsset;
		HatredCacheData.UnitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(GetFinalBattleInfoExtendID());
		HatredCacheData.UnitCommDesc = BGW_GameDB.GetUnitCommDesc(actorResID);
		bOwnerIsPlayer = BattleStateData.IsPlayerUnit;
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		if (Owner != null)
		{
			UnitLockTargetInfo targetInfo = TargetInfoData.GetTargetInfo();
			if (targetInfo.IsValidManualTargetInfo())
			{
				ABGUCharacter aBGUCharacter = targetInfo.LockTargetActor as ABGUCharacter;
				if (aBGUCharacter != null && aBGUCharacter.IsPlayerControlled())
				{
					BUS_EventCollectionCS.Get(aBGUCharacter).Evt_ClearCollectedTargetInfo.Invoke(Owner);
				}
			}
		}
		if (base.BGSEventCollection != null)
		{
			base.BGSEventCollection.Evt_BGS_NotifyCopyHatredInfo -= new Del_BGS_NotifyCopyHatredInfo(OnNotifyCopyHatredInfo);
			base.BGSEventCollection.Evt_BGS_NotifySwitchTarget -= new Del_BGS_NotifySwitchTarget(OnNotifySwitchTarget);
			base.BGSEventCollection.Evt_BGS_FightVanished -= new Del_BGS_FightVanished(OnFightVanished);
			base.BGSEventCollection.Evt_BGS_OnUnitTransited -= new Del_BGS_OnUnitTransited(OnUnitTransited);
		}
		OnClearTargetInfo();
		if (Owner != null)
		{
			OnClearHatredList();
		}
		OnForceLevelBattle();
		TargetInfoData.OnTargetInfoChg -= OnTagetInfoChange;
		if (!BattleStateData.IsPlayerUnit)
		{
			HatredData.HatredTargetInfoList.OnAdd -= OnHatredTargetInfoListAdd;
			HatredData.HatredTargetInfoList.OnRemove -= OnHatredTargetInfoListRemove;
		}
	}

	public override int GetTickGroupMask()
	{
		return 1032;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		switch (TickGroup)
		{
		case 1024:
			if (TickRateData.TROHelper_CanTickThisFrame)
			{
				TickForCamouflage();
				TickForSkillBaseTarget();
				TickForTaunter();
				TickForLockTarget(TickRateData.TROHelper_DeltaTime);
				TickForAOTarget(TickRateData.TROHelper_DeltaTime);
			}
			break;
		case 8:
			if (BattleStateData.IsPlayerUnit)
			{
				if (BattleStateData.IsUnitInBattle())
				{
					TickForValidUnit();
				}
			}
			else
			{
				if (SimpleStateData.HasSimpleState(EBGUSimpleState.CantHatredTick))
				{
					break;
				}
				UnitLockTargetInfo targetInfo = TargetInfoData.GetTargetInfo();
				if (targetInfo != null && targetInfo.LockTargetActor != null)
				{
					HatredData.HatredReFreshTick -= DeltaTime;
					if (HatredData.HatredReFreshTick <= 0f)
					{
						SimplePerceptionForHatred();
					}
					UpdateForValidHatredTarget(DeltaTime);
					HatredData.ForceUpdateHatredTargetTimer -= DeltaTime;
					if (HatredData.ForceUpdateHatredTargetTimer <= 0f)
					{
						bool bNeedUpdateTarget = HatredData.GetTaunterList().Count <= 0;
						CalculateTargetHatredFinalValue(b1.ECalcFinalValueReason.ForceUpdate, bNeedUpdateTarget);
					}
				}
			}
			break;
		}
	}

	private void TickForSkillBaseTarget()
	{
		AActor owner = GetOwner();
		if (!(owner == null) && TargetInfoData != null)
		{
			UnitLockTargetInfo skillBaseTarget = TargetInfoData.GetSkillBaseTarget();
			if (skillBaseTarget != null && skillBaseTarget.LockTargetEntity != Entity.Null && !BGUFunctionLibraryCS.BGUHasUnitState(owner, EBGUUnitState.Attacking))
			{
				OnClearSkillBaseTarget();
			}
		}
	}

	private void TickForAOTarget(float DeltaTime)
	{
		AOTickTimer -= DeltaTime;
		if (AOTickTimer > 0f || OwnerAsCharacterCS == null || !USystemLibrary.IsValid(OwnerAsCharacterCS.Mesh))
		{
			return;
		}
		AOTickTimer = AOTickDuration;
		bool flag = BattleStateData.IsUnitInBattle();
		UnitLockTargetInfo aOTarget = TargetInfoData.GetAOTarget();
		if (flag)
		{
			TargetInfoData.ClearAOTarget_NonCombatantAOTargetDegreeLimit();
		}
		UnitLockTargetInfo skillBaseTarget = TargetInfoData.GetSkillBaseTarget();
		if (skillBaseTarget != null)
		{
			AActor lockTargetActor = skillBaseTarget.LockTargetActor;
			if (lockTargetActor != null)
			{
				if (aOTarget.LockTargetActor != lockTargetActor)
				{
					TargetInfoData.SetAOTarget(lockTargetActor, ETargetSourceType.AO_SetBySkillBaseTarget, bOwnerIsPlayer);
				}
				return;
			}
		}
		UnitLockTargetInfo targetInfo = TargetInfoData.GetTargetInfo();
		if (targetInfo != null)
		{
			AActor lockTargetActor2 = targetInfo.LockTargetActor;
			if (lockTargetActor2 != null && targetInfo.LockTargetWayType == ELockTargetWayType.Manual)
			{
				if (aOTarget.LockTargetActor != lockTargetActor2)
				{
					TargetInfoData.SetAOTarget(lockTargetActor2, ETargetSourceType.AO_SetByTarget, bOwnerIsPlayer);
				}
				return;
			}
		}
		if (flag)
		{
			TargetInfoData.ClearAOTarget();
			return;
		}
		int valueInGameThread = GSGameplayCVar.CVar_EnableAODebugMode.GetValueInGameThread();
		if (valueInGameThread > 0)
		{
			USystemLibrary.DrawDebugArrow(OwnerAsCharacterCS, BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner), BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner) + OwnerAsCharacterCS.Mesh.GetForwardVector() * SearchAOTargetXYDistance, 10f, FLinearColor.Red, 2f, 2f);
		}
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		if (aOTarget != null)
		{
			AActor lockTargetActor3 = aOTarget.LockTargetActor;
			if (lockTargetActor3 != null)
			{
				if (!BGUFuncLibAICS.JudgeActorCanBeAITarget(Owner, lockTargetActor3, TeamRelationData, HatredCacheData))
				{
					TargetInfoData.ClearAOTarget();
				}
				else
				{
					FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(lockTargetActor3);
					float num = FVector.Dist2D(fVector, fVector2);
					float num2 = Math.Abs(fVector.Z - fVector2.Z);
					float num3 = Math.Abs((BGUFuncLibActorTransformCS.BGUGetActorRotation(Owner) - BGUFuncLibActorTransformCS.BGUGetActorRotation(lockTargetActor3)).Yaw);
					if (valueInGameThread > 0)
					{
						USystemLibrary.DrawDebugCircle(Owner.World, fVector, LeaveAOTargetXYDistance, 20, FLinearColor.Red, 1.5f, 20f, FVector.ForwardVector, FVector.RightVector, bDrawAxis: false);
					}
					if (num > (float)LeaveAOTargetXYDistance || num2 > (float)LeaveAOTargetZDistance)
					{
						TargetInfoData.ClearAOTarget();
					}
					else if (!bOwnerIsPlayer || (num <= (float)SearchAOTargetXYDistance && num2 <= (float)SearchAOTargetZDistance && num3 <= SearchAOTargetAngleDegrees))
					{
						if (valueInGameThread > 0)
						{
							USystemLibrary.DrawDebugLine(Owner.World, fVector, fVector2, bOwnerIsPlayer ? FLinearColor.Green : FLinearColor.Yellow, 2f, bOwnerIsPlayer ? 10 : 5);
						}
						return;
					}
				}
			}
		}
		if (BGSimpleOverlapMgrData.GetSimpleOverlapActorsByMask(Owner, fVector, 1, SearchAOTargetXYDistance, 0f, 0f, default(FVector2D), IsSphere: true, out var OutList, UseEntRadiusCheck: false) != ESimpleOverlapResult.ValidInputAndHasOverlapping)
		{
			return;
		}
		if (valueInGameThread > 0)
		{
			USystemLibrary.DrawDebugCircle(Owner.World, fVector, SearchAOTargetXYDistance, 20, FLinearColor.Blue, 1.5f, 20f, FVector.ForwardVector, FVector.RightVector, bDrawAxis: false);
		}
		float num4 = float.MaxValue;
		AActor aActor = null;
		foreach (AActor item in OutList)
		{
			if (item == GetOwner())
			{
				continue;
			}
			BGUCharacterCS bGUCharacterCS = item as BGUCharacterCS;
			if (bGUCharacterCS == null || bGUCharacterCS.IsPendingKill)
			{
				continue;
			}
			BGUPlayerCharacterCS bGUPlayerCharacterCS = item as BGUPlayerCharacterCS;
			if ((!bOwnerIsPlayer && (bGUPlayerCharacterCS == null || bGUPlayerCharacterCS.IsPendingKill)) || bGUCharacterCS.bCanAsFollowPartner)
			{
				continue;
			}
			bool bIgnoreTeamRelastion = bOwnerIsPlayer || (bGUPlayerCharacterCS != null && TeamRelationData != null && !TeamRelationData.IsEnemyTeam(Owner, bGUCharacterCS));
			if (BGUFuncLibAICS.JudgeActorCanBeAITarget(Owner, bGUCharacterCS, TeamRelationData, HatredCacheData, bIgnoreTeamRelastion) && !(Math.Abs(fVector.Z - BGUFuncLibActorTransformCS.BGUGetActorLocation(item).Z) > (float)SearchAOTargetZDistance))
			{
				float num5 = FVector.Dist2D(fVector, BGUFuncLibActorTransformCS.BGUGetActorLocation(item));
				if (num5 < num4)
				{
					num4 = num5;
					aActor = item;
				}
			}
		}
		if (aActor != null)
		{
			if (valueInGameThread > 0)
			{
				USystemLibrary.DrawDebugLine(Owner.World, fVector, BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor), bOwnerIsPlayer ? FLinearColor.Green : FLinearColor.Yellow, 2f, bOwnerIsPlayer ? 10 : 5);
			}
			TargetInfoData.SetAOTarget(aActor, ETargetSourceType.AO_AORangeFind, bOwnerIsPlayer, SearchAOTargetAngleDegrees);
		}
	}

	private void TickForTaunter()
	{
		List<Entity> taunterList = HatredData.GetTaunterList();
		for (int num = taunterList.Count - 1; num >= 0; num--)
		{
			Entity entity = taunterList[num];
			if (entity == Entity.Null)
			{
				HatredData.TaunterList.RemoveAt(num);
			}
			else
			{
				AActor aActor = ECSExtension.ToActor(entity);
				if (aActor == null || BGUFunctionLibraryCS.BGUHasUnitState(aActor, EBGUUnitState.Dead) || BGUFunctionLibraryCS.BGUHasUnitSimpleState(aActor, EBGUSimpleState.PendingDeathInAnimationSyncing))
				{
					HatredData.TaunterList.RemoveAt(num);
				}
			}
		}
		taunterList = HatredData.GetTaunterList();
		if (taunterList.Count > 0)
		{
			UnitLockTargetInfo targetInfo = TargetInfoData.GetTargetInfo();
			AActor aActor2 = ECSExtension.ToActor(taunterList[taunterList.Count - 1]);
			if (targetInfo == null || targetInfo.LockTargetActor == null || targetInfo.LockTargetActor != aActor2)
			{
				BGUFunctionLibraryCS.BGUSetTargetInfo(IsOnline(), Owner, new UnitLockTargetInfo(aActor2, ETargetSourceType.Target_ByTaunter));
			}
			if (!SimpleStateData.HasSimpleState(EBGUSimpleState.BeTaunted))
			{
				base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.BeTaunted);
			}
		}
		else if (SimpleStateData.HasSimpleState(EBGUSimpleState.BeTaunted))
		{
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.BeTaunted, IsRemove: true);
			OnRefreshHatredInfo();
		}
	}

	private void TickForLockTarget(float DeltaTime)
	{
		AActor owner = GetOwner();
		if (owner == null || owner.IsPendingKill)
		{
			return;
		}
		UnitLockTargetInfo targetInfo = TargetInfoData.GetTargetInfo();
		AActor aActor = null;
		if (targetInfo != null)
		{
			aActor = targetInfo.LockTargetActor;
		}
		if (aActor != null)
		{
			if (targetInfo.LockTargetType != ELockTargetType.SkeletonSocket && AIData != null && AIData.UseMultipointLock)
			{
				UpdateTargetCompInfo(DeltaTime);
			}
			base.BUSEventCollection.Evt_MarkLastTargetInfoForAI.Invoke(aActor);
		}
	}

	private void UpdateTargetCompInfo(float DeltaTime)
	{
		AActor owner = GetOwner();
		if (!(owner == null))
		{
			_TargetCompInfoUpdateTimer -= DeltaTime;
			if (_TargetCompInfoUpdateTimer <= 0f)
			{
				_TargetCompInfoUpdateTimer = 2f;
				UnitLockTargetInfo BestLockTargetInfo = TargetInfoData.GetTargetInfo();
				UnitLockTargetInfo BestLockTargetInfo2 = TargetInfoData.GetComboTarget();
				BGU_SelectTargetUtil.UpdateAutoLockPointInfoByTargetActor(owner, ref BestLockTargetInfo, BGUFuncLibActorTransformCS.BGUGetActorLocation(owner), BGUFuncLibActorTransformCS.BGUGetActorRotation(owner), AIData.MultipointLockMaxAngle, 1f, AIData.MultipointLockDistanceScoreRating, 0.5f, 0f, new List<string> { "AutoLockPoint" });
				BGU_SelectTargetUtil.UpdateAutoLockPointInfoByTargetActor(owner, ref BestLockTargetInfo2, BGUFuncLibActorTransformCS.BGUGetActorLocation(owner), BGUFuncLibActorTransformCS.BGUGetActorRotation(owner), AIData.MultipointLockMaxAngle, 1f, AIData.MultipointLockDistanceScoreRating, 0.5f, 0f, new List<string> { "AutoLockPoint" });
				SetTargetToData(BestLockTargetInfo);
				TargetInfoData.SetComboTargetInfo(BestLockTargetInfo2);
			}
		}
	}

	private void TickForCamouflage()
	{
		if (!SimpleStateData.HasSimpleState(EBGUSimpleState.Camouflage))
		{
			return;
		}
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		if (BGSimpleOverlapMgrData.GetSimpleOverlapActorsByMask(Owner, fVector, 1, AIData.StrongPerceptionDistance * 2f, 0f, 0f, default(FVector2D), IsSphere: true, out var OutList, UseEntRadiusCheck: false) != ESimpleOverlapResult.ValidInputAndHasOverlapping)
		{
			return;
		}
		foreach (AActor item in OutList)
		{
			if (item is BGUCharacterCS bGUCharacterCS && !(bGUCharacterCS == Owner) && !(FVector.Distance(BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS), fVector) > AIData.StrongPerceptionDistance))
			{
				IBUC_BattleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>(bGUCharacterCS);
				if (readOnlyData != null && !readOnlyData.IsUnitInBattle())
				{
					BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_AICatchTarget.Invoke(Owner, ETargetSourceType.Target_AIStrongPerception);
				}
			}
		}
	}

	private void NotifyTargetChangeTargetedCount(UnitLockTargetInfo ULTI, bool IsAdd)
	{
		if (ULTI == null)
		{
			return;
		}
		AActor lockTargetActor = ULTI.LockTargetActor;
		if (lockTargetActor != null && !lockTargetActor.IsPendingKill)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(lockTargetActor);
			if (bUS_GSEventCollection != null && bUS_GSEventCollection.HasBeginPlay)
			{
				bUS_GSEventCollection.Evt_ChangeTargetedCount.Invoke(IsAdd, Owner);
			}
		}
	}

	private void SetTargetToData(UnitLockTargetInfo NewTargetInfo)
	{
		if (!(GetOwner() as ABGUCharacter == null))
		{
			TargetInfoData.SetTargetInfo(NewTargetInfo);
		}
	}

	private void OnTagetInfoChange(UnitLockTargetInfo OldTargetInfo, UnitLockTargetInfo NewTargetInfo)
	{
		if (Owner == null)
		{
			return;
		}
		NotifyTargetChangeTargetedCount(OldTargetInfo, IsAdd: false);
		NotifyTargetChangeTargetedCount(NewTargetInfo, IsAdd: true);
		if (!BattleStateData.IsPlayerUnit)
		{
			bool oldBattleState = BattleStateData.IsUnitInBattle();
			if (OldTargetInfo.IsValidManualTargetInfo() && OldTargetInfo.LockTargetEntity != NewTargetInfo.LockTargetEntity)
			{
				ABGUCharacter aBGUCharacter = OldTargetInfo.LockTargetActor as ABGUCharacter;
				if (aBGUCharacter != null && aBGUCharacter.IsPlayerControlled())
				{
					BattleStateData.PlayerAsTarget_ForMonster = null;
					BUS_EventCollectionCS.Get(aBGUCharacter).Evt_ClearCollectedTargetInfo.Invoke(Owner);
				}
				BattleStateData.HasTarget_ForMonster = false;
			}
			if (NewTargetInfo.IsValidManualTargetInfo())
			{
				ABGUCharacter aBGUCharacter2 = NewTargetInfo.LockTargetActor as ABGUCharacter;
				if (aBGUCharacter2 != null && aBGUCharacter2.IsPlayerControlled())
				{
					BattleStateData.PlayerAsTarget_ForMonster = aBGUCharacter2;
					BUS_EventCollectionCS.Get(aBGUCharacter2).Evt_CollectCatchTargetAsPlayerInfo.Invoke(Owner);
				}
				BattleStateData.HasTarget_ForMonster = true;
			}
			NotifyBattleStateChange(oldBattleState);
			TryAddUnitIntoHatredList(NewTargetInfo.LockTargetActor);
		}
		else
		{
			if (NewTargetInfo.LockTargetEntity != Entity.Null)
			{
				if (OldTargetInfo.LockTargetEntity == Entity.Null)
				{
					BGUFunctionLibraryCS.TriggerGuideNodeFinishEvent(Owner, EGuideNodeFinishType.LockTarget);
				}
				else
				{
					BGUFunctionLibraryCS.TriggerGuideNodeFinishEvent(Owner, EGuideNodeFinishType.SwitchLockTarget);
				}
			}
			base.BUSEventCollection.Evt_DoCheckUpdateSideWalkingState.Invoke();
		}
		base.BUSEventCollection.Evt_NotifyTargetInfoChanged.Invoke(NewTargetInfo);
	}

	private void OnHatredTargetInfoListAdd(UnitHatredTargetInfo NewHatredTargetInfo)
	{
		if (!(Owner == null))
		{
			bool oldBattleState = BattleStateData.IsUnitInBattle();
			if (NewHatredTargetInfo.HatredTargetActor is BGUPlayerCharacterCS item && !BattleStateData.PlayerInHatredList_ForMonster.Contains(item))
			{
				BattleStateData.PlayerInHatredList_ForMonster.Add(item);
			}
			BattleStateData.HasHatred_ForMonster = true;
			NotifyBattleStateChange(oldBattleState);
		}
	}

	private void OnHatredTargetInfoListRemove(int RemoveIdx, UnitHatredTargetInfo OldHatredTargetInfo)
	{
		if (!(Owner == null))
		{
			bool oldBattleState = BattleStateData.IsUnitInBattle();
			if (OldHatredTargetInfo.HatredTargetActor is BGUPlayerCharacterCS item && BattleStateData.PlayerInHatredList_ForMonster.Contains(item))
			{
				BattleStateData.PlayerInHatredList_ForMonster.Remove(item);
			}
			BattleStateData.HasHatred_ForMonster = HatredData.HatredTargetInfoList.Count > 0;
			NotifyBattleStateChange(oldBattleState);
		}
	}

	private void ClearTaunterList()
	{
		HatredData.TaunterList.Clear();
	}

	private void OnClearTargetInfo()
	{
		if (!(GetOwner() == null))
		{
			SetTargetToData(new UnitLockTargetInfo());
		}
	}

	private void OnChangeTargetedCount(bool IsAdd, AActor Owner)
	{
		if (IsAdd)
		{
			TargetInfoData.IncrementTargetedCount();
		}
		else
		{
			TargetInfoData.DecrementTargetedCount();
		}
	}

	private void OnDoFreshMultiTarget(float SearchRaius, int TargetTeamFilter, int TargetTypeFilter, EMultiTargetConditionType MultiTargetConditionType, int Param1, int Param2)
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return;
		}
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(owner);
		IList<int> Prams = new List<int> { (int)SearchRaius };
		BGUFuncLibSelectTargetsCS.BGUSelectTargetsInShape(owner, out var OutActors, owner, fVector, ERangeType.Circle, -1, TargetTeamFilter, TargetTypeFilter, 0, in Prams);
		switch (MultiTargetConditionType)
		{
		case EMultiTargetConditionType.HasBuff:
		{
			for (int num5 = OutActors.Count - 1; num5 >= 0; num5--)
			{
				if (!BGUFunctionLibraryCS.BGUHasBuffByID(OutActors[num5], Param1))
				{
					OutActors.RemoveAt(num5);
				}
			}
			break;
		}
		case EMultiTargetConditionType.HasState:
		{
			EBGUUnitState unitState = (EBGUUnitState)Param1;
			for (int num3 = OutActors.Count - 1; num3 >= 0; num3--)
			{
				if (!BGUFunctionLibraryCS.BGUHasUnitState(OutActors[num3], unitState))
				{
					OutActors.RemoveAt(num3);
				}
			}
			break;
		}
		case EMultiTargetConditionType.HasSimpleState:
		{
			EBGUSimpleState simpleState = (EBGUSimpleState)Param1;
			for (int num4 = OutActors.Count - 1; num4 >= 0; num4--)
			{
				if (!BGUFunctionLibraryCS.BGUHasUnitSimpleState(OutActors[num4], simpleState))
				{
					OutActors.RemoveAt(num4);
				}
			}
			break;
		}
		case EMultiTargetConditionType.HPPercentInRange:
		{
			for (int num = OutActors.Count - 1; num >= 0; num--)
			{
				float num2 = BGUFunctionLibraryCS.BGUGetFloatAttr(OutActors[num], EBGUAttrFloat.Hp);
				if (num2 < (float)Param1 || num2 > (float)Param2)
				{
					OutActors.RemoveAt(num);
				}
			}
			break;
		}
		}
		for (int num6 = OutActors.Count - 1; num6 >= 0; num6--)
		{
			if (OutActors[num6] is BGUCharacterCS actor)
			{
				IBUC_BattleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>(actor);
				if (readOnlyData != null && !readOnlyData.IsUnitInBattle())
				{
					OutActors.RemoveAt(num6);
				}
			}
		}
		List<UnitLockTargetInfo> list = new List<UnitLockTargetInfo>();
		foreach (AActor item in OutActors)
		{
			list.Add(new UnitLockTargetInfo(item, ETargetSourceType.None));
		}
		TargetInfoData.DoFreshMultiTarget(list);
		if (GSGameplayCVar.CVar_DoFreshMultiTarget.GetValueInGameThread() == 0)
		{
			return;
		}
		USystemLibrary.DrawDebugSphere(owner, fVector, SearchRaius, 20, FLinearColor.Yellow, 5f, 10f);
		foreach (AActor item2 in OutActors)
		{
			FVector center = BGUFuncLibActorTransformCS.BGUGetActorLocation(item2);
			UCapsuleComponent uCapsuleComponent = item2.GetRootComponent() as UCapsuleComponent;
			float radius = ((uCapsuleComponent != null) ? uCapsuleComponent.GetScaledCapsuleRadius() : 200f);
			USystemLibrary.DrawDebugSphere(owner, center, radius, 20, FLinearColor.Green, 5f, 10f);
		}
	}

	private void OnUnitTransited(AActor OldUnit, AActor NewUnit)
	{
		OnNotifySwitchTarget(OldUnit, NewUnit, TriggerTaunt: false, ETargetSourceType.SwitchTarget_TransUnit);
		OnNotifyCopyHatredInfo(OldUnit, NewUnit, bRemoveOriginHatredInfo: true);
	}

	private void OnNotifySwitchTarget(AActor OldTarget, AActor NewTarget, bool TriggerTaunt, ETargetSourceType TargetSourceType)
	{
		if (GetOwner() == null || OldTarget == null || NewTarget == null)
		{
			return;
		}
		UnitLockTargetInfo targetInfo = TargetInfoData.GetTargetInfo();
		if (targetInfo.LockTargetEntity != Entity.Null && targetInfo.LockTargetActor == OldTarget)
		{
			UnitLockTargetInfo newTargetInfo = (bOwnerIsPlayer ? new UnitLockTargetInfo(NewTarget, TargetSourceType) : BGUFuncLibAICS.BGUAIGetAutoLockTargetInfo(NewTarget, TargetSourceType));
			OnSetTargetInfo(newTargetInfo);
			if (TriggerTaunt)
			{
				OnTriggerBeTaunted(NewTarget, IsReMove: false);
			}
		}
		UnitLockTargetInfo aOTarget = TargetInfoData.GetAOTarget();
		if (aOTarget.LockTargetEntity != Entity.Null && aOTarget.LockTargetActor == OldTarget)
		{
			TargetInfoData.SetAOTarget(NewTarget, TargetSourceType, bOwnerIsPlayer);
		}
		UnitLockTargetInfo comboTarget = TargetInfoData.GetComboTarget();
		if (comboTarget.LockTargetEntity != Entity.Null && comboTarget.LockTargetActor == OldTarget)
		{
			TargetInfoData.SetComboTarget(NewTarget, TargetSourceType, bOwnerIsPlayer);
		}
		UnitLockTargetInfo skillBaseTarget = TargetInfoData.GetSkillBaseTarget();
		if (skillBaseTarget.LockTargetEntity != Entity.Null && skillBaseTarget.SourceType == ETargetSourceType.SkillBase_SetByAI && skillBaseTarget.LockTargetActor == OldTarget)
		{
			TargetInfoData.SetSkillBaseTarget(NewTarget, BGUFuncLibActorTransformCS.BGUGetActorLocation(NewTarget), TargetSourceType, string.Empty);
		}
	}

	private void OnFightVanished(AActor TriggerActor)
	{
		if (!(GetOwner() == null))
		{
			UnitLockTargetInfo targetInfo = TargetInfoData.GetTargetInfo();
			if (targetInfo.LockTargetEntity != Entity.Null && targetInfo.LockTargetActor == TriggerActor)
			{
				OnClearTargetInfo();
			}
			UnitLockTargetInfo aOTarget = TargetInfoData.GetAOTarget();
			if (aOTarget.LockTargetEntity != Entity.Null && aOTarget.LockTargetActor == TriggerActor)
			{
				TargetInfoData.ClearAOTarget();
			}
			UnitLockTargetInfo comboTarget = TargetInfoData.GetComboTarget();
			if (comboTarget.LockTargetEntity != Entity.Null && comboTarget.LockTargetActor == TriggerActor)
			{
				OnClearComboTarget();
			}
			UnitLockTargetInfo skillBaseTarget = TargetInfoData.GetSkillBaseTarget();
			if (skillBaseTarget.LockTargetEntity != Entity.Null && skillBaseTarget.LockTargetActor == TriggerActor)
			{
				OnClearSkillBaseTarget();
			}
			UnitLockTargetInfo moveToTarget = TargetInfoData.GetMoveToTarget();
			if (moveToTarget.LockTargetEntity != Entity.Null && moveToTarget.LockTargetActor == TriggerActor)
			{
				OnClearMoveToTarget();
			}
			TryClearHatredInfo(TriggerActor);
		}
	}

	private void OnUnitTriggerDead(AActor Attacker, EDeadReason DeadReason, int DmgID)
	{
		if (!(GetOwner() == null))
		{
			OnEnableCanSetTarget(bEnable: false);
			OnClearTargetInfo();
			OnEnableCanUpdateHatred(bEnable: false);
			OnClearHatredList();
			OnForceLevelBattle();
		}
	}

	private void OnSetMoveToTarget(AActor MoveToTarget, FVector PointLocation, ETargetSourceType SourceType = ETargetSourceType.None, string SceneCompName = "", string SocketName = "")
	{
		if (TargetInfoData.GetCanSetTarget())
		{
			UnitLockTargetInfo moveToTarget = TargetInfoData.GetMoveToTarget();
			if (moveToTarget.LockTargetActor != MoveToTarget || !moveToTarget.LockTargetSceneCompName.Equals(SceneCompName) || !moveToTarget.LockTargetSkeletonSocketName.Equals(SocketName) || moveToTarget.LockPointLocation != PointLocation)
			{
				TargetInfoData.SetMoveToTarget(MoveToTarget, PointLocation, SourceType, SceneCompName, SocketName, bOwnerIsPlayer);
			}
		}
	}

	private void OnClearMoveToTarget()
	{
		if (!(GetOwner() == null))
		{
			TargetInfoData.ClearMoveToTarget();
		}
	}

	private void OnSetSkillBaseTarget(AActor SkillBaseTarget, FVector Location, ETargetSourceType SourceType, string SceneCompName)
	{
		if (!(GetOwner() == null))
		{
			TargetInfoData.SetSkillBaseTarget(SkillBaseTarget, Location, SourceType, SceneCompName);
		}
	}

	private void OnClearSkillBaseTarget()
	{
		if (!(GetOwner() == null))
		{
			TargetInfoData.ClearSkillBaseTarget();
		}
	}

	private void OnSetComboTarget(AActor ComboTarget, ETargetSourceType SourceType)
	{
		if (!(GetOwner() == null))
		{
			TargetInfoData.SetComboTarget(ComboTarget, SourceType, bOwnerIsPlayer);
		}
	}

	private void OnClearComboTarget()
	{
		if (!(GetOwner() == null))
		{
			TargetInfoData.ClearComboTarget();
		}
	}

	private void OnCleanAOTarget()
	{
		if (!(GetOwner() == null))
		{
			TargetInfoData.ClearAOTarget();
		}
	}

	private void OnClearMultiTarget()
	{
		if (!(GetOwner() == null))
		{
			TargetInfoData.ClearMultiTarget();
		}
	}

	private void OnSetTargetInfoWithCameraLockingServer(FUnitLockTargetInfo NewTargetInfo)
	{
		OnSetTargetInfoWithCameraLocking(BGUFuncLibReplication.GetLockTargetInfoFromRPC(NewTargetInfo, Owner));
	}

	private void OnSetTargetInfoWithCameraLocking(UnitLockTargetInfo NewTargetInfo)
	{
		OnSetTargetInfo(NewTargetInfo);
	}

	private void OnSetTargetInfoServer(FUnitLockTargetInfo NewTargetInfo)
	{
		OnSetTargetInfo(BGUFuncLibReplication.GetLockTargetInfoFromRPC(NewTargetInfo, Owner));
	}

	private void OnSetTargetInfo(UnitLockTargetInfo NewTargetInfo)
	{
		if (!TargetInfoData.GetCanSetTarget())
		{
			return;
		}
		UnitLockTargetInfo targetInfo = TargetInfoData.GetTargetInfo();
		_ = NewTargetInfo.LockTargetActor;
		if (targetInfo.LockTargetEntity != NewTargetInfo.LockTargetEntity || targetInfo.LockTargetType != NewTargetInfo.LockTargetType || targetInfo.LockTargetWayType != NewTargetInfo.LockTargetWayType || !targetInfo.LockTargetSceneCompName.Equals(NewTargetInfo.LockTargetSceneCompName) || !targetInfo.LockTargetSkeletonSocketName.Equals(NewTargetInfo.LockTargetSkeletonSocketName))
		{
			SetTargetToData(NewTargetInfo);
			if (NewTargetInfo.LockTargetType != ELockTargetType.SkeletonSocket && AIData != null && AIData.UseMultipointLock)
			{
				_TargetCompInfoUpdateTimer = 0f;
				UpdateTargetCompInfo(0f);
			}
		}
	}

	private void OnEnableCanSetTarget(bool bEnable)
	{
		TargetInfoData.SetCanSetTarget(bEnable);
	}

	private void OnSetCameraLockPointEnabled(string SkeletonSocketName, bool bEnabled)
	{
		if (bEnabled)
		{
			TargetInfoData.DisabledLockSkeletonSocket.Remove(SkeletonSocketName);
		}
		else
		{
			TargetInfoData.DisabledLockSkeletonSocket.Add(SkeletonSocketName);
		}
	}

	private void OnSetAutoLockPointEnabled(string SceneCompName, bool bEnabled)
	{
		if (bEnabled)
		{
			TargetInfoData.DisabledAutoLockSceneComp.Remove(SceneCompName);
		}
		else
		{
			TargetInfoData.DisabledAutoLockSceneComp.Add(SceneCompName);
		}
	}

	private void OnClearAllTarget()
	{
		ClearTaunterList();
		OnClearTargetInfo();
		OnClearComboTarget();
		OnClearSkillBaseTarget();
		OnCleanAOTarget();
		OnClearMultiTarget();
		OnClearMoveToTarget();
	}

	private void OnResetActorStatusPre(EResetActorReason ResetReason)
	{
		OnClearHatredList();
		OnClearAllTarget();
		OnForceLevelBattle();
	}

	private void OnRefreshHatredInfo()
	{
		SimplePerceptionForHatred();
		UpdateForValidHatredTarget(0f);
		CalculateTargetHatredFinalValue(b1.ECalcFinalValueReason.HasInValidTarget, bNeedUpdateTarget: true);
	}

	private void SimplePerceptionForHatred()
	{
		if (!HatredData.GetEnableUpdateHatred() || HatredCacheData.HatredConfigDataAsset == null)
		{
			return;
		}
		int min = HatredCacheData.HatredConfigDataAsset.HatredTickInterval / 2;
		int hatredTickInterval = HatredCacheData.HatredConfigDataAsset.HatredTickInterval;
		HatredData.HatredReFreshTick = FMath.RandRange(min, hatredTickInterval);
		if (HatredCacheData.UnitCommDesc == null)
		{
			return;
		}
		FVector inOriginalLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		BGSimpleOverlapMgrData.GetSimpleOverlapActorsByMask(Owner, inOriginalLocation, 1, HatredCacheData.UnitBattleInfoExtendDesc.HatredPerceptionXYDistance, 0f, 0f, default(FVector2D), IsSphere: true, out var OutList);
		float z = inOriginalLocation.Z;
		for (int i = 0; i < OutList.Count; i++)
		{
			if (OutList[i] is BGUCharacterCS bGUCharacterCS)
			{
				float z2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS).Z;
				if (HatredCacheData.UnitBattleInfoExtendDesc.HatredPerceptionZDistance <= 0 || !(Math.Abs(z - z2) > (float)HatredCacheData.UnitBattleInfoExtendDesc.HatredPerceptionZDistance))
				{
					TryAddUnitIntoHatredList(bGUCharacterCS);
				}
			}
		}
	}

	private void UpdateForValidHatredTarget(float DeltaTime)
	{
		GSBindList<UnitHatredTargetInfo> hatredTargetInfoList = HatredData.GetHatredTargetInfoList();
		if (hatredTargetInfoList.Count <= 0)
		{
			return;
		}
		AActor lockTargetActor = TargetInfoData.GetTargetInfo().LockTargetActor;
		for (int num = hatredTargetInfoList.Count - 1; num >= 0; num--)
		{
			UnitHatredTargetInfo unitHatredTargetInfo = hatredTargetInfoList[num];
			if (unitHatredTargetInfo != null)
			{
				AActor hatredTargetActor = unitHatredTargetInfo.HatredTargetActor;
				if (JudgeActorCanBeHatredActor(hatredTargetActor))
				{
					if (hatredTargetActor == lockTargetActor)
					{
						hatredTargetInfoList[num].IsFarawayFromOwner = false;
						hatredTargetInfoList[num].FarawayTimer = 0f;
					}
					else
					{
						FVector checkPos = BGUFuncLibActorTransformCS.BGUGetActorLocation(hatredTargetActor);
						if (!AIData.IsInPursuitRange(checkPos))
						{
							if (!hatredTargetInfoList[num].IsFarawayFromOwner)
							{
								hatredTargetInfoList[num].IsFarawayFromOwner = true;
								hatredTargetInfoList[num].FarawayTimer = HATRED_REMOVE_TIME;
							}
						}
						else
						{
							hatredTargetInfoList[num].IsFarawayFromOwner = false;
							hatredTargetInfoList[num].FarawayTimer = 0f;
						}
						if (hatredTargetInfoList[num].IsFarawayFromOwner)
						{
							hatredTargetInfoList[num].FarawayTimer -= DeltaTime;
							if (hatredTargetInfoList[num].FarawayTimer <= 0f)
							{
								TryClearHatredInfo(hatredTargetActor);
							}
						}
					}
				}
				else
				{
					TryClearHatredInfo(hatredTargetActor);
				}
			}
		}
	}

	private void TryClearHatredInfo(AActor HatredActor)
	{
		HatredData.GetHatredTargetInfoByID(HatredActor, out var Idx);
		if (Idx < 0)
		{
			return;
		}
		if (BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(Owner))
		{
			HatredData.HatredTargetInfoList.RemoveAt(Idx);
		}
		GSBindList<Entity> playerHatredEntityList = HatredData.GetPlayerHatredEntityList();
		for (int i = 0; i < playerHatredEntityList.Count; i++)
		{
			if (ECSExtension.ToActor(playerHatredEntityList[i]) == HatredActor)
			{
				if (BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(Owner))
				{
					HatredData.PlayerHatredEntityList.RemoveAt(i);
				}
				ABGUCharacter aBGUCharacter = HatredActor as ABGUCharacter;
				if (aBGUCharacter != null && aBGUCharacter.IsPlayerControlled())
				{
					BUS_EventCollectionCS.Get(aBGUCharacter).Evt_ClearCollectedHatredInfo.Invoke(Owner);
				}
				break;
			}
		}
	}

	private bool TryAddUnitIntoHatredList(AActor Target, UnitHatredTargetInfo OtherTargetInfo = null, float ValueMultiple = 0f, float ExtraValue = 0f)
	{
		if (JudgeActorCanBeHatredActor(Target))
		{
			bool flag = false;
			foreach (UnitHatredTargetInfo hatredTargetInfo in HatredData.GetHatredTargetInfoList())
			{
				if (hatredTargetInfo.HatredTargetActor == Target)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				ABGUCharacter aBGUCharacter = Target as ABGUCharacter;
				if (aBGUCharacter != null && aBGUCharacter.IsPlayerControlled())
				{
					if (BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(Owner))
					{
						HatredData.PlayerHatredEntityList.Add(ECSExtension.ToEntity(Target));
					}
					BUS_EventCollectionCS.Get(aBGUCharacter).Evt_CollectAddHatredUnitAsPlayerInfo.Invoke(Owner);
					if (aBGUCharacter.IsLocallyControlled())
					{
						base.BUSEventCollection.Evt_AddLocalPlayerIntoHatredList.Invoke();
					}
				}
				UnitHatredTargetInfo unitHatredTargetInfo = new UnitHatredTargetInfo
				{
					HatredTargetEntity = ECSExtension.ToEntity(Target)
				};
				if (OtherTargetInfo != null)
				{
					unitHatredTargetInfo.CopyAndUpdateHatredInfo(OtherTargetInfo, ValueMultiple, ExtraValue);
				}
				HatredData.HatredTargetInfoList.Add(unitHatredTargetInfo);
				return true;
			}
		}
		return false;
	}

	private void CalculateTargetHatredFinalValue(b1.ECalcFinalValueReason CalcReason, bool bNeedUpdateTarget)
	{
		if (OwnerAsCharacterCS == null)
		{
			return;
		}
		if ((CalcReason == b1.ECalcFinalValueReason.ForceUpdate || CalcReason == b1.ECalcFinalValueReason.HasInValidTarget) && HatredCacheData.HatredConfigDataAsset != null)
		{
			int min = HatredCacheData.HatredConfigDataAsset.ForceUpdateHatredTargetTime / 2;
			int forceUpdateHatredTargetTime = HatredCacheData.HatredConfigDataAsset.ForceUpdateHatredTargetTime;
			HatredData.ForceUpdateHatredTargetTimer = FMath.RandRange(min, forceUpdateHatredTargetTime);
		}
		GSBindList<UnitHatredTargetInfo> hatredTargetInfoList = HatredData.GetHatredTargetInfoList();
		if (hatredTargetInfoList == null || hatredTargetInfoList.Count == 0)
		{
			return;
		}
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = HatredCacheData.UnitBattleInfoExtendDesc;
		if (unitBattleInfoExtendDesc == null)
		{
			return;
		}
		BGWHatredConfigDataAsset hatredConfigDataAsset = HatredCacheData.HatredConfigDataAsset;
		if (hatredConfigDataAsset == null)
		{
			return;
		}
		float timeSeconds = UnrealGameplayData.GetTimeSeconds();
		FVector targetPostion = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		foreach (UnitHatredTargetInfo item in hatredTargetInfoList)
		{
			BGUCharacterCS bGUCharacterCS = item.HatredTargetActor as BGUCharacterCS;
			if (bGUCharacterCS == null)
			{
				continue;
			}
			FUStUnitBattleInfoExtendDesc fUStUnitBattleInfoExtendDesc = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_UnitHatredCacheData, BUC_UnitHatredCacheData>(bGUCharacterCS)?.UnitBattleInfoExtendDesc;
			if (fUStUnitBattleInfoExtendDesc == null)
			{
				continue;
			}
			IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_TargetInfoData>(bGUCharacterCS);
			int hatredQuality = fUStUnitBattleInfoExtendDesc.HatredQuality;
			int num = ((OwnerAsCharacterCS == readOnlyData.GetTargetInfo().LockTargetActor) ? 1 : 0);
			int num2 = 2;
			int num3 = ((readOnlyData.GetTargetedCount() >= num2) ? 1 : 0);
			item.QualityCorrection = FMath.Abs(unitBattleInfoExtendDesc.HatredQuality - hatredQuality) * hatredConfigDataAsset.QualityCorrectionFactor;
			item.LockCorrection = hatredConfigDataAsset.LockCorrectionFactor * num;
			item.BeLockedCorrection = hatredConfigDataAsset.BeLockedCorrectionFactor * num3;
			item.IsInView = true;
			if (unitBattleInfoExtendDesc.HatredQuality <= 2)
			{
				FTransform fTransform = BGUFuncLibActorTransformCS.BGUGetActorTransform(bGUCharacterCS);
				item.IsInView = BGUFunctionLibraryCS.BGUIsTargetInView(fTransform.GetLocation(), fTransform.Rotator(), targetPostion, hatredConfigDataAsset.OneSideViewAngle);
			}
			if (item.HatredValueSkillExtra > 0f)
			{
				if (item.LastTickTimeForCalcSkillExtraValue == 0f)
				{
					item.LastTickTimeForCalcSkillExtraValue = timeSeconds;
				}
				item.HatredValueSkillExtra -= (float)hatredConfigDataAsset.AttenuationSpeedForSkillExtra * (timeSeconds - item.LastTickTimeForCalcSkillExtraValue);
				item.HatredValueSkillExtra = Math.Max(0f, item.HatredValueSkillExtra);
				item.LastTickTimeForCalcSkillExtraValue = timeSeconds;
			}
			if (item.LastTickTimeForCalcBaseValue == 0f)
			{
				item.LastTickTimeForCalcBaseValue = timeSeconds;
			}
			float num4 = timeSeconds - item.LastTickTimeForCalcBaseValue;
			if (num4 > (float)hatredConfigDataAsset.AttenuationBeginTime)
			{
				item.HatredValueBase -= (float)hatredConfigDataAsset.AttenuationSpeed * num4;
				item.LastTickTimeForCalcBaseValue = timeSeconds;
			}
			item.HatredValueBase = Math.Max(0f, item.HatredValueBase);
			item.HatredViewWeight = (item.IsInView ? 1f : hatredConfigDataAsset.NotInViewHatredWeight);
			item.FinalHatredValueWithoutViewWeight = item.HatredValueBase - item.QualityCorrection - item.BeLockedCorrection + item.LockCorrection + item.HatredValueSkillExtra;
			item.HatredValueFinal = item.HatredViewWeight * item.FinalHatredValueWithoutViewWeight;
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			List<UnitHatredTargetInfo> list = HatredData.GetHatredTargetInfoList().ToList();
			list.Sort((UnitHatredTargetInfo x, UnitHatredTargetInfo y) => y.HatredValueFinal.CompareTo(x.HatredValueFinal));
			int num5 = 3;
			string text = $"<action>{DateTime.Now.ToLongTimeString()}</><character> {OwnerAsCharacterCS.GetFName()} </><action> 更新仇恨目标，原因：</><effect>{CalcReason.ToString()}</>";
			text += $"\n<action>下面显示从高到底显示仇恨值最高的{num5}个信息: </>";
			for (int num6 = 0; num6 < list.Count; num6++)
			{
				if (num5 <= 0)
				{
					break;
				}
				UnitHatredTargetInfo unitHatredTargetInfo = list[num6];
				if (unitHatredTargetInfo.HatredTargetActor is BGUCharacterCS bGUCharacterCS2)
				{
					FUStUnitBattleInfoExtendDesc fUStUnitBattleInfoExtendDesc2 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_UnitHatredCacheData, BUC_UnitHatredCacheData>(bGUCharacterCS2)?.UnitBattleInfoExtendDesc;
					if (fUStUnitBattleInfoExtendDesc2 != null)
					{
						text += $"\n<action>目标名字: </><effect>{bGUCharacterCS2.GetFName()}</><action> 仇恨品质: </><effect>{fUStUnitBattleInfoExtendDesc2.HatredQuality}</>";
						text += $"\n\t<action>最终仇恨值: </><effect>{unitHatredTargetInfo.FinalHatredValueWithoutViewWeight}</>";
						text += $"\n\t<action>基础仇恨值: </><effect>{unitHatredTargetInfo.HatredValueBase}</><action> 品质修正: </><effect>{unitHatredTargetInfo.QualityCorrection}</>";
						text += $"<action> 被锁定数量修正: </><effect>{unitHatredTargetInfo.BeLockedCorrection}</><action> 锁定修正: </><effect>{unitHatredTargetInfo.LockCorrection}</>";
						text += $"<action> 技能附加值: </><effect>{unitHatredTargetInfo.HatredValueSkillExtra}</>";
						text += $"\n\t<action>是否在视野内: </><effect>{unitHatredTargetInfo.IsInView}</>";
						text += $"\n\t<action>视野仇恨权重: </><effect>{unitHatredTargetInfo.HatredViewWeight}</>";
						num5--;
					}
				}
			}
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.Hatred, text);
		}
		if (bNeedUpdateTarget && HatredData.GetCanSetTargetByHatred())
		{
			HatredData.ForceUpdateHatredTargetTimer = hatredConfigDataAsset.ForceUpdateHatredTargetTime;
			SetTargetInfoByHatred();
		}
	}

	private void CalculateTargetHatredValueByDamage(AActor AttackerTarget, int SkillID, float DamageValue)
	{
		BGWHatredConfigDataAsset hatredConfigDataAsset = HatredCacheData.HatredConfigDataAsset;
		if (hatredConfigDataAsset == null)
		{
			return;
		}
		bool flag = false;
		UnitHatredTargetInfo hatredTargetInfo = HatredData.GetHatredTargetInfo(AttackerTarget);
		if (hatredTargetInfo.HatredTargetEntity == Entity.Null)
		{
			if (JudgeActorCanBeHatredActor(AttackerTarget) && hatredTargetInfo.HatredTargetEntity == Entity.Null && TryAddUnitIntoHatredList(AttackerTarget))
			{
				flag = true;
			}
		}
		else
		{
			flag = true;
		}
		if (!flag)
		{
			return;
		}
		float num = ((AttrContainerData.GetFloatValue(EBGUAttrFloat.HpMax) > 0f) ? AttrContainerData.GetFloatValue(EBGUAttrFloat.HpMax) : 1f);
		float num2 = DamageValue / num * (float)hatredConfigDataAsset.CommonCorrectionFactor;
		hatredTargetInfo.HatredValueBase += num2;
		BGUCharacterCS bGUCharacterCS = AttackerTarget as BGUCharacterCS;
		FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(SkillID, AttackerTarget);
		if (bGUCharacterCS != null && skillSDesc != null)
		{
			int AttackerResID = bGUCharacterCS.GetResID();
			if (hatredConfigDataAsset.HatredBattleBlackList.ToList().Find((int i) => i == AttackerResID) == 0)
			{
				hatredTargetInfo.HatredValueSkillExtra = Math.Max(skillSDesc.AdditionalHatredValue, hatredTargetInfo.HatredValueSkillExtra);
			}
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			string text = $"<action>单位</><character> {Owner.GetFName()} </><action>受到单位</><character> {AttackerTarget.GetFName()} </><action>技能攻击</>";
			text += $"<action>, 技能ID是：</><effect> {SkillID} </><action>, 对单位</><character> {AttackerTarget.GetFName()} </><action>增加伤害仇恨</><effect>{num2}</>";
			text += $"<action>，技能附加值刷新为</><effect>{hatredTargetInfo.HatredValueSkillExtra}</>";
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.HatredEvent, text);
		}
		bool bNeedUpdateTarget = HatredData.GetTaunterList().Count <= 0;
		CalculateTargetHatredFinalValue(b1.ECalcFinalValueReason.BeAttacked, bNeedUpdateTarget);
	}

	private void SetTargetInfoByHatred()
	{
		GSBindList<UnitHatredTargetInfo> hatredTargetInfoList = HatredData.GetHatredTargetInfoList();
		int count = hatredTargetInfoList.Count;
		if (count <= 0)
		{
			return;
		}
		int num = 0;
		int num2 = FMath.Min(AIData.HatredTargetRandomSelectNum, count);
		List<UnitHatredTargetInfo> list = hatredTargetInfoList.ToList();
		list.Sort((UnitHatredTargetInfo x, UnitHatredTargetInfo y) => y.HatredValueFinal.CompareTo(x.HatredValueFinal));
		if (num2 > 1)
		{
			float num3 = 0f;
			for (int num4 = 0; num4 < num2; num4++)
			{
				num3 += list[num4].HatredValueFinal;
			}
			float num5 = 0f;
			for (int num6 = 0; num6 < num2; num6++)
			{
				float num7 = FMath.RandRange(0f, num3);
				if (num5 < num7 && num7 < num5 + list[num6].HatredValueFinal)
				{
					num = num6;
					break;
				}
				num5 += list[num6].HatredValueFinal;
			}
		}
		else
		{
			num = -1;
			for (int num8 = 0; num8 < count; num8++)
			{
				if (BGUFuncLibAICS.JudgeActorCanBeAITarget(Owner, list[num8].HatredTargetActor, TeamRelationData, HatredCacheData))
				{
					num = num8;
					break;
				}
			}
		}
		if (num >= 0 && (BossControlData == null || BossControlData.CanBossCatchTarget(list[num].HatredTargetActor, ETargetSourceType.Target_ByHatred)))
		{
			BGUFunctionLibraryCS.BGUSetTargetInfo(IsOnline(), Owner, new UnitLockTargetInfo(list[num].HatredTargetActor, ETargetSourceType.Target_ByHatred));
		}
	}

	private bool JudgeActorCanBeHatredActor(AActor TargetActor)
	{
		if (TargetActor == null)
		{
			return false;
		}
		if (Owner == TargetActor)
		{
			return false;
		}
		if (BossControlData != null && !BossControlData.CanBossCatchTarget(TargetActor, ETargetSourceType.Target_ByHatred))
		{
			return false;
		}
		if (BGUFunctionLibraryCS.BGUHasUnitState(TargetActor, EBGUUnitState.Dead) || BGUFunctionLibraryCS.BGUHasUnitSimpleState(TargetActor, EBGUSimpleState.PendingDeathInAnimationSyncing))
		{
			return false;
		}
		if (TeamRelationData != null && !TeamRelationData.IsEnemyTeam(Owner, TargetActor))
		{
			return false;
		}
		BUC_FallDyingData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_FallDyingData>(TargetActor);
		if (readOnlyData != null && readOnlyData.GetFallDyingState() != EFallDyingState.Alive)
		{
			return false;
		}
		if (!(TargetActor is BGUPlayerCharacterCS))
		{
			bool flag = false;
			b1.IBUC_SummonBehaviorData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_SummonBehaviorData, b1.BUC_SummonBehaviorData>(TargetActor);
			if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.IsServant() && unPersistentReadOnlyData.SpecialSummonBehaviorType == b1.ESpecialSummonBehaviorType.PhantomRush)
			{
				flag = true;
			}
			if (!flag)
			{
				IBUC_BattleStateData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>(TargetActor);
				if (readOnlyData2 != null && !readOnlyData2.IsUnitInBattle())
				{
					return false;
				}
			}
		}
		return true;
	}

	private void OnTriggerBeTaunted(AActor Taunter, bool IsReMove)
	{
		if (IsReMove)
		{
			HatredData.ReMoveTaunter(ECSExtension.ToEntity(Taunter));
		}
		else
		{
			HatredData.AddTaunter(ECSExtension.ToEntity(Taunter));
		}
	}

	private void OnUnitCastSkillSuccess(int MappingSkillID, int OriSkillID, ECastSkillSourceType SourceType)
	{
		if (Owner == null)
		{
			return;
		}
		GSBindList<UnitHatredTargetInfo> hatredTargetInfoList = HatredData.GetHatredTargetInfoList();
		if (hatredTargetInfoList == null || hatredTargetInfoList.Count == 0)
		{
			return;
		}
		BGWHatredConfigDataAsset hatredConfigDataAsset = HatredCacheData.HatredConfigDataAsset;
		if (hatredConfigDataAsset == null)
		{
			return;
		}
		Entity lockTargetEntity = TargetInfoData.GetTargetInfo().LockTargetEntity;
		for (int i = 0; i < hatredTargetInfoList.Count; i++)
		{
			if (hatredTargetInfoList[i].HatredTargetEntity == lockTargetEntity)
			{
				hatredTargetInfoList[i].HatredValueBase -= hatredConfigDataAsset.ReduceHatredValueWhenCastSkillSuccess;
				if (DebugConfig.IsOpenBattleInfoTool)
				{
					string battleInfoLog = $"<action>单位</><character> {Owner.GetFName()} </><action>释放技能成功！对当前目标</><character> {ECSExtension.ToActor(lockTargetEntity).GetFName()} </><action>减少基础仇恨值</><effect>{hatredConfigDataAsset.ReduceHatredValueWhenCastSkillSuccess}</>";
					BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.HatredEvent, battleInfoLog);
				}
				CalculateTargetHatredFinalValue(b1.ECalcFinalValueReason.CastSkillSuccess, bNeedUpdateTarget: false);
				break;
			}
		}
	}

	private void OnEnableCanUpdateHatred(bool bEnable)
	{
		HatredData.SetEnableUpdateHatred(bEnable);
	}

	private void OnSetCanSetTargetByHatred(bool bEnable)
	{
		HatredData.SetCanSetTargetByHatred(bEnable);
	}

	private void OnClearHatredList()
	{
		if (Owner == null)
		{
			return;
		}
		HatredData.SetCanSetTargetByHatred(bEnable: true);
		if (HatredData.IsHatredTargetInfoListEmpty)
		{
			return;
		}
		GSBindList<UnitHatredTargetInfo> hatredTargetInfoList = HatredData.GetHatredTargetInfoList();
		for (int num = hatredTargetInfoList.Count - 1; num >= 0; num--)
		{
			UnitHatredTargetInfo unitHatredTargetInfo = hatredTargetInfoList[num];
			if (unitHatredTargetInfo != null)
			{
				AActor hatredTargetActor = unitHatredTargetInfo.HatredTargetActor;
				TryClearHatredInfo(hatredTargetActor);
			}
		}
		if (BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(Owner))
		{
			HatredData.ClearHatredTargetInfoList();
			HatredData.ClearPlayerHatredEntityList();
		}
	}

	private void OnLeaveFight()
	{
		OnClearHatredList();
		OnClearAllTarget();
		OnForceLevelBattle();
	}

	private void OnNotifyCopyHatredInfo(AActor OriginActor, AActor CopyActor, bool bRemoveOriginHatredInfo)
	{
		if (HatredData.GetHatredTargetInfoList().Count == 0 || !(OriginActor != null) || !(CopyActor != null))
		{
			return;
		}
		int Idx;
		UnitHatredTargetInfo hatredTargetInfoByID = HatredData.GetHatredTargetInfoByID(OriginActor, out Idx);
		if (hatredTargetInfoByID.HatredTargetEntity != Entity.Null)
		{
			if (bRemoveOriginHatredInfo)
			{
				TryAddUnitIntoHatredList(CopyActor, hatredTargetInfoByID, 1f);
				TryClearHatredInfo(OriginActor);
			}
			else
			{
				TryAddUnitIntoHatredList(CopyActor, hatredTargetInfoByID, 2f, Math.Abs(hatredTargetInfoByID.HatredValueFinal));
			}
		}
	}

	private void TickForValidUnit()
	{
		BattleStateData.TickForValidUnit();
	}

	private void NotifyBattleStateChange(bool OldBattleState)
	{
		bool flag = BattleStateData.IsUnitInBattle();
		if (OldBattleState == flag)
		{
			return;
		}
		if (flag)
		{
			DoRoleDataUnitInBattleLogic();
			UpdateOnlineAssistInBattleLogic();
		}
		if (base.BGSEventCollection != null && base.BGSEventCollection.HasBeginPlay)
		{
			string finalGuid = GuidData.GetFinalGuid();
			int finalBattleInfoExtendID = GetFinalBattleInfoExtendID();
			if (flag)
			{
				bool canForceLeaveBattle = false;
				if (!BattleStateData.IsPlayerUnit)
				{
					canForceLeaveBattle = BGUFuncLibAICS.BGUCheckCanTriggerForceReturnHome(GetActorResID(), ((BGUCharacterCS)GetOwner()).GetFinalBattleInfoExtendID(), GuidData.GetFinalGuid(), AIData, in GroupAIData, in FollowPartnerData, in GlobalBattleStateData, in TamerData);
				}
				base.BGSEventCollection.Evt_BGS_UnitInBattle.Invoke(OwnerAsCharacterCS, finalGuid, finalBattleInfoExtendID, canForceLeaveBattle);
			}
			else
			{
				base.BGSEventCollection.Evt_BGS_UnitLeaveBattle.Invoke(finalGuid, finalBattleInfoExtendID);
			}
		}
		if (base.BUSEventCollection != null)
		{
			base.BUSEventCollection.Evt_NotifyBattleStateChange.Invoke(flag);
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			string text = (OldBattleState ? "在战斗" : "脱战");
			string text2 = (flag ? "在战斗" : "脱战");
			string text3 = (BattleStateData.IsPlayerUnit ? "玩家角色" : "非玩家角色");
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BattleState, "<effect>【" + text3 + "】</><character>" + Owner.GetName() + "</><action>的战斗状态发生变化！原来是：</><effect>" + text + "</><action>, 现在是：</><effect>" + text2 + "</>");
		}
	}

	private void UpdateOnlineAssistInBattleLogic()
	{
		if (!(Owner is ABGUCharacter aBGUCharacter))
		{
			return;
		}
		List<BGUCharacterCS> allPlayerActors = BGU_UnrealWorldUtil.GetAllPlayerActors(Owner);
		int commLogicCfgValue = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.TujianDistance);
		foreach (BGUCharacterCS item in allPlayerActors)
		{
			if (!item.HasAuthority())
			{
				break;
			}
			if (FVector.Distance(BGUFuncLibActorTransformCS.BGUGetActorLocation(item), BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner)) < (float)commLogicCfgValue && aBGUCharacter.GetTeamID() != item.GetTeamID())
			{
				base.BGSEventCollection.Evt_EncounterUnit.Invoke(BGU_DataUtil.GetActorGuid(aBGUCharacter));
			}
		}
	}

	private void DoRoleDataUnitInBattleLogic()
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (!(bGUCharacterCS != null))
		{
			return;
		}
		BGUPlayerCharacterCS bGUPlayerCharacterCS = UGameplayStatics.GetPlayerCharacter(bGUCharacterCS, 0) as BGUPlayerCharacterCS;
		APlayerController aPlayerController = bGUPlayerCharacterCS?.GetController() as APlayerController;
		if (aPlayerController != null && bGUCharacterCS.GetTeamIDInCS() != bGUPlayerCharacterCS.GetTeamIDInCS())
		{
			int actorResID = BGU_DataUtil.GetActorResID(GetOwner());
			int finalBattleInfoExtendID = BGU_DataUtil.GetFinalBattleInfoExtendID(GetOwner());
			if (PlayerCollectionHelper.IsFirstSight(BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(aPlayerController).RoleData.RoleCs, actorResID, finalBattleInfoExtendID))
			{
				BTF_EventCollectionCS.Get(aPlayerController.PlayerState)?.Evt_ActorUnitEncounterReq(new CSMsgActorUnitEncounterReq
				{
					UnitId = actorResID,
					OverrideId = finalBattleInfoExtendID
				}, null);
			}
		}
	}

	private void ResetCacheTargetInfoAndHatredInfo()
	{
		BattleStateData.HasTarget_ForMonster = false;
		BattleStateData.HasHatred_ForMonster = false;
		BattleStateData.PlayerAsTarget_ForMonster = null;
		BattleStateData.PlayerInHatredList_ForMonster = new List<AActor>();
	}

	private void OnCollectCatchTargetAsPlayerInfo(AActor InvokerActor)
	{
		IBUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AIData, BUC_AIData>(InvokerActor);
		if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.CanEffectPlayerBattleState)
		{
			bool oldBattleState = BattleStateData.IsUnitInBattle();
			BattleStateData.CollectCatchTargetInfo(InvokerActor);
			NotifyBattleStateChange(oldBattleState);
		}
	}

	private void OnCollectAddHatredUnitAsPlayerInfo(AActor InvokerActor)
	{
		IBUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AIData, BUC_AIData>(InvokerActor);
		if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.CanEffectPlayerBattleState)
		{
			bool oldBattleState = BattleStateData.IsUnitInBattle();
			BattleStateData.CollectAddHatredInfo(InvokerActor);
			NotifyBattleStateChange(oldBattleState);
		}
	}

	private void OnClearCollectedTargetInfo(AActor InvokerActor)
	{
		bool oldBattleState = BattleStateData.IsUnitInBattle();
		BattleStateData.ClearCollectedTargetInfo(InvokerActor);
		NotifyBattleStateChange(oldBattleState);
	}

	private void OnClearCollectedHatredInfo(AActor InvokerActor)
	{
		bool oldBattleState = BattleStateData.IsUnitInBattle();
		BattleStateData.ClearCollectedHatredInfo(InvokerActor);
		NotifyBattleStateChange(oldBattleState);
	}

	private void OnForceLevelBattle()
	{
		bool oldBattleState = BattleStateData.IsUnitInBattle();
		ResetCacheTargetInfoAndHatredInfo();
		NotifyBattleStateChange(oldBattleState);
	}
}
