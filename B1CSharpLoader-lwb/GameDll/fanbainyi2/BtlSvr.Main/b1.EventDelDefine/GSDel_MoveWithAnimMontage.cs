using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_MoveWithAnimMontage : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_MoveWithAnimMontage _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_MoveWithAnimMontage)Delegate.Combine(_MultiCastDel, (Del_MoveWithAnimMontage)Del);
		}
		else
		{
			_MultiCastDel = (Del_MoveWithAnimMontage)Delegate.Remove(_MultiCastDel, (Del_MoveWithAnimMontage)Del);
		}
	}

	public static GSDel_MoveWithAnimMontage operator +(GSDel_MoveWithAnimMontage GSEvent, Del_MoveWithAnimMontage Del)
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
		GSEvent._MultiCastDel = (Del_MoveWithAnimMontage)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_MoveWithAnimMontage operator -(GSDel_MoveWithAnimMontage GSEvent, Del_MoveWithAnimMontage Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_MoveWithAnimMontage == Del)
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
		GSEvent._MultiCastDel = (Del_MoveWithAnimMontage)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(UAnimMontage Montage, float Scale, float PlayTimeRate, float MontagePosOffset, FName StartSectionName, EMontageBindReason Reason = EMontageBindReason.Default)
	{
		_MultiCastDel?.Invoke(Montage, Scale, PlayTimeRate, MontagePosOffset, StartSectionName, Reason);
	}
}
