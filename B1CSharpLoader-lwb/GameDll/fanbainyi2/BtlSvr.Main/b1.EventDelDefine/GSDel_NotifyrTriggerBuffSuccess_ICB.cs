using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_NotifyrTriggerBuffSuccess_ICB : IFreshAbleGSEvent
{
	private Del_NotifyrTriggerBuffSuccess _InvokeCallBack;

	private Action<Del_NotifyrTriggerBuffSuccess> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_NotifyrTriggerBuffSuccess _MultiCastDel;

	public GSDel_NotifyrTriggerBuffSuccess_ICB(Del_NotifyrTriggerBuffSuccess InvokeCallBack, Action<Del_NotifyrTriggerBuffSuccess> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_NotifyrTriggerBuffSuccess)Delegate.Combine(_MultiCastDel, (Del_NotifyrTriggerBuffSuccess)Del);
		}
		else
		{
			_MultiCastDel = (Del_NotifyrTriggerBuffSuccess)Delegate.Remove(_MultiCastDel, (Del_NotifyrTriggerBuffSuccess)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_NotifyrTriggerBuffSuccess_ICB operator +(GSDel_NotifyrTriggerBuffSuccess_ICB GSEvent, Del_NotifyrTriggerBuffSuccess Del)
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
		GSEvent._MultiCastDel = (Del_NotifyrTriggerBuffSuccess)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_NotifyrTriggerBuffSuccess_ICB operator -(GSDel_NotifyrTriggerBuffSuccess_ICB GSEvent, Del_NotifyrTriggerBuffSuccess Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_NotifyrTriggerBuffSuccess == Del)
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
		GSEvent._MultiCastDel = (Del_NotifyrTriggerBuffSuccess)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(ref FEffectInstReq EffectInstReq)
	{
		_InvokeCallBack?.Invoke(ref EffectInstReq);
	}
}
