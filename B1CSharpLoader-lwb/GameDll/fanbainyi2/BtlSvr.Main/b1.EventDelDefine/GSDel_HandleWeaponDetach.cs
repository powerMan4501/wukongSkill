using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_HandleWeaponDetach : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_HandleWeaponDetach _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_HandleWeaponDetach)Delegate.Combine(_MultiCastDel, (Del_HandleWeaponDetach)Del);
		}
		else
		{
			_MultiCastDel = (Del_HandleWeaponDetach)Delegate.Remove(_MultiCastDel, (Del_HandleWeaponDetach)Del);
		}
	}

	public static GSDel_HandleWeaponDetach operator +(GSDel_HandleWeaponDetach GSEvent, Del_HandleWeaponDetach Del)
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
		GSEvent._MultiCastDel = (Del_HandleWeaponDetach)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_HandleWeaponDetach operator -(GSDel_HandleWeaponDetach GSEvent, Del_HandleWeaponDetach Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_HandleWeaponDetach == Del)
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
		GSEvent._MultiCastDel = (Del_HandleWeaponDetach)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(EDetachmentRule LocationRule, EDetachmentRule RotationRule, EDetachmentRule ScaleRule, float DestroyDelayTime, bool WeaponEnablePhysic)
	{
		_MultiCastDel?.Invoke(LocationRule, RotationRule, ScaleRule, DestroyDelayTime, WeaponEnablePhysic);
	}
}
