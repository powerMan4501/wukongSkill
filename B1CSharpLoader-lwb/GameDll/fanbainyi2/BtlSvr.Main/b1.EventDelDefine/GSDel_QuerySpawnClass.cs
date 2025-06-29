using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_QuerySpawnClass : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_QuerySpawnClass _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_QuerySpawnClass)Delegate.Combine(_MultiCastDel, (Del_QuerySpawnClass)Del);
		}
		else
		{
			_MultiCastDel = (Del_QuerySpawnClass)Delegate.Remove(_MultiCastDel, (Del_QuerySpawnClass)Del);
		}
	}

	public static GSDel_QuerySpawnClass operator +(GSDel_QuerySpawnClass GSEvent, Del_QuerySpawnClass Del)
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
		GSEvent._MultiCastDel = (Del_QuerySpawnClass)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_QuerySpawnClass operator -(GSDel_QuerySpawnClass GSEvent, Del_QuerySpawnClass Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_QuerySpawnClass == Del)
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
		GSEvent._MultiCastDel = (Del_QuerySpawnClass)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(List<EMobAttackType> AttackTypes, in int WaveIndex, in int MinNum, in int MaxNum, FVector SpawnerLoc, out Dictionary<TSubclassOf<BGUCharacterCS>, int> OutSpawnClassNum)
	{
		OutSpawnClassNum = null;
		_MultiCastDel?.Invoke(AttackTypes, in WaveIndex, in MinNum, in MaxNum, SpawnerLoc, out OutSpawnClassNum);
	}
}
