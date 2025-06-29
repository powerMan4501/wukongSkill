using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_UnitCastSkillSuccess_ICB : IFreshAbleGSEvent
{
	private Del_UnitCastSkillSuccess _InvokeCallBack;

	private Action<Del_UnitCastSkillSuccess> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_UnitCastSkillSuccess _MultiCastDel;

	public GSDel_UnitCastSkillSuccess_ICB(Del_UnitCastSkillSuccess InvokeCallBack, Action<Del_UnitCastSkillSuccess> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_UnitCastSkillSuccess)Delegate.Combine(_MultiCastDel, (Del_UnitCastSkillSuccess)Del);
		}
		else
		{
			_MultiCastDel = (Del_UnitCastSkillSuccess)Delegate.Remove(_MultiCastDel, (Del_UnitCastSkillSuccess)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_UnitCastSkillSuccess_ICB operator +(GSDel_UnitCastSkillSuccess_ICB GSEvent, Del_UnitCastSkillSuccess Del)
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
		GSEvent._MultiCastDel = (Del_UnitCastSkillSuccess)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_UnitCastSkillSuccess_ICB operator -(GSDel_UnitCastSkillSuccess_ICB GSEvent, Del_UnitCastSkillSuccess Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_UnitCastSkillSuccess == Del)
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
		GSEvent._MultiCastDel = (Del_UnitCastSkillSuccess)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int MappingSkillID, int OriSkillID, ECastSkillSourceType SourceType)
	{
		_InvokeCallBack?.Invoke(MappingSkillID, OriSkillID, SourceType);
	}
}
