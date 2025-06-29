using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SetAllowUseSpecialItemMap : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetAllowUseSpecialItemMap _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetAllowUseSpecialItemMap)Delegate.Combine(_MultiCastDel, (Del_SetAllowUseSpecialItemMap)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetAllowUseSpecialItemMap)Delegate.Remove(_MultiCastDel, (Del_SetAllowUseSpecialItemMap)Del);
		}
	}

	public static GSDel_SetAllowUseSpecialItemMap operator +(GSDel_SetAllowUseSpecialItemMap GSEvent, Del_SetAllowUseSpecialItemMap Del)
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
		GSEvent._MultiCastDel = (Del_SetAllowUseSpecialItemMap)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_SetAllowUseSpecialItemMap operator -(GSDel_SetAllowUseSpecialItemMap GSEvent, Del_SetAllowUseSpecialItemMap Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetAllowUseSpecialItemMap == Del)
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
		GSEvent._MultiCastDel = (Del_SetAllowUseSpecialItemMap)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(in Dictionary<int, bool> AllowUseSpecialItem)
	{
		_MultiCastDel?.Invoke(in AllowUseSpecialItem);
	}
}
