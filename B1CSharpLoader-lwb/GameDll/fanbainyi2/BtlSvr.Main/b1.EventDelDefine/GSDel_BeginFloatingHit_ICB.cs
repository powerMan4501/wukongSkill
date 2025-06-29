using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_BeginFloatingHit_ICB : IFreshAbleGSEvent
{
	private Del_BeginFloatingHit _InvokeCallBack;

	private Action<Del_BeginFloatingHit> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_BeginFloatingHit _MultiCastDel;

	public GSDel_BeginFloatingHit_ICB(Del_BeginFloatingHit InvokeCallBack, Action<Del_BeginFloatingHit> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_BeginFloatingHit)Delegate.Combine(_MultiCastDel, (Del_BeginFloatingHit)Del);
		}
		else
		{
			_MultiCastDel = (Del_BeginFloatingHit)Delegate.Remove(_MultiCastDel, (Del_BeginFloatingHit)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_BeginFloatingHit_ICB operator +(GSDel_BeginFloatingHit_ICB GSEvent, Del_BeginFloatingHit Del)
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
		GSEvent._MultiCastDel = (Del_BeginFloatingHit)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_BeginFloatingHit_ICB operator -(GSDel_BeginFloatingHit_ICB GSEvent, Del_BeginFloatingHit Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_BeginFloatingHit == Del)
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
		GSEvent._MultiCastDel = (Del_BeginFloatingHit)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(float FloatingHeight, float RiseTime, float DeclineSpd)
	{
		_InvokeCallBack?.Invoke(FloatingHeight, RiseTime, DeclineSpd);
	}
}
