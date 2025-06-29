using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_SetActorLocationAndRotation : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetActorLocationAndRotation _MultiCastDel;

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
	}

	public static GSDel_SetActorLocationAndRotation operator +(GSDel_SetActorLocationAndRotation GSEvent, Del_SetActorLocationAndRotation Del)
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
		return GSEvent;
	}

	public static GSDel_SetActorLocationAndRotation operator -(GSDel_SetActorLocationAndRotation GSEvent, Del_SetActorLocationAndRotation Del)
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
		return GSEvent;
	}

	public void Invoke(FVector NewLocation, FRotator NewRotation, bool bSweep, bool bTeleport)
	{
		_MultiCastDel?.Invoke(NewLocation, NewRotation, bSweep, bTeleport);
	}
}
