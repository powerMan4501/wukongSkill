using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_OnShowDialogueBuddle_ICB : IFreshAbleGSEvent
{
	private Del_OnShowDialogueBuddle _InvokeCallBack;

	private Action<Del_OnShowDialogueBuddle> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnShowDialogueBuddle _MultiCastDel;

	public GSDel_OnShowDialogueBuddle_ICB(Del_OnShowDialogueBuddle InvokeCallBack, Action<Del_OnShowDialogueBuddle> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnShowDialogueBuddle)Delegate.Combine(_MultiCastDel, (Del_OnShowDialogueBuddle)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnShowDialogueBuddle)Delegate.Remove(_MultiCastDel, (Del_OnShowDialogueBuddle)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_OnShowDialogueBuddle_ICB operator +(GSDel_OnShowDialogueBuddle_ICB GSEvent, Del_OnShowDialogueBuddle Del)
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
		GSEvent._MultiCastDel = (Del_OnShowDialogueBuddle)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_OnShowDialogueBuddle_ICB operator -(GSDel_OnShowDialogueBuddle_ICB GSEvent, Del_OnShowDialogueBuddle Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnShowDialogueBuddle == Del)
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
		GSEvent._MultiCastDel = (Del_OnShowDialogueBuddle)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(string text, float Time)
	{
		_InvokeCallBack?.Invoke(text, Time);
	}
}
