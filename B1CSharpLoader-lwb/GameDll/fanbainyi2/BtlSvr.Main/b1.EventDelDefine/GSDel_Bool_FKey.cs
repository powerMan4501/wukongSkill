using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.InputCore;

namespace b1.EventDelDefine;

public class GSDel_Bool_FKey : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_Bool_FKey _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_Bool_FKey)Delegate.Combine(_MultiCastDel, (Del_Bool_FKey)Del);
		}
		else
		{
			_MultiCastDel = (Del_Bool_FKey)Delegate.Remove(_MultiCastDel, (Del_Bool_FKey)Del);
		}
	}

	public static GSDel_Bool_FKey operator +(GSDel_Bool_FKey GSEvent, Del_Bool_FKey Del)
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
		GSEvent._MultiCastDel = (Del_Bool_FKey)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_Bool_FKey operator -(GSDel_Bool_FKey GSEvent, Del_Bool_FKey Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_Bool_FKey == Del)
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
		GSEvent._MultiCastDel = (Del_Bool_FKey)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(bool B1, FKey InKey)
	{
		_MultiCastDel?.Invoke(B1, InKey);
	}
}
