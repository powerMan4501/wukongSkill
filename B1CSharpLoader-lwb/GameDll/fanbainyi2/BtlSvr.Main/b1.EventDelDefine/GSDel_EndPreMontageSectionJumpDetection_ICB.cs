using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_EndPreMontageSectionJumpDetection_ICB : IFreshAbleGSEvent
{
	private Del_EndPreMontageSectionJumpDetection _InvokeCallBack;

	private Action<Del_EndPreMontageSectionJumpDetection> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_EndPreMontageSectionJumpDetection _MultiCastDel;

	public GSDel_EndPreMontageSectionJumpDetection_ICB(Del_EndPreMontageSectionJumpDetection InvokeCallBack, Action<Del_EndPreMontageSectionJumpDetection> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_EndPreMontageSectionJumpDetection)Delegate.Combine(_MultiCastDel, (Del_EndPreMontageSectionJumpDetection)Del);
		}
		else
		{
			_MultiCastDel = (Del_EndPreMontageSectionJumpDetection)Delegate.Remove(_MultiCastDel, (Del_EndPreMontageSectionJumpDetection)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_EndPreMontageSectionJumpDetection_ICB operator +(GSDel_EndPreMontageSectionJumpDetection_ICB GSEvent, Del_EndPreMontageSectionJumpDetection Del)
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
		GSEvent._MultiCastDel = (Del_EndPreMontageSectionJumpDetection)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_EndPreMontageSectionJumpDetection_ICB operator -(GSDel_EndPreMontageSectionJumpDetection_ICB GSEvent, Del_EndPreMontageSectionJumpDetection Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_EndPreMontageSectionJumpDetection == Del)
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
		GSEvent._MultiCastDel = (Del_EndPreMontageSectionJumpDetection)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(bool bReversePreDetectionResult, FName JumpToSectionName, bool bJumpImmediately, List<int> BuffsToAddWhenSectionJumpApproved)
	{
		_InvokeCallBack?.Invoke(bReversePreDetectionResult, JumpToSectionName, bJumpImmediately, BuffsToAddWhenSectionJumpApproved);
	}
}
