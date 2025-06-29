using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_GroupAIRequestTask_ICB : IFreshAbleGSEvent
{
	private Del_GroupAIRequestTask _InvokeCallBack;

	private Action<Del_GroupAIRequestTask> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_GroupAIRequestTask _MultiCastDel;

	public GSDel_GroupAIRequestTask_ICB(Del_GroupAIRequestTask InvokeCallBack, Action<Del_GroupAIRequestTask> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_GroupAIRequestTask)Delegate.Combine(_MultiCastDel, (Del_GroupAIRequestTask)Del);
		}
		else
		{
			_MultiCastDel = (Del_GroupAIRequestTask)Delegate.Remove(_MultiCastDel, (Del_GroupAIRequestTask)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_GroupAIRequestTask_ICB operator +(GSDel_GroupAIRequestTask_ICB GSEvent, Del_GroupAIRequestTask Del)
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
		GSEvent._MultiCastDel = (Del_GroupAIRequestTask)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_GroupAIRequestTask_ICB operator -(GSDel_GroupAIRequestTask_ICB GSEvent, Del_GroupAIRequestTask Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_GroupAIRequestTask == Del)
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
		GSEvent._MultiCastDel = (Del_GroupAIRequestTask)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int ReqID, float Score, EGroupCMDType GroupCMDType, IGroupAIActionInfo GroupAIActionInfo, float WaitForBeginTime, float BeginNoiseTime)
	{
		_InvokeCallBack?.Invoke(ReqID, Score, GroupCMDType, GroupAIActionInfo, WaitForBeginTime, BeginNoiseTime);
	}
}
