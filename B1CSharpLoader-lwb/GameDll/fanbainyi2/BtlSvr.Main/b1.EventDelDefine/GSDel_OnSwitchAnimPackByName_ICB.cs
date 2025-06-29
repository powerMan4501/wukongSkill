using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_OnSwitchAnimPackByName_ICB : IFreshAbleGSEvent
{
	private Del_OnSwitchAnimPackByName _InvokeCallBack;

	private Action<Del_OnSwitchAnimPackByName> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnSwitchAnimPackByName _MultiCastDel;

	public GSDel_OnSwitchAnimPackByName_ICB(Del_OnSwitchAnimPackByName InvokeCallBack, Action<Del_OnSwitchAnimPackByName> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnSwitchAnimPackByName)Delegate.Combine(_MultiCastDel, (Del_OnSwitchAnimPackByName)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnSwitchAnimPackByName)Delegate.Remove(_MultiCastDel, (Del_OnSwitchAnimPackByName)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_OnSwitchAnimPackByName_ICB operator +(GSDel_OnSwitchAnimPackByName_ICB GSEvent, Del_OnSwitchAnimPackByName Del)
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
		GSEvent._MultiCastDel = (Del_OnSwitchAnimPackByName)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_OnSwitchAnimPackByName_ICB operator -(GSDel_OnSwitchAnimPackByName_ICB GSEvent, Del_OnSwitchAnimPackByName Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnSwitchAnimPackByName == Del)
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
		GSEvent._MultiCastDel = (Del_OnSwitchAnimPackByName)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public bool Invoke(string AnimPackName)
	{
		if (_InvokeCallBack == null)
		{
			return false;
		}
		return _InvokeCallBack(AnimPackName);
	}
}
