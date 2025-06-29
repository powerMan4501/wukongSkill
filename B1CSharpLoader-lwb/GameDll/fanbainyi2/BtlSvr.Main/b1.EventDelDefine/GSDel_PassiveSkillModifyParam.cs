using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_PassiveSkillModifyParam : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_PassiveSkillModifyParam _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_PassiveSkillModifyParam)Delegate.Combine(_MultiCastDel, (Del_PassiveSkillModifyParam)Del);
		}
		else
		{
			_MultiCastDel = (Del_PassiveSkillModifyParam)Delegate.Remove(_MultiCastDel, (Del_PassiveSkillModifyParam)Del);
		}
	}

	public static GSDel_PassiveSkillModifyParam operator +(GSDel_PassiveSkillModifyParam GSEvent, Del_PassiveSkillModifyParam Del)
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
		GSEvent._MultiCastDel = (Del_PassiveSkillModifyParam)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_PassiveSkillModifyParam operator -(GSDel_PassiveSkillModifyParam GSEvent, Del_PassiveSkillModifyParam Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_PassiveSkillModifyParam == Del)
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
		GSEvent._MultiCastDel = (Del_PassiveSkillModifyParam)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(int PassiveSkillID, int PassiveSkillMappingIndexID, bool bRecover, int Level)
	{
		_MultiCastDel?.Invoke(PassiveSkillID, PassiveSkillMappingIndexID, bRecover, Level);
	}
}
