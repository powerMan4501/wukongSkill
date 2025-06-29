using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SetTargetInfoServer_ICB : IFreshAbleGSEvent
{
	private Del_SetTargetInfoServer _InvokeCallBack;

	private Action<Del_SetTargetInfoServer> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetTargetInfoServer _MultiCastDel;

	public GSDel_SetTargetInfoServer_ICB(Del_SetTargetInfoServer InvokeCallBack, Action<Del_SetTargetInfoServer> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetTargetInfoServer)Delegate.Combine(_MultiCastDel, (Del_SetTargetInfoServer)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetTargetInfoServer)Delegate.Remove(_MultiCastDel, (Del_SetTargetInfoServer)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetTargetInfoServer_ICB operator +(GSDel_SetTargetInfoServer_ICB GSEvent, Del_SetTargetInfoServer Del)
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
		GSEvent._MultiCastDel = (Del_SetTargetInfoServer)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetTargetInfoServer_ICB operator -(GSDel_SetTargetInfoServer_ICB GSEvent, Del_SetTargetInfoServer Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetTargetInfoServer == Del)
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
		GSEvent._MultiCastDel = (Del_SetTargetInfoServer)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FUnitLockTargetInfo NewTargetInfo)
	{
		_InvokeCallBack?.Invoke(NewTargetInfo);
	}
}
