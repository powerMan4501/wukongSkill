using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_OnNotifyStateSpawnProjectileObj_ICB : IFreshAbleGSEvent
{
	private Del_OnNotifyStateSpawnProjectileObj _InvokeCallBack;

	private Action<Del_OnNotifyStateSpawnProjectileObj> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnNotifyStateSpawnProjectileObj _MultiCastDel;

	public GSDel_OnNotifyStateSpawnProjectileObj_ICB(Del_OnNotifyStateSpawnProjectileObj InvokeCallBack, Action<Del_OnNotifyStateSpawnProjectileObj> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

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
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_OnNotifyStateSpawnProjectileObj_ICB operator +(GSDel_OnNotifyStateSpawnProjectileObj_ICB GSEvent, Del_OnNotifyStateSpawnProjectileObj Del)
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
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_OnNotifyStateSpawnProjectileObj_ICB operator -(GSDel_OnNotifyStateSpawnProjectileObj_ICB GSEvent, Del_OnNotifyStateSpawnProjectileObj Del)
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
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(ref FGSProjecttileObjSpawnNSInfo ProjectileSpawnNSInfo, bool bNeedHandleStopReq = false, EProjectileSpawnMethod SpawnMethod = EProjectileSpawnMethod.None, int MethodUniqueID = -1)
	{
		_InvokeCallBack?.Invoke(ref ProjectileSpawnNSInfo, bNeedHandleStopReq, SpawnMethod, MethodUniqueID);
	}
}
