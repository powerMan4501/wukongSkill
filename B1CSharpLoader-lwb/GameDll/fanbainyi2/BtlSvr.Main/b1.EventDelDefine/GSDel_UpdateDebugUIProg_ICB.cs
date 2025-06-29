using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_UpdateDebugUIProg_ICB : IFreshAbleGSEvent
{
	private Del_UpdateDebugUIProg _InvokeCallBack;

	private Action<Del_UpdateDebugUIProg> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_UpdateDebugUIProg _MultiCastDel;

	public GSDel_UpdateDebugUIProg_ICB(Del_UpdateDebugUIProg InvokeCallBack, Action<Del_UpdateDebugUIProg> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_UpdateDebugUIProg)Delegate.Combine(_MultiCastDel, (Del_UpdateDebugUIProg)Del);
		}
		else
		{
			_MultiCastDel = (Del_UpdateDebugUIProg)Delegate.Remove(_MultiCastDel, (Del_UpdateDebugUIProg)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_UpdateDebugUIProg_ICB operator +(GSDel_UpdateDebugUIProg_ICB GSEvent, Del_UpdateDebugUIProg Del)
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
		GSEvent._MultiCastDel = (Del_UpdateDebugUIProg)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_UpdateDebugUIProg_ICB operator -(GSDel_UpdateDebugUIProg_ICB GSEvent, Del_UpdateDebugUIProg Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_UpdateDebugUIProg == Del)
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
		GSEvent._MultiCastDel = (Del_UpdateDebugUIProg)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(string Name, float Value, float ResetTime = 0f)
	{
		_InvokeCallBack?.Invoke(Name, Value, ResetTime);
	}
}
