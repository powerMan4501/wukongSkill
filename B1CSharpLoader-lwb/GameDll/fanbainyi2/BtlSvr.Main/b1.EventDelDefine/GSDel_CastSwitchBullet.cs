using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_CastSwitchBullet : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_CastSwitchBullet _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_CastSwitchBullet)Delegate.Combine(_MultiCastDel, (Del_CastSwitchBullet)Del);
		}
		else
		{
			_MultiCastDel = (Del_CastSwitchBullet)Delegate.Remove(_MultiCastDel, (Del_CastSwitchBullet)Del);
		}
	}

	public static GSDel_CastSwitchBullet operator +(GSDel_CastSwitchBullet GSEvent, Del_CastSwitchBullet Del)
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
		GSEvent._MultiCastDel = (Del_CastSwitchBullet)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_CastSwitchBullet operator -(GSDel_CastSwitchBullet GSEvent, Del_CastSwitchBullet Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_CastSwitchBullet == Del)
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
		GSEvent._MultiCastDel = (Del_CastSwitchBullet)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(int ctr_number, int BulletSwitchID, float SwitchInterval, float DestroyTimeFilter, ESwitchFilterMode FilterMode, int FilterBulletID, bool bSwitchImmediate, bool bSelectWithOrder = true)
	{
		_MultiCastDel?.Invoke(ctr_number, BulletSwitchID, SwitchInterval, DestroyTimeFilter, FilterMode, FilterBulletID, bSwitchImmediate, bSelectWithOrder);
	}
}
