using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SetSuperArmorLevelMapping_ICB : IFreshAbleGSEvent
{
	private Del_SetSuperArmorLevelMapping _InvokeCallBack;

	private Action<Del_SetSuperArmorLevelMapping> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetSuperArmorLevelMapping _MultiCastDel;

	public GSDel_SetSuperArmorLevelMapping_ICB(Del_SetSuperArmorLevelMapping InvokeCallBack, Action<Del_SetSuperArmorLevelMapping> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetSuperArmorLevelMapping)Delegate.Combine(_MultiCastDel, (Del_SetSuperArmorLevelMapping)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetSuperArmorLevelMapping)Delegate.Remove(_MultiCastDel, (Del_SetSuperArmorLevelMapping)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetSuperArmorLevelMapping_ICB operator +(GSDel_SetSuperArmorLevelMapping_ICB GSEvent, Del_SetSuperArmorLevelMapping Del)
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
		GSEvent._MultiCastDel = (Del_SetSuperArmorLevelMapping)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetSuperArmorLevelMapping_ICB operator -(GSDel_SetSuperArmorLevelMapping_ICB GSEvent, Del_SetSuperArmorLevelMapping Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetSuperArmorLevelMapping == Del)
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
		GSEvent._MultiCastDel = (Del_SetSuperArmorLevelMapping)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int BuffID, string OriginalLevelName, string TargetLevelName, float ValueIntervalMin, float ValueIntervalMax, float ValueBias)
	{
		_InvokeCallBack?.Invoke(BuffID, OriginalLevelName, TargetLevelName, ValueIntervalMin, ValueIntervalMax, ValueBias);
	}
}
