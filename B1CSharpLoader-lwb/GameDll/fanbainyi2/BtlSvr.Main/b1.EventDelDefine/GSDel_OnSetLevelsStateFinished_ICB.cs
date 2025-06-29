using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_OnSetLevelsStateFinished_ICB : IFreshAbleGSEvent
{
	private Del_OnSetLevelsStateFinished _InvokeCallBack;

	private Action<Del_OnSetLevelsStateFinished> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnSetLevelsStateFinished _MultiCastDel;

	public GSDel_OnSetLevelsStateFinished_ICB(Del_OnSetLevelsStateFinished InvokeCallBack, Action<Del_OnSetLevelsStateFinished> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnSetLevelsStateFinished)Delegate.Combine(_MultiCastDel, (Del_OnSetLevelsStateFinished)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnSetLevelsStateFinished)Delegate.Remove(_MultiCastDel, (Del_OnSetLevelsStateFinished)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_OnSetLevelsStateFinished_ICB operator +(GSDel_OnSetLevelsStateFinished_ICB GSEvent, Del_OnSetLevelsStateFinished Del)
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
		GSEvent._MultiCastDel = (Del_OnSetLevelsStateFinished)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_OnSetLevelsStateFinished_ICB operator -(GSDel_OnSetLevelsStateFinished_ICB GSEvent, Del_OnSetLevelsStateFinished Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnSetLevelsStateFinished == Del)
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
		GSEvent._MultiCastDel = (Del_OnSetLevelsStateFinished)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(string LevelKeyword, string LevelState, int OperationID)
	{
		_InvokeCallBack?.Invoke(LevelKeyword, LevelState, OperationID);
	}
}
