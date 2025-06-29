using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_QueryConditionWithId_ICB : IFreshAbleGSEvent
{
	private Del_QueryConditionWithId _InvokeCallBack;

	private Action<Del_QueryConditionWithId> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_QueryConditionWithId _MultiCastDel;

	public GSDel_QueryConditionWithId_ICB(Del_QueryConditionWithId InvokeCallBack, Action<Del_QueryConditionWithId> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_QueryConditionWithId)Delegate.Combine(_MultiCastDel, (Del_QueryConditionWithId)Del);
		}
		else
		{
			_MultiCastDel = (Del_QueryConditionWithId)Delegate.Remove(_MultiCastDel, (Del_QueryConditionWithId)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_QueryConditionWithId_ICB operator +(GSDel_QueryConditionWithId_ICB GSEvent, Del_QueryConditionWithId Del)
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
		GSEvent._MultiCastDel = (Del_QueryConditionWithId)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_QueryConditionWithId_ICB operator -(GSDel_QueryConditionWithId_ICB GSEvent, Del_QueryConditionWithId Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_QueryConditionWithId == Del)
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
		GSEvent._MultiCastDel = (Del_QueryConditionWithId)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EFindSceneItemWay FindWay, QueryBestLocationCondition Condition, int DataId)
	{
		_InvokeCallBack?.Invoke(FindWay, Condition, DataId);
	}
}
