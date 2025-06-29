using System;
using System.Collections.Generic;
using b1.ECS;
using BtlShare;

namespace b1.EventDelDefine;

public class GSDel_TriggerGuideNodeFinishEvent_ICB : IFreshAbleGSEvent
{
	private Del_TriggerGuideNodeFinishEvent _InvokeCallBack;

	private Action<Del_TriggerGuideNodeFinishEvent> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerGuideNodeFinishEvent _MultiCastDel;

	public GSDel_TriggerGuideNodeFinishEvent_ICB(Del_TriggerGuideNodeFinishEvent InvokeCallBack, Action<Del_TriggerGuideNodeFinishEvent> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TriggerGuideNodeFinishEvent)Delegate.Combine(_MultiCastDel, (Del_TriggerGuideNodeFinishEvent)Del);
		}
		else
		{
			_MultiCastDel = (Del_TriggerGuideNodeFinishEvent)Delegate.Remove(_MultiCastDel, (Del_TriggerGuideNodeFinishEvent)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_TriggerGuideNodeFinishEvent_ICB operator +(GSDel_TriggerGuideNodeFinishEvent_ICB GSEvent, Del_TriggerGuideNodeFinishEvent Del)
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
		GSEvent._MultiCastDel = (Del_TriggerGuideNodeFinishEvent)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_TriggerGuideNodeFinishEvent_ICB operator -(GSDel_TriggerGuideNodeFinishEvent_ICB GSEvent, Del_TriggerGuideNodeFinishEvent Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TriggerGuideNodeFinishEvent == Del)
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
		GSEvent._MultiCastDel = (Del_TriggerGuideNodeFinishEvent)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EGuideNodeFinishType FinishType)
	{
		_InvokeCallBack?.Invoke(FinishType);
	}
}
