using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_CopySkillSummonBehavior_ICB : IFreshAbleGSEvent
{
	private Del_CopySkillSummonBehavior _InvokeCallBack;

	private Action<Del_CopySkillSummonBehavior> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_CopySkillSummonBehavior _MultiCastDel;

	public GSDel_CopySkillSummonBehavior_ICB(Del_CopySkillSummonBehavior InvokeCallBack, Action<Del_CopySkillSummonBehavior> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_CopySkillSummonBehavior)Delegate.Combine(_MultiCastDel, (Del_CopySkillSummonBehavior)Del);
		}
		else
		{
			_MultiCastDel = (Del_CopySkillSummonBehavior)Delegate.Remove(_MultiCastDel, (Del_CopySkillSummonBehavior)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_CopySkillSummonBehavior_ICB operator +(GSDel_CopySkillSummonBehavior_ICB GSEvent, Del_CopySkillSummonBehavior Del)
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
		GSEvent._MultiCastDel = (Del_CopySkillSummonBehavior)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_CopySkillSummonBehavior_ICB operator -(GSDel_CopySkillSummonBehavior_ICB GSEvent, Del_CopySkillSummonBehavior Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_CopySkillSummonBehavior == Del)
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
		GSEvent._MultiCastDel = (Del_CopySkillSummonBehavior)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(UAnimMontage CopyAnim, in FTransform TeleportTrans)
	{
		_InvokeCallBack?.Invoke(CopyAnim, in TeleportTrans);
	}
}
