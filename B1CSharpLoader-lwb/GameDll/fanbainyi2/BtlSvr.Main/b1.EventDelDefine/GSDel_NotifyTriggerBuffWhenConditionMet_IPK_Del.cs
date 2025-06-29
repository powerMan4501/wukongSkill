using System;
using System.Collections.Generic;
using b1.ECS;
using b1.Prediction;
using BtlShare;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_NotifyTriggerBuffWhenConditionMet_IPK_Del : IFreshAbleGSEvent
{
	public delegate void Del_Predict(EBuffEffectTriggerType TriggerType, in FEffectInstReq EffectInstReq, AActor Victim, GSPredictionKey PredictionKey);

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_Predict _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_Predict)Delegate.Combine(_MultiCastDel, (Del_Predict)Del);
		}
		else
		{
			_MultiCastDel = (Del_Predict)Delegate.Remove(_MultiCastDel, (Del_Predict)Del);
		}
	}

	public static GSDel_NotifyTriggerBuffWhenConditionMet_IPK_Del operator +(GSDel_NotifyTriggerBuffWhenConditionMet_IPK_Del GSEvent, Del_Predict Del)
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
		GSEvent._MultiCastDel = (Del_Predict)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_NotifyTriggerBuffWhenConditionMet_IPK_Del operator -(GSDel_NotifyTriggerBuffWhenConditionMet_IPK_Del GSEvent, Del_Predict Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_Predict == Del)
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
		GSEvent._MultiCastDel = (Del_Predict)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(EBuffEffectTriggerType TriggerType, in FEffectInstReq EffectInstReq = default(FEffectInstReq), AActor Victim = null, GSPredictionKey PredictionKey = null)
	{
		_MultiCastDel?.Invoke(TriggerType, in EffectInstReq, Victim, PredictionKey);
	}
}
