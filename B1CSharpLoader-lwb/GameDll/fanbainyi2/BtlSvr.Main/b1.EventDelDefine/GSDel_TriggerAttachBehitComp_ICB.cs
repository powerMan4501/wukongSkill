using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_TriggerAttachBehitComp_ICB : IFreshAbleGSEvent
{
	private Del_TriggerAttachBehitComp _InvokeCallBack;

	private Action<Del_TriggerAttachBehitComp> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerAttachBehitComp _MultiCastDel;

	public GSDel_TriggerAttachBehitComp_ICB(Del_TriggerAttachBehitComp InvokeCallBack, Action<Del_TriggerAttachBehitComp> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TriggerAttachBehitComp)Delegate.Combine(_MultiCastDel, (Del_TriggerAttachBehitComp)Del);
		}
		else
		{
			_MultiCastDel = (Del_TriggerAttachBehitComp)Delegate.Remove(_MultiCastDel, (Del_TriggerAttachBehitComp)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_TriggerAttachBehitComp_ICB operator +(GSDel_TriggerAttachBehitComp_ICB GSEvent, Del_TriggerAttachBehitComp Del)
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
		GSEvent._MultiCastDel = (Del_TriggerAttachBehitComp)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_TriggerAttachBehitComp_ICB operator -(GSDel_TriggerAttachBehitComp_ICB GSEvent, Del_TriggerAttachBehitComp Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TriggerAttachBehitComp == Del)
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
		GSEvent._MultiCastDel = (Del_TriggerAttachBehitComp)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int NotifyID, float Duration, float Strength, FTransform HitTransform, FVector HitDiretionRealDir, FName AttachBoneName)
	{
		_InvokeCallBack?.Invoke(NotifyID, Duration, Strength, HitTransform, HitDiretionRealDir, AttachBoneName);
	}
}
