using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_ToggleSnapshotPose_ICB : IFreshAbleGSEvent
{
	private Del_ToggleSnapshotPose _InvokeCallBack;

	private Action<Del_ToggleSnapshotPose> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ToggleSnapshotPose _MultiCastDel;

	public GSDel_ToggleSnapshotPose_ICB(Del_ToggleSnapshotPose InvokeCallBack, Action<Del_ToggleSnapshotPose> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ToggleSnapshotPose)Delegate.Combine(_MultiCastDel, (Del_ToggleSnapshotPose)Del);
		}
		else
		{
			_MultiCastDel = (Del_ToggleSnapshotPose)Delegate.Remove(_MultiCastDel, (Del_ToggleSnapshotPose)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_ToggleSnapshotPose_ICB operator +(GSDel_ToggleSnapshotPose_ICB GSEvent, Del_ToggleSnapshotPose Del)
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
		GSEvent._MultiCastDel = (Del_ToggleSnapshotPose)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_ToggleSnapshotPose_ICB operator -(GSDel_ToggleSnapshotPose_ICB GSEvent, Del_ToggleSnapshotPose Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ToggleSnapshotPose == Del)
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
		GSEvent._MultiCastDel = (Del_ToggleSnapshotPose)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(bool bEnable, FPoseSnapshot PoseSnapshot, float BlendTime = 0.1f)
	{
		_InvokeCallBack?.Invoke(bEnable, PoseSnapshot, BlendTime);
	}
}
