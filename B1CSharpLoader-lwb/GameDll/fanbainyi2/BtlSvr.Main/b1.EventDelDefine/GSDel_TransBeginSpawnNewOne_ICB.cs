using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_TransBeginSpawnNewOne_ICB : IFreshAbleGSEvent
{
	private Del_TransBeginSpawnNewOne _InvokeCallBack;

	private Action<Del_TransBeginSpawnNewOne> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TransBeginSpawnNewOne _MultiCastDel;

	public GSDel_TransBeginSpawnNewOne_ICB(Del_TransBeginSpawnNewOne InvokeCallBack, Action<Del_TransBeginSpawnNewOne> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TransBeginSpawnNewOne)Delegate.Combine(_MultiCastDel, (Del_TransBeginSpawnNewOne)Del);
		}
		else
		{
			_MultiCastDel = (Del_TransBeginSpawnNewOne)Delegate.Remove(_MultiCastDel, (Del_TransBeginSpawnNewOne)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_TransBeginSpawnNewOne_ICB operator +(GSDel_TransBeginSpawnNewOne_ICB GSEvent, Del_TransBeginSpawnNewOne Del)
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
		GSEvent._MultiCastDel = (Del_TransBeginSpawnNewOne)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_TransBeginSpawnNewOne_ICB operator -(GSDel_TransBeginSpawnNewOne_ICB GSEvent, Del_TransBeginSpawnNewOne Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TransBeginSpawnNewOne == Del)
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
		GSEvent._MultiCastDel = (Del_TransBeginSpawnNewOne)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int ToReplaceUnitResID, int ToReplaceUnitBornSkillID, bool EnableBlendViewTarget, EPlayerTransBeginType TransBeginType)
	{
		_InvokeCallBack?.Invoke(ToReplaceUnitResID, ToReplaceUnitBornSkillID, EnableBlendViewTarget, TransBeginType);
	}
}
