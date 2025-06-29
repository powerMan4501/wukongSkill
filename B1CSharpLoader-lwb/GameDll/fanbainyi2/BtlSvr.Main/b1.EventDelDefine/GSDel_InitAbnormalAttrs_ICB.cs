using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_InitAbnormalAttrs_ICB : IFreshAbleGSEvent
{
	private Del_InitAbnormalAttrs _InvokeCallBack;

	private Action<Del_InitAbnormalAttrs> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_InitAbnormalAttrs _MultiCastDel;

	public GSDel_InitAbnormalAttrs_ICB(Del_InitAbnormalAttrs InvokeCallBack, Action<Del_InitAbnormalAttrs> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_InitAbnormalAttrs)Delegate.Combine(_MultiCastDel, (Del_InitAbnormalAttrs)Del);
		}
		else
		{
			_MultiCastDel = (Del_InitAbnormalAttrs)Delegate.Remove(_MultiCastDel, (Del_InitAbnormalAttrs)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_InitAbnormalAttrs_ICB operator +(GSDel_InitAbnormalAttrs_ICB GSEvent, Del_InitAbnormalAttrs Del)
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
		GSEvent._MultiCastDel = (Del_InitAbnormalAttrs)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_InitAbnormalAttrs_ICB operator -(GSDel_InitAbnormalAttrs_ICB GSEvent, Del_InitAbnormalAttrs Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_InitAbnormalAttrs == Del)
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
		GSEvent._MultiCastDel = (Del_InitAbnormalAttrs)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(BGWDataAsset_AbnormalAttrConfig AbnormalAttrConfig)
	{
		_InvokeCallBack?.Invoke(AbnormalAttrConfig);
	}
}
