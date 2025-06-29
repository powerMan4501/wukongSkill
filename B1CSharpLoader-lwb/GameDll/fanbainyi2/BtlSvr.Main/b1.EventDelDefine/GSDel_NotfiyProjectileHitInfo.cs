using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_NotfiyProjectileHitInfo : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_NotfiyProjectileHitInfo _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_NotfiyProjectileHitInfo)Delegate.Combine(_MultiCastDel, (Del_NotfiyProjectileHitInfo)Del);
		}
		else
		{
			_MultiCastDel = (Del_NotfiyProjectileHitInfo)Delegate.Remove(_MultiCastDel, (Del_NotfiyProjectileHitInfo)Del);
		}
	}

	public static GSDel_NotfiyProjectileHitInfo operator +(GSDel_NotfiyProjectileHitInfo GSEvent, Del_NotfiyProjectileHitInfo Del)
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
		GSEvent._MultiCastDel = (Del_NotfiyProjectileHitInfo)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_NotfiyProjectileHitInfo operator -(GSDel_NotfiyProjectileHitInfo GSEvent, Del_NotfiyProjectileHitInfo Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_NotfiyProjectileHitInfo == Del)
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
		GSEvent._MultiCastDel = (Del_NotfiyProjectileHitInfo)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(AActor Projectile, AActor HitActor, EBGUBulletTriggerEffectReason Reason)
	{
		_MultiCastDel?.Invoke(Projectile, HitActor, Reason);
	}
}
