using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_TriggerProcessControlCompImpl : UActorCompBaseCS
{
	private b1.BUC_TriggerProcessControllerData TriggerProcessControllerData;

	private float UpdateTimer;

	private IBIC_StateMachineData StateMachineData { get; set; }

	public override void OnAttach()
	{
		TriggerProcessControllerData = RequireWritableData<b1.BUC_TriggerProcessControllerData>();
		Init();
		StateMachineData = RequireReadonlyGameInstanceData<IBIC_StateMachineData, BIC_StateMachineData>();
	}

	private void Init()
	{
		UpdateTimer = 0.5f;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (UpdateTimer > 0f)
		{
			UpdateTimer -= DeltaTime;
			if (UpdateTimer > 0f)
			{
				return;
			}
			UpdateTimer = 0.5f;
		}
		bool flag = true;
		List<string> list = new List<string>();
		foreach (FSceneObjWithState attachedTriggerObj in TriggerProcessControllerData.AttachedTriggerObjs)
		{
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(GetOwner(), attachedTriggerObj.UnitGuid);
			if (!actorByGuid.IsNullOrDestroyed())
			{
				b1.IBUC_TriggerData readOnlyData = BGU_DataUtil.GetReadOnlyData<b1.IBUC_TriggerData, b1.BUC_TriggerData>(actorByGuid);
				if (readOnlyData != null)
				{
					list.Add(readOnlyData.TriggerActorGuid);
				}
			}
			if (StateMachineData.GetCurrentSceneObjState(attachedTriggerObj.UnitGuid, out var GameplayTagContainerRef) && (attachedTriggerObj.ActiveState != ESceneObjTransitionState.State2 || GameplayTagContainerRef.HasTag(BGW_FlowUtils.TriggerTag.State_Triggered)))
			{
				continue;
			}
			if (flag)
			{
				list.Clear();
			}
			flag = false;
			if (actorByGuid != null)
			{
				b1.IBUC_TriggerData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<b1.IBUC_TriggerData, b1.BUC_TriggerData>(actorByGuid);
				if (readOnlyData2 != null)
				{
					list.Add(readOnlyData2.TriggerActorGuid);
				}
			}
		}
		Dictionary<int, bool> dictionary = new Dictionary<int, bool>();
		foreach (KeyValuePair<int, bool> item in TriggerProcessControllerData.MapObjIndexActiveState)
		{
			FSceneObjTriggerEvent fSceneObjTriggerEvent = TriggerProcessControllerData.NeedActivateObjs[item.Key];
			AActor actorByGuid2 = BGU_DataUtil.GetActorByGuid(GetOwner(), fSceneObjTriggerEvent.UnitGuid);
			if (!(actorByGuid2 == null))
			{
				if (flag && !item.Value)
				{
					FSceneObjTriggerEventParam Param = new FSceneObjTriggerEventParam
					{
						TriggerActorsGuid = list
					};
					TriggerEvent(actorByGuid2, fSceneObjTriggerEvent.TriggerEvent, ref Param);
					dictionary.Add(item.Key, value: true);
				}
				if (!flag && item.Value)
				{
					FSceneObjTriggerEventParam Param2 = new FSceneObjTriggerEventParam
					{
						TriggerActorsGuid = list
					};
					TriggerEvent(actorByGuid2, fSceneObjTriggerEvent.UnTriggerEvent, ref Param2);
					dictionary.Add(item.Key, value: false);
				}
			}
		}
		if (dictionary.Count <= 0)
		{
			return;
		}
		foreach (KeyValuePair<int, bool> item2 in dictionary)
		{
			TriggerProcessControllerData.MapObjIndexActiveState[item2.Key] = item2.Value;
		}
	}

	protected void TriggerEvent(AActor Obj, ESceneObjTransitionEvent Event, ref FSceneObjTriggerEventParam Param)
	{
		FGameplayTag tag = Event switch
		{
			ESceneObjTransitionEvent.OnSpawn => BGW_FlowUtils.SceneObjCommonEventTag.Spawn, 
			ESceneObjTransitionEvent.OnReset => BGW_FlowUtils.SceneObjCommonEventTag.Reset, 
			ESceneObjTransitionEvent.NextState => BGW_FlowUtils.SceneObjCommonEventTag.Next, 
			ESceneObjTransitionEvent.JumpToState0 => BGW_FlowUtils.SceneObjCommonEventTag.JumpToState0, 
			ESceneObjTransitionEvent.JumpToState1 => BGW_FlowUtils.SceneObjCommonEventTag.JumpToState1, 
			ESceneObjTransitionEvent.JumpToState2 => BGW_FlowUtils.SceneObjCommonEventTag.JumpToState2, 
			ESceneObjTransitionEvent.JumpToState3 => BGW_FlowUtils.SceneObjCommonEventTag.JumpToState3, 
			_ => throw new ArgumentOutOfRangeException("Event", Event, null), 
		};
		BUS_EventCollectionCS.Get(Obj).Evt_SetTriggerActors.Invoke(Param.TriggerActorsGuid);
		BUS_EventCollectionCS.Get(Obj).Evt_SceneObjTransitByEvent.Invoke(tag);
	}
}
