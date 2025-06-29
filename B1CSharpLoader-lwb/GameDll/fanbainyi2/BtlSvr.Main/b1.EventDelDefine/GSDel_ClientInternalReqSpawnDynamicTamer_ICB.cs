using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_ClientInternalReqSpawnDynamicTamer_ICB : IFreshAbleGSEvent
{
	private Del_ClientInternalReqSpawnDynamicTamer _InvokeCallBack;

	private Action<Del_ClientInternalReqSpawnDynamicTamer> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ClientInternalReqSpawnDynamicTamer _MultiCastDel;

	public GSDel_ClientInternalReqSpawnDynamicTamer_ICB(Del_ClientInternalReqSpawnDynamicTamer InvokeCallBack, Action<Del_ClientInternalReqSpawnDynamicTamer> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ClientInternalReqSpawnDynamicTamer)Delegate.Combine(_MultiCastDel, (Del_ClientInternalReqSpawnDynamicTamer)Del);
		}
		else
		{
			_MultiCastDel = (Del_ClientInternalReqSpawnDynamicTamer)Delegate.Remove(_MultiCastDel, (Del_ClientInternalReqSpawnDynamicTamer)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_ClientInternalReqSpawnDynamicTamer_ICB operator +(GSDel_ClientInternalReqSpawnDynamicTamer_ICB GSEvent, Del_ClientInternalReqSpawnDynamicTamer Del)
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
		GSEvent._MultiCastDel = (Del_ClientInternalReqSpawnDynamicTamer)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_ClientInternalReqSpawnDynamicTamer_ICB operator -(GSDel_ClientInternalReqSpawnDynamicTamer_ICB GSEvent, Del_ClientInternalReqSpawnDynamicTamer Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ClientInternalReqSpawnDynamicTamer == Del)
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
		GSEvent._MultiCastDel = (Del_ClientInternalReqSpawnDynamicTamer)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public string Invoke(TSubclassOf<BUTamerActor> TamerClass, FTransform SpawnWorldTransform, FUnitSpawnInfo UnitSpawnInfo, AActor SpawnTrggerActor)
	{
		if (_InvokeCallBack == null)
		{
			return null;
		}
		return _InvokeCallBack(TamerClass, SpawnWorldTransform, UnitSpawnInfo, SpawnTrggerActor);
	}
}
