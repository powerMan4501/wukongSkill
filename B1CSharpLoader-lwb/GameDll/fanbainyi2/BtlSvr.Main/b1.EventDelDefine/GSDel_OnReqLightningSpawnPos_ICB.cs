using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_OnReqLightningSpawnPos_ICB : IFreshAbleGSEvent
{
	private Del_OnReqLightningSpawnPos _InvokeCallBack;

	private Action<Del_OnReqLightningSpawnPos> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnReqLightningSpawnPos _MultiCastDel;

	public GSDel_OnReqLightningSpawnPos_ICB(Del_OnReqLightningSpawnPos InvokeCallBack, Action<Del_OnReqLightningSpawnPos> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnReqLightningSpawnPos)Delegate.Combine(_MultiCastDel, (Del_OnReqLightningSpawnPos)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnReqLightningSpawnPos)Delegate.Remove(_MultiCastDel, (Del_OnReqLightningSpawnPos)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_OnReqLightningSpawnPos_ICB operator +(GSDel_OnReqLightningSpawnPos_ICB GSEvent, Del_OnReqLightningSpawnPos Del)
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
		GSEvent._MultiCastDel = (Del_OnReqLightningSpawnPos)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_OnReqLightningSpawnPos_ICB operator -(GSDel_OnReqLightningSpawnPos_ICB GSEvent, Del_OnReqLightningSpawnPos Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnReqLightningSpawnPos == Del)
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
		GSEvent._MultiCastDel = (Del_OnReqLightningSpawnPos)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(List<FVector> TargetPoints, UMeshComponent AttachMeshComp = null, List<FName> SocketList = null)
	{
		_InvokeCallBack?.Invoke(TargetPoints, AttachMeshComp, SocketList);
	}
}
