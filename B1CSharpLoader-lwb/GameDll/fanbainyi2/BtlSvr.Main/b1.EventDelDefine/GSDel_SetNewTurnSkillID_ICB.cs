using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SetNewTurnSkillID_ICB : IFreshAbleGSEvent
{
	private Del_SetNewTurnSkillID _InvokeCallBack;

	private Action<Del_SetNewTurnSkillID> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetNewTurnSkillID _MultiCastDel;

	public GSDel_SetNewTurnSkillID_ICB(Del_SetNewTurnSkillID InvokeCallBack, Action<Del_SetNewTurnSkillID> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetNewTurnSkillID)Delegate.Combine(_MultiCastDel, (Del_SetNewTurnSkillID)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetNewTurnSkillID)Delegate.Remove(_MultiCastDel, (Del_SetNewTurnSkillID)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetNewTurnSkillID_ICB operator +(GSDel_SetNewTurnSkillID_ICB GSEvent, Del_SetNewTurnSkillID Del)
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
		GSEvent._MultiCastDel = (Del_SetNewTurnSkillID)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetNewTurnSkillID_ICB operator -(GSDel_SetNewTurnSkillID_ICB GSEvent, Del_SetNewTurnSkillID Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetNewTurnSkillID == Del)
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
		GSEvent._MultiCastDel = (Del_SetNewTurnSkillID)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(TurnSkillType Type, int NewTurnSkillID)
	{
		_InvokeCallBack?.Invoke(Type, NewTurnSkillID);
	}
}
