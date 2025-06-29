using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_TriggerTTTBEffect : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerTTTBEffect _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TriggerTTTBEffect)Delegate.Combine(_MultiCastDel, (Del_TriggerTTTBEffect)Del);
		}
		else
		{
			_MultiCastDel = (Del_TriggerTTTBEffect)Delegate.Remove(_MultiCastDel, (Del_TriggerTTTBEffect)Del);
		}
	}

	public static GSDel_TriggerTTTBEffect operator +(GSDel_TriggerTTTBEffect GSEvent, Del_TriggerTTTBEffect Del)
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
		GSEvent._MultiCastDel = (Del_TriggerTTTBEffect)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_TriggerTTTBEffect operator -(GSDel_TriggerTTTBEffect GSEvent, Del_TriggerTTTBEffect Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TriggerTTTBEffect == Del)
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
		GSEvent._MultiCastDel = (Del_TriggerTTTBEffect)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(float Duration, float Strength, FName HitBoneName, FVector HitLocation, FVector HitPointNormalDir, FVector HitDiretionRealDir)
	{
		_MultiCastDel?.Invoke(Duration, Strength, HitBoneName, HitLocation, HitPointNormalDir, HitDiretionRealDir);
	}
}
