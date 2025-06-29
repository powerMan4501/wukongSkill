using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_RequestOneUniversalUAF_ICB : IFreshAbleGSEvent
{
	private Del_RequestOneUniversalUAF _InvokeCallBack;

	private Action<Del_RequestOneUniversalUAF> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_RequestOneUniversalUAF _MultiCastDel;

	public GSDel_RequestOneUniversalUAF_ICB(Del_RequestOneUniversalUAF InvokeCallBack, Action<Del_RequestOneUniversalUAF> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_RequestOneUniversalUAF)Delegate.Combine(_MultiCastDel, (Del_RequestOneUniversalUAF)Del);
		}
		else
		{
			_MultiCastDel = (Del_RequestOneUniversalUAF)Delegate.Remove(_MultiCastDel, (Del_RequestOneUniversalUAF)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_RequestOneUniversalUAF_ICB operator +(GSDel_RequestOneUniversalUAF_ICB GSEvent, Del_RequestOneUniversalUAF Del)
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
		GSEvent._MultiCastDel = (Del_RequestOneUniversalUAF)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_RequestOneUniversalUAF_ICB operator -(GSDel_RequestOneUniversalUAF_ICB GSEvent, Del_RequestOneUniversalUAF Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_RequestOneUniversalUAF == Del)
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
		GSEvent._MultiCastDel = (Del_RequestOneUniversalUAF)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int UniversalDataIndex, int Priority = 0)
	{
		_InvokeCallBack?.Invoke(UniversalDataIndex, Priority);
	}
}
