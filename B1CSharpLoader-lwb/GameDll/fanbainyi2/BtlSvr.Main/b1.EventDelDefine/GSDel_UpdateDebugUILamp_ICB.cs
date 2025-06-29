using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.SlateCore;

namespace b1.EventDelDefine;

public class GSDel_UpdateDebugUILamp_ICB : IFreshAbleGSEvent
{
	private Del_UpdateDebugUILamp _InvokeCallBack;

	private Action<Del_UpdateDebugUILamp> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_UpdateDebugUILamp _MultiCastDel;

	public GSDel_UpdateDebugUILamp_ICB(Del_UpdateDebugUILamp InvokeCallBack, Action<Del_UpdateDebugUILamp> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_UpdateDebugUILamp)Delegate.Combine(_MultiCastDel, (Del_UpdateDebugUILamp)Del);
		}
		else
		{
			_MultiCastDel = (Del_UpdateDebugUILamp)Delegate.Remove(_MultiCastDel, (Del_UpdateDebugUILamp)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_UpdateDebugUILamp_ICB operator +(GSDel_UpdateDebugUILamp_ICB GSEvent, Del_UpdateDebugUILamp Del)
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
		GSEvent._MultiCastDel = (Del_UpdateDebugUILamp)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_UpdateDebugUILamp_ICB operator -(GSDel_UpdateDebugUILamp_ICB GSEvent, Del_UpdateDebugUILamp Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_UpdateDebugUILamp == Del)
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
		GSEvent._MultiCastDel = (Del_UpdateDebugUILamp)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(string Name, FSlateColor Color, int Column = 0, float ResetTime = 0f)
	{
		_InvokeCallBack?.Invoke(Name, Color, Column, ResetTime);
	}
}
