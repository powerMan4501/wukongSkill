using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_HandleWeaponDetach_ICB : IFreshAbleGSEvent
{
	private Del_HandleWeaponDetach _InvokeCallBack;

	private Action<Del_HandleWeaponDetach> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_HandleWeaponDetach _MultiCastDel;

	public GSDel_HandleWeaponDetach_ICB(Del_HandleWeaponDetach InvokeCallBack, Action<Del_HandleWeaponDetach> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

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
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_HandleWeaponDetach_ICB operator +(GSDel_HandleWeaponDetach_ICB GSEvent, Del_HandleWeaponDetach Del)
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
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_HandleWeaponDetach_ICB operator -(GSDel_HandleWeaponDetach_ICB GSEvent, Del_HandleWeaponDetach Del)
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
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EDetachmentRule LocationRule, EDetachmentRule RotationRule, EDetachmentRule ScaleRule, float DestroyDelayTime, bool WeaponEnablePhysic)
	{
		_InvokeCallBack?.Invoke(LocationRule, RotationRule, ScaleRule, DestroyDelayTime, WeaponEnablePhysic);
	}
}
