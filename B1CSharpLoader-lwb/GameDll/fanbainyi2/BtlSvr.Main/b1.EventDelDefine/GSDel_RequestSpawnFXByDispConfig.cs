using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_RequestSpawnFXByDispConfig : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_RequestSpawnFXByDispConfig _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_RequestSpawnFXByDispConfig)Delegate.Combine(_MultiCastDel, (Del_RequestSpawnFXByDispConfig)Del);
		}
		else
		{
			_MultiCastDel = (Del_RequestSpawnFXByDispConfig)Delegate.Remove(_MultiCastDel, (Del_RequestSpawnFXByDispConfig)Del);
		}
	}

	public static GSDel_RequestSpawnFXByDispConfig operator +(GSDel_RequestSpawnFXByDispConfig GSEvent, Del_RequestSpawnFXByDispConfig Del)
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
		GSEvent._MultiCastDel = (Del_RequestSpawnFXByDispConfig)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_RequestSpawnFXByDispConfig operator -(GSDel_RequestSpawnFXByDispConfig GSEvent, Del_RequestSpawnFXByDispConfig Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_RequestSpawnFXByDispConfig == Del)
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
		GSEvent._MultiCastDel = (Del_RequestSpawnFXByDispConfig)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(string DispConfigDAPath, out int RequestID, USceneComponent EmitterDispOwnerComp = null, bool NeedSetSpawnTransform = false, FTransform SpawnTransform = default(FTransform))
	{
		RequestID = 0;
		_MultiCastDel?.Invoke(DispConfigDAPath, out RequestID, EmitterDispOwnerComp, NeedSetSpawnTransform, SpawnTransform);
	}
}
