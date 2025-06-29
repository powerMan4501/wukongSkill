using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_AICastBestComboSkill_ICB : IFreshAbleGSEvent
{
	private Del_AICastBestComboSkill _InvokeCallBack;

	private Action<Del_AICastBestComboSkill> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_AICastBestComboSkill _MultiCastDel;

	public GSDel_AICastBestComboSkill_ICB(Del_AICastBestComboSkill InvokeCallBack, Action<Del_AICastBestComboSkill> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_AICastBestComboSkill)Delegate.Combine(_MultiCastDel, (Del_AICastBestComboSkill)Del);
		}
		else
		{
			_MultiCastDel = (Del_AICastBestComboSkill)Delegate.Remove(_MultiCastDel, (Del_AICastBestComboSkill)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_AICastBestComboSkill_ICB operator +(GSDel_AICastBestComboSkill_ICB GSEvent, Del_AICastBestComboSkill Del)
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
		GSEvent._MultiCastDel = (Del_AICastBestComboSkill)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_AICastBestComboSkill_ICB operator -(GSDel_AICastBestComboSkill_ICB GSEvent, Del_AICastBestComboSkill Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_AICastBestComboSkill == Del)
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
		GSEvent._MultiCastDel = (Del_AICastBestComboSkill)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(UnitLockTargetInfo ComboTargetData, List<int> SkillIDList, bool IsFirstSkill, int CurComboSkillNum, int CurComboStage, bool IsGetTopRange, int TopPercent, bool EnableForceComboRelation, bool UseComboCondition, bool UsePursuitAnyWhere, bool NeedCheckSkillCanCast, bool CastFakeComboSkill, int LastCastSkillID)
	{
		_InvokeCallBack?.Invoke(ComboTargetData, SkillIDList, IsFirstSkill, CurComboSkillNum, CurComboStage, IsGetTopRange, TopPercent, EnableForceComboRelation, UseComboCondition, UsePursuitAnyWhere, NeedCheckSkillCanCast, CastFakeComboSkill, LastCastSkillID);
	}
}
