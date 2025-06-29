using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_ClientForceDestroyInValidTamer : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ClientForceDestroyInValidTamer _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ClientForceDestroyInValidTamer)Delegate.Combine(_MultiCastDel, (Del_ClientForceDestroyInValidTamer)Del);
		}
		else
		{
			_MultiCastDel = (Del_ClientForceDestroyInValidTamer)Delegate.Remove(_MultiCastDel, (Del_ClientForceDestroyInValidTamer)Del);
		}
	}

	public static GSDel_ClientForceDestroyInValidTamer operator +(GSDel_ClientForceDestroyInValidTamer GSEvent, Del_ClientForceDestroyInValidTamer Del)
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
		GSEvent._MultiCastDel = (Del_ClientForceDestroyInValidTamer)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_ClientForceDestroyInValidTamer operator -(GSDel_ClientForceDestroyInValidTamer GSEvent, Del_ClientForceDestroyInValidTamer Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ClientForceDestroyInValidTamer == Del)
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
		GSEvent._MultiCastDel = (Del_ClientForceDestroyInValidTamer)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(List<string> Guids)
	{
		_MultiCastDel?.Invoke(Guids);
	}
}
