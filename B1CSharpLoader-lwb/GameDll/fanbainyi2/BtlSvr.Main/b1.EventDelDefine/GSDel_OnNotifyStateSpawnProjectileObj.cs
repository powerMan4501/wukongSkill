using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_OnNotifyStateSpawnProjectileObj : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnNotifyStateSpawnProjectileObj _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnNotifyStateSpawnProjectileObj)Delegate.Combine(_MultiCastDel, (Del_OnNotifyStateSpawnProjectileObj)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnNotifyStateSpawnProjectileObj)Delegate.Remove(_MultiCastDel, (Del_OnNotifyStateSpawnProjectileObj)Del);
		}
	}

	public static GSDel_OnNotifyStateSpawnProjectileObj operator +(GSDel_OnNotifyStateSpawnProjectileObj GSEvent, Del_OnNotifyStateSpawnProjectileObj Del)
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
		GSEvent._MultiCastDel = (Del_OnNotifyStateSpawnProjectileObj)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_OnNotifyStateSpawnProjectileObj operator -(GSDel_OnNotifyStateSpawnProjectileObj GSEvent, Del_OnNotifyStateSpawnProjectileObj Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnNotifyStateSpawnProjectileObj == Del)
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
		GSEvent._MultiCastDel = (Del_OnNotifyStateSpawnProjectileObj)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(ref FGSProjecttileObjSpawnNSInfo ProjectileSpawnNSInfo, bool bNeedHandleStopReq = false, EProjectileSpawnMethod SpawnMethod = EProjectileSpawnMethod.None, int MethodUniqueID = -1)
	{
		_MultiCastDel?.Invoke(ref ProjectileSpawnNSInfo, bNeedHandleStopReq, SpawnMethod, MethodUniqueID);
	}
}
