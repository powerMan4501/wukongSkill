using System;
using System.Collections.Generic;
using b1.ECS;
using BtlShare;

namespace b1.EventDelDefine;

public class GSDel_Void_StringDeadReason : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_Void_StringDeadReason _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_Void_StringDeadReason)Delegate.Combine(_MultiCastDel, (Del_Void_StringDeadReason)Del);
		}
		else
		{
			_MultiCastDel = (Del_Void_StringDeadReason)Delegate.Remove(_MultiCastDel, (Del_Void_StringDeadReason)Del);
		}
	}

	public static GSDel_Void_StringDeadReason operator +(GSDel_Void_StringDeadReason GSEvent, Del_Void_StringDeadReason Del)
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
		GSEvent._MultiCastDel = (Del_Void_StringDeadReason)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_Void_StringDeadReason operator -(GSDel_Void_StringDeadReason GSEvent, Del_Void_StringDeadReason Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_Void_StringDeadReason == Del)
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
		GSEvent._MultiCastDel = (Del_Void_StringDeadReason)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(string UnitGuid, EDeadReason DeadReason)
	{
		_MultiCastDel?.Invoke(UnitGuid, DeadReason);
	}
}
