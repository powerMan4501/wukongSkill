using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SetAMScaleRateByPosMultCast : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetAMScaleRateByPosMultCast _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetAMScaleRateByPosMultCast)Delegate.Combine(_MultiCastDel, (Del_SetAMScaleRateByPosMultCast)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetAMScaleRateByPosMultCast)Delegate.Remove(_MultiCastDel, (Del_SetAMScaleRateByPosMultCast)Del);
		}
	}

	public static GSDel_SetAMScaleRateByPosMultCast operator +(GSDel_SetAMScaleRateByPosMultCast GSEvent, Del_SetAMScaleRateByPosMultCast Del)
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
		GSEvent._MultiCastDel = (Del_SetAMScaleRateByPosMultCast)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_SetAMScaleRateByPosMultCast operator -(GSDel_SetAMScaleRateByPosMultCast GSEvent, Del_SetAMScaleRateByPosMultCast Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetAMScaleRateByPosMultCast == Del)
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
		GSEvent._MultiCastDel = (Del_SetAMScaleRateByPosMultCast)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(EAMScaleType AMScaleType, EAMScaleRateAxis AMScaleAxis, float LandingTraceLength, float PureScaleValue, int CachedDataID, bool AttackRangeLimit, bool DebugMode, float TotalDuration, float NotifyBeginTime, float NotifyEndTime, float AMScaleMinRate = 0f, float AMScaleMaxRate = 0f, float AMScaleMoveOffset = 0f, float AMScaleMoveOffsetZ = 0f)
	{
		_MultiCastDel?.Invoke(AMScaleType, AMScaleAxis, LandingTraceLength, PureScaleValue, CachedDataID, AttackRangeLimit, DebugMode, TotalDuration, NotifyBeginTime, NotifyEndTime, AMScaleMinRate, AMScaleMaxRate, AMScaleMoveOffset, AMScaleMoveOffsetZ);
	}
}
