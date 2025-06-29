using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_ToggleWeaponsStatus_ByNotifyState : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ToggleWeaponsStatus_ByNotifyState _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ToggleWeaponsStatus_ByNotifyState)Delegate.Combine(_MultiCastDel, (Del_ToggleWeaponsStatus_ByNotifyState)Del);
		}
		else
		{
			_MultiCastDel = (Del_ToggleWeaponsStatus_ByNotifyState)Delegate.Remove(_MultiCastDel, (Del_ToggleWeaponsStatus_ByNotifyState)Del);
		}
	}

	public static GSDel_ToggleWeaponsStatus_ByNotifyState operator +(GSDel_ToggleWeaponsStatus_ByNotifyState GSEvent, Del_ToggleWeaponsStatus_ByNotifyState Del)
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
		GSEvent._MultiCastDel = (Del_ToggleWeaponsStatus_ByNotifyState)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_ToggleWeaponsStatus_ByNotifyState operator -(GSDel_ToggleWeaponsStatus_ByNotifyState GSEvent, Del_ToggleWeaponsStatus_ByNotifyState Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ToggleWeaponsStatus_ByNotifyState == Del)
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
		GSEvent._MultiCastDel = (Del_ToggleWeaponsStatus_ByNotifyState)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(List<int> WeaponIndexes, bool TriggerActivate, bool NeedOverride, int MontageInstanceID, int NotifyUniqueID)
	{
		_MultiCastDel?.Invoke(WeaponIndexes, TriggerActivate, NeedOverride, MontageInstanceID, NotifyUniqueID);
	}
}
