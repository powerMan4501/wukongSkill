using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_SkillRotateTraceActor_ICB : IFreshAbleGSEvent
{
	private Del_SkillRotateTraceActor _InvokeCallBack;

	private Action<Del_SkillRotateTraceActor> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SkillRotateTraceActor _MultiCastDel;

	public GSDel_SkillRotateTraceActor_ICB(Del_SkillRotateTraceActor InvokeCallBack, Action<Del_SkillRotateTraceActor> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SkillRotateTraceActor)Delegate.Combine(_MultiCastDel, (Del_SkillRotateTraceActor)Del);
		}
		else
		{
			_MultiCastDel = (Del_SkillRotateTraceActor)Delegate.Remove(_MultiCastDel, (Del_SkillRotateTraceActor)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SkillRotateTraceActor_ICB operator +(GSDel_SkillRotateTraceActor_ICB GSEvent, Del_SkillRotateTraceActor Del)
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
		GSEvent._MultiCastDel = (Del_SkillRotateTraceActor)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SkillRotateTraceActor_ICB operator -(GSDel_SkillRotateTraceActor_ICB GSEvent, Del_SkillRotateTraceActor Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SkillRotateTraceActor == Del)
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
		GSEvent._MultiCastDel = (Del_SkillRotateTraceActor)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor TargetActor, float TurnSpeed)
	{
		_InvokeCallBack?.Invoke(TargetActor, TurnSpeed);
	}
}
