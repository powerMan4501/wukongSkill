using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_ProjectileMoveBackorOutNest_ICB : IFreshAbleGSEvent
{
	private Del_ProjectileMoveBackorOutNest _InvokeCallBack;

	private Action<Del_ProjectileMoveBackorOutNest> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ProjectileMoveBackorOutNest _MultiCastDel;

	public GSDel_ProjectileMoveBackorOutNest_ICB(Del_ProjectileMoveBackorOutNest InvokeCallBack, Action<Del_ProjectileMoveBackorOutNest> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ProjectileMoveBackorOutNest)Delegate.Combine(_MultiCastDel, (Del_ProjectileMoveBackorOutNest)Del);
		}
		else
		{
			_MultiCastDel = (Del_ProjectileMoveBackorOutNest)Delegate.Remove(_MultiCastDel, (Del_ProjectileMoveBackorOutNest)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_ProjectileMoveBackorOutNest_ICB operator +(GSDel_ProjectileMoveBackorOutNest_ICB GSEvent, Del_ProjectileMoveBackorOutNest Del)
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
		GSEvent._MultiCastDel = (Del_ProjectileMoveBackorOutNest)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_ProjectileMoveBackorOutNest_ICB operator -(GSDel_ProjectileMoveBackorOutNest_ICB GSEvent, Del_ProjectileMoveBackorOutNest Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ProjectileMoveBackorOutNest == Del)
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
		GSEvent._MultiCastDel = (Del_ProjectileMoveBackorOutNest)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(BGUProjectileBaseActor Bullet, bool isBackNest, FName NestName = default(FName))
	{
		_InvokeCallBack?.Invoke(Bullet, isBackNest, NestName);
	}
}
