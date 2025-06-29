using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_SimpleOverlapActorsByMask : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SimpleOverlapActorsByMask _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SimpleOverlapActorsByMask)Delegate.Combine(_MultiCastDel, (Del_SimpleOverlapActorsByMask)Del);
		}
		else
		{
			_MultiCastDel = (Del_SimpleOverlapActorsByMask)Delegate.Remove(_MultiCastDel, (Del_SimpleOverlapActorsByMask)Del);
		}
	}

	public static GSDel_SimpleOverlapActorsByMask operator +(GSDel_SimpleOverlapActorsByMask GSEvent, Del_SimpleOverlapActorsByMask Del)
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
		GSEvent._MultiCastDel = (Del_SimpleOverlapActorsByMask)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_SimpleOverlapActorsByMask operator -(GSDel_SimpleOverlapActorsByMask GSEvent, Del_SimpleOverlapActorsByMask Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SimpleOverlapActorsByMask == Del)
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
		GSEvent._MultiCastDel = (Del_SimpleOverlapActorsByMask)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public bool Invoke(AActor Owner, List<int> Masks, float SphereRadius, float SquareSize, bool IsSphere, out List<AActor> OutActor)
	{
		OutActor = null;
		if (_MultiCastDel == null)
		{
			return false;
		}
		return _MultiCastDel(Owner, Masks, SphereRadius, SquareSize, IsSphere, out OutActor);
	}
}
