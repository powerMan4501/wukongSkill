using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_BuffInstsDictOnAdd_ICB : IFreshAbleGSEvent
{
	private Del_BuffInstsDictOnAdd _InvokeCallBack;

	private Action<Del_BuffInstsDictOnAdd> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_BuffInstsDictOnAdd _MultiCastDel;

	public GSDel_BuffInstsDictOnAdd_ICB(Del_BuffInstsDictOnAdd InvokeCallBack, Action<Del_BuffInstsDictOnAdd> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

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
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_BuffInstsDictOnAdd_ICB operator +(GSDel_BuffInstsDictOnAdd_ICB GSEvent, Del_BuffInstsDictOnAdd Del)
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
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_BuffInstsDictOnAdd_ICB operator -(GSDel_BuffInstsDictOnAdd_ICB GSEvent, Del_BuffInstsDictOnAdd Del)
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
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int BuffID, float Duration, EBuffSourceType BuffSourceType, AActor Caster)
	{
		_InvokeCallBack?.Invoke(BuffID, Duration, BuffSourceType, Caster);
	}
}
