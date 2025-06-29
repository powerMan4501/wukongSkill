using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_WakeUpPartnersInSameTeam_ICB : IFreshAbleGSEvent
{
	private Del_WakeUpPartnersInSameTeam _InvokeCallBack;

	private Action<Del_WakeUpPartnersInSameTeam> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_WakeUpPartnersInSameTeam _MultiCastDel;

	public GSDel_WakeUpPartnersInSameTeam_ICB(Del_WakeUpPartnersInSameTeam InvokeCallBack, Action<Del_WakeUpPartnersInSameTeam> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_WakeUpPartnersInSameTeam)Delegate.Combine(_MultiCastDel, (Del_WakeUpPartnersInSameTeam)Del);
		}
		else
		{
			_MultiCastDel = (Del_WakeUpPartnersInSameTeam)Delegate.Remove(_MultiCastDel, (Del_WakeUpPartnersInSameTeam)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_WakeUpPartnersInSameTeam_ICB operator +(GSDel_WakeUpPartnersInSameTeam_ICB GSEvent, Del_WakeUpPartnersInSameTeam Del)
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
		GSEvent._MultiCastDel = (Del_WakeUpPartnersInSameTeam)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_WakeUpPartnersInSameTeam_ICB operator -(GSDel_WakeUpPartnersInSameTeam_ICB GSEvent, Del_WakeUpPartnersInSameTeam Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_WakeUpPartnersInSameTeam == Del)
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
		GSEvent._MultiCastDel = (Del_WakeUpPartnersInSameTeam)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(HashSet<int> TeamIDList, AActor CatchedTarget)
	{
		_InvokeCallBack?.Invoke(TeamIDList, CatchedTarget);
	}
}
