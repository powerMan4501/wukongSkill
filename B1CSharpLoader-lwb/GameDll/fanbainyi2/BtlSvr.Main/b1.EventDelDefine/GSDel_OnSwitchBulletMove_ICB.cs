using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_OnSwitchBulletMove_ICB : IFreshAbleGSEvent
{
	private Del_OnSwitchBulletMove _InvokeCallBack;

	private Action<Del_OnSwitchBulletMove> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnSwitchBulletMove _MultiCastDel;

	public GSDel_OnSwitchBulletMove_ICB(Del_OnSwitchBulletMove InvokeCallBack, Action<Del_OnSwitchBulletMove> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnSwitchBulletMove)Delegate.Combine(_MultiCastDel, (Del_OnSwitchBulletMove)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnSwitchBulletMove)Delegate.Remove(_MultiCastDel, (Del_OnSwitchBulletMove)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_OnSwitchBulletMove_ICB operator +(GSDel_OnSwitchBulletMove_ICB GSEvent, Del_OnSwitchBulletMove Del)
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
		GSEvent._MultiCastDel = (Del_OnSwitchBulletMove)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_OnSwitchBulletMove_ICB operator -(GSDel_OnSwitchBulletMove_ICB GSEvent, Del_OnSwitchBulletMove Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnSwitchBulletMove == Del)
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
		GSEvent._MultiCastDel = (Del_OnSwitchBulletMove)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FGSwitchBulletMovableInfo MovableInfo, AActor Caster)
	{
		_InvokeCallBack?.Invoke(MovableInfo, Caster);
	}
}
