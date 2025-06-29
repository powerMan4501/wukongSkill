using System;
using System.Collections.Generic;
using b1.ECS;
using Diana.Common;

namespace b1.EventDelDefine;

public class GSDel_AddBattleInfoLog_ICB : IFreshAbleGSEvent
{
	private Del_AddBattleInfoLog _InvokeCallBack;

	private Action<Del_AddBattleInfoLog> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_AddBattleInfoLog _MultiCastDel;

	public GSDel_AddBattleInfoLog_ICB(Del_AddBattleInfoLog InvokeCallBack, Action<Del_AddBattleInfoLog> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_AddBattleInfoLog)Delegate.Combine(_MultiCastDel, (Del_AddBattleInfoLog)Del);
		}
		else
		{
			_MultiCastDel = (Del_AddBattleInfoLog)Delegate.Remove(_MultiCastDel, (Del_AddBattleInfoLog)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_AddBattleInfoLog_ICB operator +(GSDel_AddBattleInfoLog_ICB GSEvent, Del_AddBattleInfoLog Del)
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
		GSEvent._MultiCastDel = (Del_AddBattleInfoLog)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_AddBattleInfoLog_ICB operator -(GSDel_AddBattleInfoLog_ICB GSEvent, Del_AddBattleInfoLog Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_AddBattleInfoLog == Del)
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
		GSEvent._MultiCastDel = (Del_AddBattleInfoLog)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EBattleInfoType BattleInfoType, string BattleInfoLog, int BattleInfoLogOptions, EBGULogVerbosity BGULogVerbosity)
	{
		_InvokeCallBack?.Invoke(BattleInfoType, BattleInfoLog, BattleInfoLogOptions, BGULogVerbosity);
	}
}
