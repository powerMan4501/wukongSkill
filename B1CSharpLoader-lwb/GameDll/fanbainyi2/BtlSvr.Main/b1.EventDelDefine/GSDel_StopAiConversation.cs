using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_StopAiConversation : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_StopAiConversation _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_StopAiConversation)Delegate.Combine(_MultiCastDel, (Del_StopAiConversation)Del);
		}
		else
		{
			_MultiCastDel = (Del_StopAiConversation)Delegate.Remove(_MultiCastDel, (Del_StopAiConversation)Del);
		}
	}

	public static GSDel_StopAiConversation operator +(GSDel_StopAiConversation GSEvent, Del_StopAiConversation Del)
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
		GSEvent._MultiCastDel = (Del_StopAiConversation)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_StopAiConversation operator -(GSDel_StopAiConversation GSEvent, Del_StopAiConversation Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_StopAiConversation == Del)
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
		GSEvent._MultiCastDel = (Del_StopAiConversation)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(AActor Unit, EACInterruptType InterruptType, EACInterruptReason InterruptReason)
	{
		_MultiCastDel?.Invoke(Unit, InterruptType, InterruptReason);
	}
}
