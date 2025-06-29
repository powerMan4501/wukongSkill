using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_AICastBestComboSkill : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_AICastBestComboSkill _MultiCastDel;

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
	}

	public static GSDel_AICastBestComboSkill operator +(GSDel_AICastBestComboSkill GSEvent, Del_AICastBestComboSkill Del)
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
		return GSEvent;
	}

	public static GSDel_AICastBestComboSkill operator -(GSDel_AICastBestComboSkill GSEvent, Del_AICastBestComboSkill Del)
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
		return GSEvent;
	}

	public void Invoke(UnitLockTargetInfo ComboTargetData, List<int> SkillIDList, bool IsFirstSkill, int CurComboSkillNum, int CurComboStage, bool IsGetTopRange, int TopPercent, bool EnableForceComboRelation, bool UseComboCondition, bool UsePursuitAnyWhere, bool NeedCheckSkillCanCast, bool CastFakeComboSkill, int LastCastSkillID)
	{
		_MultiCastDel?.Invoke(ComboTargetData, SkillIDList, IsFirstSkill, CurComboSkillNum, CurComboStage, IsGetTopRange, TopPercent, EnableForceComboRelation, UseComboCondition, UsePursuitAnyWhere, NeedCheckSkillCanCast, CastFakeComboSkill, LastCastSkillID);
	}
}
