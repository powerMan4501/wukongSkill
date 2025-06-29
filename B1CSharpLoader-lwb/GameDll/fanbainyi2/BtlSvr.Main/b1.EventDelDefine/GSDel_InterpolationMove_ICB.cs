using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_InterpolationMove_ICB : IFreshAbleGSEvent
{
	private Del_InterpolationMove _InvokeCallBack;

	private Action<Del_InterpolationMove> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_InterpolationMove _MultiCastDel;

	public GSDel_InterpolationMove_ICB(Del_InterpolationMove InvokeCallBack, Action<Del_InterpolationMove> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_InterpolationMove)Delegate.Combine(_MultiCastDel, (Del_InterpolationMove)Del);
		}
		else
		{
			_MultiCastDel = (Del_InterpolationMove)Delegate.Remove(_MultiCastDel, (Del_InterpolationMove)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_InterpolationMove_ICB operator +(GSDel_InterpolationMove_ICB GSEvent, Del_InterpolationMove Del)
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
		GSEvent._MultiCastDel = (Del_InterpolationMove)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_InterpolationMove_ICB operator -(GSDel_InterpolationMove_ICB GSEvent, Del_InterpolationMove Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_InterpolationMove == Del)
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
		GSEvent._MultiCastDel = (Del_InterpolationMove)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FVector TargetLoc, FRotator TargetRot, float TotalTime, bool EnableZAxisMove, bool IgnoreLocation, bool IgnoreLocationRotation, bool ForceUpdate)
	{
		_InvokeCallBack?.Invoke(TargetLoc, TargetRot, TotalTime, EnableZAxisMove, IgnoreLocation, IgnoreLocationRotation, ForceUpdate);
	}
}
