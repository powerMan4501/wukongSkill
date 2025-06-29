using System;
using System.Collections.Generic;
using b1.ECS;
using b1.Prediction;

namespace b1.EventDelDefine;

public class GSDel_AllocPredictionKey_ICB : IFreshAbleGSEvent
{
	private Del_AllocPredictionKey _InvokeCallBack;

	private Action<Del_AllocPredictionKey> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_AllocPredictionKey _MultiCastDel;

	public GSDel_AllocPredictionKey_ICB(Del_AllocPredictionKey InvokeCallBack, Action<Del_AllocPredictionKey> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_AllocPredictionKey)Delegate.Combine(_MultiCastDel, (Del_AllocPredictionKey)Del);
		}
		else
		{
			_MultiCastDel = (Del_AllocPredictionKey)Delegate.Remove(_MultiCastDel, (Del_AllocPredictionKey)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_AllocPredictionKey_ICB operator +(GSDel_AllocPredictionKey_ICB GSEvent, Del_AllocPredictionKey Del)
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
		GSEvent._MultiCastDel = (Del_AllocPredictionKey)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_AllocPredictionKey_ICB operator -(GSDel_AllocPredictionKey_ICB GSEvent, Del_AllocPredictionKey Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_AllocPredictionKey == Del)
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
		GSEvent._MultiCastDel = (Del_AllocPredictionKey)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public GSPredictionKey Invoke()
	{
		if (_InvokeCallBack == null)
		{
			return null;
		}
		return _InvokeCallBack();
	}
}
