using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.InputCore;

namespace b1.EventDelDefine;

public class GSDel_Bool_FKey_ICB : IFreshAbleGSEvent
{
	private Del_Bool_FKey _InvokeCallBack;

	private Action<Del_Bool_FKey> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_Bool_FKey _MultiCastDel;

	public GSDel_Bool_FKey_ICB(Del_Bool_FKey InvokeCallBack, Action<Del_Bool_FKey> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_Bool_FKey)Delegate.Combine(_MultiCastDel, (Del_Bool_FKey)Del);
		}
		else
		{
			_MultiCastDel = (Del_Bool_FKey)Delegate.Remove(_MultiCastDel, (Del_Bool_FKey)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_Bool_FKey_ICB operator +(GSDel_Bool_FKey_ICB GSEvent, Del_Bool_FKey Del)
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
		GSEvent._MultiCastDel = (Del_Bool_FKey)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_Bool_FKey_ICB operator -(GSDel_Bool_FKey_ICB GSEvent, Del_Bool_FKey Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_Bool_FKey == Del)
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
		GSEvent._MultiCastDel = (Del_Bool_FKey)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(bool B1, FKey InKey)
	{
		_InvokeCallBack?.Invoke(B1, InKey);
	}
}
