using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SetGlideMoveAnimState_ICB : IFreshAbleGSEvent
{
	private Del_SetGlideMoveAnimState _InvokeCallBack;

	private Action<Del_SetGlideMoveAnimState> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetGlideMoveAnimState _MultiCastDel;

	public GSDel_SetGlideMoveAnimState_ICB(Del_SetGlideMoveAnimState InvokeCallBack, Action<Del_SetGlideMoveAnimState> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetGlideMoveAnimState)Delegate.Combine(_MultiCastDel, (Del_SetGlideMoveAnimState)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetGlideMoveAnimState)Delegate.Remove(_MultiCastDel, (Del_SetGlideMoveAnimState)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetGlideMoveAnimState_ICB operator +(GSDel_SetGlideMoveAnimState_ICB GSEvent, Del_SetGlideMoveAnimState Del)
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
		GSEvent._MultiCastDel = (Del_SetGlideMoveAnimState)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetGlideMoveAnimState_ICB operator -(GSDel_SetGlideMoveAnimState_ICB GSEvent, Del_SetGlideMoveAnimState Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetGlideMoveAnimState == Del)
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
		GSEvent._MultiCastDel = (Del_SetGlideMoveAnimState)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EGlideMoveAnimState State)
	{
		_InvokeCallBack?.Invoke(State);
	}
}
