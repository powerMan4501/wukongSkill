using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_AISearchAndCatchTarget_ICB : IFreshAbleGSEvent
{
	private Del_AISearchAndCatchTarget _InvokeCallBack;

	private Action<Del_AISearchAndCatchTarget> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_AISearchAndCatchTarget _MultiCastDel;

	public GSDel_AISearchAndCatchTarget_ICB(Del_AISearchAndCatchTarget InvokeCallBack, Action<Del_AISearchAndCatchTarget> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_AISearchAndCatchTarget)Delegate.Combine(_MultiCastDel, (Del_AISearchAndCatchTarget)Del);
		}
		else
		{
			_MultiCastDel = (Del_AISearchAndCatchTarget)Delegate.Remove(_MultiCastDel, (Del_AISearchAndCatchTarget)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_AISearchAndCatchTarget_ICB operator +(GSDel_AISearchAndCatchTarget_ICB GSEvent, Del_AISearchAndCatchTarget Del)
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
		GSEvent._MultiCastDel = (Del_AISearchAndCatchTarget)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_AISearchAndCatchTarget_ICB operator -(GSDel_AISearchAndCatchTarget_ICB GSEvent, Del_AISearchAndCatchTarget Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_AISearchAndCatchTarget == Del)
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
		GSEvent._MultiCastDel = (Del_AISearchAndCatchTarget)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor SearchBaseActor, int Radius, int TargetFilter, int SecondTargetFilter, EAISearchTargetWay AISearchTargetWay)
	{
		_InvokeCallBack?.Invoke(SearchBaseActor, Radius, TargetFilter, SecondTargetFilter, AISearchTargetWay);
	}
}
