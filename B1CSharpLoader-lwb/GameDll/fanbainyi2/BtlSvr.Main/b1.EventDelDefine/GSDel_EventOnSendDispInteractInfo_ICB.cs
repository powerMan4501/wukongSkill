using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_EventOnSendDispInteractInfo_ICB : IFreshAbleGSEvent
{
	private Del_EventOnSendDispInteractInfo _InvokeCallBack;

	private Action<Del_EventOnSendDispInteractInfo> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_EventOnSendDispInteractInfo _MultiCastDel;

	public GSDel_EventOnSendDispInteractInfo_ICB(Del_EventOnSendDispInteractInfo InvokeCallBack, Action<Del_EventOnSendDispInteractInfo> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_EventOnSendDispInteractInfo)Delegate.Combine(_MultiCastDel, (Del_EventOnSendDispInteractInfo)Del);
		}
		else
		{
			_MultiCastDel = (Del_EventOnSendDispInteractInfo)Delegate.Remove(_MultiCastDel, (Del_EventOnSendDispInteractInfo)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_EventOnSendDispInteractInfo_ICB operator +(GSDel_EventOnSendDispInteractInfo_ICB GSEvent, Del_EventOnSendDispInteractInfo Del)
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
		GSEvent._MultiCastDel = (Del_EventOnSendDispInteractInfo)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_EventOnSendDispInteractInfo_ICB operator -(GSDel_EventOnSendDispInteractInfo_ICB GSEvent, Del_EventOnSendDispInteractInfo Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_EventOnSendDispInteractInfo == Del)
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
		GSEvent._MultiCastDel = (Del_EventOnSendDispInteractInfo)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(bool Enable, Dictionary<int, FDispInteractInfo> InfoList)
	{
		_InvokeCallBack?.Invoke(Enable, InfoList);
	}
}
