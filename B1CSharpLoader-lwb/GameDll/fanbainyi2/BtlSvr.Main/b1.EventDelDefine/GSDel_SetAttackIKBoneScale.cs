using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_SetAttackIKBoneScale : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetAttackIKBoneScale _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetAttackIKBoneScale)Delegate.Combine(_MultiCastDel, (Del_SetAttackIKBoneScale)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetAttackIKBoneScale)Delegate.Remove(_MultiCastDel, (Del_SetAttackIKBoneScale)Del);
		}
	}

	public static GSDel_SetAttackIKBoneScale operator +(GSDel_SetAttackIKBoneScale GSEvent, Del_SetAttackIKBoneScale Del)
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
		GSEvent._MultiCastDel = (Del_SetAttackIKBoneScale)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_SetAttackIKBoneScale operator -(GSDel_SetAttackIKBoneScale GSEvent, Del_SetAttackIKBoneScale Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetAttackIKBoneScale == Del)
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
		GSEvent._MultiCastDel = (Del_SetAttackIKBoneScale)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(AActor Actor, bool InBoneScaleEnable, FAttackIKBoneScale InBoneScaleData)
	{
		_MultiCastDel?.Invoke(Actor, InBoneScaleEnable, InBoneScaleData);
	}
}
