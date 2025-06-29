using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_SpawnAllNianhuiDropItem_ICB : IFreshAbleGSEvent
{
	private Del_SpawnAllNianhuiDropItem _InvokeCallBack;

	private Action<Del_SpawnAllNianhuiDropItem> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SpawnAllNianhuiDropItem _MultiCastDel;

	public GSDel_SpawnAllNianhuiDropItem_ICB(Del_SpawnAllNianhuiDropItem InvokeCallBack, Action<Del_SpawnAllNianhuiDropItem> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SpawnAllNianhuiDropItem)Delegate.Combine(_MultiCastDel, (Del_SpawnAllNianhuiDropItem)Del);
		}
		else
		{
			_MultiCastDel = (Del_SpawnAllNianhuiDropItem)Delegate.Remove(_MultiCastDel, (Del_SpawnAllNianhuiDropItem)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SpawnAllNianhuiDropItem_ICB operator +(GSDel_SpawnAllNianhuiDropItem_ICB GSEvent, Del_SpawnAllNianhuiDropItem Del)
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
		GSEvent._MultiCastDel = (Del_SpawnAllNianhuiDropItem)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SpawnAllNianhuiDropItem_ICB operator -(GSDel_SpawnAllNianhuiDropItem_ICB GSEvent, Del_SpawnAllNianhuiDropItem Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SpawnAllNianhuiDropItem == Del)
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
		GSEvent._MultiCastDel = (Del_SpawnAllNianhuiDropItem)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(in List<FVector> SpawnPosList)
	{
		_InvokeCallBack?.Invoke(in SpawnPosList);
	}
}
