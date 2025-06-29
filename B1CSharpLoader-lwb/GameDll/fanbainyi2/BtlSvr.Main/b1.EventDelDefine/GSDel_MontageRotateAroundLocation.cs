using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_MontageRotateAroundLocation : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_MontageRotateAroundLocation _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_MontageRotateAroundLocation)Delegate.Combine(_MultiCastDel, (Del_MontageRotateAroundLocation)Del);
		}
		else
		{
			_MultiCastDel = (Del_MontageRotateAroundLocation)Delegate.Remove(_MultiCastDel, (Del_MontageRotateAroundLocation)Del);
		}
	}

	public static GSDel_MontageRotateAroundLocation operator +(GSDel_MontageRotateAroundLocation GSEvent, Del_MontageRotateAroundLocation Del)
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
		GSEvent._MultiCastDel = (Del_MontageRotateAroundLocation)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_MontageRotateAroundLocation operator -(GSDel_MontageRotateAroundLocation GSEvent, Del_MontageRotateAroundLocation Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_MontageRotateAroundLocation == Del)
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
		GSEvent._MultiCastDel = (Del_MontageRotateAroundLocation)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(FVector TargetPos, float TurnSpeed, float RotateDeflectionAngle, float MaxRotateAngle, ERotateDirection RotateDirection = ERotateDirection.Auto, bool bStillRotateWhenAboveMaxRotateAngle = false, float DeadzoneAngle = 0f, bool EnableDebug = false)
	{
		_MultiCastDel?.Invoke(TargetPos, TurnSpeed, RotateDeflectionAngle, MaxRotateAngle, RotateDirection, bStillRotateWhenAboveMaxRotateAngle, DeadzoneAngle, EnableDebug);
	}
}
