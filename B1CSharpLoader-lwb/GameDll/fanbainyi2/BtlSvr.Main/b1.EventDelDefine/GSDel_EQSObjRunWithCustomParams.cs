using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_EQSObjRunWithCustomParams : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_EQSObjRunWithCustomParams _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_EQSObjRunWithCustomParams)Delegate.Combine(_MultiCastDel, (Del_EQSObjRunWithCustomParams)Del);
		}
		else
		{
			_MultiCastDel = (Del_EQSObjRunWithCustomParams)Delegate.Remove(_MultiCastDel, (Del_EQSObjRunWithCustomParams)Del);
		}
	}

	public static GSDel_EQSObjRunWithCustomParams operator +(GSDel_EQSObjRunWithCustomParams GSEvent, Del_EQSObjRunWithCustomParams Del)
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
		GSEvent._MultiCastDel = (Del_EQSObjRunWithCustomParams)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_EQSObjRunWithCustomParams operator -(GSDel_EQSObjRunWithCustomParams GSEvent, Del_EQSObjRunWithCustomParams Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_EQSObjRunWithCustomParams == Del)
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
		GSEvent._MultiCastDel = (Del_EQSObjRunWithCustomParams)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public int Invoke(UEnvQuery EnvQueryObj, AActor Querier, EBGURunEQSObjReason Reason, List<FGSEnvNamedValue> EQSParamList, Action<List<FVector>, List<float>, FGSEQSExParam, int> CallBack)
	{
		if (_MultiCastDel == null)
		{
			return 0;
		}
		return _MultiCastDel(EnvQueryObj, Querier, Reason, EQSParamList, CallBack);
	}
}
