using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_OnDestroyFXCompByTag_ICB : IFreshAbleGSEvent
{
	private Del_OnDestroyFXCompByTag _InvokeCallBack;

	private Action<Del_OnDestroyFXCompByTag> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnDestroyFXCompByTag _MultiCastDel;

	public GSDel_OnDestroyFXCompByTag_ICB(Del_OnDestroyFXCompByTag InvokeCallBack, Action<Del_OnDestroyFXCompByTag> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnDestroyFXCompByTag)Delegate.Combine(_MultiCastDel, (Del_OnDestroyFXCompByTag)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnDestroyFXCompByTag)Delegate.Remove(_MultiCastDel, (Del_OnDestroyFXCompByTag)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_OnDestroyFXCompByTag_ICB operator +(GSDel_OnDestroyFXCompByTag_ICB GSEvent, Del_OnDestroyFXCompByTag Del)
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
		GSEvent._MultiCastDel = (Del_OnDestroyFXCompByTag)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_OnDestroyFXCompByTag_ICB operator -(GSDel_OnDestroyFXCompByTag_ICB GSEvent, Del_OnDestroyFXCompByTag Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnDestroyFXCompByTag == Del)
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
		GSEvent._MultiCastDel = (Del_OnDestroyFXCompByTag)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FName Tag, bool DestroyImmediately)
	{
		_InvokeCallBack?.Invoke(Tag, DestroyImmediately);
	}
}
