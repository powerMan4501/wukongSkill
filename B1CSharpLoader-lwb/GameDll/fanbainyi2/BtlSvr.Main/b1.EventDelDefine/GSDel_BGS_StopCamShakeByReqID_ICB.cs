using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_BGS_StopCamShakeByReqID_ICB : IFreshAbleGSEvent
{
	private Del_BGS_StopCamShakeByReqID _InvokeCallBack;

	private Action<Del_BGS_StopCamShakeByReqID> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_BGS_StopCamShakeByReqID _MultiCastDel;

	public GSDel_BGS_StopCamShakeByReqID_ICB(Del_BGS_StopCamShakeByReqID InvokeCallBack, Action<Del_BGS_StopCamShakeByReqID> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_BGS_StopCamShakeByReqID)Delegate.Combine(_MultiCastDel, (Del_BGS_StopCamShakeByReqID)Del);
		}
		else
		{
			_MultiCastDel = (Del_BGS_StopCamShakeByReqID)Delegate.Remove(_MultiCastDel, (Del_BGS_StopCamShakeByReqID)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_BGS_StopCamShakeByReqID_ICB operator +(GSDel_BGS_StopCamShakeByReqID_ICB GSEvent, Del_BGS_StopCamShakeByReqID Del)
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
		GSEvent._MultiCastDel = (Del_BGS_StopCamShakeByReqID)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_BGS_StopCamShakeByReqID_ICB operator -(GSDel_BGS_StopCamShakeByReqID_ICB GSEvent, Del_BGS_StopCamShakeByReqID Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_BGS_StopCamShakeByReqID == Del)
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
		GSEvent._MultiCastDel = (Del_BGS_StopCamShakeByReqID)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int ReqID, bool bImmediately = true)
	{
		_InvokeCallBack?.Invoke(ReqID, bImmediately);
	}
}
