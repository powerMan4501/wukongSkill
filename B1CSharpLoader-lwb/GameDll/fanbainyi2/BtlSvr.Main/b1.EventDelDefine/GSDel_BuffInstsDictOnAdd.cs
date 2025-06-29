using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_BuffInstsDictOnAdd : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_BuffInstsDictOnAdd _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_BuffInstsDictOnAdd)Delegate.Combine(_MultiCastDel, (Del_BuffInstsDictOnAdd)Del);
		}
		else
		{
			_MultiCastDel = (Del_BuffInstsDictOnAdd)Delegate.Remove(_MultiCastDel, (Del_BuffInstsDictOnAdd)Del);
		}
	}

	public static GSDel_BuffInstsDictOnAdd operator +(GSDel_BuffInstsDictOnAdd GSEvent, Del_BuffInstsDictOnAdd Del)
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
		GSEvent._MultiCastDel = (Del_BuffInstsDictOnAdd)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_BuffInstsDictOnAdd operator -(GSDel_BuffInstsDictOnAdd GSEvent, Del_BuffInstsDictOnAdd Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_BuffInstsDictOnAdd == Del)
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
		GSEvent._MultiCastDel = (Del_BuffInstsDictOnAdd)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(int BuffID, float Duration, EBuffSourceType BuffSourceType, AActor Caster)
	{
		_MultiCastDel?.Invoke(BuffID, Duration, BuffSourceType, Caster);
	}
}
