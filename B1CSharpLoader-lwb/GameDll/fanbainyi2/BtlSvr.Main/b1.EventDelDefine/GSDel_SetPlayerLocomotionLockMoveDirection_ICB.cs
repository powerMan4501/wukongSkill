using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SetPlayerLocomotionLockMoveDirection_ICB : IFreshAbleGSEvent
{
	private Del_SetPlayerLocomotionLockMoveDirection _InvokeCallBack;

	private Action<Del_SetPlayerLocomotionLockMoveDirection> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetPlayerLocomotionLockMoveDirection _MultiCastDel;

	public GSDel_SetPlayerLocomotionLockMoveDirection_ICB(Del_SetPlayerLocomotionLockMoveDirection InvokeCallBack, Action<Del_SetPlayerLocomotionLockMoveDirection> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetPlayerLocomotionLockMoveDirection)Delegate.Combine(_MultiCastDel, (Del_SetPlayerLocomotionLockMoveDirection)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetPlayerLocomotionLockMoveDirection)Delegate.Remove(_MultiCastDel, (Del_SetPlayerLocomotionLockMoveDirection)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetPlayerLocomotionLockMoveDirection_ICB operator +(GSDel_SetPlayerLocomotionLockMoveDirection_ICB GSEvent, Del_SetPlayerLocomotionLockMoveDirection Del)
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
		GSEvent._MultiCastDel = (Del_SetPlayerLocomotionLockMoveDirection)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetPlayerLocomotionLockMoveDirection_ICB operator -(GSDel_SetPlayerLocomotionLockMoveDirection_ICB GSEvent, Del_SetPlayerLocomotionLockMoveDirection Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetPlayerLocomotionLockMoveDirection == Del)
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
		GSEvent._MultiCastDel = (Del_SetPlayerLocomotionLockMoveDirection)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(ELockMoveDirectionSix Direction)
	{
		_InvokeCallBack?.Invoke(Direction);
	}
}
