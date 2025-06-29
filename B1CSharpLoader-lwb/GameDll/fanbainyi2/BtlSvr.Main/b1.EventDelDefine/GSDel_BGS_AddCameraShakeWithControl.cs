using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.GameplayCameras;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_BGS_AddCameraShakeWithControl : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_BGS_AddCameraShakeWithControl _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_BGS_AddCameraShakeWithControl)Delegate.Combine(_MultiCastDel, (Del_BGS_AddCameraShakeWithControl)Del);
		}
		else
		{
			_MultiCastDel = (Del_BGS_AddCameraShakeWithControl)Delegate.Remove(_MultiCastDel, (Del_BGS_AddCameraShakeWithControl)Del);
		}
	}

	public static GSDel_BGS_AddCameraShakeWithControl operator +(GSDel_BGS_AddCameraShakeWithControl GSEvent, Del_BGS_AddCameraShakeWithControl Del)
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
		GSEvent._MultiCastDel = (Del_BGS_AddCameraShakeWithControl)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_BGS_AddCameraShakeWithControl operator -(GSDel_BGS_AddCameraShakeWithControl GSEvent, Del_BGS_AddCameraShakeWithControl Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_BGS_AddCameraShakeWithControl == Del)
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
		GSEvent._MultiCastDel = (Del_BGS_AddCameraShakeWithControl)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(UMatineeCameraShake CamShakeInst, UCurveFloat CamShakeScaleByDistCurve, FVector EpicenterLoc, float Override_Duration = -1f, bool EpicenterIsAttach = false, FName SocketName = default(FName), AActor EpicenterOwner = null, int ReqID = -1)
	{
		_MultiCastDel?.Invoke(CamShakeInst, CamShakeScaleByDistCurve, EpicenterLoc, Override_Duration, EpicenterIsAttach, SocketName, EpicenterOwner, ReqID);
	}
}
