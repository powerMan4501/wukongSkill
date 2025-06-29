using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_CreateTireMark : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_CreateTireMark _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_CreateTireMark)Delegate.Combine(_MultiCastDel, (Del_CreateTireMark)Del);
		}
		else
		{
			_MultiCastDel = (Del_CreateTireMark)Delegate.Remove(_MultiCastDel, (Del_CreateTireMark)Del);
		}
	}

	public static GSDel_CreateTireMark operator +(GSDel_CreateTireMark GSEvent, Del_CreateTireMark Del)
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
		GSEvent._MultiCastDel = (Del_CreateTireMark)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_CreateTireMark operator -(GSDel_CreateTireMark GSEvent, Del_CreateTireMark Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_CreateTireMark == Del)
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
		GSEvent._MultiCastDel = (Del_CreateTireMark)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(int NotifyInstID, UMaterialInstance DecalInst, FVector DecalSize, FName SocketName, float DecalLifeSpan, float DelayFadeOutTime, float DecalFadeTime)
	{
		_MultiCastDel?.Invoke(NotifyInstID, DecalInst, DecalSize, SocketName, DecalLifeSpan, DelayFadeOutTime, DecalFadeTime);
	}
}
