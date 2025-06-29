using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_SetHitCollisionUpdateInfo_ICB : IFreshAbleGSEvent
{
	private Del_SetHitCollisionUpdateInfo _InvokeCallBack;

	private Action<Del_SetHitCollisionUpdateInfo> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetHitCollisionUpdateInfo _MultiCastDel;

	public GSDel_SetHitCollisionUpdateInfo_ICB(Del_SetHitCollisionUpdateInfo InvokeCallBack, Action<Del_SetHitCollisionUpdateInfo> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetHitCollisionUpdateInfo)Delegate.Combine(_MultiCastDel, (Del_SetHitCollisionUpdateInfo)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetHitCollisionUpdateInfo)Delegate.Remove(_MultiCastDel, (Del_SetHitCollisionUpdateInfo)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetHitCollisionUpdateInfo_ICB operator +(GSDel_SetHitCollisionUpdateInfo_ICB GSEvent, Del_SetHitCollisionUpdateInfo Del)
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
		GSEvent._MultiCastDel = (Del_SetHitCollisionUpdateInfo)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetHitCollisionUpdateInfo_ICB operator -(GSDel_SetHitCollisionUpdateInfo_ICB GSEvent, Del_SetHitCollisionUpdateInfo Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetHitCollisionUpdateInfo == Del)
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
		GSEvent._MultiCastDel = (Del_SetHitCollisionUpdateInfo)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(string CollisionCompName, EHitMoveDir HitMoveDir, UCurveVector UpdateCurve, float TotalScaleTime, bool NeedUpdateScale, bool NeedUpdateRadius, bool NeedSetRelaLocForScale)
	{
		_InvokeCallBack?.Invoke(CollisionCompName, HitMoveDir, UpdateCurve, TotalScaleTime, NeedUpdateScale, NeedUpdateRadius, NeedSetRelaLocForScale);
	}
}
