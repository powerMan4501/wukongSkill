using System;
using System.Collections.Generic;
using b1.ECS;
using ResB1;

namespace b1.EventDelDefine;

public class GSDel_TriggerCostItemSvr : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerCostItemSvr _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TriggerCostItemSvr)Delegate.Combine(_MultiCastDel, (Del_TriggerCostItemSvr)Del);
		}
		else
		{
			_MultiCastDel = (Del_TriggerCostItemSvr)Delegate.Remove(_MultiCastDel, (Del_TriggerCostItemSvr)Del);
		}
	}

	public static GSDel_TriggerCostItemSvr operator +(GSDel_TriggerCostItemSvr GSEvent, Del_TriggerCostItemSvr Del)
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
		GSEvent._MultiCastDel = (Del_TriggerCostItemSvr)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_TriggerCostItemSvr operator -(GSDel_TriggerCostItemSvr GSEvent, Del_TriggerCostItemSvr Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TriggerCostItemSvr == Del)
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
		GSEvent._MultiCastDel = (Del_TriggerCostItemSvr)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(List<ItemOne> ItemList, OPReason Reason)
	{
		_MultiCastDel?.Invoke(ItemList, Reason);
	}
}
