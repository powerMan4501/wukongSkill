using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_CastDingShenToTarget_ICB : IFreshAbleGSEvent
{
	private Del_CastDingShenToTarget _InvokeCallBack;

	private Action<Del_CastDingShenToTarget> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_CastDingShenToTarget _MultiCastDel;

	public GSDel_CastDingShenToTarget_ICB(Del_CastDingShenToTarget InvokeCallBack, Action<Del_CastDingShenToTarget> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_CastDingShenToTarget)Delegate.Combine(_MultiCastDel, (Del_CastDingShenToTarget)Del);
		}
		else
		{
			_MultiCastDel = (Del_CastDingShenToTarget)Delegate.Remove(_MultiCastDel, (Del_CastDingShenToTarget)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_CastDingShenToTarget_ICB operator +(GSDel_CastDingShenToTarget_ICB GSEvent, Del_CastDingShenToTarget Del)
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
		GSEvent._MultiCastDel = (Del_CastDingShenToTarget)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_CastDingShenToTarget_ICB operator -(GSDel_CastDingShenToTarget_ICB GSEvent, Del_CastDingShenToTarget Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_CastDingShenToTarget == Del)
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
		GSEvent._MultiCastDel = (Del_CastDingShenToTarget)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FGSCastDingShenSetting CastDingShenSetting, float Duration)
	{
		_InvokeCallBack?.Invoke(CastDingShenSetting, Duration);
	}
}
