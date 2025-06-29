using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;

namespace b1.EventDelDefine;

public class GSDel_AttachEquipCompToSocket_ICB : IFreshAbleGSEvent
{
	private Del_AttachEquipCompToSocket _InvokeCallBack;

	private Action<Del_AttachEquipCompToSocket> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_AttachEquipCompToSocket _MultiCastDel;

	public GSDel_AttachEquipCompToSocket_ICB(Del_AttachEquipCompToSocket InvokeCallBack, Action<Del_AttachEquipCompToSocket> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_AttachEquipCompToSocket)Delegate.Combine(_MultiCastDel, (Del_AttachEquipCompToSocket)Del);
		}
		else
		{
			_MultiCastDel = (Del_AttachEquipCompToSocket)Delegate.Remove(_MultiCastDel, (Del_AttachEquipCompToSocket)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_AttachEquipCompToSocket_ICB operator +(GSDel_AttachEquipCompToSocket_ICB GSEvent, Del_AttachEquipCompToSocket Del)
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
		GSEvent._MultiCastDel = (Del_AttachEquipCompToSocket)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_AttachEquipCompToSocket_ICB operator -(GSDel_AttachEquipCompToSocket_ICB GSEvent, Del_AttachEquipCompToSocket Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_AttachEquipCompToSocket == Del)
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
		GSEvent._MultiCastDel = (Del_AttachEquipCompToSocket)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EquipPosition EquipPosition, string SocketName, int InstanceID, int UniqueID)
	{
		_InvokeCallBack?.Invoke(EquipPosition, SocketName, InstanceID, UniqueID);
	}
}
