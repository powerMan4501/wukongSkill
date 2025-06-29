using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;

namespace b1.EventDelDefine;

public class GSDel_SetMapSymbolActiveState_ICB : IFreshAbleGSEvent
{
	private Del_SetMapSymbolActiveState _InvokeCallBack;

	private Action<Del_SetMapSymbolActiveState> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetMapSymbolActiveState _MultiCastDel;

	public GSDel_SetMapSymbolActiveState_ICB(Del_SetMapSymbolActiveState InvokeCallBack, Action<Del_SetMapSymbolActiveState> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetMapSymbolActiveState)Delegate.Combine(_MultiCastDel, (Del_SetMapSymbolActiveState)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetMapSymbolActiveState)Delegate.Remove(_MultiCastDel, (Del_SetMapSymbolActiveState)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetMapSymbolActiveState_ICB operator +(GSDel_SetMapSymbolActiveState_ICB GSEvent, Del_SetMapSymbolActiveState Del)
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
		GSEvent._MultiCastDel = (Del_SetMapSymbolActiveState)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetMapSymbolActiveState_ICB operator -(GSDel_SetMapSymbolActiveState_ICB GSEvent, Del_SetMapSymbolActiveState Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetMapSymbolActiveState == Del)
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
		GSEvent._MultiCastDel = (Del_SetMapSymbolActiveState)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(string MapSymbolStateGuid, EMapSymbolActiveState MapSymbolState)
	{
		_InvokeCallBack?.Invoke(MapSymbolStateGuid, MapSymbolState);
	}
}
