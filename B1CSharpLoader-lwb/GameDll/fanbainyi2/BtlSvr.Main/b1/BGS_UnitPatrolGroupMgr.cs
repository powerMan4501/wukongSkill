using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BGS_UnitPatrolGroupMgr : GameStateSystemBase
{
	private BGC_UnitPatrolGroupMgrData UnitPatrolGroupMgrData;

	public override void OnAttach()
	{
		UnitPatrolGroupMgrData = RequireWritableData<BGC_UnitPatrolGroupMgrData>();
		UnitPatrolGroupMgrData.IsPatrolGroupMgrInited = InitGroupPatrolInfoImpl();
		SetCanTick(UnitPatrolGroupMgrData.IsPatrolGroupMgrInited);
		base.BGSEventCollection.Evt_BGS_AddUnitToPatrolGroup += new Del_BGS_AddUnitToPatrolGroup(AddUnitToGroup);
		base.BGSEventCollection.Evt_BGS_RemoveUnitFromPatrolGroup += new Del_BGS_RemoveUnitFromPatrolGroup(RemoveUnitFromGroup);
		base.BGSEventCollection.Evt_BGS_GroupPatrolLeaderPathMoveComplete += new Del_BGS_GroupPatrolLeaderPathMoveComplete(GroupLeaderPathMoveComplete);
		base.BGSEventCollection.Evt_BGS_GroupPatrolWaitPointEnd += new Del_BGS_GroupPatrolWaitPointEnd(GroupPatrolWaitPointEnd);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!UnitPatrolGroupMgrData.IsPatrolGroupMgrInited)
		{
			UnitPatrolGroupMgrData.IsPatrolGroupMgrInited = InitGroupPatrolInfoImpl();
			SetCanTick(UnitPatrolGroupMgrData.IsPatrolGroupMgrInited);
		}
	}

	private void UpdateUnitPatrolGroup(PatrolUnitInfo UnitInfo)
	{
		List<PatrolGroupInfo> patrolGroups = UnitPatrolGroupMgrData.PatrolGroups;
		List<string> activeUnits = patrolGroups[UnitInfo.GroupIndex].ActiveUnits;
		BUS_EventCollectionCS.Get(BGU_DataUtil.GetActorByGuid(Owner, activeUnits[0]))?.Evt_SetGroupPatrolLeader.Invoke(patrolGroups[UnitInfo.GroupIndex].SplineActorGuid, patrolGroups[UnitInfo.GroupIndex].TargetPathPointIndex);
		for (int i = 1; i < activeUnits.Count; i++)
		{
			BUS_EventCollectionCS.Get(BGU_DataUtil.GetActorByGuid(Owner, activeUnits[i]))?.Evt_SetGroupPatrolMember.Invoke(activeUnits[0], patrolGroups[UnitInfo.GroupIndex].GroupFormation[i - 1], patrolGroups[UnitInfo.GroupIndex].TargetPathPointIndex);
		}
	}

	public void AddUnitToGroup(string UnitGuid)
	{
		if (BGU_DataUtil.GetActorByGuid(Owner, UnitGuid) == null)
		{
			return;
		}
		Dictionary<string, PatrolUnitInfo> activatedUnitInfoCache = UnitPatrolGroupMgrData.ActivatedUnitInfoCache;
		List<PatrolGroupInfo> patrolGroups = UnitPatrolGroupMgrData.PatrolGroups;
		List<int> activatedGroupsIndex = UnitPatrolGroupMgrData.ActivatedGroupsIndex;
		if (activatedUnitInfoCache.ContainsKey(UnitGuid))
		{
			return;
		}
		PatrolUnitInfo patrolUnitInfo = UnitPatrolGroupMgrData.TryFindPatrolUnitInfo(UnitGuid);
		if (patrolUnitInfo == null)
		{
			return;
		}
		List<string> activeUnits = patrolGroups[patrolUnitInfo.GroupIndex].ActiveUnits;
		if (activeUnits.Contains(UnitGuid))
		{
			activatedUnitInfoCache.Add(UnitGuid, patrolUnitInfo);
			return;
		}
		int i;
		for (i = 0; i < activeUnits.Count && activatedUnitInfoCache[activeUnits[i]].Priority <= patrolUnitInfo.Priority; i++)
		{
		}
		activeUnits.Insert(i, UnitGuid);
		activatedUnitInfoCache.Add(UnitGuid, patrolUnitInfo);
		UpdateUnitPatrolGroup(patrolUnitInfo);
		if (!activatedGroupsIndex.Contains(patrolUnitInfo.GroupIndex))
		{
			activatedGroupsIndex.Add(patrolUnitInfo.GroupIndex);
		}
	}

	public void RemoveUnitFromGroup(string UnitGuid)
	{
		Dictionary<string, PatrolUnitInfo> activatedUnitInfoCache = UnitPatrolGroupMgrData.ActivatedUnitInfoCache;
		List<PatrolGroupInfo> patrolGroups = UnitPatrolGroupMgrData.PatrolGroups;
		List<int> activatedGroupsIndex = UnitPatrolGroupMgrData.ActivatedGroupsIndex;
		if (activatedUnitInfoCache.TryGetValue(UnitGuid, out var value))
		{
			patrolGroups[value.GroupIndex].RemoveUnit(UnitGuid);
			List<string> activeUnits = patrolGroups[value.GroupIndex].ActiveUnits;
			activatedUnitInfoCache.Remove(UnitGuid);
			if (activeUnits.Count == 0)
			{
				activatedGroupsIndex.Remove(value.GroupIndex);
				patrolGroups[value.GroupIndex].Reset();
			}
			else
			{
				UpdateUnitPatrolGroup(value);
			}
		}
	}

	public void GroupLeaderPathMoveComplete(string GroupLeaderGuid)
	{
		Dictionary<string, PatrolUnitInfo> activatedUnitInfoCache = UnitPatrolGroupMgrData.ActivatedUnitInfoCache;
		List<PatrolGroupInfo> patrolGroups = UnitPatrolGroupMgrData.PatrolGroups;
		if (!activatedUnitInfoCache.TryGetValue(GroupLeaderGuid, out var value))
		{
			return;
		}
		PatrolGroupInfo patrolGroupInfo = patrolGroups[value.GroupIndex];
		if (patrolGroupInfo.Spline == null)
		{
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, patrolGroupInfo.SplineActorGuid);
			if (actorByGuid != null)
			{
				patrolGroupInfo.Spline = actorByGuid.GetComponentByClass<USplineComponent>();
			}
		}
		if (patrolGroupInfo.Spline != null)
		{
			switch (patrolGroupInfo.GroupSplinePatrolType)
			{
			case EGSGroupSplinePatrolType.Single:
				if (patrolGroupInfo.TargetPathPointIndex + 1 < patrolGroupInfo.Spline.GetNumberOfSplinePoints())
				{
					patrolGroupInfo.TargetPathPointIndex = (patrolGroupInfo.TargetPathPointIndex + 1) % patrolGroupInfo.Spline.GetNumberOfSplinePoints();
				}
				else
				{
					patrolGroupInfo.NeedStopPatrol = true;
				}
				break;
			case EGSGroupSplinePatrolType.Loop:
				if (patrolGroupInfo.Spline.IsClosedLoop())
				{
					patrolGroupInfo.TargetPathPointIndex = (patrolGroupInfo.TargetPathPointIndex + 1) % patrolGroupInfo.Spline.GetNumberOfSplinePoints();
				}
				else if (patrolGroupInfo.ReversedDirection)
				{
					if (patrolGroupInfo.TargetPathPointIndex - 1 < 0)
					{
						patrolGroupInfo.ReversedDirection = false;
						patrolGroupInfo.TargetPathPointIndex++;
					}
					else
					{
						patrolGroupInfo.TargetPathPointIndex--;
					}
				}
				else if (patrolGroupInfo.TargetPathPointIndex + 1 >= patrolGroupInfo.Spline.GetNumberOfSplinePoints())
				{
					patrolGroupInfo.ReversedDirection = true;
					patrolGroupInfo.TargetPathPointIndex--;
				}
				else
				{
					patrolGroupInfo.TargetPathPointIndex++;
				}
				break;
			}
		}
		foreach (string activeUnit in patrolGroupInfo.ActiveUnits)
		{
			patrolGroupInfo.WaitPointUnits.Add(activeUnit);
		}
		for (int i = 0; i < patrolGroupInfo.ActiveUnits.Count; i++)
		{
			BUS_EventCollectionCS.Get(BGU_DataUtil.GetActorByGuid(Owner, patrolGroupInfo.ActiveUnits[i]))?.Evt_OnGroupPatrolMoveComplete.Invoke(patrolGroupInfo.TargetPathPointIndex);
		}
	}

	public void GroupPatrolWaitPointEnd(string UnitGuid)
	{
		Dictionary<string, PatrolUnitInfo> activatedUnitInfoCache = UnitPatrolGroupMgrData.ActivatedUnitInfoCache;
		List<PatrolGroupInfo> patrolGroups = UnitPatrolGroupMgrData.PatrolGroups;
		if (!activatedUnitInfoCache.TryGetValue(UnitGuid, out var value))
		{
			return;
		}
		PatrolGroupInfo patrolGroupInfo = patrolGroups[value.GroupIndex];
		if (patrolGroupInfo.WaitPointUnits.Count == 0)
		{
			return;
		}
		patrolGroupInfo.WaitPointUnits.Remove(UnitGuid);
		if (patrolGroupInfo.WaitPointUnits.Count != 0)
		{
			return;
		}
		if (patrolGroupInfo.NeedStopPatrol)
		{
			for (int num = patrolGroupInfo.ActiveUnits.Count - 1; num >= 0; num--)
			{
				BUS_EventCollectionCS.Get(BGU_DataUtil.GetActorByGuid(Owner, patrolGroupInfo.ActiveUnits[num]))?.Evt_StopPatrolAndLeisure.Invoke();
			}
			return;
		}
		foreach (string activeUnit in patrolGroupInfo.ActiveUnits)
		{
			BUS_EventCollectionCS.Get(BGU_DataUtil.GetActorByGuid(Owner, activeUnit))?.Evt_GroupPatrolContinue.Invoke();
		}
	}

	private bool InitGroupPatrolInfoImpl()
	{
		UnitPatrolGroupMgrData.PatrolGroups = new List<PatrolGroupInfo>();
		UnitPatrolGroupMgrData.ActivatedUnitInfoCache = new Dictionary<string, PatrolUnitInfo>();
		BIC_LevelData gameInstanceWritableData = BGWGameInstanceCS.GetObject<BGW_GameDataMgr>(Owner).GetGameInstanceWritableData<BIC_LevelData>();
		if (gameInstanceWritableData == null || !gameInstanceWritableData.IsValidLevel())
		{
			return false;
		}
		LevelDesc levelDesc = GameDBRuntime.FastGetLevelDesc(gameInstanceWritableData.CurrentLevelID);
		if (levelDesc != null && !levelDesc.LevelGroupPatrolDataAssetPath.Equals(string.Empty))
		{
			UnitPatrolGroupMgrData.PatrolGroupDA = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<BGWDataAsset_PatrolGroupSettings>(levelDesc.LevelGroupPatrolDataAssetPath, ELoadResourceType.SyncLoadAndCache);
		}
		UnitPatrolGroupMgrData.ActivatedGroupsIndex = new List<int>();
		if (UnitPatrolGroupMgrData.PatrolGroupDA == null)
		{
			return true;
		}
		for (int i = 0; i < UnitPatrolGroupMgrData.PatrolGroupDA.PatrolGroups.Count; i++)
		{
			PatrolGroupInfo item = new PatrolGroupInfo(UnitPatrolGroupMgrData.PatrolGroupDA.PatrolGroups[i]);
			UnitPatrolGroupMgrData.PatrolGroups.Add(item);
		}
		return true;
	}
}
