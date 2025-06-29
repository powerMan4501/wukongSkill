using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_SceneItemAddImpulse_ICB : IFreshAbleGSEvent
{
	private Del_SceneItemAddImpulse _InvokeCallBack;

	private Action<Del_SceneItemAddImpulse> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SceneItemAddImpulse _MultiCastDel;

	public GSDel_SceneItemAddImpulse_ICB(Del_SceneItemAddImpulse InvokeCallBack, Action<Del_SceneItemAddImpulse> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SceneItemAddImpulse)Delegate.Combine(_MultiCastDel, (Del_SceneItemAddImpulse)Del);
		}
		else
		{
			_MultiCastDel = (Del_SceneItemAddImpulse)Delegate.Remove(_MultiCastDel, (Del_SceneItemAddImpulse)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SceneItemAddImpulse_ICB operator +(GSDel_SceneItemAddImpulse_ICB GSEvent, Del_SceneItemAddImpulse Del)
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
		GSEvent._MultiCastDel = (Del_SceneItemAddImpulse)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SceneItemAddImpulse_ICB operator -(GSDel_SceneItemAddImpulse_ICB GSEvent, Del_SceneItemAddImpulse Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SceneItemAddImpulse == Del)
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
		GSEvent._MultiCastDel = (Del_SceneItemAddImpulse)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FVector FinalImpulse)
	{
		_InvokeCallBack?.Invoke(FinalImpulse);
	}
}
