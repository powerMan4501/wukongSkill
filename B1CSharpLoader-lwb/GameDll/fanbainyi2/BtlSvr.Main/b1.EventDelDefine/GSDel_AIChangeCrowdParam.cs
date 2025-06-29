using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;

namespace b1.EventDelDefine;

public class GSDel_AIChangeCrowdParam : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_AIChangeCrowdParam _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_AIChangeCrowdParam)Delegate.Combine(_MultiCastDel, (Del_AIChangeCrowdParam)Del);
		}
		else
		{
			_MultiCastDel = (Del_AIChangeCrowdParam)Delegate.Remove(_MultiCastDel, (Del_AIChangeCrowdParam)Del);
		}
	}

	public static GSDel_AIChangeCrowdParam operator +(GSDel_AIChangeCrowdParam GSEvent, Del_AIChangeCrowdParam Del)
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
		GSEvent._MultiCastDel = (Del_AIChangeCrowdParam)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_AIChangeCrowdParam operator -(GSDel_AIChangeCrowdParam GSEvent, Del_AIChangeCrowdParam Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_AIChangeCrowdParam == Del)
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
		GSEvent._MultiCastDel = (Del_AIChangeCrowdParam)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(float SeparationWeight, float CollisionQueryRange, float PathOptimizationRange, EUnitAICrowdQualityLevel AvoidanceQualityLevel)
	{
		_MultiCastDel?.Invoke(SeparationWeight, CollisionQueryRange, PathOptimizationRange, AvoidanceQualityLevel);
	}
}
