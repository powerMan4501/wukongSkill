using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.AIModule;

namespace b1.EventDelDefine;

public class GSDel_AIPathMoveComplete : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_AIPathMoveComplete _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_AIPathMoveComplete)Delegate.Combine(_MultiCastDel, (Del_AIPathMoveComplete)Del);
		}
		else
		{
			_MultiCastDel = (Del_AIPathMoveComplete)Delegate.Remove(_MultiCastDel, (Del_AIPathMoveComplete)Del);
		}
	}

	public static GSDel_AIPathMoveComplete operator +(GSDel_AIPathMoveComplete GSEvent, Del_AIPathMoveComplete Del)
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
		GSEvent._MultiCastDel = (Del_AIPathMoveComplete)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_AIPathMoveComplete operator -(GSDel_AIPathMoveComplete GSEvent, Del_AIPathMoveComplete Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_AIPathMoveComplete == Del)
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
		GSEvent._MultiCastDel = (Del_AIPathMoveComplete)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(int MoveIdx, EPathFollowingResult Result)
	{
		_MultiCastDel?.Invoke(MoveIdx, Result);
	}
}
