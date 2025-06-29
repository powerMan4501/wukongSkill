using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_ToggleWeaponsStatus_ByNotifyState_ICB : IFreshAbleGSEvent
{
	private Del_ToggleWeaponsStatus_ByNotifyState _InvokeCallBack;

	private Action<Del_ToggleWeaponsStatus_ByNotifyState> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ToggleWeaponsStatus_ByNotifyState _MultiCastDel;

	public GSDel_ToggleWeaponsStatus_ByNotifyState_ICB(Del_ToggleWeaponsStatus_ByNotifyState InvokeCallBack, Action<Del_ToggleWeaponsStatus_ByNotifyState> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

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
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_ToggleWeaponsStatus_ByNotifyState_ICB operator +(GSDel_ToggleWeaponsStatus_ByNotifyState_ICB GSEvent, Del_ToggleWeaponsStatus_ByNotifyState Del)
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
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_ToggleWeaponsStatus_ByNotifyState_ICB operator -(GSDel_ToggleWeaponsStatus_ByNotifyState_ICB GSEvent, Del_ToggleWeaponsStatus_ByNotifyState Del)
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
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(List<int> WeaponIndexes, bool TriggerActivate, bool NeedOverride, int MontageInstanceID, int NotifyUniqueID)
	{
		_InvokeCallBack?.Invoke(WeaponIndexes, TriggerActivate, NeedOverride, MontageInstanceID, NotifyUniqueID);
	}
}
