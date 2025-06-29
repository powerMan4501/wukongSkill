using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SetSummonBehaviorState_ICB : IFreshAbleGSEvent
{
	private Del_SetSummonBehaviorState _InvokeCallBack;

	private Action<Del_SetSummonBehaviorState> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetSummonBehaviorState _MultiCastDel;

	public GSDel_SetSummonBehaviorState_ICB(Del_SetSummonBehaviorState InvokeCallBack, Action<Del_SetSummonBehaviorState> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetSummonBehaviorState)Delegate.Combine(_MultiCastDel, (Del_SetSummonBehaviorState)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetSummonBehaviorState)Delegate.Remove(_MultiCastDel, (Del_SetSummonBehaviorState)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetSummonBehaviorState_ICB operator +(GSDel_SetSummonBehaviorState_ICB GSEvent, Del_SetSummonBehaviorState Del)
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
		GSEvent._MultiCastDel = (Del_SetSummonBehaviorState)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetSummonBehaviorState_ICB operator -(GSDel_SetSummonBehaviorState_ICB GSEvent, Del_SetSummonBehaviorState Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetSummonBehaviorState == Del)
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
		GSEvent._MultiCastDel = (Del_SetSummonBehaviorState)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(ESummonBehaviorState State, bool NeedForceSet = false)
	{
		_InvokeCallBack?.Invoke(State, NeedForceSet);
	}
}
