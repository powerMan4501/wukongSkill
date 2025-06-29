using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SetTraceVelocityCameraInfo : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetTraceVelocityCameraInfo _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetTraceVelocityCameraInfo)Delegate.Combine(_MultiCastDel, (Del_SetTraceVelocityCameraInfo)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetTraceVelocityCameraInfo)Delegate.Remove(_MultiCastDel, (Del_SetTraceVelocityCameraInfo)Del);
		}
	}

	public static GSDel_SetTraceVelocityCameraInfo operator +(GSDel_SetTraceVelocityCameraInfo GSEvent, Del_SetTraceVelocityCameraInfo Del)
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
		GSEvent._MultiCastDel = (Del_SetTraceVelocityCameraInfo)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_SetTraceVelocityCameraInfo operator -(GSDel_SetTraceVelocityCameraInfo GSEvent, Del_SetTraceVelocityCameraInfo Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetTraceVelocityCameraInfo == Del)
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
		GSEvent._MultiCastDel = (Del_SetTraceVelocityCameraInfo)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(bool bUseTraceVelocityCamera, float TraceSpeedRate, bool bOnlyYaw = false, float InverseTraceAngle = 0f, float PauseTimeWhenCameraInput = 0f)
	{
		_MultiCastDel?.Invoke(bUseTraceVelocityCamera, TraceSpeedRate, bOnlyYaw, InverseTraceAngle, PauseTimeWhenCameraInput);
	}
}
