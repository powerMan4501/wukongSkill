using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_ChangeMotionMatchingState_ICB : IFreshAbleGSEvent
{
	private Del_ChangeMotionMatchingState _InvokeCallBack;

	private Action<Del_ChangeMotionMatchingState> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ChangeMotionMatchingState _MultiCastDel;

	public GSDel_ChangeMotionMatchingState_ICB(Del_ChangeMotionMatchingState InvokeCallBack, Action<Del_ChangeMotionMatchingState> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ChangeMotionMatchingState)Delegate.Combine(_MultiCastDel, (Del_ChangeMotionMatchingState)Del);
		}
		else
		{
			_MultiCastDel = (Del_ChangeMotionMatchingState)Delegate.Remove(_MultiCastDel, (Del_ChangeMotionMatchingState)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_ChangeMotionMatchingState_ICB operator +(GSDel_ChangeMotionMatchingState_ICB GSEvent, Del_ChangeMotionMatchingState Del)
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
		GSEvent._MultiCastDel = (Del_ChangeMotionMatchingState)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_ChangeMotionMatchingState_ICB operator -(GSDel_ChangeMotionMatchingState_ICB GSEvent, Del_ChangeMotionMatchingState Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ChangeMotionMatchingState == Del)
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
		GSEvent._MultiCastDel = (Del_ChangeMotionMatchingState)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EState_MM MMState)
	{
		_InvokeCallBack?.Invoke(MMState);
	}
}
