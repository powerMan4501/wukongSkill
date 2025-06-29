using System;
using System.Collections.Generic;
using b1.ECS;
using b1.Plugins.GSInput;

namespace b1.EventDelDefine;

public class GSDel_InputTrigger_ICB : IFreshAbleGSEvent
{
	private Del_InputTrigger _InvokeCallBack;

	private Action<Del_InputTrigger> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_InputTrigger _MultiCastDel;

	public GSDel_InputTrigger_ICB(Del_InputTrigger InvokeCallBack, Action<Del_InputTrigger> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_InputTrigger)Delegate.Combine(_MultiCastDel, (Del_InputTrigger)Del);
		}
		else
		{
			_MultiCastDel = (Del_InputTrigger)Delegate.Remove(_MultiCastDel, (Del_InputTrigger)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_InputTrigger_ICB operator +(GSDel_InputTrigger_ICB GSEvent, Del_InputTrigger Del)
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
		GSEvent._MultiCastDel = (Del_InputTrigger)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_InputTrigger_ICB operator -(GSDel_InputTrigger_ICB GSEvent, Del_InputTrigger Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_InputTrigger == Del)
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
		GSEvent._MultiCastDel = (Del_InputTrigger)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EGSInputType InputType)
	{
		_InvokeCallBack?.Invoke(InputType);
	}
}
