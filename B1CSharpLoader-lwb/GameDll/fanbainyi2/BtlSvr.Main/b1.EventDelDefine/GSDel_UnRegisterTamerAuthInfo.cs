using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_UnRegisterTamerAuthInfo : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_UnRegisterTamerAuthInfo _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_UnRegisterTamerAuthInfo)Delegate.Combine(_MultiCastDel, (Del_UnRegisterTamerAuthInfo)Del);
		}
		else
		{
			_MultiCastDel = (Del_UnRegisterTamerAuthInfo)Delegate.Remove(_MultiCastDel, (Del_UnRegisterTamerAuthInfo)Del);
		}
	}

	public static GSDel_UnRegisterTamerAuthInfo operator +(GSDel_UnRegisterTamerAuthInfo GSEvent, Del_UnRegisterTamerAuthInfo Del)
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
		GSEvent._MultiCastDel = (Del_UnRegisterTamerAuthInfo)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_UnRegisterTamerAuthInfo operator -(GSDel_UnRegisterTamerAuthInfo GSEvent, Del_UnRegisterTamerAuthInfo Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_UnRegisterTamerAuthInfo == Del)
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
		GSEvent._MultiCastDel = (Del_UnRegisterTamerAuthInfo)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public bool Invoke(string TamerGuid, APlayerController PlayerController)
	{
		if (_MultiCastDel == null)
		{
			return false;
		}
		return _MultiCastDel(TamerGuid, PlayerController);
	}
}
