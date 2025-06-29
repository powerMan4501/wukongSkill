using System;
using System.Collections.Generic;
using b1.ECS;
using b1.Plugins.AkAudio;

namespace b1.EventDelDefine;

public class GSDel_PostCloudMoveAkEvent_ICB : IFreshAbleGSEvent
{
	private Del_PostCloudMoveAkEvent _InvokeCallBack;

	private Action<Del_PostCloudMoveAkEvent> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_PostCloudMoveAkEvent _MultiCastDel;

	public GSDel_PostCloudMoveAkEvent_ICB(Del_PostCloudMoveAkEvent InvokeCallBack, Action<Del_PostCloudMoveAkEvent> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_PostCloudMoveAkEvent)Delegate.Combine(_MultiCastDel, (Del_PostCloudMoveAkEvent)Del);
		}
		else
		{
			_MultiCastDel = (Del_PostCloudMoveAkEvent)Delegate.Remove(_MultiCastDel, (Del_PostCloudMoveAkEvent)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_PostCloudMoveAkEvent_ICB operator +(GSDel_PostCloudMoveAkEvent_ICB GSEvent, Del_PostCloudMoveAkEvent Del)
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
		GSEvent._MultiCastDel = (Del_PostCloudMoveAkEvent)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_PostCloudMoveAkEvent_ICB operator -(GSDel_PostCloudMoveAkEvent_ICB GSEvent, Del_PostCloudMoveAkEvent Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_PostCloudMoveAkEvent == Del)
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
		GSEvent._MultiCastDel = (Del_PostCloudMoveAkEvent)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(bool bIsStop, UAkAudioEvent AkEvent)
	{
		_InvokeCallBack?.Invoke(bIsStop, AkEvent);
	}
}
