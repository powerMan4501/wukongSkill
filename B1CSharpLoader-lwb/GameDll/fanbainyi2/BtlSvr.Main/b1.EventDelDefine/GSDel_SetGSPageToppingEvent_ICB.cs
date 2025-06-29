using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SetGSPageToppingEvent_ICB : IFreshAbleGSEvent
{
	private Del_SetGSPageToppingEvent _InvokeCallBack;

	private Action<Del_SetGSPageToppingEvent> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetGSPageToppingEvent _MultiCastDel;

	public GSDel_SetGSPageToppingEvent_ICB(Del_SetGSPageToppingEvent InvokeCallBack, Action<Del_SetGSPageToppingEvent> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetGSPageToppingEvent)Delegate.Combine(_MultiCastDel, (Del_SetGSPageToppingEvent)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetGSPageToppingEvent)Delegate.Remove(_MultiCastDel, (Del_SetGSPageToppingEvent)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetGSPageToppingEvent_ICB operator +(GSDel_SetGSPageToppingEvent_ICB GSEvent, Del_SetGSPageToppingEvent Del)
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
		GSEvent._MultiCastDel = (Del_SetGSPageToppingEvent)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetGSPageToppingEvent_ICB operator -(GSDel_SetGSPageToppingEvent_ICB GSEvent, Del_SetGSPageToppingEvent Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetGSPageToppingEvent == Del)
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
		GSEvent._MultiCastDel = (Del_SetGSPageToppingEvent)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int PageId, List<int> DepShowPageList)
	{
		_InvokeCallBack?.Invoke(PageId, DepShowPageList);
	}
}
