using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.AIModule;

namespace b1.EventDelDefine;

public class GSDel_InitiateEQSObjRun_ICB : IFreshAbleGSEvent
{
	private Del_InitiateEQSObjRun _InvokeCallBack;

	private Action<Del_InitiateEQSObjRun> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_InitiateEQSObjRun _MultiCastDel;

	public GSDel_InitiateEQSObjRun_ICB(Del_InitiateEQSObjRun InvokeCallBack, Action<Del_InitiateEQSObjRun> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_InitiateEQSObjRun)Delegate.Combine(_MultiCastDel, (Del_InitiateEQSObjRun)Del);
		}
		else
		{
			_MultiCastDel = (Del_InitiateEQSObjRun)Delegate.Remove(_MultiCastDel, (Del_InitiateEQSObjRun)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_InitiateEQSObjRun_ICB operator +(GSDel_InitiateEQSObjRun_ICB GSEvent, Del_InitiateEQSObjRun Del)
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
		GSEvent._MultiCastDel = (Del_InitiateEQSObjRun)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_InitiateEQSObjRun_ICB operator -(GSDel_InitiateEQSObjRun_ICB GSEvent, Del_InitiateEQSObjRun Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_InitiateEQSObjRun == Del)
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
		GSEvent._MultiCastDel = (Del_InitiateEQSObjRun)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(UEnvQuery EnvQueryObj, EBGURunEQSObjReason Reason, FGSEQSExParam _ExParam)
	{
		_InvokeCallBack?.Invoke(EnvQueryObj, Reason, _ExParam);
	}
}
