using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_RequestAsyncLineTrace_ByChannelSingle_ICB : IFreshAbleGSEvent
{
	private Del_RequestAsyncLineTrace_ByChannelSingle _InvokeCallBack;

	private Action<Del_RequestAsyncLineTrace_ByChannelSingle> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_RequestAsyncLineTrace_ByChannelSingle _MultiCastDel;

	public GSDel_RequestAsyncLineTrace_ByChannelSingle_ICB(Del_RequestAsyncLineTrace_ByChannelSingle InvokeCallBack, Action<Del_RequestAsyncLineTrace_ByChannelSingle> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_RequestAsyncLineTrace_ByChannelSingle)Delegate.Combine(_MultiCastDel, (Del_RequestAsyncLineTrace_ByChannelSingle)Del);
		}
		else
		{
			_MultiCastDel = (Del_RequestAsyncLineTrace_ByChannelSingle)Delegate.Remove(_MultiCastDel, (Del_RequestAsyncLineTrace_ByChannelSingle)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_RequestAsyncLineTrace_ByChannelSingle_ICB operator +(GSDel_RequestAsyncLineTrace_ByChannelSingle_ICB GSEvent, Del_RequestAsyncLineTrace_ByChannelSingle Del)
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
		GSEvent._MultiCastDel = (Del_RequestAsyncLineTrace_ByChannelSingle)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_RequestAsyncLineTrace_ByChannelSingle_ICB operator -(GSDel_RequestAsyncLineTrace_ByChannelSingle_ICB GSEvent, Del_RequestAsyncLineTrace_ByChannelSingle Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_RequestAsyncLineTrace_ByChannelSingle == Del)
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
		GSEvent._MultiCastDel = (Del_RequestAsyncLineTrace_ByChannelSingle)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int ReqID, FVector Start, FVector End, ECollisionChannel CollisionChannel, List<AActor> Ingnores, bool bTraceComplex, Del_OnAsyncLineTraceFinish _OnLineTraceFinishCallBack, bool bDebug = false)
	{
		_InvokeCallBack?.Invoke(ReqID, Start, End, CollisionChannel, Ingnores, bTraceComplex, _OnLineTraceFinishCallBack, bDebug);
	}
}
