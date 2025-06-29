using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_SetHitCollisionUpdateInfo : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetHitCollisionUpdateInfo _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetHitCollisionUpdateInfo)Delegate.Combine(_MultiCastDel, (Del_SetHitCollisionUpdateInfo)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetHitCollisionUpdateInfo)Delegate.Remove(_MultiCastDel, (Del_SetHitCollisionUpdateInfo)Del);
		}
	}

	public static GSDel_SetHitCollisionUpdateInfo operator +(GSDel_SetHitCollisionUpdateInfo GSEvent, Del_SetHitCollisionUpdateInfo Del)
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
		GSEvent._MultiCastDel = (Del_SetHitCollisionUpdateInfo)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_SetHitCollisionUpdateInfo operator -(GSDel_SetHitCollisionUpdateInfo GSEvent, Del_SetHitCollisionUpdateInfo Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetHitCollisionUpdateInfo == Del)
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
		GSEvent._MultiCastDel = (Del_SetHitCollisionUpdateInfo)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(string CollisionCompName, EHitMoveDir HitMoveDir, UCurveVector UpdateCurve, float TotalScaleTime, bool NeedUpdateScale, bool NeedUpdateRadius, bool NeedSetRelaLocForScale)
	{
		_MultiCastDel?.Invoke(CollisionCompName, HitMoveDir, UpdateCurve, TotalScaleTime, NeedUpdateScale, NeedUpdateRadius, NeedSetRelaLocForScale);
	}
}
