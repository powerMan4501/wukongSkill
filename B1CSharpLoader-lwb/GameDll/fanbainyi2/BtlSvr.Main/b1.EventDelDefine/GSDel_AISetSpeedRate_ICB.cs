using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_AISetSpeedRate_ICB : IFreshAbleGSEvent
{
	private Del_AISetSpeedRate _InvokeCallBack;

	private Action<Del_AISetSpeedRate> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_AISetSpeedRate _MultiCastDel;

	public GSDel_AISetSpeedRate_ICB(Del_AISetSpeedRate InvokeCallBack, Action<Del_AISetSpeedRate> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_AISetSpeedRate)Delegate.Combine(_MultiCastDel, (Del_AISetSpeedRate)Del);
		}
		else
		{
			_MultiCastDel = (Del_AISetSpeedRate)Delegate.Remove(_MultiCastDel, (Del_AISetSpeedRate)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_AISetSpeedRate_ICB operator +(GSDel_AISetSpeedRate_ICB GSEvent, Del_AISetSpeedRate Del)
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
		GSEvent._MultiCastDel = (Del_AISetSpeedRate)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_AISetSpeedRate_ICB operator -(GSDel_AISetSpeedRate_ICB GSEvent, Del_AISetSpeedRate Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_AISetSpeedRate == Del)
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
		GSEvent._MultiCastDel = (Del_AISetSpeedRate)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(float SpeedRate, EBGUSpeedCtrlID SpeedCtrlID = EBGUSpeedCtrlID.Custom)
	{
		_InvokeCallBack?.Invoke(SpeedRate, SpeedCtrlID);
	}
}
