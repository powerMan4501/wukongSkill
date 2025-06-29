using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SummonSkillCastByPhantomRush_ICB : IFreshAbleGSEvent
{
	private Del_SummonSkillCastByPhantomRush _InvokeCallBack;

	private Action<Del_SummonSkillCastByPhantomRush> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SummonSkillCastByPhantomRush _MultiCastDel;

	public GSDel_SummonSkillCastByPhantomRush_ICB(Del_SummonSkillCastByPhantomRush InvokeCallBack, Action<Del_SummonSkillCastByPhantomRush> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SummonSkillCastByPhantomRush)Delegate.Combine(_MultiCastDel, (Del_SummonSkillCastByPhantomRush)Del);
		}
		else
		{
			_MultiCastDel = (Del_SummonSkillCastByPhantomRush)Delegate.Remove(_MultiCastDel, (Del_SummonSkillCastByPhantomRush)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SummonSkillCastByPhantomRush_ICB operator +(GSDel_SummonSkillCastByPhantomRush_ICB GSEvent, Del_SummonSkillCastByPhantomRush Del)
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
		GSEvent._MultiCastDel = (Del_SummonSkillCastByPhantomRush)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SummonSkillCastByPhantomRush_ICB operator -(GSDel_SummonSkillCastByPhantomRush_ICB GSEvent, Del_SummonSkillCastByPhantomRush Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SummonSkillCastByPhantomRush == Del)
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
		GSEvent._MultiCastDel = (Del_SummonSkillCastByPhantomRush)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int SummonID, FContinueBehaviorInfo CBI)
	{
		_InvokeCallBack?.Invoke(SummonID, CBI);
	}
}
