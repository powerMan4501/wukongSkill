using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_SetNewConfigDataAsset_ICB : IFreshAbleGSEvent
{
	private Del_SetNewConfigDataAsset _InvokeCallBack;

	private Action<Del_SetNewConfigDataAsset> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetNewConfigDataAsset _MultiCastDel;

	public GSDel_SetNewConfigDataAsset_ICB(Del_SetNewConfigDataAsset InvokeCallBack, Action<Del_SetNewConfigDataAsset> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetNewConfigDataAsset)Delegate.Combine(_MultiCastDel, (Del_SetNewConfigDataAsset)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetNewConfigDataAsset)Delegate.Remove(_MultiCastDel, (Del_SetNewConfigDataAsset)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetNewConfigDataAsset_ICB operator +(GSDel_SetNewConfigDataAsset_ICB GSEvent, Del_SetNewConfigDataAsset Del)
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
		GSEvent._MultiCastDel = (Del_SetNewConfigDataAsset)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetNewConfigDataAsset_ICB operator -(GSDel_SetNewConfigDataAsset_ICB GSEvent, Del_SetNewConfigDataAsset Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetNewConfigDataAsset == Del)
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
		GSEvent._MultiCastDel = (Del_SetNewConfigDataAsset)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor AreaActor, BGWGroupAIMgrConfigDataAsset GroupAIMgrConfigDA, BGWGroupAIBattleHotZoneConfigDataAsset HotZoneConfigDA)
	{
		_InvokeCallBack?.Invoke(AreaActor, GroupAIMgrConfigDA, HotZoneConfigDA);
	}
}
