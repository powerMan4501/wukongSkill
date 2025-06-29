using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_EnterInputKeyCacheWindow_ICB : IFreshAbleGSEvent
{
	private Del_EnterInputKeyCacheWindow _InvokeCallBack;

	private Action<Del_EnterInputKeyCacheWindow> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_EnterInputKeyCacheWindow _MultiCastDel;

	public GSDel_EnterInputKeyCacheWindow_ICB(Del_EnterInputKeyCacheWindow InvokeCallBack, Action<Del_EnterInputKeyCacheWindow> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_EnterInputKeyCacheWindow)Delegate.Combine(_MultiCastDel, (Del_EnterInputKeyCacheWindow)Del);
		}
		else
		{
			_MultiCastDel = (Del_EnterInputKeyCacheWindow)Delegate.Remove(_MultiCastDel, (Del_EnterInputKeyCacheWindow)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_EnterInputKeyCacheWindow_ICB operator +(GSDel_EnterInputKeyCacheWindow_ICB GSEvent, Del_EnterInputKeyCacheWindow Del)
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
		GSEvent._MultiCastDel = (Del_EnterInputKeyCacheWindow)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_EnterInputKeyCacheWindow_ICB operator -(GSDel_EnterInputKeyCacheWindow_ICB GSEvent, Del_EnterInputKeyCacheWindow Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_EnterInputKeyCacheWindow == Del)
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
		GSEvent._MultiCastDel = (Del_EnterInputKeyCacheWindow)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EInputKeyCacheType KeyCacheType, int MontageID, uint NotifyID, int GroupID, float Duration)
	{
		_InvokeCallBack?.Invoke(KeyCacheType, MontageID, NotifyID, GroupID, Duration);
	}
}
