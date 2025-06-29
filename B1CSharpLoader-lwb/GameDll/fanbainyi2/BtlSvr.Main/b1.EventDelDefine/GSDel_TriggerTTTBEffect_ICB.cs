using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_TriggerTTTBEffect_ICB : IFreshAbleGSEvent
{
	private Del_TriggerTTTBEffect _InvokeCallBack;

	private Action<Del_TriggerTTTBEffect> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerTTTBEffect _MultiCastDel;

	public GSDel_TriggerTTTBEffect_ICB(Del_TriggerTTTBEffect InvokeCallBack, Action<Del_TriggerTTTBEffect> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TriggerTTTBEffect)Delegate.Combine(_MultiCastDel, (Del_TriggerTTTBEffect)Del);
		}
		else
		{
			_MultiCastDel = (Del_TriggerTTTBEffect)Delegate.Remove(_MultiCastDel, (Del_TriggerTTTBEffect)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_TriggerTTTBEffect_ICB operator +(GSDel_TriggerTTTBEffect_ICB GSEvent, Del_TriggerTTTBEffect Del)
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
		GSEvent._MultiCastDel = (Del_TriggerTTTBEffect)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_TriggerTTTBEffect_ICB operator -(GSDel_TriggerTTTBEffect_ICB GSEvent, Del_TriggerTTTBEffect Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TriggerTTTBEffect == Del)
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
		GSEvent._MultiCastDel = (Del_TriggerTTTBEffect)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(float Duration, float Strength, FName HitBoneName, FVector HitLocation, FVector HitPointNormalDir, FVector HitDiretionRealDir)
	{
		_InvokeCallBack?.Invoke(Duration, Strength, HitBoneName, HitLocation, HitPointNormalDir, HitDiretionRealDir);
	}
}
