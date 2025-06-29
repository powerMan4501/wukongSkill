using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_OnSweepHitWorldItemForProcedural_ICB : IFreshAbleGSEvent
{
	private Del_OnSweepHitWorldItemForProcedural _InvokeCallBack;

	private Action<Del_OnSweepHitWorldItemForProcedural> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnSweepHitWorldItemForProcedural _MultiCastDel;

	public GSDel_OnSweepHitWorldItemForProcedural_ICB(Del_OnSweepHitWorldItemForProcedural InvokeCallBack, Action<Del_OnSweepHitWorldItemForProcedural> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnSweepHitWorldItemForProcedural)Delegate.Combine(_MultiCastDel, (Del_OnSweepHitWorldItemForProcedural)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnSweepHitWorldItemForProcedural)Delegate.Remove(_MultiCastDel, (Del_OnSweepHitWorldItemForProcedural)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_OnSweepHitWorldItemForProcedural_ICB operator +(GSDel_OnSweepHitWorldItemForProcedural_ICB GSEvent, Del_OnSweepHitWorldItemForProcedural Del)
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
		GSEvent._MultiCastDel = (Del_OnSweepHitWorldItemForProcedural)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_OnSweepHitWorldItemForProcedural_ICB operator -(GSDel_OnSweepHitWorldItemForProcedural_ICB GSEvent, Del_OnSweepHitWorldItemForProcedural Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnSweepHitWorldItemForProcedural == Del)
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
		GSEvent._MultiCastDel = (Del_OnSweepHitWorldItemForProcedural)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FVector2D Position, float Size, ESceneItemSurfaceType OverrideSurfaceType, int EntityID)
	{
		_InvokeCallBack?.Invoke(Position, Size, OverrideSurfaceType, EntityID);
	}
}
