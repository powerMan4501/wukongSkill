using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_BeginSyncAnimationOnGuest_ICB : IFreshAbleGSEvent
{
	private Del_BeginSyncAnimationOnGuest _InvokeCallBack;

	private Action<Del_BeginSyncAnimationOnGuest> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_BeginSyncAnimationOnGuest _MultiCastDel;

	public GSDel_BeginSyncAnimationOnGuest_ICB(Del_BeginSyncAnimationOnGuest InvokeCallBack, Action<Del_BeginSyncAnimationOnGuest> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_BeginSyncAnimationOnGuest)Delegate.Combine(_MultiCastDel, (Del_BeginSyncAnimationOnGuest)Del);
		}
		else
		{
			_MultiCastDel = (Del_BeginSyncAnimationOnGuest)Delegate.Remove(_MultiCastDel, (Del_BeginSyncAnimationOnGuest)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_BeginSyncAnimationOnGuest_ICB operator +(GSDel_BeginSyncAnimationOnGuest_ICB GSEvent, Del_BeginSyncAnimationOnGuest Del)
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
		GSEvent._MultiCastDel = (Del_BeginSyncAnimationOnGuest)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_BeginSyncAnimationOnGuest_ICB operator -(GSDel_BeginSyncAnimationOnGuest_ICB GSEvent, Del_BeginSyncAnimationOnGuest Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_BeginSyncAnimationOnGuest == Del)
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
		GSEvent._MultiCastDel = (Del_BeginSyncAnimationOnGuest)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(UAnimMontage GuestMontage, bool bFoundHostSyncPointOnDummyMesh, FName SelfSyncPointOnHost, FName TargetSyncPointOnHost, FName SelfSyncPointOnGuest, bool bEnableDebugDraw, float NotifyBeginTime, float TotalDuration)
	{
		_InvokeCallBack?.Invoke(GuestMontage, bFoundHostSyncPointOnDummyMesh, SelfSyncPointOnHost, TargetSyncPointOnHost, SelfSyncPointOnGuest, bEnableDebugDraw, NotifyBeginTime, TotalDuration);
	}
}
