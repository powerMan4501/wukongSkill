using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_RequestSetDBCEffectsPause_ICB : IFreshAbleGSEvent
{
	private Del_RequestSetDBCEffectsPause _InvokeCallBack;

	private Action<Del_RequestSetDBCEffectsPause> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_RequestSetDBCEffectsPause _MultiCastDel;

	public GSDel_RequestSetDBCEffectsPause_ICB(Del_RequestSetDBCEffectsPause InvokeCallBack, Action<Del_RequestSetDBCEffectsPause> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_RequestSetDBCEffectsPause)Delegate.Combine(_MultiCastDel, (Del_RequestSetDBCEffectsPause)Del);
		}
		else
		{
			_MultiCastDel = (Del_RequestSetDBCEffectsPause)Delegate.Remove(_MultiCastDel, (Del_RequestSetDBCEffectsPause)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_RequestSetDBCEffectsPause_ICB operator +(GSDel_RequestSetDBCEffectsPause_ICB GSEvent, Del_RequestSetDBCEffectsPause Del)
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
		GSEvent._MultiCastDel = (Del_RequestSetDBCEffectsPause)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_RequestSetDBCEffectsPause_ICB operator -(GSDel_RequestSetDBCEffectsPause_ICB GSEvent, Del_RequestSetDBCEffectsPause Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_RequestSetDBCEffectsPause == Del)
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
		GSEvent._MultiCastDel = (Del_RequestSetDBCEffectsPause)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(uint IdentityID, bool Pause, int PausePriority)
	{
		_InvokeCallBack?.Invoke(IdentityID, Pause, PausePriority);
	}
}
