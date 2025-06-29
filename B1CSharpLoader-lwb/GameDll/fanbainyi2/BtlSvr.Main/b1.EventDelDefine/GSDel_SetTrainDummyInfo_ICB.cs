using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SetTrainDummyInfo_ICB : IFreshAbleGSEvent
{
	private Del_SetTrainDummyInfo _InvokeCallBack;

	private Action<Del_SetTrainDummyInfo> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetTrainDummyInfo _MultiCastDel;

	public GSDel_SetTrainDummyInfo_ICB(Del_SetTrainDummyInfo InvokeCallBack, Action<Del_SetTrainDummyInfo> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetTrainDummyInfo)Delegate.Combine(_MultiCastDel, (Del_SetTrainDummyInfo)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetTrainDummyInfo)Delegate.Remove(_MultiCastDel, (Del_SetTrainDummyInfo)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetTrainDummyInfo_ICB operator +(GSDel_SetTrainDummyInfo_ICB GSEvent, Del_SetTrainDummyInfo Del)
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
		GSEvent._MultiCastDel = (Del_SetTrainDummyInfo)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetTrainDummyInfo_ICB operator -(GSDel_SetTrainDummyInfo_ICB GSEvent, Del_SetTrainDummyInfo Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetTrainDummyInfo == Del)
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
		GSEvent._MultiCastDel = (Del_SetTrainDummyInfo)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(string TrainDummyClassPath, int PlayerRoleDataConfigID, string TrainDummyConfigPath, float DPSCalTime)
	{
		_InvokeCallBack?.Invoke(TrainDummyClassPath, PlayerRoleDataConfigID, TrainDummyConfigPath, DPSCalTime);
	}
}
