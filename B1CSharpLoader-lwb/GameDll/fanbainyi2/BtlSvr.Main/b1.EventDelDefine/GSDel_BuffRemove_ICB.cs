using System;
using System.Collections.Generic;
using b1.ECS;
using BtlShare;

namespace b1.EventDelDefine;

public class GSDel_BuffRemove_ICB : IFreshAbleGSEvent
{
	private Del_BuffRemove _InvokeCallBack;

	private Action<Del_BuffRemove> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_BuffRemove _MultiCastDel;

	public GSDel_BuffRemove_ICB(Del_BuffRemove InvokeCallBack, Action<Del_BuffRemove> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_BuffRemove)Delegate.Combine(_MultiCastDel, (Del_BuffRemove)Del);
		}
		else
		{
			_MultiCastDel = (Del_BuffRemove)Delegate.Remove(_MultiCastDel, (Del_BuffRemove)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_BuffRemove_ICB operator +(GSDel_BuffRemove_ICB GSEvent, Del_BuffRemove Del)
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
		GSEvent._MultiCastDel = (Del_BuffRemove)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_BuffRemove_ICB operator -(GSDel_BuffRemove_ICB GSEvent, Del_BuffRemove Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_BuffRemove == Del)
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
		GSEvent._MultiCastDel = (Del_BuffRemove)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int BuffID, EBuffEffectTriggerType RemoveTriggerType, int Layer, bool WithTriggerRemmoveEffect = true)
	{
		_InvokeCallBack?.Invoke(BuffID, RemoveTriggerType, Layer, WithTriggerRemmoveEffect);
	}
}
