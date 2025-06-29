using System;
using System.Collections.Generic;
using b1.ECS;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_PostAkEvent_Follow_ICB : IFreshAbleGSEvent
{
	private Del_PostAkEvent_Follow _InvokeCallBack;

	private Action<Del_PostAkEvent_Follow> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_PostAkEvent_Follow _MultiCastDel;

	public GSDel_PostAkEvent_Follow_ICB(Del_PostAkEvent_Follow InvokeCallBack, Action<Del_PostAkEvent_Follow> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_PostAkEvent_Follow)Delegate.Combine(_MultiCastDel, (Del_PostAkEvent_Follow)Del);
		}
		else
		{
			_MultiCastDel = (Del_PostAkEvent_Follow)Delegate.Remove(_MultiCastDel, (Del_PostAkEvent_Follow)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_PostAkEvent_Follow_ICB operator +(GSDel_PostAkEvent_Follow_ICB GSEvent, Del_PostAkEvent_Follow Del)
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
		GSEvent._MultiCastDel = (Del_PostAkEvent_Follow)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_PostAkEvent_Follow_ICB operator -(GSDel_PostAkEvent_Follow_ICB GSEvent, Del_PostAkEvent_Follow Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_PostAkEvent_Follow == Del)
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
		GSEvent._MultiCastDel = (Del_PostAkEvent_Follow)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(USceneComponent SceneComp, FName AttachPointName, UAkAudioEvent AkEvent, bool bPlaySubtitle = false, bool bNeedRecordSubtitleStamp = false, string GroupName = "", string SwitchStateName = "")
	{
		_InvokeCallBack?.Invoke(SceneComp, AttachPointName, AkEvent, bPlaySubtitle, bNeedRecordSubtitleStamp, GroupName, SwitchStateName);
	}
}
