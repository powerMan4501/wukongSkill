using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_DetachWeapon_ICB : IFreshAbleGSEvent
{
	private Del_DetachWeapon _InvokeCallBack;

	private Action<Del_DetachWeapon> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_DetachWeapon _MultiCastDel;

	public GSDel_DetachWeapon_ICB(Del_DetachWeapon InvokeCallBack, Action<Del_DetachWeapon> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_DetachWeapon)Delegate.Combine(_MultiCastDel, (Del_DetachWeapon)Del);
		}
		else
		{
			_MultiCastDel = (Del_DetachWeapon)Delegate.Remove(_MultiCastDel, (Del_DetachWeapon)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_DetachWeapon_ICB operator +(GSDel_DetachWeapon_ICB GSEvent, Del_DetachWeapon Del)
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
		GSEvent._MultiCastDel = (Del_DetachWeapon)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_DetachWeapon_ICB operator -(GSDel_DetachWeapon_ICB GSEvent, Del_DetachWeapon Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_DetachWeapon == Del)
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
		GSEvent._MultiCastDel = (Del_DetachWeapon)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int Index, EDetachmentRule LocationRule = EDetachmentRule.KeepWorld, EDetachmentRule RotationRule = EDetachmentRule.KeepWorld, EDetachmentRule ScaleRule = EDetachmentRule.KeepWorld, float WeaponDestroyDelayTime = 10f, bool WeaponEnablePhysic = true)
	{
		_InvokeCallBack?.Invoke(Index, LocationRule, RotationRule, ScaleRule, WeaponDestroyDelayTime, WeaponEnablePhysic);
	}
}
