using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_TriggerMPCScalarParamTick_ICB : IFreshAbleGSEvent
{
	private Del_TriggerMPCScalarParamTick _InvokeCallBack;

	private Action<Del_TriggerMPCScalarParamTick> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerMPCScalarParamTick _MultiCastDel;

	public GSDel_TriggerMPCScalarParamTick_ICB(Del_TriggerMPCScalarParamTick InvokeCallBack, Action<Del_TriggerMPCScalarParamTick> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

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
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_TriggerMPCScalarParamTick_ICB operator +(GSDel_TriggerMPCScalarParamTick_ICB GSEvent, Del_TriggerMPCScalarParamTick Del)
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
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_TriggerMPCScalarParamTick_ICB operator -(GSDel_TriggerMPCScalarParamTick_ICB GSEvent, Del_TriggerMPCScalarParamTick Del)
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
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(string MPCPath, string ParamName, string CurveFloatPath, float TotalTime, float OriValue, bool CoverLastTrigger = true)
	{
		_InvokeCallBack?.Invoke(MPCPath, ParamName, CurveFloatPath, TotalTime, OriValue, CoverLastTrigger);
	}
}
