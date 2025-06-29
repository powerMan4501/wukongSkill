using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_RecoverAttackToken_ICB : IFreshAbleGSEvent
{
	private Del_RecoverAttackToken _InvokeCallBack;

	private Action<Del_RecoverAttackToken> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_RecoverAttackToken _MultiCastDel;

	public GSDel_RecoverAttackToken_ICB(Del_RecoverAttackToken InvokeCallBack, Action<Del_RecoverAttackToken> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_RecoverAttackToken)Delegate.Combine(_MultiCastDel, (Del_RecoverAttackToken)Del);
		}
		else
		{
			_MultiCastDel = (Del_RecoverAttackToken)Delegate.Remove(_MultiCastDel, (Del_RecoverAttackToken)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_RecoverAttackToken_ICB operator +(GSDel_RecoverAttackToken_ICB GSEvent, Del_RecoverAttackToken Del)
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
		GSEvent._MultiCastDel = (Del_RecoverAttackToken)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_RecoverAttackToken_ICB operator -(GSDel_RecoverAttackToken_ICB GSEvent, Del_RecoverAttackToken Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_RecoverAttackToken == Del)
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
		GSEvent._MultiCastDel = (Del_RecoverAttackToken)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(Entity Entity, ERecoverTokenReason RecoverTokenReason)
	{
		_InvokeCallBack?.Invoke(Entity, RecoverTokenReason);
	}
}
