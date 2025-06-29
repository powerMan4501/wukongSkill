using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;

namespace b1.EventDelDefine;

public class GSDel_ReceiveMagicSkill_ICB : IFreshAbleGSEvent
{
	private Del_ReceiveMagicSkill _InvokeCallBack;

	private Action<Del_ReceiveMagicSkill> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ReceiveMagicSkill _MultiCastDel;

	public GSDel_ReceiveMagicSkill_ICB(Del_ReceiveMagicSkill InvokeCallBack, Action<Del_ReceiveMagicSkill> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ReceiveMagicSkill)Delegate.Combine(_MultiCastDel, (Del_ReceiveMagicSkill)Del);
		}
		else
		{
			_MultiCastDel = (Del_ReceiveMagicSkill)Delegate.Remove(_MultiCastDel, (Del_ReceiveMagicSkill)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_ReceiveMagicSkill_ICB operator +(GSDel_ReceiveMagicSkill_ICB GSEvent, Del_ReceiveMagicSkill Del)
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
		GSEvent._MultiCastDel = (Del_ReceiveMagicSkill)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_ReceiveMagicSkill_ICB operator -(GSDel_ReceiveMagicSkill_ICB GSEvent, Del_ReceiveMagicSkill Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ReceiveMagicSkill == Del)
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
		GSEvent._MultiCastDel = (Del_ReceiveMagicSkill)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EMagicSkillMapping MagicSkill)
	{
		_InvokeCallBack?.Invoke(MagicSkill);
	}
}
