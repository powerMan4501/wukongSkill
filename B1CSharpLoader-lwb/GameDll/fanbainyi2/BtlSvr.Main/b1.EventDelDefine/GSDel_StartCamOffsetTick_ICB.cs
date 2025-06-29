using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_StartCamOffsetTick_ICB : IFreshAbleGSEvent
{
	private Del_StartCamOffsetTick _InvokeCallBack;

	private Action<Del_StartCamOffsetTick> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_StartCamOffsetTick _MultiCastDel;

	public GSDel_StartCamOffsetTick_ICB(Del_StartCamOffsetTick InvokeCallBack, Action<Del_StartCamOffsetTick> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_StartCamOffsetTick)Delegate.Combine(_MultiCastDel, (Del_StartCamOffsetTick)Del);
		}
		else
		{
			_MultiCastDel = (Del_StartCamOffsetTick)Delegate.Remove(_MultiCastDel, (Del_StartCamOffsetTick)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_StartCamOffsetTick_ICB operator +(GSDel_StartCamOffsetTick_ICB GSEvent, Del_StartCamOffsetTick Del)
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
		GSEvent._MultiCastDel = (Del_StartCamOffsetTick)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_StartCamOffsetTick_ICB operator -(GSDel_StartCamOffsetTick_ICB GSEvent, Del_StartCamOffsetTick Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_StartCamOffsetTick == Del)
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
		GSEvent._MultiCastDel = (Del_StartCamOffsetTick)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FGSCameraOffsetSetting CameraOffsetSetting, float TotalTime)
	{
		_InvokeCallBack?.Invoke(CameraOffsetSetting, TotalTime);
	}
}
