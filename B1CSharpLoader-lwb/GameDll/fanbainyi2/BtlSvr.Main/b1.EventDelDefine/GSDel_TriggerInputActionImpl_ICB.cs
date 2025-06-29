using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Plugins.EnhancedInput;

namespace b1.EventDelDefine;

public class GSDel_TriggerInputActionImpl_ICB : IFreshAbleGSEvent
{
	private Del_TriggerInputActionImpl _InvokeCallBack;

	private Action<Del_TriggerInputActionImpl> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerInputActionImpl _MultiCastDel;

	public GSDel_TriggerInputActionImpl_ICB(Del_TriggerInputActionImpl InvokeCallBack, Action<Del_TriggerInputActionImpl> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TriggerInputActionImpl)Delegate.Combine(_MultiCastDel, (Del_TriggerInputActionImpl)Del);
		}
		else
		{
			_MultiCastDel = (Del_TriggerInputActionImpl)Delegate.Remove(_MultiCastDel, (Del_TriggerInputActionImpl)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_TriggerInputActionImpl_ICB operator +(GSDel_TriggerInputActionImpl_ICB GSEvent, Del_TriggerInputActionImpl Del)
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
		GSEvent._MultiCastDel = (Del_TriggerInputActionImpl)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_TriggerInputActionImpl_ICB operator -(GSDel_TriggerInputActionImpl_ICB GSEvent, Del_TriggerInputActionImpl Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TriggerInputActionImpl == Del)
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
		GSEvent._MultiCastDel = (Del_TriggerInputActionImpl)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(string ActionName, ETriggerEvent TriggerEvent, FInputActionValue Value)
	{
		_InvokeCallBack?.Invoke(ActionName, TriggerEvent, Value);
	}
}
