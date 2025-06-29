using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_PlayerPossess : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_PlayerPossess _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_PlayerPossess)Delegate.Combine(_MultiCastDel, (Del_PlayerPossess)Del);
		}
		else
		{
			_MultiCastDel = (Del_PlayerPossess)Delegate.Remove(_MultiCastDel, (Del_PlayerPossess)Del);
		}
	}

	public static GSDel_PlayerPossess operator +(GSDel_PlayerPossess GSEvent, Del_PlayerPossess Del)
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
		GSEvent._MultiCastDel = (Del_PlayerPossess)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_PlayerPossess operator -(GSDel_PlayerPossess GSEvent, Del_PlayerPossess Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_PlayerPossess == Del)
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
		GSEvent._MultiCastDel = (Del_PlayerPossess)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(UWorld World, ABGPPlayerController PC, UClass ToReplaceUnitInst, FTransform NewTransform, bool NeedBlend, out APawn NewPlayer, float PossessBlendTime = 0f, int PossessBlendFunc = 0, float PossessBlendExp = 0f, bool EnableBlendViewTarget = false)
	{
		NewPlayer = null;
		_MultiCastDel?.Invoke(World, PC, ToReplaceUnitInst, NewTransform, NeedBlend, out NewPlayer, PossessBlendTime, PossessBlendFunc, PossessBlendExp, EnableBlendViewTarget);
	}
}
