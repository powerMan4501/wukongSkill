using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_InitiateEQSRun_ICB : IFreshAbleGSEvent
{
	private Del_InitiateEQSRun _InvokeCallBack;

	private Action<Del_InitiateEQSRun> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_InitiateEQSRun _MultiCastDel;

	public GSDel_InitiateEQSRun_ICB(Del_InitiateEQSRun InvokeCallBack, Action<Del_InitiateEQSRun> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_InitiateEQSRun)Delegate.Combine(_MultiCastDel, (Del_InitiateEQSRun)Del);
		}
		else
		{
			_MultiCastDel = (Del_InitiateEQSRun)Delegate.Remove(_MultiCastDel, (Del_InitiateEQSRun)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_InitiateEQSRun_ICB operator +(GSDel_InitiateEQSRun_ICB GSEvent, Del_InitiateEQSRun Del)
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
		GSEvent._MultiCastDel = (Del_InitiateEQSRun)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_InitiateEQSRun_ICB operator -(GSDel_InitiateEQSRun_ICB GSEvent, Del_InitiateEQSRun Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_InitiateEQSRun == Del)
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
		GSEvent._MultiCastDel = (Del_InitiateEQSRun)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(string EQSPath, EBGURunEQSObjReason Reason, FGSEQSExParam _ExParam)
	{
		_InvokeCallBack?.Invoke(EQSPath, Reason, _ExParam);
	}
}
