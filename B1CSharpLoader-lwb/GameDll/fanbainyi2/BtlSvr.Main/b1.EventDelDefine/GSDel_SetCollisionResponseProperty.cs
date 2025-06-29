using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_SetCollisionResponseProperty : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetCollisionResponseProperty _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetCollisionResponseProperty)Delegate.Combine(_MultiCastDel, (Del_SetCollisionResponseProperty)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetCollisionResponseProperty)Delegate.Remove(_MultiCastDel, (Del_SetCollisionResponseProperty)Del);
		}
	}

	public static GSDel_SetCollisionResponseProperty operator +(GSDel_SetCollisionResponseProperty GSEvent, Del_SetCollisionResponseProperty Del)
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
		GSEvent._MultiCastDel = (Del_SetCollisionResponseProperty)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_SetCollisionResponseProperty operator -(GSDel_SetCollisionResponseProperty GSEvent, Del_SetCollisionResponseProperty Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetCollisionResponseProperty == Del)
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
		GSEvent._MultiCastDel = (Del_SetCollisionResponseProperty)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(EPropType PropType, Dictionary<ECollisionChannel, ECollisionResponseType> Value, uint HandleID = 0u, uint NotifyUniqueID = 0u, bool bSetDefaultProperty = false)
	{
		_MultiCastDel?.Invoke(PropType, Value, HandleID, NotifyUniqueID, bSetDefaultProperty);
	}
}
