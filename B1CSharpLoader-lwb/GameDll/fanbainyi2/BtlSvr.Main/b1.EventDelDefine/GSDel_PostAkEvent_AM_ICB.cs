using System;
using System.Collections.Generic;
using b1.ECS;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_PostAkEvent_AM_ICB : IFreshAbleGSEvent
{
	private Del_PostAkEvent_AM _InvokeCallBack;

	private Action<Del_PostAkEvent_AM> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_PostAkEvent_AM _MultiCastDel;

	public GSDel_PostAkEvent_AM_ICB(Del_PostAkEvent_AM InvokeCallBack, Action<Del_PostAkEvent_AM> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_PostAkEvent_AM)Delegate.Combine(_MultiCastDel, (Del_PostAkEvent_AM)Del);
		}
		else
		{
			_MultiCastDel = (Del_PostAkEvent_AM)Delegate.Remove(_MultiCastDel, (Del_PostAkEvent_AM)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_PostAkEvent_AM_ICB operator +(GSDel_PostAkEvent_AM_ICB GSEvent, Del_PostAkEvent_AM Del)
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
		GSEvent._MultiCastDel = (Del_PostAkEvent_AM)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_PostAkEvent_AM_ICB operator -(GSDel_PostAkEvent_AM_ICB GSEvent, Del_PostAkEvent_AM Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_PostAkEvent_AM == Del)
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
		GSEvent._MultiCastDel = (Del_PostAkEvent_AM)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int MontageID, UMeshComponent MeshComp, FName AttachPointName, UAkAudioEvent AkEvent, UAkAudioEvent AkStopEvent, bool Follow, string EventName, bool CanHandleStopRequest, bool bPlaySubtitle = true, string GroupName = "", string SwitchStateName = "")
	{
		_InvokeCallBack?.Invoke(MontageID, MeshComp, AttachPointName, AkEvent, AkStopEvent, Follow, EventName, CanHandleStopRequest, bPlaySubtitle, GroupName, SwitchStateName);
	}
}
