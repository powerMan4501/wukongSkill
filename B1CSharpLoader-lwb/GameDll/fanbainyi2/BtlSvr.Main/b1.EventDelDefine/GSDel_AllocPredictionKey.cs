using System;
using System.Collections.Generic;
using b1.ECS;
using b1.Prediction;

namespace b1.EventDelDefine;

public class GSDel_AllocPredictionKey : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_AllocPredictionKey _MultiCastDel;

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
	}

	public static GSDel_AllocPredictionKey operator +(GSDel_AllocPredictionKey GSEvent, Del_AllocPredictionKey Del)
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
		return GSEvent;
	}

	public static GSDel_AllocPredictionKey operator -(GSDel_AllocPredictionKey GSEvent, Del_AllocPredictionKey Del)
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
		return GSEvent;
	}

	public GSPredictionKey Invoke()
	{
		if (_MultiCastDel == null)
		{
			return null;
		}
		return _MultiCastDel();
	}
}
