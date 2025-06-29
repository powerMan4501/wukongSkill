using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_TriggerAtkReboundingSuccess_ICB : IFreshAbleGSEvent
{
	private Del_TriggerAtkReboundingSuccess _InvokeCallBack;

	private Action<Del_TriggerAtkReboundingSuccess> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerAtkReboundingSuccess _MultiCastDel;

	public GSDel_TriggerAtkReboundingSuccess_ICB(Del_TriggerAtkReboundingSuccess InvokeCallBack, Action<Del_TriggerAtkReboundingSuccess> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TriggerAtkReboundingSuccess)Delegate.Combine(_MultiCastDel, (Del_TriggerAtkReboundingSuccess)Del);
		}
		else
		{
			_MultiCastDel = (Del_TriggerAtkReboundingSuccess)Delegate.Remove(_MultiCastDel, (Del_TriggerAtkReboundingSuccess)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_TriggerAtkReboundingSuccess_ICB operator +(GSDel_TriggerAtkReboundingSuccess_ICB GSEvent, Del_TriggerAtkReboundingSuccess Del)
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
		GSEvent._MultiCastDel = (Del_TriggerAtkReboundingSuccess)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_TriggerAtkReboundingSuccess_ICB operator -(GSDel_TriggerAtkReboundingSuccess_ICB GSEvent, Del_TriggerAtkReboundingSuccess Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TriggerAtkReboundingSuccess == Del)
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
		GSEvent._MultiCastDel = (Del_TriggerAtkReboundingSuccess)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor AtkReboundingActor)
	{
		_InvokeCallBack?.Invoke(AtkReboundingActor);
	}
}
