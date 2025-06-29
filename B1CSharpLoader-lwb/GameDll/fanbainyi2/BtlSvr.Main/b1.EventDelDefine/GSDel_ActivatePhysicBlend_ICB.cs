using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_ActivatePhysicBlend_ICB : IFreshAbleGSEvent
{
	private Del_ActivatePhysicBlend _InvokeCallBack;

	private Action<Del_ActivatePhysicBlend> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ActivatePhysicBlend _MultiCastDel;

	public GSDel_ActivatePhysicBlend_ICB(Del_ActivatePhysicBlend InvokeCallBack, Action<Del_ActivatePhysicBlend> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ActivatePhysicBlend)Delegate.Combine(_MultiCastDel, (Del_ActivatePhysicBlend)Del);
		}
		else
		{
			_MultiCastDel = (Del_ActivatePhysicBlend)Delegate.Remove(_MultiCastDel, (Del_ActivatePhysicBlend)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_ActivatePhysicBlend_ICB operator +(GSDel_ActivatePhysicBlend_ICB GSEvent, Del_ActivatePhysicBlend Del)
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
		GSEvent._MultiCastDel = (Del_ActivatePhysicBlend)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_ActivatePhysicBlend_ICB operator -(GSDel_ActivatePhysicBlend_ICB GSEvent, Del_ActivatePhysicBlend Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ActivatePhysicBlend == Del)
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
		GSEvent._MultiCastDel = (Del_ActivatePhysicBlend)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(List<FPhysicBlendInfo> PhysicBlendInfoList, bool EnableSimulate, float TotalTime)
	{
		_InvokeCallBack?.Invoke(PhysicBlendInfoList, EnableSimulate, TotalTime);
	}
}
