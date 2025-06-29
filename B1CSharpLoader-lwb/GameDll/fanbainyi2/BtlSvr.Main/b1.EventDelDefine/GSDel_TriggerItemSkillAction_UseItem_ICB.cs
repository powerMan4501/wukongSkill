using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_TriggerItemSkillAction_UseItem_ICB : IFreshAbleGSEvent
{
	private Del_TriggerItemSkillAction_UseItem _InvokeCallBack;

	private Action<Del_TriggerItemSkillAction_UseItem> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerItemSkillAction_UseItem _MultiCastDel;

	public GSDel_TriggerItemSkillAction_UseItem_ICB(Del_TriggerItemSkillAction_UseItem InvokeCallBack, Action<Del_TriggerItemSkillAction_UseItem> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TriggerItemSkillAction_UseItem)Delegate.Combine(_MultiCastDel, (Del_TriggerItemSkillAction_UseItem)Del);
		}
		else
		{
			_MultiCastDel = (Del_TriggerItemSkillAction_UseItem)Delegate.Remove(_MultiCastDel, (Del_TriggerItemSkillAction_UseItem)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_TriggerItemSkillAction_UseItem_ICB operator +(GSDel_TriggerItemSkillAction_UseItem_ICB GSEvent, Del_TriggerItemSkillAction_UseItem Del)
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
		GSEvent._MultiCastDel = (Del_TriggerItemSkillAction_UseItem)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_TriggerItemSkillAction_UseItem_ICB operator -(GSDel_TriggerItemSkillAction_UseItem_ICB GSEvent, Del_TriggerItemSkillAction_UseItem Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TriggerItemSkillAction_UseItem == Del)
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
		GSEvent._MultiCastDel = (Del_TriggerItemSkillAction_UseItem)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int ItemId)
	{
		_InvokeCallBack?.Invoke(ItemId);
	}
}
