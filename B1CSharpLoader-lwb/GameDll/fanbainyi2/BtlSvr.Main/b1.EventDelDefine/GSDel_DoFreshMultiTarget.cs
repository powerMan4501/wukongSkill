using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_DoFreshMultiTarget : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_DoFreshMultiTarget _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_DoFreshMultiTarget)Delegate.Combine(_MultiCastDel, (Del_DoFreshMultiTarget)Del);
		}
		else
		{
			_MultiCastDel = (Del_DoFreshMultiTarget)Delegate.Remove(_MultiCastDel, (Del_DoFreshMultiTarget)Del);
		}
	}

	public static GSDel_DoFreshMultiTarget operator +(GSDel_DoFreshMultiTarget GSEvent, Del_DoFreshMultiTarget Del)
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
		GSEvent._MultiCastDel = (Del_DoFreshMultiTarget)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_DoFreshMultiTarget operator -(GSDel_DoFreshMultiTarget GSEvent, Del_DoFreshMultiTarget Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_DoFreshMultiTarget == Del)
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
		GSEvent._MultiCastDel = (Del_DoFreshMultiTarget)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(float SearchRaius, int TargetTeamFilter, int TargetTypeFilter, EMultiTargetConditionType MultiTargetConditionType, int Param1, int Param2)
	{
		_MultiCastDel?.Invoke(SearchRaius, TargetTeamFilter, TargetTypeFilter, MultiTargetConditionType, Param1, Param2);
	}
}
