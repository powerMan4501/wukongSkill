using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_SweepCheckInPreciseDodgeRange_ICB : IFreshAbleGSEvent
{
	private Del_SweepCheckInPreciseDodgeRange _InvokeCallBack;

	private Action<Del_SweepCheckInPreciseDodgeRange> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SweepCheckInPreciseDodgeRange _MultiCastDel;

	public GSDel_SweepCheckInPreciseDodgeRange_ICB(Del_SweepCheckInPreciseDodgeRange InvokeCallBack, Action<Del_SweepCheckInPreciseDodgeRange> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SweepCheckInPreciseDodgeRange)Delegate.Combine(_MultiCastDel, (Del_SweepCheckInPreciseDodgeRange)Del);
		}
		else
		{
			_MultiCastDel = (Del_SweepCheckInPreciseDodgeRange)Delegate.Remove(_MultiCastDel, (Del_SweepCheckInPreciseDodgeRange)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SweepCheckInPreciseDodgeRange_ICB operator +(GSDel_SweepCheckInPreciseDodgeRange_ICB GSEvent, Del_SweepCheckInPreciseDodgeRange Del)
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
		GSEvent._MultiCastDel = (Del_SweepCheckInPreciseDodgeRange)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SweepCheckInPreciseDodgeRange_ICB operator -(GSDel_SweepCheckInPreciseDodgeRange_ICB GSEvent, Del_SweepCheckInPreciseDodgeRange Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SweepCheckInPreciseDodgeRange == Del)
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
		GSEvent._MultiCastDel = (Del_SweepCheckInPreciseDodgeRange)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor Attacker, int MontageID, int GroupID, int NotifyID, float MontageTime)
	{
		_InvokeCallBack?.Invoke(Attacker, MontageID, GroupID, NotifyID, MontageTime);
	}
}
