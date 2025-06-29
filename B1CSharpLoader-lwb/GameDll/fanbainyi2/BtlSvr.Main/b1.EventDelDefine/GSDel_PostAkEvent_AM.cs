using System;
using System.Collections.Generic;
using b1.ECS;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_PostAkEvent_AM : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_PostAkEvent_AM _MultiCastDel;

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
	}

	public static GSDel_PostAkEvent_AM operator +(GSDel_PostAkEvent_AM GSEvent, Del_PostAkEvent_AM Del)
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
		return GSEvent;
	}

	public static GSDel_PostAkEvent_AM operator -(GSDel_PostAkEvent_AM GSEvent, Del_PostAkEvent_AM Del)
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
		return GSEvent;
	}

	public void Invoke(int MontageID, UMeshComponent MeshComp, FName AttachPointName, UAkAudioEvent AkEvent, UAkAudioEvent AkStopEvent, bool Follow, string EventName, bool CanHandleStopRequest, bool bPlaySubtitle = true, string GroupName = "", string SwitchStateName = "")
	{
		_MultiCastDel?.Invoke(MontageID, MeshComp, AttachPointName, AkEvent, AkStopEvent, Follow, EventName, CanHandleStopRequest, bPlaySubtitle, GroupName, SwitchStateName);
	}
}
