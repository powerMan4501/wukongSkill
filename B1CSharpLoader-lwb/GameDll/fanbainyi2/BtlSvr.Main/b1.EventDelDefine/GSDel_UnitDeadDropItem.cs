using System;
using System.Collections.Generic;
using b1.ECS;
using BtlShare;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_UnitDeadDropItem : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_UnitDeadDropItem _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_UnitDeadDropItem)Delegate.Combine(_MultiCastDel, (Del_UnitDeadDropItem)Del);
		}
		else
		{
			_MultiCastDel = (Del_UnitDeadDropItem)Delegate.Remove(_MultiCastDel, (Del_UnitDeadDropItem)Del);
		}
	}

	public static GSDel_UnitDeadDropItem operator +(GSDel_UnitDeadDropItem GSEvent, Del_UnitDeadDropItem Del)
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
		GSEvent._MultiCastDel = (Del_UnitDeadDropItem)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_UnitDeadDropItem operator -(GSDel_UnitDeadDropItem GSEvent, Del_UnitDeadDropItem Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_UnitDeadDropItem == Del)
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
		GSEvent._MultiCastDel = (Del_UnitDeadDropItem)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(AActor Victim, AActor Attacker, EDeadReason DeadReason)
	{
		_MultiCastDel?.Invoke(Victim, Attacker, DeadReason);
	}
}
