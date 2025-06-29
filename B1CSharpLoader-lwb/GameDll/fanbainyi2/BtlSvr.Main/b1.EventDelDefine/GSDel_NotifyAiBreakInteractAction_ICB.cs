using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_NotifyAiBreakInteractAction_ICB : IFreshAbleGSEvent
{
	private Del_NotifyAiBreakInteractAction _InvokeCallBack;

	private Action<Del_NotifyAiBreakInteractAction> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_NotifyAiBreakInteractAction _MultiCastDel;

	public GSDel_NotifyAiBreakInteractAction_ICB(Del_NotifyAiBreakInteractAction InvokeCallBack, Action<Del_NotifyAiBreakInteractAction> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_NotifyAiBreakInteractAction)Delegate.Combine(_MultiCastDel, (Del_NotifyAiBreakInteractAction)Del);
		}
		else
		{
			_MultiCastDel = (Del_NotifyAiBreakInteractAction)Delegate.Remove(_MultiCastDel, (Del_NotifyAiBreakInteractAction)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_NotifyAiBreakInteractAction_ICB operator +(GSDel_NotifyAiBreakInteractAction_ICB GSEvent, Del_NotifyAiBreakInteractAction Del)
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
		GSEvent._MultiCastDel = (Del_NotifyAiBreakInteractAction)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_NotifyAiBreakInteractAction_ICB operator -(GSDel_NotifyAiBreakInteractAction_ICB GSEvent, Del_NotifyAiBreakInteractAction Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_NotifyAiBreakInteractAction == Del)
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
		GSEvent._MultiCastDel = (Del_NotifyAiBreakInteractAction)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EAiBreakInteractionType BreakType)
	{
		_InvokeCallBack?.Invoke(BreakType);
	}
}
