using System;
using System.Collections.Generic;
using b1.ECS;
using BtlShare;

namespace b1.EventDelDefine;

public class GSDel_FreezeCostAttr_ICB : IFreshAbleGSEvent
{
	private Del_FreezeCostAttr _InvokeCallBack;

	private Action<Del_FreezeCostAttr> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_FreezeCostAttr _MultiCastDel;

	public GSDel_FreezeCostAttr_ICB(Del_FreezeCostAttr InvokeCallBack, Action<Del_FreezeCostAttr> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_FreezeCostAttr)Delegate.Combine(_MultiCastDel, (Del_FreezeCostAttr)Del);
		}
		else
		{
			_MultiCastDel = (Del_FreezeCostAttr)Delegate.Remove(_MultiCastDel, (Del_FreezeCostAttr)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_FreezeCostAttr_ICB operator +(GSDel_FreezeCostAttr_ICB GSEvent, Del_FreezeCostAttr Del)
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
		GSEvent._MultiCastDel = (Del_FreezeCostAttr)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_FreezeCostAttr_ICB operator -(GSDel_FreezeCostAttr_ICB GSEvent, Del_FreezeCostAttr Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_FreezeCostAttr == Del)
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
		GSEvent._MultiCastDel = (Del_FreezeCostAttr)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EAttrCostType AttrCostType, float FreezeTime, int NotifyUniqueID)
	{
		_InvokeCallBack?.Invoke(AttrCostType, FreezeTime, NotifyUniqueID);
	}
}
