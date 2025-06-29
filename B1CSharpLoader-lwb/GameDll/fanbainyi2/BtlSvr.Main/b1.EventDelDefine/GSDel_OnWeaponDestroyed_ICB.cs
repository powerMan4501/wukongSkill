using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_OnWeaponDestroyed_ICB : IFreshAbleGSEvent
{
	private Del_OnWeaponDestroyed _InvokeCallBack;

	private Action<Del_OnWeaponDestroyed> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnWeaponDestroyed _MultiCastDel;

	public GSDel_OnWeaponDestroyed_ICB(Del_OnWeaponDestroyed InvokeCallBack, Action<Del_OnWeaponDestroyed> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnWeaponDestroyed)Delegate.Combine(_MultiCastDel, (Del_OnWeaponDestroyed)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnWeaponDestroyed)Delegate.Remove(_MultiCastDel, (Del_OnWeaponDestroyed)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_OnWeaponDestroyed_ICB operator +(GSDel_OnWeaponDestroyed_ICB GSEvent, Del_OnWeaponDestroyed Del)
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
		GSEvent._MultiCastDel = (Del_OnWeaponDestroyed)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_OnWeaponDestroyed_ICB operator -(GSDel_OnWeaponDestroyed_ICB GSEvent, Del_OnWeaponDestroyed Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnWeaponDestroyed == Del)
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
		GSEvent._MultiCastDel = (Del_OnWeaponDestroyed)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(BGUWeaponBase Weapon)
	{
		_InvokeCallBack?.Invoke(Weapon);
	}
}
