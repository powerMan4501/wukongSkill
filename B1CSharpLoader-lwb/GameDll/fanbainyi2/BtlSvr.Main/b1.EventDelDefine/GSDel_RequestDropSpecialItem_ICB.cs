using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_RequestDropSpecialItem_ICB : IFreshAbleGSEvent
{
	private Del_RequestDropSpecialItem _InvokeCallBack;

	private Action<Del_RequestDropSpecialItem> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_RequestDropSpecialItem _MultiCastDel;

	public GSDel_RequestDropSpecialItem_ICB(Del_RequestDropSpecialItem InvokeCallBack, Action<Del_RequestDropSpecialItem> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_RequestDropSpecialItem)Delegate.Combine(_MultiCastDel, (Del_RequestDropSpecialItem)Del);
		}
		else
		{
			_MultiCastDel = (Del_RequestDropSpecialItem)Delegate.Remove(_MultiCastDel, (Del_RequestDropSpecialItem)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_RequestDropSpecialItem_ICB operator +(GSDel_RequestDropSpecialItem_ICB GSEvent, Del_RequestDropSpecialItem Del)
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
		GSEvent._MultiCastDel = (Del_RequestDropSpecialItem)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_RequestDropSpecialItem_ICB operator -(GSDel_RequestDropSpecialItem_ICB GSEvent, Del_RequestDropSpecialItem Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_RequestDropSpecialItem == Del)
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
		GSEvent._MultiCastDel = (Del_RequestDropSpecialItem)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor Actor, int ItemID, FTransform Transform)
	{
		_InvokeCallBack?.Invoke(Actor, ItemID, Transform);
	}
}
