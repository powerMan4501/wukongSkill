using System;
using System.Collections.Generic;
using b1.ECS;
using ResB1;

namespace b1.EventDelDefine;

public class GSDel_TriggerItemEffectReal_ICB : IFreshAbleGSEvent
{
	private Del_TriggerItemEffectReal _InvokeCallBack;

	private Action<Del_TriggerItemEffectReal> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerItemEffectReal _MultiCastDel;

	public GSDel_TriggerItemEffectReal_ICB(Del_TriggerItemEffectReal InvokeCallBack, Action<Del_TriggerItemEffectReal> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TriggerItemEffectReal)Delegate.Combine(_MultiCastDel, (Del_TriggerItemEffectReal)Del);
		}
		else
		{
			_MultiCastDel = (Del_TriggerItemEffectReal)Delegate.Remove(_MultiCastDel, (Del_TriggerItemEffectReal)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_TriggerItemEffectReal_ICB operator +(GSDel_TriggerItemEffectReal_ICB GSEvent, Del_TriggerItemEffectReal Del)
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
		GSEvent._MultiCastDel = (Del_TriggerItemEffectReal)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_TriggerItemEffectReal_ICB operator -(GSDel_TriggerItemEffectReal_ICB GSEvent, Del_TriggerItemEffectReal Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TriggerItemEffectReal == Del)
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
		GSEvent._MultiCastDel = (Del_TriggerItemEffectReal)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int ItemId, OPReason Reason)
	{
		_InvokeCallBack?.Invoke(ItemId, Reason);
	}
}
