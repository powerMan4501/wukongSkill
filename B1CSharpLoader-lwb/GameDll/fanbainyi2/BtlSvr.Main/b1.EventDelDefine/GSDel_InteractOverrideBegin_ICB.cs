using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_InteractOverrideBegin_ICB : IFreshAbleGSEvent
{
	private Del_InteractOverrideBegin _InvokeCallBack;

	private Action<Del_InteractOverrideBegin> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_InteractOverrideBegin _MultiCastDel;

	public GSDel_InteractOverrideBegin_ICB(Del_InteractOverrideBegin InvokeCallBack, Action<Del_InteractOverrideBegin> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_InteractOverrideBegin)Delegate.Combine(_MultiCastDel, (Del_InteractOverrideBegin)Del);
		}
		else
		{
			_MultiCastDel = (Del_InteractOverrideBegin)Delegate.Remove(_MultiCastDel, (Del_InteractOverrideBegin)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_InteractOverrideBegin_ICB operator +(GSDel_InteractOverrideBegin_ICB GSEvent, Del_InteractOverrideBegin Del)
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
		GSEvent._MultiCastDel = (Del_InteractOverrideBegin)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_InteractOverrideBegin_ICB operator -(GSDel_InteractOverrideBegin_ICB GSEvent, Del_InteractOverrideBegin Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_InteractOverrideBegin == Del)
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
		GSEvent._MultiCastDel = (Del_InteractOverrideBegin)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int NotifyID, TArrayReadWrite<DispInteractOverride> OverrideInfoArr)
	{
		_InvokeCallBack?.Invoke(NotifyID, OverrideInfoArr);
	}
}
