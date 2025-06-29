using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_DashWallCheckBegin_ICB : IFreshAbleGSEvent
{
	private Del_DashWallCheckBegin _InvokeCallBack;

	private Action<Del_DashWallCheckBegin> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_DashWallCheckBegin _MultiCastDel;

	public GSDel_DashWallCheckBegin_ICB(Del_DashWallCheckBegin InvokeCallBack, Action<Del_DashWallCheckBegin> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_DashWallCheckBegin)Delegate.Combine(_MultiCastDel, (Del_DashWallCheckBegin)Del);
		}
		else
		{
			_MultiCastDel = (Del_DashWallCheckBegin)Delegate.Remove(_MultiCastDel, (Del_DashWallCheckBegin)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_DashWallCheckBegin_ICB operator +(GSDel_DashWallCheckBegin_ICB GSEvent, Del_DashWallCheckBegin Del)
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
		GSEvent._MultiCastDel = (Del_DashWallCheckBegin)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_DashWallCheckBegin_ICB operator -(GSDel_DashWallCheckBegin_ICB GSEvent, Del_DashWallCheckBegin Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_DashWallCheckBegin == Del)
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
		GSEvent._MultiCastDel = (Del_DashWallCheckBegin)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int NotifyID, TArrayReadWrite<FUStCheckShape> _CheckShapeList, TArrayReadWrite<EObjectTypeQuery> _ObjectTypeList, UAnimMontage HitWallStiffAM, string ValidTag)
	{
		_InvokeCallBack?.Invoke(NotifyID, _CheckShapeList, _ObjectTypeList, HitWallStiffAM, ValidTag);
	}
}
