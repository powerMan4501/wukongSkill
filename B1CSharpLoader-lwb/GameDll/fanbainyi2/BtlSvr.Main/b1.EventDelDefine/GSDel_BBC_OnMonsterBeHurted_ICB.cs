using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_BBC_OnMonsterBeHurted_ICB : IFreshAbleGSEvent
{
	private Del_BBC_OnMonsterBeHurted _InvokeCallBack;

	private Action<Del_BBC_OnMonsterBeHurted> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_BBC_OnMonsterBeHurted _MultiCastDel;

	public GSDel_BBC_OnMonsterBeHurted_ICB(Del_BBC_OnMonsterBeHurted InvokeCallBack, Action<Del_BBC_OnMonsterBeHurted> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_BBC_OnMonsterBeHurted)Delegate.Combine(_MultiCastDel, (Del_BBC_OnMonsterBeHurted)Del);
		}
		else
		{
			_MultiCastDel = (Del_BBC_OnMonsterBeHurted)Delegate.Remove(_MultiCastDel, (Del_BBC_OnMonsterBeHurted)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_BBC_OnMonsterBeHurted_ICB operator +(GSDel_BBC_OnMonsterBeHurted_ICB GSEvent, Del_BBC_OnMonsterBeHurted Del)
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
		GSEvent._MultiCastDel = (Del_BBC_OnMonsterBeHurted)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_BBC_OnMonsterBeHurted_ICB operator -(GSDel_BBC_OnMonsterBeHurted_ICB GSEvent, Del_BBC_OnMonsterBeHurted Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_BBC_OnMonsterBeHurted == Del)
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
		GSEvent._MultiCastDel = (Del_BBC_OnMonsterBeHurted)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int Dmg, bool bIsCrit, bool bIsElemDotDmg)
	{
		_InvokeCallBack?.Invoke(Dmg, bIsCrit, bIsElemDotDmg);
	}
}
