using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;

namespace b1.EventDelDefine;

public class GSDel_StopAllAiConversation_ICB : IFreshAbleGSEvent
{
	private Del_StopAllAiConversation _InvokeCallBack;

	private Action<Del_StopAllAiConversation> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_StopAllAiConversation _MultiCastDel;

	public GSDel_StopAllAiConversation_ICB(Del_StopAllAiConversation InvokeCallBack, Action<Del_StopAllAiConversation> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_StopAllAiConversation)Delegate.Combine(_MultiCastDel, (Del_StopAllAiConversation)Del);
		}
		else
		{
			_MultiCastDel = (Del_StopAllAiConversation)Delegate.Remove(_MultiCastDel, (Del_StopAllAiConversation)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_StopAllAiConversation_ICB operator +(GSDel_StopAllAiConversation_ICB GSEvent, Del_StopAllAiConversation Del)
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
		GSEvent._MultiCastDel = (Del_StopAllAiConversation)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_StopAllAiConversation_ICB operator -(GSDel_StopAllAiConversation_ICB GSEvent, Del_StopAllAiConversation Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_StopAllAiConversation == Del)
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
		GSEvent._MultiCastDel = (Del_StopAllAiConversation)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EACInterruptType InterruptType, EACInterruptReason InterruptReason)
	{
		_InvokeCallBack?.Invoke(InterruptType, InterruptReason);
	}
}
