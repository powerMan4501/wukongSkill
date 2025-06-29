using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_TriggerMagicFieldEffect_ICB : IFreshAbleGSEvent
{
	private Del_TriggerMagicFieldEffect _InvokeCallBack;

	private Action<Del_TriggerMagicFieldEffect> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerMagicFieldEffect _MultiCastDel;

	public GSDel_TriggerMagicFieldEffect_ICB(Del_TriggerMagicFieldEffect InvokeCallBack, Action<Del_TriggerMagicFieldEffect> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TriggerMagicFieldEffect)Delegate.Combine(_MultiCastDel, (Del_TriggerMagicFieldEffect)Del);
		}
		else
		{
			_MultiCastDel = (Del_TriggerMagicFieldEffect)Delegate.Remove(_MultiCastDel, (Del_TriggerMagicFieldEffect)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_TriggerMagicFieldEffect_ICB operator +(GSDel_TriggerMagicFieldEffect_ICB GSEvent, Del_TriggerMagicFieldEffect Del)
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
		GSEvent._MultiCastDel = (Del_TriggerMagicFieldEffect)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_TriggerMagicFieldEffect_ICB operator -(GSDel_TriggerMagicFieldEffect_ICB GSEvent, Del_TriggerMagicFieldEffect Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TriggerMagicFieldEffect == Del)
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
		GSEvent._MultiCastDel = (Del_TriggerMagicFieldEffect)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor Target, bool bIgnoreFilter, int TargetTeamFilter, int TargetTypeFilter, List<MFEffectForData> MFEffectList)
	{
		_InvokeCallBack?.Invoke(Target, bIgnoreFilter, TargetTeamFilter, TargetTypeFilter, MFEffectList);
	}
}
