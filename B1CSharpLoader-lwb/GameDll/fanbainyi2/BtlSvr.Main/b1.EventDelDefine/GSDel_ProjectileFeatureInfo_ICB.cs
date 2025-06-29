using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_ProjectileFeatureInfo_ICB : IFreshAbleGSEvent
{
	private Del_ProjectileFeatureInfo _InvokeCallBack;

	private Action<Del_ProjectileFeatureInfo> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ProjectileFeatureInfo _MultiCastDel;

	public GSDel_ProjectileFeatureInfo_ICB(Del_ProjectileFeatureInfo InvokeCallBack, Action<Del_ProjectileFeatureInfo> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ProjectileFeatureInfo)Delegate.Combine(_MultiCastDel, (Del_ProjectileFeatureInfo)Del);
		}
		else
		{
			_MultiCastDel = (Del_ProjectileFeatureInfo)Delegate.Remove(_MultiCastDel, (Del_ProjectileFeatureInfo)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_ProjectileFeatureInfo_ICB operator +(GSDel_ProjectileFeatureInfo_ICB GSEvent, Del_ProjectileFeatureInfo Del)
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
		GSEvent._MultiCastDel = (Del_ProjectileFeatureInfo)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_ProjectileFeatureInfo_ICB operator -(GSDel_ProjectileFeatureInfo_ICB GSEvent, Del_ProjectileFeatureInfo Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ProjectileFeatureInfo == Del)
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
		GSEvent._MultiCastDel = (Del_ProjectileFeatureInfo)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(bool ChargeLife, int HitNumMax, int HitNum)
	{
		_InvokeCallBack?.Invoke(ChargeLife, HitNumMax, HitNum);
	}
}
