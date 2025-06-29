using System;
using System.Collections.Generic;
using b1.ECS;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_StreamingLevelStateChanged_ICB : IFreshAbleGSEvent
{
	private Del_StreamingLevelStateChanged _InvokeCallBack;

	private Action<Del_StreamingLevelStateChanged> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_StreamingLevelStateChanged _MultiCastDel;

	public GSDel_StreamingLevelStateChanged_ICB(Del_StreamingLevelStateChanged InvokeCallBack, Action<Del_StreamingLevelStateChanged> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_StreamingLevelStateChanged)Delegate.Combine(_MultiCastDel, (Del_StreamingLevelStateChanged)Del);
		}
		else
		{
			_MultiCastDel = (Del_StreamingLevelStateChanged)Delegate.Remove(_MultiCastDel, (Del_StreamingLevelStateChanged)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_StreamingLevelStateChanged_ICB operator +(GSDel_StreamingLevelStateChanged_ICB GSEvent, Del_StreamingLevelStateChanged Del)
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
		GSEvent._MultiCastDel = (Del_StreamingLevelStateChanged)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_StreamingLevelStateChanged_ICB operator -(GSDel_StreamingLevelStateChanged_ICB GSEvent, Del_StreamingLevelStateChanged Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_StreamingLevelStateChanged == Del)
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
		GSEvent._MultiCastDel = (Del_StreamingLevelStateChanged)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FName P1, FName P2, EGsStreamingLevelState? P3, EGsStreamingLevelState P4)
	{
		_InvokeCallBack?.Invoke(P1, P2, P3, P4);
	}
}
