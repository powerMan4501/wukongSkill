using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_TriggerNPCShowStateChange_ICB : IFreshAbleGSEvent
{
	private Del_TriggerNPCShowStateChange _InvokeCallBack;

	private Action<Del_TriggerNPCShowStateChange> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerNPCShowStateChange _MultiCastDel;

	public GSDel_TriggerNPCShowStateChange_ICB(Del_TriggerNPCShowStateChange InvokeCallBack, Action<Del_TriggerNPCShowStateChange> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TriggerNPCShowStateChange)Delegate.Combine(_MultiCastDel, (Del_TriggerNPCShowStateChange)Del);
		}
		else
		{
			_MultiCastDel = (Del_TriggerNPCShowStateChange)Delegate.Remove(_MultiCastDel, (Del_TriggerNPCShowStateChange)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_TriggerNPCShowStateChange_ICB operator +(GSDel_TriggerNPCShowStateChange_ICB GSEvent, Del_TriggerNPCShowStateChange Del)
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
		GSEvent._MultiCastDel = (Del_TriggerNPCShowStateChange)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_TriggerNPCShowStateChange_ICB operator -(GSDel_TriggerNPCShowStateChange_ICB GSEvent, Del_TriggerNPCShowStateChange Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TriggerNPCShowStateChange == Del)
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
		GSEvent._MultiCastDel = (Del_TriggerNPCShowStateChange)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(bool IsShow)
	{
		_InvokeCallBack?.Invoke(IsShow);
	}
}
