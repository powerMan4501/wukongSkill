using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SetNpcGuideSplineMoveInfo_ICB : IFreshAbleGSEvent
{
	private Del_SetNpcGuideSplineMoveInfo _InvokeCallBack;

	private Action<Del_SetNpcGuideSplineMoveInfo> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetNpcGuideSplineMoveInfo _MultiCastDel;

	public GSDel_SetNpcGuideSplineMoveInfo_ICB(Del_SetNpcGuideSplineMoveInfo InvokeCallBack, Action<Del_SetNpcGuideSplineMoveInfo> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetNpcGuideSplineMoveInfo)Delegate.Combine(_MultiCastDel, (Del_SetNpcGuideSplineMoveInfo)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetNpcGuideSplineMoveInfo)Delegate.Remove(_MultiCastDel, (Del_SetNpcGuideSplineMoveInfo)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetNpcGuideSplineMoveInfo_ICB operator +(GSDel_SetNpcGuideSplineMoveInfo_ICB GSEvent, Del_SetNpcGuideSplineMoveInfo Del)
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
		GSEvent._MultiCastDel = (Del_SetNpcGuideSplineMoveInfo)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetNpcGuideSplineMoveInfo_ICB operator -(GSDel_SetNpcGuideSplineMoveInfo_ICB GSEvent, Del_SetNpcGuideSplineMoveInfo Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetNpcGuideSplineMoveInfo == Del)
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
		GSEvent._MultiCastDel = (Del_SetNpcGuideSplineMoveInfo)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(string SplineGuid, bool NeedSwitchSpeedByDistanceToPlayer, EAIMoveSpeedType SplineMoveSpeed, float MaxDistance_Sprint, float MaxDistance_Run, float MaxDistance_Jog, float DistanceBuffer)
	{
		_InvokeCallBack?.Invoke(SplineGuid, NeedSwitchSpeedByDistanceToPlayer, SplineMoveSpeed, MaxDistance_Sprint, MaxDistance_Run, MaxDistance_Jog, DistanceBuffer);
	}
}
