using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_SetMatchingPosInterpInfo_ICB : IFreshAbleGSEvent
{
	private Del_SetMatchingPosInterpInfo _InvokeCallBack;

	private Action<Del_SetMatchingPosInterpInfo> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetMatchingPosInterpInfo _MultiCastDel;

	public GSDel_SetMatchingPosInterpInfo_ICB(Del_SetMatchingPosInterpInfo InvokeCallBack, Action<Del_SetMatchingPosInterpInfo> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetMatchingPosInterpInfo)Delegate.Combine(_MultiCastDel, (Del_SetMatchingPosInterpInfo)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetMatchingPosInterpInfo)Delegate.Remove(_MultiCastDel, (Del_SetMatchingPosInterpInfo)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetMatchingPosInterpInfo_ICB operator +(GSDel_SetMatchingPosInterpInfo_ICB GSEvent, Del_SetMatchingPosInterpInfo Del)
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
		GSEvent._MultiCastDel = (Del_SetMatchingPosInterpInfo)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetMatchingPosInterpInfo_ICB operator -(GSDel_SetMatchingPosInterpInfo_ICB GSEvent, Del_SetMatchingPosInterpInfo Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetMatchingPosInterpInfo == Del)
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
		GSEvent._MultiCastDel = (Del_SetMatchingPosInterpInfo)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FTransform MoveTargetTransform, float InterpolationTime, bool EnableZAxisMove = false)
	{
		_InvokeCallBack?.Invoke(MoveTargetTransform, InterpolationTime, EnableZAxisMove);
	}
}
