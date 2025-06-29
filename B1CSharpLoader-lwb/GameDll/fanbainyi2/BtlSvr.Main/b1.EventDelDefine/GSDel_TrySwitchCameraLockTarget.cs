using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_TrySwitchCameraLockTarget : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TrySwitchCameraLockTarget _MultiCastDel;

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
	}

	public static GSDel_TrySwitchCameraLockTarget operator +(GSDel_TrySwitchCameraLockTarget GSEvent, Del_TrySwitchCameraLockTarget Del)
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
		return GSEvent;
	}

	public static GSDel_TrySwitchCameraLockTarget operator -(GSDel_TrySwitchCameraLockTarget GSEvent, Del_TrySwitchCameraLockTarget Del)
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
		return GSEvent;
	}

	public void Invoke(int ActionId, FVector2D InputAxis, float AngleMax, float ActionGap, float RecordTime, float Dist)
	{
		_MultiCastDel?.Invoke(ActionId, InputAxis, AngleMax, ActionGap, RecordTime, Dist);
	}
}
