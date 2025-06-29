using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_OnDummyMeshChange_ICB : IFreshAbleGSEvent
{
	private Del_OnDummyMeshChange _InvokeCallBack;

	private Action<Del_OnDummyMeshChange> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnDummyMeshChange _MultiCastDel;

	public GSDel_OnDummyMeshChange_ICB(Del_OnDummyMeshChange InvokeCallBack, Action<Del_OnDummyMeshChange> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnDummyMeshChange)Delegate.Combine(_MultiCastDel, (Del_OnDummyMeshChange)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnDummyMeshChange)Delegate.Remove(_MultiCastDel, (Del_OnDummyMeshChange)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_OnDummyMeshChange_ICB operator +(GSDel_OnDummyMeshChange_ICB GSEvent, Del_OnDummyMeshChange Del)
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
		GSEvent._MultiCastDel = (Del_OnDummyMeshChange)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_OnDummyMeshChange_ICB operator -(GSDel_OnDummyMeshChange_ICB GSEvent, Del_OnDummyMeshChange Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnDummyMeshChange == Del)
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
		GSEvent._MultiCastDel = (Del_OnDummyMeshChange)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(USkeletalMeshComponent Mesh, bool bAdd, float Duration)
	{
		_InvokeCallBack?.Invoke(Mesh, bAdd, Duration);
	}
}
