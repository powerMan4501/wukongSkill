using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Plugins.Niagara;

namespace b1.EventDelDefine;

public class GSDel_EventOnUpdateDispInteractNSSystem : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_EventOnUpdateDispInteractNSSystem _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_EventOnUpdateDispInteractNSSystem)Delegate.Combine(_MultiCastDel, (Del_EventOnUpdateDispInteractNSSystem)Del);
		}
		else
		{
			_MultiCastDel = (Del_EventOnUpdateDispInteractNSSystem)Delegate.Remove(_MultiCastDel, (Del_EventOnUpdateDispInteractNSSystem)Del);
		}
	}

	public static GSDel_EventOnUpdateDispInteractNSSystem operator +(GSDel_EventOnUpdateDispInteractNSSystem GSEvent, Del_EventOnUpdateDispInteractNSSystem Del)
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
		GSEvent._MultiCastDel = (Del_EventOnUpdateDispInteractNSSystem)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_EventOnUpdateDispInteractNSSystem operator -(GSDel_EventOnUpdateDispInteractNSSystem GSEvent, Del_EventOnUpdateDispInteractNSSystem Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_EventOnUpdateDispInteractNSSystem == Del)
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
		GSEvent._MultiCastDel = (Del_EventOnUpdateDispInteractNSSystem)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(UNiagaraSystem NS_Landscape_Interactive, UNiagaraSystem NS_Landscape_Simulator)
	{
		_MultiCastDel?.Invoke(NS_Landscape_Interactive, NS_Landscape_Simulator);
	}
}
