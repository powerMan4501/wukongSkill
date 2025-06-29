using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_OnProjectileCustomSweepHitWorldItem : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnProjectileCustomSweepHitWorldItem _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnProjectileCustomSweepHitWorldItem)Delegate.Combine(_MultiCastDel, (Del_OnProjectileCustomSweepHitWorldItem)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnProjectileCustomSweepHitWorldItem)Delegate.Remove(_MultiCastDel, (Del_OnProjectileCustomSweepHitWorldItem)Del);
		}
	}

	public static GSDel_OnProjectileCustomSweepHitWorldItem operator +(GSDel_OnProjectileCustomSweepHitWorldItem GSEvent, Del_OnProjectileCustomSweepHitWorldItem Del)
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
		GSEvent._MultiCastDel = (Del_OnProjectileCustomSweepHitWorldItem)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_OnProjectileCustomSweepHitWorldItem operator -(GSDel_OnProjectileCustomSweepHitWorldItem GSEvent, Del_OnProjectileCustomSweepHitWorldItem Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnProjectileCustomSweepHitWorldItem == Del)
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
		GSEvent._MultiCastDel = (Del_OnProjectileCustomSweepHitWorldItem)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(FEffectInstReq EffectInstReq, AActor BeHitActor)
	{
		_MultiCastDel?.Invoke(EffectInstReq, BeHitActor);
	}
}
