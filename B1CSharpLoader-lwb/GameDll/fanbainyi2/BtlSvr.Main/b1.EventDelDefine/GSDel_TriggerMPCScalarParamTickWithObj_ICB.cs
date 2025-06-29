using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_TriggerMPCScalarParamTickWithObj_ICB : IFreshAbleGSEvent
{
	private Del_TriggerMPCScalarParamTickWithObj _InvokeCallBack;

	private Action<Del_TriggerMPCScalarParamTickWithObj> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerMPCScalarParamTickWithObj _MultiCastDel;

	public GSDel_TriggerMPCScalarParamTickWithObj_ICB(Del_TriggerMPCScalarParamTickWithObj InvokeCallBack, Action<Del_TriggerMPCScalarParamTickWithObj> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

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
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_TriggerMPCScalarParamTickWithObj_ICB operator +(GSDel_TriggerMPCScalarParamTickWithObj_ICB GSEvent, Del_TriggerMPCScalarParamTickWithObj Del)
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
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_TriggerMPCScalarParamTickWithObj_ICB operator -(GSDel_TriggerMPCScalarParamTickWithObj_ICB GSEvent, Del_TriggerMPCScalarParamTickWithObj Del)
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
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(UMaterialParameterCollection MPC, string ParamName, UCurveFloat CurveFloat, float TotalTime, float OriValue, bool CoverLastTrigger = true)
	{
		_InvokeCallBack?.Invoke(MPC, ParamName, CurveFloat, TotalTime, OriValue, CoverLastTrigger);
	}
}
