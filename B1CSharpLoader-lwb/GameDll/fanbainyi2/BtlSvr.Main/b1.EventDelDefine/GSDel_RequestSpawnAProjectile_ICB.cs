using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_RequestSpawnAProjectile_ICB : IFreshAbleGSEvent
{
	private Del_RequestSpawnAProjectile _InvokeCallBack;

	private Action<Del_RequestSpawnAProjectile> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_RequestSpawnAProjectile _MultiCastDel;

	public GSDel_RequestSpawnAProjectile_ICB(Del_RequestSpawnAProjectile InvokeCallBack, Action<Del_RequestSpawnAProjectile> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_RequestSpawnAProjectile)Delegate.Combine(_MultiCastDel, (Del_RequestSpawnAProjectile)Del);
		}
		else
		{
			_MultiCastDel = (Del_RequestSpawnAProjectile)Delegate.Remove(_MultiCastDel, (Del_RequestSpawnAProjectile)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_RequestSpawnAProjectile_ICB operator +(GSDel_RequestSpawnAProjectile_ICB GSEvent, Del_RequestSpawnAProjectile Del)
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
		GSEvent._MultiCastDel = (Del_RequestSpawnAProjectile)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_RequestSpawnAProjectile_ICB operator -(GSDel_RequestSpawnAProjectile_ICB GSEvent, Del_RequestSpawnAProjectile Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_RequestSpawnAProjectile == Del)
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
		GSEvent._MultiCastDel = (Del_RequestSpawnAProjectile)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FGSProjectileSpawnInfo ProjectileSpawnInfo)
	{
		_InvokeCallBack?.Invoke(ProjectileSpawnInfo);
	}
}
