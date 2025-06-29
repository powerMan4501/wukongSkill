using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SetFloatProperty_ICB : IFreshAbleGSEvent
{
	private Del_SetFloatProperty _InvokeCallBack;

	private Action<Del_SetFloatProperty> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetFloatProperty _MultiCastDel;

	public GSDel_SetFloatProperty_ICB(Del_SetFloatProperty InvokeCallBack, Action<Del_SetFloatProperty> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetFloatProperty)Delegate.Combine(_MultiCastDel, (Del_SetFloatProperty)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetFloatProperty)Delegate.Remove(_MultiCastDel, (Del_SetFloatProperty)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetFloatProperty_ICB operator +(GSDel_SetFloatProperty_ICB GSEvent, Del_SetFloatProperty Del)
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
		GSEvent._MultiCastDel = (Del_SetFloatProperty)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetFloatProperty_ICB operator -(GSDel_SetFloatProperty_ICB GSEvent, Del_SetFloatProperty Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetFloatProperty == Del)
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
		GSEvent._MultiCastDel = (Del_SetFloatProperty)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EPropType PropType, float Value, uint HandleID = 0u, uint NotifyUniqueID = 0u, bool bSetDefaultProperty = false)
	{
		_InvokeCallBack?.Invoke(PropType, Value, HandleID, NotifyUniqueID, bSetDefaultProperty);
	}
}
