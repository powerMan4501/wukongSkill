using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_SwitchBulletTarget_ICB : IFreshAbleGSEvent
{
	private Del_SwitchBulletTarget _InvokeCallBack;

	private Action<Del_SwitchBulletTarget> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SwitchBulletTarget _MultiCastDel;

	public GSDel_SwitchBulletTarget_ICB(Del_SwitchBulletTarget InvokeCallBack, Action<Del_SwitchBulletTarget> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SwitchBulletTarget)Delegate.Combine(_MultiCastDel, (Del_SwitchBulletTarget)Del);
		}
		else
		{
			_MultiCastDel = (Del_SwitchBulletTarget)Delegate.Remove(_MultiCastDel, (Del_SwitchBulletTarget)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SwitchBulletTarget_ICB operator +(GSDel_SwitchBulletTarget_ICB GSEvent, Del_SwitchBulletTarget Del)
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
		GSEvent._MultiCastDel = (Del_SwitchBulletTarget)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SwitchBulletTarget_ICB operator -(GSDel_SwitchBulletTarget_ICB GSEvent, Del_SwitchBulletTarget Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SwitchBulletTarget == Del)
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
		GSEvent._MultiCastDel = (Del_SwitchBulletTarget)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(BGUProjectileBaseActor ProjectileActor, AActor InnerTarget, string SocketName)
	{
		_InvokeCallBack?.Invoke(ProjectileActor, InnerTarget, SocketName);
	}
}
