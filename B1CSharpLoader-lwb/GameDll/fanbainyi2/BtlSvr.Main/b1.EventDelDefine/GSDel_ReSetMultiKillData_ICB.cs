using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_ReSetMultiKillData_ICB : IFreshAbleGSEvent
{
	private Del_ReSetMultiKillData _InvokeCallBack;

	private Action<Del_ReSetMultiKillData> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ReSetMultiKillData _MultiCastDel;

	public GSDel_ReSetMultiKillData_ICB(Del_ReSetMultiKillData InvokeCallBack, Action<Del_ReSetMultiKillData> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ReSetMultiKillData)Delegate.Combine(_MultiCastDel, (Del_ReSetMultiKillData)Del);
		}
		else
		{
			_MultiCastDel = (Del_ReSetMultiKillData)Delegate.Remove(_MultiCastDel, (Del_ReSetMultiKillData)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_ReSetMultiKillData_ICB operator +(GSDel_ReSetMultiKillData_ICB GSEvent, Del_ReSetMultiKillData Del)
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
		GSEvent._MultiCastDel = (Del_ReSetMultiKillData)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_ReSetMultiKillData_ICB operator -(GSDel_ReSetMultiKillData_ICB GSEvent, Del_ReSetMultiKillData Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ReSetMultiKillData == Del)
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
		GSEvent._MultiCastDel = (Del_ReSetMultiKillData)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(BUC_MultiKillData MultiKillData)
	{
		_InvokeCallBack?.Invoke(MultiKillData);
	}
}
