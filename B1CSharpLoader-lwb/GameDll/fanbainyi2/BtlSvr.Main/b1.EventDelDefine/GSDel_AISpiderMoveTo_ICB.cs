using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_AISpiderMoveTo_ICB : IFreshAbleGSEvent
{
	private Del_AISpiderMoveTo _InvokeCallBack;

	private Action<Del_AISpiderMoveTo> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_AISpiderMoveTo _MultiCastDel;

	public GSDel_AISpiderMoveTo_ICB(Del_AISpiderMoveTo InvokeCallBack, Action<Del_AISpiderMoveTo> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_AISpiderMoveTo)Delegate.Combine(_MultiCastDel, (Del_AISpiderMoveTo)Del);
		}
		else
		{
			_MultiCastDel = (Del_AISpiderMoveTo)Delegate.Remove(_MultiCastDel, (Del_AISpiderMoveTo)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_AISpiderMoveTo_ICB operator +(GSDel_AISpiderMoveTo_ICB GSEvent, Del_AISpiderMoveTo Del)
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
		GSEvent._MultiCastDel = (Del_AISpiderMoveTo)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_AISpiderMoveTo_ICB operator -(GSDel_AISpiderMoveTo_ICB GSEvent, Del_AISpiderMoveTo Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_AISpiderMoveTo == Del)
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
		GSEvent._MultiCastDel = (Del_AISpiderMoveTo)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FVector TargetPos, FVector TargetNormal, ESpiderNavPositionType TargetPosType, float AcceptableRadius, EAIMoveSpeedType SplineMoveSpeed)
	{
		_InvokeCallBack?.Invoke(TargetPos, TargetNormal, TargetPosType, AcceptableRadius, SplineMoveSpeed);
	}
}
