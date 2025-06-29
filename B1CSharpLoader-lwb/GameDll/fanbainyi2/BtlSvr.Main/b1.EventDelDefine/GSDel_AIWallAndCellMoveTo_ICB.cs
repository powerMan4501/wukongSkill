using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_AIWallAndCellMoveTo_ICB : IFreshAbleGSEvent
{
	private Del_AIWallAndCellMoveTo _InvokeCallBack;

	private Action<Del_AIWallAndCellMoveTo> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_AIWallAndCellMoveTo _MultiCastDel;

	public GSDel_AIWallAndCellMoveTo_ICB(Del_AIWallAndCellMoveTo InvokeCallBack, Action<Del_AIWallAndCellMoveTo> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_AIWallAndCellMoveTo)Delegate.Combine(_MultiCastDel, (Del_AIWallAndCellMoveTo)Del);
		}
		else
		{
			_MultiCastDel = (Del_AIWallAndCellMoveTo)Delegate.Remove(_MultiCastDel, (Del_AIWallAndCellMoveTo)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_AIWallAndCellMoveTo_ICB operator +(GSDel_AIWallAndCellMoveTo_ICB GSEvent, Del_AIWallAndCellMoveTo Del)
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
		GSEvent._MultiCastDel = (Del_AIWallAndCellMoveTo)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_AIWallAndCellMoveTo_ICB operator -(GSDel_AIWallAndCellMoveTo_ICB GSEvent, Del_AIWallAndCellMoveTo Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_AIWallAndCellMoveTo == Del)
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
		GSEvent._MultiCastDel = (Del_AIWallAndCellMoveTo)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FVector TargetLocation, EAIMoveSpeedType SpeedRateType, float TurnSpeed, float AcceptableRadius, bool IncludeSelfRadius)
	{
		_InvokeCallBack?.Invoke(TargetLocation, SpeedRateType, TurnSpeed, AcceptableRadius, IncludeSelfRadius);
	}
}
