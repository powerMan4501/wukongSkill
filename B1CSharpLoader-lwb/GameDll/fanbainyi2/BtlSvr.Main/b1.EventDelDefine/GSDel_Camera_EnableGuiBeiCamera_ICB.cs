using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_Camera_EnableGuiBeiCamera_ICB : IFreshAbleGSEvent
{
	private Del_Camera_EnableGuiBeiCamera _InvokeCallBack;

	private Action<Del_Camera_EnableGuiBeiCamera> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_Camera_EnableGuiBeiCamera _MultiCastDel;

	public GSDel_Camera_EnableGuiBeiCamera_ICB(Del_Camera_EnableGuiBeiCamera InvokeCallBack, Action<Del_Camera_EnableGuiBeiCamera> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_Camera_EnableGuiBeiCamera)Delegate.Combine(_MultiCastDel, (Del_Camera_EnableGuiBeiCamera)Del);
		}
		else
		{
			_MultiCastDel = (Del_Camera_EnableGuiBeiCamera)Delegate.Remove(_MultiCastDel, (Del_Camera_EnableGuiBeiCamera)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_Camera_EnableGuiBeiCamera_ICB operator +(GSDel_Camera_EnableGuiBeiCamera_ICB GSEvent, Del_Camera_EnableGuiBeiCamera Del)
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
		GSEvent._MultiCastDel = (Del_Camera_EnableGuiBeiCamera)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_Camera_EnableGuiBeiCamera_ICB operator -(GSDel_Camera_EnableGuiBeiCamera_ICB GSEvent, Del_Camera_EnableGuiBeiCamera Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_Camera_EnableGuiBeiCamera == Del)
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
		GSEvent._MultiCastDel = (Del_Camera_EnableGuiBeiCamera)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FRotator InverseAnimRotator)
	{
		_InvokeCallBack?.Invoke(InverseAnimRotator);
	}
}
