using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_NotifyEndSyncAnimation_ICB : IFreshAbleGSEvent
{
	private Del_NotifyEndSyncAnimation _InvokeCallBack;

	private Action<Del_NotifyEndSyncAnimation> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_NotifyEndSyncAnimation _MultiCastDel;

	public GSDel_NotifyEndSyncAnimation_ICB(Del_NotifyEndSyncAnimation InvokeCallBack, Action<Del_NotifyEndSyncAnimation> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_NotifyEndSyncAnimation)Delegate.Combine(_MultiCastDel, (Del_NotifyEndSyncAnimation)Del);
		}
		else
		{
			_MultiCastDel = (Del_NotifyEndSyncAnimation)Delegate.Remove(_MultiCastDel, (Del_NotifyEndSyncAnimation)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_NotifyEndSyncAnimation_ICB operator +(GSDel_NotifyEndSyncAnimation_ICB GSEvent, Del_NotifyEndSyncAnimation Del)
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
		GSEvent._MultiCastDel = (Del_NotifyEndSyncAnimation)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_NotifyEndSyncAnimation_ICB operator -(GSDel_NotifyEndSyncAnimation_ICB GSEvent, Del_NotifyEndSyncAnimation Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_NotifyEndSyncAnimation == Del)
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
		GSEvent._MultiCastDel = (Del_NotifyEndSyncAnimation)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(List<int> PreAnimationSyncStateBuffList, List<int> AnimationSyncStateBuffList)
	{
		_InvokeCallBack?.Invoke(PreAnimationSyncStateBuffList, AnimationSyncStateBuffList);
	}
}
