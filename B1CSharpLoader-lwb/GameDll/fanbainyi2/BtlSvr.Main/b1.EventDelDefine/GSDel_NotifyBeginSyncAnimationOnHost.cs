using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_NotifyBeginSyncAnimationOnHost : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_NotifyBeginSyncAnimationOnHost _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_NotifyBeginSyncAnimationOnHost)Delegate.Combine(_MultiCastDel, (Del_NotifyBeginSyncAnimationOnHost)Del);
		}
		else
		{
			_MultiCastDel = (Del_NotifyBeginSyncAnimationOnHost)Delegate.Remove(_MultiCastDel, (Del_NotifyBeginSyncAnimationOnHost)Del);
		}
	}

	public static GSDel_NotifyBeginSyncAnimationOnHost operator +(GSDel_NotifyBeginSyncAnimationOnHost GSEvent, Del_NotifyBeginSyncAnimationOnHost Del)
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
		GSEvent._MultiCastDel = (Del_NotifyBeginSyncAnimationOnHost)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_NotifyBeginSyncAnimationOnHost operator -(GSDel_NotifyBeginSyncAnimationOnHost GSEvent, Del_NotifyBeginSyncAnimationOnHost Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_NotifyBeginSyncAnimationOnHost == Del)
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
		GSEvent._MultiCastDel = (Del_NotifyBeginSyncAnimationOnHost)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(List<int> PreAnimationSyncStateHostBuffList, UAnimMontage GuestMontage, bool bFoundHostSyncPointOnDummyMesh, FName SelfSyncPointOnHost, FName TargetSyncPointOnHost, FName SelfSyncPointOnGuest, bool bForceSyncDummyMeshAnimation, bool bEnableDebugDraw, float NotifyBeginTime, float TotalDuration, int AnimationSyncMontageInstanceID)
	{
		_MultiCastDel?.Invoke(PreAnimationSyncStateHostBuffList, GuestMontage, bFoundHostSyncPointOnDummyMesh, SelfSyncPointOnHost, TargetSyncPointOnHost, SelfSyncPointOnGuest, bForceSyncDummyMeshAnimation, bEnableDebugDraw, NotifyBeginTime, TotalDuration, AnimationSyncMontageInstanceID);
	}
}
