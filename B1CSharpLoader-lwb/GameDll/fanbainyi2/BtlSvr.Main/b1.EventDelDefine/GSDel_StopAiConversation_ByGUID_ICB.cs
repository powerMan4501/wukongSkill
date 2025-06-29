using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;

namespace b1.EventDelDefine;

public class GSDel_StopAiConversation_ByGUID_ICB : IFreshAbleGSEvent
{
	private Del_StopAiConversation_ByGUID _InvokeCallBack;

	private Action<Del_StopAiConversation_ByGUID> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_StopAiConversation_ByGUID _MultiCastDel;

	public GSDel_StopAiConversation_ByGUID_ICB(Del_StopAiConversation_ByGUID InvokeCallBack, Action<Del_StopAiConversation_ByGUID> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_StopAiConversation_ByGUID)Delegate.Combine(_MultiCastDel, (Del_StopAiConversation_ByGUID)Del);
		}
		else
		{
			_MultiCastDel = (Del_StopAiConversation_ByGUID)Delegate.Remove(_MultiCastDel, (Del_StopAiConversation_ByGUID)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_StopAiConversation_ByGUID_ICB operator +(GSDel_StopAiConversation_ByGUID_ICB GSEvent, Del_StopAiConversation_ByGUID Del)
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
		GSEvent._MultiCastDel = (Del_StopAiConversation_ByGUID)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_StopAiConversation_ByGUID_ICB operator -(GSDel_StopAiConversation_ByGUID_ICB GSEvent, Del_StopAiConversation_ByGUID Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_StopAiConversation_ByGUID == Del)
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
		GSEvent._MultiCastDel = (Del_StopAiConversation_ByGUID)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(string UnitGuid, EACInterruptType InterruptType, EACInterruptReason InterruptReason)
	{
		_InvokeCallBack?.Invoke(UnitGuid, InterruptType, InterruptReason);
	}
}
