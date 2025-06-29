using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_HandleSlowIK_ICB : IFreshAbleGSEvent
{
	private Del_HandleSlowIK _InvokeCallBack;

	private Action<Del_HandleSlowIK> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_HandleSlowIK _MultiCastDel;

	public GSDel_HandleSlowIK_ICB(Del_HandleSlowIK InvokeCallBack, Action<Del_HandleSlowIK> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_HandleSlowIK)Delegate.Combine(_MultiCastDel, (Del_HandleSlowIK)Del);
		}
		else
		{
			_MultiCastDel = (Del_HandleSlowIK)Delegate.Remove(_MultiCastDel, (Del_HandleSlowIK)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_HandleSlowIK_ICB operator +(GSDel_HandleSlowIK_ICB GSEvent, Del_HandleSlowIK Del)
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
		GSEvent._MultiCastDel = (Del_HandleSlowIK)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_HandleSlowIK_ICB operator -(GSDel_HandleSlowIK_ICB GSEvent, Del_HandleSlowIK Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_HandleSlowIK == Del)
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
		GSEvent._MultiCastDel = (Del_HandleSlowIK)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(bool Enable, ESlowIKType SlowIKType = ESlowIKType.None, float SlowTime = 0f)
	{
		_InvokeCallBack?.Invoke(Enable, SlowIKType, SlowTime);
	}
}
