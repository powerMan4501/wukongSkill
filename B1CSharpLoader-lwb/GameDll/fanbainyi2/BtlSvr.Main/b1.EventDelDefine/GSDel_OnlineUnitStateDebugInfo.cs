using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_OnlineUnitStateDebugInfo : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnlineUnitStateDebugInfo _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnlineUnitStateDebugInfo)Delegate.Combine(_MultiCastDel, (Del_OnlineUnitStateDebugInfo)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnlineUnitStateDebugInfo)Delegate.Remove(_MultiCastDel, (Del_OnlineUnitStateDebugInfo)Del);
		}
	}

	public static GSDel_OnlineUnitStateDebugInfo operator +(GSDel_OnlineUnitStateDebugInfo GSEvent, Del_OnlineUnitStateDebugInfo Del)
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
		GSEvent._MultiCastDel = (Del_OnlineUnitStateDebugInfo)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_OnlineUnitStateDebugInfo operator -(GSDel_OnlineUnitStateDebugInfo GSEvent, Del_OnlineUnitStateDebugInfo Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnlineUnitStateDebugInfo == Del)
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
		GSEvent._MultiCastDel = (Del_OnlineUnitStateDebugInfo)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(int UnitState, float Value, int ChangeType)
	{
		_MultiCastDel?.Invoke(UnitState, Value, ChangeType);
	}
}
