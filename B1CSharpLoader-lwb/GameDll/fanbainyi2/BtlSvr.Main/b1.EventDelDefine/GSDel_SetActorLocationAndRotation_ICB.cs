using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_SetActorLocationAndRotation_ICB : IFreshAbleGSEvent
{
	private Del_SetActorLocationAndRotation _InvokeCallBack;

	private Action<Del_SetActorLocationAndRotation> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetActorLocationAndRotation _MultiCastDel;

	public GSDel_SetActorLocationAndRotation_ICB(Del_SetActorLocationAndRotation InvokeCallBack, Action<Del_SetActorLocationAndRotation> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetActorLocationAndRotation)Delegate.Combine(_MultiCastDel, (Del_SetActorLocationAndRotation)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetActorLocationAndRotation)Delegate.Remove(_MultiCastDel, (Del_SetActorLocationAndRotation)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetActorLocationAndRotation_ICB operator +(GSDel_SetActorLocationAndRotation_ICB GSEvent, Del_SetActorLocationAndRotation Del)
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
		GSEvent._MultiCastDel = (Del_SetActorLocationAndRotation)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetActorLocationAndRotation_ICB operator -(GSDel_SetActorLocationAndRotation_ICB GSEvent, Del_SetActorLocationAndRotation Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetActorLocationAndRotation == Del)
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
		GSEvent._MultiCastDel = (Del_SetActorLocationAndRotation)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FVector NewLocation, FRotator NewRotation, bool bSweep, bool bTeleport)
	{
		_InvokeCallBack?.Invoke(NewLocation, NewRotation, bSweep, bTeleport);
	}
}
