using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_ChangeAnimMode_ICB : IFreshAbleGSEvent
{
	private Del_ChangeAnimMode _InvokeCallBack;

	private Action<Del_ChangeAnimMode> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ChangeAnimMode _MultiCastDel;

	public GSDel_ChangeAnimMode_ICB(Del_ChangeAnimMode InvokeCallBack, Action<Del_ChangeAnimMode> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ChangeAnimMode)Delegate.Combine(_MultiCastDel, (Del_ChangeAnimMode)Del);
		}
		else
		{
			_MultiCastDel = (Del_ChangeAnimMode)Delegate.Remove(_MultiCastDel, (Del_ChangeAnimMode)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_ChangeAnimMode_ICB operator +(GSDel_ChangeAnimMode_ICB GSEvent, Del_ChangeAnimMode Del)
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
		GSEvent._MultiCastDel = (Del_ChangeAnimMode)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_ChangeAnimMode_ICB operator -(GSDel_ChangeAnimMode_ICB GSEvent, Del_ChangeAnimMode Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ChangeAnimMode == Del)
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
		GSEvent._MultiCastDel = (Del_ChangeAnimMode)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EAnimationMode AnimMode, TSubclassOf<UAnimInstance> ABPClass = default(TSubclassOf<UAnimInstance>))
	{
		_InvokeCallBack?.Invoke(AnimMode, ABPClass);
	}
}
