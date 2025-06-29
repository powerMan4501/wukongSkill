using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_MontageRotateTraceActor_ICB : IFreshAbleGSEvent
{
	private Del_MontageRotateTraceActor _InvokeCallBack;

	private Action<Del_MontageRotateTraceActor> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_MontageRotateTraceActor _MultiCastDel;

	public GSDel_MontageRotateTraceActor_ICB(Del_MontageRotateTraceActor InvokeCallBack, Action<Del_MontageRotateTraceActor> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_MontageRotateTraceActor)Delegate.Combine(_MultiCastDel, (Del_MontageRotateTraceActor)Del);
		}
		else
		{
			_MultiCastDel = (Del_MontageRotateTraceActor)Delegate.Remove(_MultiCastDel, (Del_MontageRotateTraceActor)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_MontageRotateTraceActor_ICB operator +(GSDel_MontageRotateTraceActor_ICB GSEvent, Del_MontageRotateTraceActor Del)
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
		GSEvent._MultiCastDel = (Del_MontageRotateTraceActor)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_MontageRotateTraceActor_ICB operator -(GSDel_MontageRotateTraceActor_ICB GSEvent, Del_MontageRotateTraceActor Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_MontageRotateTraceActor == Del)
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
		GSEvent._MultiCastDel = (Del_MontageRotateTraceActor)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(UnitLockTargetInfo LockTargetInfo, float TurnSpeed, float RotateDeflectionAngle, float MaxRotateAngle, string TraceSocket = "", bool bIncludeAutoLockPoint = false, ERotateDirection RotateDirection = ERotateDirection.Auto, bool bStillRotateWhenAboveMaxRotateAngle = false, float DeadzoneAngle = 0f, bool EnableDebug = false)
	{
		_InvokeCallBack?.Invoke(LockTargetInfo, TurnSpeed, RotateDeflectionAngle, MaxRotateAngle, TraceSocket, bIncludeAutoLockPoint, RotateDirection, bStillRotateWhenAboveMaxRotateAngle, DeadzoneAngle, EnableDebug);
	}
}
