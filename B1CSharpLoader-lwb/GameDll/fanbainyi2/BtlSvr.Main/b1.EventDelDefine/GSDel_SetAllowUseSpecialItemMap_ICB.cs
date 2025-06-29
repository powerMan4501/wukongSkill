using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SetAllowUseSpecialItemMap_ICB : IFreshAbleGSEvent
{
	private Del_SetAllowUseSpecialItemMap _InvokeCallBack;

	private Action<Del_SetAllowUseSpecialItemMap> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetAllowUseSpecialItemMap _MultiCastDel;

	public GSDel_SetAllowUseSpecialItemMap_ICB(Del_SetAllowUseSpecialItemMap InvokeCallBack, Action<Del_SetAllowUseSpecialItemMap> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

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
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetAllowUseSpecialItemMap_ICB operator +(GSDel_SetAllowUseSpecialItemMap_ICB GSEvent, Del_SetAllowUseSpecialItemMap Del)
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
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetAllowUseSpecialItemMap_ICB operator -(GSDel_SetAllowUseSpecialItemMap_ICB GSEvent, Del_SetAllowUseSpecialItemMap Del)
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
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(in Dictionary<int, bool> AllowUseSpecialItem)
	{
		_InvokeCallBack?.Invoke(in AllowUseSpecialItem);
	}
}
