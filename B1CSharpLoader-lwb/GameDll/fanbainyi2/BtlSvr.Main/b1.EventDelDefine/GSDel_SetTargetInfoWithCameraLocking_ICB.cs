using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SetTargetInfoWithCameraLocking_ICB : IFreshAbleGSEvent
{
	private Del_SetTargetInfoWithCameraLocking _InvokeCallBack;

	private Action<Del_SetTargetInfoWithCameraLocking> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetTargetInfoWithCameraLocking _MultiCastDel;

	public GSDel_SetTargetInfoWithCameraLocking_ICB(Del_SetTargetInfoWithCameraLocking InvokeCallBack, Action<Del_SetTargetInfoWithCameraLocking> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetTargetInfoWithCameraLocking)Delegate.Combine(_MultiCastDel, (Del_SetTargetInfoWithCameraLocking)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetTargetInfoWithCameraLocking)Delegate.Remove(_MultiCastDel, (Del_SetTargetInfoWithCameraLocking)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetTargetInfoWithCameraLocking_ICB operator +(GSDel_SetTargetInfoWithCameraLocking_ICB GSEvent, Del_SetTargetInfoWithCameraLocking Del)
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
		GSEvent._MultiCastDel = (Del_SetTargetInfoWithCameraLocking)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetTargetInfoWithCameraLocking_ICB operator -(GSDel_SetTargetInfoWithCameraLocking_ICB GSEvent, Del_SetTargetInfoWithCameraLocking Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetTargetInfoWithCameraLocking == Del)
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
		GSEvent._MultiCastDel = (Del_SetTargetInfoWithCameraLocking)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(UnitLockTargetInfo NewTargetInfo)
	{
		_InvokeCallBack?.Invoke(NewTargetInfo);
	}
}
