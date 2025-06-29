using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_OnSkillCostDmg_ICB : IFreshAbleGSEvent
{
	private Del_OnSkillCostDmg _InvokeCallBack;

	private Action<Del_OnSkillCostDmg> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnSkillCostDmg _MultiCastDel;

	public GSDel_OnSkillCostDmg_ICB(Del_OnSkillCostDmg InvokeCallBack, Action<Del_OnSkillCostDmg> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnSkillCostDmg)Delegate.Combine(_MultiCastDel, (Del_OnSkillCostDmg)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnSkillCostDmg)Delegate.Remove(_MultiCastDel, (Del_OnSkillCostDmg)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_OnSkillCostDmg_ICB operator +(GSDel_OnSkillCostDmg_ICB GSEvent, Del_OnSkillCostDmg Del)
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
		GSEvent._MultiCastDel = (Del_OnSkillCostDmg)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_OnSkillCostDmg_ICB operator -(GSDel_OnSkillCostDmg_ICB GSEvent, Del_OnSkillCostDmg Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnSkillCostDmg == Del)
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
		GSEvent._MultiCastDel = (Del_OnSkillCostDmg)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor Victim, int SkillID, int FinalDmg, bool bIsCrit = false)
	{
		_InvokeCallBack?.Invoke(Victim, SkillID, FinalDmg, bIsCrit);
	}
}
