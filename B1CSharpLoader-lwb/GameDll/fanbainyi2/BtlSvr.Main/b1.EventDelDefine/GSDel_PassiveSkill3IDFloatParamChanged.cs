using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_PassiveSkill3IDFloatParamChanged : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_PassiveSkill3IDFloatParamChanged _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_PassiveSkill3IDFloatParamChanged)Delegate.Combine(_MultiCastDel, (Del_PassiveSkill3IDFloatParamChanged)Del);
		}
		else
		{
			_MultiCastDel = (Del_PassiveSkill3IDFloatParamChanged)Delegate.Remove(_MultiCastDel, (Del_PassiveSkill3IDFloatParamChanged)Del);
		}
	}

	public static GSDel_PassiveSkill3IDFloatParamChanged operator +(GSDel_PassiveSkill3IDFloatParamChanged GSEvent, Del_PassiveSkill3IDFloatParamChanged Del)
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
		GSEvent._MultiCastDel = (Del_PassiveSkill3IDFloatParamChanged)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_PassiveSkill3IDFloatParamChanged operator -(GSDel_PassiveSkill3IDFloatParamChanged GSEvent, Del_PassiveSkill3IDFloatParamChanged Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_PassiveSkill3IDFloatParamChanged == Del)
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
		GSEvent._MultiCastDel = (Del_PassiveSkill3IDFloatParamChanged)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(int MainID, int SubID, int SubID2, float OldVal, float NewVal)
	{
		_MultiCastDel?.Invoke(MainID, SubID, SubID2, OldVal, NewVal);
	}
}
