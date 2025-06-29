using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_OSSRebirthPoint_ICB : IFreshAbleGSEvent
{
	private Del_OSSRebirthPoint _InvokeCallBack;

	private Action<Del_OSSRebirthPoint> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OSSRebirthPoint _MultiCastDel;

	public GSDel_OSSRebirthPoint_ICB(Del_OSSRebirthPoint InvokeCallBack, Action<Del_OSSRebirthPoint> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OSSRebirthPoint)Delegate.Combine(_MultiCastDel, (Del_OSSRebirthPoint)Del);
		}
		else
		{
			_MultiCastDel = (Del_OSSRebirthPoint)Delegate.Remove(_MultiCastDel, (Del_OSSRebirthPoint)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_OSSRebirthPoint_ICB operator +(GSDel_OSSRebirthPoint_ICB GSEvent, Del_OSSRebirthPoint Del)
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
		GSEvent._MultiCastDel = (Del_OSSRebirthPoint)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_OSSRebirthPoint_ICB operator -(GSDel_OSSRebirthPoint_ICB GSEvent, Del_OSSRebirthPoint Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OSSRebirthPoint == Del)
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
		GSEvent._MultiCastDel = (Del_OSSRebirthPoint)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int RebirthPointConfigID, bool bActiveState)
	{
		_InvokeCallBack?.Invoke(RebirthPointConfigID, bActiveState);
	}
}
