using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_DecreaseAbnormalAccValue_ICB : IFreshAbleGSEvent
{
	private Del_DecreaseAbnormalAccValue _InvokeCallBack;

	private Action<Del_DecreaseAbnormalAccValue> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_DecreaseAbnormalAccValue _MultiCastDel;

	public GSDel_DecreaseAbnormalAccValue_ICB(Del_DecreaseAbnormalAccValue InvokeCallBack, Action<Del_DecreaseAbnormalAccValue> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_DecreaseAbnormalAccValue)Delegate.Combine(_MultiCastDel, (Del_DecreaseAbnormalAccValue)Del);
		}
		else
		{
			_MultiCastDel = (Del_DecreaseAbnormalAccValue)Delegate.Remove(_MultiCastDel, (Del_DecreaseAbnormalAccValue)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_DecreaseAbnormalAccValue_ICB operator +(GSDel_DecreaseAbnormalAccValue_ICB GSEvent, Del_DecreaseAbnormalAccValue Del)
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
		GSEvent._MultiCastDel = (Del_DecreaseAbnormalAccValue)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_DecreaseAbnormalAccValue_ICB operator -(GSDel_DecreaseAbnormalAccValue_ICB GSEvent, Del_DecreaseAbnormalAccValue Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_DecreaseAbnormalAccValue == Del)
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
		GSEvent._MultiCastDel = (Del_DecreaseAbnormalAccValue)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EAbnormalStateType AbnormalType, float DecreaseValue)
	{
		_InvokeCallBack?.Invoke(AbnormalType, DecreaseValue);
	}
}
