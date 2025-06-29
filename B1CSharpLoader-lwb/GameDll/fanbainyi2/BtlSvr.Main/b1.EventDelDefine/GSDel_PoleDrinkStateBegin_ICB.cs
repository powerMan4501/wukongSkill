using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_PoleDrinkStateBegin_ICB : IFreshAbleGSEvent
{
	private Del_PoleDrinkStateBegin _InvokeCallBack;

	private Action<Del_PoleDrinkStateBegin> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_PoleDrinkStateBegin _MultiCastDel;

	public GSDel_PoleDrinkStateBegin_ICB(Del_PoleDrinkStateBegin InvokeCallBack, Action<Del_PoleDrinkStateBegin> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_PoleDrinkStateBegin)Delegate.Combine(_MultiCastDel, (Del_PoleDrinkStateBegin)Del);
		}
		else
		{
			_MultiCastDel = (Del_PoleDrinkStateBegin)Delegate.Remove(_MultiCastDel, (Del_PoleDrinkStateBegin)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_PoleDrinkStateBegin_ICB operator +(GSDel_PoleDrinkStateBegin_ICB GSEvent, Del_PoleDrinkStateBegin Del)
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
		GSEvent._MultiCastDel = (Del_PoleDrinkStateBegin)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_PoleDrinkStateBegin_ICB operator -(GSDel_PoleDrinkStateBegin_ICB GSEvent, Del_PoleDrinkStateBegin Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_PoleDrinkStateBegin == Del)
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
		GSEvent._MultiCastDel = (Del_PoleDrinkStateBegin)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(UAnimMontage SuccessAM, UAnimMontage FailedAM, TMapReadWrite<int, UAnimMontage> UseItemAMMapping)
	{
		_InvokeCallBack?.Invoke(SuccessAM, FailedAM, UseItemAMMapping);
	}
}
