using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_OnProjectileBeHitted_ICB : IFreshAbleGSEvent
{
	private Del_OnProjectileBeHitted _InvokeCallBack;

	private Action<Del_OnProjectileBeHitted> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnProjectileBeHitted _MultiCastDel;

	public GSDel_OnProjectileBeHitted_ICB(Del_OnProjectileBeHitted InvokeCallBack, Action<Del_OnProjectileBeHitted> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnProjectileBeHitted)Delegate.Combine(_MultiCastDel, (Del_OnProjectileBeHitted)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnProjectileBeHitted)Delegate.Remove(_MultiCastDel, (Del_OnProjectileBeHitted)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_OnProjectileBeHitted_ICB operator +(GSDel_OnProjectileBeHitted_ICB GSEvent, Del_OnProjectileBeHitted Del)
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
		GSEvent._MultiCastDel = (Del_OnProjectileBeHitted)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_OnProjectileBeHitted_ICB operator -(GSDel_OnProjectileBeHitted_ICB GSEvent, Del_OnProjectileBeHitted Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnProjectileBeHitted == Del)
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
		GSEvent._MultiCastDel = (Del_OnProjectileBeHitted)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor AttackerActor, List<int> HitVEffectID)
	{
		_InvokeCallBack?.Invoke(AttackerActor, HitVEffectID);
	}
}
