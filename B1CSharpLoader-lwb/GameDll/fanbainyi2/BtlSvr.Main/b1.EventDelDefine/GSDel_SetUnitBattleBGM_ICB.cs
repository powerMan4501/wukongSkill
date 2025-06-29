using System;
using System.Collections.Generic;
using b1.ECS;
using b1.Plugins.AkAudio;

namespace b1.EventDelDefine;

public class GSDel_SetUnitBattleBGM_ICB : IFreshAbleGSEvent
{
	private Del_SetUnitBattleBGM _InvokeCallBack;

	private Action<Del_SetUnitBattleBGM> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetUnitBattleBGM _MultiCastDel;

	public GSDel_SetUnitBattleBGM_ICB(Del_SetUnitBattleBGM InvokeCallBack, Action<Del_SetUnitBattleBGM> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetUnitBattleBGM)Delegate.Combine(_MultiCastDel, (Del_SetUnitBattleBGM)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetUnitBattleBGM)Delegate.Remove(_MultiCastDel, (Del_SetUnitBattleBGM)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetUnitBattleBGM_ICB operator +(GSDel_SetUnitBattleBGM_ICB GSEvent, Del_SetUnitBattleBGM Del)
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
		GSEvent._MultiCastDel = (Del_SetUnitBattleBGM)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetUnitBattleBGM_ICB operator -(GSDel_SetUnitBattleBGM_ICB GSEvent, Del_SetUnitBattleBGM Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetUnitBattleBGM == Del)
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
		GSEvent._MultiCastDel = (Del_SetUnitBattleBGM)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(UAkAudioEvent AkEventBegin, UAkAudioEvent AkEventStop, float BGMEventStopTimer, Dictionary<EBGMStopCondition, BGMStopEventInfo> ConditionStopEvents)
	{
		_InvokeCallBack?.Invoke(AkEventBegin, AkEventStop, BGMEventStopTimer, ConditionStopEvents);
	}
}
