using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_BroadcastHatredToNearbyAI_ICB : IFreshAbleGSEvent
{
	private Del_BroadcastHatredToNearbyAI _InvokeCallBack;

	private Action<Del_BroadcastHatredToNearbyAI> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_BroadcastHatredToNearbyAI _MultiCastDel;

	public GSDel_BroadcastHatredToNearbyAI_ICB(Del_BroadcastHatredToNearbyAI InvokeCallBack, Action<Del_BroadcastHatredToNearbyAI> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_BroadcastHatredToNearbyAI)Delegate.Combine(_MultiCastDel, (Del_BroadcastHatredToNearbyAI)Del);
		}
		else
		{
			_MultiCastDel = (Del_BroadcastHatredToNearbyAI)Delegate.Remove(_MultiCastDel, (Del_BroadcastHatredToNearbyAI)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_BroadcastHatredToNearbyAI_ICB operator +(GSDel_BroadcastHatredToNearbyAI_ICB GSEvent, Del_BroadcastHatredToNearbyAI Del)
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
		GSEvent._MultiCastDel = (Del_BroadcastHatredToNearbyAI)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_BroadcastHatredToNearbyAI_ICB operator -(GSDel_BroadcastHatredToNearbyAI_ICB GSEvent, Del_BroadcastHatredToNearbyAI Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_BroadcastHatredToNearbyAI == Del)
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
		GSEvent._MultiCastDel = (Del_BroadcastHatredToNearbyAI)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor AlertTarget, int AlertEndBuffID)
	{
		_InvokeCallBack?.Invoke(AlertTarget, AlertEndBuffID);
	}
}
