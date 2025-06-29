using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_FireImpulseLikeRadialForceComp_ICB : IFreshAbleGSEvent
{
	private Del_FireImpulseLikeRadialForceComp _InvokeCallBack;

	private Action<Del_FireImpulseLikeRadialForceComp> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_FireImpulseLikeRadialForceComp _MultiCastDel;

	public GSDel_FireImpulseLikeRadialForceComp_ICB(Del_FireImpulseLikeRadialForceComp InvokeCallBack, Action<Del_FireImpulseLikeRadialForceComp> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_FireImpulseLikeRadialForceComp)Delegate.Combine(_MultiCastDel, (Del_FireImpulseLikeRadialForceComp)Del);
		}
		else
		{
			_MultiCastDel = (Del_FireImpulseLikeRadialForceComp)Delegate.Remove(_MultiCastDel, (Del_FireImpulseLikeRadialForceComp)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_FireImpulseLikeRadialForceComp_ICB operator +(GSDel_FireImpulseLikeRadialForceComp_ICB GSEvent, Del_FireImpulseLikeRadialForceComp Del)
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
		GSEvent._MultiCastDel = (Del_FireImpulseLikeRadialForceComp)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_FireImpulseLikeRadialForceComp_ICB operator -(GSDel_FireImpulseLikeRadialForceComp_ICB GSEvent, Del_FireImpulseLikeRadialForceComp Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_FireImpulseLikeRadialForceComp == Del)
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
		GSEvent._MultiCastDel = (Del_FireImpulseLikeRadialForceComp)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor OwnerActor, EPhysicsForceType PhysicsForceType, float ForceFieldSize, FVector ForceFieldOffset, float DestructibleDamage, float ImpulseStrength, List<EObjectTypeQuery> QueryObjectTypes, float forceDuration, bool IsDrawDebugShape = false)
	{
		_InvokeCallBack?.Invoke(OwnerActor, PhysicsForceType, ForceFieldSize, ForceFieldOffset, DestructibleDamage, ImpulseStrength, QueryObjectTypes, forceDuration, IsDrawDebugShape);
	}
}
