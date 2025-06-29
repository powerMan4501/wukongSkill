using System;
using System.Collections.Generic;
using b1.ECS;
using b1.Prediction;

namespace b1.EventDelDefine;

public class GSDel_GetPredictionKeyById_ICB : IFreshAbleGSEvent
{
	private Del_GetPredictionKeyById _InvokeCallBack;

	private Action<Del_GetPredictionKeyById> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_GetPredictionKeyById _MultiCastDel;

	public GSDel_GetPredictionKeyById_ICB(Del_GetPredictionKeyById InvokeCallBack, Action<Del_GetPredictionKeyById> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_GetPredictionKeyById)Delegate.Combine(_MultiCastDel, (Del_GetPredictionKeyById)Del);
		}
		else
		{
			_MultiCastDel = (Del_GetPredictionKeyById)Delegate.Remove(_MultiCastDel, (Del_GetPredictionKeyById)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_GetPredictionKeyById_ICB operator +(GSDel_GetPredictionKeyById_ICB GSEvent, Del_GetPredictionKeyById Del)
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
		GSEvent._MultiCastDel = (Del_GetPredictionKeyById)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_GetPredictionKeyById_ICB operator -(GSDel_GetPredictionKeyById_ICB GSEvent, Del_GetPredictionKeyById Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_GetPredictionKeyById == Del)
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
		GSEvent._MultiCastDel = (Del_GetPredictionKeyById)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public GSPredictionKey Invoke(int Id)
	{
		if (_InvokeCallBack == null)
		{
			return null;
		}
		return _InvokeCallBack(Id);
	}
}
