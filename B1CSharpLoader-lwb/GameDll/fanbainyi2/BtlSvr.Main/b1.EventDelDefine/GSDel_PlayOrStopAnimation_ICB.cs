using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_PlayOrStopAnimation_ICB : IFreshAbleGSEvent
{
	private Del_PlayOrStopAnimation _InvokeCallBack;

	private Action<Del_PlayOrStopAnimation> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_PlayOrStopAnimation _MultiCastDel;

	public GSDel_PlayOrStopAnimation_ICB(Del_PlayOrStopAnimation InvokeCallBack, Action<Del_PlayOrStopAnimation> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_PlayOrStopAnimation)Delegate.Combine(_MultiCastDel, (Del_PlayOrStopAnimation)Del);
		}
		else
		{
			_MultiCastDel = (Del_PlayOrStopAnimation)Delegate.Remove(_MultiCastDel, (Del_PlayOrStopAnimation)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_PlayOrStopAnimation_ICB operator +(GSDel_PlayOrStopAnimation_ICB GSEvent, Del_PlayOrStopAnimation Del)
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
		GSEvent._MultiCastDel = (Del_PlayOrStopAnimation)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_PlayOrStopAnimation_ICB operator -(GSDel_PlayOrStopAnimation_ICB GSEvent, Del_PlayOrStopAnimation Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_PlayOrStopAnimation == Del)
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
		GSEvent._MultiCastDel = (Del_PlayOrStopAnimation)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(bool IsPlay, bool IsLoop = false, UAnimationAsset NewAnimToPlay = null)
	{
		_InvokeCallBack?.Invoke(IsPlay, IsLoop, NewAnimToPlay);
	}
}
