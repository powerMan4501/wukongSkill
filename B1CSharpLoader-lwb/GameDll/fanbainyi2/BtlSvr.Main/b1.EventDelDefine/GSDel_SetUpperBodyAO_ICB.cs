using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_SetUpperBodyAO_ICB : IFreshAbleGSEvent
{
	private Del_SetUpperBodyAO _InvokeCallBack;

	private Action<Del_SetUpperBodyAO> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetUpperBodyAO _MultiCastDel;

	public GSDel_SetUpperBodyAO_ICB(Del_SetUpperBodyAO InvokeCallBack, Action<Del_SetUpperBodyAO> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetUpperBodyAO)Delegate.Combine(_MultiCastDel, (Del_SetUpperBodyAO)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetUpperBodyAO)Delegate.Remove(_MultiCastDel, (Del_SetUpperBodyAO)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetUpperBodyAO_ICB operator +(GSDel_SetUpperBodyAO_ICB GSEvent, Del_SetUpperBodyAO Del)
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
		GSEvent._MultiCastDel = (Del_SetUpperBodyAO)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetUpperBodyAO_ICB operator -(GSDel_SetUpperBodyAO_ICB GSEvent, Del_SetUpperBodyAO Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetUpperBodyAO == Del)
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
		GSEvent._MultiCastDel = (Del_SetUpperBodyAO)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(bool Enable, EBTTargetType TargetType, FVector InnerTargetPosition = default(FVector))
	{
		_InvokeCallBack?.Invoke(Enable, TargetType, InnerTargetPosition);
	}
}
