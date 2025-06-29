using System;
using System.Collections.Generic;
using b1.ECS;
using OssB1;

namespace b1.EventDelDefine;

public class GSDel_OnPlayerLeaveBattle : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnPlayerLeaveBattle _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnPlayerLeaveBattle)Delegate.Combine(_MultiCastDel, (Del_OnPlayerLeaveBattle)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnPlayerLeaveBattle)Delegate.Remove(_MultiCastDel, (Del_OnPlayerLeaveBattle)Del);
		}
	}

	public static GSDel_OnPlayerLeaveBattle operator +(GSDel_OnPlayerLeaveBattle GSEvent, Del_OnPlayerLeaveBattle Del)
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
		GSEvent._MultiCastDel = (Del_OnPlayerLeaveBattle)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_OnPlayerLeaveBattle operator -(GSDel_OnPlayerLeaveBattle GSEvent, Del_OnPlayerLeaveBattle Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnPlayerLeaveBattle == Del)
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
		GSEvent._MultiCastDel = (Del_OnPlayerLeaveBattle)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(ulong RoleId, BattlePlayer Player, int LeaveFightTime, bool bIsTransUnit, bool bBecauseOfTrans)
	{
		_MultiCastDel?.Invoke(RoleId, Player, LeaveFightTime, bIsTransUnit, bBecauseOfTrans);
	}
}
