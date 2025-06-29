using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_BeginPreMontageSectionJumpDetection_ICB : IFreshAbleGSEvent
{
	private Del_BeginPreMontageSectionJumpDetection _InvokeCallBack;

	private Action<Del_BeginPreMontageSectionJumpDetection> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_BeginPreMontageSectionJumpDetection _MultiCastDel;

	public GSDel_BeginPreMontageSectionJumpDetection_ICB(Del_BeginPreMontageSectionJumpDetection InvokeCallBack, Action<Del_BeginPreMontageSectionJumpDetection> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_BeginPreMontageSectionJumpDetection)Delegate.Combine(_MultiCastDel, (Del_BeginPreMontageSectionJumpDetection)Del);
		}
		else
		{
			_MultiCastDel = (Del_BeginPreMontageSectionJumpDetection)Delegate.Remove(_MultiCastDel, (Del_BeginPreMontageSectionJumpDetection)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_BeginPreMontageSectionJumpDetection_ICB operator +(GSDel_BeginPreMontageSectionJumpDetection_ICB GSEvent, Del_BeginPreMontageSectionJumpDetection Del)
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
		GSEvent._MultiCastDel = (Del_BeginPreMontageSectionJumpDetection)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_BeginPreMontageSectionJumpDetection_ICB operator -(GSDel_BeginPreMontageSectionJumpDetection_ICB GSEvent, Del_BeginPreMontageSectionJumpDetection Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_BeginPreMontageSectionJumpDetection == Del)
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
		GSEvent._MultiCastDel = (Del_BeginPreMontageSectionJumpDetection)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(MontageSectionJumpType SectionJumpType, EBGUSimpleState IgnoreSimpleState, Dictionary<FName, float> DetectionConfig, float DetectionDuration, EChangeTargetType OverlayDetectTargetType = EChangeTargetType.None, bool bEnableDebugDraw = false)
	{
		_InvokeCallBack?.Invoke(SectionJumpType, IgnoreSimpleState, DetectionConfig, DetectionDuration, OverlayDetectTargetType, bEnableDebugDraw);
	}
}
