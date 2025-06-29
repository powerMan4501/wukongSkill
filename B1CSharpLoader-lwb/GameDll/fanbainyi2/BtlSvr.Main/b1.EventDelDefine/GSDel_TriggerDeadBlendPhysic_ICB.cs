using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_TriggerDeadBlendPhysic_ICB : IFreshAbleGSEvent
{
	private Del_TriggerDeadBlendPhysic _InvokeCallBack;

	private Action<Del_TriggerDeadBlendPhysic> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerDeadBlendPhysic _MultiCastDel;

	public GSDel_TriggerDeadBlendPhysic_ICB(Del_TriggerDeadBlendPhysic InvokeCallBack, Action<Del_TriggerDeadBlendPhysic> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TriggerDeadBlendPhysic)Delegate.Combine(_MultiCastDel, (Del_TriggerDeadBlendPhysic)Del);
		}
		else
		{
			_MultiCastDel = (Del_TriggerDeadBlendPhysic)Delegate.Remove(_MultiCastDel, (Del_TriggerDeadBlendPhysic)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_TriggerDeadBlendPhysic_ICB operator +(GSDel_TriggerDeadBlendPhysic_ICB GSEvent, Del_TriggerDeadBlendPhysic Del)
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
		GSEvent._MultiCastDel = (Del_TriggerDeadBlendPhysic)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_TriggerDeadBlendPhysic_ICB operator -(GSDel_TriggerDeadBlendPhysic_ICB GSEvent, Del_TriggerDeadBlendPhysic Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TriggerDeadBlendPhysic == Del)
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
		GSEvent._MultiCastDel = (Del_TriggerDeadBlendPhysic)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(List<FPhysicBlendInfoForDeath> PhysicBlendInfoList, float TotalTime, bool CallDissolveWhenPhysicsFinish, bool DirectlyTurnIntoRagdoll)
	{
		_InvokeCallBack?.Invoke(PhysicBlendInfoList, TotalTime, CallDissolveWhenPhysicsFinish, DirectlyTurnIntoRagdoll);
	}
}
