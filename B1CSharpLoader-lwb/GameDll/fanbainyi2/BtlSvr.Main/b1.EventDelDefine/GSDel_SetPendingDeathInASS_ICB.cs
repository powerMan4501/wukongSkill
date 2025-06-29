using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_SetPendingDeathInASS_ICB : IFreshAbleGSEvent
{
	private Del_SetPendingDeathInASS _InvokeCallBack;

	private Action<Del_SetPendingDeathInASS> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetPendingDeathInASS _MultiCastDel;

	public GSDel_SetPendingDeathInASS_ICB(Del_SetPendingDeathInASS InvokeCallBack, Action<Del_SetPendingDeathInASS> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetPendingDeathInASS)Delegate.Combine(_MultiCastDel, (Del_SetPendingDeathInASS)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetPendingDeathInASS)Delegate.Remove(_MultiCastDel, (Del_SetPendingDeathInASS)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetPendingDeathInASS_ICB operator +(GSDel_SetPendingDeathInASS_ICB GSEvent, Del_SetPendingDeathInASS Del)
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
		GSEvent._MultiCastDel = (Del_SetPendingDeathInASS)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetPendingDeathInASS_ICB operator -(GSDel_SetPendingDeathInASS_ICB GSEvent, Del_SetPendingDeathInASS Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetPendingDeathInASS == Del)
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
		GSEvent._MultiCastDel = (Del_SetPendingDeathInASS)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor Killer = null, int StiffLevel = -1, int DmgID = -1, bool bIsSummon = false, FEffectInstReq EffectInstReq = default(FEffectInstReq))
	{
		_InvokeCallBack?.Invoke(Killer, StiffLevel, DmgID, bIsSummon, EffectInstReq);
	}
}
