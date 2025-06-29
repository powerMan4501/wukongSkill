using System;
using System.Collections.Generic;
using b1.ECS;
using BtlShare;
using UnrealEngine.Plugins.EnhancedInput;

namespace b1.EventDelDefine;

public class GSDel_TriggerItemSkillAction_ShortCut_ICB : IFreshAbleGSEvent
{
	private Del_TriggerItemSkillAction_ShortCut _InvokeCallBack;

	private Action<Del_TriggerItemSkillAction_ShortCut> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerItemSkillAction_ShortCut _MultiCastDel;

	public GSDel_TriggerItemSkillAction_ShortCut_ICB(Del_TriggerItemSkillAction_ShortCut InvokeCallBack, Action<Del_TriggerItemSkillAction_ShortCut> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TriggerItemSkillAction_ShortCut)Delegate.Combine(_MultiCastDel, (Del_TriggerItemSkillAction_ShortCut)Del);
		}
		else
		{
			_MultiCastDel = (Del_TriggerItemSkillAction_ShortCut)Delegate.Remove(_MultiCastDel, (Del_TriggerItemSkillAction_ShortCut)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_TriggerItemSkillAction_ShortCut_ICB operator +(GSDel_TriggerItemSkillAction_ShortCut_ICB GSEvent, Del_TriggerItemSkillAction_ShortCut Del)
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
		GSEvent._MultiCastDel = (Del_TriggerItemSkillAction_ShortCut)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_TriggerItemSkillAction_ShortCut_ICB operator -(GSDel_TriggerItemSkillAction_ShortCut_ICB GSEvent, Del_TriggerItemSkillAction_ShortCut Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TriggerItemSkillAction_ShortCut == Del)
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
		GSEvent._MultiCastDel = (Del_TriggerItemSkillAction_ShortCut)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int InputActionID, ETriggerEvent TriggerEvent, EInputActionType InputActionType)
	{
		_InvokeCallBack?.Invoke(InputActionID, TriggerEvent, InputActionType);
	}
}
