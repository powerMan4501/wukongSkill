using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_DisplayDamageNumUI_ICB : IFreshAbleGSEvent
{
	private Del_DisplayDamageNumUI _InvokeCallBack;

	private Action<Del_DisplayDamageNumUI> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_DisplayDamageNumUI _MultiCastDel;

	public GSDel_DisplayDamageNumUI_ICB(Del_DisplayDamageNumUI InvokeCallBack, Action<Del_DisplayDamageNumUI> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_DisplayDamageNumUI)Delegate.Combine(_MultiCastDel, (Del_DisplayDamageNumUI)Del);
		}
		else
		{
			_MultiCastDel = (Del_DisplayDamageNumUI)Delegate.Remove(_MultiCastDel, (Del_DisplayDamageNumUI)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_DisplayDamageNumUI_ICB operator +(GSDel_DisplayDamageNumUI_ICB GSEvent, Del_DisplayDamageNumUI Del)
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
		GSEvent._MultiCastDel = (Del_DisplayDamageNumUI)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_DisplayDamageNumUI_ICB operator -(GSDel_DisplayDamageNumUI_ICB GSEvent, Del_DisplayDamageNumUI Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_DisplayDamageNumUI == Del)
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
		GSEvent._MultiCastDel = (Del_DisplayDamageNumUI)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(string DamageNumber, EDamageNumberType DamageType, FVector HitLocation, bool AnimNeedFast)
	{
		_InvokeCallBack?.Invoke(DamageNumber, DamageType, HitLocation, AnimNeedFast);
	}
}
