using System;
using System.Collections.Generic;
using b1.ECS;
using ResB1;

namespace b1.EventDelDefine;

public class GSDel_OSSItemChange : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OSSItemChange _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OSSItemChange)Delegate.Combine(_MultiCastDel, (Del_OSSItemChange)Del);
		}
		else
		{
			_MultiCastDel = (Del_OSSItemChange)Delegate.Remove(_MultiCastDel, (Del_OSSItemChange)Del);
		}
	}

	public static GSDel_OSSItemChange operator +(GSDel_OSSItemChange GSEvent, Del_OSSItemChange Del)
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
		GSEvent._MultiCastDel = (Del_OSSItemChange)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_OSSItemChange operator -(GSDel_OSSItemChange GSEvent, Del_OSSItemChange Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OSSItemChange == Del)
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
		GSEvent._MultiCastDel = (Del_OSSItemChange)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(int ItemId, int Num, OPReason OpReason)
	{
		_MultiCastDel?.Invoke(ItemId, Num, OpReason);
	}
}
