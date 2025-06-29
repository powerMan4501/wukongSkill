using System;
using System.Collections.Generic;
using b1.ECS;
using BtlShare;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_UnitDead_ICB : IFreshAbleGSEvent
{
	private Action<AActor, EDeadReason, int, int, UAnimMontage, FEffectInstReq, bool, EAbnormalStateType> _InvokeCallBack;

	private Action<Del_UnitDead> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_UnitDead _MultiCastDel;

	public GSDel_UnitDead_ICB(Action<AActor, EDeadReason, int, int, UAnimMontage, FEffectInstReq, bool, EAbnormalStateType> InvokeCallBack, Action<Del_UnitDead> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_UnitDead)Delegate.Combine(_MultiCastDel, (Del_UnitDead)Del);
		}
		else
		{
			_MultiCastDel = (Del_UnitDead)Delegate.Remove(_MultiCastDel, (Del_UnitDead)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_UnitDead_ICB operator +(GSDel_UnitDead_ICB GSEvent, Del_UnitDead Del)
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
		GSEvent._MultiCastDel = (Del_UnitDead)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_UnitDead_ICB operator -(GSDel_UnitDead_ICB GSEvent, Del_UnitDead Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_UnitDead == Del)
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
		GSEvent._MultiCastDel = (Del_UnitDead)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor Attacker, EDeadReason DeadReason, int DmgID = -1, int StiffLevel = -1, UAnimMontage BeAttackedAM = null, FEffectInstReq EffectInstReq = default(FEffectInstReq), bool bIsDotDmg = false, EAbnormalStateType AbnormalStateType = EAbnormalStateType.None)
	{
		_InvokeCallBack?.Invoke(Attacker, DeadReason, DmgID, StiffLevel, BeAttackedAM, EffectInstReq, bIsDotDmg, AbnormalStateType);
	}
}
