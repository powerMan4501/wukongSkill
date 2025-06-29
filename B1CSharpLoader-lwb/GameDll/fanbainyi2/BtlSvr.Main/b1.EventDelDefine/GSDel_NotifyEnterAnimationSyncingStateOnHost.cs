using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_NotifyEnterAnimationSyncingStateOnHost : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_NotifyEnterAnimationSyncingStateOnHost _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_NotifyEnterAnimationSyncingStateOnHost)Delegate.Combine(_MultiCastDel, (Del_NotifyEnterAnimationSyncingStateOnHost)Del);
		}
		else
		{
			_MultiCastDel = (Del_NotifyEnterAnimationSyncingStateOnHost)Delegate.Remove(_MultiCastDel, (Del_NotifyEnterAnimationSyncingStateOnHost)Del);
		}
	}

	public static GSDel_NotifyEnterAnimationSyncingStateOnHost operator +(GSDel_NotifyEnterAnimationSyncingStateOnHost GSEvent, Del_NotifyEnterAnimationSyncingStateOnHost Del)
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
		GSEvent._MultiCastDel = (Del_NotifyEnterAnimationSyncingStateOnHost)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_NotifyEnterAnimationSyncingStateOnHost operator -(GSDel_NotifyEnterAnimationSyncingStateOnHost GSEvent, Del_NotifyEnterAnimationSyncingStateOnHost Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_NotifyEnterAnimationSyncingStateOnHost == Del)
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
		GSEvent._MultiCastDel = (Del_NotifyEnterAnimationSyncingStateOnHost)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(List<int> AnimationSyncStateBuffList, UAnimMontage AnimationSyncMontage)
	{
		_MultiCastDel?.Invoke(AnimationSyncStateBuffList, AnimationSyncMontage);
	}
}
