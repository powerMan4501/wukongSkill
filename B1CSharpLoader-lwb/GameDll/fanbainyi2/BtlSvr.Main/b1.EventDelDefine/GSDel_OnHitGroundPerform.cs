using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_OnHitGroundPerform : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnHitGroundPerform _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnHitGroundPerform)Delegate.Combine(_MultiCastDel, (Del_OnHitGroundPerform)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnHitGroundPerform)Delegate.Remove(_MultiCastDel, (Del_OnHitGroundPerform)Del);
		}
	}

	public static GSDel_OnHitGroundPerform operator +(GSDel_OnHitGroundPerform GSEvent, Del_OnHitGroundPerform Del)
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
		GSEvent._MultiCastDel = (Del_OnHitGroundPerform)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_OnHitGroundPerform operator -(GSDel_OnHitGroundPerform GSEvent, Del_OnHitGroundPerform Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnHitGroundPerform == Del)
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
		GSEvent._MultiCastDel = (Del_OnHitGroundPerform)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(UObject World, List<EAtkFXOnGroundType> AtkFXTypeList, FVector PreLocation, float LineTraceHeight, float SamplingRadius, int SkillEffectID, float SurfaceSamplingRadius, bool EnableCheckThroughWall, float HitFXRadiusMin, float HitFXRadiusMax, float HitFXRadiusExpandTime)
	{
		_MultiCastDel?.Invoke(World, AtkFXTypeList, PreLocation, LineTraceHeight, SamplingRadius, SkillEffectID, SurfaceSamplingRadius, EnableCheckThroughWall, HitFXRadiusMin, HitFXRadiusMax, HitFXRadiusExpandTime);
	}
}
