using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_PassiveSkill1IDIntParamChanged_ICB : IFreshAbleGSEvent
{
	private Del_PassiveSkill1IDIntParamChanged _InvokeCallBack;

	private Action<Del_PassiveSkill1IDIntParamChanged> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_PassiveSkill1IDIntParamChanged _MultiCastDel;

	public GSDel_PassiveSkill1IDIntParamChanged_ICB(Del_PassiveSkill1IDIntParamChanged InvokeCallBack, Action<Del_PassiveSkill1IDIntParamChanged> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

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
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_PassiveSkill1IDIntParamChanged_ICB operator +(GSDel_PassiveSkill1IDIntParamChanged_ICB GSEvent, Del_PassiveSkill1IDIntParamChanged Del)
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
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_PassiveSkill1IDIntParamChanged_ICB operator -(GSDel_PassiveSkill1IDIntParamChanged_ICB GSEvent, Del_PassiveSkill1IDIntParamChanged Del)
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
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int MainID, int OldVal, int NewVal)
	{
		_InvokeCallBack?.Invoke(MainID, OldVal, NewVal);
	}
}
