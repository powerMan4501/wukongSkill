using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_PlayBeAttackedPhysicalAnim_ICB : IFreshAbleGSEvent
{
	private Del_PlayBeAttackedPhysicalAnim _InvokeCallBack;

	private Action<Del_PlayBeAttackedPhysicalAnim> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_PlayBeAttackedPhysicalAnim _MultiCastDel;

	public GSDel_PlayBeAttackedPhysicalAnim_ICB(Del_PlayBeAttackedPhysicalAnim InvokeCallBack, Action<Del_PlayBeAttackedPhysicalAnim> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_PlayBeAttackedPhysicalAnim)Delegate.Combine(_MultiCastDel, (Del_PlayBeAttackedPhysicalAnim)Del);
		}
		else
		{
			_MultiCastDel = (Del_PlayBeAttackedPhysicalAnim)Delegate.Remove(_MultiCastDel, (Del_PlayBeAttackedPhysicalAnim)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_PlayBeAttackedPhysicalAnim_ICB operator +(GSDel_PlayBeAttackedPhysicalAnim_ICB GSEvent, Del_PlayBeAttackedPhysicalAnim Del)
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
		GSEvent._MultiCastDel = (Del_PlayBeAttackedPhysicalAnim)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_PlayBeAttackedPhysicalAnim_ICB operator -(GSDel_PlayBeAttackedPhysicalAnim_ICB GSEvent, Del_PlayBeAttackedPhysicalAnim Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_PlayBeAttackedPhysicalAnim == Del)
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
		GSEvent._MultiCastDel = (Del_PlayBeAttackedPhysicalAnim)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(float HitWeight, FVector HitDirection, FVector HitLocation)
	{
		_InvokeCallBack?.Invoke(HitWeight, HitDirection, HitLocation);
	}
}
