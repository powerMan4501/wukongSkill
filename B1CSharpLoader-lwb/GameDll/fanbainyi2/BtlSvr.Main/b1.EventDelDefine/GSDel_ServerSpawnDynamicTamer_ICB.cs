using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_ServerSpawnDynamicTamer_ICB : IFreshAbleGSEvent
{
	private Del_ServerSpawnDynamicTamer _InvokeCallBack;

	private Action<Del_ServerSpawnDynamicTamer> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ServerSpawnDynamicTamer _MultiCastDel;

	public GSDel_ServerSpawnDynamicTamer_ICB(Del_ServerSpawnDynamicTamer InvokeCallBack, Action<Del_ServerSpawnDynamicTamer> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ServerSpawnDynamicTamer)Delegate.Combine(_MultiCastDel, (Del_ServerSpawnDynamicTamer)Del);
		}
		else
		{
			_MultiCastDel = (Del_ServerSpawnDynamicTamer)Delegate.Remove(_MultiCastDel, (Del_ServerSpawnDynamicTamer)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_ServerSpawnDynamicTamer_ICB operator +(GSDel_ServerSpawnDynamicTamer_ICB GSEvent, Del_ServerSpawnDynamicTamer Del)
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
		GSEvent._MultiCastDel = (Del_ServerSpawnDynamicTamer)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_ServerSpawnDynamicTamer_ICB operator -(GSDel_ServerSpawnDynamicTamer_ICB GSEvent, Del_ServerSpawnDynamicTamer Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ServerSpawnDynamicTamer == Del)
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
		GSEvent._MultiCastDel = (Del_ServerSpawnDynamicTamer)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FDynamicTamerSpawnReq TamerClass)
	{
		_InvokeCallBack?.Invoke(TamerClass);
	}
}
