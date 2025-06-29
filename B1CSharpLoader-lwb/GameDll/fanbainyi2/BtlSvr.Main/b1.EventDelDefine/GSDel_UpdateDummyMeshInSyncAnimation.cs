using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_UpdateDummyMeshInSyncAnimation : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_UpdateDummyMeshInSyncAnimation _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_UpdateDummyMeshInSyncAnimation)Delegate.Combine(_MultiCastDel, (Del_UpdateDummyMeshInSyncAnimation)Del);
		}
		else
		{
			_MultiCastDel = (Del_UpdateDummyMeshInSyncAnimation)Delegate.Remove(_MultiCastDel, (Del_UpdateDummyMeshInSyncAnimation)Del);
		}
	}

	public static GSDel_UpdateDummyMeshInSyncAnimation operator +(GSDel_UpdateDummyMeshInSyncAnimation GSEvent, Del_UpdateDummyMeshInSyncAnimation Del)
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
		GSEvent._MultiCastDel = (Del_UpdateDummyMeshInSyncAnimation)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_UpdateDummyMeshInSyncAnimation operator -(GSDel_UpdateDummyMeshInSyncAnimation GSEvent, Del_UpdateDummyMeshInSyncAnimation Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_UpdateDummyMeshInSyncAnimation == Del)
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
		GSEvent._MultiCastDel = (Del_UpdateDummyMeshInSyncAnimation)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(in FName AttachSocketOnHost, in FName AttachSocketOnDummyMesh, UAnimationAsset DummyMeshAnimation)
	{
		_MultiCastDel?.Invoke(in AttachSocketOnHost, in AttachSocketOnDummyMesh, DummyMeshAnimation);
	}
}
