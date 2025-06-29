using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_OnSetBodiesCollisionEnable_ICB : IFreshAbleGSEvent
{
	private Del_OnSetBodiesCollisionEnable _InvokeCallBack;

	private Action<Del_OnSetBodiesCollisionEnable> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnSetBodiesCollisionEnable _MultiCastDel;

	public GSDel_OnSetBodiesCollisionEnable_ICB(Del_OnSetBodiesCollisionEnable InvokeCallBack, Action<Del_OnSetBodiesCollisionEnable> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnSetBodiesCollisionEnable)Delegate.Combine(_MultiCastDel, (Del_OnSetBodiesCollisionEnable)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnSetBodiesCollisionEnable)Delegate.Remove(_MultiCastDel, (Del_OnSetBodiesCollisionEnable)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_OnSetBodiesCollisionEnable_ICB operator +(GSDel_OnSetBodiesCollisionEnable_ICB GSEvent, Del_OnSetBodiesCollisionEnable Del)
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
		GSEvent._MultiCastDel = (Del_OnSetBodiesCollisionEnable)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_OnSetBodiesCollisionEnable_ICB operator -(GSDel_OnSetBodiesCollisionEnable_ICB GSEvent, Del_OnSetBodiesCollisionEnable Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnSetBodiesCollisionEnable == Del)
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
		GSEvent._MultiCastDel = (Del_OnSetBodiesCollisionEnable)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(List<FName> BoneNames, bool Enable)
	{
		_InvokeCallBack?.Invoke(BoneNames, Enable);
	}
}
