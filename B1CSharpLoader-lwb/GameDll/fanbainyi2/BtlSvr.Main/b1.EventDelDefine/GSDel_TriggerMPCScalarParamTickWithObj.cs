using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_TriggerMPCScalarParamTickWithObj : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerMPCScalarParamTickWithObj _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TriggerMPCScalarParamTickWithObj)Delegate.Combine(_MultiCastDel, (Del_TriggerMPCScalarParamTickWithObj)Del);
		}
		else
		{
			_MultiCastDel = (Del_TriggerMPCScalarParamTickWithObj)Delegate.Remove(_MultiCastDel, (Del_TriggerMPCScalarParamTickWithObj)Del);
		}
	}

	public static GSDel_TriggerMPCScalarParamTickWithObj operator +(GSDel_TriggerMPCScalarParamTickWithObj GSEvent, Del_TriggerMPCScalarParamTickWithObj Del)
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
		GSEvent._MultiCastDel = (Del_TriggerMPCScalarParamTickWithObj)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_TriggerMPCScalarParamTickWithObj operator -(GSDel_TriggerMPCScalarParamTickWithObj GSEvent, Del_TriggerMPCScalarParamTickWithObj Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TriggerMPCScalarParamTickWithObj == Del)
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
		GSEvent._MultiCastDel = (Del_TriggerMPCScalarParamTickWithObj)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(UMaterialParameterCollection MPC, string ParamName, UCurveFloat CurveFloat, float TotalTime, float OriValue, bool CoverLastTrigger = true)
	{
		_MultiCastDel?.Invoke(MPC, ParamName, CurveFloat, TotalTime, OriValue, CoverLastTrigger);
	}
}
