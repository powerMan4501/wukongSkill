using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_OnAiConversationCastSuccess_ICB : IFreshAbleGSEvent
{
	private Del_OnAiConversationCastSuccess _InvokeCallBack;

	private Action<Del_OnAiConversationCastSuccess> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnAiConversationCastSuccess _MultiCastDel;

	public GSDel_OnAiConversationCastSuccess_ICB(Del_OnAiConversationCastSuccess InvokeCallBack, Action<Del_OnAiConversationCastSuccess> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnAiConversationCastSuccess)Delegate.Combine(_MultiCastDel, (Del_OnAiConversationCastSuccess)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnAiConversationCastSuccess)Delegate.Remove(_MultiCastDel, (Del_OnAiConversationCastSuccess)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_OnAiConversationCastSuccess_ICB operator +(GSDel_OnAiConversationCastSuccess_ICB GSEvent, Del_OnAiConversationCastSuccess Del)
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
		GSEvent._MultiCastDel = (Del_OnAiConversationCastSuccess)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_OnAiConversationCastSuccess_ICB operator -(GSDel_OnAiConversationCastSuccess_ICB GSEvent, Del_OnAiConversationCastSuccess Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnAiConversationCastSuccess == Del)
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
		GSEvent._MultiCastDel = (Del_OnAiConversationCastSuccess)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(string UnitGuid, int ConversationContentID, uint ConversationChainRootID, float CDTime, bool bIsGlobalCD = false)
	{
		_InvokeCallBack?.Invoke(UnitGuid, ConversationContentID, ConversationChainRootID, CDTime, bIsGlobalCD);
	}
}
