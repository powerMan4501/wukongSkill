using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_PassiveSkill1IDIntParamChanged : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_PassiveSkill1IDIntParamChanged _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_PassiveSkill1IDIntParamChanged)Delegate.Combine(_MultiCastDel, (Del_PassiveSkill1IDIntParamChanged)Del);
		}
		else
		{
			_MultiCastDel = (Del_PassiveSkill1IDIntParamChanged)Delegate.Remove(_MultiCastDel, (Del_PassiveSkill1IDIntParamChanged)Del);
		}
	}

	public static GSDel_PassiveSkill1IDIntParamChanged operator +(GSDel_PassiveSkill1IDIntParamChanged GSEvent, Del_PassiveSkill1IDIntParamChanged Del)
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
		GSEvent._MultiCastDel = (Del_PassiveSkill1IDIntParamChanged)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_PassiveSkill1IDIntParamChanged operator -(GSDel_PassiveSkill1IDIntParamChanged GSEvent, Del_PassiveSkill1IDIntParamChanged Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_PassiveSkill1IDIntParamChanged == Del)
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
		GSEvent._MultiCastDel = (Del_PassiveSkill1IDIntParamChanged)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(int MainID, int OldVal, int NewVal)
	{
		_MultiCastDel?.Invoke(MainID, OldVal, NewVal);
	}
}
