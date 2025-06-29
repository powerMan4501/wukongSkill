using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_Void_InRotator_ICB : IFreshAbleGSEvent
{
	private Del_Void_InRotator _InvokeCallBack;

	private Action<Del_Void_InRotator> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_Void_InRotator _MultiCastDel;

	public GSDel_Void_InRotator_ICB(Del_Void_InRotator InvokeCallBack, Action<Del_Void_InRotator> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_Void_InRotator)Delegate.Combine(_MultiCastDel, (Del_Void_InRotator)Del);
		}
		else
		{
			_MultiCastDel = (Del_Void_InRotator)Delegate.Remove(_MultiCastDel, (Del_Void_InRotator)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_Void_InRotator_ICB operator +(GSDel_Void_InRotator_ICB GSEvent, Del_Void_InRotator Del)
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
		GSEvent._MultiCastDel = (Del_Void_InRotator)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_Void_InRotator_ICB operator -(GSDel_Void_InRotator_ICB GSEvent, Del_Void_InRotator Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_Void_InRotator == Del)
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
		GSEvent._MultiCastDel = (Del_Void_InRotator)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(in FRotator Rot)
	{
		_InvokeCallBack?.Invoke(in Rot);
	}
}
