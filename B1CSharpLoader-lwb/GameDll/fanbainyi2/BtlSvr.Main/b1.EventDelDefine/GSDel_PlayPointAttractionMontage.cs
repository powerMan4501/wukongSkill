using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_PlayPointAttractionMontage : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_PlayPointAttractionMontage _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_PlayPointAttractionMontage)Delegate.Combine(_MultiCastDel, (Del_PlayPointAttractionMontage)Del);
		}
		else
		{
			_MultiCastDel = (Del_PlayPointAttractionMontage)Delegate.Remove(_MultiCastDel, (Del_PlayPointAttractionMontage)Del);
		}
	}

	public static GSDel_PlayPointAttractionMontage operator +(GSDel_PlayPointAttractionMontage GSEvent, Del_PlayPointAttractionMontage Del)
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
		GSEvent._MultiCastDel = (Del_PlayPointAttractionMontage)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_PlayPointAttractionMontage operator -(GSDel_PlayPointAttractionMontage GSEvent, Del_PlayPointAttractionMontage Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_PlayPointAttractionMontage == Del)
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
		GSEvent._MultiCastDel = (Del_PlayPointAttractionMontage)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(AActor Attacker, int AttackStiffEffectID, FVector AttractionLocation, EAttackerArea AttractionArea)
	{
		_MultiCastDel?.Invoke(Attacker, AttackStiffEffectID, AttractionLocation, AttractionArea);
	}
}
