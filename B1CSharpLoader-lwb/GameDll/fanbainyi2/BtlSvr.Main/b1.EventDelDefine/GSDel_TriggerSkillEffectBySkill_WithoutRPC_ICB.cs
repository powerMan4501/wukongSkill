using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_TriggerSkillEffectBySkill_WithoutRPC_ICB : IFreshAbleGSEvent
{
	private Del_TriggerSkillEffectBySkill_WithoutRPC _InvokeCallBack;

	private Action<Del_TriggerSkillEffectBySkill_WithoutRPC> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerSkillEffectBySkill_WithoutRPC _MultiCastDel;

	public GSDel_TriggerSkillEffectBySkill_WithoutRPC_ICB(Del_TriggerSkillEffectBySkill_WithoutRPC InvokeCallBack, Action<Del_TriggerSkillEffectBySkill_WithoutRPC> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TriggerSkillEffectBySkill_WithoutRPC)Delegate.Combine(_MultiCastDel, (Del_TriggerSkillEffectBySkill_WithoutRPC)Del);
		}
		else
		{
			_MultiCastDel = (Del_TriggerSkillEffectBySkill_WithoutRPC)Delegate.Remove(_MultiCastDel, (Del_TriggerSkillEffectBySkill_WithoutRPC)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_TriggerSkillEffectBySkill_WithoutRPC_ICB operator +(GSDel_TriggerSkillEffectBySkill_WithoutRPC_ICB GSEvent, Del_TriggerSkillEffectBySkill_WithoutRPC Del)
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
		GSEvent._MultiCastDel = (Del_TriggerSkillEffectBySkill_WithoutRPC)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_TriggerSkillEffectBySkill_WithoutRPC_ICB operator -(GSDel_TriggerSkillEffectBySkill_WithoutRPC_ICB GSEvent, Del_TriggerSkillEffectBySkill_WithoutRPC Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TriggerSkillEffectBySkill_WithoutRPC == Del)
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
		GSEvent._MultiCastDel = (Del_TriggerSkillEffectBySkill_WithoutRPC)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		_InvokeCallBack?.Invoke(EffectID, Caster, Target, in EffectInstReq);
	}
}
