using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_DestroyProjectile_ExceptID_ICB : IFreshAbleGSEvent
{
	private Del_DestroyProjectile_ExceptID _InvokeCallBack;

	private Action<Del_DestroyProjectile_ExceptID> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_DestroyProjectile_ExceptID _MultiCastDel;

	public GSDel_DestroyProjectile_ExceptID_ICB(Del_DestroyProjectile_ExceptID InvokeCallBack, Action<Del_DestroyProjectile_ExceptID> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_DestroyProjectile_ExceptID)Delegate.Combine(_MultiCastDel, (Del_DestroyProjectile_ExceptID)Del);
		}
		else
		{
			_MultiCastDel = (Del_DestroyProjectile_ExceptID)Delegate.Remove(_MultiCastDel, (Del_DestroyProjectile_ExceptID)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_DestroyProjectile_ExceptID_ICB operator +(GSDel_DestroyProjectile_ExceptID_ICB GSEvent, Del_DestroyProjectile_ExceptID Del)
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
		GSEvent._MultiCastDel = (Del_DestroyProjectile_ExceptID)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_DestroyProjectile_ExceptID_ICB operator -(GSDel_DestroyProjectile_ExceptID_ICB GSEvent, Del_DestroyProjectile_ExceptID Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_DestroyProjectile_ExceptID == Del)
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
		GSEvent._MultiCastDel = (Del_DestroyProjectile_ExceptID)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(List<int> ProjectileID)
	{
		_InvokeCallBack?.Invoke(ProjectileID);
	}
}
