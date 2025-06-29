using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SwitchMoveAIType_ICB : IFreshAbleGSEvent
{
	private Del_SwitchMoveAIType _InvokeCallBack;

	private Action<Del_SwitchMoveAIType> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SwitchMoveAIType _MultiCastDel;

	public GSDel_SwitchMoveAIType_ICB(Del_SwitchMoveAIType InvokeCallBack, Action<Del_SwitchMoveAIType> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SwitchMoveAIType)Delegate.Combine(_MultiCastDel, (Del_SwitchMoveAIType)Del);
		}
		else
		{
			_MultiCastDel = (Del_SwitchMoveAIType)Delegate.Remove(_MultiCastDel, (Del_SwitchMoveAIType)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SwitchMoveAIType_ICB operator +(GSDel_SwitchMoveAIType_ICB GSEvent, Del_SwitchMoveAIType Del)
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
		GSEvent._MultiCastDel = (Del_SwitchMoveAIType)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SwitchMoveAIType_ICB operator -(GSDel_SwitchMoveAIType_ICB GSEvent, Del_SwitchMoveAIType Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SwitchMoveAIType == Del)
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
		GSEvent._MultiCastDel = (Del_SwitchMoveAIType)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EBGUMoveAIType MoveAIType)
	{
		_InvokeCallBack?.Invoke(MoveAIType);
	}
}
