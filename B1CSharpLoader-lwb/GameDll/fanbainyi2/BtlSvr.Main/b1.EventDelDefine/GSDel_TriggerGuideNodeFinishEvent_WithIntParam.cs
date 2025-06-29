using System;
using System.Collections.Generic;
using b1.ECS;
using BtlShare;

namespace b1.EventDelDefine;

public class GSDel_TriggerGuideNodeFinishEvent_WithIntParam : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerGuideNodeFinishEvent_WithIntParam _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TriggerGuideNodeFinishEvent_WithIntParam)Delegate.Combine(_MultiCastDel, (Del_TriggerGuideNodeFinishEvent_WithIntParam)Del);
		}
		else
		{
			_MultiCastDel = (Del_TriggerGuideNodeFinishEvent_WithIntParam)Delegate.Remove(_MultiCastDel, (Del_TriggerGuideNodeFinishEvent_WithIntParam)Del);
		}
	}

	public static GSDel_TriggerGuideNodeFinishEvent_WithIntParam operator +(GSDel_TriggerGuideNodeFinishEvent_WithIntParam GSEvent, Del_TriggerGuideNodeFinishEvent_WithIntParam Del)
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
		GSEvent._MultiCastDel = (Del_TriggerGuideNodeFinishEvent_WithIntParam)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_TriggerGuideNodeFinishEvent_WithIntParam operator -(GSDel_TriggerGuideNodeFinishEvent_WithIntParam GSEvent, Del_TriggerGuideNodeFinishEvent_WithIntParam Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TriggerGuideNodeFinishEvent_WithIntParam == Del)
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
		GSEvent._MultiCastDel = (Del_TriggerGuideNodeFinishEvent_WithIntParam)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(EGuideNodeFinishType FinishType, int IntParam)
	{
		_MultiCastDel?.Invoke(FinishType, IntParam);
	}
}
