using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.AIModule;

namespace b1.EventDelDefine;

public class GSDel_SetSummonStateBehaviorTree_ICB : IFreshAbleGSEvent
{
	private Del_SetSummonStateBehaviorTree _InvokeCallBack;

	private Action<Del_SetSummonStateBehaviorTree> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetSummonStateBehaviorTree _MultiCastDel;

	public GSDel_SetSummonStateBehaviorTree_ICB(Del_SetSummonStateBehaviorTree InvokeCallBack, Action<Del_SetSummonStateBehaviorTree> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetSummonStateBehaviorTree)Delegate.Combine(_MultiCastDel, (Del_SetSummonStateBehaviorTree)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetSummonStateBehaviorTree)Delegate.Remove(_MultiCastDel, (Del_SetSummonStateBehaviorTree)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetSummonStateBehaviorTree_ICB operator +(GSDel_SetSummonStateBehaviorTree_ICB GSEvent, Del_SetSummonStateBehaviorTree Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			bool flag = entityComponent.IsNetActive();
			orAllocEventRegCache.Add(EventRegCache.AllocEventRegCache(GSEvent.EventId, Del, flag));
			if (!flag)
			{
				return GSEvent;
			}
		}
		GSEvent._MultiCastDel = (Del_SetSummonStateBehaviorTree)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetSummonStateBehaviorTree_ICB operator -(GSDel_SetSummonStateBehaviorTree_ICB GSEvent, Del_SetSummonStateBehaviorTree Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetSummonStateBehaviorTree == Del)
				{
					EventRegCache.DeAllocEventRegCache(orAllocEventRegCache[num]);
					orAllocEventRegCache.RemoveAt(num);
				}
			}
			if (orAllocEventRegCache.Count == 0)
			{
				GSEvent._OwnerEventCollectionCS.DeAllocEventRegCache(entityComponent);
			}
			if (!entityComponent.IsNetActive())
			{
				return GSEvent;
			}
		}
		GSEvent._MultiCastDel = (Del_SetSummonStateBehaviorTree)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(ESummonBehaviorState State, UBehaviorTree BT)
	{
		_InvokeCallBack?.Invoke(State, BT);
	}
}
