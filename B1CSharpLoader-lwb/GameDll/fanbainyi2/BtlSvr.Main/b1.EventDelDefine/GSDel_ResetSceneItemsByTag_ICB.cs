using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_ResetSceneItemsByTag_ICB : IFreshAbleGSEvent
{
	private Del_ResetSceneItemsByTag _InvokeCallBack;

	private Action<Del_ResetSceneItemsByTag> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ResetSceneItemsByTag _MultiCastDel;

	public GSDel_ResetSceneItemsByTag_ICB(Del_ResetSceneItemsByTag InvokeCallBack, Action<Del_ResetSceneItemsByTag> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ResetSceneItemsByTag)Delegate.Combine(_MultiCastDel, (Del_ResetSceneItemsByTag)Del);
		}
		else
		{
			_MultiCastDel = (Del_ResetSceneItemsByTag)Delegate.Remove(_MultiCastDel, (Del_ResetSceneItemsByTag)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_ResetSceneItemsByTag_ICB operator +(GSDel_ResetSceneItemsByTag_ICB GSEvent, Del_ResetSceneItemsByTag Del)
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
		GSEvent._MultiCastDel = (Del_ResetSceneItemsByTag)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_ResetSceneItemsByTag_ICB operator -(GSDel_ResetSceneItemsByTag_ICB GSEvent, Del_ResetSceneItemsByTag Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ResetSceneItemsByTag == Del)
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
		GSEvent._MultiCastDel = (Del_ResetSceneItemsByTag)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(List<FName> ActorTags)
	{
		_InvokeCallBack?.Invoke(ActorTags);
	}
}
