using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_AISpiderMoveTo : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_AISpiderMoveTo _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_AISpiderMoveTo)Delegate.Combine(_MultiCastDel, (Del_AISpiderMoveTo)Del);
		}
		else
		{
			_MultiCastDel = (Del_AISpiderMoveTo)Delegate.Remove(_MultiCastDel, (Del_AISpiderMoveTo)Del);
		}
	}

	public static GSDel_AISpiderMoveTo operator +(GSDel_AISpiderMoveTo GSEvent, Del_AISpiderMoveTo Del)
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
		GSEvent._MultiCastDel = (Del_AISpiderMoveTo)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_AISpiderMoveTo operator -(GSDel_AISpiderMoveTo GSEvent, Del_AISpiderMoveTo Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_AISpiderMoveTo == Del)
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
		GSEvent._MultiCastDel = (Del_AISpiderMoveTo)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(FVector TargetPos, FVector TargetNormal, ESpiderNavPositionType TargetPosType, float AcceptableRadius, EAIMoveSpeedType SplineMoveSpeed)
	{
		_MultiCastDel?.Invoke(TargetPos, TargetNormal, TargetPosType, AcceptableRadius, SplineMoveSpeed);
	}
}
