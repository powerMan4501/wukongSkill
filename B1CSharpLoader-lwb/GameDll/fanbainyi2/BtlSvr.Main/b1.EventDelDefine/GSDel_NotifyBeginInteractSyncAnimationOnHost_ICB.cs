using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_NotifyBeginInteractSyncAnimationOnHost_ICB : IFreshAbleGSEvent
{
	private Del_NotifyBeginInteractSyncAnimationOnHost _InvokeCallBack;

	private Action<Del_NotifyBeginInteractSyncAnimationOnHost> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_NotifyBeginInteractSyncAnimationOnHost _MultiCastDel;

	public GSDel_NotifyBeginInteractSyncAnimationOnHost_ICB(Del_NotifyBeginInteractSyncAnimationOnHost InvokeCallBack, Action<Del_NotifyBeginInteractSyncAnimationOnHost> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_NotifyBeginInteractSyncAnimationOnHost)Delegate.Combine(_MultiCastDel, (Del_NotifyBeginInteractSyncAnimationOnHost)Del);
		}
		else
		{
			_MultiCastDel = (Del_NotifyBeginInteractSyncAnimationOnHost)Delegate.Remove(_MultiCastDel, (Del_NotifyBeginInteractSyncAnimationOnHost)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_NotifyBeginInteractSyncAnimationOnHost_ICB operator +(GSDel_NotifyBeginInteractSyncAnimationOnHost_ICB GSEvent, Del_NotifyBeginInteractSyncAnimationOnHost Del)
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
		GSEvent._MultiCastDel = (Del_NotifyBeginInteractSyncAnimationOnHost)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_NotifyBeginInteractSyncAnimationOnHost_ICB operator -(GSDel_NotifyBeginInteractSyncAnimationOnHost_ICB GSEvent, Del_NotifyBeginInteractSyncAnimationOnHost Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_NotifyBeginInteractSyncAnimationOnHost == Del)
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
		GSEvent._MultiCastDel = (Del_NotifyBeginInteractSyncAnimationOnHost)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor Guest, FName AttachSocketOnHost, FName AttachSocketOnDummyMesh, UAnimationAsset DummyMeshAnimation)
	{
		_InvokeCallBack?.Invoke(Guest, AttachSocketOnHost, AttachSocketOnDummyMesh, DummyMeshAnimation);
	}
}
