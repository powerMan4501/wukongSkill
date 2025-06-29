using System;
using ArchiveB1;
using b1.EventDelDefine;
using Google.Protobuf.Collections;
using GurGsPersistent;

namespace b1;

public class BIS_CollectionGroupSystem : GameInstanceSystemBase
{
	private BIC_CollectionGroupData CollectionGroupData { get; set; }

	private BIC_PersistentECSData PersistentECSData { get; set; }

	private BGW_EventCollection EventCollection { get; set; }

	public override void OnAttach()
	{
		CollectionGroupData = RequireWritableGameInstanceData<BIC_CollectionGroupData>();
		CollectionGroupData.CollectionGroupMgr.OnReSetGameData();
		PersistentECSData = RequireWritableGameInstanceData<BIC_PersistentECSData>();
		EventCollection = BGW_EventCollection.Get(base.Owner);
		if (EventCollection != null)
		{
			BGW_EventCollection eventCollection = EventCollection;
			eventCollection.Evt_SaveCollectionGroupInfo = (Del_Void_IntString)Delegate.Combine(eventCollection.Evt_SaveCollectionGroupInfo, new Del_Void_IntString(SaveCollectionGroupInfo));
			BGW_EventCollection eventCollection2 = EventCollection;
			eventCollection2.Evt_ResetGameInstanceData = (BGW_EventCollection.Del_BGW_ResetGameInstanceData)Delegate.Combine(eventCollection2.Evt_ResetGameInstanceData, new BGW_EventCollection.Del_BGW_ResetGameInstanceData(OnReSetGameData));
			BGW_EventCollection eventCollection3 = EventCollection;
			eventCollection3.Evt_InitCollectionSpawnActorState = (Del_Void_InitSpawnActorState)Delegate.Combine(eventCollection3.Evt_InitCollectionSpawnActorState, new Del_Void_InitSpawnActorState(InitSpawnActorState));
			BGW_EventCollection eventCollection4 = EventCollection;
			eventCollection4.Evt_RecoverArchiveData = (BGW_EventCollection.Del_BGW_Void_ArchiveData)Delegate.Combine(eventCollection4.Evt_RecoverArchiveData, new BGW_EventCollection.Del_BGW_Void_ArchiveData(OnRecoverArchiveData));
		}
	}

	private void OnRecoverArchiveData(FUStBEDArchivesData ArchivesData)
	{
		RepeatedField<DictDeltaMsgInt_CollectionGroupDataInfo> repeatedField = ArchivesData.PersistentECSData.BGCData?.BGCCollectionGroupData?.CollectionGroupDataInfo;
		if (repeatedField == null)
		{
			return;
		}
		foreach (DictDeltaMsgInt_CollectionGroupDataInfo item in repeatedField)
		{
			CollectionGroupData.CollectionGroupMgr.RecoverCollectionGroupData(item.Key, item.Value, PersistentECSData);
		}
	}

	private void OnReSetGameData(EGameInstanceResetType ResetType)
	{
		CollectionGroupData.CollectionGroupMgr.OnReSetGameData();
	}

	private void SaveCollectionGroupInfo(int GroupId, string Guid = "")
	{
		CollectionGroupData.CollectionGroupMgr.SaveCollectionGroupInfo(GroupId, Guid);
	}

	public void InitSpawnActorState(string CurrentLevelName)
	{
		CollectionGroupData.CollectionGroupMgr.InitSpawnActorState(CurrentLevelName, PersistentECSData);
	}
}
