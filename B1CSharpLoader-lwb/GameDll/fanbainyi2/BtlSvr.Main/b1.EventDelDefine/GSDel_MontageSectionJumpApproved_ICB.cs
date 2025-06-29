using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_MontageSectionJumpApproved_ICB : IFreshAbleGSEvent
{
	private Del_MontageSectionJumpApproved _InvokeCallBack;

	private Action<Del_MontageSectionJumpApproved> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_MontageSectionJumpApproved _MultiCastDel;

	public GSDel_MontageSectionJumpApproved_ICB(Del_MontageSectionJumpApproved InvokeCallBack, Action<Del_MontageSectionJumpApproved> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_MontageSectionJumpApproved)Delegate.Combine(_MultiCastDel, (Del_MontageSectionJumpApproved)Del);
		}
		else
		{
			_MultiCastDel = (Del_MontageSectionJumpApproved)Delegate.Remove(_MultiCastDel, (Del_MontageSectionJumpApproved)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_MontageSectionJumpApproved_ICB operator +(GSDel_MontageSectionJumpApproved_ICB GSEvent, Del_MontageSectionJumpApproved Del)
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
		GSEvent._MultiCastDel = (Del_MontageSectionJumpApproved)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_MontageSectionJumpApproved_ICB operator -(GSDel_MontageSectionJumpApproved_ICB GSEvent, Del_MontageSectionJumpApproved Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_MontageSectionJumpApproved == Del)
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
		GSEvent._MultiCastDel = (Del_MontageSectionJumpApproved)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(MontageSectionJumpType SectionJumpType, float TimeBeforeNextSection)
	{
		_InvokeCallBack?.Invoke(SectionJumpType, TimeBeforeNextSection);
	}
}
