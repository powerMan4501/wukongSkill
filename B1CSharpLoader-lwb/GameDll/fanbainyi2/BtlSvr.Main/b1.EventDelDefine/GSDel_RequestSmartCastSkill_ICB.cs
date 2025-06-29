using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_RequestSmartCastSkill_ICB : IFreshAbleGSEvent
{
	private Del_RequestSmartCastSkill _InvokeCallBack;

	private Action<Del_RequestSmartCastSkill> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_RequestSmartCastSkill _MultiCastDel;

	public GSDel_RequestSmartCastSkill_ICB(Del_RequestSmartCastSkill InvokeCallBack, Action<Del_RequestSmartCastSkill> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_RequestSmartCastSkill)Delegate.Combine(_MultiCastDel, (Del_RequestSmartCastSkill)Del);
		}
		else
		{
			_MultiCastDel = (Del_RequestSmartCastSkill)Delegate.Remove(_MultiCastDel, (Del_RequestSmartCastSkill)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_RequestSmartCastSkill_ICB operator +(GSDel_RequestSmartCastSkill_ICB GSEvent, Del_RequestSmartCastSkill Del)
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
		GSEvent._MultiCastDel = (Del_RequestSmartCastSkill)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_RequestSmartCastSkill_ICB operator -(GSDel_RequestSmartCastSkill_ICB GSEvent, Del_RequestSmartCastSkill Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_RequestSmartCastSkill == Del)
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
		GSEvent._MultiCastDel = (Del_RequestSmartCastSkill)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int ID, List<int> RuleIDList, EMontageBindReason Reason = EMontageBindReason.Default, bool bNeedCheckSkillCanCast = true, ECastSkillSourceType SourceType = ECastSkillSourceType.SmartCastSkill)
	{
		_InvokeCallBack?.Invoke(ID, RuleIDList, Reason, bNeedCheckSkillCanCast, SourceType);
	}
}
