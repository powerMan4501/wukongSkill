using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_MovementRotateToTarget_ICB : IFreshAbleGSEvent
{
	private Del_MovementRotateToTarget _InvokeCallBack;

	private Action<Del_MovementRotateToTarget> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_MovementRotateToTarget _MultiCastDel;

	public GSDel_MovementRotateToTarget_ICB(Del_MovementRotateToTarget InvokeCallBack, Action<Del_MovementRotateToTarget> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_MovementRotateToTarget)Delegate.Combine(_MultiCastDel, (Del_MovementRotateToTarget)Del);
		}
		else
		{
			_MultiCastDel = (Del_MovementRotateToTarget)Delegate.Remove(_MultiCastDel, (Del_MovementRotateToTarget)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_MovementRotateToTarget_ICB operator +(GSDel_MovementRotateToTarget_ICB GSEvent, Del_MovementRotateToTarget Del)
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
		GSEvent._MultiCastDel = (Del_MovementRotateToTarget)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_MovementRotateToTarget_ICB operator -(GSDel_MovementRotateToTarget_ICB GSEvent, Del_MovementRotateToTarget Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_MovementRotateToTarget == Del)
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
		GSEvent._MultiCastDel = (Del_MovementRotateToTarget)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor TargetActor, float TurnSpeed)
	{
		_InvokeCallBack?.Invoke(TargetActor, TurnSpeed);
	}
}
