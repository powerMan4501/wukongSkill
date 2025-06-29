using System;
using System.Collections.Generic;
using System.Linq;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BIS_GlobalActorManager : GameInstanceSystemBase
{
	private BIC_GlobalActorData GlobalActorData { get; set; }

	private BGW_EventCollection EventCollection { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		GlobalActorData = RequireWritableGameInstanceData<BIC_GlobalActorData>();
		EventCollection = BGW_EventCollection.Get(base.Owner);
		if (EventCollection != null)
		{
			BGW_EventCollection eventCollection = EventCollection;
			eventCollection.Evt_ResetGameInstanceData = (BGW_EventCollection.Del_BGW_ResetGameInstanceData)Delegate.Combine(eventCollection.Evt_ResetGameInstanceData, new BGW_EventCollection.Del_BGW_ResetGameInstanceData(OnResetGameData));
			BGW_EventCollection eventCollection2 = EventCollection;
			eventCollection2.Evt_SetActorGuid2Entity = (Del_Void_ActorStringInt)Delegate.Combine(eventCollection2.Evt_SetActorGuid2Entity, new Del_Void_ActorStringInt(SetActorGuid2Entity));
			BGW_EventCollection eventCollection3 = EventCollection;
			eventCollection3.Evt_RemoveActorGuid2Entity = (Del_Void_ActorStringInt)Delegate.Combine(eventCollection3.Evt_RemoveActorGuid2Entity, new Del_Void_ActorStringInt(RemoveActorGuid2Entity));
			BGW_EventCollection eventCollection4 = EventCollection;
			eventCollection4.Evt_SetActorInitDataInitialized = (Del_Void_StringBool)Delegate.Combine(eventCollection4.Evt_SetActorInitDataInitialized, new Del_Void_StringBool(SetActorInitDataInitialized));
			BGW_EventCollection eventCollection5 = EventCollection;
			eventCollection5.Evt_SetActorAliveState = (Del_Void_StringBool)Delegate.Combine(eventCollection5.Evt_SetActorAliveState, new Del_Void_StringBool(SetActorAliveState));
			BGW_EventCollection eventCollection6 = EventCollection;
			eventCollection6.Evt_RemoveActorData = (Del_Void_String)Delegate.Combine(eventCollection6.Evt_RemoveActorData, new Del_Void_String(RemoveActorData));
			BGW_EventCollection eventCollection7 = EventCollection;
			eventCollection7.Evt_SaveActorInitData = (BGW_EventCollection.Del_BGW_SaveActorInitData)Delegate.Combine(eventCollection7.Evt_SaveActorInitData, new BGW_EventCollection.Del_BGW_SaveActorInitData(SaveActorInitData));
			BGW_EventCollection eventCollection8 = EventCollection;
			eventCollection8.Evt_LoadActorAliveState = (Del_Void_StringBool)Delegate.Combine(eventCollection8.Evt_LoadActorAliveState, new Del_Void_StringBool(LoadActorAliveState));
			BGW_EventCollection eventCollection9 = EventCollection;
			eventCollection9.Evt_SetActorResetTypeOverride = (Del_Void_StringResetType)Delegate.Combine(eventCollection9.Evt_SetActorResetTypeOverride, new Del_Void_StringResetType(SetActorResetTypeOverride));
			BGW_EventCollection eventCollection10 = EventCollection;
			eventCollection10.Evt_SetGroupResetTypeOverride = (Del_Void_StringResetType)Delegate.Combine(eventCollection10.Evt_SetGroupResetTypeOverride, new Del_Void_StringResetType(SetGroupResetTypeOverride));
			BGW_EventCollection eventCollection11 = EventCollection;
			eventCollection11.Evt_ClearActorResetTypeOverride = (Del_Void_String)Delegate.Combine(eventCollection11.Evt_ClearActorResetTypeOverride, new Del_Void_String(ClearActorResetTypeOverride));
			BGW_EventCollection eventCollection12 = EventCollection;
			eventCollection12.Evt_ClearGroupResetTypeOverride = (Del_Void_String)Delegate.Combine(eventCollection12.Evt_ClearGroupResetTypeOverride, new Del_Void_String(ClearGroupResetTypeOverride));
			BGW_EventCollection eventCollection13 = EventCollection;
			eventCollection13.Evt_LoadActorResetType = (Del_Void_StringResetType)Delegate.Combine(eventCollection13.Evt_LoadActorResetType, new Del_Void_StringResetType(OnLoadActorResetType));
			BGW_EventCollection eventCollection14 = EventCollection;
			eventCollection14.Evt_BGW_UnitCastSkillSuccess = (BGW_EventCollection.Del_BGW_UnitCastSkillSuccess)Delegate.Combine(eventCollection14.Evt_BGW_UnitCastSkillSuccess, new BGW_EventCollection.Del_BGW_UnitCastSkillSuccess(OnUnitCastSkillSuccess));
			BGW_EventCollection eventCollection15 = EventCollection;
			eventCollection15.Evt_RegisterInteractor = (Del_Void_String)Delegate.Combine(eventCollection15.Evt_RegisterInteractor, new Del_Void_String(OnRegisterInteractor));
			BGW_EventCollection eventCollection16 = EventCollection;
			eventCollection16.Evt_UnregisterInteractor = (Del_Void_String)Delegate.Combine(eventCollection16.Evt_UnregisterInteractor, new Del_Void_String(OnUnregisterInteractor));
			BGW_EventCollection eventCollection17 = EventCollection;
			eventCollection17.Evt_ClearAllGameData = (Del_Void)Delegate.Combine(eventCollection17.Evt_ClearAllGameData, new Del_Void(ClearGameData));
		}
	}

	private void OnRegisterInteractor(string ActorGuid)
	{
		if (!GlobalActorData.InteractorSet.Contains(ActorGuid))
		{
			GlobalActorData.InteractorSet.Add(ActorGuid);
		}
	}

	private void OnUnregisterInteractor(string ActorGuid)
	{
		GlobalActorData.InteractorSet.Remove(ActorGuid);
	}

	public override void OnInit()
	{
	}

	private void ClearActorResetTypeOverride(string UnitGuid)
	{
		if (!string.IsNullOrEmpty(UnitGuid) && GlobalActorData.ActorResetTypeOverride.ContainsKey(UnitGuid))
		{
			GlobalActorData.ActorResetTypeOverride.Remove(UnitGuid);
		}
	}

	private void ClearGroupResetTypeOverride(string GroupGuid)
	{
		if (!string.IsNullOrEmpty(GroupGuid) && GlobalActorData.GroupResetTypeOverride.ContainsKey(GroupGuid))
		{
			GlobalActorData.GroupResetTypeOverride.Remove(GroupGuid);
		}
	}

	private void SetActorResetTypeOverride(string UnitGuid, EBGUResetType ResetType)
	{
		if (!string.IsNullOrEmpty(UnitGuid))
		{
			GlobalActorData.ActorResetTypeOverride[UnitGuid] = ResetType;
		}
	}

	private void SetGroupResetTypeOverride(string GroupGuid, EBGUResetType ResetType)
	{
		if (!string.IsNullOrEmpty(GroupGuid))
		{
			GlobalActorData.GroupResetTypeOverride[GroupGuid] = ResetType;
		}
	}

	private void OnResetGameData(EGameInstanceResetType ResetType)
	{
		GlobalActorData.ActorInitDataDict.Clear();
		GlobalActorData.ActorGuid2Entity.Clear();
		GlobalActorData.ActorResID2Entity.Clear();
		GlobalActorData.ActorAliveState.Clear();
		GlobalActorData.ActorResetType.Clear();
		GlobalActorData.ActorResetTypeOverride.Clear();
		GlobalActorData.GroupResetTypeOverride.Clear();
		GlobalActorData.StreamingLevelActors.Clear();
		GlobalActorData.ActorCastSkillCount.Clear();
		GlobalActorData.InteractorSet.Clear();
	}

	private void ClearGameData()
	{
		foreach (string item in GlobalActorData.ActorAliveState.Keys.ToList())
		{
			GlobalActorData.ActorAliveState[item] = true;
		}
	}

	public void SetActorGuid2Entity(AActor InActor, string UnitGuid, int ActorResID)
	{
		if (string.IsNullOrEmpty(UnitGuid))
		{
			return;
		}
		if (!GlobalActorData.ActorGuid2Entity.ContainsKey(UnitGuid))
		{
			GlobalActorData.ActorGuid2Entity.Add(UnitGuid, new List<AActor>());
		}
		if (!GlobalActorData.ActorResID2Entity.ContainsKey(ActorResID))
		{
			GlobalActorData.ActorResID2Entity.Add(ActorResID, new List<AActor>());
		}
		List<AActor> list = GlobalActorData.ActorGuid2Entity[UnitGuid];
		if (!list.Contains(InActor))
		{
			list.Add(InActor);
			IBGC_TamerData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_TamerData, BGC_TamerData>(base.Owner);
			if (gameStateReadonlyData != null && gameStateReadonlyData.GetTamerType(UnitGuid, out var OutTamerType) && OutTamerType != ETamerType.LevelLoaded)
			{
				GlobalActorData.SpawnActors.Add(UnitGuid);
			}
		}
		list = GlobalActorData.ActorResID2Entity[ActorResID];
		if (!list.Contains(InActor))
		{
			list.Add(InActor);
		}
	}

	public void RemoveActorGuid2Entity(AActor InActor, string UnitGuid, int ActorResID)
	{
		if (string.IsNullOrEmpty(UnitGuid))
		{
			return;
		}
		if (GlobalActorData.ActorResID2Entity.TryGetValue(ActorResID, out var value) && value != null && value.Contains(InActor))
		{
			value.Remove(InActor);
		}
		if (GlobalActorData.ActorGuid2Entity.TryGetValue(UnitGuid, out value) && value != null && value.Contains(InActor))
		{
			value.Remove(InActor);
			if (value.Count == 0 && GlobalActorData.SpawnActors.Contains(UnitGuid))
			{
				RemoveActorData(UnitGuid);
			}
		}
	}

	public void SetActorInitDataInitialized(string UnitGuid, bool bInit)
	{
		if (GlobalActorData.ActorInitDataDict.TryGetValue(UnitGuid, out var value))
		{
			value.HasInitialized = bInit;
		}
	}

	public void SetActorAliveState(string UnitGuid, bool bAlive)
	{
		if (GlobalActorData.ActorAliveState.TryGetValue(UnitGuid, out var value))
		{
			if (value && !bAlive && !GlobalActorData.SpawnActors.Contains(UnitGuid))
			{
				BGW_GameArchiveMgr.Get(base.Owner).MarkDelaySaveArchive(EArchiveDelaySaveSource.FarmedUnitDead, "UnitGuid: " + UnitGuid);
			}
			GlobalActorData.ActorAliveState[UnitGuid] = bAlive;
		}
	}

	public void RemoveActorData(string UnitGuid)
	{
		if (GlobalActorData.ActorInitDataDict.TryGetValue(UnitGuid, out var value))
		{
			GlobalActorData.ActorInitDataDict.Remove(UnitGuid);
		}
		if (GlobalActorData.ActorAliveState.ContainsKey(UnitGuid))
		{
			GlobalActorData.ActorAliveState.Remove(UnitGuid);
		}
		if (GlobalActorData.ActorResetType.ContainsKey(UnitGuid))
		{
			GlobalActorData.ActorResetType.Remove(UnitGuid);
		}
		if (GlobalActorData.GetActorEntity(UnitGuid, out var Entity))
		{
			AActor aActor = ECSExtension.ToActor(Entity);
			if (aActor != null && aActor is BGUCharacterCS bGUCharacterCS && GlobalActorData.ActorResID2Entity.TryGetValue(bGUCharacterCS.GetResID(), out var value2))
			{
				value2.Remove(aActor);
			}
		}
		GlobalActorData.ActorGuid2Entity.Remove(UnitGuid);
		GlobalActorData.ActorCastSkillCount.Remove(UnitGuid);
		GlobalActorData.SpawnActors.Remove(UnitGuid);
		if (value != null && value.GetInitDataModule(EInitDataModuleType.Basic) is b1.GSBasicInitDataModule gSBasicInitDataModule && GlobalActorData.StreamingLevelActors.TryGetValue(gSBasicInitDataModule.WorldPackageName, out var value3))
		{
			value3.Remove(UnitGuid);
		}
	}

	private void SaveActorInitData(string UnitGuid, BUC_ActorInitData ActorInitData, EBGUResetType ResetType)
	{
		if (UnitGuid == null)
		{
			return;
		}
		if (GlobalActorData.ActorInitDataDict.TryGetValue(UnitGuid, out var value))
		{
			List<EInitDataModuleType> list = new List<EInitDataModuleType>();
			foreach (KeyValuePair<EInitDataModuleType, GSInitDataModuleBase> initDatum in ActorInitData.InitData)
			{
				EInitDataModuleType key = initDatum.Key;
				GSInitDataModuleBase value2 = initDatum.Value;
				if (value2.HasInited)
				{
					value.InitData[key] = value2;
				}
				else
				{
					list.Add(key);
				}
			}
			foreach (EInitDataModuleType item in list)
			{
				if (value.InitData.TryGetValue(item, out var value3))
				{
					ActorInitData.InitData[item] = value3;
				}
			}
		}
		else
		{
			GlobalActorData.ActorInitDataDict.Add(UnitGuid, ActorInitData);
			if (!GlobalActorData.ActorAliveState.ContainsKey(UnitGuid))
			{
				GlobalActorData.ActorAliveState.Add(UnitGuid, value: true);
			}
			if (!GlobalActorData.ActorResetType.ContainsKey(UnitGuid))
			{
				GlobalActorData.ActorResetType.Add(UnitGuid, ResetType);
			}
		}
		GlobalActorData.ActorInitDataDict[UnitGuid].HasInitialized = true;
		if (ActorInitData.GetInitDataModule(EInitDataModuleType.Basic) is b1.GSBasicInitDataModule { WorldPackageName: not null } gSBasicInitDataModule)
		{
			if (GlobalActorData.StreamingLevelActors.TryGetValue(gSBasicInitDataModule.WorldPackageName, out var value4))
			{
				value4.Add(UnitGuid);
				return;
			}
			GlobalActorData.StreamingLevelActors.Add(gSBasicInitDataModule.WorldPackageName, new HashSet<string> { UnitGuid });
		}
	}

	public void LoadActorAliveState(string UnitGuid, bool bAlive)
	{
		GlobalActorData.ActorAliveState[UnitGuid] = bAlive;
	}

	private void OnLoadActorResetType(string UnitGuid, EBGUResetType ResetType)
	{
		GlobalActorData.ActorResetType[UnitGuid] = ResetType;
	}

	private void OnUnitCastSkillSuccess(AActor Owner, int SkillID)
	{
		string actorGuid = BGU_DataUtil.GetActorGuid(Owner);
		if (actorGuid.Length == 0)
		{
			return;
		}
		if (GlobalActorData.ActorCastSkillCount.TryGetValue(actorGuid, out var value))
		{
			if (value.TryGetValue(SkillID, out var value2))
			{
				value[SkillID] = value2 + 1;
			}
			else
			{
				value.Add(SkillID, 1);
			}
		}
		else
		{
			GlobalActorData.ActorCastSkillCount.Add(actorGuid, new Dictionary<int, int> { { SkillID, 1 } });
		}
	}
}
