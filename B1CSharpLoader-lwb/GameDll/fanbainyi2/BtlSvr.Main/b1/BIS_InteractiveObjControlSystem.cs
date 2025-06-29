using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using GurGsPersistent;

namespace b1;

public class BIS_InteractiveObjControlSystem : GameInstanceSystemBase
{
	private BIC_PersistentECSData PersistentECSData { get; set; }

	private BGW_EventCollection EventCollection { get; set; }

	private IBIC_LevelData LevelData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		PersistentECSData = RequireWritableGameInstanceData<BIC_PersistentECSData>();
		LevelData = RequireReadonlyGameInstanceData<IBIC_LevelData, BIC_LevelData>();
		EventCollection = BGW_EventCollection.Get(base.Owner);
		if (EventCollection != null)
		{
			BGW_EventCollection eventCollection = EventCollection;
			eventCollection.Evt_SendUpdateInteractGroup = (Del_Void_StringInt)Delegate.Combine(eventCollection.Evt_SendUpdateInteractGroup, new Del_Void_StringInt(OnSendUpdateInteractGroup));
		}
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		if (EventCollection != null)
		{
			BGW_EventCollection eventCollection = EventCollection;
			eventCollection.Evt_SendUpdateInteractGroup = (Del_Void_StringInt)Delegate.Remove(eventCollection.Evt_SendUpdateInteractGroup, new Del_Void_StringInt(OnSendUpdateInteractGroup));
		}
	}

	private void OnSendUpdateInteractGroup(string ActorGuid, int InGroupID)
	{
		List<FUStInteractionMappingDesc> interactionActionsByGroupID = BGW_GameDB.GetInteractionActionsByGroupID(InGroupID);
		EBGUInteractUnitState state = EBGUInteractUnitState.BeforeInactive;
		if (InGroupID != 0 && interactionActionsByGroupID != null && interactionActionsByGroupID.Count >= 1 && interactionActionsByGroupID[0].ActionCanInteract == EGSYesNo.Yes)
		{
			state = EBGUInteractUnitState.BeforeActive;
		}
		if (!PersistentECSData.FindOrAllocBUCDataByGuid(ActorGuid, out var Ret) || Ret.BUCInteractData == null || !Ret.BUCInteractData.HasActionGroupIDPersistent || Ret.BUCInteractData.ActionGroupIDPersistent != InGroupID)
		{
			SyncStateToActor(ActorGuid, InGroupID, state, OnlyState: false, Ret);
		}
	}

	private void SyncStateToActor(string Guid, int InteractGroupID, EBGUInteractUnitState State, bool OnlyState, PersistentBUCData PersistentBUCData)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(BGU_DataUtil.GetActorByGuid(base.Owner, Guid));
		if (bUS_GSEventCollection != null)
		{
			if (OnlyState)
			{
				bUS_GSEventCollection.Evt_InteractState_Update.Invoke(State, UpdatePersistent: false);
			}
			else
			{
				bUS_GSEventCollection.Evt_InteractGroup_Update.Invoke(InteractGroupID, State);
			}
			return;
		}
		if (PersistentBUCData.BUCInteractData == null)
		{
			PersistentBUCData.BUCInteractData = new GurGsPersistent.BUC_InteractData
			{
				ActionGroupIDPersistent = InteractGroupID,
				InteractUnitStatePersistent = (int)State
			};
		}
		PersistentBUCData.BUCInteractData.ActionGroupIDPersistent = InteractGroupID;
		PersistentBUCData.BUCInteractData.InteractUnitStatePersistent = (int)State;
	}
}
