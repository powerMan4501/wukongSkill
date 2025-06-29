using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_DisableTargetAttackIK_ICB : IFreshAbleGSEvent
{
	private Del_DisableTargetAttackIK _InvokeCallBack;

	private Action<Del_DisableTargetAttackIK> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_DisableTargetAttackIK _MultiCastDel;

	public GSDel_DisableTargetAttackIK_ICB(Del_DisableTargetAttackIK InvokeCallBack, Action<Del_DisableTargetAttackIK> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_DisableTargetAttackIK)Delegate.Combine(_MultiCastDel, (Del_DisableTargetAttackIK)Del);
		}
		else
		{
			_MultiCastDel = (Del_DisableTargetAttackIK)Delegate.Remove(_MultiCastDel, (Del_DisableTargetAttackIK)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_DisableTargetAttackIK_ICB operator +(GSDel_DisableTargetAttackIK_ICB GSEvent, Del_DisableTargetAttackIK Del)
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
		GSEvent._MultiCastDel = (Del_DisableTargetAttackIK)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_DisableTargetAttackIK_ICB operator -(GSDel_DisableTargetAttackIK_ICB GSEvent, Del_DisableTargetAttackIK Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_DisableTargetAttackIK == Del)
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
		GSEvent._MultiCastDel = (Del_DisableTargetAttackIK)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(bool enable)
	{
		_InvokeCallBack?.Invoke(enable);
	}
}
