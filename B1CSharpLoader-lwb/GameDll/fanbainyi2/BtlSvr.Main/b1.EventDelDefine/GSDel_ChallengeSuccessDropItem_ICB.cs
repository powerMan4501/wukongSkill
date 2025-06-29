using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_ChallengeSuccessDropItem_ICB : IFreshAbleGSEvent
{
	private Del_ChallengeSuccessDropItem _InvokeCallBack;

	private Action<Del_ChallengeSuccessDropItem> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ChallengeSuccessDropItem _MultiCastDel;

	public GSDel_ChallengeSuccessDropItem_ICB(Del_ChallengeSuccessDropItem InvokeCallBack, Action<Del_ChallengeSuccessDropItem> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ChallengeSuccessDropItem)Delegate.Combine(_MultiCastDel, (Del_ChallengeSuccessDropItem)Del);
		}
		else
		{
			_MultiCastDel = (Del_ChallengeSuccessDropItem)Delegate.Remove(_MultiCastDel, (Del_ChallengeSuccessDropItem)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_ChallengeSuccessDropItem_ICB operator +(GSDel_ChallengeSuccessDropItem_ICB GSEvent, Del_ChallengeSuccessDropItem Del)
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
		GSEvent._MultiCastDel = (Del_ChallengeSuccessDropItem)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_ChallengeSuccessDropItem_ICB operator -(GSDel_ChallengeSuccessDropItem_ICB GSEvent, Del_ChallengeSuccessDropItem Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ChallengeSuccessDropItem == Del)
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
		GSEvent._MultiCastDel = (Del_ChallengeSuccessDropItem)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor Player, int DropId)
	{
		_InvokeCallBack?.Invoke(Player, DropId);
	}
}
