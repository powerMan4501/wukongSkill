using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_BeAttackedVisualEffect : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_BeAttackedVisualEffect _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_BeAttackedVisualEffect)Delegate.Combine(_MultiCastDel, (Del_BeAttackedVisualEffect)Del);
		}
		else
		{
			_MultiCastDel = (Del_BeAttackedVisualEffect)Delegate.Remove(_MultiCastDel, (Del_BeAttackedVisualEffect)Del);
		}
	}

	public static GSDel_BeAttackedVisualEffect operator +(GSDel_BeAttackedVisualEffect GSEvent, Del_BeAttackedVisualEffect Del)
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
		GSEvent._MultiCastDel = (Del_BeAttackedVisualEffect)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_BeAttackedVisualEffect operator -(GSDel_BeAttackedVisualEffect GSEvent, Del_BeAttackedVisualEffect Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_BeAttackedVisualEffect == Del)
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
		GSEvent._MultiCastDel = (Del_BeAttackedVisualEffect)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(AActor Attacker, ESkillDamageType SkillDamageType, EHitPerformFXEventType ExtraAkCheck, FEffectInstReq HitReq, int SkillEffectID, int HitPartID, bool bCostDmg = true)
	{
		_MultiCastDel?.Invoke(Attacker, SkillDamageType, ExtraAkCheck, HitReq, SkillEffectID, HitPartID, bCostDmg);
	}
}
