using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BPS_RebirthPointSystem : PlayerControllerSystemBase
{
	private BIC_GMRebirthData GMRebirthData;

	private BPC_RebirthPointData RebirthPointData { get; set; }

	private BPC_PlayerRoleData PlayerRoleData { get; set; }

	private BPS_GSEventCollection EventCollection { get; set; }

	private IBIC_LevelData LevelData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		RebirthPointData = RequireWritableLocalPlayerControlData<BPC_RebirthPointData>();
		PlayerRoleData = RequireWritableLocalPlayerControlData<BPC_PlayerRoleData>();
		LevelData = RequireReadonlyGameInstanceData<IBIC_LevelData, BIC_LevelData>();
		GMRebirthData = BGWGameInstanceCS.GetObject<BGW_GameDataMgr>(GetOwner()).GetGameInstanceWritableData<BIC_GMRebirthData>();
		EventCollection = GetPlayerEventCollection();
		if (EventCollection != null)
		{
			EventCollection.Evt_ActiveRebirthPoint += new Del_Void_IntBool(OnActiveRebirthPoint);
			EventCollection.Evt_BlockRebirthPoint += new Del_Void_IntBool(OnBlockRebirthPoint);
			EventCollection.Evt_SetCurrentRebirthPoint += new Del_Void_Int(OnSetCurrentRebirthPoint);
			EventCollection.Evt_SetCurrentBirthPoint += new Del_Void_Int(OnSetCurrentBirthPoint);
			EventCollection.Evt_RegSpecialRebirthPoint += new Del_Void_IntList(OnRegSpecialRebirthPoint);
			EventCollection.Evt_UnregSpecialRebirthPoint += new Del_Void_IntList(OnUnregSpecialRebirthPoint);
			EventCollection.Evt_ForceSetRebirthPoint += new Del_Void_Int(OnForceSetRebirthPoint);
		}
		if (base.BGWEventCollection != null)
		{
			BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
			bGWEventCollection.Evt_PostSeamlessTravel = (BGW_EventCollection.Del_BGW_Void)Delegate.Combine(bGWEventCollection.Evt_PostSeamlessTravel, new BGW_EventCollection.Del_BGW_Void(OnPostSeamlessTravel));
			BGW_EventCollection bGWEventCollection2 = base.BGWEventCollection;
			bGWEventCollection2.Evt_OnSeamlessTravelStart = (BGW_EventCollection.Del_BGW_Void_String)Delegate.Combine(bGWEventCollection2.Evt_OnSeamlessTravelStart, new BGW_EventCollection.Del_BGW_Void_String(OnSeamlessTravelStart));
		}
	}

	private void OnPostSeamlessTravel()
	{
		RebirthPointData.InitRebirthAndBirthPointMap(GetOwner());
	}

	private void OnSeamlessTravelStart(string Level)
	{
		RebirthPointData.RegisteredBirthPointIDActorMap.Clear();
		RebirthPointData.RegisteredRebirthPointIDActorMap.Clear();
	}

	public override void OnBeginPlay()
	{
		RebirthPointData.InitRebirthAndBirthPointMap(GetOwner());
		InitRebirthPointArchiveData();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		RebirthPointData.RegisteredBirthPointIDActorMap.Clear();
		if (base.BGWEventCollection != null)
		{
			BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
			bGWEventCollection.Evt_PostSeamlessTravel = (BGW_EventCollection.Del_BGW_Void)Delegate.Remove(bGWEventCollection.Evt_PostSeamlessTravel, new BGW_EventCollection.Del_BGW_Void(OnPostSeamlessTravel));
			BGW_EventCollection bGWEventCollection2 = base.BGWEventCollection;
			bGWEventCollection2.Evt_OnSeamlessTravelStart = (BGW_EventCollection.Del_BGW_Void_String)Delegate.Remove(bGWEventCollection2.Evt_OnSeamlessTravelStart, new BGW_EventCollection.Del_BGW_Void_String(OnSeamlessTravelStart));
		}
	}

	private void OnSetCurrentRebirthPoint(int CurrentRebirthPointID)
	{
		FUStRebirthPointDesc rebirthPointDesc = BGW_GameDB.GetRebirthPointDesc(CurrentRebirthPointID);
		if (BGW_LogUtil.LogIfNull(rebirthPointDesc, $"Find RebirthPointDesc failed! ID: {CurrentRebirthPointID}"))
		{
			return;
		}
		if (RebirthPointData != null && RebirthPointData.CurrentRebirthPointIDMap != null)
		{
			if (RebirthPointData.CurrentRebirthPointIDMap.ContainsKey(rebirthPointDesc.MapID))
			{
				RebirthPointData.CurrentRebirthPointIDMap[rebirthPointDesc.MapID] = CurrentRebirthPointID;
			}
			else
			{
				RebirthPointData.CurrentRebirthPointIDMap.Add(rebirthPointDesc.MapID, CurrentRebirthPointID);
			}
		}
		else
		{
			BGW_LogUtil.LogError("OnSetCurrentRebirthPoint 无法获取当前复活点数据！");
		}
		OnSetRebirthPointAsCurrentBirthPoint(CurrentRebirthPointID);
		GMRebirthData.Reset();
	}

	private void InitRebirthPointArchiveData()
	{
		int currentLevelID = LevelData.CurrentLevelID;
		int num = 0;
		if (RebirthPointData != null && RebirthPointData.CurrentRebirthPointIDMap != null)
		{
			if (RebirthPointData.CurrentRebirthPointIDMap.ContainsKey(currentLevelID))
			{
				num = RebirthPointData.CurrentRebirthPointIDMap[currentLevelID];
			}
		}
		else
		{
			BGW_LogUtil.LogError("[BPS_RebirthPointSystem] InitRebirthPointArchiveData 无法获取当前复活点数据！");
		}
		FUStRebirthPointDesc rebirthPointDesc = BGW_GameDB.GetRebirthPointDesc(num);
		if (currentLevelID > 0 && (num == 0 || (rebirthPointDesc != null && rebirthPointDesc.MapID != currentLevelID)))
		{
			Dictionary<int, FUStRebirthPointDesc> allRebirthPointDesc = BGW_GameDB.GetAllRebirthPointDesc();
			foreach (KeyValuePair<int, FUStRebirthPointDesc> item in allRebirthPointDesc)
			{
				if (item.Value.MapID == currentLevelID && item.Value.IsDefault == EGSYesNo.Yes)
				{
					if (!RebirthPointData.ActivedRebirthPointList.Contains(item.Value.ID))
					{
						RebirthPointData.ActivedRebirthPointList.Add(item.Value.ID);
					}
					if (num == 0 || BGW_GameDB.GetRebirthPointDesc(num).MapID != currentLevelID)
					{
						num = item.Value.ID;
					}
					break;
				}
			}
			foreach (KeyValuePair<int, FUStRebirthPointDesc> item2 in allRebirthPointDesc)
			{
				if (item2.Value.MapID == currentLevelID && item2.Value.IsActive == EGSYesNo.Yes)
				{
					if (!RebirthPointData.ActivedRebirthPointList.Contains(item2.Value.ID))
					{
						RebirthPointData.ActivedRebirthPointList.Add(item2.Value.ID);
					}
					if (num == 0 || BGW_GameDB.GetRebirthPointDesc(num).MapID != currentLevelID)
					{
						num = item2.Value.ID;
					}
				}
			}
			if (DebugConfig.Debug820Demo)
			{
				num = BGW_820DemoPlayTimeMgr.Get(GetOwner()).GetCurLevelCurRebirthPoint();
			}
		}
		foreach (int activedRebirthPoint in RebirthPointData.ActivedRebirthPointList)
		{
			OnActiveRebirthPoint(activedRebirthPoint, bActive: true);
		}
		ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(Owner, 0);
		OnSetCurrentRebirthPoint(num);
		foreach (BGURebirthPointBase allActorsOfClass in UGameplayStatics.GetAllActorsOfClassList<BGURebirthPointBase>(Owner))
		{
			BUS_RebirthPointConfigComp componentByClass = allActorsOfClass.GetComponentByClass<BUS_RebirthPointConfigComp>();
			if (!(componentByClass != null))
			{
				continue;
			}
			bool flag = false;
			for (int i = 0; i < RebirthPointData.ActivedRebirthPointList.Count; i++)
			{
				if (componentByClass.RebirthPointConfig.RebirthPointID == RebirthPointData.ActivedRebirthPointList[i])
				{
					flag = true;
				}
			}
			if (flag)
			{
				BUS_EventCollectionCS.Get(allActorsOfClass).Evt_SetRebirthPointActiveState.Invoke(P1: true, P2: true);
			}
		}
		int num2 = PlayerRoleData.RoleData.RoleCs.Actor.NewGamePlusCount;
		if (DebugConfig.DebugGameCount > 0)
		{
			num2 = DebugConfig.DebugGameCount;
		}
		if (num2 > 1)
		{
			BPS_EventCollectionCS.GetLocal(playerCharacter).Evt_ActiveRebirthPoint.Invoke(9001, P2: true);
		}
	}

	private void OnRegSpecialRebirthPoint(List<int> SpRBPList)
	{
		foreach (int item in RebirthPointData.HighPrioritySpecialRebithPointID)
		{
			BGW_LogUtil.LogError($"[RebirthPointSystem] SpecialRebirthPoint 重复注册 {item}");
		}
		RebirthPointData.HighPrioritySpecialRebithPointID.Clear();
		RebirthPointData.HighPrioritySpecialRebithPointID = SpRBPList;
	}

	private void OnUnregSpecialRebirthPoint(List<int> SpRBPList)
	{
		foreach (int SpRBP in SpRBPList)
		{
			if (!RebirthPointData.HighPrioritySpecialRebithPointID.Contains(SpRBP))
			{
				BGW_LogUtil.LogError($"[RebirthPointSystem] SpecialRebirthPoint 重复反注册 {RebirthPointData.HighPrioritySpecialRebithPointID[0]}");
			}
		}
		RebirthPointData.HighPrioritySpecialRebithPointID.Clear();
	}

	private void OnForceSetRebirthPoint(int RebirthPointId)
	{
		OnSetCurrentRebirthPoint(RebirthPointId);
		RebirthPointData.CurrentBirthPoint = new FBirthPointInfo
		{
			PointType = EBirthPointType.RebirthPoint,
			PointID = RebirthPointId
		};
	}

	private void OnSetCurrentBirthPoint(int BirthPointID)
	{
		if (RebirthPointData.RegisteredBirthPointIDActorMap.ContainsKey(BirthPointID) && (RebirthPointData.CurrentBirthPoint.PointType != EBirthPointType.BirthPoint || RebirthPointData.CurrentBirthPoint.PointID != BirthPointID))
		{
			RebirthPointData.CurrentBirthPoint = new FBirthPointInfo
			{
				PointType = EBirthPointType.BirthPoint,
				PointID = BirthPointID
			};
		}
	}

	private void OnSetRebirthPointAsCurrentBirthPoint(int RebirthPointID)
	{
		if (RebirthPointData.RegisteredRebirthPointIDActorMap.ContainsKey(RebirthPointID) && (RebirthPointData.CurrentBirthPoint.PointType != EBirthPointType.RebirthPoint || RebirthPointData.CurrentBirthPoint.PointID != RebirthPointID))
		{
			RebirthPointData.CurrentBirthPoint = new FBirthPointInfo
			{
				PointType = EBirthPointType.RebirthPoint,
				PointID = RebirthPointID
			};
		}
	}

	private void OnActiveRebirthPoint(int RebirthPointID, bool bActive)
	{
		if (bActive && !RebirthPointData.ActivedRebirthPointList.Contains(RebirthPointID))
		{
			RebirthPointData.ActivedRebirthPointList.Add(RebirthPointID);
		}
		else if (!bActive && RebirthPointData.ActivedRebirthPointList.Contains(RebirthPointID))
		{
			RebirthPointData.ActivedRebirthPointList.Remove(RebirthPointID);
		}
	}

	private void OnBlockRebirthPoint(int RebirthPointID, bool Block)
	{
		if (Block && !RebirthPointData.BlockedRebirthPointList.Contains(RebirthPointID))
		{
			RebirthPointData.BlockedRebirthPointList.Add(RebirthPointID);
		}
		else if (!Block && RebirthPointData.BlockedRebirthPointList.Contains(RebirthPointID))
		{
			RebirthPointData.BlockedRebirthPointList.Remove(RebirthPointID);
		}
	}
}
