using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_OverlapSceneItems_ICB : IFreshAbleGSEvent
{
	private Del_OverlapSceneItems _InvokeCallBack;

	private Action<Del_OverlapSceneItems> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OverlapSceneItems _MultiCastDel;

	public GSDel_OverlapSceneItems_ICB(Del_OverlapSceneItems InvokeCallBack, Action<Del_OverlapSceneItems> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OverlapSceneItems)Delegate.Combine(_MultiCastDel, (Del_OverlapSceneItems)Del);
		}
		else
		{
			_MultiCastDel = (Del_OverlapSceneItems)Delegate.Remove(_MultiCastDel, (Del_OverlapSceneItems)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_OverlapSceneItems_ICB operator +(GSDel_OverlapSceneItems_ICB GSEvent, Del_OverlapSceneItems Del)
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
		GSEvent._MultiCastDel = (Del_OverlapSceneItems)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_OverlapSceneItems_ICB operator -(GSDel_OverlapSceneItems_ICB GSEvent, Del_OverlapSceneItems Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OverlapSceneItems == Del)
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
		GSEvent._MultiCastDel = (Del_OverlapSceneItems)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public List<AActor> Invoke(List<FUStCheckShape> SweepCheckShape)
	{
		if (_InvokeCallBack == null)
		{
			return null;
		}
		return _InvokeCallBack(SweepCheckShape);
	}
}
