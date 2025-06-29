using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_Void_FNameActorFloatVector_ICB : IFreshAbleGSEvent
{
	private Del_Void_FNameActorFloatVector _InvokeCallBack;

	private Action<Del_Void_FNameActorFloatVector> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_Void_FNameActorFloatVector _MultiCastDel;

	public GSDel_Void_FNameActorFloatVector_ICB(Del_Void_FNameActorFloatVector InvokeCallBack, Action<Del_Void_FNameActorFloatVector> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_Void_FNameActorFloatVector)Delegate.Combine(_MultiCastDel, (Del_Void_FNameActorFloatVector)Del);
		}
		else
		{
			_MultiCastDel = (Del_Void_FNameActorFloatVector)Delegate.Remove(_MultiCastDel, (Del_Void_FNameActorFloatVector)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_Void_FNameActorFloatVector_ICB operator +(GSDel_Void_FNameActorFloatVector_ICB GSEvent, Del_Void_FNameActorFloatVector Del)
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
		GSEvent._MultiCastDel = (Del_Void_FNameActorFloatVector)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_Void_FNameActorFloatVector_ICB operator -(GSDel_Void_FNameActorFloatVector_ICB GSEvent, Del_Void_FNameActorFloatVector Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_Void_FNameActorFloatVector == Del)
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
		GSEvent._MultiCastDel = (Del_Void_FNameActorFloatVector)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FName P1, AActor P2, float P3, FVector P4)
	{
		_InvokeCallBack?.Invoke(P1, P2, P3, P4);
	}
}
