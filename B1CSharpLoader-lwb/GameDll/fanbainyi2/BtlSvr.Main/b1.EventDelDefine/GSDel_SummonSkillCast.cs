using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_SummonSkillCast : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SummonSkillCast _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SummonSkillCast)Delegate.Combine(_MultiCastDel, (Del_SummonSkillCast)Del);
		}
		else
		{
			_MultiCastDel = (Del_SummonSkillCast)Delegate.Remove(_MultiCastDel, (Del_SummonSkillCast)Del);
		}
	}

	public static GSDel_SummonSkillCast operator +(GSDel_SummonSkillCast GSEvent, Del_SummonSkillCast Del)
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
		GSEvent._MultiCastDel = (Del_SummonSkillCast)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_SummonSkillCast operator -(GSDel_SummonSkillCast GSEvent, Del_SummonSkillCast Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SummonSkillCast == Del)
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
		GSEvent._MultiCastDel = (Del_SummonSkillCast)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(int SummonID, int SummonPointIndex, AActor EffectCaster, in FEffectInstReq EffectInstReq, bool TeleportSelf = false, AActor SelectPointActor = null)
	{
		_MultiCastDel?.Invoke(SummonID, SummonPointIndex, EffectCaster, in EffectInstReq, TeleportSelf, SelectPointActor);
	}
}
