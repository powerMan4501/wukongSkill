using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_OnlineOnePlayerDead_ICB : IFreshAbleGSEvent
{
	private Del_OnlineOnePlayerDead _InvokeCallBack;

	private Action<Del_OnlineOnePlayerDead> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnlineOnePlayerDead _MultiCastDel;

	public GSDel_OnlineOnePlayerDead_ICB(Del_OnlineOnePlayerDead InvokeCallBack, Action<Del_OnlineOnePlayerDead> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnlineOnePlayerDead)Delegate.Combine(_MultiCastDel, (Del_OnlineOnePlayerDead)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnlineOnePlayerDead)Delegate.Remove(_MultiCastDel, (Del_OnlineOnePlayerDead)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_OnlineOnePlayerDead_ICB operator +(GSDel_OnlineOnePlayerDead_ICB GSEvent, Del_OnlineOnePlayerDead Del)
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
		GSEvent._MultiCastDel = (Del_OnlineOnePlayerDead)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_OnlineOnePlayerDead_ICB operator -(GSDel_OnlineOnePlayerDead_ICB GSEvent, Del_OnlineOnePlayerDead Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnlineOnePlayerDead == Del)
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
		GSEvent._MultiCastDel = (Del_OnlineOnePlayerDead)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(APlayerController PlayerController)
	{
		_InvokeCallBack?.Invoke(PlayerController);
	}
}
