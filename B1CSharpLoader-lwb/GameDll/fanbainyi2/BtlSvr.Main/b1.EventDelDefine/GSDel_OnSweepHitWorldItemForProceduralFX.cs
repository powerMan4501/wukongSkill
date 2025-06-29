using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_OnSweepHitWorldItemForProceduralFX : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnSweepHitWorldItemForProceduralFX _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnSweepHitWorldItemForProceduralFX)Delegate.Combine(_MultiCastDel, (Del_OnSweepHitWorldItemForProceduralFX)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnSweepHitWorldItemForProceduralFX)Delegate.Remove(_MultiCastDel, (Del_OnSweepHitWorldItemForProceduralFX)Del);
		}
	}

	public static GSDel_OnSweepHitWorldItemForProceduralFX operator +(GSDel_OnSweepHitWorldItemForProceduralFX GSEvent, Del_OnSweepHitWorldItemForProceduralFX Del)
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
		GSEvent._MultiCastDel = (Del_OnSweepHitWorldItemForProceduralFX)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_OnSweepHitWorldItemForProceduralFX operator -(GSDel_OnSweepHitWorldItemForProceduralFX GSEvent, Del_OnSweepHitWorldItemForProceduralFX Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnSweepHitWorldItemForProceduralFX == Del)
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
		GSEvent._MultiCastDel = (Del_OnSweepHitWorldItemForProceduralFX)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(AActor HitActor, FVector2D Position, float Size, ESceneItemSurfaceType OverrideSurfaceType, float OverrideSurfacePersistTime, int EntityID)
	{
		_MultiCastDel?.Invoke(HitActor, Position, Size, OverrideSurfaceType, OverrideSurfacePersistTime, EntityID);
	}
}
