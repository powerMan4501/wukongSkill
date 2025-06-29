using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_BGW_OnSkillValidAttackFrameEnded : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_BGW_OnSkillValidAttackFrameEnded _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_BGW_OnSkillValidAttackFrameEnded)Delegate.Combine(_MultiCastDel, (Del_BGW_OnSkillValidAttackFrameEnded)Del);
		}
		else
		{
			_MultiCastDel = (Del_BGW_OnSkillValidAttackFrameEnded)Delegate.Remove(_MultiCastDel, (Del_BGW_OnSkillValidAttackFrameEnded)Del);
		}
	}

	public static GSDel_BGW_OnSkillValidAttackFrameEnded operator +(GSDel_BGW_OnSkillValidAttackFrameEnded GSEvent, Del_BGW_OnSkillValidAttackFrameEnded Del)
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
		GSEvent._MultiCastDel = (Del_BGW_OnSkillValidAttackFrameEnded)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_BGW_OnSkillValidAttackFrameEnded operator -(GSDel_BGW_OnSkillValidAttackFrameEnded GSEvent, Del_BGW_OnSkillValidAttackFrameEnded Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_BGW_OnSkillValidAttackFrameEnded == Del)
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
		GSEvent._MultiCastDel = (Del_BGW_OnSkillValidAttackFrameEnded)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(AActor Attacker, int SkillID)
	{
		_MultiCastDel?.Invoke(Attacker, SkillID);
	}
}
