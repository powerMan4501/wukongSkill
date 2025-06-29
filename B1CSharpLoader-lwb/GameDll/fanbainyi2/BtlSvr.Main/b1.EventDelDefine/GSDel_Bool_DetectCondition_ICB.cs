using System;
using System.Collections.Generic;
using b1.ECS;
using GurCalliopeState;

namespace b1.EventDelDefine;

public class GSDel_Bool_DetectCondition_ICB : IFreshAbleGSEvent
{
	private Del_Bool_DetectCondition _InvokeCallBack;

	private Action<Del_Bool_DetectCondition> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_Bool_DetectCondition _MultiCastDel;

	public GSDel_Bool_DetectCondition_ICB(Del_Bool_DetectCondition InvokeCallBack, Action<Del_Bool_DetectCondition> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_Bool_DetectCondition)Delegate.Combine(_MultiCastDel, (Del_Bool_DetectCondition)Del);
		}
		else
		{
			_MultiCastDel = (Del_Bool_DetectCondition)Delegate.Remove(_MultiCastDel, (Del_Bool_DetectCondition)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_Bool_DetectCondition_ICB operator +(GSDel_Bool_DetectCondition_ICB GSEvent, Del_Bool_DetectCondition Del)
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
		GSEvent._MultiCastDel = (Del_Bool_DetectCondition)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_Bool_DetectCondition_ICB operator -(GSDel_Bool_DetectCondition_ICB GSEvent, Del_Bool_DetectCondition Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_Bool_DetectCondition == Del)
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
		GSEvent._MultiCastDel = (Del_Bool_DetectCondition)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public bool Invoke(CalliopeCustom_DetectCondition DetectCondition)
	{
		if (_InvokeCallBack == null)
		{
			return false;
		}
		return _InvokeCallBack(DetectCondition);
	}
}
