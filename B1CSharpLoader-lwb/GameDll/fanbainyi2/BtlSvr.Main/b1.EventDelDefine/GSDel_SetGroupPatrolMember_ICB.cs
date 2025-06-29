using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_SetGroupPatrolMember_ICB : IFreshAbleGSEvent
{
	private Del_SetGroupPatrolMember _InvokeCallBack;

	private Action<Del_SetGroupPatrolMember> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetGroupPatrolMember _MultiCastDel;

	public GSDel_SetGroupPatrolMember_ICB(Del_SetGroupPatrolMember InvokeCallBack, Action<Del_SetGroupPatrolMember> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetGroupPatrolMember)Delegate.Combine(_MultiCastDel, (Del_SetGroupPatrolMember)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetGroupPatrolMember)Delegate.Remove(_MultiCastDel, (Del_SetGroupPatrolMember)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetGroupPatrolMember_ICB operator +(GSDel_SetGroupPatrolMember_ICB GSEvent, Del_SetGroupPatrolMember Del)
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
		GSEvent._MultiCastDel = (Del_SetGroupPatrolMember)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetGroupPatrolMember_ICB operator -(GSDel_SetGroupPatrolMember_ICB GSEvent, Del_SetGroupPatrolMember Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetGroupPatrolMember == Del)
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
		GSEvent._MultiCastDel = (Del_SetGroupPatrolMember)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(string GroupLeaderGuid, FVector GroupRelativeLocation, int TargetSplinePoint)
	{
		_InvokeCallBack?.Invoke(GroupLeaderGuid, GroupRelativeLocation, TargetSplinePoint);
	}
}
