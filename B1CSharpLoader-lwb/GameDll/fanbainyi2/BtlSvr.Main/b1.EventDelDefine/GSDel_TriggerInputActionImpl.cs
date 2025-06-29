using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Plugins.EnhancedInput;

namespace b1.EventDelDefine;

public class GSDel_TriggerInputActionImpl : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerInputActionImpl _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TriggerInputActionImpl)Delegate.Combine(_MultiCastDel, (Del_TriggerInputActionImpl)Del);
		}
		else
		{
			_MultiCastDel = (Del_TriggerInputActionImpl)Delegate.Remove(_MultiCastDel, (Del_TriggerInputActionImpl)Del);
		}
	}

	public static GSDel_TriggerInputActionImpl operator +(GSDel_TriggerInputActionImpl GSEvent, Del_TriggerInputActionImpl Del)
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
		GSEvent._MultiCastDel = (Del_TriggerInputActionImpl)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_TriggerInputActionImpl operator -(GSDel_TriggerInputActionImpl GSEvent, Del_TriggerInputActionImpl Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TriggerInputActionImpl == Del)
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
		GSEvent._MultiCastDel = (Del_TriggerInputActionImpl)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(string ActionName, ETriggerEvent TriggerEvent, FInputActionValue Value)
	{
		_MultiCastDel?.Invoke(ActionName, TriggerEvent, Value);
	}
}
