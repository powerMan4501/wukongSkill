using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_UnitCastSkillFail_ICB : IFreshAbleGSEvent
{
	private Del_UnitCastSkillFail _InvokeCallBack;

	private Action<Del_UnitCastSkillFail> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_UnitCastSkillFail _MultiCastDel;

	public GSDel_UnitCastSkillFail_ICB(Del_UnitCastSkillFail InvokeCallBack, Action<Del_UnitCastSkillFail> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_UnitCastSkillFail)Delegate.Combine(_MultiCastDel, (Del_UnitCastSkillFail)Del);
		}
		else
		{
			_MultiCastDel = (Del_UnitCastSkillFail)Delegate.Remove(_MultiCastDel, (Del_UnitCastSkillFail)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_UnitCastSkillFail_ICB operator +(GSDel_UnitCastSkillFail_ICB GSEvent, Del_UnitCastSkillFail Del)
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
		GSEvent._MultiCastDel = (Del_UnitCastSkillFail)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_UnitCastSkillFail_ICB operator -(GSDel_UnitCastSkillFail_ICB GSEvent, Del_UnitCastSkillFail Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_UnitCastSkillFail == Del)
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
		GSEvent._MultiCastDel = (Del_UnitCastSkillFail)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int SkillID, ECanCastSkillResult FailReason)
	{
		_InvokeCallBack?.Invoke(SkillID, FailReason);
	}
}
