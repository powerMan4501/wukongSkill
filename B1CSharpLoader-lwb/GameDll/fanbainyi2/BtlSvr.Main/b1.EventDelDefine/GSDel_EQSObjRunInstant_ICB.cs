using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_EQSObjRunInstant_ICB : IFreshAbleGSEvent
{
	private Del_EQSObjRunInstant _InvokeCallBack;

	private Action<Del_EQSObjRunInstant> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_EQSObjRunInstant _MultiCastDel;

	public GSDel_EQSObjRunInstant_ICB(Del_EQSObjRunInstant InvokeCallBack, Action<Del_EQSObjRunInstant> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_EQSObjRunInstant)Delegate.Combine(_MultiCastDel, (Del_EQSObjRunInstant)Del);
		}
		else
		{
			_MultiCastDel = (Del_EQSObjRunInstant)Delegate.Remove(_MultiCastDel, (Del_EQSObjRunInstant)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_EQSObjRunInstant_ICB operator +(GSDel_EQSObjRunInstant_ICB GSEvent, Del_EQSObjRunInstant Del)
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
		GSEvent._MultiCastDel = (Del_EQSObjRunInstant)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_EQSObjRunInstant_ICB operator -(GSDel_EQSObjRunInstant_ICB GSEvent, Del_EQSObjRunInstant Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_EQSObjRunInstant == Del)
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
		GSEvent._MultiCastDel = (Del_EQSObjRunInstant)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(UEnvQuery EnvQueryObj, AActor Querier, out List<FVector> Locations, out List<float> Scores)
	{
		Locations = null;
		Scores = null;
		_InvokeCallBack?.Invoke(EnvQueryObj, Querier, out Locations, out Scores);
	}
}
