using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_SolveBeAttackedStiffLogic_ICB : IFreshAbleGSEvent
{
	private Del_SolveBeAttackedStiffLogic _InvokeCallBack;

	private Action<Del_SolveBeAttackedStiffLogic> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SolveBeAttackedStiffLogic _MultiCastDel;

	public GSDel_SolveBeAttackedStiffLogic_ICB(Del_SolveBeAttackedStiffLogic InvokeCallBack, Action<Del_SolveBeAttackedStiffLogic> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SolveBeAttackedStiffLogic)Delegate.Combine(_MultiCastDel, (Del_SolveBeAttackedStiffLogic)Del);
		}
		else
		{
			_MultiCastDel = (Del_SolveBeAttackedStiffLogic)Delegate.Remove(_MultiCastDel, (Del_SolveBeAttackedStiffLogic)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SolveBeAttackedStiffLogic_ICB operator +(GSDel_SolveBeAttackedStiffLogic_ICB GSEvent, Del_SolveBeAttackedStiffLogic Del)
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
		GSEvent._MultiCastDel = (Del_SolveBeAttackedStiffLogic)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SolveBeAttackedStiffLogic_ICB operator -(GSDel_SolveBeAttackedStiffLogic_ICB GSEvent, Del_SolveBeAttackedStiffLogic Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SolveBeAttackedStiffLogic == Del)
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
		GSEvent._MultiCastDel = (Del_SolveBeAttackedStiffLogic)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(UAnimMontage Montage)
	{
		_InvokeCallBack?.Invoke(Montage);
	}
}
