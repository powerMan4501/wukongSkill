using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_ProjectileGetSlotNameToBack_ICB : IFreshAbleGSEvent
{
	private Del_ProjectileGetSlotNameToBack _InvokeCallBack;

	private Action<Del_ProjectileGetSlotNameToBack> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ProjectileGetSlotNameToBack _MultiCastDel;

	public GSDel_ProjectileGetSlotNameToBack_ICB(Del_ProjectileGetSlotNameToBack InvokeCallBack, Action<Del_ProjectileGetSlotNameToBack> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ProjectileGetSlotNameToBack)Delegate.Combine(_MultiCastDel, (Del_ProjectileGetSlotNameToBack)Del);
		}
		else
		{
			_MultiCastDel = (Del_ProjectileGetSlotNameToBack)Delegate.Remove(_MultiCastDel, (Del_ProjectileGetSlotNameToBack)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_ProjectileGetSlotNameToBack_ICB operator +(GSDel_ProjectileGetSlotNameToBack_ICB GSEvent, Del_ProjectileGetSlotNameToBack Del)
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
		GSEvent._MultiCastDel = (Del_ProjectileGetSlotNameToBack)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_ProjectileGetSlotNameToBack_ICB operator -(GSDel_ProjectileGetSlotNameToBack_ICB GSEvent, Del_ProjectileGetSlotNameToBack Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ProjectileGetSlotNameToBack == Del)
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
		GSEvent._MultiCastDel = (Del_ProjectileGetSlotNameToBack)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public FName Invoke(string PreSlotName)
	{
		if (_InvokeCallBack == null)
		{
			return default(FName);
		}
		return _InvokeCallBack(PreSlotName);
	}
}
