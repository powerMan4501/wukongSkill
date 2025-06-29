using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_ObjectActorSetVelocity_ICB : IFreshAbleGSEvent
{
	private Del_ObjectActorSetVelocity _InvokeCallBack;

	private Action<Del_ObjectActorSetVelocity> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ObjectActorSetVelocity _MultiCastDel;

	public GSDel_ObjectActorSetVelocity_ICB(Del_ObjectActorSetVelocity InvokeCallBack, Action<Del_ObjectActorSetVelocity> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ObjectActorSetVelocity)Delegate.Combine(_MultiCastDel, (Del_ObjectActorSetVelocity)Del);
		}
		else
		{
			_MultiCastDel = (Del_ObjectActorSetVelocity)Delegate.Remove(_MultiCastDel, (Del_ObjectActorSetVelocity)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_ObjectActorSetVelocity_ICB operator +(GSDel_ObjectActorSetVelocity_ICB GSEvent, Del_ObjectActorSetVelocity Del)
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
		GSEvent._MultiCastDel = (Del_ObjectActorSetVelocity)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_ObjectActorSetVelocity_ICB operator -(GSDel_ObjectActorSetVelocity_ICB GSEvent, Del_ObjectActorSetVelocity Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ObjectActorSetVelocity == Del)
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
		GSEvent._MultiCastDel = (Del_ObjectActorSetVelocity)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FVector Velocity)
	{
		_InvokeCallBack?.Invoke(Velocity);
	}
}
