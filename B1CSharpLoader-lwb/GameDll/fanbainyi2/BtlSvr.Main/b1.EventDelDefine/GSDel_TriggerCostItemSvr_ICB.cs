using System;
using System.Collections.Generic;
using b1.ECS;
using ResB1;

namespace b1.EventDelDefine;

public class GSDel_TriggerCostItemSvr_ICB : IFreshAbleGSEvent
{
	private Del_TriggerCostItemSvr _InvokeCallBack;

	private Action<Del_TriggerCostItemSvr> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerCostItemSvr _MultiCastDel;

	public GSDel_TriggerCostItemSvr_ICB(Del_TriggerCostItemSvr InvokeCallBack, Action<Del_TriggerCostItemSvr> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

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
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_TriggerCostItemSvr_ICB operator +(GSDel_TriggerCostItemSvr_ICB GSEvent, Del_TriggerCostItemSvr Del)
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
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_TriggerCostItemSvr_ICB operator -(GSDel_TriggerCostItemSvr_ICB GSEvent, Del_TriggerCostItemSvr Del)
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
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(List<ItemOne> ItemList, OPReason Reason)
	{
		_InvokeCallBack?.Invoke(ItemList, Reason);
	}
}
