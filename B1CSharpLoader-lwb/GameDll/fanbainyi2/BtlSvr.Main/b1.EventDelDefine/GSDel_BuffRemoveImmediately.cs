using System;
using System.Collections.Generic;
using b1.ECS;
using BtlShare;

namespace b1.EventDelDefine;

public class GSDel_BuffRemoveImmediately : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_BuffRemoveImmediately _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_BuffRemoveImmediately)Delegate.Combine(_MultiCastDel, (Del_BuffRemoveImmediately)Del);
		}
		else
		{
			_MultiCastDel = (Del_BuffRemoveImmediately)Delegate.Remove(_MultiCastDel, (Del_BuffRemoveImmediately)Del);
		}
	}

	public static GSDel_BuffRemoveImmediately operator +(GSDel_BuffRemoveImmediately GSEvent, Del_BuffRemoveImmediately Del)
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
		GSEvent._MultiCastDel = (Del_BuffRemoveImmediately)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_BuffRemoveImmediately operator -(GSDel_BuffRemoveImmediately GSEvent, Del_BuffRemoveImmediately Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_BuffRemoveImmediately == Del)
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
		GSEvent._MultiCastDel = (Del_BuffRemoveImmediately)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(int BuffID, EBuffEffectTriggerType RemoveTriggerType, bool WithTriggerRemmoveEffect = true)
	{
		_MultiCastDel?.Invoke(BuffID, RemoveTriggerType, WithTriggerRemmoveEffect);
	}
}
