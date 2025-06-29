using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_ToggleWeaponsStatus_ByEffect : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ToggleWeaponsStatus_ByEffect _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ToggleWeaponsStatus_ByEffect)Delegate.Combine(_MultiCastDel, (Del_ToggleWeaponsStatus_ByEffect)Del);
		}
		else
		{
			_MultiCastDel = (Del_ToggleWeaponsStatus_ByEffect)Delegate.Remove(_MultiCastDel, (Del_ToggleWeaponsStatus_ByEffect)Del);
		}
	}

	public static GSDel_ToggleWeaponsStatus_ByEffect operator +(GSDel_ToggleWeaponsStatus_ByEffect GSEvent, Del_ToggleWeaponsStatus_ByEffect Del)
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
		GSEvent._MultiCastDel = (Del_ToggleWeaponsStatus_ByEffect)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_ToggleWeaponsStatus_ByEffect operator -(GSDel_ToggleWeaponsStatus_ByEffect GSEvent, Del_ToggleWeaponsStatus_ByEffect Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ToggleWeaponsStatus_ByEffect == Del)
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
		GSEvent._MultiCastDel = (Del_ToggleWeaponsStatus_ByEffect)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(List<int> WeaponIndexes, bool TriggerActivate, bool NeedOverride, int FlagID1, int FlagID2, bool Reset2Default)
	{
		_MultiCastDel?.Invoke(WeaponIndexes, TriggerActivate, NeedOverride, FlagID1, FlagID2, Reset2Default);
	}
}
