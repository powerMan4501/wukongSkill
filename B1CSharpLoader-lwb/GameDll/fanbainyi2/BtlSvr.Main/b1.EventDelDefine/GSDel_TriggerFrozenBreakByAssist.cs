using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_TriggerFrozenBreakByAssist : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerFrozenBreakByAssist _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TriggerFrozenBreakByAssist)Delegate.Combine(_MultiCastDel, (Del_TriggerFrozenBreakByAssist)Del);
		}
		else
		{
			_MultiCastDel = (Del_TriggerFrozenBreakByAssist)Delegate.Remove(_MultiCastDel, (Del_TriggerFrozenBreakByAssist)Del);
		}
	}

	public static GSDel_TriggerFrozenBreakByAssist operator +(GSDel_TriggerFrozenBreakByAssist GSEvent, Del_TriggerFrozenBreakByAssist Del)
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
		GSEvent._MultiCastDel = (Del_TriggerFrozenBreakByAssist)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_TriggerFrozenBreakByAssist operator -(GSDel_TriggerFrozenBreakByAssist GSEvent, Del_TriggerFrozenBreakByAssist Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TriggerFrozenBreakByAssist == Del)
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
		GSEvent._MultiCastDel = (Del_TriggerFrozenBreakByAssist)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(in FEffectInstReq EffectInstReq)
	{
		_MultiCastDel?.Invoke(in EffectInstReq);
	}
}
