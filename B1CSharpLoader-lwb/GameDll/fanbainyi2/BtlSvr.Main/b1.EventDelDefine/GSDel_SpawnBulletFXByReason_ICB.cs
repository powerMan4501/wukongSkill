using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_SpawnBulletFXByReason_ICB : IFreshAbleGSEvent
{
	private Del_SpawnBulletFXByReason _InvokeCallBack;

	private Action<Del_SpawnBulletFXByReason> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SpawnBulletFXByReason _MultiCastDel;

	public GSDel_SpawnBulletFXByReason_ICB(Del_SpawnBulletFXByReason InvokeCallBack, Action<Del_SpawnBulletFXByReason> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SpawnBulletFXByReason)Delegate.Combine(_MultiCastDel, (Del_SpawnBulletFXByReason)Del);
		}
		else
		{
			_MultiCastDel = (Del_SpawnBulletFXByReason)Delegate.Remove(_MultiCastDel, (Del_SpawnBulletFXByReason)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SpawnBulletFXByReason_ICB operator +(GSDel_SpawnBulletFXByReason_ICB GSEvent, Del_SpawnBulletFXByReason Del)
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
		GSEvent._MultiCastDel = (Del_SpawnBulletFXByReason)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SpawnBulletFXByReason_ICB operator -(GSDel_SpawnBulletFXByReason_ICB GSEvent, Del_SpawnBulletFXByReason Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SpawnBulletFXByReason == Del)
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
		GSEvent._MultiCastDel = (Del_SpawnBulletFXByReason)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EBGUBulletDispReason BulletDispReason, FEffectInstReq EffectInstReq, AActor BeHitActor = null)
	{
		_InvokeCallBack?.Invoke(BulletDispReason, EffectInstReq, BeHitActor);
	}
}
