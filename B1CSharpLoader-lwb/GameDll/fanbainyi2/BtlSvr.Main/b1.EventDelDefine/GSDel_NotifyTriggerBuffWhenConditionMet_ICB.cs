using System;
using System.Collections.Generic;
using b1.ECS;
using BtlShare;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_NotifyTriggerBuffWhenConditionMet_ICB : IFreshAbleGSEvent
{
	private Action<EBuffEffectTriggerType, FEffectInstReq, AActor> _InvokeCallBack;

	private Action<Del_NotifyTriggerBuffWhenConditionMet> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_NotifyTriggerBuffWhenConditionMet _MultiCastDel;

	public GSDel_NotifyTriggerBuffWhenConditionMet_ICB(Action<EBuffEffectTriggerType, FEffectInstReq, AActor> InvokeCallBack, Action<Del_NotifyTriggerBuffWhenConditionMet> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_NotifyTriggerBuffWhenConditionMet)Delegate.Combine(_MultiCastDel, (Del_NotifyTriggerBuffWhenConditionMet)Del);
		}
		else
		{
			_MultiCastDel = (Del_NotifyTriggerBuffWhenConditionMet)Delegate.Remove(_MultiCastDel, (Del_NotifyTriggerBuffWhenConditionMet)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_NotifyTriggerBuffWhenConditionMet_ICB operator +(GSDel_NotifyTriggerBuffWhenConditionMet_ICB GSEvent, Del_NotifyTriggerBuffWhenConditionMet Del)
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
		GSEvent._MultiCastDel = (Del_NotifyTriggerBuffWhenConditionMet)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_NotifyTriggerBuffWhenConditionMet_ICB operator -(GSDel_NotifyTriggerBuffWhenConditionMet_ICB GSEvent, Del_NotifyTriggerBuffWhenConditionMet Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_NotifyTriggerBuffWhenConditionMet == Del)
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
		GSEvent._MultiCastDel = (Del_NotifyTriggerBuffWhenConditionMet)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EBuffEffectTriggerType TriggerType, FEffectInstReq EffectInstReq = default(FEffectInstReq), AActor Victim = null)
	{
		_InvokeCallBack?.Invoke(TriggerType, EffectInstReq, Victim);
	}
}
