using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_EQSFinishBroadcast_ICB : IFreshAbleGSEvent
{
	private Del_EQSFinishBroadcast _InvokeCallBack;

	private Action<Del_EQSFinishBroadcast> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_EQSFinishBroadcast _MultiCastDel;

	public GSDel_EQSFinishBroadcast_ICB(Del_EQSFinishBroadcast InvokeCallBack, Action<Del_EQSFinishBroadcast> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_EQSFinishBroadcast)Delegate.Combine(_MultiCastDel, (Del_EQSFinishBroadcast)Del);
		}
		else
		{
			_MultiCastDel = (Del_EQSFinishBroadcast)Delegate.Remove(_MultiCastDel, (Del_EQSFinishBroadcast)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_EQSFinishBroadcast_ICB operator +(GSDel_EQSFinishBroadcast_ICB GSEvent, Del_EQSFinishBroadcast Del)
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
		GSEvent._MultiCastDel = (Del_EQSFinishBroadcast)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_EQSFinishBroadcast_ICB operator -(GSDel_EQSFinishBroadcast_ICB GSEvent, Del_EQSFinishBroadcast Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_EQSFinishBroadcast == Del)
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
		GSEvent._MultiCastDel = (Del_EQSFinishBroadcast)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(List<FVector> Result, List<float> Scores, FGSEQSExParam ExParam, int QueryID)
	{
		_InvokeCallBack?.Invoke(Result, Scores, ExParam, QueryID);
	}
}
