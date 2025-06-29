using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SetGroupAIWanderHotZonePoint_ICB : IFreshAbleGSEvent
{
	private Del_SetGroupAIWanderHotZonePoint _InvokeCallBack;

	private Action<Del_SetGroupAIWanderHotZonePoint> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetGroupAIWanderHotZonePoint _MultiCastDel;

	public GSDel_SetGroupAIWanderHotZonePoint_ICB(Del_SetGroupAIWanderHotZonePoint InvokeCallBack, Action<Del_SetGroupAIWanderHotZonePoint> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetGroupAIWanderHotZonePoint)Delegate.Combine(_MultiCastDel, (Del_SetGroupAIWanderHotZonePoint)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetGroupAIWanderHotZonePoint)Delegate.Remove(_MultiCastDel, (Del_SetGroupAIWanderHotZonePoint)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetGroupAIWanderHotZonePoint_ICB operator +(GSDel_SetGroupAIWanderHotZonePoint_ICB GSEvent, Del_SetGroupAIWanderHotZonePoint Del)
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
		GSEvent._MultiCastDel = (Del_SetGroupAIWanderHotZonePoint)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetGroupAIWanderHotZonePoint_ICB operator -(GSDel_SetGroupAIWanderHotZonePoint_ICB GSEvent, Del_SetGroupAIWanderHotZonePoint Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetGroupAIWanderHotZonePoint == Del)
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
		GSEvent._MultiCastDel = (Del_SetGroupAIWanderHotZonePoint)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(HotZonePointInfo HZPI)
	{
		_InvokeCallBack?.Invoke(HZPI);
	}
}
