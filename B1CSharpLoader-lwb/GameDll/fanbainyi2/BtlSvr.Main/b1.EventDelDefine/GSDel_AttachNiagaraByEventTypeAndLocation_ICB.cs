using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_AttachNiagaraByEventTypeAndLocation_ICB : IFreshAbleGSEvent
{
	private Del_AttachNiagaraByEventTypeAndLocation _InvokeCallBack;

	private Action<Del_AttachNiagaraByEventTypeAndLocation> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_AttachNiagaraByEventTypeAndLocation _MultiCastDel;

	public GSDel_AttachNiagaraByEventTypeAndLocation_ICB(Del_AttachNiagaraByEventTypeAndLocation InvokeCallBack, Action<Del_AttachNiagaraByEventTypeAndLocation> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_AttachNiagaraByEventTypeAndLocation)Delegate.Combine(_MultiCastDel, (Del_AttachNiagaraByEventTypeAndLocation)Del);
		}
		else
		{
			_MultiCastDel = (Del_AttachNiagaraByEventTypeAndLocation)Delegate.Remove(_MultiCastDel, (Del_AttachNiagaraByEventTypeAndLocation)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_AttachNiagaraByEventTypeAndLocation_ICB operator +(GSDel_AttachNiagaraByEventTypeAndLocation_ICB GSEvent, Del_AttachNiagaraByEventTypeAndLocation Del)
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
		GSEvent._MultiCastDel = (Del_AttachNiagaraByEventTypeAndLocation)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_AttachNiagaraByEventTypeAndLocation_ICB operator -(GSDel_AttachNiagaraByEventTypeAndLocation_ICB GSEvent, Del_AttachNiagaraByEventTypeAndLocation Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_AttachNiagaraByEventTypeAndLocation == Del)
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
		GSEvent._MultiCastDel = (Del_AttachNiagaraByEventTypeAndLocation)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EAttachNiagaraEventType EventType, FVector HitLocation, FName BoneName, FVector RelativeLocation, float DurTime)
	{
		_InvokeCallBack?.Invoke(EventType, HitLocation, BoneName, RelativeLocation, DurTime);
	}
}
