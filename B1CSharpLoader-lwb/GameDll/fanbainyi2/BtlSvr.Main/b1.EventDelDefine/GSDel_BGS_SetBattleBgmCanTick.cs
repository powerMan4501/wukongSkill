using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_BGS_SetBattleBgmCanTick : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_BGS_SetBattleBgmCanTick _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_BGS_SetBattleBgmCanTick)Delegate.Combine(_MultiCastDel, (Del_BGS_SetBattleBgmCanTick)Del);
		}
		else
		{
			_MultiCastDel = (Del_BGS_SetBattleBgmCanTick)Delegate.Remove(_MultiCastDel, (Del_BGS_SetBattleBgmCanTick)Del);
		}
	}

	public static GSDel_BGS_SetBattleBgmCanTick operator +(GSDel_BGS_SetBattleBgmCanTick GSEvent, Del_BGS_SetBattleBgmCanTick Del)
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
		GSEvent._MultiCastDel = (Del_BGS_SetBattleBgmCanTick)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_BGS_SetBattleBgmCanTick operator -(GSDel_BGS_SetBattleBgmCanTick GSEvent, Del_BGS_SetBattleBgmCanTick Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_BGS_SetBattleBgmCanTick == Del)
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
		GSEvent._MultiCastDel = (Del_BGS_SetBattleBgmCanTick)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(bool NewIsCanTick)
	{
		_MultiCastDel?.Invoke(NewIsCanTick);
	}
}
