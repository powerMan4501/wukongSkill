using System;
using System.Collections.Generic;
using b1.ECS;
using BtlShare;

namespace b1.EventDelDefine;

public class GSDel_SendOnlineScreenMsg_ICB : IFreshAbleGSEvent
{
	private Del_SendOnlineScreenMsg _InvokeCallBack;

	private Action<Del_SendOnlineScreenMsg> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SendOnlineScreenMsg _MultiCastDel;

	public GSDel_SendOnlineScreenMsg_ICB(Del_SendOnlineScreenMsg InvokeCallBack, Action<Del_SendOnlineScreenMsg> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SendOnlineScreenMsg)Delegate.Combine(_MultiCastDel, (Del_SendOnlineScreenMsg)Del);
		}
		else
		{
			_MultiCastDel = (Del_SendOnlineScreenMsg)Delegate.Remove(_MultiCastDel, (Del_SendOnlineScreenMsg)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SendOnlineScreenMsg_ICB operator +(GSDel_SendOnlineScreenMsg_ICB GSEvent, Del_SendOnlineScreenMsg Del)
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
		GSEvent._MultiCastDel = (Del_SendOnlineScreenMsg)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SendOnlineScreenMsg_ICB operator -(GSDel_SendOnlineScreenMsg_ICB GSEvent, Del_SendOnlineScreenMsg Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SendOnlineScreenMsg == Del)
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
		GSEvent._MultiCastDel = (Del_SendOnlineScreenMsg)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EScreenMsgType ScreenMsgType, string Msg, int TipsDuration)
	{
		_InvokeCallBack?.Invoke(ScreenMsgType, Msg, TipsDuration);
	}
}
