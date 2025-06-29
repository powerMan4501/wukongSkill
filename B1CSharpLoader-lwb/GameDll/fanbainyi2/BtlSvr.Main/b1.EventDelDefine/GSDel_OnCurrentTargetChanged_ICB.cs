using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_OnCurrentTargetChanged_ICB : IFreshAbleGSEvent
{
	private Del_OnCurrentTargetChanged _InvokeCallBack;

	private Action<Del_OnCurrentTargetChanged> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnCurrentTargetChanged _MultiCastDel;

	public GSDel_OnCurrentTargetChanged_ICB(Del_OnCurrentTargetChanged InvokeCallBack, Action<Del_OnCurrentTargetChanged> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnCurrentTargetChanged)Delegate.Combine(_MultiCastDel, (Del_OnCurrentTargetChanged)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnCurrentTargetChanged)Delegate.Remove(_MultiCastDel, (Del_OnCurrentTargetChanged)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_OnCurrentTargetChanged_ICB operator +(GSDel_OnCurrentTargetChanged_ICB GSEvent, Del_OnCurrentTargetChanged Del)
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
		GSEvent._MultiCastDel = (Del_OnCurrentTargetChanged)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_OnCurrentTargetChanged_ICB operator -(GSDel_OnCurrentTargetChanged_ICB GSEvent, Del_OnCurrentTargetChanged Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnCurrentTargetChanged == Del)
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
		GSEvent._MultiCastDel = (Del_OnCurrentTargetChanged)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor NewTarget, AActor OldTarget)
	{
		_InvokeCallBack?.Invoke(NewTarget, OldTarget);
	}
}
