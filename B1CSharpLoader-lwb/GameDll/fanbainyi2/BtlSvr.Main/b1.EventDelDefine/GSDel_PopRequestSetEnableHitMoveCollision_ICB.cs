using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_PopRequestSetEnableHitMoveCollision_ICB : IFreshAbleGSEvent
{
	private Del_PopRequestSetEnableHitMoveCollision _InvokeCallBack;

	private Action<Del_PopRequestSetEnableHitMoveCollision> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_PopRequestSetEnableHitMoveCollision _MultiCastDel;

	public GSDel_PopRequestSetEnableHitMoveCollision_ICB(Del_PopRequestSetEnableHitMoveCollision InvokeCallBack, Action<Del_PopRequestSetEnableHitMoveCollision> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_PopRequestSetEnableHitMoveCollision)Delegate.Combine(_MultiCastDel, (Del_PopRequestSetEnableHitMoveCollision)Del);
		}
		else
		{
			_MultiCastDel = (Del_PopRequestSetEnableHitMoveCollision)Delegate.Remove(_MultiCastDel, (Del_PopRequestSetEnableHitMoveCollision)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_PopRequestSetEnableHitMoveCollision_ICB operator +(GSDel_PopRequestSetEnableHitMoveCollision_ICB GSEvent, Del_PopRequestSetEnableHitMoveCollision Del)
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
		GSEvent._MultiCastDel = (Del_PopRequestSetEnableHitMoveCollision)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_PopRequestSetEnableHitMoveCollision_ICB operator -(GSDel_PopRequestSetEnableHitMoveCollision_ICB GSEvent, Del_PopRequestSetEnableHitMoveCollision Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_PopRequestSetEnableHitMoveCollision == Del)
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
		GSEvent._MultiCastDel = (Del_PopRequestSetEnableHitMoveCollision)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(ulong RequestID)
	{
		_InvokeCallBack?.Invoke(RequestID);
	}
}
