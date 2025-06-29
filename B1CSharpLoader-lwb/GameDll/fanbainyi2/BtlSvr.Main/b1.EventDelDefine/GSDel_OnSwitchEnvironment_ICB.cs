using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_OnSwitchEnvironment_ICB : IFreshAbleGSEvent
{
	private Del_OnSwitchEnvironment _InvokeCallBack;

	private Action<Del_OnSwitchEnvironment> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnSwitchEnvironment _MultiCastDel;

	public GSDel_OnSwitchEnvironment_ICB(Del_OnSwitchEnvironment InvokeCallBack, Action<Del_OnSwitchEnvironment> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnSwitchEnvironment)Delegate.Combine(_MultiCastDel, (Del_OnSwitchEnvironment)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnSwitchEnvironment)Delegate.Remove(_MultiCastDel, (Del_OnSwitchEnvironment)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_OnSwitchEnvironment_ICB operator +(GSDel_OnSwitchEnvironment_ICB GSEvent, Del_OnSwitchEnvironment Del)
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
		GSEvent._MultiCastDel = (Del_OnSwitchEnvironment)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_OnSwitchEnvironment_ICB operator -(GSDel_OnSwitchEnvironment_ICB GSEvent, Del_OnSwitchEnvironment Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnSwitchEnvironment == Del)
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
		GSEvent._MultiCastDel = (Del_OnSwitchEnvironment)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor Actor, string LevelSequencePath, float AddtiveTargetPercentage)
	{
		_InvokeCallBack?.Invoke(Actor, LevelSequencePath, AddtiveTargetPercentage);
	}
}
