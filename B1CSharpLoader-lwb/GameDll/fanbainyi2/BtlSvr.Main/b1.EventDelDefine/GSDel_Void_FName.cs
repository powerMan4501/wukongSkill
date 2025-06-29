using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_Void_FName : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_Void_FName _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_Void_FName)Delegate.Combine(_MultiCastDel, (Del_Void_FName)Del);
		}
		else
		{
			_MultiCastDel = (Del_Void_FName)Delegate.Remove(_MultiCastDel, (Del_Void_FName)Del);
		}
	}

	public static GSDel_Void_FName operator +(GSDel_Void_FName GSEvent, Del_Void_FName Del)
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
		GSEvent._MultiCastDel = (Del_Void_FName)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_Void_FName operator -(GSDel_Void_FName GSEvent, Del_Void_FName Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_Void_FName == Del)
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
		GSEvent._MultiCastDel = (Del_Void_FName)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(FName P1)
	{
		_MultiCastDel?.Invoke(P1);
	}
}
