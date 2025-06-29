using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_StopAiConversation_ICB : IFreshAbleGSEvent
{
	private Del_StopAiConversation _InvokeCallBack;

	private Action<Del_StopAiConversation> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_StopAiConversation _MultiCastDel;

	public GSDel_StopAiConversation_ICB(Del_StopAiConversation InvokeCallBack, Action<Del_StopAiConversation> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

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
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_StopAiConversation_ICB operator +(GSDel_StopAiConversation_ICB GSEvent, Del_StopAiConversation Del)
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
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_StopAiConversation_ICB operator -(GSDel_StopAiConversation_ICB GSEvent, Del_StopAiConversation Del)
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
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor Unit, EACInterruptType InterruptType, EACInterruptReason InterruptReason)
	{
		_InvokeCallBack?.Invoke(Unit, InterruptType, InterruptReason);
	}
}
