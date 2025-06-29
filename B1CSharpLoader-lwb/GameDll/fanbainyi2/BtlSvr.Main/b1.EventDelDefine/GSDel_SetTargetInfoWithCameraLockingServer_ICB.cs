using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SetTargetInfoWithCameraLockingServer_ICB : IFreshAbleGSEvent
{
	private Del_SetTargetInfoWithCameraLockingServer _InvokeCallBack;

	private Action<Del_SetTargetInfoWithCameraLockingServer> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetTargetInfoWithCameraLockingServer _MultiCastDel;

	public GSDel_SetTargetInfoWithCameraLockingServer_ICB(Del_SetTargetInfoWithCameraLockingServer InvokeCallBack, Action<Del_SetTargetInfoWithCameraLockingServer> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetTargetInfoWithCameraLockingServer)Delegate.Combine(_MultiCastDel, (Del_SetTargetInfoWithCameraLockingServer)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetTargetInfoWithCameraLockingServer)Delegate.Remove(_MultiCastDel, (Del_SetTargetInfoWithCameraLockingServer)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetTargetInfoWithCameraLockingServer_ICB operator +(GSDel_SetTargetInfoWithCameraLockingServer_ICB GSEvent, Del_SetTargetInfoWithCameraLockingServer Del)
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
		GSEvent._MultiCastDel = (Del_SetTargetInfoWithCameraLockingServer)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetTargetInfoWithCameraLockingServer_ICB operator -(GSDel_SetTargetInfoWithCameraLockingServer_ICB GSEvent, Del_SetTargetInfoWithCameraLockingServer Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetTargetInfoWithCameraLockingServer == Del)
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
		GSEvent._MultiCastDel = (Del_SetTargetInfoWithCameraLockingServer)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FUnitLockTargetInfo NewTargetInfo)
	{
		_InvokeCallBack?.Invoke(NewTargetInfo);
	}
}
