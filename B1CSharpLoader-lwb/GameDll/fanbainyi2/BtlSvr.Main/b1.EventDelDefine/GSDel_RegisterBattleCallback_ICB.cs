using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_RegisterBattleCallback_ICB : IFreshAbleGSEvent
{
	private Del_RegisterBattleCallback _InvokeCallBack;

	private Action<Del_RegisterBattleCallback> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_RegisterBattleCallback _MultiCastDel;

	public GSDel_RegisterBattleCallback_ICB(Del_RegisterBattleCallback InvokeCallBack, Action<Del_RegisterBattleCallback> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_RegisterBattleCallback)Delegate.Combine(_MultiCastDel, (Del_RegisterBattleCallback)Del);
		}
		else
		{
			_MultiCastDel = (Del_RegisterBattleCallback)Delegate.Remove(_MultiCastDel, (Del_RegisterBattleCallback)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_RegisterBattleCallback_ICB operator +(GSDel_RegisterBattleCallback_ICB GSEvent, Del_RegisterBattleCallback Del)
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
		GSEvent._MultiCastDel = (Del_RegisterBattleCallback)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_RegisterBattleCallback_ICB operator -(GSDel_RegisterBattleCallback_ICB GSEvent, Del_RegisterBattleCallback Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_RegisterBattleCallback == Del)
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
		GSEvent._MultiCastDel = (Del_RegisterBattleCallback)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FInputDelegate.InputActionTrigger Callback)
	{
		_InvokeCallBack?.Invoke(Callback);
	}
}
