using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_AITransformBySplineStop_ICB : IFreshAbleGSEvent
{
	private Del_AITransformBySplineStop _InvokeCallBack;

	private Action<Del_AITransformBySplineStop> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_AITransformBySplineStop _MultiCastDel;

	public GSDel_AITransformBySplineStop_ICB(Del_AITransformBySplineStop InvokeCallBack, Action<Del_AITransformBySplineStop> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_AITransformBySplineStop)Delegate.Combine(_MultiCastDel, (Del_AITransformBySplineStop)Del);
		}
		else
		{
			_MultiCastDel = (Del_AITransformBySplineStop)Delegate.Remove(_MultiCastDel, (Del_AITransformBySplineStop)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_AITransformBySplineStop_ICB operator +(GSDel_AITransformBySplineStop_ICB GSEvent, Del_AITransformBySplineStop Del)
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
		GSEvent._MultiCastDel = (Del_AITransformBySplineStop)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_AITransformBySplineStop_ICB operator -(GSDel_AITransformBySplineStop_ICB GSEvent, Del_AITransformBySplineStop Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_AITransformBySplineStop == Del)
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
		GSEvent._MultiCastDel = (Del_AITransformBySplineStop)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(in AActor _Target, in BAIT_Base _BAITRef, in BANS_GSBase _BANSRef)
	{
		_InvokeCallBack?.Invoke(in _Target, in _BAITRef, in _BANSRef);
	}
}
