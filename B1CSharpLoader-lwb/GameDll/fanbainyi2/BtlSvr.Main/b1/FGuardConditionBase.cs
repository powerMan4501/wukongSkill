using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using CommB1;
using GUR.Runtime;
using GurCalliopeState;
using UnrealEngine.Runtime;

namespace b1;

[TypeFactory(bPartial = true)]
public abstract class FGuardConditionBase : IDisposable
{
	public static GuardConditionCommonData CommonData { get; } = new GuardConditionCommonData();

	protected UObject Owner { get; private set; }

	public EQueryState QueryState { get; protected set; }

	public List<FGuardConditionBase> SubConditions { get; } = new List<FGuardConditionBase>();

	public bool bCreateByPool { get; set; }

	[FactoryKey]
	public abstract EGuardConditionType ConditionType { get; }

	public void NotifyStart(UObject InOwner)
	{
		Owner = InOwner;
		QueryState = EQueryState.Querying;
		Start();
		BindLifeTimeEvent(IsBind: true);
		foreach (FGuardConditionBase subCondition in SubConditions)
		{
			subCondition.NotifyStart(Owner);
		}
	}

	protected virtual void Start()
	{
	}

	public void NotifyTick(float DeltaTime)
	{
		if (QueryState == EQueryState.NotBegin || QueryState == EQueryState.Error)
		{
			return;
		}
		OnTick(DeltaTime);
		foreach (FGuardConditionBase subCondition in SubConditions)
		{
			subCondition.NotifyTick(DeltaTime);
		}
	}

	protected virtual void OnTick(float DeltaTime)
	{
	}

	public void NotifyStop()
	{
		QueryState = EQueryState.NotBegin;
		Stop();
		BindLifeTimeEvent(IsBind: false);
		foreach (FGuardConditionBase subCondition in SubConditions)
		{
			subCondition.NotifyStop();
		}
	}

	protected virtual void Stop()
	{
	}

	public void NotifyReset()
	{
		Reset();
		foreach (FGuardConditionBase subCondition in SubConditions)
		{
			subCondition.NotifyReset();
		}
	}

	protected virtual void Reset()
	{
	}

	public int IsSuccess()
	{
		if (ConditionType == EGuardConditionType.CompositeAnd)
		{
			bool flag = true;
			foreach (FGuardConditionBase subCondition in SubConditions)
			{
				if (subCondition.IsSuccess() <= 0)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				QueryState = EQueryState.QuerySuccess;
			}
		}
		else if (ConditionType == EGuardConditionType.CompositeOr)
		{
			bool flag2 = false;
			foreach (FGuardConditionBase subCondition2 in SubConditions)
			{
				if (subCondition2.IsSuccess() > 0)
				{
					flag2 = true;
					break;
				}
			}
			if (flag2)
			{
				QueryState = EQueryState.QuerySuccess;
			}
		}
		return QueryState switch
		{
			EQueryState.QuerySuccess => 1, 
			EQueryState.QueryFailure => -1, 
			_ => 0, 
		};
	}

	public void NotifyClean()
	{
		Clean();
		SubConditions.Clear();
		QueryState = EQueryState.NotBegin;
	}

	protected abstract void Clean();

	private void BindLifeTimeEvent(bool IsBind)
	{
		if (IsBind)
		{
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Owner);
			bGW_EventCollection.Evt_PostPlayerControllerAttach = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_PostPlayerControllerAttach, new Del_Void(OnPlayerControllerAttach));
			BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(Owner);
			bGW_EventCollection2.Evt_PostGameStateAttach = (Del_Void)Delegate.Combine(bGW_EventCollection2.Evt_PostGameStateAttach, new Del_Void(OnGameStateAttach));
		}
		else
		{
			BGW_EventCollection bGW_EventCollection3 = BGW_EventCollection.Get(Owner);
			bGW_EventCollection3.Evt_PostPlayerControllerAttach = (Del_Void)Delegate.Remove(bGW_EventCollection3.Evt_PostPlayerControllerAttach, new Del_Void(OnPlayerControllerAttach));
			BGW_EventCollection bGW_EventCollection4 = BGW_EventCollection.Get(Owner);
			bGW_EventCollection4.Evt_PostGameStateAttach = (Del_Void)Delegate.Remove(bGW_EventCollection4.Evt_PostGameStateAttach, new Del_Void(OnGameStateAttach));
		}
	}

	protected virtual void OnPlayerControllerAttach()
	{
	}

	protected virtual void OnGameStateAttach()
	{
	}

	public void Dispose()
	{
		FGuardConditionFactory.Return(this);
	}

	protected UObject GetOwner()
	{
		return Owner;
	}

	public virtual bool TryQuickFinishCondition()
	{
		return false;
	}

	public virtual bool Initial(CalliopeCustom_CompositeTransitionCondition_Idle IdleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		return false;
	}

	public virtual bool Initial(CalliopeCustom_CompositeTransitionCondition_Battle BattleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		return false;
	}

	public virtual bool Initial(CalliopeCustom_CompositeTransitionCondition_Group GroupCondition, PsmNodeInstance InPsmNodeInstance)
	{
		return false;
	}

	public virtual bool Initial(CalliopeCustom_CompositeTransitionCondition_Guide GuideCondition, PsmNodeInstance InPsmNodeInstance)
	{
		return false;
	}

	public virtual bool Initial(CalliopeCustom_CompositeTransitionCondition_State StateCondition)
	{
		return false;
	}

	public virtual bool Initial(CalliopeCustom_TransitionCondition_Idle IdleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		return false;
	}

	public virtual bool Initial(CalliopeCustom_TransitionCondition_Battle BattleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		return false;
	}

	public virtual bool Initial(CalliopeCustom_TransitionCondition_Group GroupCondition, PsmNodeInstance InPsmNodeInstance)
	{
		return false;
	}

	public virtual bool Initial(CalliopeCustom_TransitionCondition_State StateCondition)
	{
		return false;
	}

	public virtual bool Initial(CalliopeCustom_DetectUnitCondition DetectUnitCondition)
	{
		return false;
	}

	public virtual bool Initial(EDetectedUnitType InUnitType, string UnitGuid, CalliopeCustom_DetectCondition InDetectCondition)
	{
		return false;
	}

	public virtual bool Initial(CalliopeCustom_TransitionCondition_Guide GuideCondition, PsmNodeInstance InPsmNodeInstance)
	{
		return false;
	}
}
