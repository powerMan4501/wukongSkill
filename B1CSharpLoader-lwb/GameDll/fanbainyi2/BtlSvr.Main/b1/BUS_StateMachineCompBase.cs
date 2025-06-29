using System;
using System.Collections.Generic;
using b1.CppExport;
using b1.EventDelDefine;
using GUR.Runtime;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_StateMachineCompBase : BUS_QuestCompBase
{
	[InstanceFactory(bUseTypeAsKey = true)]
	public abstract class GSStateBase
	{
		public abstract FGameplayTag StateTag { get; }

		public GameplayTagDictionary<FGameplayTag> EventTransitDictionary { get; } = new GameplayTagDictionary<FGameplayTag>();

		public GameplayTagDictionary<Action<BUS_StateMachineCompBase>> ReactionDictionary { get; } = new GameplayTagDictionary<Action<BUS_StateMachineCompBase>>();

		public GameplayTagDictionary<Action<BUS_StateMachineCompBase>> ExtraActionDictionary { get; } = new GameplayTagDictionary<Action<BUS_StateMachineCompBase>>();

		public virtual void OnInitialize()
		{
			EventTransitDictionary.Clear();
			ReactionDictionary.Clear();
			ExtraActionDictionary.Clear();
		}

		public virtual void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
		}

		public virtual void OnExitAction(BUS_StateMachineCompBase InOwner)
		{
		}

		public virtual void OnTickAction(BUS_StateMachineCompBase InOwner, float DeltaTime)
		{
		}

		public virtual void OnInitialAction(BUS_StateMachineCompBase InOwner)
		{
			OnEnterAction(InOwner);
		}

		public virtual void OnRecoverAction(BUS_StateMachineCompBase InOwner)
		{
			OnExitAction(InOwner);
			OnEnterAction(InOwner);
		}

		protected void ForceJumpToState(BUS_StateMachineCompBase InOwner, FGameplayTag InStateTag)
		{
			InOwner?.OnForceJumpToState(InStateTag);
		}

		protected void TransitionByEvent(BUS_StateMachineCompBase InOwner, FGameplayTag InEventTag)
		{
			InOwner?.OnEvent(InEventTag);
		}

		protected void NotifyGraph(BUS_StateMachineCompBase InOwner, FGameplayTag InNotifyTag)
		{
			InOwner?.NotifyGraph(InNotifyTag);
		}
	}

	private static readonly int MaxStateNum = 10;

	public Dictionary<FGameplayTag, GSStateBase> States { get; } = new Dictionary<FGameplayTag, GSStateBase>();

	public GameplayTagContainerRef StateTagContainer { get; set; }

	public List<FName> EventTagContainer { get; } = new List<FName>();

	private GSStateBase[] IndexStates { get; set; } = new GSStateBase[MaxStateNum];

	public GSStateBase CurrentState { get; private set; }

	protected GSStateBase InitialState { get; set; }

	protected FGameplayTag SceneObjTag { get; set; }

	private Queue<FGameplayTag> EventQueue { get; } = new Queue<FGameplayTag>();

	private bool bInEventHandler { get; set; }

	private IBIC_StateMachineData StateMachineData { get; set; }

	private bool bNotSaveState { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		StateTagContainer = new GameplayTagContainerRef();
		StateMachineData = RequireReadonlyGameInstanceData<IBIC_StateMachineData, BIC_StateMachineData>();
		if (OwnerAsCharacterCS != null)
		{
			bNotSaveState = OwnerAsCharacterCS.TamerType != ETamerType.LevelLoaded;
		}
		base.BUSEventCollection.Evt_SceneObjDirectJumpToState += new Del_Void_GameplayTag(OnForceJumpToState);
		base.BUSEventCollection.Evt_SceneObjTransitByEvent += new Del_Void_GameplayTag(OnMulticastEvent);
		base.BUSEventCollection.Evt_SceneObjTransitByEventNoSaveState += new Del_Void_GameplayTag(OnNoSaveEvent);
		base.BUSEventCollection.Evt_NotifyStartObserve += new Del_Void(OnNotifyStartObserve);
	}

	public override void OnNetActive()
	{
		base.OnNetActive();
		if (bNotSaveState)
		{
			OnSpawn();
			return;
		}
		string finalGuid = base.GuidData.GetFinalGuid();
		if (StateMachineData.IsStateMachineNeedReset(finalGuid))
		{
			OnReset();
			base.BGWEventCollection.Evt_SetStateMachineNeedReset(finalGuid, P2: false);
		}
		else
		{
			OnSpawn();
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if ((TickGroup & 0x400) != 0)
		{
			CurrentState?.OnTickAction(this, DeltaTime);
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		States.Clear();
		StateTagContainer.RemoveAllTags();
		EventTagContainer.Clear();
		for (int i = 0; i < MaxStateNum; i++)
		{
			IndexStates[i] = null;
		}
		InitialState = null;
		EventQueue.Clear();
		bInEventHandler = false;
		base.BUSEventCollection.Evt_SceneObjDirectJumpToState -= new Del_Void_GameplayTag(OnForceJumpToState);
		base.BUSEventCollection.Evt_SceneObjTransitByEvent -= new Del_Void_GameplayTag(OnMulticastEvent);
		base.BUSEventCollection.Evt_SceneObjTransitByEventNoSaveState -= new Del_Void_GameplayTag(OnNoSaveEvent);
		CurrentState = null;
	}

	protected virtual bool IsIgnoreSavedState()
	{
		return false;
	}

	protected void EnableStateTransition()
	{
		base.BUSEventCollection.Evt_SceneObjDirectJumpToState += new Del_Void_GameplayTag(OnForceJumpToState);
		base.BUSEventCollection.Evt_SceneObjTransitByEvent += new Del_Void_GameplayTag(OnMulticastEvent);
		base.BUSEventCollection.Evt_SceneObjTransitByEventNoSaveState += new Del_Void_GameplayTag(OnNoSaveEvent);
	}

	protected void DisableStateTransition()
	{
		base.BUSEventCollection.Evt_SceneObjDirectJumpToState -= new Del_Void_GameplayTag(OnForceJumpToState);
		base.BUSEventCollection.Evt_SceneObjTransitByEvent -= new Del_Void_GameplayTag(OnMulticastEvent);
		base.BUSEventCollection.Evt_SceneObjTransitByEventNoSaveState -= new Del_Void_GameplayTag(OnNoSaveEvent);
	}

	protected GSStateBase AddState(Type StateType, int Index = -1)
	{
		if (Index >= MaxStateNum)
		{
			return null;
		}
		GSStateBase state = StateMachineData.GetState(StateType);
		if (state == null)
		{
			return null;
		}
		if (States.ContainsKey(state.StateTag))
		{
			return state;
		}
		if (Index < 0)
		{
			IndexStates[States.Count] = state;
		}
		else
		{
			IndexStates[Index] = state;
		}
		States.Add(state.StateTag, state);
		StateTagContainer.AddTag(state.StateTag);
		foreach (KeyValuePair<FName, FGameplayTag> item in state.EventTransitDictionary)
		{
			if (!EventTagContainer.Contains(item.Key))
			{
				EventTagContainer.Add(item.Key);
			}
		}
		foreach (KeyValuePair<FName, Action<BUS_StateMachineCompBase>> item2 in state.ReactionDictionary)
		{
			if (!EventTagContainer.Contains(item2.Key))
			{
				EventTagContainer.Add(item2.Key);
			}
		}
		return state;
	}

	protected virtual void OnForceJumpToState(FGameplayTag StateTag)
	{
		if (States.ContainsKey(StateTag))
		{
			GSStateBase targetState = States[StateTag];
			JumpToState(targetState);
		}
	}

	protected void JumpToState(GSStateBase TargetState, bool bSaveState = true)
	{
		if (CurrentState != null)
		{
			CurrentState.OnExitAction(this);
			if (CurrentState.ExtraActionDictionary.ContainsTag(TargetState.StateTag))
			{
				CurrentState.ExtraActionDictionary.GetValue(TargetState.StateTag)(this);
			}
		}
		UpdateCurrentState(TargetState, bSaveState);
		TargetState.OnEnterAction(this);
	}

	protected void ResetToInitialState()
	{
		GSStateBase gSStateBase = null;
		if (IsIgnoreSavedState() || bNotSaveState)
		{
			gSStateBase = InitialState;
		}
		else
		{
			if (StateMachineData.GetCurrentSceneObjState(base.GuidData.GetFinalGuid(), out var GameplayTagContainerRef, bOuterQuery: false))
			{
				foreach (FGameplayTag item in StateTagContainer)
				{
					if (GameplayTagContainerRef.HasTag(item))
					{
						gSStateBase = States[item];
						break;
					}
				}
			}
			if (gSStateBase == null && InitialState != null)
			{
				gSStateBase = InitialState;
			}
		}
		if (gSStateBase != null)
		{
			UpdateCurrentState(gSStateBase, bSaveState: true);
			DoTargetStateAction(gSStateBase);
		}
	}

	protected virtual void DoTargetStateAction(GSStateBase TargetState)
	{
		if (TargetState == InitialState)
		{
			TargetState.OnInitialAction(this);
		}
		else
		{
			TargetState.OnRecoverAction(this);
		}
	}

	protected void OnHandleDeferredEvents()
	{
		if (bNotSaveState)
		{
			return;
		}
		string finalGuid = base.GuidData.GetFinalGuid();
		if (StateMachineData.GetUnhandledSceneObjEvents(finalGuid, EventTagContainer, out var FGameplayTags))
		{
			foreach (FGameplayTag item in FGameplayTags)
			{
				OnEvent(item);
			}
		}
		base.BGWEventCollection?.Evt_ClearUnhandledSceneObjEvents(finalGuid, FGameplayTags);
		base.BGWEventCollection?.Evt_RequestCleanupCachedStates(finalGuid);
	}

	protected void UpdateCurrentState(GSStateBase TargetState, bool bSaveState)
	{
		CurrentState = TargetState;
		if (!bNotSaveState)
		{
			string finalGuid = base.GuidData.GetFinalGuid();
			if (bSaveState)
			{
				base.BGWEventCollection?.Evt_SaveSceneObjState(finalGuid, StateTagContainer, CurrentState.StateTag);
			}
			else
			{
				base.BGWEventCollection?.Evt_RecordSceneObjState(finalGuid, StateTagContainer, CurrentState.StateTag);
			}
		}
	}

	protected bool OnEvent(FGameplayTag EventTag)
	{
		if (!EventTagContainer.Contains(EventTag.TagName))
		{
			return false;
		}
		if (bInEventHandler)
		{
			EventQueue.Enqueue(EventTag);
			return true;
		}
		bInEventHandler = true;
		OnEventHandler(EventTag);
		while (EventQueue.Count > 0)
		{
			OnEventHandler(EventQueue.Dequeue());
		}
		bInEventHandler = false;
		return true;
	}

	protected void OnMulticastEvent(FGameplayTag EventTag)
	{
		if (bInEventHandler)
		{
			EventQueue.Enqueue(EventTag);
			return;
		}
		bInEventHandler = true;
		OnEventHandler(EventTag);
		while (EventQueue.Count > 0)
		{
			OnEventHandler(EventQueue.Dequeue());
		}
		bInEventHandler = false;
	}

	private void OnNoSaveEvent(FGameplayTag EventTag)
	{
		if (CurrentState != null)
		{
			if (CurrentState.EventTransitDictionary.ContainsTag(EventTag))
			{
				GSStateBase targetState = States[CurrentState.EventTransitDictionary.GetValue(EventTag)];
				JumpToState(targetState, bSaveState: false);
			}
			else if (CurrentState.ReactionDictionary.ContainsTag(EventTag))
			{
				CurrentState.ReactionDictionary.GetValue(EventTag)(this);
			}
		}
	}

	protected virtual void OnJumpToStateByIndex(int Index)
	{
		if (IndexStates[Index] != null)
		{
			GSStateBase gSStateBase = IndexStates[Index];
			if (gSStateBase != null)
			{
				JumpToState(gSStateBase);
			}
		}
	}

	private bool OnEventHandler(FGameplayTag EventTag)
	{
		if (GameplayTagExtension.IsTag(EventTag, BGW_FlowUtils.SceneObjCommonEventTag.Reset))
		{
			OnReset();
			return true;
		}
		if (GameplayTagExtension.IsTag(EventTag, BGW_FlowUtils.SceneObjCommonEventTag.Spawn))
		{
			OnSpawn();
			return true;
		}
		if (GameplayTagExtension.IsTag(EventTag, BGW_FlowUtils.SceneObjCommonEventTag.JumpToState0))
		{
			OnJumpToStateByIndex(0);
			return true;
		}
		if (GameplayTagExtension.IsTag(EventTag, BGW_FlowUtils.SceneObjCommonEventTag.JumpToState1))
		{
			OnJumpToStateByIndex(1);
			return true;
		}
		if (GameplayTagExtension.IsTag(EventTag, BGW_FlowUtils.SceneObjCommonEventTag.JumpToState2))
		{
			OnJumpToStateByIndex(2);
			return true;
		}
		if (GameplayTagExtension.IsTag(EventTag, BGW_FlowUtils.SceneObjCommonEventTag.JumpToState3))
		{
			OnJumpToStateByIndex(3);
			return true;
		}
		if (CurrentState == null)
		{
			return false;
		}
		if (CurrentState.EventTransitDictionary.ContainsTag(EventTag))
		{
			GSStateBase targetState = States[CurrentState.EventTransitDictionary.GetValue(EventTag)];
			JumpToState(targetState);
		}
		else
		{
			if (!CurrentState.ReactionDictionary.ContainsTag(EventTag))
			{
				return false;
			}
			CurrentState.ReactionDictionary.GetValue(EventTag)(this);
		}
		return true;
	}

	protected virtual void OnNotifyStartObserve()
	{
	}

	protected virtual void OnReset()
	{
		ResetToInitialState();
		OnHandleDeferredEvents();
	}

	protected virtual void OnSpawn()
	{
		ResetToInitialState();
		OnHandleDeferredEvents();
	}
}
