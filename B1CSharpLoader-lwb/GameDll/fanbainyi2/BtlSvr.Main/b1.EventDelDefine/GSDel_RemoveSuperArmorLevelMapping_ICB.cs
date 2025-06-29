using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_RemoveSuperArmorLevelMapping_ICB : IFreshAbleGSEvent
{
	private Del_RemoveSuperArmorLevelMapping _InvokeCallBack;

	private Action<Del_RemoveSuperArmorLevelMapping> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_RemoveSuperArmorLevelMapping _MultiCastDel;

	public GSDel_RemoveSuperArmorLevelMapping_ICB(Del_RemoveSuperArmorLevelMapping InvokeCallBack, Action<Del_RemoveSuperArmorLevelMapping> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_RemoveSuperArmorLevelMapping)Delegate.Combine(_MultiCastDel, (Del_RemoveSuperArmorLevelMapping)Del);
		}
		else
		{
			_MultiCastDel = (Del_RemoveSuperArmorLevelMapping)Delegate.Remove(_MultiCastDel, (Del_RemoveSuperArmorLevelMapping)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_RemoveSuperArmorLevelMapping_ICB operator +(GSDel_RemoveSuperArmorLevelMapping_ICB GSEvent, Del_RemoveSuperArmorLevelMapping Del)
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
		GSEvent._MultiCastDel = (Del_RemoveSuperArmorLevelMapping)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_RemoveSuperArmorLevelMapping_ICB operator -(GSDel_RemoveSuperArmorLevelMapping_ICB GSEvent, Del_RemoveSuperArmorLevelMapping Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_RemoveSuperArmorLevelMapping == Del)
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
		GSEvent._MultiCastDel = (Del_RemoveSuperArmorLevelMapping)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int BuffID, string OriginalLevelName)
	{
		_InvokeCallBack?.Invoke(BuffID, OriginalLevelName);
	}
}
