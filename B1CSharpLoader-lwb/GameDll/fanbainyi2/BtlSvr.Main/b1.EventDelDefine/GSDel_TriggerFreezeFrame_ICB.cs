using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_TriggerFreezeFrame_ICB : IFreshAbleGSEvent
{
	private Del_TriggerFreezeFrame _InvokeCallBack;

	private Action<Del_TriggerFreezeFrame> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerFreezeFrame _MultiCastDel;

	public GSDel_TriggerFreezeFrame_ICB(Del_TriggerFreezeFrame InvokeCallBack, Action<Del_TriggerFreezeFrame> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TriggerFreezeFrame)Delegate.Combine(_MultiCastDel, (Del_TriggerFreezeFrame)Del);
		}
		else
		{
			_MultiCastDel = (Del_TriggerFreezeFrame)Delegate.Remove(_MultiCastDel, (Del_TriggerFreezeFrame)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_TriggerFreezeFrame_ICB operator +(GSDel_TriggerFreezeFrame_ICB GSEvent, Del_TriggerFreezeFrame Del)
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
		GSEvent._MultiCastDel = (Del_TriggerFreezeFrame)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_TriggerFreezeFrame_ICB operator -(GSDel_TriggerFreezeFrame_ICB GSEvent, Del_TriggerFreezeFrame Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TriggerFreezeFrame == Del)
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
		GSEvent._MultiCastDel = (Del_TriggerFreezeFrame)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(float TotalFreezeTime, float FreezeGap, bool EnableCache = false, bool bPlayedMontage = true)
	{
		_InvokeCallBack?.Invoke(TotalFreezeTime, FreezeGap, EnableCache, bPlayedMontage);
	}
}
