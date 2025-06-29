using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_NotifyAttackerHitSuccess_ICB : IFreshAbleGSEvent
{
	private Del_NotifyAttackerHitSuccess _InvokeCallBack;

	private Action<Del_NotifyAttackerHitSuccess> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_NotifyAttackerHitSuccess _MultiCastDel;

	public GSDel_NotifyAttackerHitSuccess_ICB(Del_NotifyAttackerHitSuccess InvokeCallBack, Action<Del_NotifyAttackerHitSuccess> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_NotifyAttackerHitSuccess)Delegate.Combine(_MultiCastDel, (Del_NotifyAttackerHitSuccess)Del);
		}
		else
		{
			_MultiCastDel = (Del_NotifyAttackerHitSuccess)Delegate.Remove(_MultiCastDel, (Del_NotifyAttackerHitSuccess)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_NotifyAttackerHitSuccess_ICB operator +(GSDel_NotifyAttackerHitSuccess_ICB GSEvent, Del_NotifyAttackerHitSuccess Del)
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
		GSEvent._MultiCastDel = (Del_NotifyAttackerHitSuccess)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_NotifyAttackerHitSuccess_ICB operator -(GSDel_NotifyAttackerHitSuccess_ICB GSEvent, Del_NotifyAttackerHitSuccess Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_NotifyAttackerHitSuccess == Del)
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
		GSEvent._MultiCastDel = (Del_NotifyAttackerHitSuccess)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor VictimActor, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq, bool IsVictimDead)
	{
		_InvokeCallBack?.Invoke(VictimActor, in SkillDamageConfig, in EffectInstReq, IsVictimDead);
	}
}
