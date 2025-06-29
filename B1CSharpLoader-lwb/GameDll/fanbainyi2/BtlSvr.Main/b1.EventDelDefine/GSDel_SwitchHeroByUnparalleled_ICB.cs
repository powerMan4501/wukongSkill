using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SwitchHeroByUnparalleled_ICB : IFreshAbleGSEvent
{
	private Del_SwitchHeroByUnparalleled _InvokeCallBack;

	private Action<Del_SwitchHeroByUnparalleled> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SwitchHeroByUnparalleled _MultiCastDel;

	public GSDel_SwitchHeroByUnparalleled_ICB(Del_SwitchHeroByUnparalleled InvokeCallBack, Action<Del_SwitchHeroByUnparalleled> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SwitchHeroByUnparalleled)Delegate.Combine(_MultiCastDel, (Del_SwitchHeroByUnparalleled)Del);
		}
		else
		{
			_MultiCastDel = (Del_SwitchHeroByUnparalleled)Delegate.Remove(_MultiCastDel, (Del_SwitchHeroByUnparalleled)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SwitchHeroByUnparalleled_ICB operator +(GSDel_SwitchHeroByUnparalleled_ICB GSEvent, Del_SwitchHeroByUnparalleled Del)
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
		GSEvent._MultiCastDel = (Del_SwitchHeroByUnparalleled)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SwitchHeroByUnparalleled_ICB operator -(GSDel_SwitchHeroByUnparalleled_ICB GSEvent, Del_SwitchHeroByUnparalleled Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SwitchHeroByUnparalleled == Del)
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
		GSEvent._MultiCastDel = (Del_SwitchHeroByUnparalleled)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int EnityId, bool CastSkill)
	{
		_InvokeCallBack?.Invoke(EnityId, CastSkill);
	}
}
