using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_CreatePlayMontageProxy_ICB : IFreshAbleGSEvent
{
	private Del_CreatePlayMontageProxy _InvokeCallBack;

	private Action<Del_CreatePlayMontageProxy> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_CreatePlayMontageProxy _MultiCastDel;

	public GSDel_CreatePlayMontageProxy_ICB(Del_CreatePlayMontageProxy InvokeCallBack, Action<Del_CreatePlayMontageProxy> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_CreatePlayMontageProxy)Delegate.Combine(_MultiCastDel, (Del_CreatePlayMontageProxy)Del);
		}
		else
		{
			_MultiCastDel = (Del_CreatePlayMontageProxy)Delegate.Remove(_MultiCastDel, (Del_CreatePlayMontageProxy)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_CreatePlayMontageProxy_ICB operator +(GSDel_CreatePlayMontageProxy_ICB GSEvent, Del_CreatePlayMontageProxy Del)
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
		GSEvent._MultiCastDel = (Del_CreatePlayMontageProxy)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_CreatePlayMontageProxy_ICB operator -(GSDel_CreatePlayMontageProxy_ICB GSEvent, Del_CreatePlayMontageProxy Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_CreatePlayMontageProxy == Del)
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
		GSEvent._MultiCastDel = (Del_CreatePlayMontageProxy)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public bool Invoke(EMontageBindReason Reason, USkeletalMeshComponent InSkeletalMeshComponent, UAnimMontage MontageToPaly, float PlayRate, float StartingPosition, FName StartingSection)
	{
		if (_InvokeCallBack == null)
		{
			return false;
		}
		return _InvokeCallBack(Reason, InSkeletalMeshComponent, MontageToPaly, PlayRate, StartingPosition, StartingSection);
	}
}
