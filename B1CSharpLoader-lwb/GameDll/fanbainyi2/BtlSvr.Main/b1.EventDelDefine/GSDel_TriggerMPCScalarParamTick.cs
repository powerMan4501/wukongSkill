using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_TriggerMPCScalarParamTick : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerMPCScalarParamTick _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TriggerMPCScalarParamTick)Delegate.Combine(_MultiCastDel, (Del_TriggerMPCScalarParamTick)Del);
		}
		else
		{
			_MultiCastDel = (Del_TriggerMPCScalarParamTick)Delegate.Remove(_MultiCastDel, (Del_TriggerMPCScalarParamTick)Del);
		}
	}

	public static GSDel_TriggerMPCScalarParamTick operator +(GSDel_TriggerMPCScalarParamTick GSEvent, Del_TriggerMPCScalarParamTick Del)
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
		GSEvent._MultiCastDel = (Del_TriggerMPCScalarParamTick)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_TriggerMPCScalarParamTick operator -(GSDel_TriggerMPCScalarParamTick GSEvent, Del_TriggerMPCScalarParamTick Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TriggerMPCScalarParamTick == Del)
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
		GSEvent._MultiCastDel = (Del_TriggerMPCScalarParamTick)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(string MPCPath, string ParamName, string CurveFloatPath, float TotalTime, float OriValue, bool CoverLastTrigger = true)
	{
		_MultiCastDel?.Invoke(MPCPath, ParamName, CurveFloatPath, TotalTime, OriValue, CoverLastTrigger);
	}
}
