using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_UI_X2UpdateAlertProgress_ICB : IFreshAbleGSEvent
{
	private Del_UI_X2UpdateAlertProgress _InvokeCallBack;

	private Action<Del_UI_X2UpdateAlertProgress> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_UI_X2UpdateAlertProgress _MultiCastDel;

	public GSDel_UI_X2UpdateAlertProgress_ICB(Del_UI_X2UpdateAlertProgress InvokeCallBack, Action<Del_UI_X2UpdateAlertProgress> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_UI_X2UpdateAlertProgress)Delegate.Combine(_MultiCastDel, (Del_UI_X2UpdateAlertProgress)Del);
		}
		else
		{
			_MultiCastDel = (Del_UI_X2UpdateAlertProgress)Delegate.Remove(_MultiCastDel, (Del_UI_X2UpdateAlertProgress)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_UI_X2UpdateAlertProgress_ICB operator +(GSDel_UI_X2UpdateAlertProgress_ICB GSEvent, Del_UI_X2UpdateAlertProgress Del)
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
		GSEvent._MultiCastDel = (Del_UI_X2UpdateAlertProgress)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_UI_X2UpdateAlertProgress_ICB operator -(GSDel_UI_X2UpdateAlertProgress_ICB GSEvent, Del_UI_X2UpdateAlertProgress Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_UI_X2UpdateAlertProgress == Del)
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
		GSEvent._MultiCastDel = (Del_UI_X2UpdateAlertProgress)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(float Percent)
	{
		_InvokeCallBack?.Invoke(Percent);
	}
}
