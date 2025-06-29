using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_EQSObjRun : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_EQSObjRun _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_EQSObjRun)Delegate.Combine(_MultiCastDel, (Del_EQSObjRun)Del);
		}
		else
		{
			_MultiCastDel = (Del_EQSObjRun)Delegate.Remove(_MultiCastDel, (Del_EQSObjRun)Del);
		}
	}

	public static GSDel_EQSObjRun operator +(GSDel_EQSObjRun GSEvent, Del_EQSObjRun Del)
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
		GSEvent._MultiCastDel = (Del_EQSObjRun)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_EQSObjRun operator -(GSDel_EQSObjRun GSEvent, Del_EQSObjRun Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_EQSObjRun == Del)
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
		GSEvent._MultiCastDel = (Del_EQSObjRun)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public int Invoke(UEnvQuery EnvQueryObj, AActor Querier, EBGURunEQSObjReason Reason, FGSEQSExParam _ExParam, Action<List<FVector>, List<float>, FGSEQSExParam, int> CallBack)
	{
		if (_MultiCastDel == null)
		{
			return 0;
		}
		return _MultiCastDel(EnvQueryObj, Querier, Reason, _ExParam, CallBack);
	}
}
