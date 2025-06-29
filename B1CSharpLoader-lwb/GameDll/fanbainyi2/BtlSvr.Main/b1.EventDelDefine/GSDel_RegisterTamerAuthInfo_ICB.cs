using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_RegisterTamerAuthInfo_ICB : IFreshAbleGSEvent
{
	private Del_RegisterTamerAuthInfo _InvokeCallBack;

	private Action<Del_RegisterTamerAuthInfo> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_RegisterTamerAuthInfo _MultiCastDel;

	public GSDel_RegisterTamerAuthInfo_ICB(Del_RegisterTamerAuthInfo InvokeCallBack, Action<Del_RegisterTamerAuthInfo> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_RegisterTamerAuthInfo)Delegate.Combine(_MultiCastDel, (Del_RegisterTamerAuthInfo)Del);
		}
		else
		{
			_MultiCastDel = (Del_RegisterTamerAuthInfo)Delegate.Remove(_MultiCastDel, (Del_RegisterTamerAuthInfo)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_RegisterTamerAuthInfo_ICB operator +(GSDel_RegisterTamerAuthInfo_ICB GSEvent, Del_RegisterTamerAuthInfo Del)
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
		GSEvent._MultiCastDel = (Del_RegisterTamerAuthInfo)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_RegisterTamerAuthInfo_ICB operator -(GSDel_RegisterTamerAuthInfo_ICB GSEvent, Del_RegisterTamerAuthInfo Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_RegisterTamerAuthInfo == Del)
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
		GSEvent._MultiCastDel = (Del_RegisterTamerAuthInfo)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(string TamerGuid, APlayerController PlayerController)
	{
		_InvokeCallBack?.Invoke(TamerGuid, PlayerController);
	}
}
