using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_OnProjectileCustomSweepHitNormalUnit_ICB : IFreshAbleGSEvent
{
	private Del_OnProjectileCustomSweepHitNormalUnit _InvokeCallBack;

	private Action<Del_OnProjectileCustomSweepHitNormalUnit> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnProjectileCustomSweepHitNormalUnit _MultiCastDel;

	public GSDel_OnProjectileCustomSweepHitNormalUnit_ICB(Del_OnProjectileCustomSweepHitNormalUnit InvokeCallBack, Action<Del_OnProjectileCustomSweepHitNormalUnit> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnProjectileCustomSweepHitNormalUnit)Delegate.Combine(_MultiCastDel, (Del_OnProjectileCustomSweepHitNormalUnit)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnProjectileCustomSweepHitNormalUnit)Delegate.Remove(_MultiCastDel, (Del_OnProjectileCustomSweepHitNormalUnit)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_OnProjectileCustomSweepHitNormalUnit_ICB operator +(GSDel_OnProjectileCustomSweepHitNormalUnit_ICB GSEvent, Del_OnProjectileCustomSweepHitNormalUnit Del)
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
		GSEvent._MultiCastDel = (Del_OnProjectileCustomSweepHitNormalUnit)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_OnProjectileCustomSweepHitNormalUnit_ICB operator -(GSDel_OnProjectileCustomSweepHitNormalUnit_ICB GSEvent, Del_OnProjectileCustomSweepHitNormalUnit Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnProjectileCustomSweepHitNormalUnit == Del)
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
		GSEvent._MultiCastDel = (Del_OnProjectileCustomSweepHitNormalUnit)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FUStGSHitResult CurGSHitResult)
	{
		_InvokeCallBack?.Invoke(CurGSHitResult);
	}
}
