using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_SpawnGhostActor_ICB : IFreshAbleGSEvent
{
	private Del_SpawnGhostActor _InvokeCallBack;

	private Action<Del_SpawnGhostActor> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SpawnGhostActor _MultiCastDel;

	public GSDel_SpawnGhostActor_ICB(Del_SpawnGhostActor InvokeCallBack, Action<Del_SpawnGhostActor> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SpawnGhostActor)Delegate.Combine(_MultiCastDel, (Del_SpawnGhostActor)Del);
		}
		else
		{
			_MultiCastDel = (Del_SpawnGhostActor)Delegate.Remove(_MultiCastDel, (Del_SpawnGhostActor)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SpawnGhostActor_ICB operator +(GSDel_SpawnGhostActor_ICB GSEvent, Del_SpawnGhostActor Del)
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
		GSEvent._MultiCastDel = (Del_SpawnGhostActor)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SpawnGhostActor_ICB operator -(GSDel_SpawnGhostActor_ICB GSEvent, Del_SpawnGhostActor Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SpawnGhostActor == Del)
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
		GSEvent._MultiCastDel = (Del_SpawnGhostActor)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(string DataAssetPath, FEffectInstReq EffectInstReq = default(FEffectInstReq), UAnimMontage MontageToMapTo = null)
	{
		_InvokeCallBack?.Invoke(DataAssetPath, EffectInstReq, MontageToMapTo);
	}
}
