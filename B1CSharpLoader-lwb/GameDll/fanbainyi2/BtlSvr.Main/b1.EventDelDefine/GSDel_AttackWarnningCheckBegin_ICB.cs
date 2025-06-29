using System;
using System.Collections.Generic;
using b1.ECS;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_AttackWarnningCheckBegin_ICB : IFreshAbleGSEvent
{
	private Del_AttackWarnningCheckBegin _InvokeCallBack;

	private Action<Del_AttackWarnningCheckBegin> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_AttackWarnningCheckBegin _MultiCastDel;

	public GSDel_AttackWarnningCheckBegin_ICB(Del_AttackWarnningCheckBegin InvokeCallBack, Action<Del_AttackWarnningCheckBegin> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_AttackWarnningCheckBegin)Delegate.Combine(_MultiCastDel, (Del_AttackWarnningCheckBegin)Del);
		}
		else
		{
			_MultiCastDel = (Del_AttackWarnningCheckBegin)Delegate.Remove(_MultiCastDel, (Del_AttackWarnningCheckBegin)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_AttackWarnningCheckBegin_ICB operator +(GSDel_AttackWarnningCheckBegin_ICB GSEvent, Del_AttackWarnningCheckBegin Del)
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
		GSEvent._MultiCastDel = (Del_AttackWarnningCheckBegin)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_AttackWarnningCheckBegin_ICB operator -(GSDel_AttackWarnningCheckBegin_ICB GSEvent, Del_AttackWarnningCheckBegin Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_AttackWarnningCheckBegin == Del)
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
		GSEvent._MultiCastDel = (Del_AttackWarnningCheckBegin)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int FromInstanceID, int AttackWarningGroupID, int NotifyID, int WeaponIndex, List<FUStCheckShape> AttackWarnningCheckShape, FVector FixedLocalOffset, ESweepCheckHitFilterType ResultFilterType, int HitLevel, EHitActionDir HitActionDir, float Duration, UAnimSequenceBase Animation, float NotifyBeginTime)
	{
		_InvokeCallBack?.Invoke(FromInstanceID, AttackWarningGroupID, NotifyID, WeaponIndex, AttackWarnningCheckShape, FixedLocalOffset, ResultFilterType, HitLevel, HitActionDir, Duration, Animation, NotifyBeginTime);
	}
}
