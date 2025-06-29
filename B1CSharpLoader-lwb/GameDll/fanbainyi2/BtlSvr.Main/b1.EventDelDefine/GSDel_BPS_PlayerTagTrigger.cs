using System;
using System.Collections.Generic;
using b1.ECS;
using BtlShare;

namespace b1.EventDelDefine;

public class GSDel_BPS_PlayerTagTrigger : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_BPS_PlayerTagTrigger _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_BPS_PlayerTagTrigger)Delegate.Combine(_MultiCastDel, (Del_BPS_PlayerTagTrigger)Del);
		}
		else
		{
			_MultiCastDel = (Del_BPS_PlayerTagTrigger)Delegate.Remove(_MultiCastDel, (Del_BPS_PlayerTagTrigger)Del);
		}
	}

	public static GSDel_BPS_PlayerTagTrigger operator +(GSDel_BPS_PlayerTagTrigger GSEvent, Del_BPS_PlayerTagTrigger Del)
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
		GSEvent._MultiCastDel = (Del_BPS_PlayerTagTrigger)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_BPS_PlayerTagTrigger operator -(GSDel_BPS_PlayerTagTrigger GSEvent, Del_BPS_PlayerTagTrigger Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_BPS_PlayerTagTrigger == Del)
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
		GSEvent._MultiCastDel = (Del_BPS_PlayerTagTrigger)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(EBGPTagTrigger TagTrigger, float Time, bool NeedForceUpdate = false)
	{
		_MultiCastDel?.Invoke(TagTrigger, Time, NeedForceUpdate);
	}
}
