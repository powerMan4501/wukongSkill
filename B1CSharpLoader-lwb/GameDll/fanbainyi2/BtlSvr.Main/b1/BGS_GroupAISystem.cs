using System;
using System.Collections.Generic;
using System.Linq;
using b1.BGW;
using b1.ECS;
using b1.EventDelDefine;
using BtlB1;
using Diana.Common;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGS_GroupAISystem : GameStateSystemBase
{
	private int ReqID;

	private Entity PlayerActorEntityForDebug;

	private BGC_GroupAIMgrData GroupAIMgrData;

	private IBGC_AnimationSyncData AnimationSyncData;

	private IBGC_LocalPlayerSharedData LocalPlayerSharedData;

	private TStrongObjectPtr<UMaterial> mGroupAIHotZoneDebugMat = new TStrongObjectPtr<UMaterial>();

	private const string HotZoneDebugMatPath = "Material'/Game/00Main/Design/AI/GroupAI/M_AIViewBoard.M_AIViewBoard'";

	private const string AIMgrConfigPath = "BGWGroupAIMgrConfigDataAsset'/Game/00Main/Design/AI/GroupAI/BP_GroupAIConfig_Default.BP_GroupAIConfig_Default'";

	private const string HotZoneConfigPath = "BGWGroupAIBattleHotZoneConfigDataAsset'/Game/00Main/Design/AI/GroupAI/BP_GroupAIHotZoneConfig_Default.BP_GroupAIHotZoneConfig_Default'";

	private UMaterial GroupAIHotZoneDebugMat
	{
		get
		{
			return mGroupAIHotZoneDebugMat.Get();
		}
		set
		{
			mGroupAIHotZoneDebugMat.Set(value);
		}
	}

	public override void OnAttach()
	{
		GroupAIMgrData = RequireWritableData<BGC_GroupAIMgrData>();
		AnimationSyncData = RequireReadOnlyGameStateData<IBGC_AnimationSyncData, BGC_AnimationSyncData>();
		LocalPlayerSharedData = RequireReadOnlyGameStateData<IBGC_LocalPlayerSharedData, BGC_LocalPlayerSharedData>();
		base.BGSEventCollection.Evt_BGS_AddPerformerInfoToList += new Del_Void_Actor(OnAddPerformerInfoToList);
		base.BGSEventCollection.Evt_BGS_RemovePerformerInList += new Del_RemovePerformerInList(OnRemovePerformerInList);
		base.BGSEventCollection.Evt_BGS_SetNewConfigDataAsset += new Del_SetNewConfigDataAsset(OnSetNewConfigDataAsset);
		base.BGSEventCollection.Evt_BGS_Try2RecoverDefaultConfigDataAsset += new Del_Void_Actor(OnTry2RecoverDefaultConfigDataAsset);
		base.BGSEventCollection.Evt_BGS_RecoverAttackToken += new Del_RecoverAttackToken(OnRecoverAttackToken);
		base.BGSEventCollection.Evt_BGS_InitiatePriorityActionQue += new Del_InitiatePriorityActionQue(OnInitiatePriorityActionQue);
		base.BGSEventCollection.Evt_BGS_SetCanTriggerGroupAI += new Del_Void_Bool(OnSetCanTriggerGroupAI);
		base.BGSEventCollection.Evt_BGS_ChangeHotZonePointSelectionStatus += new Del_ChangeHotZonePointSelectionStatus(OnChangeHotZonePointSelectionStatus);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.BGSEventCollection.Evt_BGS_AddPerformerInfoToList -= new Del_Void_Actor(OnAddPerformerInfoToList);
		base.BGSEventCollection.Evt_BGS_RemovePerformerInList -= new Del_RemovePerformerInList(OnRemovePerformerInList);
		base.BGSEventCollection.Evt_BGS_SetNewConfigDataAsset -= new Del_SetNewConfigDataAsset(OnSetNewConfigDataAsset);
		base.BGSEventCollection.Evt_BGS_Try2RecoverDefaultConfigDataAsset -= new Del_Void_Actor(OnTry2RecoverDefaultConfigDataAsset);
		base.BGSEventCollection.Evt_BGS_RecoverAttackToken -= new Del_RecoverAttackToken(OnRecoverAttackToken);
		base.BGSEventCollection.Evt_BGS_InitiatePriorityActionQue -= new Del_InitiatePriorityActionQue(OnInitiatePriorityActionQue);
		base.BGSEventCollection.Evt_BGS_SetCanTriggerGroupAI -= new Del_Void_Bool(OnSetCanTriggerGroupAI);
		base.BGSEventCollection.Evt_BGS_ChangeHotZonePointSelectionStatus -= new Del_ChangeHotZonePointSelectionStatus(OnChangeHotZonePointSelectionStatus);
		if (GroupAIHotZoneDebugMat != null)
		{
			mGroupAIHotZoneDebugMat.Set(null);
			GroupAIHotZoneDebugMat = null;
		}
	}

	public override void PreBeginPlay()
	{
		ReqID = 0;
		PlayerActorEntityForDebug = Entity.Null;
		BGWGroupAIMgrConfigDataAsset bGWGroupAIMgrConfigDataAsset = null;
		BGWGroupAIBattleHotZoneConfigDataAsset bGWGroupAIBattleHotZoneConfigDataAsset = null;
		BGW_WorldSettings bGW_WorldSettings = Owner.World.GetWorldSettings().Cast<BGW_WorldSettings>();
		if (bGW_WorldSettings != null)
		{
			bGWGroupAIMgrConfigDataAsset = bGW_WorldSettings.DefaultGroupAIMgrConfigDataAsset;
			bGWGroupAIBattleHotZoneConfigDataAsset = bGW_WorldSettings.DefaultGroupAIBattleHotZoneConfigDataAsset;
		}
		if (bGWGroupAIMgrConfigDataAsset == null)
		{
			bGWGroupAIMgrConfigDataAsset = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<BGWGroupAIMgrConfigDataAsset>("BGWGroupAIMgrConfigDataAsset'/Game/00Main/Design/AI/GroupAI/BP_GroupAIConfig_Default.BP_GroupAIConfig_Default'", ELoadResourceType.SyncLoadAndCache);
		}
		GroupAIMgrData.SetGroupAIMgrConfigDataAsset(bGWGroupAIMgrConfigDataAsset, bUpdateOri: true);
		if (bGWGroupAIBattleHotZoneConfigDataAsset == null)
		{
			bGWGroupAIBattleHotZoneConfigDataAsset = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<BGWGroupAIBattleHotZoneConfigDataAsset>("BGWGroupAIBattleHotZoneConfigDataAsset'/Game/00Main/Design/AI/GroupAI/BP_GroupAIHotZoneConfig_Default.BP_GroupAIHotZoneConfig_Default'", ELoadResourceType.SyncLoadAndCache);
		}
		GroupAIMgrData.SetGroupAIBattleHotZoneConfigDataAsset(bGWGroupAIBattleHotZoneConfigDataAsset, bUpdateOri: true);
		GroupAIMgrData.CanTriggerGroupAI = true;
		GroupAIMgrData.IsEnableGroupAI = false;
		GroupAIMgrData.IsNoMoveAttack = false;
		GroupAIMgrData.UpdateTimer = 0f;
		GroupAIMgrData.UpdateDurationForAllocHotZonePoint = 0f;
		GroupAIMgrData.TotalMeleeAttackTokenNum = 0;
		GroupAIMgrData.TotalRangeAttackTokenNum = 0;
		GroupAIMgrData.BeginRecover2DefaultConfig = false;
		GroupAIMgrData.BeginRecover2DefaultConfigTimer = 3f;
		GroupAIMgrData.CurrentUseGroupAIConfigAreaID = -1;
		GroupAIMgrData.NeedReDrawDebugPanel = false;
		if (GroupAIMgrData.GroupAIMgrConfigDataAsset != null)
		{
			GroupAIMgrData.TotalMeleeAttackTokenNum = GroupAIMgrData.GroupAIMgrConfigDataAsset.MeleeAttackTokenNum;
			GroupAIMgrData.TotalRangeAttackTokenNum = GroupAIMgrData.GroupAIMgrConfigDataAsset.RangeAttackTokenNum;
		}
	}

	private void OnSetCanTriggerGroupAI(bool CanTrigger)
	{
		GroupAIMgrData.CanTriggerGroupAI = CanTrigger;
	}

	private void OnChangeHotZonePointSelectionStatus(EGroupAIHotZoneType HZType, HotZonePointInfo PointInfo, bool IsSelect)
	{
		if (GroupAIMgrData.HotZonePointInfoDict.TryGetValue(HZType, out var value) && value.HotZonePointInfoList.Contains(PointInfo))
		{
			int index = value.HotZonePointInfoList.IndexOf(PointInfo);
			HotZonePointInfo value2 = value.HotZonePointInfoList[index];
			value2.HasAlreadyBeenSelected = IsSelect;
			value.HotZonePointInfoList[index] = value2;
			value.SelectNum = (IsSelect ? value.SelectNum++ : value.SelectNum--);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!(GroupAIMgrData.GroupAIMgrConfigDataAsset == null) && UGSE_EngineFuncLib.IsStandAlone(UGSE_EngineFuncLib.GetWorldFromObj(Owner)))
		{
			UpdateForHotZoneDebug();
			UpdateForObserveBattlefield(DeltaTime);
			UpdateForEnableGroupAI();
			UpdateForRecover2DefaultConfig(DeltaTime);
		}
	}

	private void UpdateForHotZoneDebug()
	{
		if (GSGameplayCVar.CVar_GroupAIDebugInfoEnableHotZoneDebug.GetValueInGameThread() != 0)
		{
			if (GroupAIHotZoneDebugMat == null)
			{
				GroupAIHotZoneDebugMat = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UMaterial>("Material'/Game/00Main/Design/AI/GroupAI/M_AIViewBoard.M_AIViewBoard'", ELoadResourceType.SyncLoadAndCache);
			}
			if (GroupAIHotZoneDebugMat == null || GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset == null)
			{
				return;
			}
			FVector cachedLocalPlayerLocation = LocalPlayerSharedData.CachedLocalPlayerLocation;
			FRotator cachedLocalPlayerRotation = LocalPlayerSharedData.CachedLocalPlayerRotation;
			FRotator cachedLocalPlayerCameraRotation = LocalPlayerSharedData.CachedLocalPlayerCameraRotation;
			foreach (KeyValuePair<EGroupAIHotZoneType, HotZonePointInfoWrap> item in GroupAIMgrData.HotZonePointInfoDict)
			{
				foreach (HotZonePointInfo hotZonePointInfo in item.Value.HotZonePointInfoList)
				{
					FVector center = BGUFuncLibAICS.BGUGetHotZonePointWorldLocation(cachedLocalPlayerLocation, cachedLocalPlayerRotation, cachedLocalPlayerCameraRotation, hotZonePointInfo.RelativePos);
					FLinearColor lineColor = FLinearColor.Black;
					if (hotZonePointInfo.HotZoneIdx == EGroupAIHotZoneType.ShortDistanceAtkHotZone)
					{
						lineColor = FLinearColor.Orange;
					}
					else if (hotZonePointInfo.HotZoneIdx == EGroupAIHotZoneType.MeleeAtkHotZone)
					{
						lineColor = FLinearColor.Red;
					}
					else if (hotZonePointInfo.HotZoneIdx == EGroupAIHotZoneType.MiddleDistanceAtkHotZone)
					{
						lineColor = FLinearColor.Green;
					}
					else if (hotZonePointInfo.HotZoneIdx == EGroupAIHotZoneType.RangeAtkHotZone)
					{
						lineColor = FLinearColor.DarkGreen;
					}
					else if (hotZonePointInfo.HotZoneIdx == EGroupAIHotZoneType.LongDistanceAtkHotZone)
					{
						lineColor = FLinearColor.Blue;
					}
					USystemLibrary.DrawDebugSphere(Owner, center, 50f, 12, lineColor, 0f, 0f);
				}
			}
			foreach (KeyValuePair<EGroupAIHotZoneType, List<HotZonePointInfo>> item2 in GroupAIMgrData.HotZoneWayPointInfoDict)
			{
				foreach (HotZonePointInfo item3 in item2.Value)
				{
					FVector center2 = BGUFuncLibAICS.BGUGetHotZonePointWorldLocation(cachedLocalPlayerLocation, cachedLocalPlayerRotation, cachedLocalPlayerCameraRotation, item3.RelativePos);
					USystemLibrary.DrawDebugBox(Owner, center2, new FVector(100f), FLinearColor.DarkOrange, FRotator.ZeroRotator);
				}
			}
			int shortBattleCircleRadius = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.ShortBattleCircleRadius;
			int middleBattleCircleRadius = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.MiddleBattleCircleRadius;
			int longBattleCircleRadius = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.LongBattleCircleRadius;
			int meleeAttackHotZoneInnerRadius = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.MeleeAttackHotZoneInnerRadius;
			int meleeAttackHotZoneOneSideAngle = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.MeleeAttackHotZoneOneSideAngle;
			int rangeAttackHotZoneOneSideAngle = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.RangeAttackHotZoneOneSideAngle;
			APawn firstLocalPlayerPawn = LocalPlayerSharedData.FirstLocalPlayerPawn;
			Entity entity = ECSUtil.ToEntity(firstLocalPlayerPawn);
			if (PlayerActorEntityForDebug != entity || GroupAIMgrData.NeedReDrawDebugPanel)
			{
				PlayerActorEntityForDebug = entity;
				if (!(GroupAIHotZoneDebugMat != null))
				{
					return;
				}
				List<UActorComponent> componentsByTag = firstLocalPlayerPawn.GetComponentsByTag(UClass.GetClass<UStaticMeshComponent>(), B1GlobalFNames.GroupAIDebug);
				if (componentsByTag != null && componentsByTag.Count > 0 && componentsByTag[0] is UStaticMeshComponent uStaticMeshComponent)
				{
					UMaterialInstanceDynamic uMaterialInstanceDynamic = UMaterialLibrary.CreateDynamicMaterialInstance(Owner, GroupAIHotZoneDebugMat, FName.None, EMIDCreationFlags.None);
					if (uMaterialInstanceDynamic != null)
					{
						uMaterialInstanceDynamic.SetScalarParameterValue(B1GlobalFNames.Area1DiametersInMeter, shortBattleCircleRadius * 2 / 100);
						uMaterialInstanceDynamic.SetScalarParameterValue(B1GlobalFNames.Area2DiametersInMeter, meleeAttackHotZoneInnerRadius * 2 / 100);
						uMaterialInstanceDynamic.SetScalarParameterValue(B1GlobalFNames.Area3DiametersInMeter, middleBattleCircleRadius * 2 / 100);
						uMaterialInstanceDynamic.SetScalarParameterValue(B1GlobalFNames.Area5DiametersInMeter, longBattleCircleRadius * 2 / 100);
						uMaterialInstanceDynamic.SetScalarParameterValue(B1GlobalFNames.Area2Degree, meleeAttackHotZoneOneSideAngle * 2);
						uMaterialInstanceDynamic.SetScalarParameterValue(B1GlobalFNames.Area4Degree, rangeAttackHotZoneOneSideAngle * 2);
						uStaticMeshComponent.SetRelativeScale3D(FVector.OneVector * longBattleCircleRadius * 2.0 / 100.0);
						uStaticMeshComponent.SetMaterial(0, uMaterialInstanceDynamic);
						uStaticMeshComponent.SetVisibility(bNewVisibility: true);
						uStaticMeshComponent.SetHiddenInGame(NewHidden: false);
						GroupAIMgrData.NeedReDrawDebugPanel = false;
					}
				}
			}
			else
			{
				List<UActorComponent> componentsByTag2 = firstLocalPlayerPawn.GetComponentsByTag(UClass.GetClass<UStaticMeshComponent>(), B1GlobalFNames.GroupAIDebug);
				if (componentsByTag2 != null && componentsByTag2.Count > 0 && componentsByTag2[0] is UStaticMeshComponent uStaticMeshComponent2)
				{
					FRotator worldRotation = uStaticMeshComponent2.GetWorldRotation();
					worldRotation.Yaw = cachedLocalPlayerCameraRotation.Yaw;
					uStaticMeshComponent2.SetWorldRotation(worldRotation, bSweep: false, out var _, bTeleport: true);
				}
			}
		}
		else
		{
			if (!(PlayerActorEntityForDebug != Entity.Null))
			{
				return;
			}
			AActor aActor = ECSUtil.ToActor(PlayerActorEntityForDebug);
			if (!aActor.IsNullOrDestroyed())
			{
				List<UActorComponent> componentsByTag3 = aActor.GetComponentsByTag(UClass.GetClass<UStaticMeshComponent>(), B1GlobalFNames.GroupAIDebug);
				if (componentsByTag3 != null)
				{
					UStaticMeshComponent uStaticMeshComponent3 = componentsByTag3[0] as UStaticMeshComponent;
					if (uStaticMeshComponent3 != null)
					{
						uStaticMeshComponent3.SetMaterial(0, null);
						uStaticMeshComponent3.SetVisibility(bNewVisibility: false);
						uStaticMeshComponent3.SetHiddenInGame(NewHidden: true);
					}
				}
			}
			PlayerActorEntityForDebug = Entity.Null;
		}
	}

	private bool CheckPerformerIsValid(GroupAIPerformerInfo PerformerInfo)
	{
		AActor performerActor = PerformerInfo.PerformerActor;
		if (performerActor == null || performerActor.IsNullOrDestroyed())
		{
			return false;
		}
		return true;
	}

	private void UpdateForEnableGroupAI()
	{
		bool flag = false;
		GAAI_EnableGroupAI gAAI_EnableGroupAI = new GAAI_EnableGroupAI();
		if (GroupAIMgrData.IsEnableGroupAI)
		{
			if (!GroupAIMgrData.CanTriggerGroupAI || GroupAIMgrData.GroupAIPerformerInfoDic.Count < GroupAIMgrData.GroupAIMgrConfigDataAsset.PerformerNumToStart)
			{
				flag = true;
				GroupAIMgrData.IsEnableGroupAI = false;
				GroupAIMgrData.IsNoMoveAttack = false;
				GroupAIMgrData.UpdateTimer = 0f;
				GroupAIMgrData.UpdateDurationForAllocHotZonePoint = 0f;
				gAAI_EnableGroupAI.IsEnable = false;
				ClearHotZonePoint();
			}
		}
		else if (GroupAIMgrData.CanTriggerGroupAI && GroupAIMgrData.GroupAIPerformerInfoDic.Count >= GroupAIMgrData.GroupAIMgrConfigDataAsset.PerformerNumToStart)
		{
			flag = true;
			GroupAIMgrData.IsEnableGroupAI = true;
			GroupAIMgrData.IsNoMoveAttack = GroupAIMgrData.GroupAIMgrConfigDataAsset.IsNoMoveAttackInFirstRound;
			GroupAIMgrData.UpdateTimer = GroupAIMgrData.GroupAIMgrConfigDataAsset.UpdateDuration;
			GroupAIMgrData.UpdateDurationForAllocHotZonePoint = GroupAIMgrData.GroupAIMgrConfigDataAsset.UpdateDurationForAllocHotZonePoint;
			gAAI_EnableGroupAI.IsEnable = true;
			GenerateHotZonePoint();
		}
		if (!flag)
		{
			return;
		}
		foreach (KeyValuePair<Entity, GroupAIPerformerInfo> item in GroupAIMgrData.GroupAIPerformerInfoDic.ToList())
		{
			AActor performerActor = item.Value.PerformerActor;
			if (performerActor != null)
			{
				BUS_EventCollectionCS.Get(performerActor)?.Evt_GroupAIRequestTask.Invoke(GenReqID(), 0f, EGroupCMDType.ToggleActivateGroupAI, gAAI_EnableGroupAI, 0f, 0f);
			}
		}
	}

	private void UpdateForObserveBattlefield(float DeltaTime)
	{
		if (!GroupAIMgrData.IsEnableGroupAI)
		{
			return;
		}
		if (AnimationSyncData.IsAnyUnitInAnimationSyncing())
		{
			GroupAIMgrData.UpdateDurationForAllocHotZonePoint = GroupAIMgrData.GroupAIMgrConfigDataAsset.UpdateDurationForAllocHotZonePoint;
			GroupAIMgrData.UpdateTimer = GroupAIMgrData.GroupAIMgrConfigDataAsset.UpdateDuration;
			return;
		}
		GroupAIMgrData.UpdateTimer += DeltaTime;
		GroupAIMgrData.UpdateDurationForAllocHotZonePoint += DeltaTime;
		bool flag = GroupAIMgrData.UpdateDurationForAllocHotZonePoint >= GroupAIMgrData.GroupAIMgrConfigDataAsset.UpdateDurationForAllocHotZonePoint;
		bool flag2 = GroupAIMgrData.UpdateTimer >= GroupAIMgrData.GroupAIMgrConfigDataAsset.UpdateDuration;
		if (!(flag || flag2))
		{
			return;
		}
		List<GroupAIPerformerInfo> PerformerInfos = GroupAIMgrData.GroupAIPerformerInfoDic.Values.ToList();
		APawn firstLocalPlayerPawn = LocalPlayerSharedData.FirstLocalPlayerPawn;
		IBUC_TargetInfoData PlayerTargetInfoData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(firstLocalPlayerPawn);
		FVector cachedLocalPlayerLocation = LocalPlayerSharedData.CachedLocalPlayerLocation;
		FRotator cachedLocalPlayerRotation = LocalPlayerSharedData.CachedLocalPlayerRotation;
		FRotator cachedLocalPlayerCameraRotation = LocalPlayerSharedData.CachedLocalPlayerCameraRotation;
		float timeSeconds = Owner.World.GetTimeSeconds();
		for (int num = PerformerInfos.Count - 1; num >= 0; num--)
		{
			GroupAIPerformerInfo groupAIPerformerInfo = PerformerInfos[num];
			if (!CheckPerformerIsValid(groupAIPerformerInfo))
			{
				PerformerInfos.RemoveAt(num);
				OnRecoverAttackToken(groupAIPerformerInfo.PerformerEntity, ERecoverTokenReason.InValid);
				GroupAIMgrData.GroupAIPerformerInfoDic.Remove(groupAIPerformerInfo.PerformerEntity);
			}
			else
			{
				PerformerInfos[num].CachedLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(groupAIPerformerInfo.PerformerActor);
				if (flag2)
				{
					PerformerInfos[num].Score = CalcScore(groupAIPerformerInfo.PerformerActor, PerformerInfos[num].CachedLocation, cachedLocalPlayerLocation, cachedLocalPlayerRotation, cachedLocalPlayerCameraRotation, timeSeconds, in PlayerTargetInfoData);
				}
				if (flag)
				{
					BUS_EventCollectionCS.Get(groupAIPerformerInfo.PerformerActor)?.Evt_ClearMeleeAttackGroupAIHotZonePoint.Invoke();
				}
			}
		}
		if (flag2)
		{
			GroupAIMgrData.UpdateTimer = 0f;
			if (GroupAIMgrData.TotalMeleeAttackTokenNum > 0 || GroupAIMgrData.TotalRangeAttackTokenNum > 0)
			{
				GrantAttackToken(firstLocalPlayerPawn, ref PerformerInfos);
				GroupAIMgrData.IsNoMoveAttack = false;
			}
		}
		if (!flag)
		{
			return;
		}
		GroupAIMgrData.UpdateDurationForAllocHotZonePoint = 0f;
		for (int i = 0; i <= 2; i++)
		{
			if (PerformerInfos.Count == 0)
			{
				break;
			}
			GrantHotzonePoint(cachedLocalPlayerLocation, cachedLocalPlayerRotation, cachedLocalPlayerCameraRotation, (EGroupAIHotZoneType)(1 << i), ref PerformerInfos);
		}
	}

	private void UpdateForRecover2DefaultConfig(float DeltaTime)
	{
		if (!GroupAIMgrData.BeginRecover2DefaultConfig)
		{
			return;
		}
		GroupAIMgrData.BeginRecover2DefaultConfigTimer -= DeltaTime;
		if (GroupAIMgrData.BeginRecover2DefaultConfigTimer < 0f)
		{
			GroupAIMgrData.BeginRecover2DefaultConfig = false;
			GroupAIMgrData.BeginRecover2DefaultConfigTimer = 3f;
			GroupAIMgrData.CurrentUseGroupAIConfigAreaID = -1;
			GroupAIMgrData.SetGroupAIMgrConfigDataAsset(GroupAIMgrData.OriGroupAIMgrConfigDataAsset);
			GroupAIMgrData.SetGroupAIBattleHotZoneConfigDataAsset(GroupAIMgrData.OriGroupAIBattleHotZoneConfigDataAsset);
			GroupAIMgrData.NeedReDrawDebugPanel = true;
			ClearHotZonePoint();
			if (GroupAIMgrData.IsEnableGroupAI)
			{
				GenerateHotZonePoint();
			}
		}
	}

	private void GrantHotzonePoint(FVector PlayerLocation, FRotator PlayerRotation, FRotator PlayerCamRot, EGroupAIHotZoneType HZType, ref List<GroupAIPerformerInfo> PerformerInfos)
	{
		if (!GroupAIMgrData.HotZonePointInfoDict.TryGetValue(HZType, out var value))
		{
			return;
		}
		float num = -1f;
		if (GroupAIMgrData.HotZoneRadiusInfoDict.TryGetValue(HZType, out var value2))
		{
			num = value2;
		}
		int num2 = (int)Math.Ceiling((float)GroupAIMgrData.GroupAIPerformerInfoDic.Count * 0.1f);
		if (HZType == EGroupAIHotZoneType.RangeAtkHotZone)
		{
			num2 = (int)Math.Ceiling((float)GroupAIMgrData.GroupAIPerformerInfoDic.Count * 0.2f);
		}
		List<HotZonePointInfo> hotZonePointInfoList = value.HotZonePointInfoList;
		for (int num3 = hotZonePointInfoList.Count - 1; num3 >= 0 && PerformerInfos.Count != 0 && num2 != 0; num3--)
		{
			HotZonePointInfo hZPI = hotZonePointInfoList[num3];
			if (hZPI.HasAlreadyBeenSelected)
			{
				continue;
			}
			switch (HZType)
			{
			case EGroupAIHotZoneType.MeleeAtkHotZone:
				if (MathLib.RandomFloatInRange(1f, 10f) > 5f)
				{
					continue;
				}
				break;
			case EGroupAIHotZoneType.ShortDistanceAtkHotZone:
				if (MathLib.RandomFloatInRange(1f, 10f) > 3f)
				{
					continue;
				}
				break;
			case EGroupAIHotZoneType.RangeAtkHotZone:
				if (MathLib.RandomFloatInRange(1f, 10f) > 7f)
				{
					continue;
				}
				break;
			}
			FVector v = BGUFuncLibAICS.BGUGetHotZonePointWorldLocation(PlayerLocation, PlayerRotation, PlayerCamRot, hZPI.RelativePos);
			float num4 = -1f;
			int num5 = -1;
			bool flag = false;
			for (int num6 = PerformerInfos.Count - 1; num6 >= 0; num6--)
			{
				FVector cachedLocation = PerformerInfos[num6].CachedLocation;
				float num7 = FVector.Dist2D(cachedLocation, PlayerLocation);
				if (!flag || !(num7 > num))
				{
					float num8 = FVector.Dist2D(cachedLocation, v);
					if (num4 < 0f || num4 > num8)
					{
						num5 = num6;
						num4 = num8;
					}
					flag = num >= 0f && num7 <= num;
				}
			}
			if (num4 > 0f && num5 >= 0 && PerformerInfos.Count > num5)
			{
				BUS_EventCollectionCS.Get(PerformerInfos[num5].PerformerActor)?.Evt_SetGroupAIWanderHotZonePoint.Invoke(hZPI);
				PerformerInfos.RemoveAt(num5);
				num2--;
			}
		}
	}

	private void GrantAttackToken(AActor PlayerActor, ref List<GroupAIPerformerInfo> PerformerInfos)
	{
		if (PlayerActor == null)
		{
			return;
		}
		PerformerInfos.Sort();
		if (GroupAIMgrData.TotalMeleeAttackTokenNum > 0)
		{
			int num = 0;
			int num2 = PerformerInfos.Count - 1;
			while (num2 >= 0 && GroupAIMgrData.TotalMeleeAttackTokenNum > 0)
			{
				GroupAIPerformerInfo groupAIPerformerInfo = PerformerInfos[num2];
				int num3 = GroupAIMgrData.TotalMeleeAttackTokenNum - groupAIPerformerInfo.CostToken;
				if (num3 >= 0 && GrantGroupAITask2OnePerformer(groupAIPerformerInfo, EGroupAIAttackBias.MeleeAttack))
				{
					GroupAIMgrData.TotalMeleeAttackTokenNum = num3;
					PerformerInfos.RemoveAt(num2);
					num += groupAIPerformerInfo.CostToken;
				}
				num2--;
			}
			if (GroupAIMgrData.TotalMeleeAttackTokenNum > 0 && PerformerInfos.Count > 0 && GroupAIMgrData.GroupAIMgrConfigDataAsset.MinMeleeAttackTokenReplenishedNum > num)
			{
				int num4 = GroupAIMgrData.GroupAIMgrConfigDataAsset.MinMeleeAttackTokenReplenishedNum - num;
				num4 = Math.Max(0, num4 - GroupAIMgrData.GroupAIMgrConfigDataAsset.MinRangeAttackTokenNumWhenReplenished);
				if (num4 > 0)
				{
					int num5 = PerformerInfos.Count - 1;
					while (num5 >= 0 && num4 > 0)
					{
						GroupAIPerformerInfo groupAIPerformerInfo2 = PerformerInfos[num5];
						int num6 = num4 - groupAIPerformerInfo2.CostToken;
						if (num6 >= 0 && groupAIPerformerInfo2.MeleeAtkSkillNum > 0 && GrantGroupAITask2OnePerformer(groupAIPerformerInfo2, EGroupAIAttackBias.MeleeAttack))
						{
							num4 = num6;
							PerformerInfos.RemoveAt(num5);
						}
						num5--;
					}
				}
			}
		}
		if (GroupAIMgrData.TotalRangeAttackTokenNum <= 0 || PerformerInfos.Count <= 0)
		{
			return;
		}
		int num7 = PerformerInfos.Count - 1;
		while (num7 >= 0 && GroupAIMgrData.TotalRangeAttackTokenNum > 0)
		{
			GroupAIPerformerInfo groupAIPerformerInfo3 = PerformerInfos[num7];
			int num8 = GroupAIMgrData.TotalRangeAttackTokenNum - groupAIPerformerInfo3.CostToken;
			if (num8 >= 0 && GrantGroupAITask2OnePerformer(groupAIPerformerInfo3, EGroupAIAttackBias.RangeAttack))
			{
				GroupAIMgrData.TotalRangeAttackTokenNum = num8;
				PerformerInfos.RemoveAt(num7);
			}
			num7--;
		}
	}

	private bool GrantGroupAITask2OnePerformer(GroupAIPerformerInfo PerformerInfo, EGroupAIAttackBias NeedAttackBias)
	{
		bool result = false;
		if (!PerformerInfo.IsAttacking)
		{
			PerformerInfo.IsAttacking = true;
			result = true;
			float beginNoiseTime = ((NeedAttackBias == EGroupAIAttackBias.MeleeAttack) ? GroupAIMgrData.GroupAIMgrConfigDataAsset.NormalTaskBeginNoiseTimeForMeleeAttacker : GroupAIMgrData.GroupAIMgrConfigDataAsset.NormalTaskBeginNoiseTimeForRangeAttacker);
			BUS_EventCollectionCS.Get(PerformerInfo.PerformerActor)?.Evt_GroupAIRequestTask.Invoke(GenReqID(), PerformerInfo.Score, EGroupCMDType.Attack, new GAAI_FSM_2_Attack(NeedAttackBias, PerformerInfo.CostToken, GroupAIMgrData.IsNoMoveAttack), GroupAIMgrData.GroupAIMgrConfigDataAsset.NormalTaskWaitTime, beginNoiseTime);
		}
		return result;
	}

	private float CalcScore(AActor PerformerActor, FVector PerformerActorLocation, FVector PlayerLocation, FRotator PlayerRotation, FRotator PlayerCamRot, float NowTime, in IBUC_TargetInfoData PlayerTargetInfoData)
	{
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorForwardVector(PerformerActor);
		FVector fVector2 = PlayerLocation - PerformerActorLocation;
		float val = UBUS_UtilComm.CalcDegreeFromVectorsProjectInXYPlane(fVector.GetSafeNormal2D(), fVector2.GetSafeNormal2D());
		float num = GroupAIMgrData.GroupAIMgrConfigDataAsset.AngleScoreWeight * MathLib.Cos(val);
		float num2 = 0f;
		if (GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset != null)
		{
			float num3 = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.LongBattleCircleRadius;
			float num4 = FVector.Dist2D(PerformerActorLocation, PlayerLocation);
			num2 = GroupAIMgrData.GroupAIMgrConfigDataAsset.DistanceScoreWeight * (num3 - num4) / num3;
		}
		BUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AIData>(PerformerActor);
		float num5 = unPersistentReadOnlyData?.GetLastAttackTime() ?? 0f;
		float num6 = ((unPersistentReadOnlyData != null) ? (NowTime - num5) : 0f);
		float num7 = FMath.Min(GroupAIMgrData.GroupAIMgrConfigDataAsset.LastAttackPerSecondScoreMax, num6 * GroupAIMgrData.GroupAIMgrConfigDataAsset.LastAttackPerSecondScore);
		float num8 = 0f;
		FUStGroupAISDesc groupAIDesc = BGW_GameDB.GetGroupAIDesc(BGU_DataUtil.GetActorResID(PerformerActor));
		if (groupAIDesc != null)
		{
			switch (GetPerformerLocateHotZoneType(PerformerActorLocation, PlayerLocation, PlayerRotation))
			{
			case EGroupAIHotZoneType.MeleeAtkHotZone:
			case EGroupAIHotZoneType.ShortDistanceAtkHotZone:
				num8 = groupAIDesc.GroupAIShortDisPrioWeight;
				break;
			case EGroupAIHotZoneType.RangeAtkHotZone:
			case EGroupAIHotZoneType.MiddleDistanceAtkHotZone:
				num8 = groupAIDesc.GroupAIMiddleDisPrioWeight;
				break;
			case EGroupAIHotZoneType.LongDistanceAtkHotZone:
				num8 = groupAIDesc.GroupAILongDisPrioWeight;
				break;
			}
		}
		float num9 = (BGUFunctionLibraryCS.BGUIsTargetInView(PlayerLocation, PlayerCamRot, PerformerActorLocation, GroupAIMgrData.GroupAIMgrConfigDataAsset.InViewAngleOneSide) ? GroupAIMgrData.GroupAIMgrConfigDataAsset.InCameraViewportWeight : GroupAIMgrData.GroupAIMgrConfigDataAsset.OutCameraViewportWeight);
		float num10 = 0f;
		if (PlayerTargetInfoData != null)
		{
			UnitLockTargetInfo targetInfo = PlayerTargetInfoData.GetTargetInfo();
			num10 = ((targetInfo.LockTargetActor == PerformerActor && targetInfo.LockTargetWayType == ELockTargetWayType.Manual) ? GroupAIMgrData.GroupAIMgrConfigDataAsset.LockExtraScore : 0f);
		}
		float num11 = 0f;
		IBUC_GroupAIData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_GroupAIData, BUC_GroupAIData>(PerformerActor);
		if (readOnlyData != null)
		{
			num11 = (readOnlyData.IsBossUnit ? GroupAIMgrData.GroupAIMgrConfigDataAsset.BossExtraScore : 0f);
		}
		return (num + num2 + num7) * num8 * num9 + num10 + num11;
	}

	private EGroupAIHotZoneType GetPerformerLocateHotZoneType(FVector PerformerActorLocation, FVector PlayerActorLocation, FRotator PlayerActorRotation)
	{
		if (GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset != null)
		{
			float num = FVector.Dist2D(PerformerActorLocation, PlayerActorLocation);
			float val = BGUFuncLibAICS.BGUCalAngleWith2PointAndDir(PlayerActorLocation, PlayerActorRotation, PerformerActorLocation);
			int shortBattleCircleRadius = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.ShortBattleCircleRadius;
			int middleBattleCircleRadius = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.MiddleBattleCircleRadius;
			int longBattleCircleRadius = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.LongBattleCircleRadius;
			int meleeAttackHotZoneInnerRadius = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.MeleeAttackHotZoneInnerRadius;
			int meleeAttackHotZoneOneSideAngle = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.MeleeAttackHotZoneOneSideAngle;
			int rangeAttackHotZoneOneSideAngle = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.RangeAttackHotZoneOneSideAngle;
			if (num > (float)longBattleCircleRadius)
			{
				return EGroupAIHotZoneType.OutsideHotZone;
			}
			if (num <= (float)longBattleCircleRadius && num > (float)middleBattleCircleRadius)
			{
				return EGroupAIHotZoneType.LongDistanceAtkHotZone;
			}
			if (num <= (float)middleBattleCircleRadius && num > (float)shortBattleCircleRadius)
			{
				if (MathLib.Abs(val) <= (float)rangeAttackHotZoneOneSideAngle)
				{
					return EGroupAIHotZoneType.RangeAtkHotZone;
				}
				return EGroupAIHotZoneType.MiddleDistanceAtkHotZone;
			}
			if (num <= (float)shortBattleCircleRadius)
			{
				if (MathLib.Abs(val) <= (float)meleeAttackHotZoneOneSideAngle && num > (float)meleeAttackHotZoneInnerRadius)
				{
					return EGroupAIHotZoneType.MeleeAtkHotZone;
				}
				return EGroupAIHotZoneType.ShortDistanceAtkHotZone;
			}
		}
		return EGroupAIHotZoneType.None;
	}

	private void GenerateHotZonePoint()
	{
		if (!(GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset == null))
		{
			int longBattleCircleRadius = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.LongBattleCircleRadius;
			int middleBattleCircleRadius = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.MiddleBattleCircleRadius;
			int shortBattleCircleRadius = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.ShortBattleCircleRadius;
			int meleeAttackHotZoneInnerRadius = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.MeleeAttackHotZoneInnerRadius;
			int rangeAttackHotZoneOneSideAngle = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.RangeAttackHotZoneOneSideAngle;
			int meleeAttackHotZoneOneSideAngle = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.MeleeAttackHotZoneOneSideAngle;
			ClearHotZonePoint();
			GenerateOneCircleHotZonePoints(middleBattleCircleRadius, longBattleCircleRadius, 0, GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.LongBattleCircleCustomInfo, GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.LongBattleCircleCustomInfo, EGroupAIHotZoneType.LongDistanceAtkHotZone, EGroupAIHotZoneType.LongDistanceAtkHotZone);
			GenerateOneCircleHotZonePoints(shortBattleCircleRadius, middleBattleCircleRadius, rangeAttackHotZoneOneSideAngle, GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.RangeAttackCircleCustomInfo, GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.MiddleBattleCircleCustomInfo, EGroupAIHotZoneType.RangeAtkHotZone, EGroupAIHotZoneType.MiddleDistanceAtkHotZone);
			GenerateOneCircleHotZonePoints(meleeAttackHotZoneInnerRadius, shortBattleCircleRadius, meleeAttackHotZoneOneSideAngle, GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.MeleeAttackCircleCustomInfo, GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.ShortBattleCircleCustomInfo, EGroupAIHotZoneType.MeleeAtkHotZone, EGroupAIHotZoneType.ShortDistanceAtkHotZone);
		}
	}

	private void GenerateOneCircleHotZonePoints(int InCircleRadius, int OutCircleRadius, int HotZoneOneSideAngle, FGroupAIHotZoneCircleCustomInfo InShapeCustomInfo, FGroupAIHotZoneCircleCustomInfo OutShapeCustomInfo, EGroupAIHotZoneType InShapeHotZoneType, EGroupAIHotZoneType OutShapeHotZoneType)
	{
		GroupAIMgrData.HotZoneRadiusInfoDict[InShapeHotZoneType] = OutCircleRadius;
		GroupAIMgrData.HotZoneRadiusInfoDict[OutShapeHotZoneType] = OutCircleRadius;
		int battleCirclePointRingNum = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.BattleCirclePointRingNum;
		int battleCirclePointAngleInterval = GroupAIMgrData.GroupAIBattleHotZoneConfigDataAsset.BattleCirclePointAngleInterval;
		if (InShapeCustomInfo.EnableCustomSetting)
		{
			battleCirclePointRingNum = InShapeCustomInfo.BattleCirclePointRingNum;
			battleCirclePointAngleInterval = InShapeCustomInfo.BattleCirclePointAngleInterval;
		}
		GenerateCircleHotZonePoints(battleCirclePointRingNum, battleCirclePointAngleInterval, HotZoneOneSideAngle, InCircleRadius, OutCircleRadius, InShapeHotZoneType, IsInShape: true);
		if (OutShapeCustomInfo.EnableCustomSetting)
		{
			battleCirclePointRingNum = OutShapeCustomInfo.BattleCirclePointRingNum;
			battleCirclePointAngleInterval = OutShapeCustomInfo.BattleCirclePointAngleInterval;
		}
		GenerateCircleHotZonePoints(battleCirclePointRingNum, battleCirclePointAngleInterval, HotZoneOneSideAngle, InCircleRadius, OutCircleRadius, OutShapeHotZoneType, IsInShape: false);
		int num = OutCircleRadius - InCircleRadius;
		int num2 = InCircleRadius + num / 2;
		FVector fVector = new FVector(num2, 0.0, 0.0);
		int num3 = 0;
		for (int i = 1; i <= 4; i++)
		{
			FVector v = fVector.RotateAngleAxis(num3, FVector.UpVector);
			List<HotZonePointInfo> value;
			if (num3 <= HotZoneOneSideAngle || 360 - num3 <= HotZoneOneSideAngle)
			{
				if (GroupAIMgrData.HotZoneWayPointInfoDict.TryGetValue(InShapeHotZoneType, out value))
				{
					GroupAIMgrData.HotZoneWayPointInfoDict[InShapeHotZoneType].Add(new HotZonePointInfo(InShapeHotZoneType, new FVector2D(v)));
				}
				else
				{
					GroupAIMgrData.HotZoneWayPointInfoDict[InShapeHotZoneType] = new List<HotZonePointInfo>
					{
						new HotZonePointInfo(InShapeHotZoneType, new FVector2D(v))
					};
				}
			}
			else if (GroupAIMgrData.HotZoneWayPointInfoDict.TryGetValue(OutShapeHotZoneType, out value))
			{
				GroupAIMgrData.HotZoneWayPointInfoDict[OutShapeHotZoneType].Add(new HotZonePointInfo(OutShapeHotZoneType, new FVector2D(v)));
			}
			else
			{
				GroupAIMgrData.HotZoneWayPointInfoDict[OutShapeHotZoneType] = new List<HotZonePointInfo>
				{
					new HotZonePointInfo(OutShapeHotZoneType, new FVector2D(v))
				};
			}
			num3 += 90;
		}
	}

	private void GenerateCircleHotZonePoints(int BattleCirclePointRingNum, int BattleCirclePointAngleInterval, int HotZoneOneSideAngle, int InCircleRadius, int OutCircleRadius, EGroupAIHotZoneType HotZoneType, bool IsInShape)
	{
		if (BattleCirclePointAngleInterval <= 0 || BattleCirclePointRingNum <= 0 || (IsInShape && HotZoneOneSideAngle == 0))
		{
			return;
		}
		FVector zeroVector = FVector.ZeroVector;
		int num = (OutCircleRadius - InCircleRadius) / BattleCirclePointRingNum;
		int num2 = num / 2 + InCircleRadius;
		for (int i = 1; i <= BattleCirclePointRingNum; i++)
		{
			zeroVector.X = num2 + num * (i - 1);
			for (int j = 0; j < 360; j += BattleCirclePointAngleInterval)
			{
				FVector v = zeroVector.RotateAngleAxis(j, FVector.UpVector);
				bool flag = false;
				if (j <= HotZoneOneSideAngle || 360 - j <= HotZoneOneSideAngle)
				{
					if (IsInShape)
					{
						flag = true;
					}
					else if (j == 0 && HotZoneOneSideAngle == 0)
					{
						flag = true;
					}
				}
				else
				{
					flag = !IsInShape;
				}
				if (flag)
				{
					if (!GroupAIMgrData.HotZonePointInfoDict.TryGetValue(HotZoneType, out var _))
					{
						GroupAIMgrData.HotZonePointInfoDict.Add(HotZoneType, new HotZonePointInfoWrap());
					}
					GroupAIMgrData.HotZonePointInfoDict[HotZoneType].HotZonePointInfoList.Add(new HotZonePointInfo(HotZoneType, new FVector2D(v)));
				}
			}
		}
	}

	private void ClearHotZonePoint()
	{
		GroupAIMgrData.HotZonePointInfoDict.Clear();
		GroupAIMgrData.HotZoneRadiusInfoDict.Clear();
		GroupAIMgrData.HotZoneWayPointInfoDict.Clear();
	}

	private int GenReqID()
	{
		ReqID++;
		if (ReqID <= 0)
		{
			ReqID = 1;
		}
		return ReqID;
	}

	private List<AActor> GetExecuteActionValidUnit(int ResID, EPriorityActionUnitType UnitType)
	{
		List<AActor> list = new List<AActor>();
		Dictionary<Entity, AActor> dictionary = new Dictionary<Entity, AActor>();
		foreach (KeyValuePair<Entity, GroupAIPerformerInfo> item in GroupAIMgrData.GroupAIPerformerInfoDic)
		{
			Entity key = item.Key;
			AActor aActor = ECSUtil.ToActor(key);
			if (aActor != null && !dictionary.ContainsKey(key))
			{
				dictionary.Add(key, aActor);
			}
		}
		switch (UnitType)
		{
		case EPriorityActionUnitType.ActivatingGroupAIUnit:
			foreach (AActor value in dictionary.Values)
			{
				list.Add(value);
			}
			break;
		case EPriorityActionUnitType.NoneActivatingGroupAIUnit:
		{
			BGUCharacterCS[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUCharacterCS>(Owner);
			foreach (BGUCharacterCS bGUCharacterCS2 in allActorsOfClass)
			{
				if (bGUCharacterCS2 != null && BGU_DataUtil.GetActorResID(bGUCharacterCS2) == ResID && !dictionary.ContainsKey(ECSUtil.ToEntity(bGUCharacterCS2)))
				{
					list.Add(bGUCharacterCS2);
				}
			}
			break;
		}
		case EPriorityActionUnitType.AllUnit:
		{
			BGUCharacterCS[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUCharacterCS>(Owner);
			foreach (BGUCharacterCS bGUCharacterCS in allActorsOfClass)
			{
				if (bGUCharacterCS != null && BGU_DataUtil.GetActorResID(bGUCharacterCS) == ResID)
				{
					list.Add(bGUCharacterCS);
				}
			}
			break;
		}
		}
		for (int num = list.Count - 1; num >= 0; num--)
		{
			bool flag = true;
			AActor aActor2 = list[num];
			if (aActor2 != null && !BGUFunctionLibraryCS.BGUHasUnitState(aActor2, EBGUUnitState.Dead) && !BGUFunctionLibraryCS.BGUHasUnitSimpleState(aActor2, EBGUSimpleState.PendingDeathInAnimationSyncing))
			{
				flag = false;
			}
			if (flag)
			{
				list.RemoveAt(num);
			}
		}
		return list;
	}

	private List<AActor> FindCanExecutePriorityActionPerformer(int ResID, FPAQI_SelectUnitTypeInfo SelectUnitTypeInfo, EPriorityActionUnitType UnitType)
	{
		List<AActor> list = new List<AActor>();
		list = GetExecuteActionValidUnit(ResID, UnitType);
		switch (SelectUnitTypeInfo.SelectUnitType)
		{
		case EPriorityActionSelectUnitType.AllInWandering:
		{
			for (int num = list.Count - 1; num >= 0; num--)
			{
				bool flag = true;
				AActor aActor = list[num];
				if (aActor != null && !BGU_DataUtil.GetReadOnlyData<IBUC_GroupAIData, BUC_GroupAIData>(aActor).GetIsInPriorityAction() && !BGUFunctionLibraryCS.BGUHasUnitState(aActor, EBGUUnitState.Attacking))
				{
					flag = false;
				}
				if (flag)
				{
					list.RemoveAt(num);
				}
			}
			break;
		}
		case EPriorityActionSelectUnitType.FarFromPlayerAndInScreenSort:
		{
			float OneSideAngle = ((SelectUnitTypeInfo.SelectUnitTypeIntParams != null && SelectUnitTypeInfo.SelectUnitTypeIntParams.Count > 0) ? SelectUnitTypeInfo.SelectUnitTypeIntParams[0] : 60);
			OneSideAngle = FMath.Clamp(OneSideAngle, 0f, 180f);
			if (!(LocalPlayerSharedData.FirstLocalPlayerPawn as ACharacter != null))
			{
				break;
			}
			FVector PlayerPos = LocalPlayerSharedData.CachedLocalPlayerLocation;
			FVector2D PlayerPos2D = new FVector2D(PlayerPos);
			FRotator PlayerCamRot = LocalPlayerSharedData.CachedLocalPlayerCameraRotation;
			list.Sort(delegate(AActor x, AActor y)
			{
				if (x == null && y == null)
				{
					return 0;
				}
				if (x == null)
				{
					return 1;
				}
				if (y == null)
				{
					return -1;
				}
				FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(x);
				FVector fVector3 = BGUFuncLibActorTransformCS.BGUGetActorLocation(y);
				bool flag2 = BGUFunctionLibraryCS.BGUIsTargetInView(PlayerPos, PlayerCamRot, fVector2, OneSideAngle);
				bool flag3 = BGUFunctionLibraryCS.BGUIsTargetInView(PlayerPos, PlayerCamRot, fVector3, OneSideAngle);
				if (flag2 && !flag3)
				{
					return -1;
				}
				if (!flag2 && flag3)
				{
					return 1;
				}
				float num2 = FVector2D.Distance(PlayerPos2D, new FVector2D(fVector2));
				float num3 = FVector2D.Distance(PlayerPos2D, new FVector2D(fVector3));
				if (num2 == num3)
				{
					return 0;
				}
				return (!(num2 > num3)) ? 1 : (-1);
			});
			break;
		}
		}
		if (GSGameplayCVar.CVar_ShowPrioritySelectUnit.GetValueInGameThread() != 0)
		{
			foreach (AActor item in list)
			{
				UCapsuleComponent uCapsuleComponent = item.GetRootComponent() as UCapsuleComponent;
				float radius = ((uCapsuleComponent != null) ? uCapsuleComponent.GetScaledCapsuleRadius() : 200f);
				FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(item);
				USystemLibrary.DrawDebugSphere(Owner, fVector, radius, 20, FLinearColor.Yellow, 5f, 10f);
				if (SelectUnitTypeInfo.SelectUnitType == EPriorityActionSelectUnitType.FarFromPlayerAndInScreenSort && LocalPlayerSharedData.FirstLocalPlayerPawn as ACharacter != null)
				{
					FVector cachedLocalPlayerLocation = LocalPlayerSharedData.CachedLocalPlayerLocation;
					FRotator cachedLocalPlayerCameraRotation = LocalPlayerSharedData.CachedLocalPlayerCameraRotation;
					float angleOneSide = ((SelectUnitTypeInfo.SelectUnitTypeIntParams != null && SelectUnitTypeInfo.SelectUnitTypeIntParams.Count > 0) ? SelectUnitTypeInfo.SelectUnitTypeIntParams[0] : 60);
					if (BGUFunctionLibraryCS.BGUIsTargetInView(cachedLocalPlayerLocation, cachedLocalPlayerCameraRotation, fVector, angleOneSide))
					{
						USystemLibrary.DrawDebugBox(Owner, fVector, new FVector(50.0, 50.0, 500.0), FLinearColor.Black, FRotator.ZeroRotator, 5f, 10f);
					}
				}
			}
		}
		return list;
	}

	private void AssignPriorityAction(in List<OneActionWarpInfo> ActionWarpList, AActor PerformerActor, FVector GoalPos)
	{
		foreach (OneActionWarpInfo ActionWarp in ActionWarpList)
		{
			EGroupPriorityActionType actionType = ActionWarp.ActionType;
			float waitForBeginTime = ActionWarp.WaitForBeginTime;
			float beginNoiseTime = ActionWarp.BeginNoiseTime;
			switch (actionType)
			{
			case EGroupPriorityActionType.MoveToPos:
			{
				GAAI_PRIO_ACT_MoveToPos gAAI_PRIO_ACT_MoveToPos = new GAAI_PRIO_ACT_MoveToPos(ActionWarp.GroupAIActionInfo as GAAI_PRIO_ACT_MoveToPos);
				gAAI_PRIO_ACT_MoveToPos.GoalPos = GoalPos;
				BUS_EventCollectionCS.Get(PerformerActor).Evt_GroupAIRequestTask.Invoke(GenReqID(), 0f, EGroupCMDType.PRIO_ACT_MoveTo, gAAI_PRIO_ACT_MoveToPos, waitForBeginTime, beginNoiseTime);
				break;
			}
			case EGroupPriorityActionType.CastSkill:
			{
				GAAI_PRIO_ACT_CastSkill groupAIActionInfo2 = new GAAI_PRIO_ACT_CastSkill(ActionWarp.GroupAIActionInfo as GAAI_PRIO_ACT_CastSkill);
				BUS_EventCollectionCS.Get(PerformerActor).Evt_GroupAIRequestTask.Invoke(GenReqID(), 0f, EGroupCMDType.PRIO_ACT_CastSkill, groupAIActionInfo2, waitForBeginTime, beginNoiseTime);
				break;
			}
			case EGroupPriorityActionType.AddBuff:
			{
				GAAI_PRIO_ACT_AddBuff groupAIActionInfo = new GAAI_PRIO_ACT_AddBuff(ActionWarp.GroupAIActionInfo as GAAI_PRIO_ACT_AddBuff);
				BUS_EventCollectionCS.Get(PerformerActor).Evt_GroupAIRequestTask.Invoke(GenReqID(), 0f, EGroupCMDType.PRIO_ACT_AddBuff, groupAIActionInfo, waitForBeginTime, beginNoiseTime);
				break;
			}
			}
		}
		if (GSGameplayCVar.CVar_ShowPrioritySelectUnit.GetValueInGameThread() != 0)
		{
			UCapsuleComponent uCapsuleComponent = PerformerActor.GetRootComponent() as UCapsuleComponent;
			float radius = ((uCapsuleComponent != null) ? uCapsuleComponent.GetScaledCapsuleRadius() : 200f);
			USystemLibrary.DrawDebugSphere(Owner, BGUFuncLibActorTransformCS.BGUGetActorLocation(PerformerActor), radius, 20, FLinearColor.Green, 5f, 10f);
		}
	}

	private void OnRecoverAttackToken(Entity Entity, ERecoverTokenReason RecoverTokenReason)
	{
		if (!GroupAIMgrData.GroupAIPerformerInfoDic.TryGetValue(Entity, out var value) || !value.IsAttacking)
		{
			return;
		}
		value.IsAttacking = false;
		FUStGroupAISDesc groupAIDesc = BGW_GameDB.GetGroupAIDesc(value.ResID);
		if (groupAIDesc == null)
		{
			return;
		}
		switch (value.UnitAttackBias)
		{
		case EGroupAIAttackBias.MeleeAttack:
			GroupAIMgrData.TotalMeleeAttackTokenNum += groupAIDesc.GroupAIAtkRequestTokenNum;
			break;
		case EGroupAIAttackBias.RangeAttack:
			GroupAIMgrData.TotalRangeAttackTokenNum += groupAIDesc.GroupAIAtkRequestTokenNum;
			break;
		}
		GroupAIMgrData.TotalMeleeAttackTokenNum = (int)MathLib.Clamp(GroupAIMgrData.TotalMeleeAttackTokenNum, 0f, GroupAIMgrData.GroupAIMgrConfigDataAsset.MeleeAttackTokenNum);
		GroupAIMgrData.TotalRangeAttackTokenNum = (int)MathLib.Clamp(GroupAIMgrData.TotalRangeAttackTokenNum, 0f, GroupAIMgrData.GroupAIMgrConfigDataAsset.RangeAttackTokenNum);
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			AActor firstLocalPlayerPawn = LocalPlayerSharedData.FirstLocalPlayerPawn;
			if (!(firstLocalPlayerPawn == null))
			{
				BGUFunctionLibraryCS.LogBattleInfo(firstLocalPlayerPawn, EBattleInfoType.GroupAI, $"<character>【群体AI】</><action>回收Toke</><action>，收到单位：</><effect>{value.PerformerName}</><action>，EntityRef：</><effect>{Entity}</><action>，回收原因：</><effect>{RecoverTokenReason}</><action>，回收的Token倾向是：</><effect>{value.UnitAttackBias}</><action>，返回的Token数量是：</><effect>{groupAIDesc.GroupAIAtkRequestTokenNum}</>");
			}
		}
	}

	private void OnAddPerformerInfoToList(AActor PerformerActor)
	{
		Entity entity = ECSUtil.ToEntity(PerformerActor);
		if (PerformerActor == null || entity == Entity.Null || GroupAIMgrData.GroupAIPerformerInfoDic.TryGetValue(entity, out var _))
		{
			return;
		}
		int actorResID = BGU_DataUtil.GetActorResID(PerformerActor);
		FUStGroupAISDesc groupAIDesc = BGW_GameDB.GetGroupAIDesc(actorResID);
		if (groupAIDesc != null)
		{
			GroupAIMgrData.GroupAIPerformerInfoDic.Add(entity, new GroupAIPerformerInfo(entity, PerformerActor, actorResID, groupAIDesc.GroupAIPriorityNumInSameScore, groupAIDesc.GroupAIAttackBias, groupAIDesc.GroupAIAtkRequestTokenNum, PerformerActor.GetName()));
			if (GroupAIMgrData.IsEnableGroupAI)
			{
				BUS_EventCollectionCS.Get(PerformerActor).Evt_GroupAIRequestTask.Invoke(GenReqID(), 0f, EGroupCMDType.ToggleActivateGroupAI, new GAAI_EnableGroupAI
				{
					IsEnable = true
				}, 0f, 0f);
			}
		}
	}

	private void OnRemovePerformerInList(Entity PerformerEntity, ERecoverTokenReason RecoverTokenReason)
	{
		if (GroupAIMgrData.GroupAIPerformerInfoDic.Count > 0 && GroupAIMgrData.GroupAIPerformerInfoDic.TryGetValue(PerformerEntity, out var _))
		{
			OnRecoverAttackToken(PerformerEntity, RecoverTokenReason);
			GroupAIMgrData.GroupAIPerformerInfoDic.Remove(PerformerEntity);
		}
	}

	private void OnSetNewConfigDataAsset(AActor AreaActor, BGWGroupAIMgrConfigDataAsset GroupAIMgrConfigDA, BGWGroupAIBattleHotZoneConfigDataAsset HotZoneConfigDA)
	{
		if (GroupAIMgrConfigDA != null && HotZoneConfigDA != null && !AreaActor.IsNullOrDestroyed() && GroupAIMgrData.CurrentUseGroupAIConfigAreaID != AActorStatics.GetEntityHash(AreaActor))
		{
			GroupAIMgrData.CurrentUseGroupAIConfigAreaID = AActorStatics.GetEntityHash(AreaActor);
			GroupAIMgrData.SetGroupAIMgrConfigDataAsset(GroupAIMgrConfigDA);
			GroupAIMgrData.SetGroupAIBattleHotZoneConfigDataAsset(HotZoneConfigDA);
			GroupAIMgrData.NeedReDrawDebugPanel = true;
			ClearHotZonePoint();
			if (GroupAIMgrData.IsEnableGroupAI)
			{
				GenerateHotZonePoint();
			}
		}
	}

	private void OnTry2RecoverDefaultConfigDataAsset(AActor AreaActor)
	{
		if (!AreaActor.IsNullOrDestroyed() && AActorStatics.GetEntityHash(AreaActor) == GroupAIMgrData.CurrentUseGroupAIConfigAreaID)
		{
			GroupAIMgrData.BeginRecover2DefaultConfig = true;
		}
	}

	private void OnInitiatePriorityActionQue(ActionWarpInfo AWI)
	{
		if (AWI.ActionWarpList.Count <= 0)
		{
			return;
		}
		int resID = AWI.ResID;
		int executorNum = AWI.ExecutorNum;
		List<AActor> list = FindCanExecutePriorityActionPerformer(resID, AWI.SelectUnitTypeInfo, AWI.UnitType);
		List<FVector> eQSGoalPos = AWI.EQSGoalPos;
		OneActionWarpInfo oneActionWarpInfo = AWI.ActionWarpList[0];
		int num = 0;
		if (oneActionWarpInfo.ActionType == EGroupPriorityActionType.MoveToPos)
		{
			foreach (FVector item in eQSGoalPos)
			{
				if (executorNum <= num)
				{
					break;
				}
				float num2 = -1f;
				int num3 = -1;
				for (int num4 = list.Count - 1; num4 >= 0; num4--)
				{
					float num5 = FVector.Dist2D(item, BGUFuncLibActorTransformCS.BGUGetActorLocation(list[num4]));
					if (num2 == -1f || num5 < num2)
					{
						num2 = num5;
						num3 = num4;
					}
				}
				if (num3 != -1)
				{
					num++;
					AssignPriorityAction(in AWI.ActionWarpList, list[num3], item);
					list.RemoveAt(num3);
				}
			}
			return;
		}
		foreach (AActor item2 in list)
		{
			if (executorNum <= num)
			{
				break;
			}
			num++;
			AssignPriorityAction(in AWI.ActionWarpList, item2, FVector.ZeroVector);
		}
	}
}
