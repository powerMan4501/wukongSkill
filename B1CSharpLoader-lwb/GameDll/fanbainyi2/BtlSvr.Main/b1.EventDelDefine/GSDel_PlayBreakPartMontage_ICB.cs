using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_PlayBreakPartMontage_ICB : IFreshAbleGSEvent
{
	private Del_PlayBreakPartMontage _InvokeCallBack;

	private Action<Del_PlayBreakPartMontage> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_PlayBreakPartMontage _MultiCastDel;

	public GSDel_PlayBreakPartMontage_ICB(Del_PlayBreakPartMontage InvokeCallBack, Action<Del_PlayBreakPartMontage> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_PlayBreakPartMontage)Delegate.Combine(_MultiCastDel, (Del_PlayBreakPartMontage)Del);
		}
		else
		{
			_MultiCastDel = (Del_PlayBreakPartMontage)Delegate.Remove(_MultiCastDel, (Del_PlayBreakPartMontage)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_PlayBreakPartMontage_ICB operator +(GSDel_PlayBreakPartMontage_ICB GSEvent, Del_PlayBreakPartMontage Del)
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
		GSEvent._MultiCastDel = (Del_PlayBreakPartMontage)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_PlayBreakPartMontage_ICB operator -(GSDel_PlayBreakPartMontage_ICB GSEvent, Del_PlayBreakPartMontage Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_PlayBreakPartMontage == Del)
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
		GSEvent._MultiCastDel = (Del_PlayBreakPartMontage)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int PartID, string BreakerGUID, EAttackerArea AttackerArea)
	{
		_InvokeCallBack?.Invoke(PartID, BreakerGUID, AttackerArea);
	}
}
