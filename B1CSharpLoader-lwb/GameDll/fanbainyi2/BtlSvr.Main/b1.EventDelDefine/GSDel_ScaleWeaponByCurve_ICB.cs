using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_ScaleWeaponByCurve_ICB : IFreshAbleGSEvent
{
	private Del_ScaleWeaponByCurve _InvokeCallBack;

	private Action<Del_ScaleWeaponByCurve> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ScaleWeaponByCurve _MultiCastDel;

	public GSDel_ScaleWeaponByCurve_ICB(Del_ScaleWeaponByCurve InvokeCallBack, Action<Del_ScaleWeaponByCurve> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ScaleWeaponByCurve)Delegate.Combine(_MultiCastDel, (Del_ScaleWeaponByCurve)Del);
		}
		else
		{
			_MultiCastDel = (Del_ScaleWeaponByCurve)Delegate.Remove(_MultiCastDel, (Del_ScaleWeaponByCurve)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_ScaleWeaponByCurve_ICB operator +(GSDel_ScaleWeaponByCurve_ICB GSEvent, Del_ScaleWeaponByCurve Del)
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
		GSEvent._MultiCastDel = (Del_ScaleWeaponByCurve)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_ScaleWeaponByCurve_ICB operator -(GSDel_ScaleWeaponByCurve_ICB GSEvent, Del_ScaleWeaponByCurve Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ScaleWeaponByCurve == Del)
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
		GSEvent._MultiCastDel = (Del_ScaleWeaponByCurve)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(UCurveVector ScaleCurve)
	{
		_InvokeCallBack?.Invoke(ScaleCurve);
	}
}
