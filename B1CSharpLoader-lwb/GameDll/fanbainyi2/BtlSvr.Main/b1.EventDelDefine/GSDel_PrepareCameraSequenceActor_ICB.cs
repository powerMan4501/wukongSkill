using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_PrepareCameraSequenceActor_ICB : IFreshAbleGSEvent
{
	private Del_PrepareCameraSequenceActor _InvokeCallBack;

	private Action<Del_PrepareCameraSequenceActor> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_PrepareCameraSequenceActor _MultiCastDel;

	public GSDel_PrepareCameraSequenceActor_ICB(Del_PrepareCameraSequenceActor InvokeCallBack, Action<Del_PrepareCameraSequenceActor> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_PrepareCameraSequenceActor)Delegate.Combine(_MultiCastDel, (Del_PrepareCameraSequenceActor)Del);
		}
		else
		{
			_MultiCastDel = (Del_PrepareCameraSequenceActor)Delegate.Remove(_MultiCastDel, (Del_PrepareCameraSequenceActor)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_PrepareCameraSequenceActor_ICB operator +(GSDel_PrepareCameraSequenceActor_ICB GSEvent, Del_PrepareCameraSequenceActor Del)
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
		GSEvent._MultiCastDel = (Del_PrepareCameraSequenceActor)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_PrepareCameraSequenceActor_ICB operator -(GSDel_PrepareCameraSequenceActor_ICB GSEvent, Del_PrepareCameraSequenceActor Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_PrepareCameraSequenceActor == Del)
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
		GSEvent._MultiCastDel = (Del_PrepareCameraSequenceActor)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FGSCameraSequenceData CameraSequenceData, ref FTransform StartTransform, bool IsSeqAttachToActor = false)
	{
		_InvokeCallBack?.Invoke(CameraSequenceData, ref StartTransform, IsSeqAttachToActor);
	}
}
