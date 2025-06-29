using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_AdditionFloatingHit_ICB : IFreshAbleGSEvent
{
	private Del_AdditionFloatingHit _InvokeCallBack;

	private Action<Del_AdditionFloatingHit> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_AdditionFloatingHit _MultiCastDel;

	public GSDel_AdditionFloatingHit_ICB(Del_AdditionFloatingHit InvokeCallBack, Action<Del_AdditionFloatingHit> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_AdditionFloatingHit)Delegate.Combine(_MultiCastDel, (Del_AdditionFloatingHit)Del);
		}
		else
		{
			_MultiCastDel = (Del_AdditionFloatingHit)Delegate.Remove(_MultiCastDel, (Del_AdditionFloatingHit)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_AdditionFloatingHit_ICB operator +(GSDel_AdditionFloatingHit_ICB GSEvent, Del_AdditionFloatingHit Del)
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
		GSEvent._MultiCastDel = (Del_AdditionFloatingHit)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_AdditionFloatingHit_ICB operator -(GSDel_AdditionFloatingHit_ICB GSEvent, Del_AdditionFloatingHit Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_AdditionFloatingHit == Del)
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
		GSEvent._MultiCastDel = (Del_AdditionFloatingHit)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(float AdditionHeight, float AdditionTime)
	{
		_InvokeCallBack?.Invoke(AdditionHeight, AdditionTime);
	}
}
