using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_AAMotionMatchAssetPreloadRequireFinished_ICB : IFreshAbleGSEvent
{
	private Del_AAMotionMatchAssetPreloadRequireFinished _InvokeCallBack;

	private Action<Del_AAMotionMatchAssetPreloadRequireFinished> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_AAMotionMatchAssetPreloadRequireFinished _MultiCastDel;

	public GSDel_AAMotionMatchAssetPreloadRequireFinished_ICB(Del_AAMotionMatchAssetPreloadRequireFinished InvokeCallBack, Action<Del_AAMotionMatchAssetPreloadRequireFinished> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_AAMotionMatchAssetPreloadRequireFinished)Delegate.Combine(_MultiCastDel, (Del_AAMotionMatchAssetPreloadRequireFinished)Del);
		}
		else
		{
			_MultiCastDel = (Del_AAMotionMatchAssetPreloadRequireFinished)Delegate.Remove(_MultiCastDel, (Del_AAMotionMatchAssetPreloadRequireFinished)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_AAMotionMatchAssetPreloadRequireFinished_ICB operator +(GSDel_AAMotionMatchAssetPreloadRequireFinished_ICB GSEvent, Del_AAMotionMatchAssetPreloadRequireFinished Del)
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
		GSEvent._MultiCastDel = (Del_AAMotionMatchAssetPreloadRequireFinished)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_AAMotionMatchAssetPreloadRequireFinished_ICB operator -(GSDel_AAMotionMatchAssetPreloadRequireFinished_ICB GSEvent, Del_AAMotionMatchAssetPreloadRequireFinished Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_AAMotionMatchAssetPreloadRequireFinished == Del)
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
		GSEvent._MultiCastDel = (Del_AAMotionMatchAssetPreloadRequireFinished)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FSoftObjectPath Path)
	{
		_InvokeCallBack?.Invoke(Path);
	}
}
