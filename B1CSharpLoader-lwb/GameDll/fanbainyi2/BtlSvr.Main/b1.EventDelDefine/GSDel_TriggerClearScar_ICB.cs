using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;

namespace b1.EventDelDefine;

public class GSDel_TriggerClearScar_ICB : IFreshAbleGSEvent
{
	private Del_TriggerClearScar _InvokeCallBack;

	private Action<Del_TriggerClearScar> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerClearScar _MultiCastDel;

	public GSDel_TriggerClearScar_ICB(Del_TriggerClearScar InvokeCallBack, Action<Del_TriggerClearScar> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TriggerClearScar)Delegate.Combine(_MultiCastDel, (Del_TriggerClearScar)Del);
		}
		else
		{
			_MultiCastDel = (Del_TriggerClearScar)Delegate.Remove(_MultiCastDel, (Del_TriggerClearScar)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_TriggerClearScar_ICB operator +(GSDel_TriggerClearScar_ICB GSEvent, Del_TriggerClearScar Del)
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
		GSEvent._MultiCastDel = (Del_TriggerClearScar)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_TriggerClearScar_ICB operator -(GSDel_TriggerClearScar_ICB GSEvent, Del_TriggerClearScar Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TriggerClearScar == Del)
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
		GSEvent._MultiCastDel = (Del_TriggerClearScar)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EScarDecalTriggerType ScarDecalTriggerType)
	{
		_InvokeCallBack?.Invoke(ScarDecalTriggerType);
	}
}
