using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_FakeDeadForSkillDamage : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_FakeDeadForSkillDamage _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_FakeDeadForSkillDamage)Delegate.Combine(_MultiCastDel, (Del_FakeDeadForSkillDamage)Del);
		}
		else
		{
			_MultiCastDel = (Del_FakeDeadForSkillDamage)Delegate.Remove(_MultiCastDel, (Del_FakeDeadForSkillDamage)Del);
		}
	}

	public static GSDel_FakeDeadForSkillDamage operator +(GSDel_FakeDeadForSkillDamage GSEvent, Del_FakeDeadForSkillDamage Del)
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
		GSEvent._MultiCastDel = (Del_FakeDeadForSkillDamage)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_FakeDeadForSkillDamage operator -(GSDel_FakeDeadForSkillDamage GSEvent, Del_FakeDeadForSkillDamage Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_FakeDeadForSkillDamage == Del)
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
		GSEvent._MultiCastDel = (Del_FakeDeadForSkillDamage)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(AActor Attacker, int StiffLevel, UAnimMontage BeAttackedAM, in FEffectInstReq EffectInstReq, bool bIsDotDmg = false, EAbnormalStateType AbnormalType = EAbnormalStateType.None)
	{
		_MultiCastDel?.Invoke(Attacker, StiffLevel, BeAttackedAM, in EffectInstReq, bIsDotDmg, AbnormalType);
	}
}
