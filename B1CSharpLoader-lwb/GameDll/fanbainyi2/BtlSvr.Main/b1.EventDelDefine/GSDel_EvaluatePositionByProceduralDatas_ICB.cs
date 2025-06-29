using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_EvaluatePositionByProceduralDatas_ICB : IFreshAbleGSEvent
{
	private Del_EvaluatePositionByProceduralDatas _InvokeCallBack;

	private Action<Del_EvaluatePositionByProceduralDatas> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_EvaluatePositionByProceduralDatas _MultiCastDel;

	public GSDel_EvaluatePositionByProceduralDatas_ICB(Del_EvaluatePositionByProceduralDatas InvokeCallBack, Action<Del_EvaluatePositionByProceduralDatas> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_EvaluatePositionByProceduralDatas)Delegate.Combine(_MultiCastDel, (Del_EvaluatePositionByProceduralDatas)Del);
		}
		else
		{
			_MultiCastDel = (Del_EvaluatePositionByProceduralDatas)Delegate.Remove(_MultiCastDel, (Del_EvaluatePositionByProceduralDatas)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_EvaluatePositionByProceduralDatas_ICB operator +(GSDel_EvaluatePositionByProceduralDatas_ICB GSEvent, Del_EvaluatePositionByProceduralDatas Del)
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
		GSEvent._MultiCastDel = (Del_EvaluatePositionByProceduralDatas)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_EvaluatePositionByProceduralDatas_ICB operator -(GSDel_EvaluatePositionByProceduralDatas_ICB GSEvent, Del_EvaluatePositionByProceduralDatas Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_EvaluatePositionByProceduralDatas == Del)
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
		GSEvent._MultiCastDel = (Del_EvaluatePositionByProceduralDatas)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public ESceneItemSurfaceType Invoke(FVector2D Position)
	{
		if (_InvokeCallBack == null)
		{
			return ESceneItemSurfaceType.DefaultSurface;
		}
		return _InvokeCallBack(Position);
	}
}
