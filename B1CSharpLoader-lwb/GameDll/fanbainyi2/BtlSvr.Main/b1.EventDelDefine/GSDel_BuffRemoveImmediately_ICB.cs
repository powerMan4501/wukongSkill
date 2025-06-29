using System;
using System.Collections.Generic;
using b1.ECS;
using BtlShare;

namespace b1.EventDelDefine;

public class GSDel_BuffRemoveImmediately_ICB : IFreshAbleGSEvent
{
	private Del_BuffRemoveImmediately _InvokeCallBack;

	private Action<Del_BuffRemoveImmediately> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_BuffRemoveImmediately _MultiCastDel;

	public GSDel_BuffRemoveImmediately_ICB(Del_BuffRemoveImmediately InvokeCallBack, Action<Del_BuffRemoveImmediately> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_BuffRemoveImmediately)Delegate.Combine(_MultiCastDel, (Del_BuffRemoveImmediately)Del);
		}
		else
		{
			_MultiCastDel = (Del_BuffRemoveImmediately)Delegate.Remove(_MultiCastDel, (Del_BuffRemoveImmediately)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_BuffRemoveImmediately_ICB operator +(GSDel_BuffRemoveImmediately_ICB GSEvent, Del_BuffRemoveImmediately Del)
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
		GSEvent._MultiCastDel = (Del_BuffRemoveImmediately)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_BuffRemoveImmediately_ICB operator -(GSDel_BuffRemoveImmediately_ICB GSEvent, Del_BuffRemoveImmediately Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_BuffRemoveImmediately == Del)
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
		GSEvent._MultiCastDel = (Del_BuffRemoveImmediately)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int BuffID, EBuffEffectTriggerType RemoveTriggerType, bool WithTriggerRemmoveEffect = true)
	{
		_InvokeCallBack?.Invoke(BuffID, RemoveTriggerType, WithTriggerRemmoveEffect);
	}
}
