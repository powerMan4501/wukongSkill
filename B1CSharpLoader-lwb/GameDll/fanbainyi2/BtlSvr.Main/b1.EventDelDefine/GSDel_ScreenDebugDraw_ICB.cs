using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_ScreenDebugDraw_ICB : IFreshAbleGSEvent
{
	private Del_ScreenDebugDraw _InvokeCallBack;

	private Action<Del_ScreenDebugDraw> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ScreenDebugDraw _MultiCastDel;

	public GSDel_ScreenDebugDraw_ICB(Del_ScreenDebugDraw InvokeCallBack, Action<Del_ScreenDebugDraw> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ScreenDebugDraw)Delegate.Combine(_MultiCastDel, (Del_ScreenDebugDraw)Del);
		}
		else
		{
			_MultiCastDel = (Del_ScreenDebugDraw)Delegate.Remove(_MultiCastDel, (Del_ScreenDebugDraw)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_ScreenDebugDraw_ICB operator +(GSDel_ScreenDebugDraw_ICB GSEvent, Del_ScreenDebugDraw Del)
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
		GSEvent._MultiCastDel = (Del_ScreenDebugDraw)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_ScreenDebugDraw_ICB operator -(GSDel_ScreenDebugDraw_ICB GSEvent, Del_ScreenDebugDraw Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ScreenDebugDraw == Del)
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
		GSEvent._MultiCastDel = (Del_ScreenDebugDraw)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FVector2D Point, FLinearColor Color, float Size)
	{
		_InvokeCallBack?.Invoke(Point, Color, Size);
	}
}
