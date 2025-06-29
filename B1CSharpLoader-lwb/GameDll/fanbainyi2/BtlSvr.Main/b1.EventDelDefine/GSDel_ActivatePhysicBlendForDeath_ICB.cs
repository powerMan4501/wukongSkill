using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_ActivatePhysicBlendForDeath_ICB : IFreshAbleGSEvent
{
	private Del_ActivatePhysicBlendForDeath _InvokeCallBack;

	private Action<Del_ActivatePhysicBlendForDeath> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ActivatePhysicBlendForDeath _MultiCastDel;

	public GSDel_ActivatePhysicBlendForDeath_ICB(Del_ActivatePhysicBlendForDeath InvokeCallBack, Action<Del_ActivatePhysicBlendForDeath> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ActivatePhysicBlendForDeath)Delegate.Combine(_MultiCastDel, (Del_ActivatePhysicBlendForDeath)Del);
		}
		else
		{
			_MultiCastDel = (Del_ActivatePhysicBlendForDeath)Delegate.Remove(_MultiCastDel, (Del_ActivatePhysicBlendForDeath)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_ActivatePhysicBlendForDeath_ICB operator +(GSDel_ActivatePhysicBlendForDeath_ICB GSEvent, Del_ActivatePhysicBlendForDeath Del)
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
		GSEvent._MultiCastDel = (Del_ActivatePhysicBlendForDeath)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_ActivatePhysicBlendForDeath_ICB operator -(GSDel_ActivatePhysicBlendForDeath_ICB GSEvent, Del_ActivatePhysicBlendForDeath Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ActivatePhysicBlendForDeath == Del)
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
		GSEvent._MultiCastDel = (Del_ActivatePhysicBlendForDeath)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(List<FPhysicBlendInfoForDeath> PhysicBlendInfoList, float TotalTime, bool CallDissolveWhenPhysicsFinish)
	{
		_InvokeCallBack?.Invoke(PhysicBlendInfoList, TotalTime, CallDissolveWhenPhysicsFinish);
	}
}
