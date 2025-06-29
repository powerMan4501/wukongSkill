using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_SimpleOverlapActorsByMask_ICB : IFreshAbleGSEvent
{
	private Del_SimpleOverlapActorsByMask _InvokeCallBack;

	private Action<Del_SimpleOverlapActorsByMask> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SimpleOverlapActorsByMask _MultiCastDel;

	public GSDel_SimpleOverlapActorsByMask_ICB(Del_SimpleOverlapActorsByMask InvokeCallBack, Action<Del_SimpleOverlapActorsByMask> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SimpleOverlapActorsByMask)Delegate.Combine(_MultiCastDel, (Del_SimpleOverlapActorsByMask)Del);
		}
		else
		{
			_MultiCastDel = (Del_SimpleOverlapActorsByMask)Delegate.Remove(_MultiCastDel, (Del_SimpleOverlapActorsByMask)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SimpleOverlapActorsByMask_ICB operator +(GSDel_SimpleOverlapActorsByMask_ICB GSEvent, Del_SimpleOverlapActorsByMask Del)
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
		GSEvent._MultiCastDel = (Del_SimpleOverlapActorsByMask)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SimpleOverlapActorsByMask_ICB operator -(GSDel_SimpleOverlapActorsByMask_ICB GSEvent, Del_SimpleOverlapActorsByMask Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SimpleOverlapActorsByMask == Del)
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
		GSEvent._MultiCastDel = (Del_SimpleOverlapActorsByMask)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public bool Invoke(AActor Owner, List<int> Masks, float SphereRadius, float SquareSize, bool IsSphere, out List<AActor> OutActor)
	{
		OutActor = null;
		if (_InvokeCallBack == null)
		{
			return false;
		}
		return _InvokeCallBack(Owner, Masks, SphereRadius, SquareSize, IsSphere, out OutActor);
	}
}
