using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_SpawnDropItemOnLoad_ICB : IFreshAbleGSEvent
{
	private Del_SpawnDropItemOnLoad _InvokeCallBack;

	private Action<Del_SpawnDropItemOnLoad> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SpawnDropItemOnLoad _MultiCastDel;

	public GSDel_SpawnDropItemOnLoad_ICB(Del_SpawnDropItemOnLoad InvokeCallBack, Action<Del_SpawnDropItemOnLoad> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SpawnDropItemOnLoad)Delegate.Combine(_MultiCastDel, (Del_SpawnDropItemOnLoad)Del);
		}
		else
		{
			_MultiCastDel = (Del_SpawnDropItemOnLoad)Delegate.Remove(_MultiCastDel, (Del_SpawnDropItemOnLoad)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SpawnDropItemOnLoad_ICB operator +(GSDel_SpawnDropItemOnLoad_ICB GSEvent, Del_SpawnDropItemOnLoad Del)
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
		GSEvent._MultiCastDel = (Del_SpawnDropItemOnLoad)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SpawnDropItemOnLoad_ICB operator -(GSDel_SpawnDropItemOnLoad_ICB GSEvent, Del_SpawnDropItemOnLoad Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SpawnDropItemOnLoad == Del)
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
		GSEvent._MultiCastDel = (Del_SpawnDropItemOnLoad)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int ItemID, FTransform Transform, ref AActor DropItem)
	{
		_InvokeCallBack?.Invoke(ItemID, Transform, ref DropItem);
	}
}
