using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_OnProjectileCustomSweepHitWorldItem_ICB : IFreshAbleGSEvent
{
	private Del_OnProjectileCustomSweepHitWorldItem _InvokeCallBack;

	private Action<Del_OnProjectileCustomSweepHitWorldItem> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnProjectileCustomSweepHitWorldItem _MultiCastDel;

	public GSDel_OnProjectileCustomSweepHitWorldItem_ICB(Del_OnProjectileCustomSweepHitWorldItem InvokeCallBack, Action<Del_OnProjectileCustomSweepHitWorldItem> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnProjectileCustomSweepHitWorldItem)Delegate.Combine(_MultiCastDel, (Del_OnProjectileCustomSweepHitWorldItem)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnProjectileCustomSweepHitWorldItem)Delegate.Remove(_MultiCastDel, (Del_OnProjectileCustomSweepHitWorldItem)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_OnProjectileCustomSweepHitWorldItem_ICB operator +(GSDel_OnProjectileCustomSweepHitWorldItem_ICB GSEvent, Del_OnProjectileCustomSweepHitWorldItem Del)
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
		GSEvent._MultiCastDel = (Del_OnProjectileCustomSweepHitWorldItem)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_OnProjectileCustomSweepHitWorldItem_ICB operator -(GSDel_OnProjectileCustomSweepHitWorldItem_ICB GSEvent, Del_OnProjectileCustomSweepHitWorldItem Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnProjectileCustomSweepHitWorldItem == Del)
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
		GSEvent._MultiCastDel = (Del_OnProjectileCustomSweepHitWorldItem)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FEffectInstReq EffectInstReq, AActor BeHitActor)
	{
		_InvokeCallBack?.Invoke(EffectInstReq, BeHitActor);
	}
}
