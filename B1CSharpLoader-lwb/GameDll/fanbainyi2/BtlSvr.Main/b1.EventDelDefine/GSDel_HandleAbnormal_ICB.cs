using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_HandleAbnormal_ICB : IFreshAbleGSEvent
{
	private Del_HandleAbnormal _InvokeCallBack;

	private Action<Del_HandleAbnormal> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_HandleAbnormal _MultiCastDel;

	public GSDel_HandleAbnormal_ICB(Del_HandleAbnormal InvokeCallBack, Action<Del_HandleAbnormal> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_HandleAbnormal)Delegate.Combine(_MultiCastDel, (Del_HandleAbnormal)Del);
		}
		else
		{
			_MultiCastDel = (Del_HandleAbnormal)Delegate.Remove(_MultiCastDel, (Del_HandleAbnormal)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_HandleAbnormal_ICB operator +(GSDel_HandleAbnormal_ICB GSEvent, Del_HandleAbnormal Del)
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
		GSEvent._MultiCastDel = (Del_HandleAbnormal)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_HandleAbnormal_ICB operator -(GSDel_HandleAbnormal_ICB GSEvent, Del_HandleAbnormal Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_HandleAbnormal == Del)
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
		GSEvent._MultiCastDel = (Del_HandleAbnormal)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EAbnormalStateType AbnormalType, AActor Attacker, EAccAbnormalValueType AccType, float IncreaseValue, int AbnormalLevel)
	{
		_InvokeCallBack?.Invoke(AbnormalType, Attacker, AccType, IncreaseValue, AbnormalLevel);
	}
}
