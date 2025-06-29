using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_TrySwitchCameraLockTarget_ICB : IFreshAbleGSEvent
{
	private Del_TrySwitchCameraLockTarget _InvokeCallBack;

	private Action<Del_TrySwitchCameraLockTarget> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TrySwitchCameraLockTarget _MultiCastDel;

	public GSDel_TrySwitchCameraLockTarget_ICB(Del_TrySwitchCameraLockTarget InvokeCallBack, Action<Del_TrySwitchCameraLockTarget> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TrySwitchCameraLockTarget)Delegate.Combine(_MultiCastDel, (Del_TrySwitchCameraLockTarget)Del);
		}
		else
		{
			_MultiCastDel = (Del_TrySwitchCameraLockTarget)Delegate.Remove(_MultiCastDel, (Del_TrySwitchCameraLockTarget)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_TrySwitchCameraLockTarget_ICB operator +(GSDel_TrySwitchCameraLockTarget_ICB GSEvent, Del_TrySwitchCameraLockTarget Del)
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
		GSEvent._MultiCastDel = (Del_TrySwitchCameraLockTarget)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_TrySwitchCameraLockTarget_ICB operator -(GSDel_TrySwitchCameraLockTarget_ICB GSEvent, Del_TrySwitchCameraLockTarget Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TrySwitchCameraLockTarget == Del)
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
		GSEvent._MultiCastDel = (Del_TrySwitchCameraLockTarget)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int ActionId, FVector2D InputAxis, float AngleMax, float ActionGap, float RecordTime, float Dist)
	{
		_InvokeCallBack?.Invoke(ActionId, InputAxis, AngleMax, ActionGap, RecordTime, Dist);
	}
}
