using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_PerformCutDeath : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_PerformCutDeath _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_PerformCutDeath)Delegate.Combine(_MultiCastDel, (Del_PerformCutDeath)Del);
		}
		else
		{
			_MultiCastDel = (Del_PerformCutDeath)Delegate.Remove(_MultiCastDel, (Del_PerformCutDeath)Del);
		}
	}

	public static GSDel_PerformCutDeath operator +(GSDel_PerformCutDeath GSEvent, Del_PerformCutDeath Del)
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
		GSEvent._MultiCastDel = (Del_PerformCutDeath)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_PerformCutDeath operator -(GSDel_PerformCutDeath GSEvent, Del_PerformCutDeath Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_PerformCutDeath == Del)
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
		GSEvent._MultiCastDel = (Del_PerformCutDeath)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(ACharacter OriginalChar, float DelayClearArmorTime, float DelayDestroyActorTime, float StiffLevelCauseDead = 0f, FVector KillerLocation = default(FVector), bool UseBoomForce = false)
	{
		_MultiCastDel?.Invoke(OriginalChar, DelayClearArmorTime, DelayDestroyActorTime, StiffLevelCauseDead, KillerLocation, UseBoomForce);
	}
}
