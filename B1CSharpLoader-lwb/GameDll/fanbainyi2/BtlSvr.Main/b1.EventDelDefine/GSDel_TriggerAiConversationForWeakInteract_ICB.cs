using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_TriggerAiConversationForWeakInteract_ICB : IFreshAbleGSEvent
{
	private Del_TriggerAiConversationForWeakInteract _InvokeCallBack;

	private Action<Del_TriggerAiConversationForWeakInteract> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerAiConversationForWeakInteract _MultiCastDel;

	public GSDel_TriggerAiConversationForWeakInteract_ICB(Del_TriggerAiConversationForWeakInteract InvokeCallBack, Action<Del_TriggerAiConversationForWeakInteract> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TriggerAiConversationForWeakInteract)Delegate.Combine(_MultiCastDel, (Del_TriggerAiConversationForWeakInteract)Del);
		}
		else
		{
			_MultiCastDel = (Del_TriggerAiConversationForWeakInteract)Delegate.Remove(_MultiCastDel, (Del_TriggerAiConversationForWeakInteract)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_TriggerAiConversationForWeakInteract_ICB operator +(GSDel_TriggerAiConversationForWeakInteract_ICB GSEvent, Del_TriggerAiConversationForWeakInteract Del)
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
		GSEvent._MultiCastDel = (Del_TriggerAiConversationForWeakInteract)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_TriggerAiConversationForWeakInteract_ICB operator -(GSDel_TriggerAiConversationForWeakInteract_ICB GSEvent, Del_TriggerAiConversationForWeakInteract Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TriggerAiConversationForWeakInteract == Del)
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
		GSEvent._MultiCastDel = (Del_TriggerAiConversationForWeakInteract)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(string WeakAiInteractGUID, List<int> ConversationIDList)
	{
		_InvokeCallBack?.Invoke(WeakAiInteractGUID, ConversationIDList);
	}
}
