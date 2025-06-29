using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_BossRushSetPauseTimeTick_ICB : IFreshAbleGSEvent
{
	private Del_BossRushSetPauseTimeTick _InvokeCallBack;

	private Action<Del_BossRushSetPauseTimeTick> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_BossRushSetPauseTimeTick _MultiCastDel;

	public GSDel_BossRushSetPauseTimeTick_ICB(Del_BossRushSetPauseTimeTick InvokeCallBack, Action<Del_BossRushSetPauseTimeTick> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_BossRushSetPauseTimeTick)Delegate.Combine(_MultiCastDel, (Del_BossRushSetPauseTimeTick)Del);
		}
		else
		{
			_MultiCastDel = (Del_BossRushSetPauseTimeTick)Delegate.Remove(_MultiCastDel, (Del_BossRushSetPauseTimeTick)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_BossRushSetPauseTimeTick_ICB operator +(GSDel_BossRushSetPauseTimeTick_ICB GSEvent, Del_BossRushSetPauseTimeTick Del)
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
		GSEvent._MultiCastDel = (Del_BossRushSetPauseTimeTick)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_BossRushSetPauseTimeTick_ICB operator -(GSDel_BossRushSetPauseTimeTick_ICB GSEvent, Del_BossRushSetPauseTimeTick Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_BossRushSetPauseTimeTick == Del)
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
		GSEvent._MultiCastDel = (Del_BossRushSetPauseTimeTick)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(bool Pause, float Time)
	{
		_InvokeCallBack?.Invoke(Pause, Time);
	}
}
