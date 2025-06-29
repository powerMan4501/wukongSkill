using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_EQSObjRunInstantWithCustomParams : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_EQSObjRunInstantWithCustomParams _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_EQSObjRunInstantWithCustomParams)Delegate.Combine(_MultiCastDel, (Del_EQSObjRunInstantWithCustomParams)Del);
		}
		else
		{
			_MultiCastDel = (Del_EQSObjRunInstantWithCustomParams)Delegate.Remove(_MultiCastDel, (Del_EQSObjRunInstantWithCustomParams)Del);
		}
	}

	public static GSDel_EQSObjRunInstantWithCustomParams operator +(GSDel_EQSObjRunInstantWithCustomParams GSEvent, Del_EQSObjRunInstantWithCustomParams Del)
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
		GSEvent._MultiCastDel = (Del_EQSObjRunInstantWithCustomParams)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_EQSObjRunInstantWithCustomParams operator -(GSDel_EQSObjRunInstantWithCustomParams GSEvent, Del_EQSObjRunInstantWithCustomParams Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_EQSObjRunInstantWithCustomParams == Del)
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
		GSEvent._MultiCastDel = (Del_EQSObjRunInstantWithCustomParams)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(UEnvQuery EnvQueryObj, AActor Querier, List<FGSEnvNamedValue> NamedParams, out List<FVector> Locations, out List<float> Scores)
	{
		Locations = null;
		Scores = null;
		_MultiCastDel?.Invoke(EnvQueryObj, Querier, NamedParams, out Locations, out Scores);
	}
}
