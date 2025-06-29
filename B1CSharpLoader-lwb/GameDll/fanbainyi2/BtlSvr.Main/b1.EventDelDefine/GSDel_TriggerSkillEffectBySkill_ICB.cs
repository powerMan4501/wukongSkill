using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_TriggerSkillEffectBySkill_ICB : IFreshAbleGSEvent
{
	private Action<int, AActor, AActor, FEffectInstReq> _InvokeCallBack;

	private Action<Del_TriggerSkillEffectBySkill> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerSkillEffectBySkill _MultiCastDel;

	public GSDel_TriggerSkillEffectBySkill_ICB(Action<int, AActor, AActor, FEffectInstReq> InvokeCallBack, Action<Del_TriggerSkillEffectBySkill> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TriggerSkillEffectBySkill)Delegate.Combine(_MultiCastDel, (Del_TriggerSkillEffectBySkill)Del);
		}
		else
		{
			_MultiCastDel = (Del_TriggerSkillEffectBySkill)Delegate.Remove(_MultiCastDel, (Del_TriggerSkillEffectBySkill)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_TriggerSkillEffectBySkill_ICB operator +(GSDel_TriggerSkillEffectBySkill_ICB GSEvent, Del_TriggerSkillEffectBySkill Del)
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
		GSEvent._MultiCastDel = (Del_TriggerSkillEffectBySkill)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_TriggerSkillEffectBySkill_ICB operator -(GSDel_TriggerSkillEffectBySkill_ICB GSEvent, Del_TriggerSkillEffectBySkill Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TriggerSkillEffectBySkill == Del)
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
		GSEvent._MultiCastDel = (Del_TriggerSkillEffectBySkill)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int EffectID, AActor Caster, AActor Target, FEffectInstReq EffectInstReq)
	{
		_InvokeCallBack?.Invoke(EffectID, Caster, Target, EffectInstReq);
	}
}
