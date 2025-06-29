using System;
using System.Collections.Generic;
using b1.ECS;
using b1.Plugins.AkAudio;

namespace b1.EventDelDefine;

public class GSDel_PostAkEvent_OnAkComp : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_PostAkEvent_OnAkComp _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_PostAkEvent_OnAkComp)Delegate.Combine(_MultiCastDel, (Del_PostAkEvent_OnAkComp)Del);
		}
		else
		{
			_MultiCastDel = (Del_PostAkEvent_OnAkComp)Delegate.Remove(_MultiCastDel, (Del_PostAkEvent_OnAkComp)Del);
		}
	}

	public static GSDel_PostAkEvent_OnAkComp operator +(GSDel_PostAkEvent_OnAkComp GSEvent, Del_PostAkEvent_OnAkComp Del)
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
		GSEvent._MultiCastDel = (Del_PostAkEvent_OnAkComp)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_PostAkEvent_OnAkComp operator -(GSDel_PostAkEvent_OnAkComp GSEvent, Del_PostAkEvent_OnAkComp Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_PostAkEvent_OnAkComp == Del)
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
		GSEvent._MultiCastDel = (Del_PostAkEvent_OnAkComp)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(UAkComponent AkComp, UAkAudioEvent AkEvent, bool bPlaySubtitle = false, bool bNeedRecordSubtitleStamp = false, string GroupName = "", string SwitchStateName = "", bool bAkCompIsAutoDestroy = false)
	{
		_MultiCastDel?.Invoke(AkComp, AkEvent, bPlaySubtitle, bNeedRecordSubtitleStamp, GroupName, SwitchStateName, bAkCompIsAutoDestroy);
	}
}
