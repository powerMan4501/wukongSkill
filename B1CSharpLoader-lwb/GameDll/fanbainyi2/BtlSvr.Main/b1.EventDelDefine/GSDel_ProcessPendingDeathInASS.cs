using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_ProcessPendingDeathInASS : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ProcessPendingDeathInASS _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ProcessPendingDeathInASS)Delegate.Combine(_MultiCastDel, (Del_ProcessPendingDeathInASS)Del);
		}
		else
		{
			_MultiCastDel = (Del_ProcessPendingDeathInASS)Delegate.Remove(_MultiCastDel, (Del_ProcessPendingDeathInASS)Del);
		}
	}

	public static GSDel_ProcessPendingDeathInASS operator +(GSDel_ProcessPendingDeathInASS GSEvent, Del_ProcessPendingDeathInASS Del)
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
		GSEvent._MultiCastDel = (Del_ProcessPendingDeathInASS)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_ProcessPendingDeathInASS operator -(GSDel_ProcessPendingDeathInASS GSEvent, Del_ProcessPendingDeathInASS Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ProcessPendingDeathInASS == Del)
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
		GSEvent._MultiCastDel = (Del_ProcessPendingDeathInASS)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(UAnimMontage DeathMontage, float TotalDuration)
	{
		_MultiCastDel?.Invoke(DeathMontage, TotalDuration);
	}
}
