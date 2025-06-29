using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_SyncModularData_ICB : IFreshAbleGSEvent
{
	private Del_SyncModularData _InvokeCallBack;

	private Action<Del_SyncModularData> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SyncModularData _MultiCastDel;

	public GSDel_SyncModularData_ICB(Del_SyncModularData InvokeCallBack, Action<Del_SyncModularData> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SyncModularData)Delegate.Combine(_MultiCastDel, (Del_SyncModularData)Del);
		}
		else
		{
			_MultiCastDel = (Del_SyncModularData)Delegate.Remove(_MultiCastDel, (Del_SyncModularData)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SyncModularData_ICB operator +(GSDel_SyncModularData_ICB GSEvent, Del_SyncModularData Del)
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
		GSEvent._MultiCastDel = (Del_SyncModularData)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SyncModularData_ICB operator -(GSDel_SyncModularData_ICB GSEvent, Del_SyncModularData Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SyncModularData == Del)
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
		GSEvent._MultiCastDel = (Del_SyncModularData)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(List<AActor> ModularActors, bool bAutoAttachModularActors, bool bAutoSnapToGround, bool bDestroyAfterOwnerDeath, bool bNeedsCopyPose, Dictionary<FName, int> BreakDownProjectileMap)
	{
		_InvokeCallBack?.Invoke(ModularActors, bAutoAttachModularActors, bAutoSnapToGround, bDestroyAfterOwnerDeath, bNeedsCopyPose, BreakDownProjectileMap);
	}
}
