using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_AttachToTargetWhenTraceOver_ICB : IFreshAbleGSEvent
{
	private Del_AttachToTargetWhenTraceOver _InvokeCallBack;

	private Action<Del_AttachToTargetWhenTraceOver> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_AttachToTargetWhenTraceOver _MultiCastDel;

	public GSDel_AttachToTargetWhenTraceOver_ICB(Del_AttachToTargetWhenTraceOver InvokeCallBack, Action<Del_AttachToTargetWhenTraceOver> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_AttachToTargetWhenTraceOver)Delegate.Combine(_MultiCastDel, (Del_AttachToTargetWhenTraceOver)Del);
		}
		else
		{
			_MultiCastDel = (Del_AttachToTargetWhenTraceOver)Delegate.Remove(_MultiCastDel, (Del_AttachToTargetWhenTraceOver)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_AttachToTargetWhenTraceOver_ICB operator +(GSDel_AttachToTargetWhenTraceOver_ICB GSEvent, Del_AttachToTargetWhenTraceOver Del)
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
		GSEvent._MultiCastDel = (Del_AttachToTargetWhenTraceOver)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_AttachToTargetWhenTraceOver_ICB operator -(GSDel_AttachToTargetWhenTraceOver_ICB GSEvent, Del_AttachToTargetWhenTraceOver Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_AttachToTargetWhenTraceOver == Del)
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
		GSEvent._MultiCastDel = (Del_AttachToTargetWhenTraceOver)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public bool Invoke()
	{
		if (_InvokeCallBack == null)
		{
			return false;
		}
		return _InvokeCallBack();
	}
}
