using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_BGS_PlayerEnterBgmVolume : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_BGS_PlayerEnterBgmVolume _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_BGS_PlayerEnterBgmVolume)Delegate.Combine(_MultiCastDel, (Del_BGS_PlayerEnterBgmVolume)Del);
		}
		else
		{
			_MultiCastDel = (Del_BGS_PlayerEnterBgmVolume)Delegate.Remove(_MultiCastDel, (Del_BGS_PlayerEnterBgmVolume)Del);
		}
	}

	public static GSDel_BGS_PlayerEnterBgmVolume operator +(GSDel_BGS_PlayerEnterBgmVolume GSEvent, Del_BGS_PlayerEnterBgmVolume Del)
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
		GSEvent._MultiCastDel = (Del_BGS_PlayerEnterBgmVolume)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_BGS_PlayerEnterBgmVolume operator -(GSDel_BGS_PlayerEnterBgmVolume GSEvent, Del_BGS_PlayerEnterBgmVolume Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_BGS_PlayerEnterBgmVolume == Del)
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
		GSEvent._MultiCastDel = (Del_BGS_PlayerEnterBgmVolume)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(AActor WanderVolumeActor, BGMVolumeInfo VolumeInfo)
	{
		_MultiCastDel?.Invoke(WanderVolumeActor, VolumeInfo);
	}
}
