using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_OnBuffLayerChangedNotify_ICB : IFreshAbleGSEvent
{
	private Del_OnBuffLayerChangedNotify _InvokeCallBack;

	private Action<Del_OnBuffLayerChangedNotify> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnBuffLayerChangedNotify _MultiCastDel;

	public GSDel_OnBuffLayerChangedNotify_ICB(Del_OnBuffLayerChangedNotify InvokeCallBack, Action<Del_OnBuffLayerChangedNotify> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnBuffLayerChangedNotify)Delegate.Combine(_MultiCastDel, (Del_OnBuffLayerChangedNotify)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnBuffLayerChangedNotify)Delegate.Remove(_MultiCastDel, (Del_OnBuffLayerChangedNotify)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_OnBuffLayerChangedNotify_ICB operator +(GSDel_OnBuffLayerChangedNotify_ICB GSEvent, Del_OnBuffLayerChangedNotify Del)
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
		GSEvent._MultiCastDel = (Del_OnBuffLayerChangedNotify)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_OnBuffLayerChangedNotify_ICB operator -(GSDel_OnBuffLayerChangedNotify_ICB GSEvent, Del_OnBuffLayerChangedNotify Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnBuffLayerChangedNotify == Del)
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
		GSEvent._MultiCastDel = (Del_OnBuffLayerChangedNotify)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int BuffID, int Layer_OldValue, int Layer_NewValue)
	{
		_InvokeCallBack?.Invoke(BuffID, Layer_OldValue, Layer_NewValue);
	}
}
