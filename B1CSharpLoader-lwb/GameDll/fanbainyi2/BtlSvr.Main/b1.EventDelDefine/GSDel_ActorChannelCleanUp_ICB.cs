using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_ActorChannelCleanUp_ICB : IFreshAbleGSEvent
{
	private Del_ActorChannelCleanUp _InvokeCallBack;

	private Action<Del_ActorChannelCleanUp> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ActorChannelCleanUp _MultiCastDel;

	public GSDel_ActorChannelCleanUp_ICB(Del_ActorChannelCleanUp InvokeCallBack, Action<Del_ActorChannelCleanUp> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ActorChannelCleanUp)Delegate.Combine(_MultiCastDel, (Del_ActorChannelCleanUp)Del);
		}
		else
		{
			_MultiCastDel = (Del_ActorChannelCleanUp)Delegate.Remove(_MultiCastDel, (Del_ActorChannelCleanUp)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_ActorChannelCleanUp_ICB operator +(GSDel_ActorChannelCleanUp_ICB GSEvent, Del_ActorChannelCleanUp Del)
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
		GSEvent._MultiCastDel = (Del_ActorChannelCleanUp)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_ActorChannelCleanUp_ICB operator -(GSDel_ActorChannelCleanUp_ICB GSEvent, Del_ActorChannelCleanUp Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ActorChannelCleanUp == Del)
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
		GSEvent._MultiCastDel = (Del_ActorChannelCleanUp)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(long ActorNetGUID, APlayerController PlayerController, EChannelCloseReason CloseReason)
	{
		_InvokeCallBack?.Invoke(ActorNetGUID, PlayerController, CloseReason);
	}
}
