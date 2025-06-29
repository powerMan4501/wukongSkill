using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_OnSwitchOneProjectile_ICB : IFreshAbleGSEvent
{
	private Del_OnSwitchOneProjectile _InvokeCallBack;

	private Action<Del_OnSwitchOneProjectile> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnSwitchOneProjectile _MultiCastDel;

	public GSDel_OnSwitchOneProjectile_ICB(Del_OnSwitchOneProjectile InvokeCallBack, Action<Del_OnSwitchOneProjectile> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnSwitchOneProjectile)Delegate.Combine(_MultiCastDel, (Del_OnSwitchOneProjectile)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnSwitchOneProjectile)Delegate.Remove(_MultiCastDel, (Del_OnSwitchOneProjectile)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_OnSwitchOneProjectile_ICB operator +(GSDel_OnSwitchOneProjectile_ICB GSEvent, Del_OnSwitchOneProjectile Del)
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
		GSEvent._MultiCastDel = (Del_OnSwitchOneProjectile)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_OnSwitchOneProjectile_ICB operator -(GSDel_OnSwitchOneProjectile_ICB GSEvent, Del_OnSwitchOneProjectile Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnSwitchOneProjectile == Del)
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
		GSEvent._MultiCastDel = (Del_OnSwitchOneProjectile)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(BGUProjectileBaseActor ProjectileBaseActor, int ProjectileSwitchID, int SwitchIdx = 0, AActor InnerActor = null)
	{
		_InvokeCallBack?.Invoke(ProjectileBaseActor, ProjectileSwitchID, SwitchIdx, InnerActor);
	}
}
