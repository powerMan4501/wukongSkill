using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_SetHitMoveIgnoreActor_ICB : IFreshAbleGSEvent
{
	private Del_SetHitMoveIgnoreActor _InvokeCallBack;

	private Action<Del_SetHitMoveIgnoreActor> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetHitMoveIgnoreActor _MultiCastDel;

	public GSDel_SetHitMoveIgnoreActor_ICB(Del_SetHitMoveIgnoreActor InvokeCallBack, Action<Del_SetHitMoveIgnoreActor> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetHitMoveIgnoreActor)Delegate.Combine(_MultiCastDel, (Del_SetHitMoveIgnoreActor)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetHitMoveIgnoreActor)Delegate.Remove(_MultiCastDel, (Del_SetHitMoveIgnoreActor)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetHitMoveIgnoreActor_ICB operator +(GSDel_SetHitMoveIgnoreActor_ICB GSEvent, Del_SetHitMoveIgnoreActor Del)
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
		GSEvent._MultiCastDel = (Del_SetHitMoveIgnoreActor)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetHitMoveIgnoreActor_ICB operator -(GSDel_SetHitMoveIgnoreActor_ICB GSEvent, Del_SetHitMoveIgnoreActor Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetHitMoveIgnoreActor == Del)
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
		GSEvent._MultiCastDel = (Del_SetHitMoveIgnoreActor)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor Actor, bool NeedIgnore)
	{
		_InvokeCallBack?.Invoke(Actor, NeedIgnore);
	}
}
