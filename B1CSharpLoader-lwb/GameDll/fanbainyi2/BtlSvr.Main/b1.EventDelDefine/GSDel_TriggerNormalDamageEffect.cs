using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_TriggerNormalDamageEffect : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerNormalDamageEffect _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TriggerNormalDamageEffect)Delegate.Combine(_MultiCastDel, (Del_TriggerNormalDamageEffect)Del);
		}
		else
		{
			_MultiCastDel = (Del_TriggerNormalDamageEffect)Delegate.Remove(_MultiCastDel, (Del_TriggerNormalDamageEffect)Del);
		}
	}

	public static GSDel_TriggerNormalDamageEffect operator +(GSDel_TriggerNormalDamageEffect GSEvent, Del_TriggerNormalDamageEffect Del)
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
		GSEvent._MultiCastDel = (Del_TriggerNormalDamageEffect)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_TriggerNormalDamageEffect operator -(GSDel_TriggerNormalDamageEffect GSEvent, Del_TriggerNormalDamageEffect Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TriggerNormalDamageEffect == Del)
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
		GSEvent._MultiCastDel = (Del_TriggerNormalDamageEffect)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(AActor Attacker, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq, in FBattleAttrSnapShot Attacker_AttrMemData)
	{
		_MultiCastDel?.Invoke(Attacker, in SkillDamageConfig, in EffectInstReq, in Attacker_AttrMemData);
	}
}
