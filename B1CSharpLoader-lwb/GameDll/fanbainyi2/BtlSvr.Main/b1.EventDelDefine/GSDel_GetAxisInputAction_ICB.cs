using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_GetAxisInputAction_ICB : IFreshAbleGSEvent
{
	private Del_GetAxisInputAction _InvokeCallBack;

	private Action<Del_GetAxisInputAction> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_GetAxisInputAction _MultiCastDel;

	public GSDel_GetAxisInputAction_ICB(Del_GetAxisInputAction InvokeCallBack, Action<Del_GetAxisInputAction> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_GetAxisInputAction)Delegate.Combine(_MultiCastDel, (Del_GetAxisInputAction)Del);
		}
		else
		{
			_MultiCastDel = (Del_GetAxisInputAction)Delegate.Remove(_MultiCastDel, (Del_GetAxisInputAction)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_GetAxisInputAction_ICB operator +(GSDel_GetAxisInputAction_ICB GSEvent, Del_GetAxisInputAction Del)
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
		GSEvent._MultiCastDel = (Del_GetAxisInputAction)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_GetAxisInputAction_ICB operator -(GSDel_GetAxisInputAction_ICB GSEvent, Del_GetAxisInputAction Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_GetAxisInputAction == Del)
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
		GSEvent._MultiCastDel = (Del_GetAxisInputAction)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public List<GSBattleActionEn> Invoke()
	{
		if (_InvokeCallBack == null)
		{
			return null;
		}
		return _InvokeCallBack();
	}
}
