using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_NotifyAssociationUnitActive_ICB : IFreshAbleGSEvent
{
	private Del_NotifyAssociationUnitActive _InvokeCallBack;

	private Action<Del_NotifyAssociationUnitActive> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_NotifyAssociationUnitActive _MultiCastDel;

	public GSDel_NotifyAssociationUnitActive_ICB(Del_NotifyAssociationUnitActive InvokeCallBack, Action<Del_NotifyAssociationUnitActive> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_NotifyAssociationUnitActive)Delegate.Combine(_MultiCastDel, (Del_NotifyAssociationUnitActive)Del);
		}
		else
		{
			_MultiCastDel = (Del_NotifyAssociationUnitActive)Delegate.Remove(_MultiCastDel, (Del_NotifyAssociationUnitActive)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_NotifyAssociationUnitActive_ICB operator +(GSDel_NotifyAssociationUnitActive_ICB GSEvent, Del_NotifyAssociationUnitActive Del)
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
		GSEvent._MultiCastDel = (Del_NotifyAssociationUnitActive)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_NotifyAssociationUnitActive_ICB operator -(GSDel_NotifyAssociationUnitActive_ICB GSEvent, Del_NotifyAssociationUnitActive Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_NotifyAssociationUnitActive == Del)
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
		GSEvent._MultiCastDel = (Del_NotifyAssociationUnitActive)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int ConfigID, string TargetGUID, int OnFightSkillID)
	{
		_InvokeCallBack?.Invoke(ConfigID, TargetGUID, OnFightSkillID);
	}
}
