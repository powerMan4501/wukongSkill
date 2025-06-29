using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_AITransformBySplineChange_ICB : IFreshAbleGSEvent
{
	private Del_AITransformBySplineChange _InvokeCallBack;

	private Action<Del_AITransformBySplineChange> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_AITransformBySplineChange _MultiCastDel;

	public GSDel_AITransformBySplineChange_ICB(Del_AITransformBySplineChange InvokeCallBack, Action<Del_AITransformBySplineChange> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_AITransformBySplineChange)Delegate.Combine(_MultiCastDel, (Del_AITransformBySplineChange)Del);
		}
		else
		{
			_MultiCastDel = (Del_AITransformBySplineChange)Delegate.Remove(_MultiCastDel, (Del_AITransformBySplineChange)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_AITransformBySplineChange_ICB operator +(GSDel_AITransformBySplineChange_ICB GSEvent, Del_AITransformBySplineChange Del)
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
		GSEvent._MultiCastDel = (Del_AITransformBySplineChange)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_AITransformBySplineChange_ICB operator -(GSDel_AITransformBySplineChange_ICB GSEvent, Del_AITransformBySplineChange Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_AITransformBySplineChange == Del)
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
		GSEvent._MultiCastDel = (Del_AITransformBySplineChange)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(float _RemainTime, ETransformBySplineRotateType _RotateType, in AActor _Target, in FGameplayTag SplineGuid, bool bShowDebug, in BAIT_Base _BAITRef, in BANS_GSBase _BANSRef)
	{
		_InvokeCallBack?.Invoke(_RemainTime, _RotateType, in _Target, in SplineGuid, bShowDebug, in _BAITRef, in _BANSRef);
	}
}
