using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_OnTriggerDropItem_ICB : IFreshAbleGSEvent
{
	private Del_OnTriggerDropItem _InvokeCallBack;

	private Action<Del_OnTriggerDropItem> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnTriggerDropItem _MultiCastDel;

	public GSDel_OnTriggerDropItem_ICB(Del_OnTriggerDropItem InvokeCallBack, Action<Del_OnTriggerDropItem> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnTriggerDropItem)Delegate.Combine(_MultiCastDel, (Del_OnTriggerDropItem)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnTriggerDropItem)Delegate.Remove(_MultiCastDel, (Del_OnTriggerDropItem)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_OnTriggerDropItem_ICB operator +(GSDel_OnTriggerDropItem_ICB GSEvent, Del_OnTriggerDropItem Del)
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
		GSEvent._MultiCastDel = (Del_OnTriggerDropItem)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_OnTriggerDropItem_ICB operator -(GSDel_OnTriggerDropItem_ICB GSEvent, Del_OnTriggerDropItem Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnTriggerDropItem == Del)
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
		GSEvent._MultiCastDel = (Del_OnTriggerDropItem)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor Actor, List<byte> AwardsBytes, DropReason DropReason, OverrideDropTempleteInfoClass OverrideDropTempleteInfo = null)
	{
		_InvokeCallBack?.Invoke(Actor, AwardsBytes, DropReason, OverrideDropTempleteInfo);
	}
}
