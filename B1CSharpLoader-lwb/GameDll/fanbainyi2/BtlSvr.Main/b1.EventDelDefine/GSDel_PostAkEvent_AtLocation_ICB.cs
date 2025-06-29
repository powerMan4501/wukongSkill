using System;
using System.Collections.Generic;
using b1.ECS;
using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_PostAkEvent_AtLocation_ICB : IFreshAbleGSEvent
{
	private Del_PostAkEvent_AtLocation _InvokeCallBack;

	private Action<Del_PostAkEvent_AtLocation> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_PostAkEvent_AtLocation _MultiCastDel;

	public GSDel_PostAkEvent_AtLocation_ICB(Del_PostAkEvent_AtLocation InvokeCallBack, Action<Del_PostAkEvent_AtLocation> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_PostAkEvent_AtLocation)Delegate.Combine(_MultiCastDel, (Del_PostAkEvent_AtLocation)Del);
		}
		else
		{
			_MultiCastDel = (Del_PostAkEvent_AtLocation)Delegate.Remove(_MultiCastDel, (Del_PostAkEvent_AtLocation)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_PostAkEvent_AtLocation_ICB operator +(GSDel_PostAkEvent_AtLocation_ICB GSEvent, Del_PostAkEvent_AtLocation Del)
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
		GSEvent._MultiCastDel = (Del_PostAkEvent_AtLocation)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_PostAkEvent_AtLocation_ICB operator -(GSDel_PostAkEvent_AtLocation_ICB GSEvent, Del_PostAkEvent_AtLocation Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_PostAkEvent_AtLocation == Del)
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
		GSEvent._MultiCastDel = (Del_PostAkEvent_AtLocation)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FVector WorldPosistion, FRotator WorldRotator, UAkAudioEvent AkEvent)
	{
		_InvokeCallBack?.Invoke(WorldPosistion, WorldRotator, AkEvent);
	}
}
