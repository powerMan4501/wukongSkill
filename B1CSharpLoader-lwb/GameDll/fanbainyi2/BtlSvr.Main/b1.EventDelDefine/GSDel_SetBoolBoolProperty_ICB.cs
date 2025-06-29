using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SetBoolBoolProperty_ICB : IFreshAbleGSEvent
{
	private Del_SetBoolBoolProperty _InvokeCallBack;

	private Action<Del_SetBoolBoolProperty> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetBoolBoolProperty _MultiCastDel;

	public GSDel_SetBoolBoolProperty_ICB(Del_SetBoolBoolProperty InvokeCallBack, Action<Del_SetBoolBoolProperty> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetBoolBoolProperty)Delegate.Combine(_MultiCastDel, (Del_SetBoolBoolProperty)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetBoolBoolProperty)Delegate.Remove(_MultiCastDel, (Del_SetBoolBoolProperty)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetBoolBoolProperty_ICB operator +(GSDel_SetBoolBoolProperty_ICB GSEvent, Del_SetBoolBoolProperty Del)
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
		GSEvent._MultiCastDel = (Del_SetBoolBoolProperty)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetBoolBoolProperty_ICB operator -(GSDel_SetBoolBoolProperty_ICB GSEvent, Del_SetBoolBoolProperty Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetBoolBoolProperty == Del)
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
		GSEvent._MultiCastDel = (Del_SetBoolBoolProperty)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EPropType PropType, bool Value1, bool Value2, uint HandleID = 0u, uint NotifyUniqueID = 0u, bool bSetDefaultProperty = false)
	{
		_InvokeCallBack?.Invoke(PropType, Value1, Value2, HandleID, NotifyUniqueID, bSetDefaultProperty);
	}
}
