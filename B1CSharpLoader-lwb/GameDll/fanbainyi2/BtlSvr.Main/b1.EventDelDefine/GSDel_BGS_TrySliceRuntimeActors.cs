using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_BGS_TrySliceRuntimeActors : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_BGS_TrySliceRuntimeActors _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_BGS_TrySliceRuntimeActors)Delegate.Combine(_MultiCastDel, (Del_BGS_TrySliceRuntimeActors)Del);
		}
		else
		{
			_MultiCastDel = (Del_BGS_TrySliceRuntimeActors)Delegate.Remove(_MultiCastDel, (Del_BGS_TrySliceRuntimeActors)Del);
		}
	}

	public static GSDel_BGS_TrySliceRuntimeActors operator +(GSDel_BGS_TrySliceRuntimeActors GSEvent, Del_BGS_TrySliceRuntimeActors Del)
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
		GSEvent._MultiCastDel = (Del_BGS_TrySliceRuntimeActors)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_BGS_TrySliceRuntimeActors operator -(GSDel_BGS_TrySliceRuntimeActors GSEvent, Del_BGS_TrySliceRuntimeActors Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_BGS_TrySliceRuntimeActors == Del)
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
		GSEvent._MultiCastDel = (Del_BGS_TrySliceRuntimeActors)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(FVector PivotLocation, FVector PreSliceEdge, FVector PostSliceEdge, float SliceLength, float ApplyForce, bool bIsReflexAngle, bool bShowDebug)
	{
		_MultiCastDel?.Invoke(PivotLocation, PreSliceEdge, PostSliceEdge, SliceLength, ApplyForce, bIsReflexAngle, bShowDebug);
	}
}
