using System;
using System.Collections.Generic;
using GUR.Runtime;
using UnrealEngine.Runtime;

namespace b1;

[TypeFactory]
public abstract class PsmSubMachine : ICheckNodeQueryable
{
	private class State_GraphInitial : PsmSubMachineState
	{
	}

	private class State_GraphTerminate : PsmSubMachineState
	{
	}

	private FGameplayTag _currentState;

	[FactoryKey]
	public abstract string NodeClass { get; }

	private FGameplayTag InitialStateTag => BGW_FlowUtils.FsmStateTag.GraphInitial;

	protected virtual FGameplayTag FinalStateTag => BGW_FlowUtils.FsmStateTag.GraphTerminate;

	protected virtual string DefaultTerminatePinName => "";

	protected static FGameplayTag Next => BGW_FlowUtils.SceneObjCommonEventTag.Next;

	private FGameplayTag InitialTransitionTarget { get; set; }

	private Dictionary<FGameplayTag, IPsmState> StateTags { get; } = new Dictionary<FGameplayTag, IPsmState>();

	private Dictionary<FGameplayTag, Dictionary<FGameplayTag, FGameplayTag>> StateTransitionMap { get; } = new Dictionary<FGameplayTag, Dictionary<FGameplayTag, FGameplayTag>>();

	private Dictionary<FGameplayTag, FGameplayTag> StateResetTransitionMap { get; } = new Dictionary<FGameplayTag, FGameplayTag>();

	private Dictionary<FGameplayTag, Type> StateClassDictionary { get; } = new Dictionary<FGameplayTag, Type>();

	private FGameplayTag CurrentState
	{
		get
		{
			return _currentState;
		}
		set
		{
			_currentState = value;
			StateTags.TryGetValue(_currentState, out var value2);
			CurrentPsmState = value2;
		}
	}

	private IPsmState CurrentPsmState { get; set; }

	private Dictionary<FGameplayTag, FGameplayTag> CurrentStatesTransitionMap { get; set; }

	private Queue<FGameplayTag> EventTagQueue { get; } = new Queue<FGameplayTag>();

	public PsmNodeInstance ParentNodeInstance { get; set; }

	public Action<string> TerminateCallBack { get; set; }

	public PsmInstance ParentPsmInstance => ParentNodeInstance?.ParentInstance;

	private IPsmState FinalState { get; set; }

	private List<TransitionGuard> Guards { get; } = new List<TransitionGuard>();

	public void PostCreate()
	{
		EventTagQueue.Clear();
		InitialBaseStates();
		InitialData(ParentNodeInstance.Node.NodeData);
		FinalState = StateTags[FinalStateTag];
	}

	private void InitialBaseStates()
	{
		State_GraphInitial value = new State_GraphInitial
		{
			ParentSubMachine = this
		};
		FinalState = new State_GraphTerminate
		{
			ParentSubMachine = this
		};
		StateTags.Add(InitialStateTag, value);
		StateTags.Add(FinalStateTag, FinalState);
		CurrentState = InitialStateTag;
	}

	protected abstract void InitialData(byte[] CustomDataBytes);

	protected void RegisterStateWithClass(FGameplayTag InStateTag, Type InStateType)
	{
		if (!StateClassDictionary.ContainsKey(InStateTag))
		{
			StateClassDictionary.Add(InStateTag, InStateType);
		}
		RegisterState(InStateTag);
	}

	protected void RegisterState(FGameplayTag InStateTag)
	{
		PsmSubMachineState psmSubMachineState = null;
		if (StateClassDictionary.TryGetValue(InStateTag, out var value))
		{
			psmSubMachineState = Activator.CreateInstance(value) as PsmSubMachineState;
			if (psmSubMachineState != null)
			{
				psmSubMachineState.PostCreate(ParentNodeInstance.Node.NodeData);
				psmSubMachineState.ParentSubMachine = this;
			}
		}
		if (psmSubMachineState != null)
		{
			IPsmState value2;
			if (ParentNodeInstance.ParentInstance.TryGetStateInstance(InStateTag.TagName.PlainName, out var StateInstance))
			{
				StateInstance.BaseState = psmSubMachineState;
				value2 = StateInstance;
			}
			else
			{
				value2 = psmSubMachineState;
			}
			StateTags[InStateTag] = value2;
		}
	}

	protected void RegisterInitialTransition(FGameplayTag TargetState)
	{
		InitialTransitionTarget = TargetState;
	}

	protected void RegisterFinalTransition(FGameplayTag OriginState, FGameplayTag EventTag)
	{
		RegisterStateTransition(OriginState, EventTag, FinalStateTag);
	}

	protected void RegisterStateTransition(FGameplayTag FromState, FGameplayTag EventTag, FGameplayTag TargetState)
	{
		if (StateTags.ContainsKey(FromState) && StateTags.ContainsKey(TargetState))
		{
			if (!StateTransitionMap.ContainsKey(FromState))
			{
				StateTransitionMap.Add(FromState, new Dictionary<FGameplayTag, FGameplayTag>());
			}
			Dictionary<FGameplayTag, FGameplayTag> dictionary = StateTransitionMap[FromState];
			if (!dictionary.ContainsKey(EventTag))
			{
				dictionary.Add(EventTag, TargetState);
			}
		}
	}

	protected void RegisterResetStateTransition(FGameplayTag BeforeState, FGameplayTag AfterState)
	{
		if (StateResetTransitionMap.ContainsKey(BeforeState))
		{
			StateResetTransitionMap[BeforeState] = AfterState;
		}
		else
		{
			StateResetTransitionMap.Add(BeforeState, AfterState);
		}
	}

	protected void RegisterTerminateGuards(TransitionGuard Guard)
	{
		Guards.Add(Guard);
	}

	protected void ClearTerminateGuards()
	{
		Guards.ForEach(delegate(TransitionGuard Guard)
		{
			Guard.Stop();
		});
		Guards.Clear();
	}

	protected void StartTerminateGuards()
	{
		Guards.ForEach(delegate(TransitionGuard Guard)
		{
			Guard.Start(GetOwner());
		});
	}

	public virtual void PreStart()
	{
	}

	public virtual void Start()
	{
		EventTagQueue.Clear();
		PreStart();
		foreach (TransitionGuard guard in Guards)
		{
			guard.Start(GetOwner());
		}
		OnTransitionToState(InitialTransitionTarget);
	}

	public void OnEvent(FGameplayTag EventTag)
	{
		EventTagQueue.Enqueue(EventTag);
	}

	public void OnTransitionToState(FGameplayTag TargetState)
	{
		CurrentPsmState?.OnExitAction();
		CurrentState = TargetState;
		if (StateTransitionMap.TryGetValue(CurrentState, out var value))
		{
			CurrentStatesTransitionMap = value;
		}
		else
		{
			CurrentStatesTransitionMap = null;
		}
		StateTags[TargetState]?.OnEnterAction();
	}

	public void OnTick(float InDeltaTime)
	{
		foreach (TransitionGuard guard in Guards)
		{
			guard.OnTick(InDeltaTime);
		}
		foreach (TransitionGuard guard2 in Guards)
		{
			if (guard2.IsSuccess())
			{
				Finish(guard2.GuardPin);
				return;
			}
		}
		CurrentPsmState?.OnTickAction(InDeltaTime);
		if (EventTagQueue.Count > 0)
		{
			FGameplayTag key = EventTagQueue.Dequeue();
			if (CurrentStatesTransitionMap != null && CurrentStatesTransitionMap.TryGetValue(key, out var value))
			{
				OnTransitionToState(value);
			}
		}
		if (CurrentPsmState == FinalState)
		{
			Finish(DefaultTerminatePinName);
		}
	}

	public virtual void OnRecover()
	{
		if (CurrentPsmState == null || GameplayTagExtension.EqualTo(CurrentState, InitialStateTag))
		{
			PreStart();
			foreach (TransitionGuard guard in Guards)
			{
				guard.Start(GetOwner());
			}
			CurrentState = InitialTransitionTarget;
			if (StateTransitionMap.TryGetValue(CurrentState, out var value))
			{
				CurrentStatesTransitionMap = value;
			}
			else
			{
				CurrentStatesTransitionMap = null;
			}
			if (CurrentPsmState == null)
			{
				return;
			}
		}
		CurrentPsmState.OnRecoverAction();
	}

	public virtual void OnReset()
	{
		if (CurrentPsmState == null || GameplayTagExtension.EqualTo(CurrentState, InitialStateTag))
		{
			PreStart();
			foreach (TransitionGuard guard in Guards)
			{
				guard.Start(GetOwner());
			}
			CurrentState = InitialTransitionTarget;
			if (StateTransitionMap.TryGetValue(CurrentState, out var value))
			{
				CurrentStatesTransitionMap = value;
			}
			else
			{
				CurrentStatesTransitionMap = null;
			}
			if (CurrentPsmState == null)
			{
				return;
			}
		}
		foreach (TransitionGuard guard2 in Guards)
		{
			guard2.Reset();
		}
		CurrentPsmState.OnResetAction();
		if (StateResetTransitionMap.TryGetValue(CurrentState, out var value2))
		{
			OnTransitionToState(value2);
		}
	}

	private void Finish(string TerminateTag)
	{
		if (GameplayTagExtension.NotEqualTo(CurrentState, FinalStateTag))
		{
			OnTransitionToState(FinalStateTag);
		}
		TerminateCallBack?.Invoke(TerminateTag);
		Shutdown();
	}

	public virtual void Shutdown()
	{
		foreach (TransitionGuard guard in Guards)
		{
			guard.Stop();
		}
		Guards.Clear();
		CurrentPsmState.Shutdown();
		CurrentState = InitialStateTag;
		CurrentStatesTransitionMap = null;
	}

	protected internal UObject GetOwner()
	{
		return ParentNodeInstance.ParentInstance.Owner;
	}

	public virtual bool IsGroupNode(out string GroupName)
	{
		GroupName = "";
		return false;
	}

	public virtual bool CheckNodeQueryable(out string ErrorMassager)
	{
		ErrorMassager = "";
		return true;
	}
}
