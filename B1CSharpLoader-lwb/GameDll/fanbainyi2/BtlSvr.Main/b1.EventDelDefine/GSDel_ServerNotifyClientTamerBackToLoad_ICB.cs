using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_ServerNotifyClientTamerBackToLoad_ICB : IFreshAbleGSEvent
{
	private Del_ServerNotifyClientTamerBackToLoad _InvokeCallBack;

	private Action<Del_ServerNotifyClientTamerBackToLoad> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ServerNotifyClientTamerBackToLoad _MultiCastDel;

	public GSDel_ServerNotifyClientTamerBackToLoad_ICB(Del_ServerNotifyClientTamerBackToLoad InvokeCallBack, Action<Del_ServerNotifyClientTamerBackToLoad> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ServerNotifyClientTamerBackToLoad)Delegate.Combine(_MultiCastDel, (Del_ServerNotifyClientTamerBackToLoad)Del);
		}
		else
		{
			_MultiCastDel = (Del_ServerNotifyClientTamerBackToLoad)Delegate.Remove(_MultiCastDel, (Del_ServerNotifyClientTamerBackToLoad)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_ServerNotifyClientTamerBackToLoad_ICB operator +(GSDel_ServerNotifyClientTamerBackToLoad_ICB GSEvent, Del_ServerNotifyClientTamerBackToLoad Del)
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
		GSEvent._MultiCastDel = (Del_ServerNotifyClientTamerBackToLoad)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_ServerNotifyClientTamerBackToLoad_ICB operator -(GSDel_ServerNotifyClientTamerBackToLoad_ICB GSEvent, Del_ServerNotifyClientTamerBackToLoad Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ServerNotifyClientTamerBackToLoad == Del)
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
		GSEvent._MultiCastDel = (Del_ServerNotifyClientTamerBackToLoad)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(List<string> Guids)
	{
		_InvokeCallBack?.Invoke(Guids);
	}
}
