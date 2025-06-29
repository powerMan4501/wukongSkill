using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SmartCastSkillTry_ICB : IFreshAbleGSEvent
{
	private Del_SmartCastSkillTry _InvokeCallBack;

	private Action<Del_SmartCastSkillTry> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SmartCastSkillTry _MultiCastDel;

	public GSDel_SmartCastSkillTry_ICB(Del_SmartCastSkillTry InvokeCallBack, Action<Del_SmartCastSkillTry> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SmartCastSkillTry)Delegate.Combine(_MultiCastDel, (Del_SmartCastSkillTry)Del);
		}
		else
		{
			_MultiCastDel = (Del_SmartCastSkillTry)Delegate.Remove(_MultiCastDel, (Del_SmartCastSkillTry)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SmartCastSkillTry_ICB operator +(GSDel_SmartCastSkillTry_ICB GSEvent, Del_SmartCastSkillTry Del)
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
		GSEvent._MultiCastDel = (Del_SmartCastSkillTry)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SmartCastSkillTry_ICB operator -(GSDel_SmartCastSkillTry_ICB GSEvent, Del_SmartCastSkillTry Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SmartCastSkillTry == Del)
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
		GSEvent._MultiCastDel = (Del_SmartCastSkillTry)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int ID, List<int> RuleIDList, EMontageBindReason Reason = EMontageBindReason.Default, ESkillDirection SkillDirection = ESkillDirection.None, bool bNeedCheckSkillCanCast = true, ECastSkillSourceType SourceType = ECastSkillSourceType.SmartCastSkill)
	{
		_InvokeCallBack?.Invoke(ID, RuleIDList, Reason, SkillDirection, bNeedCheckSkillCanCast, SourceType);
	}
}
