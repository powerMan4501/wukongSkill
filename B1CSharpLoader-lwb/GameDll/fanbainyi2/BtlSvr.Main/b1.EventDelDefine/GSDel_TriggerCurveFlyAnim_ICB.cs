using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_TriggerCurveFlyAnim_ICB : IFreshAbleGSEvent
{
	private Del_TriggerCurveFlyAnim _InvokeCallBack;

	private Action<Del_TriggerCurveFlyAnim> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerCurveFlyAnim _MultiCastDel;

	public GSDel_TriggerCurveFlyAnim_ICB(Del_TriggerCurveFlyAnim InvokeCallBack, Action<Del_TriggerCurveFlyAnim> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TriggerCurveFlyAnim)Delegate.Combine(_MultiCastDel, (Del_TriggerCurveFlyAnim)Del);
		}
		else
		{
			_MultiCastDel = (Del_TriggerCurveFlyAnim)Delegate.Remove(_MultiCastDel, (Del_TriggerCurveFlyAnim)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_TriggerCurveFlyAnim_ICB operator +(GSDel_TriggerCurveFlyAnim_ICB GSEvent, Del_TriggerCurveFlyAnim Del)
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
		GSEvent._MultiCastDel = (Del_TriggerCurveFlyAnim)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_TriggerCurveFlyAnim_ICB operator -(GSDel_TriggerCurveFlyAnim_ICB GSEvent, Del_TriggerCurveFlyAnim Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TriggerCurveFlyAnim == Del)
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
		GSEvent._MultiCastDel = (Del_TriggerCurveFlyAnim)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FVector StartPosition, float ChangeValue)
	{
		_InvokeCallBack?.Invoke(StartPosition, ChangeValue);
	}
}
