using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_PlayCameraSequence_ICB : IFreshAbleGSEvent
{
	private Del_PlayCameraSequence _InvokeCallBack;

	private Action<Del_PlayCameraSequence> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_PlayCameraSequence _MultiCastDel;

	public GSDel_PlayCameraSequence_ICB(Del_PlayCameraSequence InvokeCallBack, Action<Del_PlayCameraSequence> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_PlayCameraSequence)Delegate.Combine(_MultiCastDel, (Del_PlayCameraSequence)Del);
		}
		else
		{
			_MultiCastDel = (Del_PlayCameraSequence)Delegate.Remove(_MultiCastDel, (Del_PlayCameraSequence)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_PlayCameraSequence_ICB operator +(GSDel_PlayCameraSequence_ICB GSEvent, Del_PlayCameraSequence Del)
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
		GSEvent._MultiCastDel = (Del_PlayCameraSequence)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_PlayCameraSequence_ICB operator -(GSDel_PlayCameraSequence_ICB GSEvent, Del_PlayCameraSequence Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_PlayCameraSequence == Del)
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
		GSEvent._MultiCastDel = (Del_PlayCameraSequence)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor MasterActor, FGSCameraSequencePlaySetting PlaySetting, float Duration, bool IsSeqAttachToActor)
	{
		_InvokeCallBack?.Invoke(MasterActor, PlaySetting, Duration, IsSeqAttachToActor);
	}
}
