using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_Evt_NotifyUnitTrans_BeforePosses : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_Evt_NotifyUnitTrans_BeforePosses _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_Evt_NotifyUnitTrans_BeforePosses)Delegate.Combine(_MultiCastDel, (Del_Evt_NotifyUnitTrans_BeforePosses)Del);
		}
		else
		{
			_MultiCastDel = (Del_Evt_NotifyUnitTrans_BeforePosses)Delegate.Remove(_MultiCastDel, (Del_Evt_NotifyUnitTrans_BeforePosses)Del);
		}
	}

	public static GSDel_Evt_NotifyUnitTrans_BeforePosses operator +(GSDel_Evt_NotifyUnitTrans_BeforePosses GSEvent, Del_Evt_NotifyUnitTrans_BeforePosses Del)
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
		GSEvent._MultiCastDel = (Del_Evt_NotifyUnitTrans_BeforePosses)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_Evt_NotifyUnitTrans_BeforePosses operator -(GSDel_Evt_NotifyUnitTrans_BeforePosses GSEvent, Del_Evt_NotifyUnitTrans_BeforePosses Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_Evt_NotifyUnitTrans_BeforePosses == Del)
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
		GSEvent._MultiCastDel = (Del_Evt_NotifyUnitTrans_BeforePosses)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(EPlayerTransEndType UnitTransType)
	{
		_MultiCastDel?.Invoke(UnitTransType);
	}
}
