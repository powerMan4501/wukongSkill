using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_Void_ActorActorFloat_ICB : IFreshAbleGSEvent
{
	private Del_Void_ActorActorFloat _InvokeCallBack;

	private Action<Del_Void_ActorActorFloat> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_Void_ActorActorFloat _MultiCastDel;

	public GSDel_Void_ActorActorFloat_ICB(Del_Void_ActorActorFloat InvokeCallBack, Action<Del_Void_ActorActorFloat> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_Void_ActorActorFloat)Delegate.Combine(_MultiCastDel, (Del_Void_ActorActorFloat)Del);
		}
		else
		{
			_MultiCastDel = (Del_Void_ActorActorFloat)Delegate.Remove(_MultiCastDel, (Del_Void_ActorActorFloat)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_Void_ActorActorFloat_ICB operator +(GSDel_Void_ActorActorFloat_ICB GSEvent, Del_Void_ActorActorFloat Del)
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
		GSEvent._MultiCastDel = (Del_Void_ActorActorFloat)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_Void_ActorActorFloat_ICB operator -(GSDel_Void_ActorActorFloat_ICB GSEvent, Del_Void_ActorActorFloat Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_Void_ActorActorFloat == Del)
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
		GSEvent._MultiCastDel = (Del_Void_ActorActorFloat)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor Actor1, AActor Actor2, float P1)
	{
		_InvokeCallBack?.Invoke(Actor1, Actor2, P1);
	}
}
