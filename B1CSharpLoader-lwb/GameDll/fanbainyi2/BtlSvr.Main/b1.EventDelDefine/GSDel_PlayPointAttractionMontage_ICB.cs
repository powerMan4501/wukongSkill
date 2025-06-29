using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_PlayPointAttractionMontage_ICB : IFreshAbleGSEvent
{
	private Del_PlayPointAttractionMontage _InvokeCallBack;

	private Action<Del_PlayPointAttractionMontage> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_PlayPointAttractionMontage _MultiCastDel;

	public GSDel_PlayPointAttractionMontage_ICB(Del_PlayPointAttractionMontage InvokeCallBack, Action<Del_PlayPointAttractionMontage> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_PlayPointAttractionMontage)Delegate.Combine(_MultiCastDel, (Del_PlayPointAttractionMontage)Del);
		}
		else
		{
			_MultiCastDel = (Del_PlayPointAttractionMontage)Delegate.Remove(_MultiCastDel, (Del_PlayPointAttractionMontage)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_PlayPointAttractionMontage_ICB operator +(GSDel_PlayPointAttractionMontage_ICB GSEvent, Del_PlayPointAttractionMontage Del)
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
		GSEvent._MultiCastDel = (Del_PlayPointAttractionMontage)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_PlayPointAttractionMontage_ICB operator -(GSDel_PlayPointAttractionMontage_ICB GSEvent, Del_PlayPointAttractionMontage Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_PlayPointAttractionMontage == Del)
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
		GSEvent._MultiCastDel = (Del_PlayPointAttractionMontage)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor Attacker, int AttackStiffEffectID, FVector AttractionLocation, EAttackerArea AttractionArea)
	{
		_InvokeCallBack?.Invoke(Attacker, AttackStiffEffectID, AttractionLocation, AttractionArea);
	}
}
