using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_BattleSCMulticastCachedPointSet : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_BattleSCMulticastCachedPointSet _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_BattleSCMulticastCachedPointSet)Delegate.Combine(_MultiCastDel, (Del_BattleSCMulticastCachedPointSet)Del);
		}
		else
		{
			_MultiCastDel = (Del_BattleSCMulticastCachedPointSet)Delegate.Remove(_MultiCastDel, (Del_BattleSCMulticastCachedPointSet)Del);
		}
	}

	public static GSDel_BattleSCMulticastCachedPointSet operator +(GSDel_BattleSCMulticastCachedPointSet GSEvent, Del_BattleSCMulticastCachedPointSet Del)
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
		GSEvent._MultiCastDel = (Del_BattleSCMulticastCachedPointSet)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_BattleSCMulticastCachedPointSet operator -(GSDel_BattleSCMulticastCachedPointSet GSEvent, Del_BattleSCMulticastCachedPointSet Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_BattleSCMulticastCachedPointSet == Del)
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
		GSEvent._MultiCastDel = (Del_BattleSCMulticastCachedPointSet)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(string BattleSCGUID, AActor Sender, int RegisterID, List<FVector> PointSet)
	{
		_MultiCastDel?.Invoke(BattleSCGUID, Sender, RegisterID, PointSet);
	}
}
