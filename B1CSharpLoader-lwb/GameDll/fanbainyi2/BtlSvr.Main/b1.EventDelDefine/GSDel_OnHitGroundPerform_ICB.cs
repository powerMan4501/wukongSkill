using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_OnHitGroundPerform_ICB : IFreshAbleGSEvent
{
	private Del_OnHitGroundPerform _InvokeCallBack;

	private Action<Del_OnHitGroundPerform> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnHitGroundPerform _MultiCastDel;

	public GSDel_OnHitGroundPerform_ICB(Del_OnHitGroundPerform InvokeCallBack, Action<Del_OnHitGroundPerform> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

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
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_OnHitGroundPerform_ICB operator +(GSDel_OnHitGroundPerform_ICB GSEvent, Del_OnHitGroundPerform Del)
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
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_OnHitGroundPerform_ICB operator -(GSDel_OnHitGroundPerform_ICB GSEvent, Del_OnHitGroundPerform Del)
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
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(UObject World, List<EAtkFXOnGroundType> AtkFXTypeList, FVector PreLocation, float LineTraceHeight, float SamplingRadius, int SkillEffectID, float SurfaceSamplingRadius, bool EnableCheckThroughWall, float HitFXRadiusMin, float HitFXRadiusMax, float HitFXRadiusExpandTime)
	{
		_InvokeCallBack?.Invoke(World, AtkFXTypeList, PreLocation, LineTraceHeight, SamplingRadius, SkillEffectID, SurfaceSamplingRadius, EnableCheckThroughWall, HitFXRadiusMin, HitFXRadiusMax, HitFXRadiusExpandTime);
	}
}
