using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SetSuperUserInputMode_ICB : IFreshAbleGSEvent
{
	private Del_SetSuperUserInputMode _InvokeCallBack;

	private Action<Del_SetSuperUserInputMode> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetSuperUserInputMode _MultiCastDel;

	public GSDel_SetSuperUserInputMode_ICB(Del_SetSuperUserInputMode InvokeCallBack, Action<Del_SetSuperUserInputMode> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetSuperUserInputMode)Delegate.Combine(_MultiCastDel, (Del_SetSuperUserInputMode)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetSuperUserInputMode)Delegate.Remove(_MultiCastDel, (Del_SetSuperUserInputMode)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetSuperUserInputMode_ICB operator +(GSDel_SetSuperUserInputMode_ICB GSEvent, Del_SetSuperUserInputMode Del)
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
		GSEvent._MultiCastDel = (Del_SetSuperUserInputMode)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetSuperUserInputMode_ICB operator -(GSDel_SetSuperUserInputMode_ICB GSEvent, Del_SetSuperUserInputMode Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetSuperUserInputMode == Del)
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
		GSEvent._MultiCastDel = (Del_SetSuperUserInputMode)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(bool IsRequest, EGSInputModeChangeReason ChangeReason)
	{
		_InvokeCallBack?.Invoke(IsRequest, ChangeReason);
	}
}
