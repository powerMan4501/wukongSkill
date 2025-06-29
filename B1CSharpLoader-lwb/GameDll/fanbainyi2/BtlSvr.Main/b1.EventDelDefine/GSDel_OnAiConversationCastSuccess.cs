using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_OnAiConversationCastSuccess : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnAiConversationCastSuccess _MultiCastDel;

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
	}

	public static GSDel_OnAiConversationCastSuccess operator +(GSDel_OnAiConversationCastSuccess GSEvent, Del_OnAiConversationCastSuccess Del)
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
		return GSEvent;
	}

	public static GSDel_OnAiConversationCastSuccess operator -(GSDel_OnAiConversationCastSuccess GSEvent, Del_OnAiConversationCastSuccess Del)
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
		return GSEvent;
	}

	public void Invoke(string UnitGuid, int ConversationContentID, uint ConversationChainRootID, float CDTime, bool bIsGlobalCD = false)
	{
		_MultiCastDel?.Invoke(UnitGuid, ConversationContentID, ConversationChainRootID, CDTime, bIsGlobalCD);
	}
}
