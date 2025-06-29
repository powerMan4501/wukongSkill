using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_BPS_TeleportTo_ICB : IFreshAbleGSEvent
{
	private Del_BPS_TeleportTo _InvokeCallBack;

	private Action<Del_BPS_TeleportTo> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_BPS_TeleportTo _MultiCastDel;

	public GSDel_BPS_TeleportTo_ICB(Del_BPS_TeleportTo InvokeCallBack, Action<Del_BPS_TeleportTo> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_BPS_TeleportTo)Delegate.Combine(_MultiCastDel, (Del_BPS_TeleportTo)Del);
		}
		else
		{
			_MultiCastDel = (Del_BPS_TeleportTo)Delegate.Remove(_MultiCastDel, (Del_BPS_TeleportTo)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_BPS_TeleportTo_ICB operator +(GSDel_BPS_TeleportTo_ICB GSEvent, Del_BPS_TeleportTo Del)
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
		GSEvent._MultiCastDel = (Del_BPS_TeleportTo)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_BPS_TeleportTo_ICB operator -(GSDel_BPS_TeleportTo_ICB GSEvent, Del_BPS_TeleportTo Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_BPS_TeleportTo == Del)
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
		GSEvent._MultiCastDel = (Del_BPS_TeleportTo)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(ETeleportTypeV2 TeleportType, ValueType UserData, EPlayerTeleportReason Reason)
	{
		_InvokeCallBack?.Invoke(TeleportType, UserData, Reason);
	}
}
