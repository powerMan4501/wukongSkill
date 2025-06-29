using System;
using System.Collections.Generic;
using System.Linq;
using b1.Plugins.Calliope;
using BtlShare;
using CommB1;
using UnrealEngine.Runtime;

namespace b1;

public abstract class PsmSubMachine_TemplateBase : PsmSubMachine
{
	protected class ManagedSceneObjForPsm
	{
		public ManagedSceneObjType ObjType { get; }

		public string ObjGuid { get; }

		public int DefaultState { get; }

		public int ManagePolice { get; }

		public ManagedSceneObjForPsm(CalliopeCustom_ManagedSceneObj ManagedSceneObjData, PsmInstance InPsmInstance)
		{
			ObjType = ManagedSceneObjData.ObjType;
			DefaultState = ManagedSceneObjData.DefaultState;
			ManagePolice = ManagedSceneObjData.ManagePolice;
			if (InPsmInstance != null)
			{
				ObjGuid = InPsmInstance.ConvertParamID2StringParam(ManagedSceneObjData.ObjGuid);
			}
		}
	}

	protected class ManagedGroupUnitForPsm
	{
		public string ObjGuid { get; }

		public int DefaultState { get; }

		public int ManagePolice { get; }

		public ManagedGroupUnitForPsm(CalliopeCustom_ManagedGroupUnit ManagedGroupUnitData, PsmInstance InPsmInstance)
		{
			DefaultState = ManagedGroupUnitData.DefaultState;
			ManagePolice = ManagedGroupUnitData.ManagePolice;
			if (InPsmInstance != null)
			{
				ObjGuid = InPsmInstance.ConvertParamID2StringParam(ManagedGroupUnitData.ObjGuid);
			}
		}
	}

	protected class ManagedInteractorForPsm
	{
		public string ObjGuid { get; }

		public int GroupID { get; }

		public ManagedInteractorForPsm(CalliopeCustom_ManagedInteractor ManagedInteractor, PsmInstance InPsmInstance)
		{
			if (InPsmInstance != null)
			{
				ObjGuid = InPsmInstance.ConvertParamID2StringParam(ManagedInteractor.ObjGuid);
				GroupID = InPsmInstance.ConvertParamID2IntParam(ManagedInteractor.GroupId);
			}
		}
	}

	protected class ManagedStreamingLevelStateConfigForPsm
	{
		public string ConfigGuid { get; }

		public int LevelID { get; }

		public ManagedStreamingLevelStateConfigParam DataAssetID { get; }

		public ManagedStreamingLevelStateConfigForPsm(CalliopeCustom_ManagedStreamingLevelStateConfig ManagedStreamingLevelStateConfig, PsmInstance InPsmInstance)
		{
			if (InPsmInstance != null)
			{
				ConfigGuid = ManagedStreamingLevelStateConfig.ConfigGuid;
				DataAssetID = ManagedStreamingLevelStateConfig.DataAssetIdValue;
				LevelID = InPsmInstance.ConvertParamID2IntParam(ManagedStreamingLevelStateConfig.ConfigGuid);
			}
		}
	}

	protected class ManagedNpcUnitForPsm
	{
		public string NpcConfigGuid { get; }

		public string NpcUnitGuid { get; }

		public List<string> NpcUnitInstanceGuids { get; } = new List<string>();

		public string ActiveInstanceGuid { get; }

		public ManagedSmartParam TeamIdParamValue { get; }

		public ManagedSmartParam IdleAmIdxParamValue { get; }

		public ManagedSmartParam LeisureAnimIndexParamValue { get; }

		public ManagedSmartParam InteractGroupIdParamValue { get; }

		public ManagedNPCUnitParam ShowStateValue { get; }

		public List<ManagedNPCUnitBuffParam> BuffParamList { get; } = new List<ManagedNPCUnitBuffParam>();

		public ManagedNpcUnitForPsm(CalliopeCustom_ManagedNPCUnit ManagedNpcUnitData, PsmInstance InPsmInstance)
		{
			NpcConfigGuid = ManagedNpcUnitData.NpcGuid;
			TeamIdParamValue = ManagedNpcUnitData.TeamIdParamValue;
			IdleAmIdxParamValue = ManagedNpcUnitData.IdleAmIdxParamValue;
			LeisureAnimIndexParamValue = ManagedNpcUnitData.LeisureAnimIndexParamValue;
			InteractGroupIdParamValue = ManagedNpcUnitData.InteractGroupIdParamValue;
			ShowStateValue = ManagedNpcUnitData.ShowStateValue;
			BuffParamList = ManagedNpcUnitData.BuffInfoList.ToList();
			if (InPsmInstance == null)
			{
				return;
			}
			NpcUnitGuid = InPsmInstance.ConvertParamID2StringParam(ManagedNpcUnitData.NpcGuid);
			if (!InPsmInstance.TryGetParameter(ManagedNpcUnitData.NpcGuid, out var OutParameterInstance))
			{
				return;
			}
			foreach (PsmParameterSubInstance value2 in OutParameterInstance.ParamSubInstances.Values)
			{
				NpcUnitInstanceGuids.Add(value2.ParamValueStr);
			}
			if (ManagedNpcUnitData.ActiveInstanceValue != null && Guid.TryParse(ManagedNpcUnitData.ActiveInstanceValue.ManagedValue, out var result) && OutParameterInstance.ParamSubInstances.TryGetValue(result, out var value))
			{
				ActiveInstanceGuid = value.ParamValueStr;
			}
			else
			{
				ActiveInstanceGuid = "";
			}
		}
	}

	protected List<CalliopeCustom_ManagedSceneObj> ManagedSceneObjs { get; } = new List<CalliopeCustom_ManagedSceneObj>();

	protected List<CalliopeCustom_ManagedNPCUnit> ManagedNpcUnits { get; } = new List<CalliopeCustom_ManagedNPCUnit>();

	protected List<CalliopeCustom_ManagedGroupUnit> ManagedGroupUnits { get; } = new List<CalliopeCustom_ManagedGroupUnit>();

	protected List<CalliopeCustom_ManagedInteractor> ManagedInteractors { get; } = new List<CalliopeCustom_ManagedInteractor>();

	protected List<CalliopeCustom_ManagedStreamingLevelStateConfig> ManagedStreamingLevelStateConfigs { get; } = new List<CalliopeCustom_ManagedStreamingLevelStateConfig>();

	protected List<ManagedSceneObjForPsm> ManagedSceneObjsForPsm { get; } = new List<ManagedSceneObjForPsm>();

	protected List<ManagedNpcUnitForPsm> ManagedNPCUnitsForPsm { get; } = new List<ManagedNpcUnitForPsm>();

	protected List<ManagedGroupUnitForPsm> ManagedGroupUnitsForPsm { get; } = new List<ManagedGroupUnitForPsm>();

	protected List<ManagedInteractorForPsm> ManagedInteractorsForPsm { get; } = new List<ManagedInteractorForPsm>();

	protected List<ManagedStreamingLevelStateConfigForPsm> ManagedStreamingLevelStateConfigsForPsm { get; } = new List<ManagedStreamingLevelStateConfigForPsm>();

	protected BGW_EventCollection BGWEventCollection { get; set; }

	protected override void InitialData(byte[] CustomDataBytes)
	{
		BGWEventCollection = BGW_EventCollection.Get(GetOwner());
	}

	public override void PreStart()
	{
		base.PreStart();
		ManagedSceneObjsForPsm.Clear();
		foreach (CalliopeCustom_ManagedSceneObj managedSceneObj in ManagedSceneObjs)
		{
			ManagedSceneObjsForPsm.Add(new ManagedSceneObjForPsm(managedSceneObj, base.ParentPsmInstance));
		}
		ManagedNPCUnitsForPsm.Clear();
		foreach (CalliopeCustom_ManagedNPCUnit managedNpcUnit in ManagedNpcUnits)
		{
			ManagedNpcUnitForPsm managedNpcUnitForPsm = new ManagedNpcUnitForPsm(managedNpcUnit, base.ParentPsmInstance);
			ManagedNPCUnitsForPsm.Add(managedNpcUnitForPsm);
			if (managedNpcUnitForPsm.NpcUnitInstanceGuids.Count > 0 && base.ParentPsmInstance.TryGetParameter(managedNpcUnitForPsm.NpcConfigGuid, out var OutParameterInstance))
			{
				OutParameterInstance.ParamValueStr = managedNpcUnitForPsm.ActiveInstanceGuid;
			}
		}
		ManagedGroupUnitsForPsm.Clear();
		foreach (CalliopeCustom_ManagedGroupUnit managedGroupUnit in ManagedGroupUnits)
		{
			ManagedGroupUnitsForPsm.Add(new ManagedGroupUnitForPsm(managedGroupUnit, base.ParentPsmInstance));
		}
		ManagedInteractorsForPsm.Clear();
		foreach (CalliopeCustom_ManagedInteractor managedInteractor in ManagedInteractors)
		{
			ManagedInteractorsForPsm.Add(new ManagedInteractorForPsm(managedInteractor, base.ParentPsmInstance));
		}
		ManagedStreamingLevelStateConfigsForPsm.Clear();
		foreach (CalliopeCustom_ManagedStreamingLevelStateConfig managedStreamingLevelStateConfig in ManagedStreamingLevelStateConfigs)
		{
			ManagedStreamingLevelStateConfigsForPsm.Add(new ManagedStreamingLevelStateConfigForPsm(managedStreamingLevelStateConfig, base.ParentPsmInstance));
		}
	}

	protected void SetObjStateOnBeginning()
	{
		if (base.ParentPsmInstance == null)
		{
			return;
		}
		foreach (ManagedSceneObjForPsm item in ManagedSceneObjsForPsm)
		{
			FGameplayTag? fGameplayTag = null;
			EBGUResetType? eBGUResetType = null;
			EGsStreamingLevelState? eGsStreamingLevelState = null;
			switch (item.ObjType)
			{
			case ManagedSceneObjType.DynamicObstacle:
			{
				EDynamicObstacleState? eDynamicObstacleState = (EDynamicObstacleState)item.DefaultState;
				switch ((EDynamicObstacleManagePolice)(byte)item.ManagePolice)
				{
				case EDynamicObstacleManagePolice.KeepOpen:
					eDynamicObstacleState = EDynamicObstacleState.Opened;
					break;
				case EDynamicObstacleManagePolice.KeepClose:
					eDynamicObstacleState = EDynamicObstacleState.Closed;
					break;
				case EDynamicObstacleManagePolice.AsBattleInDoor:
					eDynamicObstacleState = EDynamicObstacleState.Opened;
					break;
				case EDynamicObstacleManagePolice.AsBattleOutDoor:
					eDynamicObstacleState = EDynamicObstacleState.Closed;
					break;
				}
				if (eDynamicObstacleState.HasValue)
				{
					switch (eDynamicObstacleState)
					{
					case EDynamicObstacleState.Opened:
						fGameplayTag = BGW_FlowUtils.DynamicObstacleTag.State_Disabled;
						break;
					case EDynamicObstacleState.Closed:
						fGameplayTag = BGW_FlowUtils.DynamicObstacleTag.State_Enabled;
						break;
					}
				}
				break;
			}
			case ManagedSceneObjType.Overlap:
			{
				EOverlapState eOverlapState = (EOverlapState)item.DefaultState;
				switch ((EOverlapManagePolice)(byte)item.ManagePolice)
				{
				case EOverlapManagePolice.KeepEnable:
					eOverlapState = EOverlapState.Enabled;
					break;
				case EOverlapManagePolice.KeepDisable:
					eOverlapState = EOverlapState.Disabled;
					break;
				}
				switch (eOverlapState)
				{
				case EOverlapState.Enabled:
					fGameplayTag = BGW_FlowUtils.OverlapTag.State_Enabled;
					break;
				case EOverlapState.Disabled:
					fGameplayTag = BGW_FlowUtils.OverlapTag.State_Disabled;
					break;
				}
				break;
			}
			case ManagedSceneObjType.Spawner:
			{
				ESpawnerState? eSpawnerState = (ESpawnerState)item.DefaultState;
				switch ((ESpawnerManagePolice)(byte)item.ManagePolice)
				{
				case ESpawnerManagePolice.Auto:
					eSpawnerState = null;
					break;
				case ESpawnerManagePolice.SameAsBattle:
					eSpawnerState = ESpawnerState.Enabled;
					break;
				case ESpawnerManagePolice.OnlyBeginSameAsBattle:
					eSpawnerState = ESpawnerState.Enabled;
					break;
				case ESpawnerManagePolice.OnlyEndSameAsBattle:
					eSpawnerState = null;
					break;
				case ESpawnerManagePolice.Disable:
					eSpawnerState = ESpawnerState.Disabled;
					break;
				case ESpawnerManagePolice.BeginLikeStateEndLikeBattle:
					eSpawnerState = ESpawnerState.Spawned;
					break;
				}
				if (eSpawnerState.HasValue)
				{
					switch (eSpawnerState)
					{
					case ESpawnerState.Disabled:
						fGameplayTag = BGW_FlowUtils.SpawnerTag.State_Disabled;
						break;
					case ESpawnerState.Enabled:
						fGameplayTag = BGW_FlowUtils.SpawnerTag.State_Idled;
						break;
					case ESpawnerState.Spawned:
						fGameplayTag = BGW_FlowUtils.SpawnerTag.State_Spawned;
						break;
					}
				}
				break;
			}
			case ManagedSceneObjType.Unit:
				eBGUResetType = (EBGUResetType)item.DefaultState;
				switch ((EUnitManagePolice)(byte)item.ManagePolice)
				{
				case EUnitManagePolice.Status:
					eBGUResetType = EBGUResetType.Status;
					break;
				case EUnitManagePolice.StatusWithoutHP:
					eBGUResetType = EBGUResetType.StatusWithoutHp;
					break;
				case EUnitManagePolice.Spawn:
					eBGUResetType = EBGUResetType.Spawn;
					break;
				case EUnitManagePolice.Destroy:
					eBGUResetType = EBGUResetType.Destroy;
					break;
				}
				break;
			case ManagedSceneObjType.StreamingLevel:
				eGsStreamingLevelState = (EGsStreamingLevelState)item.DefaultState;
				switch ((EGsStreamingLevelManagePolice)(byte)item.ManagePolice)
				{
				case EGsStreamingLevelManagePolice.DefaultLoadAndShow:
					eGsStreamingLevelState = EGsStreamingLevelState.LoadedAndShown;
					break;
				case EGsStreamingLevelManagePolice.DefaultUnload:
					eGsStreamingLevelState = EGsStreamingLevelState.Unloaded;
					break;
				}
				break;
			}
			if (fGameplayTag.HasValue)
			{
				BGWEventCollection.Evt_SetSceneObjState(item.ObjGuid, fGameplayTag.Value);
			}
			if (eBGUResetType.HasValue)
			{
				BGWEventCollection.Evt_SetActorResetTypeOverride(item.ObjGuid, eBGUResetType.Value);
			}
			if (!eGsStreamingLevelState.HasValue)
			{
				continue;
			}
			string[] array = item.ObjGuid.Split('.');
			if (array.Length == 2)
			{
				string levelName = array[0];
				string text = array[1];
				if (B1Global.GIsBossRushMode)
				{
					UBGUWCStreamingFuncLib.SetLevelsState(base.ParentPsmInstance.Owner, text, (eGsStreamingLevelState.Value != EGsStreamingLevelState.Unloaded) ? EGSLevelState.LoadedVisible : EGSLevelState.Unloaded);
					continue;
				}
				int levelIdByLevelName = UBGWFunctionLibraryCS.GetLevelIdByLevelName(levelName);
				FGSLevelStateControlInfo fGSLevelStateControlInfo = new FGSLevelStateControlInfo();
				fGSLevelStateControlInfo.DefaultLevelManageInfo.ManagedLevels.Add(text, new FGSLevelStateInfo(text, (eGsStreamingLevelState.Value != EGsStreamingLevelState.Unloaded) ? EGSLevelState.LoadedVisible : EGSLevelState.Unloaded, disableKeyword: true, EGSLevelStateInfoLayerType.CPG, "流式关卡列表控制 CPG: " + base.ParentPsmInstance.PsmGuid + " : " + base.ParentPsmInstance.TemplateAsset.AssetPath + " | Level: " + item.ObjGuid));
				BGW_LevelStreamingStateMgr.Get(base.ParentPsmInstance.Owner)?.UpdateLevelState(base.ParentPsmInstance.PsmGuid + "|" + base.ParentPsmInstance.TemplateAsset.AssetPath + "|" + item.ObjGuid, levelIdByLevelName, fGSLevelStateControlInfo, EGSLevelStateInfoLayerType.CPG);
			}
		}
		foreach (ManagedNpcUnitForPsm item2 in ManagedNPCUnitsForPsm)
		{
			PsmParameterInstance OutParameterInstance;
			int teamID = (base.ParentPsmInstance.TryGetParameter(item2.TeamIdParamValue.ManagedValue, out OutParameterInstance) ? OutParameterInstance.ParamValueInt : 99);
			int idleAMIdx = base.ParentPsmInstance.ConvertParamID2IntParam(item2.IdleAmIdxParamValue.ManagedValue);
			int leisureAnimIndex = (base.ParentPsmInstance.TryGetParameter(item2.LeisureAnimIndexParamValue.ManagedValue, out OutParameterInstance) ? OutParameterInstance.ParamValueInt : (-1));
			int interactGroupID = base.ParentPsmInstance.ConvertParamID2IntParam(item2.InteractGroupIdParamValue.ManagedValue);
			EGsNPCShowState nPCShowState = (EGsNPCShowState)item2.ShowStateValue.ManagedValue;
			List<NPCBuffInfo> list = new List<NPCBuffInfo>();
			foreach (ManagedNPCUnitBuffParam buffParam in item2.BuffParamList)
			{
				list.Add(new NPCBuffInfo
				{
					BuffID = base.ParentPsmInstance.ConvertParamID2IntParam(buffParam.BuffParamId),
					bIsAdd = (buffParam.ManagedValue == 0)
				});
			}
			if (item2.NpcUnitInstanceGuids.Count == 0)
			{
				BGWEventCollection.Evt_BGW_CacheNPCInfo(item2.NpcUnitGuid, teamID, idleAMIdx, leisureAnimIndex, interactGroupID, nPCShowState, list);
				continue;
			}
			foreach (string npcUnitInstanceGuid in item2.NpcUnitInstanceGuids)
			{
				if (npcUnitInstanceGuid == item2.ActiveInstanceGuid)
				{
					BGWEventCollection.Evt_BGW_CacheNPCInfo(npcUnitInstanceGuid, teamID, idleAMIdx, leisureAnimIndex, interactGroupID, EGsNPCShowState.Show, list);
				}
				else
				{
					BGWEventCollection.Evt_BGW_CacheNPCInfo(npcUnitInstanceGuid, teamID, idleAMIdx, leisureAnimIndex, interactGroupID, EGsNPCShowState.Hide, list);
				}
			}
		}
		foreach (ManagedGroupUnitForPsm item3 in ManagedGroupUnitsForPsm)
		{
			EBGUResetType? eBGUResetType2 = (EBGUResetType)item3.DefaultState;
			switch ((EUnitManagePolice)(byte)item3.ManagePolice)
			{
			case EUnitManagePolice.Status:
				eBGUResetType2 = EBGUResetType.Status;
				break;
			case EUnitManagePolice.StatusWithoutHP:
				eBGUResetType2 = EBGUResetType.StatusWithoutHp;
				break;
			case EUnitManagePolice.Spawn:
				eBGUResetType2 = EBGUResetType.Spawn;
				break;
			case EUnitManagePolice.Destroy:
				eBGUResetType2 = EBGUResetType.Destroy;
				break;
			}
			if (eBGUResetType2.HasValue)
			{
				BGWEventCollection.Evt_SetGroupResetTypeOverride(item3.ObjGuid, eBGUResetType2.Value);
			}
		}
		UObject owner = GetOwner();
		foreach (ManagedStreamingLevelStateConfigForPsm item4 in ManagedStreamingLevelStateConfigsForPsm)
		{
			BGW_LevelStreamingStateMgr.Get(owner)?.UpdateLevelState(item4.ConfigGuid, item4.LevelID, item4.DataAssetID.ManagedValue, EGSLevelStateInfoLayerType.CPG, $"CPG: {base.ParentPsmInstance.PsmGuid} : {base.ParentPsmInstance.TemplateAsset.AssetPath} | DA_id: {item4.DataAssetID.ManagedValue}");
		}
		foreach (ManagedInteractorForPsm item5 in ManagedInteractorsForPsm)
		{
			BGWEventCollection.Evt_SendUpdateInteractGroup(item5.ObjGuid, item5.GroupID);
		}
	}

	protected void SetObjStateBeforeBattle()
	{
		if (base.ParentPsmInstance == null)
		{
			return;
		}
		foreach (ManagedSceneObjForPsm item in ManagedSceneObjsForPsm)
		{
			if (item.ObjType == ManagedSceneObjType.DynamicObstacle && (byte)item.ManagePolice == 3)
			{
				BGWEventCollection.Evt_SetSceneObjState(item.ObjGuid, BGW_FlowUtils.DynamicObstacleTag.State_Enabled);
			}
			if (item.ObjType == ManagedSceneObjType.Spawner)
			{
				ESpawnerManagePolice eSpawnerManagePolice = (ESpawnerManagePolice)item.ManagePolice;
				if (eSpawnerManagePolice - 2 <= ESpawnerManagePolice.Auto)
				{
					BGWEventCollection.Evt_SetSceneObjState(item.ObjGuid, BGW_FlowUtils.SpawnerTag.State_Spawned);
				}
			}
		}
	}

	protected void SetObjStateAfterBattle()
	{
		if (base.ParentPsmInstance == null)
		{
			return;
		}
		foreach (ManagedSceneObjForPsm item in ManagedSceneObjsForPsm)
		{
			if (item.ObjType == ManagedSceneObjType.DynamicObstacle)
			{
				EDynamicObstacleManagePolice eDynamicObstacleManagePolice = (EDynamicObstacleManagePolice)item.ManagePolice;
				if (eDynamicObstacleManagePolice - 3 <= EDynamicObstacleManagePolice.KeepOpen)
				{
					BGWEventCollection.Evt_SetSceneObjState(item.ObjGuid, BGW_FlowUtils.DynamicObstacleTag.State_Disabled);
				}
			}
			if (item.ObjType == ManagedSceneObjType.Spawner)
			{
				switch ((ESpawnerManagePolice)(byte)item.ManagePolice)
				{
				case ESpawnerManagePolice.SameAsBattle:
				case ESpawnerManagePolice.OnlyEndSameAsBattle:
				case ESpawnerManagePolice.BeginLikeStateEndLikeBattle:
					BGWEventCollection.Evt_SetSceneObjState(item.ObjGuid, BGW_FlowUtils.SpawnerTag.State_Disabled);
					break;
				}
			}
		}
	}
}
