using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_SetMagicFieldDirection_ICB : IFreshAbleGSEvent
{
	private Del_SetMagicFieldDirection _InvokeCallBack;

	private Action<Del_SetMagicFieldDirection> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetMagicFieldDirection _MultiCastDel;

	public GSDel_SetMagicFieldDirection_ICB(Del_SetMagicFieldDirection InvokeCallBack, Action<Del_SetMagicFieldDirection> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetMagicFieldDirection)Delegate.Combine(_MultiCastDel, (Del_SetMagicFieldDirection)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetMagicFieldDirection)Delegate.Remove(_MultiCastDel, (Del_SetMagicFieldDirection)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetMagicFieldDirection_ICB operator +(GSDel_SetMagicFieldDirection_ICB GSEvent, Del_SetMagicFieldDirection Del)
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
		GSEvent._MultiCastDel = (Del_SetMagicFieldDirection)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetMagicFieldDirection_ICB operator -(GSDel_SetMagicFieldDirection_ICB GSEvent, Del_SetMagicFieldDirection Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetMagicFieldDirection == Del)
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
		GSEvent._MultiCastDel = (Del_SetMagicFieldDirection)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor MagicFieldActor, EMagicFieldDirectionUsage Usage, in FVector Direction)
	{
		_InvokeCallBack?.Invoke(MagicFieldActor, Usage, in Direction);
	}
}
