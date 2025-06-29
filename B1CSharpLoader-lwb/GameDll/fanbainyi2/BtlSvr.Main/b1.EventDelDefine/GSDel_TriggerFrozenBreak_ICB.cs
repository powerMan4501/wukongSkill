using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_TriggerFrozenBreak_ICB : IFreshAbleGSEvent
{
	private Action<FEffectInstReq, UAnimMontage, bool> _InvokeCallBack;

	private Action<Del_TriggerFrozenBreak> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerFrozenBreak _MultiCastDel;

	public GSDel_TriggerFrozenBreak_ICB(Action<FEffectInstReq, UAnimMontage, bool> InvokeCallBack, Action<Del_TriggerFrozenBreak> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TriggerFrozenBreak)Delegate.Combine(_MultiCastDel, (Del_TriggerFrozenBreak)Del);
		}
		else
		{
			_MultiCastDel = (Del_TriggerFrozenBreak)Delegate.Remove(_MultiCastDel, (Del_TriggerFrozenBreak)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_TriggerFrozenBreak_ICB operator +(GSDel_TriggerFrozenBreak_ICB GSEvent, Del_TriggerFrozenBreak Del)
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
		GSEvent._MultiCastDel = (Del_TriggerFrozenBreak)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_TriggerFrozenBreak_ICB operator -(GSDel_TriggerFrozenBreak_ICB GSEvent, Del_TriggerFrozenBreak Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TriggerFrozenBreak == Del)
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
		GSEvent._MultiCastDel = (Del_TriggerFrozenBreak)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FEffectInstReq EffectInstReq, UAnimMontage FrozenBreakAM, bool bIsNormalStiff)
	{
		_InvokeCallBack?.Invoke(EffectInstReq, FrozenBreakAM, bIsNormalStiff);
	}
}
