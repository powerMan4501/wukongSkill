using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_PlayAttackHitAudioByRule : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_PlayAttackHitAudioByRule _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_PlayAttackHitAudioByRule)Delegate.Combine(_MultiCastDel, (Del_PlayAttackHitAudioByRule)Del);
		}
		else
		{
			_MultiCastDel = (Del_PlayAttackHitAudioByRule)Delegate.Remove(_MultiCastDel, (Del_PlayAttackHitAudioByRule)Del);
		}
	}

	public static GSDel_PlayAttackHitAudioByRule operator +(GSDel_PlayAttackHitAudioByRule GSEvent, Del_PlayAttackHitAudioByRule Del)
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
		GSEvent._MultiCastDel = (Del_PlayAttackHitAudioByRule)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_PlayAttackHitAudioByRule operator -(GSDel_PlayAttackHitAudioByRule GSEvent, Del_PlayAttackHitAudioByRule Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_PlayAttackHitAudioByRule == Del)
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
		GSEvent._MultiCastDel = (Del_PlayAttackHitAudioByRule)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(AActor Attacker, int HitAudioID, EHitPerformAudioEventType HitPerformAudioEventType, FVector HitResultLocation, FRotator DirectionRotator, int CasterResID, int HitPartID)
	{
		_MultiCastDel?.Invoke(Attacker, HitAudioID, HitPerformAudioEventType, HitResultLocation, DirectionRotator, CasterResID, HitPartID);
	}
}
