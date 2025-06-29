using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_AIPerceptionConfig_ICB : IFreshAbleGSEvent
{
	private Del_AIPerceptionConfig _InvokeCallBack;

	private Action<Del_AIPerceptionConfig> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_AIPerceptionConfig _MultiCastDel;

	public GSDel_AIPerceptionConfig_ICB(Del_AIPerceptionConfig InvokeCallBack, Action<Del_AIPerceptionConfig> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_AIPerceptionConfig)Delegate.Combine(_MultiCastDel, (Del_AIPerceptionConfig)Del);
		}
		else
		{
			_MultiCastDel = (Del_AIPerceptionConfig)Delegate.Remove(_MultiCastDel, (Del_AIPerceptionConfig)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_AIPerceptionConfig_ICB operator +(GSDel_AIPerceptionConfig_ICB GSEvent, Del_AIPerceptionConfig Del)
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
		GSEvent._MultiCastDel = (Del_AIPerceptionConfig)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_AIPerceptionConfig_ICB operator -(GSDel_AIPerceptionConfig_ICB GSEvent, Del_AIPerceptionConfig Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_AIPerceptionConfig == Del)
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
		GSEvent._MultiCastDel = (Del_AIPerceptionConfig)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(BGWDataAsset_AIPerceptionConfig Config)
	{
		_InvokeCallBack?.Invoke(Config);
	}
}
