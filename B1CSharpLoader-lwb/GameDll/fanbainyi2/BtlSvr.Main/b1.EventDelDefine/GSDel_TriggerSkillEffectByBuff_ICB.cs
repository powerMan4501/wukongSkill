using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_TriggerSkillEffectByBuff_ICB : IFreshAbleGSEvent
{
	private Action<int, AActor, int, FEffectInstReq, bool> _InvokeCallBack;

	private Action<Del_TriggerSkillEffectByBuff> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerSkillEffectByBuff _MultiCastDel;

	public GSDel_TriggerSkillEffectByBuff_ICB(Action<int, AActor, int, FEffectInstReq, bool> InvokeCallBack, Action<Del_TriggerSkillEffectByBuff> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TriggerSkillEffectByBuff)Delegate.Combine(_MultiCastDel, (Del_TriggerSkillEffectByBuff)Del);
		}
		else
		{
			_MultiCastDel = (Del_TriggerSkillEffectByBuff)Delegate.Remove(_MultiCastDel, (Del_TriggerSkillEffectByBuff)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_TriggerSkillEffectByBuff_ICB operator +(GSDel_TriggerSkillEffectByBuff_ICB GSEvent, Del_TriggerSkillEffectByBuff Del)
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
		GSEvent._MultiCastDel = (Del_TriggerSkillEffectByBuff)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_TriggerSkillEffectByBuff_ICB operator -(GSDel_TriggerSkillEffectByBuff_ICB GSEvent, Del_TriggerSkillEffectByBuff Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TriggerSkillEffectByBuff == Del)
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
		GSEvent._MultiCastDel = (Del_TriggerSkillEffectByBuff)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int BuffID, AActor Target, int EffectIdx, FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		_InvokeCallBack?.Invoke(BuffID, Target, EffectIdx, EffectInstReq, bIsPeriodical);
	}
}
