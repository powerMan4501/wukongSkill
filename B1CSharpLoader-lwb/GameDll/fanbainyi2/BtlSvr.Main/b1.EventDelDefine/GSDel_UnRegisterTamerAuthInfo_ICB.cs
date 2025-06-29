using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_UnRegisterTamerAuthInfo_ICB : IFreshAbleGSEvent
{
	private Del_UnRegisterTamerAuthInfo _InvokeCallBack;

	private Action<Del_UnRegisterTamerAuthInfo> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_UnRegisterTamerAuthInfo _MultiCastDel;

	public GSDel_UnRegisterTamerAuthInfo_ICB(Del_UnRegisterTamerAuthInfo InvokeCallBack, Action<Del_UnRegisterTamerAuthInfo> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_UnRegisterTamerAuthInfo)Delegate.Combine(_MultiCastDel, (Del_UnRegisterTamerAuthInfo)Del);
		}
		else
		{
			_MultiCastDel = (Del_UnRegisterTamerAuthInfo)Delegate.Remove(_MultiCastDel, (Del_UnRegisterTamerAuthInfo)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_UnRegisterTamerAuthInfo_ICB operator +(GSDel_UnRegisterTamerAuthInfo_ICB GSEvent, Del_UnRegisterTamerAuthInfo Del)
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
		GSEvent._MultiCastDel = (Del_UnRegisterTamerAuthInfo)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_UnRegisterTamerAuthInfo_ICB operator -(GSDel_UnRegisterTamerAuthInfo_ICB GSEvent, Del_UnRegisterTamerAuthInfo Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_UnRegisterTamerAuthInfo == Del)
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
		GSEvent._MultiCastDel = (Del_UnRegisterTamerAuthInfo)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public bool Invoke(string TamerGuid, APlayerController PlayerController)
	{
		if (_InvokeCallBack == null)
		{
			return false;
		}
		return _InvokeCallBack(TamerGuid, PlayerController);
	}
}
