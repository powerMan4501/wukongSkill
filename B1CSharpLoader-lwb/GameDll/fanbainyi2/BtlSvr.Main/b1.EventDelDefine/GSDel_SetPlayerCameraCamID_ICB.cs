using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SetPlayerCameraCamID_ICB : IFreshAbleGSEvent
{
	private Del_SetPlayerCameraCamID _InvokeCallBack;

	private Action<Del_SetPlayerCameraCamID> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetPlayerCameraCamID _MultiCastDel;

	public GSDel_SetPlayerCameraCamID_ICB(Del_SetPlayerCameraCamID InvokeCallBack, Action<Del_SetPlayerCameraCamID> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetPlayerCameraCamID)Delegate.Combine(_MultiCastDel, (Del_SetPlayerCameraCamID)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetPlayerCameraCamID)Delegate.Remove(_MultiCastDel, (Del_SetPlayerCameraCamID)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetPlayerCameraCamID_ICB operator +(GSDel_SetPlayerCameraCamID_ICB GSEvent, Del_SetPlayerCameraCamID Del)
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
		GSEvent._MultiCastDel = (Del_SetPlayerCameraCamID)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetPlayerCameraCamID_ICB operator -(GSDel_SetPlayerCameraCamID_ICB GSEvent, Del_SetPlayerCameraCamID Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetPlayerCameraCamID == Del)
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
		GSEvent._MultiCastDel = (Del_SetPlayerCameraCamID)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int CamID, bool bIsGeneral = false)
	{
		_InvokeCallBack?.Invoke(CamID, bIsGeneral);
	}
}
