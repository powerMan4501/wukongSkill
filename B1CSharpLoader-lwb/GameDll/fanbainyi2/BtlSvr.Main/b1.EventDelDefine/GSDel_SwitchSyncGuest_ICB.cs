using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_SwitchSyncGuest_ICB : IFreshAbleGSEvent
{
	private Del_SwitchSyncGuest _InvokeCallBack;

	private Action<Del_SwitchSyncGuest> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SwitchSyncGuest _MultiCastDel;

	public GSDel_SwitchSyncGuest_ICB(Del_SwitchSyncGuest InvokeCallBack, Action<Del_SwitchSyncGuest> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SwitchSyncGuest)Delegate.Combine(_MultiCastDel, (Del_SwitchSyncGuest)Del);
		}
		else
		{
			_MultiCastDel = (Del_SwitchSyncGuest)Delegate.Remove(_MultiCastDel, (Del_SwitchSyncGuest)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SwitchSyncGuest_ICB operator +(GSDel_SwitchSyncGuest_ICB GSEvent, Del_SwitchSyncGuest Del)
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
		GSEvent._MultiCastDel = (Del_SwitchSyncGuest)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SwitchSyncGuest_ICB operator -(GSDel_SwitchSyncGuest_ICB GSEvent, Del_SwitchSyncGuest Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SwitchSyncGuest == Del)
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
		GSEvent._MultiCastDel = (Del_SwitchSyncGuest)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor NewGuest, float MontageRemainingTime)
	{
		_InvokeCallBack?.Invoke(NewGuest, MontageRemainingTime);
	}
}
