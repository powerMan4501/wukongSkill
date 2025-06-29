using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_ChangeSkeletalMeshWithABP_ICB : IFreshAbleGSEvent
{
	private Del_ChangeSkeletalMeshWithABP _InvokeCallBack;

	private Action<Del_ChangeSkeletalMeshWithABP> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ChangeSkeletalMeshWithABP _MultiCastDel;

	public GSDel_ChangeSkeletalMeshWithABP_ICB(Del_ChangeSkeletalMeshWithABP InvokeCallBack, Action<Del_ChangeSkeletalMeshWithABP> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ChangeSkeletalMeshWithABP)Delegate.Combine(_MultiCastDel, (Del_ChangeSkeletalMeshWithABP)Del);
		}
		else
		{
			_MultiCastDel = (Del_ChangeSkeletalMeshWithABP)Delegate.Remove(_MultiCastDel, (Del_ChangeSkeletalMeshWithABP)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_ChangeSkeletalMeshWithABP_ICB operator +(GSDel_ChangeSkeletalMeshWithABP_ICB GSEvent, Del_ChangeSkeletalMeshWithABP Del)
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
		GSEvent._MultiCastDel = (Del_ChangeSkeletalMeshWithABP)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_ChangeSkeletalMeshWithABP_ICB operator -(GSDel_ChangeSkeletalMeshWithABP_ICB GSEvent, Del_ChangeSkeletalMeshWithABP Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ChangeSkeletalMeshWithABP == Del)
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
		GSEvent._MultiCastDel = (Del_ChangeSkeletalMeshWithABP)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(USkeletalMesh NewMesh, TSubclassOf<UAnimInstance> NewABPClass)
	{
		_InvokeCallBack?.Invoke(NewMesh, NewABPClass);
	}
}
