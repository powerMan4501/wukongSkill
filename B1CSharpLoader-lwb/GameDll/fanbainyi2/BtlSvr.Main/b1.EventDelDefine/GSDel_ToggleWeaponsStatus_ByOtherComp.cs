using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_ToggleWeaponsStatus_ByOtherComp : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ToggleWeaponsStatus_ByOtherComp _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ToggleWeaponsStatus_ByOtherComp)Delegate.Combine(_MultiCastDel, (Del_ToggleWeaponsStatus_ByOtherComp)Del);
		}
		else
		{
			_MultiCastDel = (Del_ToggleWeaponsStatus_ByOtherComp)Delegate.Remove(_MultiCastDel, (Del_ToggleWeaponsStatus_ByOtherComp)Del);
		}
	}

	public static GSDel_ToggleWeaponsStatus_ByOtherComp operator +(GSDel_ToggleWeaponsStatus_ByOtherComp GSEvent, Del_ToggleWeaponsStatus_ByOtherComp Del)
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
		GSEvent._MultiCastDel = (Del_ToggleWeaponsStatus_ByOtherComp)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_ToggleWeaponsStatus_ByOtherComp operator -(GSDel_ToggleWeaponsStatus_ByOtherComp GSEvent, Del_ToggleWeaponsStatus_ByOtherComp Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ToggleWeaponsStatus_ByOtherComp == Del)
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
		GSEvent._MultiCastDel = (Del_ToggleWeaponsStatus_ByOtherComp)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(List<int> WeaponIndexes, bool TriggerActivate, bool NeedOverride, EToggleWeaponStatusCompType CompType)
	{
		_MultiCastDel?.Invoke(WeaponIndexes, TriggerActivate, NeedOverride, CompType);
	}
}
