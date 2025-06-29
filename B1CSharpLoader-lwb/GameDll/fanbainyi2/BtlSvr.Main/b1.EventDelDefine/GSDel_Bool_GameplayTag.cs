using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_Bool_GameplayTag : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_Bool_GameplayTag _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_Bool_GameplayTag)Delegate.Combine(_MultiCastDel, (Del_Bool_GameplayTag)Del);
		}
		else
		{
			_MultiCastDel = (Del_Bool_GameplayTag)Delegate.Remove(_MultiCastDel, (Del_Bool_GameplayTag)Del);
		}
	}

	public static GSDel_Bool_GameplayTag operator +(GSDel_Bool_GameplayTag GSEvent, Del_Bool_GameplayTag Del)
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
		GSEvent._MultiCastDel = (Del_Bool_GameplayTag)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_Bool_GameplayTag operator -(GSDel_Bool_GameplayTag GSEvent, Del_Bool_GameplayTag Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_Bool_GameplayTag == Del)
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
		GSEvent._MultiCastDel = (Del_Bool_GameplayTag)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public bool Invoke(FGameplayTag Tag)
	{
		if (_MultiCastDel == null)
		{
			return false;
		}
		return _MultiCastDel(Tag);
	}
}
