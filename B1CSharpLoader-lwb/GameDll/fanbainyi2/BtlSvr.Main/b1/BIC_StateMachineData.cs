using System;
using System.Collections.Generic;
using ArchiveB1;
using b1.CppExport;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BIC_StateMachineData : IBIC_StateMachineData
{
	public UObject Owner { get; set; }

	public bool bInitialCustomStateMachines { get; set; }

	public bool bPaused { get; set; }

	public Dictionary<string, PsmInstance> PsmInstances { get; } = new Dictionary<string, PsmInstance>();

	public StateMachineArchiveData ArchiveData { get; set; }

	public Dictionary<string, PsmArchiveGraphData> PsmArchiveDataCache { get; } = new Dictionary<string, PsmArchiveGraphData>();

	public Dictionary<string, GameplayTagContainerRef> SceneObjState { get; } = new Dictionary<string, GameplayTagContainerRef>();

	public Dictionary<string, Dictionary<FGameplayTag, FGameplayTag>> SceneObjTransientState { get; } = new Dictionary<string, Dictionary<FGameplayTag, FGameplayTag>>();

	public Dictionary<string, List<FGameplayTag>> SceneObjEvent { get; } = new Dictionary<string, List<FGameplayTag>>();

	public Dictionary<string, Queue<FGameplayTag>> SceneObjStateCache { get; } = new Dictionary<string, Queue<FGameplayTag>>();

	public Dictionary<string, bool> StateMachineNeedReset { get; } = new Dictionary<string, bool>();

	public Dictionary<Type, BUS_StateMachineCompBase.GSStateBase> StateCaches { get; } = new Dictionary<Type, BUS_StateMachineCompBase.GSStateBase>();

	public bool GetCurrentSceneObjState(string UnitGuid, out GameplayTagContainerRef StateTagContainer, bool bOuterQuery = true)
	{
		StateTagContainer = new GameplayTagContainerRef();
		if (!SceneObjState.ContainsKey(UnitGuid))
		{
			if (!(Owner != null && bOuterQuery))
			{
				return false;
			}
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, UnitGuid);
			if (!(actorByGuid != null))
			{
				return false;
			}
			BUS_EventCollectionCS.Get(actorByGuid)?.Evt_SceneObjTransitByEvent.Invoke(BGW_FlowUtils.SceneObjCommonEventTag.Spawn);
			if (!SceneObjState.ContainsKey(UnitGuid))
			{
				return false;
			}
		}
		StateTagContainer.Append(SceneObjState[UnitGuid]);
		if (SceneObjTransientState.ContainsKey(UnitGuid))
		{
			foreach (KeyValuePair<FGameplayTag, FGameplayTag> item in SceneObjTransientState[UnitGuid])
			{
				if (StateTagContainer.HasTag(item.Key))
				{
					StateTagContainer.RemoveTag(item.Key);
					StateTagContainer.AddTag(item.Value);
				}
			}
		}
		return true;
	}

	public bool GetUnhandledSceneObjEvents(string UnitGuid, in List<FName> EventTagContainer, out List<FGameplayTag> EventTags)
	{
		Dictionary<string, List<FGameplayTag>> sceneObjEvent = SceneObjEvent;
		EventTags = new List<FGameplayTag>();
		if (!sceneObjEvent.ContainsKey(UnitGuid))
		{
			return false;
		}
		foreach (FGameplayTag item in sceneObjEvent[UnitGuid])
		{
			if (EventTagContainer.Contains(item.TagName))
			{
				EventTags.Add(item);
			}
		}
		return true;
	}

	public bool IsStateMachineNeedReset(string UnitGuid)
	{
		if (StateMachineNeedReset.TryGetValue(UnitGuid, out var value))
		{
			return value;
		}
		return false;
	}

	public BUS_StateMachineCompBase.GSStateBase GetState(Type StateType)
	{
		if (!StateCaches.ContainsKey(StateType))
		{
			return null;
		}
		return StateCaches[StateType];
	}

	public bool IsAllActionFinished(string PsmGuid, Guid InNodeGuid)
	{
		bool result = false;
		if (PsmInstances.TryGetValue(PsmGuid, out var value))
		{
			result = true;
			if (value.IdleNodeProcessActions.TryGetValue(InNodeGuid, out var value2))
			{
				foreach (FIdleProcessExecutorBase item in value2)
				{
					if (!item.IsFinished())
					{
						result = false;
					}
				}
			}
		}
		return result;
	}

	public bool IsAiConversationChainEnd(string PsmGuid, Guid InNodeGuid)
	{
		bool result = false;
		if (PsmInstances.TryGetValue(PsmGuid, out var value))
		{
			result = true;
			if (value.IdleNodeProcessActions.TryGetValue(InNodeGuid, out var value2))
			{
				foreach (FIdleProcessExecutorBase item in value2)
				{
					if (!item.IsAiConversationChainEnd())
					{
						result = false;
					}
				}
			}
		}
		return result;
	}

	public int GetAllSceneObjState(out Dictionary<string, GameplayTagContainerRef> OutSceneObjState)
	{
		OutSceneObjState = SceneObjState;
		return OutSceneObjState.Count;
	}

	public int GetAllSceneObjTransientState(out Dictionary<string, Dictionary<FGameplayTag, FGameplayTag>> OutSceneObjTransientState)
	{
		OutSceneObjTransientState = SceneObjTransientState;
		return OutSceneObjTransientState.Count;
	}

	bool IBIC_StateMachineData.GetUnhandledSceneObjEvents(string UnitGuid, in List<FName> GameplayTagContainerRef, out List<FGameplayTag> FGameplayTags)
	{
		return GetUnhandledSceneObjEvents(UnitGuid, in GameplayTagContainerRef, out FGameplayTags);
	}
}
