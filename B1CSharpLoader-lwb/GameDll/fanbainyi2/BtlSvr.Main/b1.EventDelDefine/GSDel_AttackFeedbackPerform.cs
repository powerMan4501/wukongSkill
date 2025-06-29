using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_AttackFeedbackPerform : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_AttackFeedbackPerform _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_AttackFeedbackPerform)Delegate.Combine(_MultiCastDel, (Del_AttackFeedbackPerform)Del);
		}
		else
		{
			_MultiCastDel = (Del_AttackFeedbackPerform)Delegate.Remove(_MultiCastDel, (Del_AttackFeedbackPerform)Del);
		}
	}

	public static GSDel_AttackFeedbackPerform operator +(GSDel_AttackFeedbackPerform GSEvent, Del_AttackFeedbackPerform Del)
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
		GSEvent._MultiCastDel = (Del_AttackFeedbackPerform)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_AttackFeedbackPerform operator -(GSDel_AttackFeedbackPerform GSEvent, Del_AttackFeedbackPerform Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_AttackFeedbackPerform == Del)
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
		GSEvent._MultiCastDel = (Del_AttackFeedbackPerform)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(AActor Victim, ESkillDamageType SkillDamageType, EHitPerformFXEventType FinalHitPerformFXEventType, FEffectInstReq EffectInstReq, int CasterResID, int SkillEffectID, int HitPartID)
	{
		_MultiCastDel?.Invoke(Victim, SkillDamageType, FinalHitPerformFXEventType, EffectInstReq, CasterResID, SkillEffectID, HitPartID);
	}
}
